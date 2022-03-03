using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Pronia_eCommerce.Data;
using Pronia_eCommerce.Models;
using Pronia_eCommerce.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia_eCommerce.Controllers
{
    public static class SessionExtensions
    {
        public static void SetObject(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T GetObject<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }

    public static class Extension
    {
        public static void Put<T>(this ITempDataDictionary tempData, string key, T value) where T : class
        {
            tempData[key] = JsonConvert.SerializeObject(value);


            //Extension.Put(TempData, "key1", test);
        }

        public static T Get<T>(this ITempDataDictionary tempData, string key) where T : class
        {
            object o;
            tempData.TryGetValue(key, out o);
            return o == null ? null : JsonConvert.DeserializeObject<T>((string)o);


            //Extension.Get<VmSessionObject>(TempData, "key1");

        }
    }

    public class CheckoutController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CheckoutController(AppDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Indext()
        {
            if (User.Identity.IsAuthenticated)
            {
                if (!User.IsInRole("User"))
                {
                    return RedirectToAction("Logout", "Account");
                }
            }

            var vmSessionObjectL = HttpContext.Session.GetObject<VmSessionObject>("testSession");
            var vmpayment = Extension.Get<VmPayment>(TempData, "modelState");

            if (vmSessionObjectL==null)
            {
                return RedirectToAction("Index", "Cart");
            }

            VmCheckout model = new();
            model.Setting = _context.Setting.FirstOrDefault();
            model.SiteSocial = _context.SiteSocials.ToList();
            if (vmpayment != null)
            {
                model.vmPayment = vmpayment;
                TempData["modelState"] = null;
            }
            if (vmSessionObjectL.Messages!=null && vmSessionObjectL.Messages.Count > 0)
            {
                model.Messages = vmSessionObjectL.Messages;
            }

            List<ProductSizeToProduct> prstp2 = _context.ProductSizeToProducts.Include(ps => ps.Product).Include(ps => ps.ProductSize).ToList();

            model.prstp = (from y in vmSessionObjectL.ProductSizeToProductId join x in prstp2 on y equals x.Id select x).ToList();
            model.prqty = vmSessionObjectL.ProductCount;
            
            return View(model);
        }

        public IActionResult CartToCheckout(VmCart cart)
        {
            if (User.Identity.IsAuthenticated)
            {
                if (!User.IsInRole("User"))
                {
                    return RedirectToAction("Logout", "Account");
                }
            }

            if (cart.ProductCounts != null && cart.ProductIds != null && cart.ProductSizeIds != null)
            {
                if (cart.ProductCounts.Count > 0 && cart.ProductIds.Count > 0 && cart.ProductSizeIds.Count > 0)
                {
                    if (cart.ProductCounts.Count==cart.ProductSizeIds.Count)
                    {
                        VmSessionObject test = new();
                        List<string> msg2 = new();

                        for (int i = 0; i < cart.ProductSizeIds.Count; i++)
                        {
                            if (_context.ProductSizeToProducts.Find(cart.ProductSizeIds[i]).Quantity >= cart.ProductCounts[i])
                            {
                                test.ProductSizeToProductId.Add(cart.ProductSizeIds[i]);
                                test.ProductCount.Add(cart.ProductCounts[i]);
                                test.ProductId.Add((cart.ProductIds[i]));
                            }
                            else
                            {
                                ProductSizeToProduct toProduct = _context.ProductSizeToProducts.Include(ps => ps.Product).Include(ps => ps.ProductSize).FirstOrDefault(ps => ps.Id == cart.ProductSizeIds[i]);
                                var msg = "Sorry there are only left " + toProduct.Quantity + " unit(s) for the " + toProduct.ProductSize.Size + " size of " + toProduct.Product.Name;
                                msg2.Add(msg);
                                test.Messages.Add(msg);
                            }
                        }
                        if (msg2.Count > 0)
                        {
                            HttpContext.Session.SetObject("QuantityError", msg2);
                            return RedirectToAction("Index", "Cart");
                        }
                        HttpContext.Session.SetObject("testSession", test);
                        return RedirectToAction("Indext");
                    }
                    else
                    {
                        TempData["Errorcart2"] = "Please select a size for each products!";
                        return RedirectToAction("Index", "Cart");
                    }
                }
                else
                {
                    TempData["Errorcart2"] = "Please pick a count for each products!";
                    return RedirectToAction("Index", "Cart");
                }
            }
            else
            {
                return RedirectToAction("Index", "Cart");
            }




            
        }


    }
}
