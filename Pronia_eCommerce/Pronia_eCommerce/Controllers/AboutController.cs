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
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
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


            Counter counter = new();
            List<Sale> sales = _context.Sales.Include(s => s.EndUser).Include(s => s.UnregisteredCustomer).ToList();
            List<UnregisteredCustomer> uUsers = _context.UnregisteredCustomers.ToList();
            List<UnregisteredCustomer> uUsersNR = new();
            List<EndUser> endUsers = new();

            foreach (var usr1 in uUsers)
            {
                if (uUsersNR.Count==0)
                {
                    uUsersNR.Add(usr1);
                }
                else
                {
                    if (!uUsersNR.Any(e => (e.Email.ToLower() == usr1.Email.ToLower()) && (e.FirstName.ToLower() == usr1.FirstName.ToLower()) && (e.LastName.ToLower() == usr1.LastName.ToLower())))
                    {
                        uUsersNR.Add(usr1);

                    }
                }
                
            }
            foreach (var usr2 in sales)
            {
                if (usr2.EndUserId!=null)
                {
                    if (endUsers.Count==0)
                    {
                        endUsers.Add(usr2.EndUser);
                    }
                    else
                    {
                        if (!endUsers.Any(e => e.Id == usr2.EndUserId))
                        {
                            endUsers.Add(usr2.EndUser);
                        }
                    }
                }
            }

            int clients = uUsersNR.Count + endUsers.Count;
            _context.Counters.FirstOrDefault().Client = clients;
            _context.SaveChanges();

            List<RatingStar> rstars = _context.RatingStars.ToList();
            List<RatingStar> rstarsNR = new();

            foreach (var str in rstars)
            {
                if (rstarsNR.Count == 0)
                {
                    rstarsNR.Add(str);
                }
                else
                {
                    if (!rstarsNR.Any(e => (e.UserEmail.ToLower() == str.UserEmail.ToLower())))
                    {
                        rstarsNR.Add(str);

                    }
                }
            }

            _context.Counters.FirstOrDefault().Rating = rstarsNR.Count;
            _context.Counters.FirstOrDefault().Project = _context.Products.Count();
            _context.Counters.FirstOrDefault().Award = _context.Blogs.Count();
            _context.SaveChanges();




            VmAbout model = new();
            model.Setting = _context.Setting.FirstOrDefault();
            model.SiteSocial = _context.SiteSocials.ToList();
            model.Counters = _context.Counters.FirstOrDefault();
            model.OurBrands = _context.OurBrands.ToList();
            model.About = _context.About.FirstOrDefault();
            model.Banner = _context.Banners.FirstOrDefault(b => b.Page.ToLower() == "about");
            model.OurTeam = _context.SiteUsers.Take(4).ToList();

            return View(model);
        }

        public IActionResult Subscribe(string email)
        {
            VmResponse response = new();

            if (_context.Subscribes.FirstOrDefault(e=>e.Email==email.ToLower())==null)
            {
                Subscribe subscribe = new();
                subscribe.Email = email.ToLower();
                subscribe.CreatedDate = DateTime.Now;
                _context.Subscribes.Add(subscribe);
                _context.SaveChanges();
                response.Success = "Thank you for subscribing";
                return Json(response);
            }
            else
            {
                response.Changed = "You already subscribed to our newsletter.";
                return Json(response);
            }

        }
    }
}
