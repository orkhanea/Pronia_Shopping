using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Pronia_eCommerce.Data;
using Pronia_eCommerce.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SiteSettingController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnviroment;

        public SiteSettingController(AppDbContext context, IWebHostEnvironment webHostEnviroment)
        {
            _context = context;
            _webHostEnviroment = webHostEnviroment;
        }
        public IActionResult Index()
        {

            return View(_context.Setting.FirstOrDefault());
        }

        public IActionResult Update()
        {


            return View(_context.Setting.FirstOrDefault());
        }

        [HttpPost]
        public IActionResult Update(Setting model)
        {
            if (ModelState.IsValid)
            {

                if (model.LogoFile != null)
                {
                    if (model.LogoFile.ContentType == "image/jpeg" || model.LogoFile.ContentType == "image/png")
                    {
                        if (model.LogoFile.Length < 3000000)
                        {


                            if (!string.IsNullOrEmpty(model.Logo))
                            {
                                string oldImagePath = Path.Combine(_webHostEnviroment.WebRootPath, "img", "logo", model.Logo);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }


                            string ImageName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + model.LogoFile.FileName;
                            string FilePath = Path.Combine(_webHostEnviroment.WebRootPath, "img", "logo", ImageName);

                            using (var Stream = new FileStream(FilePath, FileMode.Create))
                            {
                                model.LogoFile.CopyTo(Stream);
                            }

                            model.Logo = ImageName;
                        }
                        else
                        {
                            TempData["SettingError"] = "The size of the Logo Image file must be less than 3 MB";
                            return View(model);
                        }
                    }
                    else
                    {
                        TempData["SettingError"] = "The type of Logo Image file can only be jpeg/jpg or png";
                        return View(model);
                    }
                }
                if (model.FooterBgImageFile != null)
                {
                    if (model.FooterBgImageFile.ContentType == "image/jpeg" || model.FooterBgImageFile.ContentType == "image/png")
                    {
                        if (model.FooterBgImageFile.Length < 3000000)
                        {


                            if (!string.IsNullOrEmpty(model.FooterBgImage))
                            {
                                string oldImagePath = Path.Combine(_webHostEnviroment.WebRootPath, "img", "bg-image", model.FooterBgImage);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }


                            string ImageName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + model.FooterBgImageFile.FileName;
                            string FilePath = Path.Combine(_webHostEnviroment.WebRootPath, "img", "bg-image", ImageName);

                            using (var Stream = new FileStream(FilePath, FileMode.Create))
                            {
                                model.FooterBgImageFile.CopyTo(Stream);
                            }

                            model.FooterBgImage = ImageName;
                        }
                        else
                        {
                            TempData["SettingError"] = "The size of the Home Page Image file must be less than 3 MB";
                            return View(model);
                        }
                    }
                    else
                    {
                        TempData["SettingError"] = "The type of Home Page Image file can only be jpeg/jpg or png";
                        return View(model);
                    }
                }

                _context.Setting.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }

    }
}
