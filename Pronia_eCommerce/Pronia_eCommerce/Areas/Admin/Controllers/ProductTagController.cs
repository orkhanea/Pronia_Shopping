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
    public class ProductTagController : Controller
    {
        private readonly AppDbContext _context;

        public ProductTagController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.ProductTags.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductTag model)
        {
            if (ModelState.IsValid)
            {
                _context.ProductTags.Add(model);
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
                if (_context.ProductTags.Find(Id) != null)
                {
                    return View(_context.ProductTags.Find(Id));
                }
                else
                {
                    TempData["ProductTagError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["ProductTagError"] = "Id must not be null";
                return RedirectToAction("Index");
            }


        }

        [HttpPost]
        public IActionResult Update(ProductTag model)
        {
            if (ModelState.IsValid)
            {
                _context.ProductTags.Update(model);
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
                ProductTag productTag = _context.ProductTags.Find(Id);

                if (productTag != null)
                {
                    _context.ProductTags.Remove(productTag);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["ProductTagError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["ProductTagError"] = "Id must not be null";
                return RedirectToAction("Index");
            }
        }

    }
}
