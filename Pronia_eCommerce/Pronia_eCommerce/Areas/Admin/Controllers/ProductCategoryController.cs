using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pronia_eCommerce.Data;
using Pronia_eCommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin, Admin")]
    public class ProductCategoryController : Controller
    {
        private readonly AppDbContext _context;

        public ProductCategoryController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.ProductCats.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductCat model)
        {
            if (ModelState.IsValid)
            {
                _context.ProductCats.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

        public IActionResult Update(int? Id)
        {
            if (Id != null)
            {
                if (_context.ProductCats.Find(Id) != null)
                {
                    return View(_context.ProductCats.Find(Id));
                }
                else
                {
                    TempData["ProductCategoryError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["ProductCategoryError"] = "Id must not be null";
                return RedirectToAction("Index");
            }


        }

        [HttpPost]
        public IActionResult Update(ProductCat model)
        {
            if (ModelState.IsValid)
            {
                _context.ProductCats.Update(model);
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
                ProductCat productCat = _context.ProductCats.Find(Id);

                if (productCat != null)
                {
                    _context.ProductCats.Remove(productCat);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["ProductCategoryError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["ProductCategoryError"] = "Id must not be null";
                return RedirectToAction("Index");
            }
        }
    }
}
