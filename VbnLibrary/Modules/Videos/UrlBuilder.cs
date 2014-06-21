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
/// Summary description for UrlBuilder
/// </summary>
namespace Modules.Videos
{
    public class UrlBuilder
    {
        public static string RootUrl
        {
            get
            {
                return Library.Tools.UrlBuilder.RootUrl + "/videos";
            }
        }

        public static string Videos()
        {
            string url = "";

            if (Config.IsUrlRewrite())
            {
                url = "/videos.html";
            }
            else
            {
                url = "/Modules/Videos/Default.aspx";
            }

            return url;
        }

        public static string ViewVideo(int IntId, string TextId)
        {
            string url = "";

            if (Config.IsUrlRewrite())
            {
                url = RootUrl +
                    "/" + IntId.ToString() +
                    "/" + TextId +
                    ".html";
            }
            else
            {
                url = "/Modules/Videos/Default.aspx?" +
                      "IntId=" + IntId.ToString() +
                      "&textid=" + TextId;
            }

            return url;
        }

        public static string ViewVideo(string CatTextId, int IntId, string TextId)
        {
            string url = "";

            if (Config.IsUrlRewrite())
            {
                url = RootUrl +
                    "/" + CatTextId +
                    "/" + IntId.ToString() +
                    "/" + TextId +
                    ".html";
            }
            else
            {
                url = "/Modules/Videos/Default2.aspx?" +
                      "CatTextId=" + CatTextId +
                      "&IntId=" + IntId.ToString() +
                      "&textid=" + TextId;
            }

            return url;
        }

        public static string VideoCatalog(string CatTextId)
        {
            string url = "";

            if (Config.IsUrlRewrite())
            {
                url = RootUrl +
                    "/" + CatTextId +
                    ".html";
            }
            else
            {
                url = "/Modules/Videos/Default2.aspx?" +
                      "CatTextId=" + CatTextId;
            }

            return url;
        }
    }
}