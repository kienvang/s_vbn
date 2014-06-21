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
using LayerHelper.ShopCake.DAL.HelperClasses;

public partial class Admin_Products_Controls_Detail : System.Web.UI.UserControl
{
    public Guid ProductId
    {
        get
        {
            return !string.IsNullOrEmpty(Request["id"]) ? Util.IsGuid(Request["id"]) ? new Guid(Request["Id"]) : Guid.Empty : Guid.Empty;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            HttpCookie cookie = new HttpCookie("tabs", "");
            if (!string.IsNullOrEmpty(Request.QueryString["tabs"]))
                cookie.Value = Request["tabs"];
            cookie.Path = "/Admin/Products/";
            Response.SetCookie(cookie);
        }
        LoadDetail();
    }

    void LoadDetail()
    {
        ProductsEntity product = ProductsManager.CreateInstant().SelectOne(ProductId, true);
        if (product != null)
        {
            Page.Title = "Sản phẩm - " + product.IntId.ToString() + " - " + product.ProductName;
            lblIntId.Text = product.IntId.ToString();
            lblProductName.Text = (!string.IsNullOrEmpty(product.ProductCode) ? product.ProductCode + " - " : "") + product.ProductName;
            lblSupplierName.Text = SuppliersManager.CreateInstant().GetSupplierName(product.SupplierId);
            lblCatalogName.Text = CatalogsManager.CreateInstant().GetCatalogName(product.CatalogId);
            if (string.IsNullOrEmpty(product.Thumbnail))
                imgThumbnail.Visible = false;
            else
                imgThumbnail.ImageUrl = product.Thumbnail;

            if (product.Amount < 0)
                lblAmount.Text = "Số lượng chưa xác định";
            else
                lblAmount.Text = product.Amount.ToString() + " " + product.Unit.UnitName;

            //----- Box Giá ------
            lblPriceBuy.Text = FNumber.FormatNumber(product.ProductInfo.PriceBuy, 0) + " " + product.ProductInfo.Currency;
            lblPriceSell.Text = FNumber.FormatNumber(product.ProductInfo.PriceSell, 0) + " " + product.ProductInfo.Currency;
            lblCommission.Text = FNumber.FormatNumber(product.ProductInfo.PriceSell - product.ProductInfo.PriceBuy, 0) + " " + product.ProductInfo.Currency;
        }
    }
}
