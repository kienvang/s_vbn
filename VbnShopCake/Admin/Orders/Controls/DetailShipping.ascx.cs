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

public partial class Admin_Orders_Controls_DetailShipping : System.Web.UI.UserControl
{
    public double PriceSell = 0;
    public double TotalPriceSell = 0;
    public double TotalAmount = 0;

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
        DataTable table = ShippingManager.CreateInstant().GetShippingByOrderCode(OrderNumber);
        repShipping.DataSource = table;
        repShipping.DataBind();
    }

    public DataTable GetShippingItem(Guid ShippingId)
    {
        TotalPriceSell = 0;
        TotalAmount = 0;
        DataTable table = ShippingDetailManager.CreateInstant().GetShippingItem(ShippingId);

        if (table != null && table.Rows.Count > 0)
        {
            PriceSell = Convert.ToDouble(table.Compute("Sum(PriceAfterTax)", ""));
            TotalPriceSell = Convert.ToDouble(table.Compute("Sum(TotalPriceAfterTax)", ""));
            TotalAmount = Convert.ToInt32(table.Compute("Sum(Amount)", ""));
        }

        return table;
    }

    public int GetTotalShipping(Guid ShippingId)
    {
        return ShippingDetailManager.CreateInstant().GetTotalShipByShipId(ShippingId);
    }

    public string GetItemHtml(Guid ShippingId)
    {
        string html = "";
        ShippingEntity shipping = ShippingManager.CreateInstant().SelectOne(ShippingId);
        if (shipping != null)
        {
            int rowspan = ShippingDetailManager.CreateInstant().GetTotalShipByShipId(ShippingId);
            html += @"<td rowspan='" + rowspan.ToString() + "' valign='top'>";
            html += @"<b>Người nhận </b>: " + shipping.ReceiverName;
            html += @"<br/>Điện thoại :" + shipping.Phone1;
            html += @"<br/>Địa chỉ : " + shipping.Address;
            html += @"</td>";
        }
        return html;
    }
}
