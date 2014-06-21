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
/// Summary description for Filter
/// </summary>
namespace Library.Tools
{
    public class Filter
    {
        public static string GetMaxString(string data, int MaxLength)
        {
            string str = data;
            if (data.Length > MaxLength)
                str = data.Substring(0, MaxLength - 1);
            return str;
        }

        public static string GetMaxStringFilter(string data)
        {
            string str = FilterHtml.CreateInstant().Filter_RemoveHtmlTag2(data);
            //if (str.Length > MaxLength)
            //    str = str.Substring(0, MaxLength - 1);
            return str;
        }

        public static string GetStringNoHtml(string data, int MaxLength)
        {
            return FilterHtml.CreateInstant().Filter_TextWithNumbersAndSpecialCharactersFew(data, MaxLength);
        }

        public static string Encoding(string data)
        {
            return HttpContext.Current.Server.HtmlEncode(data);
        }
    }
}