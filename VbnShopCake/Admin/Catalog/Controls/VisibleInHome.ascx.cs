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

public partial class Admin_Catalog_Controls_VisibleInHome : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadData();
        }
    }

    void LoadData()
    {
        DataTable table = CatalogsManager.CreateInstant().SelectByIsVisibleRDT(true);
        table.DefaultView.Sort = "OrderIndex";
        repCatalog.DataSource = table.DefaultView;
        repCatalog.DataBind();
    }

    protected void repCatalog_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        int Id = int.Parse(e.CommandArgument.ToString());
        CatalogsEntity cat = CatalogsManager.CreateInstant().SelectOne(Id);
        switch (e.CommandName)
        {
            case "visiblehome":
                if (cat != null)
                {
                    cat.IsVisibleHome = !cat.IsVisibleHome;
                    CatalogsManager.CreateInstant().Update(cat);
                }
                break;
            case "order":
                TextBox txt = (TextBox)e.Item.FindControl("txtOrder");
                int order = 0;
                if (cat != null && txt != null && int.TryParse(txt.Text.Trim(), out order))
                {
                    CatalogsManager.CreateInstant().OrderInHome(cat.Id, order, cat.OrderIndex);
                }
                break;
        }

        Response.Redirect(Request.RawUrl);
    }
}
