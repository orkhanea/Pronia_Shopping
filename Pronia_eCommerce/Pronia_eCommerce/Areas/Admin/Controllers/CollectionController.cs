using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
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

namespace Pronia_eCommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin, Admin")]
    public class CollectionController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public CollectionController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            VmCollection model = new();
            model.CollectionL = _context.CollectionL.Include(c=>c.ProductCat).ToList();
            model.CollectionS = _context.CollectionS.Include(c => c.ProductCat).ToList();

            return View(model);
        }

        public IActionResult CreateL()
        {

            ViewBag.ProdCatColL = _context.ProductCats.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult CreateL(CollectionL collectionL)
        {
            if (_context.CollectionL.Count()<2)
            {
                if (ModelState.IsValid)
                {
                    if (collectionL.ImageFile != null)
                    {
                        if (collectionL.ImageFile.ContentType == "image/jpeg" || collectionL.ImageFile.ContentType == "image/png")
                        {
                            if (collectionL.ImageFile.Length < 3000000)
                            {
                                if (collectionL.ProductCatId!=null &&_context.ProductCats.Find(collectionL.ProductCatId)!=null)
                                {
                                    string ImageName2 = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + collectionL.ImageFile.FileName;
                                    string FilePath2 = Path.Combine(_webHostEnvironment.WebRootPath, "img", "collection", ImageName2);

                                    using (var Stream = new FileStream(FilePath2, FileMode.Create))
                                    {
                                        collectionL.ImageFile.CopyTo(Stream);
                                    }

                                    collectionL.Image = ImageName2;

                                    _context.CollectionL.Add(collectionL);
                                    _context.SaveChanges();
                                    return RedirectToAction("Index");
                                }
                                else
                                {
                                    TempData["CollectionError2"] = "Please choose category!";
                                    ViewBag.ProdCatColL = _context.ProductCats.ToList();
                                    return View(collectionL);
                                }

                            }
                            else
                            {
                                TempData["CollectionError2"] = "The size of the Image file must be less than 3 MB";
                                ViewBag.ProdCatColL = _context.ProductCats.ToList();
                                return View(collectionL);
                            }
                        }
                        else
                        {
                            TempData["CollectionError2"] = "The type of Image file can only be jpeg/jpg or png";
                            ViewBag.ProdCatColL = _context.ProductCats.ToList();
                            return View(collectionL);
                        }
                    }
                    else
                    {
                        TempData["CollectionError2"] = "Image field must not be empty. Please choose a image";
                        ViewBag.ProdCatColL = _context.ProductCats.ToList();
                        return View(collectionL);
                    }
                }
                ViewBag.ProdCatColL = _context.ProductCats.ToList();
                return View(collectionL);
            }
            else
            {
                TempData["CollectionError2"] = "You reach the limit of Collection Large";
                ViewBag.ProdCatColL = _context.ProductCats.ToList();
                return View(collectionL);
            }
        }

        public IActionResult CreateS()
        {
            ViewBag.ProdCatColL = _context.ProductCats.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult CreateS(CollectionS collectionS)
        {
            if (_context.CollectionS.Count() < 2)
            {
                if (ModelState.IsValid)
                {
                    if (collectionS.ImageFile != null)
                    {
                        if (collectionS.ImageFile.ContentType == "image/jpeg" || collectionS.ImageFile.ContentType == "image/png")
                        {
                            if (collectionS.ImageFile.Length < 3000000)
                            {
                                if (collectionS.ProductCatId != null && _context.ProductCats.Find(collectionS.ProductCatId) != null)
                                {
                                    string ImageName2 = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + collectionS.ImageFile.FileName;
                                    string FilePath2 = Path.Combine(_webHostEnvironment.WebRootPath, "img", "collection", ImageName2);

                                    using (var Stream = new FileStream(FilePath2, FileMode.Create))
                                    {
                                        collectionS.ImageFile.CopyTo(Stream);
                                    }

                                    collectionS.Image = ImageName2;

                                    _context.CollectionS.Add(collectionS);
                                    _context.SaveChanges();
                                    return RedirectToAction("Index");
                                }
                                else
                                {
                                    TempData["CollectionError2"] = "Please choose category!";
                                    ViewBag.ProdCatColL = _context.ProductCats.ToList();
                                    return View(collectionS);
                                }

                            }
                            else
                            {
                                TempData["CollectionError2"] = "The size of the Image file must be less than 3 MB";
                                ViewBag.ProdCatColL = _context.ProductCats.ToList();
                                return View(collectionS);
                            }
                        }
                        else
                        {
                            TempData["CollectionError2"] = "The type of Image file can only be jpeg/jpg or png";
                            ViewBag.ProdCatColL = _context.ProductCats.ToList();
                            return View(collectionS);
                        }
                    }
                    else
                    {
                        TempData["CollectionError2"] = "Image field must not be empty. Please choose a image";
                        ViewBag.ProdCatColL = _context.ProductCats.ToList();
                        return View(collectionS);
                    }
                }
                ViewBag.ProdCatColL = _context.ProductCats.ToList();
                return View(collectionS);
            }
            else
            {
                TempData["CollectionError2"] = "You reach the limit of Collection Large";
                ViewBag.ProdCatColL = _context.ProductCats.ToList();
                return View(collectionS);
            }
        }

        public IActionResult UpdateL(int? Id)
        {

            if (Id != null)
            {
                if (_context.CollectionL.Find(Id) != null)
                {
                    ViewBag.ProdCatColL = _context.ProductCats.ToList();
                    return View(_context.CollectionL.Find(Id));
                }
                else
                {
                    TempData["CollectionError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["CollectionError"] = "Id must not be null";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult UpdateL(CollectionL collectionL)
        {
            if (ModelState.IsValid)
            {
                if (collectionL.ImageFile != null)
                {
                    if (collectionL.ImageFile.ContentType == "image/jpeg" || collectionL.ImageFile.ContentType == "image/png")
                    {
                        if (collectionL.ImageFile.Length < 3000000)
                        {


                            if (!string.IsNullOrEmpty(collectionL.Image))
                            {
                                string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "img", "collection", collectionL.Image);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }


                            string ImageName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + collectionL.ImageFile.FileName;
                            string FilePath = Path.Combine(_webHostEnvironment.WebRootPath, "img", "collection", ImageName);

                            using (var Stream = new FileStream(FilePath, FileMode.Create))
                            {
                                collectionL.ImageFile.CopyTo(Stream);
                            }

                            collectionL.Image = ImageName;

                        }
                        else
                        {
                            TempData["CollectionError3"] = "The size of the Image file must be less than 3 MB";
                            ViewBag.ProdCatColL = _context.ProductCats.ToList();
                            return View(collectionL);
                        }
                    }
                    else
                    {
                        TempData["CollectionError3"] = "The type of Image file can only be jpeg/jpg or png";
                        ViewBag.ProdCatColL = _context.ProductCats.ToList();
                        return View(collectionL);
                    }

                }

                _context.CollectionL.Update(collectionL);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.ProdCatColL = _context.ProductCats.ToList();
                return View(collectionL);
            }
        }

        public IActionResult UpdateS(int? Id)
        {

            if (Id != null)
            {
                if (_context.CollectionS.Find(Id) != null)
                {
                    ViewBag.ProdCatColL = _context.ProductCats.ToList();
                    return View(_context.CollectionS.Find(Id));
                }
                else
                {
                    TempData["CollectionError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["CollectionError"] = "Id must not be null";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult UpdateS(CollectionS collectionS)
        {
            if (ModelState.IsValid)
            {
                if (collectionS.ImageFile != null)
                {
                    if (collectionS.ImageFile.ContentType == "image/jpeg" || collectionS.ImageFile.ContentType == "image/png")
                    {
                        if (collectionS.ImageFile.Length < 3000000)
                        {


                            if (!string.IsNullOrEmpty(collectionS.Image))
                            {
                                string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "img", "collection", collectionS.Image);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }


                            string ImageName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + collectionS.ImageFile.FileName;
                            string FilePath = Path.Combine(_webHostEnvironment.WebRootPath, "img", "collection", ImageName);

                            using (var Stream = new FileStream(FilePath, FileMode.Create))
                            {
                                collectionS.ImageFile.CopyTo(Stream);
                            }

                            collectionS.Image = ImageName;

                        }
                        else
                        {
                            TempData["CollectionError3"] = "The size of the Image file must be less than 3 MB";
                            ViewBag.ProdCatColL = _context.ProductCats.ToList();
                            return View(collectionS);
                        }
                    }
                    else
                    {
                        TempData["CollectionError3"] = "The type of Image file can only be jpeg/jpg or png";
                        ViewBag.ProdCatColL = _context.ProductCats.ToList();
                        return View(collectionS);
                    }

                }

                _context.CollectionS.Update(collectionS);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.ProdCatColL = _context.ProductCats.ToList();
                return View(collectionS);
            }
        }

        public IActionResult DeleteL(int? Id)
        {
            if (Id != null)
            {
                CollectionL collectionL = _context.CollectionL.Find(Id);
                if (collectionL != null)
                {
                    if (!string.IsNullOrEmpty(collectionL.Image))
                    {
                        string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "img", "collection", collectionL.Image);
                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }
                    _context.CollectionL.Remove(collectionL);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["CollectionError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["CollectionError"] = "Id must not be null";
                return RedirectToAction("Index");
            }
        }

        public IActionResult DeleteS(int? Id)
        {
            if (Id != null)
            {
                CollectionS collectionS = _context.CollectionS.Find(Id);
                if (collectionS != null)
                {
                    if (!string.IsNullOrEmpty(collectionS.Image))
                    {
                        string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "img", "collection", collectionS.Image);
                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }
                    _context.CollectionS.Remove(collectionS);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["CollectionError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["CollectionError"] = "Id must not be null";
                return RedirectToAction("Index");
            }
        }
    }
}
