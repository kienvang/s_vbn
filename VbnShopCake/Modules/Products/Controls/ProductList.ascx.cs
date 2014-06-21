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

public partial class Modules_Products_Controls_ProductList : System.Web.UI.UserControl
{
    PagedDataSource pagedata = new PagedDataSource();
    private int pageNumber;
    private int pageSize;

    public string CatalogName = "";
    public int CatId
    {
        get
        {
            return !string.IsNullOrEmpty(Request["catId"]) ? FNumber.ConvertInt(Request["catId"]) : 0;
        }
    }

    public string TextId
    {
        get
        {
            return !string.IsNullOrEmpty(Request["TextId"]) ? Request["TextId"] : "";
        }
    }

    public int last = -1;

    protected void Page_Load(object sender, EventArgs e)
    {
        CatalogsEntity cat = CatalogsManager.CreateInstant().SelectOne(CatId);
        if (cat != null)
        {
            CatalogName = cat.CatalogName;
            LoadData();
        }
    }

    void LoadData()
    {
        DataTable table = ProductsManager.CreateInstant().GetProductInCatalog(CatId, 0);

        //smartPager.Visible = true;
        if ((table == null && table.Rows.Count == 0) || (table != null && table.Rows.Count == 0) || CatId <= 0 || string.IsNullOrEmpty(TextId))
        {
            smartPager.Visible = false;
            this.Visible = false;
            return;
        }

        pagedata = Func.GetPaging(table, Request["page"], Config.GetPagging());

        this.smartPager.RowCount = pagedata.DataSourceCount;
        this.smartPager.CurrentPage = pagedata.CurrentPageIndex + 1;
        this.smartPager.PageSize = pagedata.PageSize;
        this.smartPager.Visible = this.smartPager.RowCount > this.smartPager.PageSize;
        this.smartPager.UrlFormatString = Modules.Catalogs.UrlBuilder.GetCatsByIdTextIdPagging(CatId, TextId);

        if (pagedata.DataSourceCount > 0)
            last = pagedata.DataSourceCount - 1;

        dltProducts.DataSource = pagedata;
        dltProducts.DataBind();
    }
}
