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

/// <summary>
/// Summary description for Catalogs
/// </summary>
namespace Modules.Catalogs
{
    public class UrlBuilder
    {
        public static string RootUrl
        {
            get { return Library.Tools.UrlBuilder.RootUrl; }
        }

        public static string GetCatsByIdTextId(int CatId, string CatTextId)
        {
            string url = "";

            if (!Config.IsUrlRewrite())
            {
                url = "/Modules/Products/ProductList.aspx?catId=" + CatId.ToString() +
                    "&textId=" + CatTextId;
            }
            else
            {
                url = RootUrl +
                    "/danh-muc" +
                    "/" + CatId.ToString() +
                    "/" + CatTextId +
                    ".html";
            }

            return url;
        }

        public static string GetCatsByIdTextIdPagging(int CatId, string CatTextId)
        {
            string url = "";

            if (Config.IsUrlRewrite())
            {
                url = RootUrl +
                    "/danh-muc" +
                    "/" + CatId.ToString() +
                    "/" + CatTextId +
                    "/trang-{0}" +
                    ".html";
            }
            else
            {
                url = "/Modules/Products/ProductList.aspx?catId=" + CatId.ToString() +
                    "&textId=" + CatTextId +
                    "&page={0}";
            }

            return url;
        }
    }
}