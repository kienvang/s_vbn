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

public partial class Admin_Products_Controls_DetailStore : System.Web.UI.UserControl
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
            LoadStore();
        }
    }

    void LoadStore()
    {
        DataTable table = StorageManager.CreateInstant().SelectByProductIdRDT(ProductId);
        table.DefaultView.Sort = "CreatedDate desc";
        repStore.DataSource = table.DefaultView;
        repStore.DataBind();
    }

    protected void rdoCapNhat_CheckedChanged(object sender, EventArgs e)
    {
        reqAmount.Enabled = reqPrice.Enabled = reqPricePo.Enabled = true;
        regAmount.Enabled = regPrice.Enabled = regPricePo.Enabled = true;
        txtAmount.Enabled = txtPoPrice.Enabled = txtPrice.Enabled = true;
        btnAdd.Text = "Thêm";
    }

    protected void rdoNoPrice_CheckedChanged(object sender, EventArgs e)
    {
        reqAmount.Enabled = true;
        regAmount.Enabled = true;
        txtAmount.Enabled = true;
        reqPrice.Enabled = reqPricePo.Enabled = false;
        regPrice.Enabled = regPricePo.Enabled = false;
        txtPoPrice.Enabled = txtPrice.Enabled = false;
        btnAdd.Text = "Thêm";
    }

    protected void rdoNoAmount_CheckedChanged(object sender, EventArgs e)
    {
        reqAmount.Enabled = reqPrice.Enabled = reqPricePo.Enabled = false;
        regAmount.Enabled = regPrice.Enabled = regPricePo.Enabled = false;
        txtAmount.Enabled = txtPoPrice.Enabled = txtPrice.Enabled = false;
        btnAdd.Text = "Cập nhật";
    }

    void Refresh()
    {
        Response.Redirect(WebUtility.AddQueryString(Request.Path, "id=" + Request["id"], "tabs=" + Request["tabs"]));
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            ProductInfoEntity info = ProductInfoManager.CreateInstant().SelectOne(ProductId);
            ProductsEntity product = ProductsManager.CreateInstant().SelectOne(ProductId);
            if (info != null && product != null)
            {
                StorageEntity store = new StorageEntity();
                store.Id = Guid.NewGuid();
                store.ProductId = ProductId;
                store.CreatedBy = Util.CurrentUserName;

                string action = "";

                if (rdoCapNhat.Checked)
                {
                    store.Price = FNumber.ConvertDecimal(txtPrice.Text.Trim());
                    store.PoPrice = FNumber.ConvertDecimal(txtPoPrice.Text.Trim());
                    store.Import = FNumber.ConvertInt(txtAmount.Text.Trim());
                    store.Export = 0;

                    action = EnumsAction.UpdatePrice.Replace("[priceold/]", FNumber.FormatNumber(info.PriceSell)).Replace("[pricenew/]", FNumber.FormatNumber(store.Price)) + "<br/>";
                    action += EnumsAction.UpdatePricePo.Replace("[priceold/]", FNumber.FormatNumber(info.PriceBuy)).Replace("[pricenew/]", FNumber.FormatNumber(store.PoPrice)) + "<br/>";
                    action += EnumsAction.UpdateStore.Replace("[amountold/]", product.Amount.ToString()).Replace("[amountnew/]", store.Import.ToString());

                    info.PriceSell = store.Price;
                    info.PriceBuy = store.PoPrice;

                    if (product.Amount != -1)
                        product.Amount += store.Import;
                    else
                        product.Amount = store.Import;

                    product.Price = store.Price;
                    product.UpdatedBy = Util.CurrentUserName;
                    product.UpdatedDate = DateTime.Now;

                    DealsEntity deal = new DealsEntity();
                    deal.Price = store.Price;
                    deal.PoPrice = store.PoPrice;
                    deal.ProductId = product.Id;
                    deal.Currency = info.Currency;
                    deal.CreatedBy = Util.CurrentUserName;

                    StorageManager.CreateInstant().Insert(store);
                    DealsManager.CreateInstant().Insert(deal);

                }
                else if (rdoNoPrice.Checked)
                {
                    store.Price = info.PriceSell;
                    store.PoPrice = info.PriceBuy;
                    store.Import = FNumber.ConvertInt(txtAmount.Text.Trim());
                    store.Export = 0;

                    action += EnumsAction.UpdateStore.Replace("[amountold/]", product.Amount.ToString()).Replace("[amountnew/]", store.Import.ToString());

                    if (product.Amount != -1)
                        product.Amount += store.Import;
                    else
                        product.Amount = store.Import;

                    StorageManager.CreateInstant().Insert(store);
                }
                else if (rdoNoAmount.Checked)
                {


                    action += EnumsAction.UpdateStore.Replace("[amountold/]", product.Amount.ToString()).Replace("[amountnew/]", "-1");

                    product.Amount = -1;
                }

                ProductInfoManager.CreateInstant().Update(info);
                ProductsManager.CreateInstant().Update(product);

                HistoryProductManager.CreateInstant().AddHistory(action, product.Id);

                Refresh();
            }
        }
    }
}
