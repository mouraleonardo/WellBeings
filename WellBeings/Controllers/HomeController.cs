using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WellBeings.Data;

namespace WellBeings.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductsDataAccess _productsDataAccess;

        public HomeController()
        {
            _productsDataAccess = new ProductsDataAccess();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Products()
        {
            ViewBag.Message = "Products page.";
            ViewBag.Products = _productsDataAccess.GetProducts();

            return View();
        }

        public ActionResult Retailers()
        {
            ViewBag.Message = "Retailers page.";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Our team will be happy to answer store and product-related questions.";

            return View();
        }
    }
}