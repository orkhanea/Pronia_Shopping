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
    public class BlogCategoryController : Controller
    {
        private readonly AppDbContext _context;

        public BlogCategoryController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.BlogCategories.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BlogCategory model)
        {
            if (ModelState.IsValid)
            {
                _context.BlogCategories.Add(model);
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
                if (_context.BlogCategories.Find(Id) != null)
                {
                    return View(_context.BlogCategories.Find(Id));
                }
                else
                {
                    TempData["BlogCategoryError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["BlogCategoryError"] = "Id must not be null";
                return RedirectToAction("Index");
            }


        }

        [HttpPost]
        public IActionResult Update(BlogCategory model)
        {
            if (ModelState.IsValid)
            {
                _context.BlogCategories.Update(model);
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
                BlogCategory blogCategory = _context.BlogCategories.Find(Id);

                if (blogCategory != null)
                {
                    _context.BlogCategories.Remove(blogCategory);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["BlogCategoryError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["BlogCategoryError"] = "Id must not be null";
                return RedirectToAction("Index");
            }
        }
    }
}
