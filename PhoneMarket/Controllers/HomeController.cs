using PhoneMarket.Class;
using PhoneMarket.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhoneMarket.Controllers
{
    public class HomeController : Controller
    {
        private static PhonesDb db = new PhonesDb();

        public ActionResult Index(FilterModel filter)
        {
            ViewBag.Phones = PhoneFlter.GetFiltred(filter);

            return View();
        }

        public ActionResult More(int? id)
        {
            ViewBag.Phone = PhoneFlter.GetFiltredByID(id);

            return View();
        }
    }
}