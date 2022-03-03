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
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Pronia_eCommerce.Controllers
{
    public class BankController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IWebHostEnvironment _webHostEnviroment;

        public BankController(AppDbContext context, IHttpContextAccessor httpContextAccessor, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, RoleManager<IdentityRole> roleManager, IWebHostEnvironment webHostEnviroment)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
            _signInManager = signInManager;
            _webHostEnviroment = webHostEnviroment;
        }

        public IActionResult Index(VmPayment vmPayment)
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
                if (_context.EndUsers.Find(_userManager.GetUserId(User)).BillingAddress!=null && _context.EndUsers.Find(_userManager.GetUserId(User)).BillingAddress != "" && _context.EndUsers.Find(_userManager.GetUserId(User)).ShippingAddress != null && _context.EndUsers.Find(_userManager.GetUserId(User)).ShippingAddress != "" && _context.EndUsers.Find(_userManager.GetUserId(User)).PhoneNumber != null && _context.EndUsers.Find(_userManager.GetUserId(User)).PhoneNumber != "")
                {
                    if (TempData["BalanceError"] != null)
                    {
                        var ttt = HttpContext.Session.GetObject<BankCarts>("bankcartInfo");
                        return View(ttt);
                    }
                    else
                    {
                        return View();
                    }
                }
                else
                {
                    TempData["UpdateProfilePLS"] = "Please fill in the fields marked with an asterisk (*) to shopping!";
                    return RedirectToAction("Profile", "Account");
                }

            }
            else
            {

                if (TempData["BalanceError"] != null)
                {
                    var ttt = HttpContext.Session.GetObject<BankCarts>("bankcartInfo");
                    return View(ttt);
                }

                if (ModelState.IsValid)
                {

                    HttpContext.Session.SetObject("paymentInfo", vmPayment);
                    return View();
                }
                else
                {
                    Extension.Put(TempData, "modelState", vmPayment);
                    TempData["modelMessage"] = "Please fill in the fields marked with an asterisk (*)";
                    return RedirectToAction("Indext", "Checkout");
                }
            }

        }

        [HttpPost]
        public IActionResult Payment(BankCarts bankCarts)
        {
            if (ModelState.IsValid)
            {
                if (_context.BankCarts.Any(b => (b.CartNo == bankCarts.CartNo) && (b.Cvc == bankCarts.Cvc) && (b.HolderName == bankCarts.HolderName) && (b.CardExpiry == bankCarts.CardExpiry)))
                {
                    BankCarts crt = _context.BankCarts.FirstOrDefault(b => (b.CartNo == bankCarts.CartNo) && (b.Cvc == bankCarts.Cvc) && (b.HolderName == bankCarts.HolderName) && (b.CardExpiry == bankCarts.CardExpiry));

                    if (crt != null)
                    {

                        var vmSessionObjectL = HttpContext.Session.GetObject<VmSessionObject>("testSession");


                        VmCheckout model = new();
                        List<ProductSizeToProduct> prstp2 = _context.ProductSizeToProducts.Include(ps => ps.Product).Include(ps => ps.ProductSize).ToList();
                        model.prstp = (from y in vmSessionObjectL.ProductSizeToProductId join x in prstp2 on y equals x.Id select x).ToList();
                        model.prqty = vmSessionObjectL.ProductCount;


                        decimal total = 0;
                        for (int i = 0; i < model.prstp.Count; i++)
                        {
                            total += model.prqty[i] * model.prstp[i].Price;
                        }

                        if (crt.Balance >= total)
                        {
                            if (!User.Identity.IsAuthenticated)
                            {
                                var vmpayment = HttpContext.Session.GetObject<VmPayment>("paymentInfo");

                                UnregisteredCustomer unregisteredCustomer = new();
                                unregisteredCustomer.FirstName = vmpayment.FirstName;
                                unregisteredCustomer.LastName = vmpayment.LastName;
                                unregisteredCustomer.Phone = vmpayment.Phone;
                                unregisteredCustomer.Email = vmpayment.Email;
                                unregisteredCustomer.Address = vmpayment.Address;
                                unregisteredCustomer.CompanyName = vmpayment.CompanyName;
                                unregisteredCustomer.CountyName = vmpayment.CountyName;
                                unregisteredCustomer.Apartment = vmpayment.Apartment;
                                unregisteredCustomer.PostcodeZip = vmpayment.PostcodeZip;
                                unregisteredCustomer.TownCity = vmpayment.TownCity;
                                unregisteredCustomer.OrderNotes = vmpayment.OrderNotes;

                                _context.UnregisteredCustomers.Add(unregisteredCustomer);
                                _context.SaveChanges();


                                InvoiceNo invoiceNoBase = _context.Invoice.FirstOrDefault();
                                invoiceNoBase.iNumber += 1;

                                _context.Invoice.Update(invoiceNoBase);
                                _context.SaveChanges();

                                Sale sale = new();
                                sale.InvoiceNo = "PRN" + invoiceNoBase.iNumber.ToString("D7");
                                sale.UnregisteredCustomerId = unregisteredCustomer.Id;
                                sale.SaleDate = DateTime.Now;

                                _context.Sales.Add(sale);
                                _context.SaveChanges();


                                for (int i = 0; i < model.prstp.Count; i++)
                                {
                                    SaleItem saleItem = new();

                                    saleItem.ProductSizeToProductId = model.prstp[i].Id;
                                    saleItem.Price = model.prstp[i].Price;
                                    saleItem.Quantity = (byte)model.prqty[i];
                                    saleItem.SaleId = sale.Id;

                                    _context.SaleItems.Add(saleItem);
                                    _context.SaveChanges();

                                    ProductSizeToProduct productSizeToProduct2 = _context.ProductSizeToProducts.Find(model.prstp[i].Id);
                                    productSizeToProduct2.Quantity -= (byte)model.prqty[i];

                                    _context.ProductSizeToProducts.Update(productSizeToProduct2);
                                    _context.SaveChanges();


                                }





                                crt.Balance -= total;

                                _context.BankCarts.Update(crt);
                                _context.SaveChanges();





                                MailMessage newInvoice = new MailMessage("proniaecommerce@gmail.com", unregisteredCustomer.Email);
                                newInvoice.Subject = "Pronia Shopping";

                                newInvoice.Body = @"<h2>Your purchase complete successfully.<h2/><br/><h4>Total: $<h4/>" + total;
                                newInvoice.IsBodyHtml = true;
                                SmtpClient smtp = new SmtpClient();
                                smtp.Host = "smtp.gmail.com";
                                smtp.EnableSsl = true;
                                NetworkCredential NetworkCred = new NetworkCredential("proniaecommerce@gmail.com", "123456Pronia@");
                                smtp.UseDefaultCredentials = false;
                                smtp.Credentials = NetworkCred;
                                smtp.Port = 587;
                                smtp.Send(newInvoice);





                                TempData["PaymentSuccess"] = "Thank you for choosing us!";
                                if (Request.Cookies["cart"]!=null)
                                {
                                    _httpContextAccessor.HttpContext.Response.Cookies.Delete("cart");
                                }
                                return RedirectToAction("Index", "Cart");
                            }
                            else
                            {
                                InvoiceNo invoiceNoBase = _context.Invoice.FirstOrDefault();
                                invoiceNoBase.iNumber += 1;

                                _context.Invoice.Update(invoiceNoBase);
                                _context.SaveChanges();

                                Sale sale = new();
                                sale.InvoiceNo = "PRN" + invoiceNoBase.iNumber.ToString("D7");
                                sale.EndUserId = _context.EndUsers.Find(_userManager.GetUserId(User)).Id;
                                sale.SaleDate = DateTime.Now;

                                _context.Sales.Add(sale);
                                _context.SaveChanges();


                                for (int i = 0; i < model.prstp.Count; i++)
                                {
                                    SaleItem saleItem = new();

                                    saleItem.ProductSizeToProductId = model.prstp[i].Id;
                                    saleItem.Price = model.prstp[i].Price;
                                    saleItem.Quantity = (byte)model.prqty[i];
                                    saleItem.SaleId = sale.Id;

                                    _context.SaleItems.Add(saleItem);
                                    _context.SaveChanges();

                                    ProductSizeToProduct productSizeToProduct2 = _context.ProductSizeToProducts.Find(model.prstp[i].Id);
                                    productSizeToProduct2.Quantity -= (byte)model.prqty[i];

                                    _context.ProductSizeToProducts.Update(productSizeToProduct2);
                                    _context.SaveChanges();


                                }





                                crt.Balance -= total;

                                _context.BankCarts.Update(crt);
                                _context.SaveChanges();





                                MailMessage newInvoice = new MailMessage("proniaecommerce@gmail.com", _context.EndUsers.Find(_userManager.GetUserId(User)).Email);
                                newInvoice.Subject = "Pronia Shopping";

                                newInvoice.Body = @"<h2>Your purchase complete successfully.<h2/><br/><h4>Total: $<h4/>" + total;
                                newInvoice.IsBodyHtml = true;
                                SmtpClient smtp = new SmtpClient();
                                smtp.Host = "smtp.gmail.com";
                                smtp.EnableSsl = true;
                                NetworkCredential NetworkCred = new NetworkCredential("proniaecommerce@gmail.com", "123456Pronia@");
                                smtp.UseDefaultCredentials = false;
                                smtp.Credentials = NetworkCred;
                                smtp.Port = 587;
                                smtp.Send(newInvoice);





                                TempData["PaymentSuccess"] = "Thank you for choosing us!";
                                if (_context.EndUsers.Find(_userManager.GetUserId(User)).UserCart!=null)
                                {
                                    _context.EndUsers.Find(_userManager.GetUserId(User)).UserCart = null;
                                    _context.SaveChanges();
                                }
                                return RedirectToAction("Index", "Cart");
                            }


                        }
                        else
                        {
                            HttpContext.Session.SetObject("bankcartInfo", bankCarts);
                            TempData["BalanceError"] = "You do not have enough funds in your balance to complete this payment!";
                            return RedirectToAction("Index");
                        }

                    }
                    else
                    {
                        HttpContext.Session.SetObject("bankcartInfo", bankCarts);
                        TempData["BalanceError"] = "The credit/debit card information is not valid";
                        return RedirectToAction("Index");
                    }

                }
                else
                {
                    HttpContext.Session.SetObject("bankcartInfo", bankCarts);
                    TempData["BalanceError"] = "The credit/debit card information is not valid";
                    return RedirectToAction("Index");
                }

            }
            else
            {
                return RedirectToAction("Index");
            }

        }

    }
}
