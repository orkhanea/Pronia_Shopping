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
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnviroment;

        public AboutController(AppDbContext context, IWebHostEnvironment webHostEnviroment)
        {
            _context = context;
            _webHostEnviroment = webHostEnviroment;
        }

        public IActionResult Index()
        {

            return View(_context.About.FirstOrDefault());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(About model)
        {
            if (ModelState.IsValid)
            {
                if (model.SignatureFile != null)
                {
                    if (model.SignatureFile.ContentType == "image/jpeg" || model.SignatureFile.ContentType == "image/png")
                    {
                        if (model.SignatureFile.Length < 3000000)
                        {
                            string ImageName2 = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + model.SignatureFile.FileName;
                            string FilePath2 = Path.Combine(_webHostEnviroment.WebRootPath, "img", "uncategorized", ImageName2);

                            using (var Stream = new FileStream(FilePath2, FileMode.Create))
                            {
                                model.SignatureFile.CopyTo(Stream);
                            }

                            model.Signature = ImageName2;

                            _context.About.Add(model);
                            _context.SaveChanges();
                            return RedirectToAction("Index");

                        }
                        else
                        {
                            TempData["AboutError"] = "The size of the Image file must be less than 3 MB";
                            return View(model);
                        }
                    }
                    else
                    {
                        TempData["AboutError"] = "The type of Image file can only be jpeg/jpg or png";
                        return View(model);
                    }
                }
                else
                {
                    TempData["AboutError"] = "Image field must not be empty. Please choose a image";
                    return View(model);
                }
            }

            return View(model);
        }

        public IActionResult Update()
        {
            return View(_context.About.FirstOrDefault());
        }

        [HttpPost]
        public IActionResult Update(About model)
        {
            if (ModelState.IsValid)
            {
                if (model.SignatureFile != null)
                {
                    if (model.SignatureFile.ContentType == "image/jpeg" || model.SignatureFile.ContentType == "image/png")
                    {
                        if (model.SignatureFile.Length < 3000000)
                        {


                            if (!string.IsNullOrEmpty(model.Signature))
                            {
                                string oldImagePath = Path.Combine(_webHostEnviroment.WebRootPath, "img", "uncategorized", model.Signature);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }


                            string ImageName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + model.SignatureFile.FileName;
                            string FilePath = Path.Combine(_webHostEnviroment.WebRootPath, "img", "uncategorized", ImageName);

                            using (var Stream = new FileStream(FilePath, FileMode.Create))
                            {
                                model.SignatureFile.CopyTo(Stream);
                            }

                            model.Signature = ImageName;

                        }
                        else
                        {
                            TempData["AboutError2"] = "The size of the Image file must be less than 3 MB";
                            return View(model);
                        }
                    }
                    else
                    {
                        TempData["AboutError2"] = "The type of Image file can only be jpeg/jpg or png";
                        return View(model);
                    }

                }

                _context.About.Update(model);
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
            if (!string.IsNullOrEmpty(_context.About.FirstOrDefault().Signature))
            {
                string oldImagePath = Path.Combine(_webHostEnviroment.WebRootPath, "img", "uncategorized", _context.About.FirstOrDefault().Signature);
                if (System.IO.File.Exists(oldImagePath))
                {
                    System.IO.File.Delete(oldImagePath);
                }
            }

            _context.About.Remove(_context.About.FirstOrDefault());
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
