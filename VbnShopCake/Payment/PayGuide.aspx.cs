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

public partial class Payment_PayGuide : System.Web.UI.Page
{
    public string paycode
    {
        get { return Request["p"]; }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        PaymentMethodEntity pay = PaymentMethodManager.CreateInstant().SelectOne(paycode);
        if (pay != null)
        {
            lblPayName.Text = pay.PayName;
            //lblContent.Text = pay.PayGuide;
        }
    }
}
