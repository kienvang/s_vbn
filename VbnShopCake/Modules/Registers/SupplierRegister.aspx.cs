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
using Modules.Resource;
using Modules.Role;

public partial class Modules_Registers_SupplierRegister : System.Web.UI.Page
{
    public string url = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        url = Library.Tools.UrlBuilder.RootUrl;
        SetTitle();
        if (!IsPostBack)
        {
            LoadCombo();
            if (!CheckRoles.CreateInstant().IsRoles(EnumsRoles.UserMember))
            {
                Response.Redirect(CheckRoles.CreateInstant().GetUrlDirect(Request.RawUrl));
            }
        }
    }

    void SetTitle()
    {
        string title = GetGlobalResourceObject(EnumsResourcesName.HeaderTags, "RegisterSupplier" + ResourcesEntity.STitle).ToString();
        string description = GetGlobalResourceObject(EnumsResourcesName.HeaderTags, "RegisterSupplier" + ResourcesEntity.SDescription).ToString();
        string keywords = GetGlobalResourceObject(EnumsResourcesName.HeaderTags, "RegisterSupplier" + ResourcesEntity.SKeyWords).ToString();

        ResourcesEntity.CreateInstant().SetPage(Page, title, description, keywords);
    }

    void LoadCombo()
    {
        DataTable table = SupplierTypeManager.CreateInstant().GetSupplierTypeNotMain();
        ddlSupplierType.DataTextField = "TypeName";
        ddlSupplierType.DataValueField = "Id";
        ddlSupplierType.DataSource = table;
        ddlSupplierType.DataBind();
    }

    SupplierRegisterEntity getRegister()
    {
        SupplierRegisterEntity register = new SupplierRegisterEntity();

        register.Id = Guid.NewGuid();
        register.UserName = Util.CurrentUserName;
        register.SupplierName = Filter.GetStringNoHtml(txtSupplierName.Text.Trim(), SupplierRegisterFields.SupplierName.MaxLength);
        register.Email = Filter.GetMaxString(txtEmail.Text.Trim(), SupplierRegisterFields.Email.MaxLength);
        register.Phone = Filter.GetStringNoHtml(txtPhone.Text.Trim(), SupplierRegisterFields.Phone.MaxLength);
        register.SupplierTypeId = ddlSupplierType.SelectedValue;
        register.Address = Filter.GetStringNoHtml(txtPhone.Text.Trim(), SupplierRegisterFields.Address.MaxLength);
        register.AboutContents = Filter.GetMaxStringFilter(txtAboutContent.Value.Trim());

        return register;
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            SupplierRegisterEntity register = getRegister();
            SupplierRegisterManager.CreateInstant().Insert(register);

            EventsManager.CreateInstant().AddEvent(register.SupplierName, Modules.Events.EnumsEvents.RegisterSupplier, register.Id.ToString());

            Response.Redirect(Modules.UrlBuilder.SupplierRegisterComplete());
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("/");
    }

    protected void valRegister_ServerValidate(object source, ServerValidateEventArgs args)
    {
        args.IsValid = true;
        Captcha1.ValidateCaptcha(txtCaptcha.Text.Trim());
        if (!Captcha1.UserValidated || string.IsNullOrEmpty(txtCaptcha.Text.Trim()))
        {
            args.IsValid = false;
            valRegister.ErrorMessage = "Mã xác nhận chưa chính xác";
            return;
        }
    }
}
