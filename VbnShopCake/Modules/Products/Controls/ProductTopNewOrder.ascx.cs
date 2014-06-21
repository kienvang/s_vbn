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

public partial class Modules_Products_Controls_ProductTopNewOrder : System.Web.UI.UserControl
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
        //if (!IsPostBack)
            LoadData();
    }

    void LoadData()
    {
        this.Visible = false;
        CatalogsEntity cat = CatalogsManager.CreateInstant().SelectOne(CatId);
        if (cat != null)
        {
            DataTable table = ProductsManager.CreateInstant().GetProductTopInParent(cat.ParentId);
            if (table != null && table.Rows.Count > 0)
            {
                this.Visible = true;

                last = table.Rows.Count - 1;

                dltProducts.DataSource = table;
                dltProducts.DataBind();
            }
        }
    }

    protected void dltProducts_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        switch (e.CommandName)
        {
            case "order":
                ProductsEntity product = ProductsManager.CreateInstant().SelectOne(new Guid(e.CommandArgument.ToString()));
                if (product != null)
                {
                    TextBox txt = (TextBox)e.Item.FindControl("txtQuantity");
                    if (txt != null)
                    {
                        int quantity = FNumber.ConvertInt(txt.Text);
                        if (quantity > 0)
                        {
                            CartsSession.CreateInstant().AddCart(Page, product.Id, quantity);
                            Response.Redirect(Modules.Products.UrlBuilder.Carts());
                        }
                    }
                }
                break;
        }
        Response.Redirect(Request.RawUrl);
    }
}
