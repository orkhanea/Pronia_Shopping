using Microsoft.AspNetCore.Mvc;
using Pronia_eCommerce.Data;
using Pronia_eCommerce.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            VmAbout model = new();
            model.Setting = _context.Setting.FirstOrDefault();
            model.SiteSocial = _context.SiteSocials.ToList();
            model.Counters = _context.Counters.FirstOrDefault();
            model.OurBrands = _context.OurBrands.ToList();
            model.About = _context.About.FirstOrDefault();
            model.Banner = _context.Banners.FirstOrDefault(b => b.Page.ToLower() == "about");

            return View(model);
        }
    }
}
