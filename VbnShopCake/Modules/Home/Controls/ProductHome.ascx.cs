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

public partial class Modules_Home_Controls_ProductHome : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!IsPostBack)
        //{
            LoadCatalogHome();
        //}
    }

    public int last = -1;

    void LoadCatalogHome()
    {
        DataTable table = CatalogsManager.CreateInstant().GetVisibleInHome();
        repCatHome.DataSource = table;
        repCatHome.DataBind();
    }

    public DataTable GetProductHome(int CatalogId)
    {
        DataTable tbl = ProductsManager.CreateInstant().GetProductInCatalog(CatalogId);
        last = -1;
        if (tbl != null && tbl.Rows.Count > 0)
            last = tbl.Rows.Count - 1;
        return tbl;
    }
}
