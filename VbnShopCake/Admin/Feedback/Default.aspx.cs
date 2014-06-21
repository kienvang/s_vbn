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

public partial class Admin_Feedback_Default : System.Web.UI.Page
{
    PagedDataSource pagedata = new PagedDataSource();

    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable table = FeedBackManager.CreateInstant().SelectAllRDT();
        table.DefaultView.Sort = "SendDate desc";

        smartPager.Visible = true;
        if (table == null && table.Rows.Count == 0)
        {
            smartPager.Visible = false;
            return;
        }

        string paramUrl = "";
        //paramUrl = string.Format(paramUrl, OrderCode, CustomerName, OrderDate, PaidComplete);

        pagedata = Func.GetPaging(table.DefaultView, Request["page"], 100);

        this.smartPager.RowCount = pagedata.DataSourceCount;
        this.smartPager.CurrentPage = pagedata.CurrentPageIndex + 1;
        this.smartPager.PageSize = pagedata.PageSize;
        this.smartPager.Visible = this.smartPager.RowCount > this.smartPager.PageSize;
        this.smartPager.UrlFormatString = "/Admin/Orders/?" + paramUrl + "&page={0}";

        repFeedBack.DataSource = pagedata;
        repFeedBack.DataBind();
    }

    protected void repFeedBack_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        FeedBackEntity feedback = FeedBackManager.CreateInstant().SelectOne(new Guid(e.CommandArgument.ToString()));
        switch (e.CommandName)
        {
            case "approve":
                if (feedback != null)
                {
                    feedback.Approved = !feedback.Approved;
                    FeedBackManager.CreateInstant().Update(feedback);

                    Response.Redirect(Request.RawUrl);
                }
                break;
        }
    }
}
