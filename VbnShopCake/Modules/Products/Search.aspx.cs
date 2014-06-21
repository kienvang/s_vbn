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
using Modules;
using Library.Tools;

public partial class Modules_Products_Search : System.Web.UI.Page
{
    public int TotalSearch = 0;

    PagedDataSource pagedata = new PagedDataSource();
    private int pageNumber;
    private int pageSize;

    public int last = -1;

    public string ProductName
    {
        get
        {
            return !string.IsNullOrEmpty(Request["p"]) ? Request["p"] : "";
        }
    }

    public string Price
    {
        get
        {
            return !string.IsNullOrEmpty(Request["pr"]) ? Request["pr"] : "";
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        LoadSearch();
    }

    void LoadSearch()
    {
        DataTable table = new DataTable();

        table = ProductsManager.CreateInstant().Search(ProductName, Price, Request["c"]);

        //smartPager.Visible = true;
        if ((table == null && table.Rows.Count == 0) || (table != null && table.Rows.Count == 0))
        {
            smartPager.Visible = false;
            return;
        }

        TotalSearch = table.Rows.Count;
        pagedata = Func.GetPaging(table, Request["page"], Config.GetPagging());

        this.smartPager.RowCount = pagedata.DataSourceCount;
        this.smartPager.CurrentPage = pagedata.CurrentPageIndex + 1;
        this.smartPager.PageSize = pagedata.PageSize;
        this.smartPager.Visible = this.smartPager.RowCount > this.smartPager.PageSize;
        this.smartPager.UrlFormatString = Modules.Products.UrlBuilder.SearchPaging(ProductName, Price, Request["c"]);

        if (pagedata.DataSourceCount > 0)
            last = pagedata.DataSourceCount - 1;

        dltProducts.DataSource = pagedata;
        dltProducts.DataBind();
    }
}
