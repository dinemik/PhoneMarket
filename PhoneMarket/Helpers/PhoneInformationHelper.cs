using PhoneMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhoneMarket.Helpers
{
    public static class PhoneInformationHelper
    {
        public static MvcHtmlString CreatePhonesList(this HtmlHelper html, Phone tmp)
        {
            TagBuilder CardDiv = new TagBuilder("div");
            CardDiv.AddCssClass("card");

            TagBuilder Img = new TagBuilder("img");
            Img.AddCssClass("card-img-top");
            Img.MergeAttribute("src", tmp.Img);

            CardDiv.InnerHtml = Img.ToString();

            TagBuilder InfoDiv = new TagBuilder("div");
            InfoDiv.AddCssClass("card-body");

            TagBuilder Name = new TagBuilder("h5");
            Name.AddCssClass("card-title");
            Name.InnerHtml += $"{tmp.Firm}  {tmp.Model}";
            InfoDiv.InnerHtml += Name.ToString();

            TagBuilder Size = new TagBuilder("p");
            Size.AddCssClass("card-text");
            Size.InnerHtml = $"Size: {tmp.Size}";
            InfoDiv.InnerHtml += Size.ToString();



            TagBuilder Weight = new TagBuilder("p");
            Weight.AddCssClass("card-text");
            Weight.InnerHtml = $"Weight: {tmp.Weight}";
            InfoDiv.InnerHtml += Weight.ToString();

            TagBuilder ScreenSize = new TagBuilder("p");
            ScreenSize.AddCssClass("card-text");
            ScreenSize.InnerHtml = $"Screen size: {tmp.ScreenSize}";
            InfoDiv.InnerHtml += ScreenSize.ToString();

            TagBuilder Resolution = new TagBuilder("p");
            Resolution.AddCssClass("card-text");
            Resolution.InnerHtml = $"Resolution: {tmp.Resolution}";
            InfoDiv.InnerHtml += Resolution.ToString();

            TagBuilder Processor = new TagBuilder("p");
            Processor.AddCssClass("card-text");
            Processor.InnerHtml = $"Processor: {tmp.Processor}";
            InfoDiv.InnerHtml += Processor.ToString();

            TagBuilder Storage = new TagBuilder("p");
            Storage.AddCssClass("card-text");
            Storage.InnerHtml = $"Storage: {tmp.Storage}";
            InfoDiv.InnerHtml += Storage.ToString();

            TagBuilder System = new TagBuilder("p");
            System.AddCssClass("card-text");
            System.InnerHtml = $"System: {tmp.System}";
            InfoDiv.InnerHtml += System.ToString();

            TagBuilder Price = new TagBuilder("p");
            Price.AddCssClass("card-text");
            Price.InnerHtml = $"Price: {tmp.Price}";
            InfoDiv.InnerHtml += Price.ToString();

            if (tmp.Video != null)
            {
                TagBuilder Video = new TagBuilder("iframe");
                Video.AddCssClass("Video");
                Video.MergeAttribute("src", tmp.Video);
                InfoDiv.InnerHtml += Video.ToString();
            }

            CardDiv.InnerHtml += InfoDiv.ToString();
            return new MvcHtmlString(CardDiv.ToString());
        }
    }
}