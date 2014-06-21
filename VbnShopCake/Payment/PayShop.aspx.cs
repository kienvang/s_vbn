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

public partial class Payment_PayShop : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request["status"] == "1")
        {
            OrdersEntity od = OrdersManager.CreateInstant().GetByOrderCode(Request["ordercode"]);
            if (od != null)
            {
                Session["PAY"] = true;
                od.PaidCompleted = true;
                OrdersManager.CreateInstant().Update(od);
                Response.Redirect("/Payment/Thankyou.aspx?t=" + NganLuong.PayShop + "&id=" + od.Id.ToString());
            }
        }
        Response.Redirect("/");
    }
}
