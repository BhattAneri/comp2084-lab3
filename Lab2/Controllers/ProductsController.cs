using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            var myArray = new List<string>
            { "Laptop",
               "Tablet",
              "Desktop" };
            ViewBag.products = myArray;
            return View();    
           
        }
        public string Details(string pro){
            
           string message = HttpUtility.HtmlEncode("You've Selected product:" +pro);
            return message;
        }
    }
}