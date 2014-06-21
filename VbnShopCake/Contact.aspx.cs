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
using System.Collections.Generic;

using LayerHelper.ShopCake.BLL;
using LayerHelper.ShopCake.DAL.EntityClasses;

public partial class Contact : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LoadData();

        Maps21.LatLong = new List<string>();
        Maps21.LatLong.Add("10.754316065638186:106.68338298797607:18");
    }

    void LoadData()
    {
        EmailTemplatesEntity template = EmailTemplatesManager.CreateInstant().GetTemplateByTemplateCode("Contact");
        if (template != null)
        {
            lblTemplate.Text = template.Body;
        }
    }
}
