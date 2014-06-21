using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

using Modules.Role;

public partial class Modules_Products_Payment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (!CheckRoles.CreateInstant().IsRoles(EnumsRoles.UserMember))
            {
                if (Convert.ToBoolean(Session["guest"]) == false)
                    Response.Redirect(CheckRoles.CreateInstant().GetUrlDirect(Request.RawUrl));
            }
        }
    }
}
