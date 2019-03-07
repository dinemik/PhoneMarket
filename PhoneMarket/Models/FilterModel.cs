using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneMarket.Models
{
    public class FilterModel
    {
        public int? MinPrice { get; set; }

        public int? MaxPrice { get; set; }

        public string Stor { get; set; }

        public string Sys { get; set; }
    }
}