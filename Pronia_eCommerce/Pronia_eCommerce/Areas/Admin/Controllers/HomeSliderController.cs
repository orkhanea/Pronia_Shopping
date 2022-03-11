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
    [Authorize(Roles ="SuperAdmin")]
    public class HomeSliderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public HomeSliderController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View(_context.HomeSliders.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(HomeSlider homeSlider)
        {
            if (ModelState.IsValid)
            {
                if (homeSlider.ImageFile != null)
                {
                    if (homeSlider.ImageFile.ContentType == "image/jpeg" || homeSlider.ImageFile.ContentType == "image/png")
                    {
                        if (homeSlider.ImageFile.Length < 3000000)
                        {
                            string ImageName2 = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + homeSlider.ImageFile.FileName;
                            string FilePath2 = Path.Combine(_webHostEnvironment.WebRootPath, "img", "slider", ImageName2);

                            using (var Stream = new FileStream(FilePath2, FileMode.Create))
                            {
                                homeSlider.ImageFile.CopyTo(Stream);
                            }

                            homeSlider.Image = ImageName2;

                            _context.HomeSliders.Add(homeSlider);
                            _context.SaveChanges();
                            return RedirectToAction("Index");

                        }
                        else
                        {
                            TempData["HomeSliderError2"] = "The size of the Image file must be less than 3 MB";
                            return View(homeSlider);
                        }
                    }
                    else
                    {
                        TempData["HomeSliderError2"] = "The type of Image file can only be jpeg/jpg or png";
                        return View(homeSlider);
                    }
                }
                else
                {
                    TempData["HomeSliderError2"] = "Image field must not be empty. Please choose a image";
                    return View(homeSlider);
                }
            }

            return View(homeSlider);
        }


        public IActionResult Update(int? Id)
        {
            if (Id!=null)
            {
                if (_context.HomeSliders.Find(Id)!=null)
                {
                    return View(_context.HomeSliders.Find(Id));
                }
                else
                {
                    TempData["HomeSliderError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["HomeSliderError"] = "Id must not be null";
                return RedirectToAction("Index");
            }

        }

        [HttpPost]
        public IActionResult Update(HomeSlider model)
        {
            if (ModelState.IsValid)
            {
                if (model.ImageFile != null)
                {
                    if (model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/png")
                    {
                        if (model.ImageFile.Length < 3000000)
                        {


                            if (!string.IsNullOrEmpty(model.Image))
                            {
                                string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "img", "slider", model.Image);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }


                            string ImageName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + model.ImageFile.FileName;
                            string FilePath = Path.Combine(_webHostEnvironment.WebRootPath, "img", "slider", ImageName);

                            using (var Stream = new FileStream(FilePath, FileMode.Create))
                            {
                                model.ImageFile.CopyTo(Stream);
                            }

                            model.Image = ImageName;

                        }
                        else
                        {
                            TempData["HomeSliderError3"] = "The size of the Image file must be less than 3 MB";
                            return View(model);
                        }
                    }
                    else
                    {
                        TempData["HomeSliderError3"] = "The type of Image file can only be jpeg/jpg or png";
                        return View(model);
                    }

                }

                _context.HomeSliders.Update(model);
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
                HomeSlider model = _context.HomeSliders.Find(Id);
                if (model != null)
                {
                    if (!string.IsNullOrEmpty(model.Image))
                    {
                        string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "img", "slider", model.Image);
                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }
                    _context.HomeSliders.Remove(model);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["HomeSliderError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }

            }
            else
            {
                TempData["HomeSliderError"] = "Id must not be null";
                return RedirectToAction("Index");
            }



        }
    }
    
}
