using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using WellBeings.Data;
using Contact.Models;

namespace WellBeings.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductsDataAccess _productsDataAccess;

        private readonly RetailersDataAccess _retailersDataAccess;

        public HomeController()
        {
            _productsDataAccess = new ProductsDataAccess();
            _retailersDataAccess = new RetailersDataAccess();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Products()
        {
            ViewBag.Message = "Products page";
            ViewBag.Products = _productsDataAccess.GetProducts();

            return View();
        }

        public ActionResult Retailers()
        {
            ViewBag.Message = "Retailers page";
            ViewBag.Retailers = _retailersDataAccess.GetRetailers();
            return View();
        }

        // GET: Contact
        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = null;
            return View();
        }
        [HttpPost]
        public ActionResult Contact(ContactUs vm)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    MailMessage msz = new MailMessage();
                    msz.From = new MailAddress(vm.Email);
                    msz.To.Add("yourEmailAdress@gmail.com");
                    msz.Subject = vm.Subject;
                    msz.Body = vm.Message;
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.Credentials = new System.Net.NetworkCredential
                        ("yourEmailAdress@gmail.com", "yourActualPassword");
                    smtp.EnableSsl = true;
                    smtp.Send(msz);
                    ModelState.Clear();
                    ViewBag.Message = "Thank you for Contacting us.";
                }
                catch (Exception ex)
                {
                    ModelState.Clear();
                    ViewBag.Message = "Sorry your message was not sent." + ex;
                }
            }

            return View();
        }
        public ActionResult Error()
        {
            return View();
        }
    }
}