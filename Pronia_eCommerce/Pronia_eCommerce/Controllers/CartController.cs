using Microsoft.AspNetCore.Http;
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
    public class CartController : Controller
    {
        private readonly AppDbContext _context;

        public CartController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            string oldData = Request.Cookies["cart"];

            if (!string.IsNullOrEmpty(oldData))
            {
                var cart = oldData.Split("-").ToList();


                List<Product> _products = new();
                foreach (var pr in cart)
                {
                    if (_context.Products.Find(Int32.Parse(pr)) != null)
                    {
                        _products.Add(_context.Products.Include(p => p.ProductImages).Include(p => p.ProductSizeToProducts).ThenInclude(ps => ps.ProductSize).FirstOrDefault(p => p.Id == Int32.Parse(pr)));
                    }

                }
                VmCart model = new();
                model.Setting = _context.Setting.FirstOrDefault();
                model.SiteSocial = _context.SiteSocials.ToList();
                if (_products.Count > 0)
                {
                    model.Products = _products;
                    return View(model);
                }
                return View(model);
            }
            else
            {
                VmCart model = new();
                model.Setting = _context.Setting.FirstOrDefault();
                model.SiteSocial = _context.SiteSocials.ToList();

                return View(model);
            }

        }

        public IActionResult AddToCart(string productId)
        {
            if (productId!=null)
            {
                if (_context.Products.Find(Int32.Parse(productId))!=null)
                {
                    if (_context.Products.Any(p => p.Id == Int16.Parse(productId)))
                    {

                        string oldData = Request.Cookies["cart"];
                        string newData = null;
                        VmResponse response = new();
                        if (string.IsNullOrEmpty(oldData))
                        {
                            newData = productId;
                            response.Success = "Added";
                        }
                        else
                        {
                            List<string> favouriteList = oldData.Split("-").ToList();
                            if (favouriteList.Any(f => f == productId))
                            {
                                response.Changed = "Already Added";
                                return Json(response);

                            }
                            else
                            {
                                newData = oldData + "-" + productId;
                                response.Success = "Added";
                            }
                        }

                        CookieOptions options = new()
                        {
                            Expires = DateTime.Now.AddMonths(1)
                        };

                        Response.Cookies.Append("cart", newData, options);

                        return Json(response);

                    }
                    else
                    {
                        VmResponse response = new();
                        response.Error = "Error";

                        return Json(response);
                    }
                }
                else
                {
                    VmResponse response = new();
                    response.Error = "Error";

                    return Json(response);
                }

            }
            else
            {
                VmResponse response = new();
                response.Error = "Error";

                return Json(response);
            }

            
        }

        public IActionResult GetCartMenu()
        {
            string oldData = Request.Cookies["cart"];

            if (!string.IsNullOrEmpty(oldData))
            {
                var cart = oldData.Split("-").ToList();


                List<Product> _products = new();
                foreach (var pr in cart)
                {
                    if (_context.Products.Find(Int32.Parse(pr)) != null)
                    {
                        _products.Add(_context.Products.Include(p => p.ProductImages).Include(p => p.ProductSizeToProducts).FirstOrDefault(p => p.Id == Int32.Parse(pr)));
                    }

                }
                VmCart model = new();
                if (_products.Count > 0)
                {
                    model.Products = _products;


                    return Json(_products);
                }
                else
                {
                    return Json(new { data = "Empty" });
                }
            }
            else
            {
                return Json(new { data = "Empty" });
            }


            
        }

        public IActionResult RemoveFromCart(int? Id)
        {
            string oldData = Request.Cookies["cart"];
            string newData = null;

            if (!string.IsNullOrEmpty(oldData))
            {
                List<string> carts = oldData.Split("-").ToList();
                if (carts.Any(f => f == Id.ToString()))
                {
                    carts.Remove(Id.ToString());
                    newData = string.Join("-", carts);
                }
                else
                {
                    return RedirectToAction("index");
                }
            }
            else
            {
                return RedirectToAction("index");
            }

            CookieOptions options = new()
            {
                Expires = DateTime.Now.AddMonths(1)
            };

            Response.Cookies.Append("cart", newData, options);

            return RedirectToAction("index");
        }


    }
}
