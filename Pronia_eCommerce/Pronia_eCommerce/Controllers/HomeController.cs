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
            VmHome model = new();
            model.Setting = _context.Setting.FirstOrDefault();
            model.SiteSocial = _context.SiteSocials.ToList();
            model.OurBrands = _context.OurBrands.ToList();
            model.CollectionL = _context.CollectionL.ToList();
            model.CollectionS = _context.CollectionS.ToList();
            return View(model);
        }

    }
}
