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
using Modules;
using Modules.Resource;
using Modules.Role;

public partial class Modules_Registers_ProductRegister : System.Web.UI.Page
{
    public string url = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        url = Library.Tools.UrlBuilder.RootUrl;
        SetTitle();
        if (!IsPostBack)
        {
            if (!CheckRoles.CreateInstant().IsRoles(EnumsRoles.UserMember))
            {
                Response.Redirect(CheckRoles.CreateInstant().GetUrlDirect(Request.RawUrl));
            }
        }
    }

    void SetTitle()
    {
        string title = GetGlobalResourceObject(EnumsResourcesName.HeaderTags, "RegisterProduct" + ResourcesEntity.STitle).ToString();
        string description = GetGlobalResourceObject(EnumsResourcesName.HeaderTags, "RegisterProduct" + ResourcesEntity.SDescription).ToString();
        string keywords = GetGlobalResourceObject(EnumsResourcesName.HeaderTags, "RegisterProduct" + ResourcesEntity.SKeyWords).ToString();

        ResourcesEntity.CreateInstant().SetPage(Page, title, description, keywords);
    }

    ProductRegisterEntity getRegister()
    {
        ProductRegisterEntity register = new ProductRegisterEntity();

        register.Id = Guid.NewGuid();
        register.UserName = Util.CurrentUserName;
        register.ProductName = Filter.GetStringNoHtml(txtProductName.Text.Trim(), ProductRegisterFields.ProductName.MaxLength);
        register.Abstract = Filter.GetStringNoHtml(txtAbstract.Text.Trim(), ProductRegisterFields.Abstract.MaxLength);
        register.Warranty = Filter.GetStringNoHtml(txtWarranty.Text.Trim(), ProductRegisterFields.Warranty.MaxLength);
        register.Detail = Filter.GetMaxStringFilter(txtDetail.Value.Trim());
        register.PriceBuy = FNumber.ConvertDecimal(txtPriceBuy.Text.Trim());
        register.PriceSell = FNumber.ConvertDecimal(txtPriceSell.Text.Trim());
        register.Quantity = FNumber.ConvertInt(txtQuantity.Text.Trim());

        register.CompanyName = Filter.GetStringNoHtml(txtCompanyName.Text.Trim(), ProductRegisterFields.CompanyName.MaxLength);
        register.CompanyPhone = Filter.GetStringNoHtml(txtCompanyPhone.Text.Trim(), ProductRegisterFields.CompanyPhone.MaxLength);
        register.CompanyEmail = Filter.GetMaxString(txtCompanyEmail.Text.Trim(), ProductRegisterFields.CompanyEmail.MaxLength);
        register.CompanyNumberTax = Filter.GetStringNoHtml(txtCompanyNumberTax.Text.Trim(), ProductRegisterFields.CompanyNumberTax.MaxLength);
        register.CompanyAddress = Filter.GetStringNoHtml(txtCompanyAddress.Text.Trim(), ProductRegisterFields.CompanyAddress.MaxLength);
        register.Note = Filter.GetStringNoHtml(txtNote.Text.Trim(), ProductRegisterFields.Note.MaxLength);

        register.Thumbnail = "";
        if (fileUpload.HasFile)
        {
            register.Thumbnail = FileUploadControl.FullPath(fileUpload, register.ProductName, ProductRegisterFields.Thumbnail.MaxLength, EnumsFile.Thumbnails);
        }

        return register;
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            ProductRegisterEntity register = getRegister();
            ProductRegisterManager.CreateInstant().Insert(register);

            EventsManager.CreateInstant().AddEvent(register.ProductName, Modules.Events.EnumsEvents.RegisterProduct, register.Id.ToString());

            Response.Redirect(Modules.UrlBuilder.ProductRegisterComplete());
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("/");
    }

    protected void valProduct_ServerValidate(object source, ServerValidateEventArgs args)
    {
        args.IsValid = true;
        if (fileUpload.HasFile)
        {
            if (!FileUploadControl.IsValidPhoto(fileUpload, Modules.EnumsCheckType.SizeAndExtendName))
            {
                valProduct.ErrorMessage = "Hình phải là *.bmp,*.gif,*.jpeg,*.jpg,*.png";
                args.IsValid = false;
                return;
            }
        }
        Captcha1.ValidateCaptcha(txtCaptcha.Text.Trim());
        if (!Captcha1.UserValidated)
        {
            args.IsValid = false;
            valProduct.ErrorMessage = "Mã xác nhận chưa chính xác";
            return;
        }
    }
}
