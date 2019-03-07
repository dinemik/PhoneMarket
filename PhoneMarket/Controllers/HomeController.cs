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

        public ActionResult Index(FilterModel filter)
        {
            ViewBag.Phones = Filter.GetFiltred(filter);

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