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
using Library.Tools;

public partial class Admin_Orders_Controls_DetailHistory : System.Web.UI.UserControl
{
    public string OrderNumber
    {
        get
        {
            return Request["OrderNumber"];
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataTable table = HistoryOrdersManager.CreateInstant().SelectByOrderCodeRDT(OrderNumber);
            table.DefaultView.Sort = "ActionDate desc";
            repHistory.DataSource = table.DefaultView;
            repHistory.DataBind();
        }
    }
}
