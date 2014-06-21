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

public partial class Admin_Orders_Controls_DetailCarts : System.Web.UI.UserControl
{
    public double TotalPriceAfterTax = 0;
    public double TotalPoPrice = 0;
    public double TotalAmount = 0;
    public double PriceAfterTax = 0;
    public double PoPrice = 0;

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
            LoadItems();
        }
    }

    void LoadItems()
    {
        DataTable table = OrderItemsManager.CreateInstant().GetItemsByOrderCode(OrderNumber);
        repItems.DataSource = table;
        repItems.DataBind();
    }

    public DataTable GetItemsDetail(Guid OrderItemId)
    {
        DataTable table = OrderDetailManager.CreateInstant().GetlByOrderItemId(OrderItemId);

        TotalPriceAfterTax = 0;
        TotalPoPrice = 0;
        TotalAmount = 0;

        if (table != null && table.Rows.Count > 0)
        {
            PriceAfterTax = Convert.ToDouble(table.Compute("Sum(PriceAfterTax)", ""));
            TotalPriceAfterTax = Convert.ToDouble(table.Compute("Sum(TotalPriceAfterTax)", ""));

            PoPrice = Convert.ToDouble(table.Compute("Sum(PoPrice)", ""));
            TotalPoPrice = Convert.ToDouble(table.Compute("Sum(TotalPoPrice)", ""));

            TotalAmount = Convert.ToInt32(table.Compute("Sum(Amount)", ""));
        }

        return table;
    }
}
