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
using Modules;

public partial class Admin_Products_Controls_DetailPhotos : System.Web.UI.UserControl
{
    public Guid ProductId
    {
        get
        {
            return !string.IsNullOrEmpty(Request["id"]) ? Util.IsGuid(Request["id"]) ? new Guid(Request["Id"]) : Guid.Empty : Guid.Empty;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadPhotos();
        }
    }

    void LoadPhotos()
    {
        DataTable table = ProductPhotosManager.CreateInstant().SelectByProductIdRDT(ProductId);
        repPhotos.DataSource = table;
        repPhotos.DataBind();
    }

    ProductPhotosEntity getPhoto()
    {
        ProductPhotosEntity photo = new ProductPhotosEntity();
        photo.Id = Guid.NewGuid();
        photo.ProductId = ProductId;
        photo.PhotoName = Filter.GetMaxString(txtPhotoName.Text.Trim(), ProductPhotosFields.PhotoName.MaxLength);
        if (uploadPhoto.HasFile)
            photo.Path = FileUploadControl.FullPath(uploadPhoto, photo.PhotoName, ProductPhotosFields.Path.MaxLength, EnumsFile.Catalogs);
        else
            photo.Path = "";
        return photo;
    }

    void Refresh()
    {
        Response.Redirect(WebUtility.AddQueryString(Request.Path, "id=" + Request["id"], "tabs=" + Request["tabs"]));
    }

    protected void btnAddPhoto_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            ProductPhotosEntity photo = getPhoto();
            ProductPhotosManager.CreateInstant().Insert(photo);

            Refresh();
        }
    }

    protected void valPhotos_ServerValidate(object source, ServerValidateEventArgs args)
    {
        args.IsValid = true;
        if (uploadPhoto.HasFile)
        {
            if (!FileUploadControl.IsValidPhoto(uploadPhoto, EnumsCheckType.ExtendName))
            {
                args.IsValid = false;
                valPhotos.ErrorMessage = "File hình phải là jpg, jpeg, bmp, gif, png";
            }
        }
        else
        {
            if (hidStatus.Value != "edit")
            {
                args.IsValid = false;
                valPhotos.ErrorMessage = "Chọn hình ảnh";
            }
        }
    }

    protected void btnEditPhoto_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            ProductPhotosEntity tmp = getPhoto();
            Guid Id = new Guid(hidId.Value);
            ProductPhotosEntity photo = ProductPhotosManager.CreateInstant().SelectOne(Id);
            if (photo != null)
            {
                photo.PhotoName = tmp.PhotoName;
                if (uploadPhoto.HasFile)
                    photo.Path = tmp.Path;
                ProductPhotosManager.CreateInstant().Update(photo);

                Refresh();
            }
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Refresh();
    }

    protected void repPhotos_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        Guid Id = new Guid(e.CommandArgument.ToString());
        ProductPhotosEntity photo = ProductPhotosManager.CreateInstant().SelectOne(Id);
        if (photo != null)
        {
            switch (e.CommandName)
            {
                case "isvisible":
                    photo.IsVisible = !photo.IsVisible;
                    ProductPhotosManager.CreateInstant().Update(photo);
                    Refresh();
                    break;
                case "edit":
                    hidStatus.Value = "edit";
                    txtPhotoName.Text = photo.PhotoName;

                    btnAddPhoto.Visible = false;
                    btnEditPhoto.Visible = true;
                    btnCancel.Visible = true;
                    reqPhoto.Enabled = false;

                    hidId.Value = Id.ToString();
                    break;
                case "del":
                    ProductPhotosManager.CreateInstant().Delete(Id);
                    Refresh();
                    break;
            }
        }
    }
}
