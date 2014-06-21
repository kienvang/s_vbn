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
/// Summary description for Config
/// </summary>
namespace Modules
{
    public class Config
    {
        public static int GetTopHome()
        {
            return int.Parse(ConfigurationManager.AppSettings["TopHome"]);
        }

        public static int GetMaxItemInCart()
        {
            return int.Parse(ConfigurationManager.AppSettings["MaxItemInCart"]);
        }

        public static int GetPagging()
        {
            return int.Parse(ConfigurationManager.AppSettings["Pagging"]);
        }

        public static int GetTopVideo()
        {
            return int.Parse(ConfigurationManager.AppSettings["TopVideo"]);
        }

        public static bool IsUrlRewrite()
        {
            return bool.Parse(ConfigurationManager.AppSettings["UrlRewrite"]);
        }

        public static bool IsLoginDomain()
        {
            return bool.Parse(ConfigurationManager.AppSettings["loginDomain"]);
        }

        public static string UploadDoc()
        {
            return ConfigurationManager.AppSettings["uploadDoc"];
        }
    }
}