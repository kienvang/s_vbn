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
public partial class Admin_Payment_Control_EditPayment : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            loadData();
        }
    }

    void loadData()
    {
        PaymentMethodEntity pay = PaymentMethodManager.CreateInstant().SelectOne(Request["id"]);
        if (pay != null)
        {
            lblPayName.Text = pay.PayName;
        }
        else
            this.Visible = false;
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        PaymentMethodEntity pay = PaymentMethodManager.CreateInstant().SelectOne(Request["id"]);
        if (pay != null)
        {
            
            PaymentMethodManager.CreateInstant().Update(pay);

            Response.Redirect(Request.RawUrl);
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Admin/Payment/PaymentMethod.aspx");
    }
}
