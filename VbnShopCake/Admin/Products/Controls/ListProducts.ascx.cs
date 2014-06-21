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
using Modules.Products;
using Library.Tools;

public partial class Admin_Products_Controls_ListProducts : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GridView1.PageSize = 100;
            LoadData();
        }
    }

    void LoadData()
    {
        DataTable table = ProductsManager.CreateInstant().Search(Request["p"], Request["pr"], Request["c"]);
        GridView1.DataSource = table;
        GridView1.DataBind();
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (!Util.IsGuid(e.CommandArgument.ToString())) return;

        ProductsEntity product = ProductsManager.CreateInstant().SelectOne(new Guid(e.CommandArgument.ToString()));
        if (product == null) return;
        switch (e.CommandName)
        {
            case "isvisible":
                product.IsVisible = !product.IsVisible;
                HistoryProductManager.CreateInstant().AddHistory(EnumsAction.UpdateIsVisible, product.Id);
                break;
            case "del":
                HistoryProductManager.CreateInstant().AddHistory(EnumsAction.UpdateDel, product.Id);
                product.IsDelete = !product.IsDelete;
                break;
        }
        ProductsManager.CreateInstant().Update(product);
        Response.Redirect("/Admin/Products/");
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        LoadData();
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Admin/Products/?p=" + Server.UrlEncode(txtProductName.Text.Trim()) +
            "&c=" + Server.UrlEncode(txtCatalogName.Text.Trim()) +
            "&pr=" + Server.UrlEncode(ddlPrice.SelectedValue));
    }
}
