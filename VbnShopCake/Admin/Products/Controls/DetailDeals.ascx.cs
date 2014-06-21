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
using Modules.Products;

using System.Globalization;

public partial class Admin_Products_Controls_DetailDeals : System.Web.UI.UserControl
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
            LoadDeals();
        }
    }

    void LoadDeals()
    {
        DataTable table = DealsManager.CreateInstant().SelectByProductIdRDT(ProductId);
        table.DefaultView.Sort = "CreatedDate desc";
        repDeals.DataSource = table.DefaultView;
        repDeals.DataBind();
    }

    DealsEntity getDeal()
    {
        DealsEntity deal = new DealsEntity();

        deal.Id = Guid.NewGuid();
        deal.Price = FNumber.ConvertDecimal(txtPrice.Text.Trim());
        deal.PoPrice = FNumber.ConvertDecimal(txtPoPrice.Text.Trim());
        deal.CreatedBy = Util.CurrentUserName;
        deal.ProductId = ProductId;

        return deal;
    }

    void Refresh()
    {
        Response.Redirect(WebUtility.AddQueryString(Request.Path, "id=" + Request["id"], "tabs=" + Request["tabs"]));
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            DealsEntity deal = getDeal();
            DealsManager.CreateInstant().Insert(deal);

            string action = "";

            ProductsEntity product = ProductsManager.CreateInstant().SelectOne(ProductId);
            if (product != null)
            {
                product.Price = deal.Price;
                ProductsManager.CreateInstant().Update(product);
            }

            ProductInfoEntity info = ProductInfoManager.CreateInstant().SelectOne(ProductId);
            if (info != null)
            {
                action = EnumsAction.UpdatePrice.Replace("[priceold/]", FNumber.FormatNumber(info.PriceSell)).Replace("[pricenew/]", FNumber.FormatNumber(deal.Price)) + "<br/>";
                action += EnumsAction.UpdatePricePo.Replace("[priceold/]", FNumber.FormatNumber(info.PriceBuy)).Replace("[pricenew/]", FNumber.FormatNumber(deal.PoPrice));

                info.PriceBuy = deal.PoPrice;
                info.PriceSell = deal.Price;
                info.Currency = deal.Currency;

                ProductInfoManager.CreateInstant().Update(info);
            }

            HistoryProductManager.CreateInstant().AddHistory(action, ProductId);

            Refresh();
        }
    }
}
