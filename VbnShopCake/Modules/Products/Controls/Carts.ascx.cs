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

using Modules.Cart;
using Library.Tools;
using System.Collections.Generic;

public partial class Modules_Products_Controls_Carts : System.Web.UI.UserControl
{
    public decimal Total = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadData();
            Session["guest"] = false;
        }
    }

    void LoadData()
    {
        DataTable table = CartsSession.CreateInstant().GetCartRDT(this.Page);
        repCart.DataSource = table;
        repCart.DataBind();

        if (table != null && table.Rows.Count > 0)
        {
            btnPayment.Visible = true;
            btnReCal.Visible = true;

            if (string.IsNullOrEmpty(Util.CurrentUserName))
            {
                btnPayment.Visible = false;
            }

            foreach (DataRow r in table.Rows)
            {
                Total += (Convert.ToDecimal(r["Price"]) * Convert.ToDecimal(r["Total"]));
            }
        }
        else
        {
            CartsSession.CreateInstant().DeleteCart(Page);
            Response.Redirect(UrlBuilder.RootUrl);
        }
    }

    protected void btnReCal_Click(object sender, EventArgs e)
    {
        if (repCart.Items != null && repCart.Items.Count > 0)
        {
            List<CartItem> carts = CartsSession.CreateInstant().GetCarts(Page);
            foreach (RepeaterItem item in repCart.Items)
            {
                TextBox txt = (TextBox)item.FindControl("txtQuantity");
                HiddenField hidId = (HiddenField)item.FindControl("hidId");

                if (txt != null && hidId != null)
                {
                    int quantity = FNumber.ConvertInt(txt.Text.Trim());
                    Guid ProductId = new Guid(hidId.Value);

                    for (int j = 0; j < carts.Count; j++)
                    {
                        if (carts[j].ProductId == ProductId)
                            carts[j].Total = quantity;
                    }
                }
            }

            CartsSession.CreateInstant().UpdateCart(Page, carts);
        }
        Response.Redirect(Request.RawUrl);
    }

    protected void btnPayment_Click(object sender, EventArgs e)
    {
        Response.Redirect(Library.Tools.UrlBuilder.RootUrl + "/modules/products/payment.aspx");
    }

    protected void btnContinue_Click(object sender, EventArgs e)
    {
        Response.Redirect("/");
    }

    protected void repCart_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        switch (e.CommandName)
        {
            case "del":
                //ProductsEntity product = ProductsManager.CreateInstant().SelectOne(new Guid(e.CommandArgument.ToString()));
                //if (product != null)
                //{
                CartsSession.CreateInstant().DeleteItem(Page, new Guid(e.CommandArgument.ToString()));
                //}
                break;
        }
        Response.Redirect(Request.RawUrl);
    }

    protected void lkPayment_Click(object sender, EventArgs e)
    {
        Session["guest"] = true;
        Response.Redirect(Library.Tools.UrlBuilder.RootUrl + "/modules/products/payment.aspx");
    }
}
