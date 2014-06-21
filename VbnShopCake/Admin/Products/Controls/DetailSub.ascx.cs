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

public partial class Admin_Products_Controls_DetailSub : System.Web.UI.UserControl
{
    public Guid ProductId
    {
        get
        {
            return !string.IsNullOrEmpty(Request["id"]) ? Util.IsGuid(Request["id"]) ? new Guid(Request["Id"]) : Guid.Empty : Guid.Empty;
        }
    }

    ProductSubEntity getProductSub()
    {
        ProductSubEntity sub = new ProductSubEntity();

        sub.Id = Guid.NewGuid();
        sub.ProductId = ProductId;
        sub.ProductName = Filter.GetMaxString(txtProductName.Text.Trim(), ProductSubFields.ProductName.MaxLength);
        sub.Price = FNumber.ConvertDecimal(txtPriceSub.Text.Trim());
        sub.Description = Filter.GetMaxString(txtDescription.Text.Trim(), ProductSubFields.Description.MaxLength);
        sub.CreatedBy = Util.CurrentUserName;

        return sub;
    }

    void LoadData()
    {
        DataTable table = ProductSubManager.CreateInstant().SelectByProductIdRDT(ProductId);
        table.DefaultView.Sort = "ProductName";
        repSub.DataSource = table.DefaultView;
        repSub.DataBind();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadData();
        }
    }

    void Refresh()
    {
        Response.Redirect(WebUtility.AddQueryString(Request.Path, "id=" + Request["id"], "tabs=" + Request["tabs"]));
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            ProductSubEntity sub = getProductSub();
            ProductSubManager.CreateInstant().Insert(sub);

            Refresh();
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            ProductSubEntity sub = getProductSub();
            ProductSubEntity tmp = ProductSubManager.CreateInstant().SelectOne(new Guid(hidId.Value));
            if (tmp != null)
            {
                sub.Id = tmp.Id;
                ProductSubManager.CreateInstant().Update(sub);

                Refresh();
            }
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        ProductSubEntity sub = ProductSubManager.CreateInstant().SelectOne(new Guid(hidId.Value));
        if (sub != null)
        {
            ProductSubManager.CreateInstant().Delete(sub.Id);

            Refresh();
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Refresh();
    }

    protected void repSub_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        ProductSubEntity sub = ProductSubManager.CreateInstant().SelectOne(new Guid(e.CommandArgument.ToString()));
        if (sub != null)
        {
            switch (e.CommandName)
            {
                case "edit":
                    txtProductName.Text = sub.ProductName;
                    txtPriceSub.Text = FNumber.FormatNumber(sub.Price).Replace(",", "");
                    txtDescription.Text = sub.Description;
                    hidId.Value = sub.Id.ToString();

                    btnAdd.Visible = false;
                    btnEdit.Visible = btnDelete.Visible = btnCancel.Visible = true;
                    break;
                case "del":
                    ProductSubManager.CreateInstant().Delete(sub.Id);
                    Refresh();
                    break;
            }
        }
    }
}
