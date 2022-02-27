using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pronia_eCommerce.Data;
using Pronia_eCommerce.Models;
using Pronia_eCommerce.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Pronia_eCommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin, Admin, Moderator")]

    public class InboxController : Controller
    {
        private readonly AppDbContext _context;

        public InboxController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Message> messages = _context.Messages.OrderByDescending(m => m.CreatedDate).ToList();

            return View(messages);
        }

        public IActionResult Read(int? Id)
        {
            if (Id !=null)
            {
                if (_context.Messages.Find(Id)!=null)
                {
                    var message = _context.Messages.Find(Id);
                    VmSendEmail model = new();
                    model.message = message;
                    message.hasReaded = true;
                    _context.Messages.Update(message);
                    _context.SaveChanges();
                    return View(model);
                }
            }

            return RedirectToAction();
        }

        [HttpPost]
        public IActionResult Read(VmSendEmail vmSendEmail)
        {
            if (ModelState.IsValid)
            {
                MailMessage message = new MailMessage("proniaecommerce@gmail.com", vmSendEmail.EmailAddress);
                message.Subject = "Pronia";
                message.Body = vmSendEmail.sendingMessage;
                message.IsBodyHtml = false;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                NetworkCredential NetworkCred = new NetworkCredential("proniaecommerce@gmail.com", "123456Pronia@");
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = NetworkCred;
                smtp.Port = 587;
                smtp.Send(message);

                TempData["EmailSucces"] = "Email have been sent successfully!";
                return RedirectToAction("Index");
            }

            return View(vmSendEmail);
        }

        public IActionResult DelMes(int? Id)
        {
            if (Id!=null)
            {
                if (_context.Messages.Find(Id)!=null)
                {
                    _context.Messages.Remove(_context.Messages.Find(Id));
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return RedirectToAction("Index");
        }
    }
}
