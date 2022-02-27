using Microsoft.AspNetCore.Authorization;
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
    [Authorize(Roles = "SuperAdmin, Admin")]
    public class BrandController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public BrandController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            return View(_context.OurBrands.ToList());
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(OurBrand model)
        {

            if (model.BrandLogoFile != null)
            {
                if (model.BrandLogoFile.ContentType == "image/jpeg" || model.BrandLogoFile.ContentType == "image/png")
                {
                    if (model.BrandLogoFile.Length < 3000000)
                    {
                        string ImageName2 = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + model.BrandLogoFile.FileName;
                        string FilePath2 = Path.Combine(_webHostEnvironment.WebRootPath, "img", "brand", ImageName2);

                        using (var Stream = new FileStream(FilePath2, FileMode.Create))
                        {
                            model.BrandLogoFile.CopyTo(Stream);
                        }

                        model.BrandLogo = ImageName2;

                        _context.OurBrands.Add(model);
                        _context.SaveChanges();
                        return RedirectToAction("Index");

                    }
                    else
                    {
                        TempData["BrandError2"] = "The size of the Image file must be less than 3 MB";
                        return View(model);
                    }
                }
                else
                {
                    TempData["BrandError2"] = "The type of Image file can only be jpeg/jpg or png";
                    return View(model);
                }
            }
            else
            {
                TempData["BrandError2"] = "Image field must not be empty. Please choose a image";
                return View(model);
            }
        }

        public IActionResult Delete(int? Id)
        {
            if (Id != null)
            {
                OurBrand ourBrand = _context.OurBrands.Find(Id);
                if (ourBrand != null)
                {
                    if (!string.IsNullOrEmpty(ourBrand.BrandLogo))
                    {
                        string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "img", "brand", ourBrand.BrandLogo);
                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }
                    _context.OurBrands.Remove(ourBrand);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["BrandError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }

            }
            else
            {
                TempData["BannerError"] = "Id must not be null";
                return RedirectToAction("Index");
            }



        }
    }
}
