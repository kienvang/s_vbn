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

public partial class Admin_EmailTemplates_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadCombo();
        }
    }

    void LoadCombo()
    {
        DataTable table = EmailTemplatesManager.CreateInstant().SelectAllRDT();
        ddlEmailTemplate.DataTextField = "TemplateName";
        ddlEmailTemplate.DataValueField = "Id";
        table.DefaultView.Sort = "TemplateName";
        ddlEmailTemplate.DataSource = table.DefaultView;
        ddlEmailTemplate.DataBind();
    }

    protected void ddlEmailTemplate_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlEmailTemplate.SelectedValue != "")
        {
            EmailTemplatesEntity template = EmailTemplatesManager.CreateInstant().SelectOne(new Guid(ddlEmailTemplate.SelectedValue));
            if (template != null)
            {
                lblSubject.Text = template.Subject;
                lblBody.Text = template.Body;
                lblUpdateBy.Text = template.UpdatedBy;
                lblTemplateCode.Text = template.TemplateCode;
            }
        }
        else
        {
            lblSubject.Text = "";
            lblBody.Text = "";
            lblUpdateBy.Text = "";
            lblTemplateCode.Text = "";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        if (ddlEmailTemplate.SelectedValue != "")
        {
            EmailTemplatesEntity template = EmailTemplatesManager.CreateInstant().SelectOne(new Guid(ddlEmailTemplate.SelectedValue));
            if (template != null)
            {
                Response.Redirect("/Admin/EmailTemplates/EditTemplate.aspx?id=" + template.Id.ToString());
            }
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Admin/EmailTemplates/AddTemplate.aspx");
    }
}
