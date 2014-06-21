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

public partial class Admin_Catalog_Webservices_GetCatalog : System.Web.UI.Page
{
    public int ParentId = 0;
    public int Id = 10;
    public bool IsLeaf = true;

    public CatalogsEntity catParent;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Id = int.Parse(Request["Id"]);
            catParent = CatalogsManager.CreateInstant().SelectOne(Id);
            if (catParent != null)
            {
                ParentId = catParent.ParentId;
                IsLeaf = catParent.IsLeaf;

                if (Request["t"] == "prev")
                {
                    LoadData(catParent.ParentId);

                }
                else
                {
                    LoadData(Id);
                }
            }

            string html = Library.Tools.Util.RenderControl((Control)cats);
            Response.Write(html);
            Response.End();
        }
    }

    void LoadData(int catId)
    {
        EntityCollection<CatalogsEntity> cats = CatalogsManager.CreateInstant().GetByParentId(catId, null);
        repCatalog.DataSource = cats;
        repCatalog.DataBind();
    }
}
