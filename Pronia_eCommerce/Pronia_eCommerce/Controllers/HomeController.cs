using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pronia_eCommerce.Data;
using Pronia_eCommerce.Models;
using Pronia_eCommerce.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                if (!User.IsInRole("User"))
                {
                    return RedirectToAction("Logout", "Account");
                }
            }

            VmHome model = new();
            model.Setting = _context.Setting.FirstOrDefault();
            model.SiteSocial = _context.SiteSocials.ToList();
            model.OurBrands = _context.OurBrands.ToList();
            model.CollectionL = _context.CollectionL.ToList();
            model.CollectionS = _context.CollectionS.ToList();
            model.LatestBlogs = _context.Blogs.OrderByDescending(b => b.CreatedDate).Take(3).ToList();
            return View(model);
        }

    }
}
