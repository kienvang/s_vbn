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
public partial class Modules_Document_Control_ListAllDocument : Authentication
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadData();
        }
    }
    public Guid ID
    {
        get { return !string.IsNullOrEmpty(Request["id"]) ? Util.IsGuid(Request["id"]) ? new Guid(Request["id"]) : Guid.Empty : Guid.Empty; }
    }
    public int IntId
    {
        get { return !string.IsNullOrEmpty(Request["id"]) ? FString.IsInteger(Request["id"]) ? int.Parse(Request["id"]) : -1 : -1; }
    }
    public void LoadData()
    {
        DataTable dt = new DataTable();
        if (IntId==-1)
        {
            dt = DocumentManager.CreateInstant().SelectByIsDeletedRDT(false);
            lbTitle.Text = "Danh sách các tài liệu";
        }
        else
        {
            dt = DocumentManager.CreateInstant().GetByGroup(IntId);
            DocumentGroupEntity obj = DocumentGroupManager.CreateInstant().GetByIntID(IntId);
            lbTitle.Text = obj.GroupName;
        }

        PagedDataSource pagedata = Func.GetPaging(dt, Request["page"], 100);

        this.smartPager.RowCount = pagedata.DataSourceCount;
        this.smartPager.CurrentPage = pagedata.CurrentPageIndex + 1;
        this.smartPager.PageSize = pagedata.PageSize;
        this.smartPager.Visible = this.smartPager.RowCount > this.smartPager.PageSize;
        this.smartPager.UrlFormatString = "/Modules/Document/ListAllDocument.aspx?" + "page={0}";

        listAll.DataSource = pagedata;
        listAll.DataBind();
    }
    public string SplitString(string str)
    {
        string result = "";
        string[] temp = str.Split(' ');
        if (temp.Length >= 10)
        {
            for (int i = 0; i < 10; i++)
                result += temp[i] + " ";
            return result + "...";
        }
        return str;
    }

    
}
