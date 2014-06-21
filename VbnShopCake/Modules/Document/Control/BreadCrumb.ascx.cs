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
using LayerHelper.ShopCake.BLL;
using LayerHelper.ShopCake.DAL.EntityClasses;
using LayerHelper.ShopCake.DAL.HelperClasses;
using Modules;
using Library.Tools;
public partial class Modules_Document_Control_BreadCrumb : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataTable dt = DocumentGroupManager.CreateInstant().selectbyIntId(IntId);
            repBreadCrumb.DataSource = dt;
            repBreadCrumb.DataBind();
        }

    }
    public string Name
    {
        get { return !string.IsNullOrEmpty(Request["name"]) ? Request["name"] : ""; }
    }
    public int IntId
    {
        get { return !string.IsNullOrEmpty(Request["id"]) ? FString.IsInteger(Request["id"]) ? int.Parse(Request["id"]) : -1 : -1; }
    }
}
