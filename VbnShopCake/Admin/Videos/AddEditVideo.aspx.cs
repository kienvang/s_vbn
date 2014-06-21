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
using System.IO;

public partial class Admin_Videos_AddEditVideo : System.Web.UI.Page
{
    public Guid VideoId
    {
        get
        {
            return !string.IsNullOrEmpty(Request["id"]) ? Util.IsGuid(Request["id"]) ? new Guid(Request["id"]) : Guid.Empty : Guid.Empty;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadCombo();
            if (VideoId != Guid.Empty)
            {
                LoadData();
            }
        }
    }

    void LoadCombo()
    {
        DataTable table = VideoTypeManager.CreateInstant().SelectAllRDT();
        table.DefaultView.Sort = "TypeName";
        ddlVideoType.DataTextField = "TypeName";
        ddlVideoType.DataValueField = "Id";
        ddlVideoType.DataSource = table.DefaultView;
        ddlVideoType.DataBind();

        VisibleEmbeb();

        table = VideoCatalogManager.CreateInstant().SelectAllRDT();
        table.DefaultView.Sort = "CatName";
        ddlCatalog.DataTextField = "CatName";
        ddlCatalog.DataValueField = "Id";
        ddlCatalog.DataSource = table;
        ddlCatalog.DataBind();
    }

    void LoadData()
    {
        VideosEntity video = VideosManager.CreateInstant().SelectOne(VideoId);
        if (video != null)
        {
            txtVideoName.Text = video.VideoName;
            txtDescription.Text = video.Descriptions;
            chkIsVisibleHome.Checked = video.IsVisibleHome;
            ddlVideoType.SelectedValue = video.VideoTypeId;
            ddlCatalog.SelectedValue = video.CatalogId.ToString();

            btnEdit.Visible = true;
            btnDelete.Visible = true;
            btnAdd.Visible = false;
            reqVideo.Visible = false;
            reqVideo.IsValid = true;
            ddlOjectType.SelectedValue = video.ObjectType;
            txtCodeEmbeb.Text = video.CodeEmbed;

            img.Visible = true;
            if (!string.IsNullOrEmpty(video.Thumbnail))
                img.ImageUrl = video.Thumbnail + "?w=120&h=100&c=0";
            else
                img.ImageUrl = "/images/no_img.gif";

            VisibleEmbeb();
        }
    }

    void VisibleEmbeb()
    {
        if (ddlVideoType.SelectedValue == EnumsMediaType.Flash)
        {
            tdUpload.Visible = false;
            reqVideo.Enabled = false;

            tdOjectType.Visible = true;
            tdCodeEmbeb.Visible = true;
            reqCodeEmbeb.Enabled = true;
        }
        else
        {
            tdUpload.Visible = true;
            reqVideo.Enabled = true;

            tdOjectType.Visible = false;
            tdCodeEmbeb.Visible = false;
            reqCodeEmbeb.Enabled = false;
        }
    }

    VideosEntity getVideo()
    {
        VideosEntity video = new VideosEntity();

        video.Id = Guid.NewGuid();
        video.VideoName = Filter.GetMaxString(txtVideoName.Text.Trim(), VideosFields.VideoName.MaxLength);
        video.VideoTypeId = ddlVideoType.SelectedValue;
        video.IsVisibleHome = chkIsVisibleHome.Checked;
        video.Descriptions = Filter.GetMaxString(txtDescription.Text.Trim(), VideosFields.Descriptions.MaxLength);
        video.AutoStart = chkAutoStart.Checked;
        video.CatalogId = int.Parse(ddlCatalog.SelectedValue);

        return video;
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            VideosEntity video = getVideo();
            video.TextId = VideosManager.CreateInstant().GetUniqueTextIdFromUnicodeText(video.VideoName);
            video.CreatedBy = Util.CurrentUserName;
            video.Thumbnail = "/images/no_img.gif";
            if (fileThumbnail.HasFile)
            {
                video.Thumbnail = FileUploadControl.FullPath(fileThumbnail, EnumsFile.Images, video.TextId, VideosFields.Thumbnail.MaxLength);
            }

            video.Path = "";
            if (fileUpload.HasFile)
                video.Path = FileUploadControl.FullPath(fileUpload, EnumsFile.Videos, video.TextId, VideosFields.Path.MaxLength);

            video.VideoTypeId = ddlVideoType.SelectedValue;
            if (video.VideoTypeId == EnumsMediaType.Flash)
            {
                video.ObjectType = ddlOjectType.SelectedValue;
                video.CodeEmbed = Filter.GetMaxString(txtCodeEmbeb.Text.Trim(), VideosFields.CodeEmbed.MaxLength);
            }

            if (video.IsVisibleHome)
                VideosManager.CreateInstant().UpdateVisibleVideo();

            VideosManager.CreateInstant().Insert(video);

            Response.Redirect("/Admin/Videos/");
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            VideosEntity video = getVideo();
            VideosEntity tmp = VideosManager.CreateInstant().SelectOne(VideoId);
            if (tmp != null)
            {
                if (tmp.VideoName != video.VideoName)
                    video.TextId = VideosManager.CreateInstant().GetUniqueTextIdFromUnicodeText(video.VideoName);

                video.Thumbnail = tmp.Thumbnail;
                if (fileThumbnail.HasFile)
                {
                    video.Thumbnail = FileUploadControl.FullPath(fileThumbnail, EnumsFile.Images, video.TextId, VideosFields.Thumbnail.MaxLength);
                }

                video.Path = tmp.Path;
                if (fileUpload.HasFile)
                {
                    video.Path = FileUploadControl.FullPath(fileUpload, EnumsFile.Videos, video.TextId, VideosFields.Path.MaxLength);
                }
                video.CreatedBy = tmp.CreatedBy;
                video.CreatedDate = tmp.CreatedDate;
                video.Id = tmp.Id;

                video.VideoTypeId = ddlVideoType.SelectedValue;
                if (video.VideoTypeId == EnumsMediaType.Flash)
                {
                    video.ObjectType = ddlOjectType.SelectedValue;
                    video.CodeEmbed = Filter.GetMaxString(txtCodeEmbeb.Text.Trim(), VideosFields.CodeEmbed.MaxLength);
                }

                if (video.IsVisibleHome)
                    VideosManager.CreateInstant().UpdateVisibleVideo();

                VideosManager.CreateInstant().Update(video);

                Response.Redirect("/Admin/Videos/");
            }
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        VideosEntity tmp = VideosManager.CreateInstant().SelectOne(VideoId);
        if (tmp != null)
        {
            VideosManager.CreateInstant().Delete(tmp.Id);
            //File.Delete(Server.MapPath("~") + tmp.Path);
            if (tmp.IsVisibleHome)
                VideosManager.CreateInstant().UpdateSetVisibleVideo();

            Response.Redirect("/Admin/Videos/");
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Admin/Videos/");
    }



    protected void ddlVideoType_SelectedIndexChanged(object sender, EventArgs e)
    {
        VisibleEmbeb();
    }
}
