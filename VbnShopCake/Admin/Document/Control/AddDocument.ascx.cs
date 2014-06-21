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
using System.IO;
public partial class Admin_Document_Control_AddDocument : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadData();
        }
    }
    public Guid group
    {
        get { return !string.IsNullOrEmpty(Request["gr"]) ? Util.IsGuid(Request["id"]) ? new Guid(Request["id"]) : Guid.Empty : Guid.Empty; }
    }
    public void LoadData()
    {
        DataTable dtgroup = DocumentGroupManager.CreateInstant().SelectByIsDeletedRDT(false);
        ddlGroup.DataSource = dtgroup;
        ddlGroup.DataTextField = "GroupName";
        ddlGroup.DataValueField = "IntId";
        ddlGroup.DataBind();

        string[] files = Directory.GetFiles(Server.MapPath(Config.UploadDoc()));
        for (int i = 0; i < files.Length; i++)
            files[i] = files[i].Substring(files[i].LastIndexOf("\\") + 1);
        ddlSelectFile.DataSource = files;
        ddlSelectFile.DataBind();
    }
    public DocumentEntity GetDocument()
    {
        DocumentEntity obj = new DocumentEntity();
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
        if (rdoUpload.Checked)
        {
            if (UpLoadDocument.HasFile)
            {
                obj.PathName = FileUploadControl.FullPath(UpLoadDocument, EnumsFile.Document, obj.TextId, DocumentFields.PathName.MaxLength);
                obj.FileSize = Math.Round((double)UpLoadDocument.PostedFile.ContentLength / (1024 * 1024), 3);
            }
            else
            {
                //obj.PathName = "";
                CustomValidator1.ErrorMessage = "File rỗng, chọn file khác";
                CustomValidator1.IsValid = false;
                return null;
            }
        }
        else
        {
            if (!string.IsNullOrEmpty(ddlSelectFile.SelectedValue))
            {
                obj.PathName = Config.UploadDoc().TrimEnd('/') + "/" + ddlSelectFile.SelectedValue;
                FileInfo f = new FileInfo(Server.MapPath("~" + obj.PathName));
                obj.FileSize = Math.Round((double)f.Length / (1024 * 1024), 3);
            }
            else
            {
                CustomValidator1.ErrorMessage = "File rỗng, chọn file khác";
                CustomValidator1.IsValid = false;
                return null;
            }
        }

        obj.DisplayImage = FileUploadControl.FullPath(UpLoadImage, EnumsFile.Images, obj.TextId, DocumentFields.DisplayImage.MaxLength);

        obj.VideoTrailer = FileUploadControl.FullPath(UploadVideo, EnumsFile.Videos, obj.TextId, DocumentFields.VideoTrailer.MaxLength);
        obj.ShowVideo = check.Checked;
        //obj.Description = Filter.GetMaxString(txtGuide.Value.Trim(), DocumentFields.Guide.MaxLength);
        obj.CountDown = 0;
        obj.CreatedBy = Util.CurrentUserName;
        obj.CreatedDate = DateTime.Now;
        obj.IsVisible = true;
        obj.IsDeleted = false;
        return obj;
    }
    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {
        args.IsValid = true;
        string FileName = UpLoadDocument.FileName;
        string ExtensionFileName = System.IO.Path.GetExtension(FileName).Trim('.');
        ExtensionFileName = ExtensionFileName.ToLower();
        DataTable dt = DocumentTypeManager.CreateInstant().GetAll();

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            if (ExtensionFileName.Equals(dt.Rows[i]["TypeCode"].ToString()))
                return;
        }

        string strError = "File không đúng định dạng, chỉ được chọn các file có định dạng sau : ";
        for (int i = 0; i < dt.Rows.Count - 1; i++)
            strError += dt.Rows[i]["TypeCode"].ToString() + ", ";
        strError += dt.Rows[dt.Rows.Count - 1]["TypeCode"].ToString();
        CustomValidator1.ErrorMessage = strError;
        args.IsValid = false;
    }
    protected void btAdd_Click(object sender, EventArgs e)
    {
        DocumentEntity obj = GetDocument();
        if (obj != null)
        {
            if (DocumentManager.CreateInstant().GetByName(obj.DocumentName) == null)
            {
                DocumentManager.CreateInstant().Insert(obj);
                CustomValidator1.ErrorMessage = "Thêm thành công";
                CustomValidator1.IsValid = false;
            }
            else
            {
                CustomValidator1.ErrorMessage = "Tên tài liệu đã tồn tại, vui lòng chọn tên khác";
                CustomValidator1.IsValid = false;
            }
        }
    }
}
