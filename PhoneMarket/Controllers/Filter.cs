using PhoneMarket.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PhoneMarket.Controllers
{
    public class Filter
    {
        private static PhonesDb db;
        static Filter()
        {
            db = new PhonesDb();
            db.Phones.Load();
        }

        public static IEnumerable<Phone> GetFiltred(FilterModel filt)
        {
            IEnumerable<Phone> FilteredPhones = db.Phones.Local.ToBindingList();

            if (filt.MinPrice != null && filt.MaxPrice != null && (filt.MinPrice < filt.MaxPrice))
                FilteredPhones = FilteredPhones.Where(o => o.Price >= filt.MinPrice && o.Price <= filt.MaxPrice);

            if (filt.Stor != null)
                FilteredPhones = FilteredPhones.Where(o => o.Storage == filt.Stor);

            if (filt.Sys != null)
                FilteredPhones = FilteredPhones.Where(o => o.System == filt.Sys);

            //if do not find anything  back to everyone. :)
            return FilteredPhones.Count() == 0 ? db.Phones : FilteredPhones;
        }

        public static Phone GetFiltredByID(int? id) => db.Phones.FirstOrDefault(o => o.Id == id);
    }
}