using Microsoft.AspNetCore.Mvc;
using Pronia_eCommerce.Data;
using Pronia_eCommerce.Models;
using Pronia_eCommerce.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmContact model = new();
            model.Setting = _context.Setting.FirstOrDefault();
            model.SiteSocial = _context.SiteSocials.ToList();
            model.ContactUs = _context.ContactUs.FirstOrDefault();
            model.Banner = _context.Banners.FirstOrDefault(b => b.Page.ToLower() == "contact");

            return View(model);
        }

        [HttpPost]
        public IActionResult Message(Message Message)
        {
            if (ModelState.IsValid)
            {
                Message.CreatedDate = DateTime.Now;
                _context.Messages.Add(Message);
                _context.SaveChanges();

                TempData["MessageSuccess"] = "Your message has been sent successfully";
            }
            else
            {
                TempData["MessageError"] = "Please fill out all of the required fields correctly";

            }

            return RedirectToAction("Index");
        }
    }
}
