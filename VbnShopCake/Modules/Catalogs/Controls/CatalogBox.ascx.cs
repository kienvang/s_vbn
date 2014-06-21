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

public partial class Modules_Catalogs_Controls_CatalogBox : System.Web.UI.UserControl
{
    public int CatId
    {
        get
        {
            return !string.IsNullOrEmpty(Request["catId"]) ? FNumber.ConvertInt(Request["catId"]) : 0;
        }
    }

    public int Total = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        LoadData();
    }

    void LoadData()
    {
        EntityCollection<CatalogsEntity> cats = CatalogsManager.CreateInstant().GetByParentId2(CatId);
        

        if (cats == null || cats.Count <= 0)
        {
            this.Visible = false;
        }
        else
        {
            Total = cats.Count;
            int tmp = Total / 2;
            if (Total % 2 != 0)
                tmp++;
            Total = tmp;
        }
        
        repCatChild.DataSource = cats;
        repCatChild.DataBind();
    }
}
