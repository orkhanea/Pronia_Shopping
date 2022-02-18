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
    public class FaqController : Controller
    {
        private readonly AppDbContext _context;

        public FaqController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.FAQs.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(FAQ model)
        {
            if (ModelState.IsValid)
            {
                _context.FAQs.Add(model);
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
                if (_context.FAQs.Find(Id) != null)
                {
                    return View(_context.FAQs.Find(Id));
                }
                else
                {
                    TempData["FaqError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["FaqError"] = "Id must not be null";
                return RedirectToAction("Index");
            }


        }

        [HttpPost]
        public IActionResult Update(FAQ model)
        {
            if (ModelState.IsValid)
            {
                _context.FAQs.Update(model);
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
                FAQ Faq = _context.FAQs.Find(Id);

                if (Faq != null)
                {
                    _context.FAQs.Remove(Faq);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["FaqError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["FaqError"] = "Id must not be null";
                return RedirectToAction("Index");
            }
        }
    }
}
