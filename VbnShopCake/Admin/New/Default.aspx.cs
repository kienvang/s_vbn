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

public partial class Admin_New_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LoadData();
    }

    PagedDataSource pagedata = new PagedDataSource();
    private int pageNumber;
    private int pageSize;

    void LoadData()
    {
        DataTable table = NewsManager.CreateInstant().SelectAllRDT();
        pagedata = Func.GetPaging(table, Request["page"], 100);

        this.smartPager.RowCount = pagedata.DataSourceCount;
        this.smartPager.CurrentPage = pagedata.CurrentPageIndex + 1;
        this.smartPager.PageSize = pagedata.PageSize;
        this.smartPager.Visible = this.smartPager.RowCount > this.smartPager.PageSize;
        this.smartPager.UrlFormatString = "/Admin/New/?" + "page={0}";

        repNews.DataSource = pagedata;
        repNews.DataBind();
    }

    protected void repNews_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        Guid Id = new Guid(e.CommandArgument.ToString());
        switch (e.CommandName)
        {
            case "del":
                NewsManager.CreateInstant().Delete(Id);
                
                break;
            case "isvisible":
                NewsEntity news = NewsManager.CreateInstant().SelectOne(Id);
                if (news != null)
                {
                    news.IsVisible = !news.IsVisible;
                    NewsManager.CreateInstant().Update(news);
                }
                break;
        }
        Response.Redirect("/Admin/New");
    }
}
