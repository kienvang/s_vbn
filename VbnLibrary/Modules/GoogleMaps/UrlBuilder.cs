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
/// 
namespace Modules.GoogleMaps
{
    public class UrlBuilder
    {
        public static string Root
        {
            get { return "/Modules/GoogleMaps"; }
        }
    }
}