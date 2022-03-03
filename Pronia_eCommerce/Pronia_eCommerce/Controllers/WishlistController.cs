using Microsoft.AspNetCore.Identity;
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
        private readonly UserManager<IdentityUser> _userManager;

        public WishlistController(AppDbContext context, UserManager<IdentityUser> userManager)
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

            if (User.Identity.IsAuthenticated)
            {
                string oldData = _context.EndUsers.Find(_userManager.GetUserId(User)).UserFavourite;

                if (!string.IsNullOrEmpty(oldData))
                {
                    var favourite = oldData.Split("-").ToList();


                    List<Product> _restourants = new();
                    foreach (var f in favourite)
                    {
                        if (_context.Products.Find(Int32.Parse(f)) != null)
                        {
                            _restourants.Add(_context.Products.Include(p => p.ProductImages).Include(p => p.ProductSizeToProducts).ThenInclude(ps => ps.ProductSize).FirstOrDefault(p => p.Id == Int32.Parse(f)));
                        }

                    }
                    VmWishlist model = new();
                    model.Setting = _context.Setting.FirstOrDefault();
                    model.SiteSocial = _context.SiteSocials.ToList();
                    model.Banner = _context.Banners.FirstOrDefault(p => p.Page == "Wishlist");
                    if (_restourants.Count > 0)
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
                    model.Banner = _context.Banners.FirstOrDefault(p => p.Page == "Wishlist");

                    return View(model);
                }

            }
            else
            {
                string oldData = Request.Cookies["favourites"];

                if (!string.IsNullOrEmpty(oldData))
                {
                    var favourite = oldData.Split("-").ToList();


                    List<Product> _restourants = new();
                    foreach (var f in favourite)
                    {
                        if (_context.Products.Find(Int32.Parse(f)) != null)
                        {
                            _restourants.Add(_context.Products.Include(p => p.ProductImages).Include(p => p.ProductSizeToProducts).ThenInclude(ps => ps.ProductSize).FirstOrDefault(p => p.Id == Int32.Parse(f)));
                        }

                    }
                    VmWishlist model = new();
                    model.Setting = _context.Setting.FirstOrDefault();
                    model.SiteSocial = _context.SiteSocials.ToList();
                    model.Banner = _context.Banners.FirstOrDefault(p => p.Page == "Wishlist");
                    if (_restourants.Count > 0)
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
                    model.Banner = _context.Banners.FirstOrDefault(p => p.Page == "Wishlist");

                    return View(model);
                }
            }

            
        }
    }
}
