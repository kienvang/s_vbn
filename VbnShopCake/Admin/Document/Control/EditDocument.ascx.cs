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

public partial class Admin_Document_Control_EditDocument : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadData();
        }
    }
    public void LoadGroupDocument()
    {
        DataTable dtgroup = DocumentGroupManager.CreateInstant().SelectByIsDeletedRDT(false);
        ddlGroup.DataSource = dtgroup;
        ddlGroup.DataTextField = "GroupName";
        ddlGroup.DataValueField = "IntId";
        ddlGroup.DataBind();
    }
    public void LoadData()
    {
        LoadGroupDocument();
        if (ID != Guid.Empty)
        {
            DocumentEntity obj = DocumentManager.CreateInstant().GetByID(ID);
            if (obj != null)
            {
                txtName.Text = obj.DocumentName;
                txtDescription.Value = obj.Description;
                txtMark.Text = obj.Mark.ToString();
                ddlGroup.Text = obj.GroupId.ToString();
                if (!string.IsNullOrEmpty(obj.DisplayImage))
                {
                    DisplayImage.ImageUrl = obj.DisplayImage;
                    linkDelete.Visible = true;
                }
                else
                {
                    DisplayImage.AlternateText = "Chưa có hình đại diện";
                    linkDelete.Visible = false;
                }
                //txtGuide.Value = obj.Guide;
                
            }
        }
    }

    public Guid ID
    {
        get { return !string.IsNullOrEmpty(Request["id"]) ? Util.IsGuid(Request["id"]) ? new Guid(Request["id"]) : Guid.Empty : Guid.Empty; }
    }
    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {

    }
    protected void btEdit_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            DocumentEntity obj = DocumentManager.CreateInstant().GetByID(ID);
            if (obj != null)
            {
                obj.DocumentName = Filter.GetMaxString(txtName.Text.Trim(), DocumentFields.DocumentName.MaxLength);
                obj.TextId = DocumentManager.CreateInstant().GetUniqueTextIdFromUnicodeText(obj.DocumentName);
                obj.Description = Filter.GetMaxString(txtDescription.Value.Trim(), DocumentFields.Description.MaxLength);
                if (!string.IsNullOrEmpty(txtMark.Text))
                {
                    obj.Mark = int.Parse(txtMark.Text.Trim());
                }
                else
                    obj.Mark = 0;
                obj.GroupId = int.Parse(ddlGroup.SelectedValue);
                
                if(UpLoadImage.HasFile)
                    obj.DisplayImage = FileUploadControl.FullPath(UpLoadImage, EnumsFile.Images, obj.TextId, DocumentFields.DisplayImage.MaxLength);
                //obj.Guide = Filter.GetMaxString(txtGuide.Value.Trim(), DocumentFields.Guide.MaxLength);
                obj.UpdatedBy = Util.CurrentUserName;
                obj.UpdatedDate = DateTime.Now;

                DocumentManager.CreateInstant().Update(obj);
               
                CustomValidator1.ErrorMessage = "Cập nhật thành công";
                CustomValidator1.IsValid = false;

                LoadData();
            }
        }

    }
    protected void linkDelete_Click(object sender, EventArgs e)
    {
        DocumentEntity obj = DocumentManager.CreateInstant().GetByID(ID);
        if (obj != null)
        {
            obj.DisplayImage = "";
            obj.UpdatedDate = DateTime.Now;
            obj.UpdatedBy = Util.CurrentUserName;
            DocumentManager.CreateInstant().Update(obj);
            Response.Redirect(Request.RawUrl);
        }
    }
}
