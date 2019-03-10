using PhoneMarket.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace PhoneMarket.Class
{
    public static class PhoneFlter
    {
        private static PhonesDb db = new PhonesDb();

        public static IEnumerable<Phone> GetFiltred(FilterModel filt)
        {
            IEnumerable<Phone> FilteredPhones = db.Phones;

            if (filt.MinPrice != null && filt.MaxPrice != null && filt.MinPrice < filt.MaxPrice)
                FilteredPhones = FilteredPhones.Where(o => o.Price >= filt.MinPrice && o.Price <= filt.MaxPrice);

            if (filt.Stor != null)
                FilteredPhones = FilteredPhones.Where(o => o.Storage == filt.Stor);

            if (filt.Sys != null)
                FilteredPhones = FilteredPhones.Where(o => o.System == filt.Sys);

            return FilteredPhones;
        }

        public static Phone GetFiltredByID(int? id) => db.Phones.FirstOrDefault(o => o.Id == id);
    }
}