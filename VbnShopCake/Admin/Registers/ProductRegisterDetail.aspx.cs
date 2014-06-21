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

public partial class Admin_Registers_ProductRegisterDetail : System.Web.UI.Page
{
    public Guid RegisterId
    {
        get
        {
            return !string.IsNullOrEmpty(Request["id"]) ? Util.IsGuid(Request["id"]) ? new Guid(Request["id"]) : Guid.Empty : Guid.Empty;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadData();
        }
    }

    void LoadData()
    {
        ProductRegisterEntity reg = ProductRegisterManager.CreateInstant().SelectOne(RegisterId);
        if (reg != null)
        {
            if (!reg.Approved)
            {
                btnSubmit.Visible = true;
                btnDelete.Visible = true;
            }

            this.Title = "Đăng ký bán sản phẩm - " + reg.ProductName;

            lblProductName.Text = reg.ProductName;
            
            lblCompanyName.Text = reg.CompanyName;
            lblCompanyPhone.Text = reg.CompanyPhone;
            lblCompanyNumberTax.Text = reg.CompanyNumberTax;
            lblCompanyEmail.Text = reg.CompanyEmail;
            lblCompanyAddress.Text = reg.CompanyAddress;
            lblNote.Text = reg.Note;

            if (string.IsNullOrEmpty(reg.Thumbnail))
                img.ImageUrl = "/images/no_img.gif";
            else
                img.ImageUrl = reg.Thumbnail + "?w=400&c=1";
            lblPriceBuy.Text = FNumber.FormatNumber(reg.PriceBuy);
            lblPriceSell.Text = FNumber.FormatNumber(reg.PriceSell);
            lblQuantity.Text = reg.Quantity.ToString();
            lblAbstract.Text = reg.Abstract;
            lblWarranty.Text = reg.Warranty;
            lblDetail.Text = reg.Detail;
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Admin/Products/AddEditProduct.aspx?id=" + RegisterId.ToString());
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        ProductRegisterEntity reg = ProductRegisterManager.CreateInstant().SelectOne(RegisterId);
        if (reg != null)
        {
            ProductRegisterManager.CreateInstant().Delete(reg.Id);
            Response.Redirect("/Admin/Registers/ProductsRegister.aspx");
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Admin/Registers/ProductsRegister.aspx");
    }
}
