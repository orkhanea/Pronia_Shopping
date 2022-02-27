using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pronia_eCommerce.Data;
using Pronia_eCommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin, Moderator, Admin")]
    public class BlogTagController : Controller
    {
        private readonly AppDbContext _context;

        public BlogTagController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            return View(_context.BlogTags.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BlogTag model)
        {
            if (ModelState.IsValid)
            {
                _context.BlogTags.Add(model);
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
                if (_context.BlogTags.Find(Id) != null)
                {
                    return View(_context.BlogTags.Find(Id));
                }
                else
                {
                    TempData["BlogTagError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["BlogTagError"] = "Id must not be null";
                return RedirectToAction("Index");
            }


        }

        [HttpPost]
        public IActionResult Update(BlogTag model)
        {
            if (ModelState.IsValid)
            {
                _context.BlogTags.Update(model);
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
                BlogTag blogTag = _context.BlogTags.Find(Id);

                if (blogTag != null)
                {
                    _context.BlogTags.Remove(blogTag);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["BlogTagError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["BlogTagError"] = "Id must not be null";
                return RedirectToAction("Index");
            }
        }
    }
}
