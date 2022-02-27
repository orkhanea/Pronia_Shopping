using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pronia_eCommerce.Data;
using Pronia_eCommerce.Models;
using Pronia_eCommerce.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IWebHostEnvironment _webHostEnviroment;

        public AccountController(AppDbContext context, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, RoleManager<IdentityRole> roleManager, IWebHostEnvironment webHostEnviroment)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _webHostEnviroment = webHostEnviroment;
        }

        [Authorize(Roles = "SuperAdmin")]
        public IActionResult Index()
        {
            ViewBag.Roles = _context.Roles.ToList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(VmSiteRegister vmSiteRegister)
        {
            if (ModelState.IsValid)
            {
                IdentityRole identityRole = _context.Roles.Find(vmSiteRegister.RoleId);
                if (identityRole != null)
                {
                    SiteUser newUser = new()
                    {
                        Name = vmSiteRegister.Name,
                        Surname = vmSiteRegister.Surname,
                        UserName = vmSiteRegister.Email,
                        Email = vmSiteRegister.Email,
                        CreatedDate = DateTime.Now

                    };

                    var result = await _userManager.CreateAsync(newUser, vmSiteRegister.Password);
                    await _context.SaveChangesAsync();
                    await _userManager.AddToRoleAsync(newUser, identityRole.Name);


                    if (result.Succeeded)
                    {
                        //await _signInManager.SignInAsync(newUser, false);
                        return RedirectToAction("Index", "Sale");
                    }
                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }

                        ViewBag.Roles = _context.Roles.ToList();
                        return View(vmSiteRegister);
                    }

                }
                else
                {
                    ViewBag.Roles = _context.Roles.ToList();
                    ModelState.AddModelError("", "");
                    return View(vmSiteRegister);
                }



                
            }

            ViewBag.Roles = _context.Roles.ToList();
            return View(vmSiteRegister);
        }

        [Authorize(Roles = "SuperAdmin")]
        public IActionResult Roles()
        {
            List<IdentityRole> roles = _context.Roles.ToList();

            return View(roles);
        }

        [Authorize(Roles = "SuperAdmin")]
        public IActionResult RoleCreate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RoleCreate(IdentityRole model)
        {
            if (ModelState.IsValid)
            {
                await _roleManager.CreateAsync(model);
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Upps..");
            return View(model);
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                if (User.IsInRole("User"))
                {
                    return RedirectToAction("Index", "Home", new { area = "" });
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(VmSiteLogin vmSiteLogin)
        {
            if (ModelState.IsValid)
            {

                var result = await _signInManager.PasswordSignInAsync(vmSiteLogin.Email, vmSiteLogin.Password, true, false);

                if (result.Succeeded)
                {

                    var user = await _userManager.FindByEmailAsync(vmSiteLogin.Email);

                    if (user!=null)
                    {
                        if (await _userManager.IsInRoleAsync(user, "User"))
                        {
                            TempData["SiteLoginRoleError"] = "You dont have permission to access!";
                            return RedirectToAction("Logout");
                        }
                        else
                        {

                            return RedirectToAction("Index", "Home");
                        }
                    }
                    else
                    {
                        TempData["SiteLoginError"] = "Email address or password is incorrect!";
                        return RedirectToAction("Login");
                    }

                    


                }
                else
                {
                    TempData["SiteLoginError"] = "Email address or password is incorrect!";
                    return RedirectToAction("Login");
                }


            }
            else
            {
                return View(vmSiteLogin);
            }

           
        }

        [Authorize(Roles = "SuperAdmin, Moderator, Admin")]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Login");

        }

        public IActionResult Profile()
        {
            VmSiteUserProfile model = new();
            model.SiteUser = _context.SiteUsers.Find(_userManager.GetUserId(User));

            return View(model);
        }

        public IActionResult SiteUserUpdate(VmSiteUserProfile vmSiteUserProfile)
        {
            if (ModelState.IsValid)
            {
                SiteUser model = new();
            }




            return View();
        }

    }
}
