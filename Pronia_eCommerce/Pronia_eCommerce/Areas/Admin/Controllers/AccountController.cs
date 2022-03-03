using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pronia_eCommerce.Data;
using Pronia_eCommerce.Models;
using Pronia_eCommerce.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
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
            ViewBag.Roles = _context.Roles.Where(r=>r.Name!="User").ToList();
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

        [HttpPost]
        public IActionResult SiteUserUpdate(VmSiteUserProfile vmSiteUserProfile)
        {
            if (ModelState.IsValid)
            {
                SiteUser model = new();
                model = _context.SiteUsers.Find(vmSiteUserProfile.UserId);

                if (vmSiteUserProfile.SiteUser.ImageFile != null)
                {
                    if (vmSiteUserProfile.SiteUser.ImageFile.ContentType == "image/jpeg" || vmSiteUserProfile.SiteUser.ImageFile.ContentType == "image/png")
                    {
                        if (vmSiteUserProfile.SiteUser.ImageFile.Length < 3000000)
                        {


                            if (!string.IsNullOrEmpty(vmSiteUserProfile.SiteUser.Image))
                            {
                                string oldImagePath = Path.Combine(_webHostEnviroment.WebRootPath, "img", "user", vmSiteUserProfile.SiteUser.Image);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }


                            string ImageName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + vmSiteUserProfile.SiteUser.ImageFile.FileName;
                            string FilePath = Path.Combine(_webHostEnviroment.WebRootPath, "img", "user", ImageName);

                            using (var Stream = new FileStream(FilePath, FileMode.Create))
                            {
                                vmSiteUserProfile.SiteUser.ImageFile.CopyTo(Stream);
                            }

                            model.Image = ImageName;

                        }
                        else
                        {
                            TempData["SiteUserProfileError"] = "The size of the Image file must be less than 3 MB";
                            return RedirectToAction("Profile");
                        }
                    }
                    else
                    {
                        TempData["SiteUserProfileError"] = "The type of Image file can only be jpeg/jpg or png";
                        return RedirectToAction("Profile");
                    }

                }

                if (vmSiteUserProfile.SiteUser.BgImageFile != null)
                {
                    if (vmSiteUserProfile.SiteUser.BgImageFile.ContentType == "image/jpeg" || vmSiteUserProfile.SiteUser.BgImageFile.ContentType == "image/png")
                    {
                        if (vmSiteUserProfile.SiteUser.BgImageFile.Length < 3000000)
                        {


                            if (!string.IsNullOrEmpty(vmSiteUserProfile.SiteUser.BgImage))
                            {
                                string oldImagePath = Path.Combine(_webHostEnviroment.WebRootPath, "img", "userBgImage", vmSiteUserProfile.SiteUser.BgImage);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }


                            string ImageName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + vmSiteUserProfile.SiteUser.BgImageFile.FileName;
                            string FilePath = Path.Combine(_webHostEnviroment.WebRootPath, "img", "userBgImage", ImageName);

                            using (var Stream = new FileStream(FilePath, FileMode.Create))
                            {
                                vmSiteUserProfile.SiteUser.BgImageFile.CopyTo(Stream);
                            }

                            model.BgImage = ImageName;

                        }
                        else
                        {
                            TempData["SiteUserProfileError"] = "The size of the Image file must be less than 3 MB";
                            return RedirectToAction("Profile");
                        }
                    }
                    else
                    {
                        TempData["SiteUserProfileError"] = "The type of Image file can only be jpeg/jpg or png";
                        return RedirectToAction("Profile");
                    }

                }

                model.Name = vmSiteUserProfile.SiteUser.Name;
                model.Surname = vmSiteUserProfile.SiteUser.Surname;
                model.PhoneNumber = vmSiteUserProfile.SiteUser.PhoneNumber;
                model.BDate = vmSiteUserProfile.SiteUser.BDate;
                model.UserInfo = vmSiteUserProfile.SiteUser.UserInfo;
                model.UserInfo = vmSiteUserProfile.SiteUser.UserInfo;

                _context.SiteUsers.Update(model);
                _context.SaveChanges();

                return RedirectToAction("Profile");

            }
            else
            {
                return RedirectToAction("Profile");

            }




           
        }

    }
}
