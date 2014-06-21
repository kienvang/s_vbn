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

public partial class Modules_News_Controls_BoxNews : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LoadData();
    }

    void LoadData()
    {
        DataTable table = NewsManager.CreateInstant().SelectByIsVisibleRDT(true);

        if (table != null && table.Rows.Count > 0)
        {
            table.DefaultView.Sort = "Subject";
            repNews.DataSource = table.DefaultView;
            repNews.DataBind();
        }
        else
            this.Visible = false;
    }
}
