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
using Modules;
using Library.Tools;
using Modules.Role;
public partial class Modules_Document_Control_DownLoadHistory : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(Util.CurrentUserName))
            Response.Redirect(EnumsUrlDirect.LoginUrlTest);
        if (!IsPostBack)
            LoadData();
    }
    public void LoadData()
    {
        DataTable dt = DownLoadHistoryManager.CreateInstant().GetDownLoadHistory(Util.CurrentUserName);
        PagedDataSource pagedata = Func.GetPaging(dt, Request["page"], 100);

        this.smartPager.RowCount = pagedata.DataSourceCount;
        this.smartPager.CurrentPage = pagedata.CurrentPageIndex + 1;
        this.smartPager.PageSize = pagedata.PageSize;
        this.smartPager.Visible = this.smartPager.RowCount > this.smartPager.PageSize;
        this.smartPager.UrlFormatString = "/Admin/Document/ListGroup.aspx?" + "page={0}";

        RepHistory.DataSource = pagedata;
        RepHistory.DataBind();
    }

}
