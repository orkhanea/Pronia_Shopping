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
    [Authorize(Roles = "SuperAdmin")]
    public class SiteSocialController : Controller
    {
        private readonly AppDbContext _context;

        public SiteSocialController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.SiteSocials.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(SiteSocial model)
        {
            if (ModelState.IsValid)
            {
                _context.SiteSocials.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult Update(int? Id)
        {
            if (Id != null)
            {
                if (_context.SiteSocials.Find(Id) != null)
                {
                    return View(_context.SiteSocials.Find(Id));
                }
                else
                {
                    TempData["SocialError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["SocialError"] = "Id must not be null";
                return RedirectToAction("Index");
            }


        }

        [HttpPost]
        public IActionResult Update(SiteSocial model)
        {
            if (ModelState.IsValid)
            {
                _context.SiteSocials.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult Delete(int? Id)
        {
            if (Id != null)
            {
                SiteSocial siteSocial = _context.SiteSocials.Find(Id);

                if (siteSocial != null)
                {
                    _context.SiteSocials.Remove(siteSocial);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["SocialError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }

            }
            else
            {
                TempData["SocialError"] = "Id must not be null";
                return RedirectToAction("Index");
            }



        }
    }
}
