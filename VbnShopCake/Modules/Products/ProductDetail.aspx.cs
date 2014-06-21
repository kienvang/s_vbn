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
using Library.Tools;
using LayerHelper.ShopCake.BLL;
using LayerHelper.ShopCake.DAL.EntityClasses;
using Modules.Resource;

public partial class Modules_Products_ProductDetail : System.Web.UI.Page
{
    public int IntId
    {
        get
        {
            return !string.IsNullOrEmpty(Request["IntId"]) ? FNumber.ConvertInt(Request["IntId"]) : 0;
        }
    }

    public string TextId
    {
        get
        {
            return !string.IsNullOrEmpty(Request["textId"]) ? Request["textId"] : "";
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        ProductsEntity product = ProductsManager.CreateInstant().GetProductByIntIdTextId(IntId, TextId);
        if (product != null)
        {
            string catName = CatalogsManager.CreateInstant().GetCatalogName(product.CatalogId);

            string title = "VBN_Vietnam Bakery Network - " + catName + " - " + product.ProductName;
            string description = product.Abstract;
            string keywords = GetGlobalResourceObject(EnumsResourcesName.HeaderTags, "Home" + ResourcesEntity.SKeyWords).ToString();

            ResourcesEntity.CreateInstant().SetPage(Page, title, description, keywords);
        }
    }
}
