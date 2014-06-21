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
/// Summary description for EnumsTags
/// </summary>
namespace Modules
{
    public class EnumsTags
    {
        public const string PAID = "PAY";
        public const string CANCEL = "CAN";
        public const string WAIT = "WAT";
    }
}