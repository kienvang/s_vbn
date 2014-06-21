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

public partial class Modules_Products_QuickSearch : System.Web.UI.Page
{
    public int TotalSearch = 0;

    PagedDataSource pagedata = new PagedDataSource();
    private int pageNumber;
    private int pageSize;

    public string ProductName
    {
        get
        {
            return !string.IsNullOrEmpty(Request["ProductName"]) ? Request["ProductName"] : "";
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        LoadSearch();
    }

    void LoadSearch()
    {
        DataTable table = new DataTable();
        if (string.IsNullOrEmpty(ProductName))
            table = ProductsManager.CreateInstant().GetAll();
        else
            table = ProductsManager.CreateInstant().GetQuickSearch(ProductName);

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
        this.smartPager.UrlFormatString = Modules.Products.UrlBuilder.QuickSearchPaging(ProductName);

        dltProducts.DataSource = pagedata;
        dltProducts.DataBind();
    }
}
