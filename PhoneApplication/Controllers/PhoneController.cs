using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhoneApplication.Models;

namespace PhoneApplication.Controllers
{
    public class PhoneController : Controller
    {
        // GET: Phone
        public ActionResult Index()
        {
            var PhoneList = new List<Phone>
            {
            new Phone { PhoneName="iPhone 11" , 
                Manufacturer = "Apple",
                MSRP=1080.50 ,
                DateReleased= new DateTime(2019,12,08) },

            new Phone {  PhoneName="iPhone 11 Pro",  
                Manufacturer = "Apple",
                MSRP=1500.50 ,
                DateReleased= new DateTime(2019,12,08) },

            new Phone {  PhoneName="Samsung Note 10",
                Manufacturer = "Samsung",
                MSRP=965.50 ,
                DateReleased= new DateTime(2017,10,05) },

            new Phone {  PhoneName="Google Pixel", 
                Manufacturer = "Google" , 
                MSRP=852.50 , 
                DateReleased= new DateTime(2017,10,02)},

            new Phone {  PhoneName="One Plus 7T", 
                Manufacturer = "One Plus" ,
                MSRP=750.50 , 
                DateReleased= new DateTime(2019,06,15)}

            };
            return View(PhoneList);
        }
    }
}