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

public partial class Admin_Videos_Catalog : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            loadData();
        }
    }

    void loadData()
    {
        DataTable table = VideoCatalogManager.CreateInstant().SelectAllRDT();
        if (table != null && table.Rows.Count > 0)
        {
            table.DefaultView.Sort = "CatName";
            repCat.DataSource = table.DefaultView;
            repCat.DataBind();
        }
    }

    protected void repCat_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        switch (e.CommandName)
        {
            case "del":
                VideoCatalogManager.CreateInstant().DeleteCatById(int.Parse(e.CommandArgument.ToString()));
                Response.Redirect(Request.RawUrl);
                break;
        }
    }
}
