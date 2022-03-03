using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private readonly UserManager<IdentityUser> _userManager;

        public HomeController(AppDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
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
            model.LatestProducts = _context.Products.Include(p=>p.ProductImages).Include(p=>p.ProductSizeToProducts).OrderByDescending(p => p.CreatedDate).Take(8).ToList();
            model.Products = _context.Products.Include(p => p.ProductImages).Include(p => p.ProductSizeToProducts).Take(8).ToList();
            model.RatingProducts = _context.Products.Include(p => p.ProductImages).Include(p=>p.ProductSizeToProducts).Include(p => p.Ratings).OrderByDescending(p=>p.Ratings.Count>0).Take(8).ToList();

            if (User.Identity.IsAuthenticated)
            {
                string oldData = _context.EndUsers.Find(_userManager.GetUserId(User)).UserFavourite;

                if (!string.IsNullOrEmpty(oldData))
                {
                    model.Favourite = oldData.Split("-").ToList();
                }
            }
            else
            {
                string oldData = Request.Cookies["favourites"];

                if (!string.IsNullOrEmpty(oldData))
                {
                    model.Favourite = oldData.Split("-").ToList();
                }
            }

            return View(model);
        }

    }
}
