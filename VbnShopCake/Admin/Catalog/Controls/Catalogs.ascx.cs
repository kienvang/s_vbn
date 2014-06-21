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

public partial class Admin_Catalog_Controls_Catalogs : System.Web.UI.UserControl
{
    public int ParentId = 0;
    public int Id = 10;
    public bool IsLeaf = true;

    public CatalogsEntity catParent;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadData();
        }
    }

    void LoadData()
    {
        catParent = CatalogsManager.CreateInstant().SelectOne(Id);
        if (catParent != null)
        {
            ParentId = catParent.ParentId;
            IsLeaf = catParent.IsLeaf;
        }

        EntityCollection<CatalogsEntity> cats = CatalogsManager.CreateInstant().GetByParentId(Id, null);
        repCatalog.DataSource = cats;
        repCatalog.DataBind();
    }
}
