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

public partial class Modules_Products_OrderComplete : System.Web.UI.Page
{
    public Guid OrderId
    {
        get
        {
            return !string.IsNullOrEmpty(Request["id"]) ? Util.IsGuid(Request["id"]) ? new Guid(Request["id"]) : Guid.Empty : Guid.Empty;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        OrdersEntity order = OrdersManager.CreateInstant().SelectOne(OrderId);
        if (order != null)
        {
            string html = "";
            SingleOrderDetail1.OrderId = order.Id;
            html = SingleOrderDetail1.GetBody();
            EmailTemplatesEntity template = EmailTemplatesManager.CreateInstant().GetOrderCompleted(order.Id, html);
            if (template != null)
            {
                this.Title = template.Subject;
                lblMes.Text = template.Body;
            }
        }
    }
}
