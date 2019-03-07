using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneMarket.Models
{
    public class Phone
    {
        public int Id { get; set; }

        public string Model { get; set; }

        public string Firm { get; set; }

        public int Size { get; set; }

        public double Weight { get; set; }

        public double ScreenSize { get; set; }

        public string Resolution { get; set; }

        public string Processor { get; set; }
            
        public int Storage { get; set; }

        public string System { get; set; }
        
        public string Img { get; set; }

        public string Video { get; set; }

        public int Price { get; set; }
    }
}