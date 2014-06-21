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

public partial class Modules_Payment_Controls_SingleOrderDetail : System.Web.UI.UserControl
{
    public Guid OrderId;
    public decimal Total = 0;
    public bool IsFooterSms = true;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public string GetBody()
    {
        string html = "";

        LoadData();
        
        LoadFooterSms();

        html = Util.RenderControl((Control)divContent);

        return html;
    }

    void LoadData()
    {
        DataTable table = OrderItemsManager.CreateInstant().GetItemsDetailByOrderId(OrderId);
        repCart.DataSource = table;
        repCart.DataBind();

        if (table != null && table.Rows.Count > 0)
            Total = Convert.ToDecimal(table.Compute("Sum(Total)", ""));
    }

    void LoadFooterSms()
    {
        if (IsFooterSms)
        {
            EmailTemplatesEntity footersms = EmailTemplatesManager.CreateInstant().GetTemplateByTemplateCode("FooterOrderSMS");
            if (footersms != null)
            {
                lblFooterOrderSms.Text = footersms.Body;
            }
        }
    }
}
