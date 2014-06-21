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
using Modules;
public partial class Payment_Thankyou : System.Web.UI.Page
{
    public Guid OrderId
    {
        get
        {
            return !string.IsNullOrEmpty(Request["id"]) ? Util.IsGuid(Request["id"]) ? new Guid(Request["id"]) : Guid.Empty : Guid.Empty;
        }
    }

    public string PayType
    {
        get { return !string.IsNullOrEmpty(Request["t"]) ? Request["t"] : ""; }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        switch (PayType.ToLower())
        {
            case "shop":
                OrdersEntity order = OrdersManager.CreateInstant().SelectOne(OrderId);
                if (order != null)
                {
                    string html = "";
                    SingleOrderDetail1.OrderId = order.Id;
                    html = SingleOrderDetail1.GetBody();
                    EmailTemplatesEntity template = EmailTemplatesManager.CreateInstant().GetOrderPayCompleted(order.Id, html);
                    if (template != null)
                    {
                        this.Title = template.Subject;
                        lblMes.Text = template.Body;

                        if (Session["PAY"] != null)
                        {
                            if (Convert.ToBoolean(Session["PAY"]))
                            {
                                HistoryEmail.SendMailHistory(order.OrderCode, GetEmail.EmailFrom, order.CustomerEmail, "", GetEmail.EmailTo, template.Subject, template.Body, "");
                            }
                            Session["PAY"] = null;
                        }
                    }
                }
                break;
            case "doc":
                MarkTransferEntity mark = MarkTransferManager.CreateInstant().SelectOne(OrderId);
                if (mark != null)
                {
                    EmailTemplatesEntity template2 = EmailTemplatesManager.CreateInstant().GetTemplateByTemplateCode("PayDocSuc");
                    if (template2 != null)
                    {
                        this.Title = template2.Subject;
                        lblMes.Text = template2.Body;
                        Session["PAY"] = null;
                    }
                }
                break;
        }
    }
}
