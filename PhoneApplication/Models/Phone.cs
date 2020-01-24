using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PhoneApplication.Models;

namespace PhoneApplication.Models
{
    public class Phone
    {
            public Phone ()
            {
               
                PhoneName = "";
                Manufacturer="";
                MSRP = 0;
                ScreenSize = 0;
            DateReleased = DateTime.Now;
            }

        public string PhoneName { get; set; }
        public int PhoneID { get; set; }
        public string Manufacturer { get; set; }
        public DateTime DateReleased { get; set; }
        public double MSRP { get; set; }
        public float ScreenSize { get; set; }



    }
}