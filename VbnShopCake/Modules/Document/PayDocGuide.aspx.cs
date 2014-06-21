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
public partial class Modules_Document_PayDocGuide : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        EmailTemplatesEntity temp = EmailTemplatesManager.CreateInstant().GetTemplateByTemplateCode("PayDoc");
        if (temp != null)
        {
            lblTempName.Text = temp.TemplateName;
            lblContent.Text = temp.Body;
        }
    }
}
