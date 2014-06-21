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
/// Summary description for CheckRoles
/// </summary>
namespace Modules.Role
{
    public class CheckRoles
    {
        public static CheckRoles CreateInstant()
        {
            return new CheckRoles();
        }

        public bool IsRoles(params string[] roles)
        {
            bool isrole = false;

            for (int i = 0; i < roles.Length; i++)
            {
                if (HttpContext.Current.User.IsInRole(roles[i]))
                {
                    isrole = true;
                    break;
                }
            }

            return isrole;
        }

        public string GetUrlDirect(string param)
        {
            if (!Config.IsLoginDomain())
                return EnumsUrlDirect.LoginUrlTest + "?ReturnUrl=" + HttpContext.Current.Server.UrlEncode(Library.Tools.UrlBuilder.RootUrl + param);
            return EnumsUrlDirect.LoginUrl + "?ReturnUrl=" + HttpContext.Current.Server.UrlEncode(Library.Tools.UrlBuilder.RootUrl + param);
        }
    }
}