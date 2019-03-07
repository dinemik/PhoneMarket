using PhoneMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhoneMarket.Controllers
{
    public class HomeController : Controller
    {
        private PhonesDb db = new PhonesDb();

        public ActionResult Index(int? MinPrice, int? MaxPrice, string Stor, string Sys)
        {
            if(MinPrice == null && MaxPrice == null && Stor == null && Sys == null)
                ViewBag.Phones = db.Phones;
            else
            {
                var tmp = db.Phones.ToList();

                if (MinPrice != null)
                    tmp = tmp.Where(o => o.Price >= MinPrice).ToList();

                if (MaxPrice != null)
                    tmp = tmp.Where(o => o.Price <= MaxPrice).ToList();

                if(Stor != null)
                {
                    int.TryParse(Stor, out int stor);
                    tmp = tmp.Where(o => o.Storage == stor).ToList();
                }

                if(Sys != null)
                    tmp = tmp.Where(o => o.System == Sys).ToList();

                ViewBag.Phones = tmp;
            }

            return View();
        }

        public ActionResult More(int? id)
        {
            foreach (var item in db.Phones)
            {
                if (item.Id == id)
                    ViewBag.Phone = item;
            }
            return View();
        }
    }
}