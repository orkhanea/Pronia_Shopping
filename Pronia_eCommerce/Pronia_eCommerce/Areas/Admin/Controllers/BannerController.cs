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
    [Authorize(Roles = "SuperAdmin")]
    public class BannerController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnviroment;

        public BannerController(AppDbContext context, IWebHostEnvironment webHostEnviroment)
        {
            _context = context;
            _webHostEnviroment = webHostEnviroment;
        }
        public IActionResult Index()
        {
            return View(_context.Banners.ToList());
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Banner model)
        {
            if (ModelState.IsValid)
            {
                if (model.BgImageFile != null)
                {
                    if (model.BgImageFile.ContentType == "image/jpeg" || model.BgImageFile.ContentType == "image/png")
                    {
                        if (model.BgImageFile.Length < 3000000)
                        {
                            string ImageName2 = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + model.BgImageFile.FileName;
                            string FilePath2 = Path.Combine(_webHostEnviroment.WebRootPath, "img", "bg-image", ImageName2);

                            using (var Stream = new FileStream(FilePath2, FileMode.Create))
                            {
                                model.BgImageFile.CopyTo(Stream);
                            }

                            model.BgImage = ImageName2;

                            _context.Banners.Add(model);
                            _context.SaveChanges();
                            return RedirectToAction("Index");

                        }
                        else
                        {
                            TempData["BannerError"] = "The size of the Image file must be less than 3 MB";
                            return View(model);
                        }
                    }
                    else
                    {
                        TempData["BannerError"] = "The type of Image file can only be jpeg/jpg or png";
                        return View(model);
                    }
                }
                else
                {
                    TempData["BannerError"] = "Image field must not be empty. Please choose a image";
                    return View(model);
                }
            }

            return View(model);
        }

        public IActionResult Update(int? Id)
        {
            if (Id != null)
            {
                if (_context.Banners.Find(Id) != null)
                {
                    return View(_context.Banners.Find(Id));
                }
                else
                {
                    TempData["BannerError2"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["BannerError2"] = "Id must not be null";
                return RedirectToAction("Index");
            }


        }

        [HttpPost]
        public IActionResult Update(Banner model)
        {
            if (ModelState.IsValid)
            {
                if (model.BgImageFile != null)
                {
                    if (model.BgImageFile.ContentType == "image/jpeg" || model.BgImageFile.ContentType == "image/png")
                    {
                        if (model.BgImageFile.Length < 3000000)
                        {


                            if (!string.IsNullOrEmpty(model.BgImage))
                            {
                                string oldImagePath = Path.Combine(_webHostEnviroment.WebRootPath, "img", "bg-image", model.BgImage);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }


                            string ImageName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + model.BgImageFile.FileName;
                            string FilePath = Path.Combine(_webHostEnviroment.WebRootPath, "img", "bg-image", ImageName);

                            using (var Stream = new FileStream(FilePath, FileMode.Create))
                            {
                                model.BgImageFile.CopyTo(Stream);
                            }

                            model.BgImage = ImageName;

                        }
                        else
                        {
                            TempData["BannerError3"] = "The size of the Image file must be less than 3 MB";
                            return View(model);
                        }
                    }
                    else
                    {
                        TempData["BannerError3"] = "The type of Image file can only be jpeg/jpg or png";
                        return View(model);
                    }

                }

                _context.Banners.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }


        }

        public IActionResult Delete(int? Id)
        {
            if (Id != null)
            {
                Banner banner = _context.Banners.Find(Id);
                if (banner != null)
                {
                    if (!string.IsNullOrEmpty(banner.BgImage))
                    {
                        string oldImagePath = Path.Combine(_webHostEnviroment.WebRootPath, "img", "bg-image", banner.BgImage);
                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }
                    _context.Banners.Remove(banner);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["BannerError2"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }

            }
            else
            {
                TempData["BannerError2"] = "Id must not be null";
                return RedirectToAction("Index");
            }



        }
    }
}
