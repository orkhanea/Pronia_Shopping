using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pronia_eCommerce.Data;
using Pronia_eCommerce.Models;
using Pronia_eCommerce.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.Controllers
{
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

        public IActionResult Index()
        {

            VmRegister model = new();
            model.Setting = _context.Setting.FirstOrDefault();
            model.SiteSocial = _context.SiteSocials.ToList();
            model.Countries = _context.Countries.ToList();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Register(VmRegister model)
        {
            if (ModelState.IsValid)
            {
                EndUser newUser = new()
                {
                    Name = model.Name,
                    Surname = model.Surname,
                    UserName = model.UserName,
                    Email = model.Email,
                    CreatedDate = DateTime.Now,
                    CountryId = model.CountryId


                };

                var result = await _userManager.CreateAsync(newUser, model.Password);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(newUser, false);

                    TempData["isCreated"] = true;

                    return RedirectToAction("Profile");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }

                    return RedirectToAction("Index", model);
                }
            }
            else
            {
                TempData["UserErrorIndex"] = "Empty field detected!";
                return RedirectToAction("Index");
            }

            
        }

        public IActionResult Profile()
        {
            if (_signInManager.IsSignedIn(User))
            {
                if (_context.EndUsers.Find(_userManager.GetUserId(User))!=null)
                {
                    VmEndUser model = new();
                    model.Setting = _context.Setting.FirstOrDefault();
                    model.SiteSocial = _context.SiteSocials.ToList();
                    model.EndUser = _context.EndUsers.Find(_userManager.GetUserId(User));
                    model.Countries = _context.Countries.ToList();
                    return View(model);
                }
                else
                {
                    return RedirectToAction("Index");
                }

            }
            else
            {
                return RedirectToAction("Index");
            }

            
            
        }

        [HttpPost]
        public IActionResult Update(VmEndUser VmEndUser)
        {
            if (ModelState.IsValid)
            {

                if (_context.EndUsers.Find(VmEndUser.EndUser.Id)!=null)
                {
                    EndUser endUser = _context.EndUsers.Find(VmEndUser.EndUser.Id);
                    endUser.Name = VmEndUser.EndUser.Name;
                    endUser.Surname = VmEndUser.EndUser.Surname;
                    endUser.CountryId = VmEndUser.EndUser.CountryId;
                    endUser.BillingAddress = VmEndUser.EndUser.BillingAddress;
                    endUser.ShippingAddress = VmEndUser.EndUser.ShippingAddress;
                    endUser.PhoneNumber = VmEndUser.EndUser.PhoneNumber;
                    endUser.UserName = VmEndUser.EndUser.UserName;

                    if (VmEndUser.EndUser.ImageFile != null)
                    {
                        if (VmEndUser.EndUser.ImageFile.ContentType == "image/jpeg" || VmEndUser.EndUser.ImageFile.ContentType == "image/png")
                        {
                            if (VmEndUser.EndUser.ImageFile.Length < 3000000)
                            {


                                if (!string.IsNullOrEmpty(VmEndUser.EndUser.Image))
                                {
                                    string oldImagePath = Path.Combine(_webHostEnviroment.WebRootPath, "assets", "images", VmEndUser.EndUser.Image);
                                    if (System.IO.File.Exists(oldImagePath))
                                    {
                                        System.IO.File.Delete(oldImagePath);
                                    }
                                }


                                string ImageName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + VmEndUser.EndUser.ImageFile.FileName;
                                string FilePath = Path.Combine(_webHostEnviroment.WebRootPath, "img", "user", ImageName);

                                using (var Stream = new FileStream(FilePath, FileMode.Create))
                                {
                                    VmEndUser.EndUser.ImageFile.CopyTo(Stream);
                                }

                                endUser.Image = ImageName;

                            }
                            else
                            {
                                TempData["UserError"] = "The size of the Image file must be less than 3 MB";
                                return RedirectToAction("Profile");
                            }
                        }
                        else
                        {
                            TempData["UserError"] = "The type of Image file can only be jpeg/jpg or png";
                            return RedirectToAction("Profile");
                        }

                    }

                    TempData["Succes"] = "True";
                    _context.SaveChanges();
                    return RedirectToAction("Profile");

                }
                else
                {
                    TempData["UserError"] = "Error";
                    return RedirectToAction("Profile");
                }
                
            }
            else
            {

                TempData["UserError"] = "ModelStateNoValid";
                return RedirectToAction("Profile");
            }
        }


        [HttpPost]
        public async Task<IActionResult> Login(VmRegister vmRegister)
        {
            

            if (vmRegister.VmLogin.UserName != null && vmRegister.VmLogin.Password!=null)
            {

                var result = await _signInManager.PasswordSignInAsync(vmRegister.VmLogin.UserName, vmRegister.VmLogin.Password, false, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Profile");
                }
                else
                {
                    TempData["LoginError"] = "Email address or password is incorrect!";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["LoginError"] = "Fill out all of the required fields correctly!";

                return RedirectToAction("Index");

            }

        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}
