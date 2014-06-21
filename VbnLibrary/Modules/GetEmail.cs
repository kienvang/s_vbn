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
/// Summary description for GetEmail
/// </summary>
namespace Modules
{
    public class GetEmail
    {
        public static string EmailFrom
        {
            get
            {
                return ConfigurationManager.AppSettings["emailFrom"];
            }
        }

        public static string EmailTo
        {
            get
            {
                return ConfigurationManager.AppSettings["emailTo"];
            }
        }

        public static string CombineEmail(params string[] email)
        {
            string e = "";
            for (int i = 0; i < email.Length; i++)
                e += email[i] + ",";
            return e.Trim(',');
        }
    }
}