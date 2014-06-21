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

using Library.Tools;

public partial class Admin_Orders_Controls_OrderDetail : System.Web.UI.UserControl
{
    OrdersEntity order = null;
    public string TagId = "";

    public string OrderNumber
    {
        get
        {
            return Request["OrderNumber"];
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadData();
        }
    }

    void LoadData()
    {
        order = OrdersManager.CreateInstant().GetByOrderCode(OrderNumber);
        if (order != null)
        {
            //--- Title
            this.Page.Title = "Don Dat Hang - " + order.OrderCode;
            string paymethod = "CAH";
            if (!string.IsNullOrEmpty(order.PaymentMethod))
            {
                PaymentMethodEntity method = PaymentMethodManager.CreateInstant().SelectOne(order.PaymentMethod);
                if (method != null)
                {
                    lblPayment.Text = method.PayName;
                }
            }

            //---
            lblOrderDate.Text = FDateTime.FormatDateTime(order.CreatedDate);
            lblCustomer.Text = order.CustomerName;
            
            // Gia
            lblPriceSell.Text = FNumber.FormatNumber(order.TotalAmountAfterTax) + " VNĐ";
            lblPriceBuy.Text = FNumber.FormatNumber(order.TotalAllSupplier) + " VNĐ";
            lblCommission.Text = FNumber.FormatNumber(order.TotalAmountAfterTax - order.TotalAllSupplier) + " VNĐ";
            
            //---
            TagId = OrdersJoinTagsManager.CreateInstant().GetTag(order.Id);

            viewOrder.OrderId = order.Id;
            viewOrder.IsFooterSms = false;

            string detail = viewOrder.GetBody();

            EmailTemplatesEntity template = EmailTemplatesManager.CreateInstant().GetOrderCompletedPDF(order.Id, detail);
            if (template != null)
            {
                template = EmailTemplatesManager.CreateInstant().GetFormatEmailPDF(template);

                lblViewOrder.Text = template.Body;
            }
        }
    }

    public string GetStatusPaid()
    {
        string status = "";
        if (order != null)
        {
            if (order.PaidCompleted)
                status = "Thanh toán hoàn tất";
            else
                status = "Chờ thanh toán";
        }
        return status;
    }

    protected void lkPdf_Click(object sender, EventArgs e)
    {
        order = OrdersManager.CreateInstant().GetByOrderCode(OrderNumber);
        if (order != null)
        {
            SingleOrderDetail1.OrderId = order.Id;
            SingleOrderDetail1.IsFooterSms = false;

            string detail = SingleOrderDetail1.GetBody();

            EmailTemplatesEntity template = EmailTemplatesManager.CreateInstant().GetOrderCompletedPDF(order.Id, detail);
            if (template != null)
            {
                template = EmailTemplatesManager.CreateInstant().GetFormatEmailPDF(template);

                ExportPdf.CreateInstant().Export(order.OrderCode, template.Body);
            }
        }
    }
}
