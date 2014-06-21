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

using Library.Tools;

public partial class Modules_Products_Controls_ProductTopNew : System.Web.UI.UserControl
{
    public int IntId
    {
        get
        {
            return !string.IsNullOrEmpty(Request["IntId"]) ? FNumber.ConvertInt(Request["IntId"]) : 0;
        }
    }

    public int CatId
    {
        get
        {
            return !string.IsNullOrEmpty(Request["catId"]) ? FNumber.ConvertInt(Request["catId"]) : 0;
        }
    }

    public int last = -1;

    protected void Page_Load(object sender, EventArgs e)
    {
        LoadData();
    }

    void LoadData()
    {
        this.Visible = false;
        CatalogsEntity cat = CatalogsManager.CreateInstant().SelectOne(CatId);
        if (cat != null)
        {
            DataTable table = ProductsManager.CreateInstant().GetProductInCatalog(cat.Id, Modules.Config.GetTopHome());
            if (table != null && table.Rows.Count > 0)
            {
                this.Visible = true;
                last = table.Rows.Count - 1;
                dltProducts.DataSource = table;
                dltProducts.DataBind();
            }
        }
    }
}
