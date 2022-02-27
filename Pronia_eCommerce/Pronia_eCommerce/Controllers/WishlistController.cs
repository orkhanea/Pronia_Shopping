using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pronia_eCommerce.Data;
using Pronia_eCommerce.Models;
using Pronia_eCommerce.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.Controllers
{
    public class WishlistController : Controller
    {
        private readonly AppDbContext _context;

        public WishlistController(AppDbContext context)
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

            string oldData = Request.Cookies["favourites"];

            if (!string.IsNullOrEmpty(oldData))
            {
                var favourite = oldData.Split("-").ToList();


                List<Product> _restourants = new();
                foreach (var f in favourite)
                {
                    if (_context.Products.Find(Int32.Parse(f))!=null)
                    {
                        _restourants.Add(_context.Products.Include(p=>p.ProductImages).Include(p=>p.ProductSizeToProducts).ThenInclude(ps=>ps.ProductSize).FirstOrDefault(p=>p.Id== Int32.Parse(f)));
                    }
                    
                }
                VmWishlist model = new();
                model.Setting = _context.Setting.FirstOrDefault();
                model.SiteSocial = _context.SiteSocials.ToList();
                if (_restourants.Count>0)
                {
                    model.Products = _restourants;
                    return View(model);
                }
                return View(model);
            }
            else
            {
                VmWishlist model = new();
                model.Setting = _context.Setting.FirstOrDefault();
                model.SiteSocial = _context.SiteSocials.ToList();

                return View(model);
            }
        }
    }
}
