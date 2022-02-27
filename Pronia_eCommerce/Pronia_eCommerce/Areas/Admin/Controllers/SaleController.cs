using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pronia_eCommerce.Data;
using Pronia_eCommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin")]
    public class SaleController : Controller
    {
        private readonly AppDbContext _context;

        public SaleController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Sale> sales = _context.Sales.Include(si => si.SaleItems)
                                             .ThenInclude(ps => ps.ProductSizeToProduct)
                                             .ThenInclude(p => p.Product)
                                             .ThenInclude(p=>p.ProductImages)
                                             .Include(si => si.SaleItems)
                                             .ThenInclude(si => si.ProductSizeToProduct)
                                             .ThenInclude(s => s.ProductSize)
                                             .Include(si=>si.UnregisteredCustomer)
                                             .Include(si=>si.EndUser).OrderByDescending(s=>s.SaleDate).ToList();


            return View(sales);
        }

        public IActionResult SaleDetail(int? Id)
        {
            if (Id !=null)
            {
                if (_context.Sales.Find(Id)!=null)
                {

                    Sale sale = _context.Sales.Include(si => si.SaleItems)
                                             .ThenInclude(ps => ps.ProductSizeToProduct)
                                             .ThenInclude(p => p.Product)
                                             .ThenInclude(p => p.ProductImages)
                                             .Include(si => si.SaleItems)
                                             .ThenInclude(si => si.ProductSizeToProduct)
                                             .ThenInclude(s => s.ProductSize)
                                             .Include(si => si.UnregisteredCustomer)
                                             .Include(si => si.EndUser)
                                             .ThenInclude(u=>u.Country)
                                             .FirstOrDefault(s => s.Id == Id);
                    sale.isReaded = true;
                    _context.Sales.Update(sale);
                    _context.SaveChanges();

                    return View(sale);

                }
                else
                {

                    TempData["SaleError"] = "Something went wrong. Please try it again!";
                    return RedirectToAction("Index");
                }
            }
            else
            {

                TempData["SaleError"] = "Something went wrong. Please try it again!";
                return RedirectToAction("Index");
            }






        }




    }
}
