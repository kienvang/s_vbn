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

public partial class Modules_Products_Controls_ProductPhoto : System.Web.UI.UserControl
{
    public int IntId
    {
        get
        {
            return !string.IsNullOrEmpty(Request["IntId"]) ? FNumber.ConvertInt(Request["IntId"]) : 0;
        }
    }

    public string ProductName = "";
    public string path = "";
    public int Total = 0;
    public string TextId
    {
        get
        {
            return !string.IsNullOrEmpty(Request["textId"]) ? Request["textId"] : "";
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        LoadData();
    }

    void LoadData()
    {
        ProductsEntity product = ProductsManager.CreateInstant().GetProductByIntIdTextId(IntId, TextId);
        if (product != null)
        {
            ProductName = product.ProductName;

            DataTable table = ProductPhotosManager.CreateInstant().GetProductPhotos(product.Id, true);
            repPhoto.DataSource = table;
            Total = table.Rows.Count;
            //Response.Write(Total);
            repPhoto.DataBind();
            if (table == null || table.Rows.Count <= 0)
            {
                this.Visible = false;
            }
            return;



        }
    }
}
