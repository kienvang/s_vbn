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
/// Summary description for Enums
/// </summary>
namespace Modules.Role
{
    public class EnumsRoles
    {
        public const string UserMember = "Members";
        public const string Administrator = "Administrator";
    }

    public class EnumsUrlDirect
    {
        public const string LoginUrlTest = "/DangNhap.aspx";
        public const string LoginUrl = "http://dangnhap.vbn.vn/dangnhap.aspx";
    }
}