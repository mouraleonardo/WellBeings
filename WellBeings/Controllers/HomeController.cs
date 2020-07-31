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
        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Our team will be happy to answer store and product-related questions.";

        //    if (!Page.IsPostBack)
        //    {
        //        HttpCookie c = Request.Cookies["test"];
        //        if (c != null)
        //        {
        //            Response.Write(String.Format("test value is {0} <br />", c.Value));
        //        }
        //    }
        //    else
        //    {
        //        HttpCookie c = new HttpCookie("test");
        //        c.Value = "HERE IT IS";
        //        Response.Cookies.Add(c);
        //    }

        //    return View();
        //}

        //[HttpPost]
        //public ActionResult SubmitAction(string model)
        //{
        //    var value1 = model.SimpleProp1;
        //    var value2 = model.SimpleProp2;
        //    var value3 = model.ComplexProp1.SimpleProp1;
        //    return something...
        //}
    }
}