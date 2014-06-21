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

public partial class Admin_EmailTemplates_EditTemplate : System.Web.UI.Page
{
    public Guid Id
    {
        get
        {
            return !string.IsNullOrEmpty(Request["Id"]) ? Util.IsGuid(Request["id"]) ? new Guid(Request["id"]) : Guid.Empty : Guid.Empty;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            EmailTemplatesEntity template = EmailTemplatesManager.CreateInstant().SelectOne(Id);
            if (template != null)
            {
                Title = "Edit Email Template - " + template.TemplateName;
                txtTemplateName.Text = template.TemplateName;
                txtSubject.Text = template.Subject;
                txtBody.Value = template.Body;
            }
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            EmailTemplatesEntity template = EmailTemplatesManager.CreateInstant().SelectOne(Id);
            if (template != null)
            {
                template.TemplateName = txtTemplateName.Text.Trim();
                template.Subject = txtSubject.Text.Trim();
                template.Body = txtBody.Value;

                template.UpdatedBy = Util.CurrentUserName;
                template.UpdatedDate = DateTime.Now;

                if (EmailTemplatesManager.CreateInstant().Update(template))
                {
                    lblStatus.Text = "Cập nhật thành công";
                }
                else
                {
                    lblStatus.Text = "Cập nhật không thành công";
                }
            }
            else
                lblStatus.Text = "Cập nhật không thành công";
        }
    }

    protected void btnDel_Click(object sender, EventArgs e)
    {
        EmailTemplatesEntity template = EmailTemplatesManager.CreateInstant().SelectOne(Id);
        if (template != null)
        {
            EmailTemplatesManager.CreateInstant().Delete(template.Id);
            Response.Redirect("/Admin/EmailTemplates/");
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Admin/EmailTemplates/");
    }
}
