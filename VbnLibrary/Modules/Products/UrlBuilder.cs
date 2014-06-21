using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

using Library.Tools;

/// <summary>
/// Summary description for UrlBuilder
/// </summary>
namespace Modules.Products
{
    public class UrlBuilder
    {
        public static string RootUrl
        {
            get { return Library.Tools.UrlBuilder.RootUrl + "/san-pham"; }
        }

        public static string Products()
        {
            string url = "";

            if (Config.IsUrlRewrite())
            {
                url = Library.Tools.UrlBuilder.RootUrl + "/san-pham.html";
            }
            else
            {
                url = "/Modules/Products/Products.aspx";
            }

            return url;
        }

        public static string Carts()
        {
            string url = "";

            if (Config.IsUrlRewrite())
            {
                url = Library.Tools.UrlBuilder.RootUrl + "/san-pham/gio-hang.html";
            }
            else
            {
                url = "/Modules/Products/Carts.aspx";
            }

            return url;
        }

        public static string ViewDetail(int CatId, string CatTextId, int IntId, string ProductTextId)
        {
            string url = "";

            if (!Config.IsUrlRewrite())
            {
                url = "/Modules/Products/ProductDetail.aspx?" +
                      "catId=" + CatId.ToString() +
                      "&IntId=" + IntId.ToString() +
                      "&catTextId=" + CatTextId +
                      "&textId=" + ProductTextId;
            }
            else
            {
                url = RootUrl +
                    "/mua-hang" +
                    "/" + CatId.ToString() +
                    "/" + IntId.ToString() +
                    "/" + CatTextId +
                    "/" + ProductTextId +
                    ".html";
            }

            return url;
        }

        public static string QuickSearch(string ProductName)
        {
            string url = "";

            if (!Config.IsUrlRewrite())
            {
                url = "/Modules/Products/QuickSearch.aspx?" +
                      "ProductName=" + ProductName;
            }
            else
            {
                url = RootUrl +
                    "/tim-kiem-nhanh" +
                    "/" + HttpContext.Current.Server.UrlEncode(ProductName) +
                    ".html";
            }

            return url;
        }

        public static string QuickSearchPaging(string ProductName)
        {
            string url = "";

            if (!Config.IsUrlRewrite())
            {
                url = "/Modules/Products/QuickSearch.aspx?" +
                      "ProductName=" + ProductName +
                      "&page={0}";
            }
            else
            {
                url = RootUrl +
                    "/tim-kiem-nhanh" +
                    "/" + HttpContext.Current.Server.UrlEncode(ProductName) +
                    "/trang-{0}" +
                    ".html";
            }

            return url;
        }

        public static string Search(string ProductName, string Price, string catalogName)
        {
            string url = "";

            url = "/Modules/Products/Search.aspx?" +
                  "p=" + HttpContext.Current.Server.UrlEncode(ProductName) +
                  "&pr=" + HttpContext.Current.Server.UrlEncode(Price) +
                  "&c=" + HttpContext.Current.Server.UrlEncode(catalogName);

            return url;
        }

        public static string SearchPaging(string ProductName, string Price, string catalogName)
        {
            string url = "";

            url = "/Modules/Products/Search.aspx?" +
                   "p=" + HttpContext.Current.Server.UrlEncode(ProductName) +
                   "&pr=" + HttpContext.Current.Server.UrlEncode(Price) +
                   "&c=" + HttpContext.Current.Server.UrlEncode(catalogName) +
                   "&page={0}";

            return url;
        }
    }
}