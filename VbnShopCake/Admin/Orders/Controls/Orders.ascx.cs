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
using Library.Tools;

public partial class Admin_Orders_Controls_Orders : System.Web.UI.UserControl
{
    public string OrderCode
    {
        get { return Request["orderid"]; }
    }

    public string CustomerName
    {
        get { return Request["customer"]; }
    }

    public string OrderDate
    {
        get { return Request["date"]; }
    }

    public string PaidComplete
    {
        get { return Request["paid"]; }
    }

    PagedDataSource pagedata = new PagedDataSource();
    private int pageNumber;
    private int pageSize;

    protected void Page_Load(object sender, EventArgs e)
    {
        LoadData();
    }

    void LoadData()
    {
        int top = 0;
        if (Request.QueryString.Count == 0)
            top = 50;

        DataTable table = new DataTable();
        table = OrdersManager.CreateInstant().Search(OrderCode, CustomerName, OrderDate, PaidComplete, top);
        smartPager.Visible = true;
        if (table == null && table.Rows.Count == 0)
        {
            smartPager.Visible = false;
            return;
        }

        string paramUrl = "orderid={0}&customer={1}&date={2}&paid={3}";
        paramUrl = string.Format(paramUrl, OrderCode, CustomerName, OrderDate, PaidComplete);

        pagedata = Func.GetPaging(table, Request["page"], 50);

        this.smartPager.RowCount = pagedata.DataSourceCount;
        this.smartPager.CurrentPage = pagedata.CurrentPageIndex + 1;
        this.smartPager.PageSize = pagedata.PageSize;
        this.smartPager.Visible = this.smartPager.RowCount > this.smartPager.PageSize;
        this.smartPager.UrlFormatString = "/Admin/Orders/?" + paramUrl + "&page={0}";

        repOrders.DataSource = pagedata;
        repOrders.DataBind();
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        string url = "/Admin/Orders/?";
        string paramUrl = "orderid={0}&customer={1}&date={2}&paid={3}&page=1";

        paramUrl = string.Format(paramUrl, txtOrderCode.Text.Trim(), txtCustomer.Text.Trim(), txtCreatedDate.Text.Trim(), ddlStatusPay.SelectedValue);
        Response.Redirect(url + paramUrl);
    }

    public string GetPayment(bool PaidComplete)
    {
        string img = "";

        if (PaidComplete)
            img = "<img src='/img/button/checked.png' alt='Đã thanh toán' title='Đã thanh toán'/>";
        else
            img = "<img src='/img/button/unchecked.gif' alt='Chưa thanh toán' title='Chưa thanh toán'/>";

        return img;
    }
}