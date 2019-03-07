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
            {
                ViewBag.Phones = db.Phones;
            }
            else
            {
                var tmp = db.Phones.ToList();

                if (MinPrice > MaxPrice)
                    return Content("MinPrice > MaxPrice WTF? go back and try again");
                else if ((MinPrice == null && MaxPrice != null) || (MinPrice != null && MaxPrice == null))
                    return Content("Enter Correct Price");
                else if (MinPrice == null && MaxPrice == null) ;
                else
                {
                    for (int i = 0; i < tmp.Count; i++)
                    {
                        if (tmp[i].Price < MinPrice || tmp[i].Price > MaxPrice)
                        {
                            tmp.Remove(tmp[i]);
                            i--;
                        }
                    }
                }

                if(Stor != null)
                {
                    for (int i = 0; i < tmp.Count; i++)
                    {
                        int.TryParse(Stor, out int stor);
                        if (tmp[i].Storage != stor)
                        {
                            tmp.Remove(tmp[i]);
                            i--;
                        }
                    }
                }

                if (Sys != null)
                {
                    for (int i = 0; i < tmp.Count; i++)
                    {
                        int.TryParse(Stor, out int stor);
                        if (tmp[i].System != Sys)
                        {
                            tmp.Remove(tmp[i]);
                            i--;
                        }
                    }
                }

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