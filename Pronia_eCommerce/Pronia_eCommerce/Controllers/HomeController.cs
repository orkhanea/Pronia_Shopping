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
            model.LatestProducts = _context.Products.Include(p=>p.ProductImages).Include(p=>p.ProductSizeToProducts).Include(p=>p.Ratings).OrderByDescending(p => p.CreatedDate).Where(p => p.Archived == false).Take(8).ToList();
            model.Products = _context.Products.Include(p => p.ProductImages).Include(p => p.ProductSizeToProducts).Include(p=>p.Ratings).Where(p => p.Archived == false).Take(8).ToList();
            List<Product> helperProducts = _context.Products.Include(p => p.ProductImages).Include(p=>p.ProductSizeToProducts).Include(p => p.Ratings).Where(p => p.Archived == false).ToList();
            model.Testimonials = _context.Testimonials.ToList();
            model.HomeSliders = _context.HomeSliders.ToList();


            foreach (var item in helperProducts)
            {

                if (item.Ratings.Count > 0)
                {
                    var rval2 = item.Ratings;
                    var fiveS = 0;
                    var fourS = 0;
                    var threeS = 0;
                    var twoS = 0;
                    var oneS = 0;
                    for (var rs = 0; rs < rval2.Count; rs++)
                    {


                        for (var str = 0; str < rval2.Count; str++)
                        {
                            if (rval2[str].Star == 5)
                            {
                                fiveS++;
                            }
                            else if (rval2[str].Star == 4)
                            {
                                fourS++;
                            }
                            else if (rval2[str].Star == 3)
                            {
                                threeS++;
                            }
                            else if (rval2[str].Star == 2)
                            {
                                twoS++;
                            }
                            else if (rval2[str].Star == 1)
                            {
                                oneS++;
                            }
                        }

                    }

                    decimal sum = (fiveS * 5) + (fourS * 4) + (threeS * 3) + (twoS * 2) + (oneS * 1);
                    decimal rSum = fiveS + fourS + threeS + twoS + oneS;
                    var sumRsum = Math.Round((sum / rSum), 1, MidpointRounding.ToEven);

                    item.Ratingval = sumRsum;
                }


            }

            model.RatingProducts = helperProducts.OrderByDescending(p => p.Ratingval).Take(8).ToList();







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
