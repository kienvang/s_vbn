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

public partial class Admin_EmailTemplates_AddTemplate : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            EmailTemplatesEntity template = new EmailTemplatesEntity();
            template.TemplateCode = txtTemplateCode.Text.Trim();
            template.TemplateName = txtTemplateName.Text.Trim();
            template.Subject = txtSubject.Text.Trim();
            template.Body = txtBody.Value;

            template.CreatedBy = Util.CurrentUserName;
            template.CreatedDate = DateTime.Now;
            template.UpdatedBy = Util.CurrentUserName;
            template.UpdatedDate = DateTime.Now;

            EmailTemplatesManager.CreateInstant().Insert(template);

            Response.Redirect("/Admin/EmailTemplates/");
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Admin/EmailTemplates/");
    }
}
