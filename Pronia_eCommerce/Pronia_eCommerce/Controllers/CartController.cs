using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
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
    public class CartController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IWebHostEnvironment _webHostEnviroment;

        public CartController(AppDbContext context, IHttpContextAccessor httpContextAccessor, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, RoleManager<IdentityRole> roleManager, IWebHostEnvironment webHostEnviroment)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _webHostEnviroment = webHostEnviroment;
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

                string oldData = _context.EndUsers.Find(_userManager.GetUserId(User)).UserCart;

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
            else
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

            

        }

        public IActionResult AddToCart(string productId)
        {
            if (User.Identity.IsAuthenticated)
            {
                if (!User.IsInRole("User"))
                {
                    return RedirectToAction("Logout", "Account");
                }
            }

            if (productId!=null)
            {
                if (_context.Products.Find(Int32.Parse(productId))!=null)
                {
                    if (_context.Products.Any(p => p.Id == Int16.Parse(productId)))
                    {

                        if (User.Identity.IsAuthenticated)
                        {
                            EndUser endUser = _context.EndUsers.Find(_userManager.GetUserId(User));

                            string oldData = endUser.UserCart;
                            string newData = null;
                            VmResponse response = new();

                            if (string.IsNullOrEmpty(oldData))
                            {
                                newData = productId;
                                response.Success = "Added";
                            }
                            else
                            {
                                List<string> userCartList = oldData.Split("-").ToList();
                                if (userCartList.Any(f => f == productId))
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

                            endUser.UserCart = newData;
                            _context.EndUsers.Update(endUser);
                            _context.SaveChanges();
                            List<string> cartCount = newData.Split("-").ToList();
                            response.CartCount = cartCount.Count;
                            return Json(response);


                        }
                        else
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
                            List<string> cartCount = newData.Split("-").ToList();
                            response.CartCount = cartCount.Count;
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
            else
            {
                VmResponse response = new();
                response.Error = "Error";

                return Json(response);
            }

            
        }

        public IActionResult GetCartMenu()
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

                EndUser endUser = _context.EndUsers.Find(_userManager.GetUserId(User));

                string oldData = endUser.UserCart;

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
            else
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

        }

        public IActionResult RemoveFromCart(int? Id)
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

                EndUser endUser = _context.EndUsers.Find(_userManager.GetUserId(User));

                string oldData = endUser.UserCart;
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

                endUser.UserCart = newData;

                _context.EndUsers.Update(endUser);
                _context.SaveChanges();

                return RedirectToAction("index");
            }
            else
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
}
