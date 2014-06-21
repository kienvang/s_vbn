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
using Library.Tools;

public partial class Modules_Home_Controls_Catalogs : System.Web.UI.UserControl
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
        //if (!IsPostBack)
        //{
            LoadParent();
        //}
    }

    void LoadParent()
    {
        EntityCollection<CatalogsEntity> cats = CatalogsManager.CreateInstant().GetAllParent(null);
        repCatParent.DataSource = cats;
        repCatParent.DataBind();
    }

    public EntityCollection<CatalogsEntity> LoadChild(int ParentId)
    {
        EntityCollection<CatalogsEntity> cats = CatalogsManager.CreateInstant().GetByParentId2(ParentId);
        return cats;
    }
}
