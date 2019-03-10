using PhoneMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhoneMarket.Helpers
{
    public static class PhoneListHelper
    {
        public static MvcHtmlString CreatePhonesList(this HtmlHelper html, IEnumerable<Phone> phones)
        {
            TagBuilder Main = new TagBuilder("div");

            foreach (var item in phones)
            {
                TagBuilder CardDiv = new TagBuilder("div");
                CardDiv.AddCssClass("card");

                TagBuilder a_TagImg = new TagBuilder("a");
                a_TagImg.MergeAttribute("href", $"/home/More/{item.Id}");

                TagBuilder Img = new TagBuilder("img");
                Img.AddCssClass("card-img-top");
                Img.MergeAttribute("src", $"{item.Img}");

                a_TagImg.InnerHtml = Img.ToString();
                CardDiv.InnerHtml = a_TagImg.ToString();


                TagBuilder CardBodyDiv = new TagBuilder("div");
                CardBodyDiv.AddCssClass("card-body");

                TagBuilder Name = new TagBuilder("h5");
                Name.AddCssClass("card-title");
                Name.InnerHtml = $"{item.Firm}  {item.Model}";

                CardBodyDiv.InnerHtml = Name.ToString();

                TagBuilder Price = new TagBuilder("p");
                Price.AddCssClass("card-text");
                Price.InnerHtml = $"Phone Price: {item.Price} $";

                CardBodyDiv.InnerHtml += Price.ToString();
                CardDiv.InnerHtml += CardBodyDiv.ToString();

                Main.InnerHtml += CardDiv.ToString();
            }
            return new MvcHtmlString(Main.ToString());
        }
    }
}