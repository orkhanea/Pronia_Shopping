﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pronia_eCommerce.Data;
using Pronia_eCommerce.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin, Moderator, Admin")]
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmAdminHome vmAdminHome = new();
            vmAdminHome.Sales = _context.Sales.Include(si => si.SaleItems)
                                             .ThenInclude(ps => ps.ProductSizeToProduct)
                                             .ThenInclude(p => p.Product)
                                             .ThenInclude(p => p.ProductImages)
                                             .Include(si => si.SaleItems)
                                             .ThenInclude(si => si.ProductSizeToProduct)
                                             .ThenInclude(s => s.ProductSize)
                                             .Include(si => si.UnregisteredCustomer)
                                             .Include(si => si.EndUser).OrderByDescending(s => s.SaleDate).Take(10).ToList();

            var Datassss = _context.SaleItems.Include(s => s.Sale).ToList().GroupBy(d => d.Sale.SaleDate.Date);

            var nnn = Datassss.Select(w => w.Select(s => s.Quantity)).ToList();

            List<int> count = new();

            foreach (var item in nnn)
            {
                var x = 0;
                foreach (var item2 in item)
                {
                    x += item2;
                }

                count.Add(x);
                
            }

            vmAdminHome.Dates = Datassss.Select(e => e.Select(r => r.Sale.SaleDate.Date)).Take(10).ToList();
            vmAdminHome.Datas = count;

            return View(vmAdminHome);
        }
    }
}
