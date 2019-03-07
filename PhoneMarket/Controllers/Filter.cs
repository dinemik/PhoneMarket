using PhoneMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneMarket.Controllers
{
    public class Filter
    {
        private static PhonesDb db = new PhonesDb();

        public static List<Phone> GetFiltred(FilterModel filt)
        {
            var tmp = db.Phones.ToList();

            if (filt.MinPrice == null && filt.MaxPrice == null && filt.Stor == null && filt.Sys == null)
                return tmp;

            tmp = filt.MinPrice != null ? tmp.Where(o => o.Price >= filt.MinPrice).ToList() : tmp;

            tmp = filt.MaxPrice != null ? tmp.Where(o => o.Price <= filt.MaxPrice).ToList() : tmp;

            int.TryParse(filt.Stor, out int stor);
            tmp = filt.Stor != null ? tmp.Where(o => o.Storage == stor).ToList() : tmp;

            tmp = filt.Sys != null ? tmp.Where(o => o.System == filt.Sys).ToList() : tmp;

            return tmp;
        }
    }
}