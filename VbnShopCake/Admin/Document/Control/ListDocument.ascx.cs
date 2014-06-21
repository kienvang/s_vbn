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

public partial class Admin_Document_Control_ListDocument : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadData();
        }
    }
    
    public void LoadData()
    {
        DataTable dt = DocumentManager.CreateInstant().GetAll();
        PagedDataSource pagedata = Func.GetPaging(dt, Request["page"], 100);

        this.smartPager.RowCount = pagedata.DataSourceCount;
        this.smartPager.CurrentPage = pagedata.CurrentPageIndex + 1;
        this.smartPager.PageSize = pagedata.PageSize;
        this.smartPager.Visible = this.smartPager.RowCount > this.smartPager.PageSize;
        this.smartPager.UrlFormatString = "/Admin/Document/ListDocument.aspx?" + "page={0}";

        RepDocument.DataSource = pagedata;
        RepDocument.DataBind();
    }
    protected void RepDocument_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        Guid ID = new Guid(e.CommandArgument.ToString());
        switch (e.CommandName)
        {
            case "del":
                DocumentEntity obj = DocumentManager.CreateInstant().GetByID(ID);
                if (obj != null)
                {
                    obj.IsDeleted = true;
                    DocumentManager.CreateInstant().Update(obj);
                }
                break;
            case "isvisible":
                DocumentEntity obj1 = DocumentManager.CreateInstant().GetByID(ID);
                if (obj1 != null)
                {
                    obj1.IsVisible = !obj1.IsVisible;
                    DocumentManager.CreateInstant().Update(obj1);
                }
                break;
        }
        LoadData();
    }
}
