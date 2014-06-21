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

public partial class Admin_Document_Control_ListGroup : System.Web.UI.UserControl
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
    private void LoadData()
    {
        if (ID != Guid.Empty)
        {
            DocumentGroupEntity obj = DocumentGroupManager.CreateInstant().GetByID(ID);
            txtGroupName.Text = obj.GroupName;
        }
        DataTable dt = DocumentGroupManager.CreateInstant().SelectByIsDeletedRDT(false);
        PagedDataSource pagedata = Func.GetPaging(dt, Request["page"], 100);

        this.smartPager.RowCount = pagedata.DataSourceCount;
        this.smartPager.CurrentPage = pagedata.CurrentPageIndex + 1;
        this.smartPager.PageSize = pagedata.PageSize;
        this.smartPager.Visible = this.smartPager.RowCount > this.smartPager.PageSize;
        this.smartPager.UrlFormatString = "/Admin/Document/ListGroup.aspx?" + "page={0}";

        RepGroup.DataSource = pagedata;
        RepGroup.DataBind();
    }
    protected void RepGroup_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        Guid ID = new Guid(e.CommandArgument.ToString());
        switch (e.CommandName)
        {
            case "del":
                DocumentGroupEntity obj = DocumentGroupManager.CreateInstant().GetByID(ID);
                if (obj != null)
                {
                    obj.IsDeleted = true;
                    DocumentGroupManager.CreateInstant().Update(obj);
                }
                break;
        }
        LoadData();
    }
    protected void btAdd_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            DocumentGroupEntity obj = new DocumentGroupEntity();
            obj.GroupName = Filter.GetMaxString(txtGroupName.Text.Trim(), DocumentGroupFields.GroupName.MaxLength);
            obj.TextId = DocumentGroupManager.CreateInstant().GetUniqueTextIdFromUnicodeText(obj.GroupName);
            obj.CreatedBy = Util.CurrentUserName;
            obj.CreatedDate = DateTime.Now;
            obj.IsDeleted = false;

            if (DocumentGroupManager.CreateInstant().GetByGroupName(obj.GroupName) == null)
                DocumentGroupManager.CreateInstant().Insert(obj);
            else
            {
                CustomValidator1.ErrorMessage = "Tên nhóm đã tồn tại, vui lòng chọn tên khác";
                CustomValidator1.IsValid = false;
            }
            CustomValidator1.ErrorMessage = "Thêm thành công";
            CustomValidator1.IsValid = false;

            LoadData();
        }
    }
    protected void btEdit_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            if (ID != Guid.Empty)
            {
                DocumentGroupEntity obj = DocumentGroupManager.CreateInstant().GetByID(ID);
                obj.GroupName = Filter.GetMaxString(txtGroupName.Text.Trim(), DocumentGroupFields.GroupName.MaxLength);
                obj.TextId = DocumentGroupManager.CreateInstant().GetUniqueTextIdFromUnicodeText(obj.GroupName);
                obj.UpdatedBy = Util.CurrentUserName;
                obj.UpdatedDate = DateTime.Now;

                DocumentGroupManager.CreateInstant().Update(obj);

                CustomValidator1.ErrorMessage = "Sửa thành công";
                CustomValidator1.IsValid = false;

                LoadData();
            }
        }
    }
}
