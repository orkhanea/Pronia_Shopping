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
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ContactController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {

            return View(_context.ContactUs.FirstOrDefault());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ContactUs model)
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
                            string FilePath2 = Path.Combine(_webHostEnvironment.WebRootPath, "img", "bg-image", ImageName2);

                            using (var Stream = new FileStream(FilePath2, FileMode.Create))
                            {
                                model.BgImageFile.CopyTo(Stream);
                            }

                            model.BgImage = ImageName2;

                            _context.ContactUs.Add(model);
                            _context.SaveChanges();
                            return RedirectToAction("Index");

                        }
                        else
                        {
                            TempData["ContactError"] = "The size of the Image file must be less than 3 MB";
                            return View(model);
                        }
                    }
                    else
                    {
                        TempData["ContactError"] = "The type of Image file can only be jpeg/jpg or png";
                        return View(model);
                    }
                }
                else
                {
                    TempData["ContactError"] = "Image field must not be empty. Please choose a image";
                    return View(model);
                }
            }
            else
            {
                return View(model);
            }

        }

        public IActionResult Update()
        {
            return View(_context.ContactUs.FirstOrDefault());
        }

        [HttpPost]
        public IActionResult Update(ContactUs model)
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
                                string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "img", "bg-image", model.BgImage);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }


                            string ImageName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + model.BgImageFile.FileName;
                            string FilePath = Path.Combine(_webHostEnvironment.WebRootPath, "img", "bg-image", ImageName);

                            using (var Stream = new FileStream(FilePath, FileMode.Create))
                            {
                                model.BgImageFile.CopyTo(Stream);
                            }

                            model.BgImage = ImageName;

                        }
                        else
                        {
                            TempData["ContactError2"] = "The size of the Image file must be less than 3 MB";
                            return View(model);
                        }
                    }
                    else
                    {
                        TempData["ContactError2"] = "The type of Image file can only be jpeg/jpg or png";
                        return View(model);
                    }

                }

                _context.ContactUs.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }

        }

        public IActionResult Delete()
        {
            if (!string.IsNullOrEmpty(_context.ContactUs.FirstOrDefault().BgImage))
            {
                string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "img", "bg-image", _context.ContactUs.FirstOrDefault().BgImage);
                if (System.IO.File.Exists(oldImagePath))
                {
                    System.IO.File.Delete(oldImagePath);
                }
            }

            _context.ContactUs.Remove(_context.ContactUs.FirstOrDefault());
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
