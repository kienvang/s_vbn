using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modules
{
    public class UrlBuilder
    {
        public static string ProductRegister()
        {
            string url = "";

            if (Config.IsUrlRewrite())
            {
                url = "/dang-ky/dang-ky-ban-hang.html";
            }
            else
            {
                url = "/Modules/Registers/ProductRegister.aspx";
            }

            return Library.Tools.UrlBuilder.RootUrl + url;
        }

        public static string SupplierRegister()
        {
            string url = "";

            if (Config.IsUrlRewrite())
            {
                url = "/dang-ky/dang-ky-nha-cung-cap.html";
            }
            else
            {
                url = "/Modules/Registers/SupplierRegister.aspx";
            }

            return Library.Tools.UrlBuilder.RootUrl + url;
        }

        public static string ProductRegisterComplete()
        {
            string url = "";

            if (Config.IsUrlRewrite())
            {
                url = "/cam-on/dang-ky-ban-hang-thanh-cong.html";
            }
            else
            {
                url = "/Modules/Registers/ThankProductRegister.aspx";
            }

            return Library.Tools.UrlBuilder.RootUrl + url;
        }

        public static string SupplierRegisterComplete()
        {
            string url = "";

            if (Config.IsUrlRewrite())
            {
                url = "/cam-on/dang-ky-nha-cung-cap-thanh-cong.html";
            }
            else
            {
                url = "/Modules/Registers/ThankSupplierRegister.aspx";
            }

            return Library.Tools.UrlBuilder.RootUrl + url;
        }

        public static string Contact()
        {
            string url = "";

            if (Config.IsUrlRewrite())
            {
                url = "/gioi-thieu.html";
            }
            else
            {
                url = "/Contact.aspx";
            }

            return Library.Tools.UrlBuilder.RootUrl + url;
        }

        public static string FeedBack()
        {
            string url = "";

            if (Config.IsUrlRewrite())
            {
                url = "/lien-he.html";
            }
            else
            {
                url = "/Modules/FeedBack/FeedBack.aspx";
            }

            return Library.Tools.UrlBuilder.RootUrl + url;
        }

        public static string FeedBackComplete()
        {
            string url = "";

            if (Config.IsUrlRewrite())
            {
                url = "/lien-he-thanh-cong.html";
            }
            else
            {
                url = "/Modules/FeedBack/FeedBackComplete.aspx";
            }

            return Library.Tools.UrlBuilder.RootUrl + url;
        }

        public static string GetNews(string TextId)
        {
            string url = "";

            if (Config.IsUrlRewrite())
            {
                url = "/tin-tuc" +
                      "/" + TextId +
                      ".html";
            }
            else
            {
                url = "/Modules/News/News.aspx?textId=" + TextId;
            }

            return Library.Tools.UrlBuilder.RootUrl + url;
        }
    }
}
