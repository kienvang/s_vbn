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

public partial class Admin_Orders_Controls_DetailEmail : System.Web.UI.UserControl
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
            LoadData();
    }

    void LoadData()
    {
        DataTable table = HistoryEmailManager.CreateInstant().SelectByOrderCodeRDT(OrderNumber);
        table.DefaultView.Sort = "ReceiveDated desc";
        repHistory.DataSource = table;
        repHistory.DataBind();
    }
}
