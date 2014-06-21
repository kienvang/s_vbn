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
public partial class Admin_Payment_Control_Payment : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            rep.DataSource = PaymentMethodManager.CreateInstant().SelectAllLST();
            rep.DataBind();
        }
    }

    protected void btnCapNhat_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < rep.Items.Count; i++)
        {
            HiddenField hid = (HiddenField)rep.Items[i].FindControl("hidId");
            TextBox txt = (TextBox)rep.Items[i].FindControl("txtLink");

            PaymentMethodEntity pay = PaymentMethodManager.CreateInstant().SelectOne(hid.Value);
            if (pay != null)
            {
                pay.Link = txt.Text.Trim();
                PaymentMethodManager.CreateInstant().Update(pay);
            }
        }
        Response.Redirect(Request.RawUrl);
    }
}
