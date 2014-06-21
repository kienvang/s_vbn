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

public partial class Modules_Catalogs_Controls_BreadCrumb : System.Web.UI.UserControl
{
    public int CatId
    {
        get
        {
            return !string.IsNullOrEmpty(Request["catId"]) ? FNumber.ConvertInt(Request["catId"]) : 0;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        LoadData();
    }

    void LoadData()
    {
        DataTable table = CatalogsManager.CreateInstant().GetListCatalogById(CatId);
        repBreadCrumb.DataSource = table;
        repBreadCrumb.DataBind();
    }
}
