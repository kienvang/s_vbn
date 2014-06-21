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
using Modules.Cart;
using Modules.Products;
using Modules.Resource;

public partial class Modules_Products_Controls_ProductDetail : System.Web.UI.UserControl
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

    public string UrlPost = "";

    public string TextId
    {
        get
        {
            return !string.IsNullOrEmpty(Request["textId"]) ? Request["textId"] : "";
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadData();
            LoadSub();
            txtQuantity.Text = "1";
        }
    }

    void LoadSub()
    {
        ProductsEntity product = ProductsManager.CreateInstant().GetProductByIntIdTextId(IntId, TextId);
        if (product != null)
        {
            DataTable sub = ProductSubManager.CreateInstant().SelectByProductIdRDT(product.Id);

            if (sub != null && sub.Rows.Count > 0)
            {
                itemGroup.Visible = true;

                sub.DefaultView.Sort = "ProductName";
                foreach (DataRow r in sub.DefaultView.Table.Rows)
                {
                    ListItem item = new ListItem();
                    item.Text = r["ProductName"].ToString() + " - " + FNumber.FormatNumber(r["Price"]) + " VND";
                    item.Value = r["Id"].ToString();
                    rdoListSub.Items.Add(item);
                }

                rdoListSub.Items[0].Selected = true;
            }
            else
            {
                itemSingle.Visible = true;
                itemPrice.Visible = true;
            }
        }
    }

    void LoadData()
    {
        ProductsEntity product = ProductsManager.CreateInstant().GetProductByIntIdTextId(IntId, TextId);
        if (product != null)
        {
            if (!string.IsNullOrEmpty(product.Thumbnail))
            {
                img.ImageUrl = product.Thumbnail + "?w=280&h=180&c=0";
                path = product.Thumbnail;
            }
            else
            {
                img.ImageUrl = "/images/no_img.gif";
                path = "/images/no_img.gif";
            }

            img.ToolTip = product.ProductName;

            //img.DescriptionUrl = product.ProductName;

            ProductName = product.ProductName;
            lblProductCode.Text = product.ProductCode;
            lblProductName.Text = ProductName;
            lblAbstract.Text = product.Abstract;
            lblWarranty.Text = product.Warranty;
            if (product.Price <= 0)
                lblPrice.Text = "Vui lòng liên hệ sau";
            else
                lblPrice.Text = FNumber.FormatNumber(product.Price) + " VND";
            lblDetail.Text = product.Detail;
        }
    }

    protected void btnOrder_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            ProductsEntity product = ProductsManager.CreateInstant().GetProductByIntIdTextId(IntId, TextId);
            if (product != null)
            {
                int quantity = FNumber.ConvertInt(txtQuantity.Text.Trim());
                CartsSession.CreateInstant().AddCart(this.Page, product.Id, quantity);

                Response.Redirect(Modules.Products.UrlBuilder.Carts());
            }
        }
    }

    protected void btnOrderSub_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            ProductsEntity product = ProductsManager.CreateInstant().GetProductByIntIdTextId(IntId, TextId);
            if (product != null && !string.IsNullOrEmpty(rdoListSub.SelectedValue) && Util.IsGuid(rdoListSub.SelectedValue))
            {
                Guid subId = new Guid(rdoListSub.SelectedValue);
                ProductSubEntity sub = ProductSubManager.CreateInstant().SelectOne(subId);
                if (sub != null)
                {
                    CartsSession.CreateInstant().AddCart(Page, product.Id, sub.Id);
                    Response.Redirect(Modules.Products.UrlBuilder.Carts());
                }
            }
        }
    }

}
