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

public partial class Modules_Videos_Default2 : System.Web.UI.Page
{
    public int IntId
    {
        get
        {
            return !string.IsNullOrEmpty(Request["IntId"]) ? FNumber.ConvertInt(Request["IntId"]) : 0;
        }
    }

    public string CatTextId
    {
        get
        {
            return !string.IsNullOrEmpty(Request["CatTextId"]) ? Request["CatTextId"] : string.Empty;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        LoadVideo();
    }

    void LoadVideo()
    {
        VideosEntity video = null;
        bool f = false;
        if (IntId <= 0 && string.IsNullOrEmpty(CatTextId))
        {
            video = VideosManager.CreateInstant().GetVideoHome();
        }
        else
        {
            if (IntId <= 0)
            {
                video = VideosManager.CreateInstant().GetVideoByCatTextId(CatTextId);
            }
            else
            {
                video = VideosManager.CreateInstant().GetVideoByIntId(IntId);
                f = true;
            }

            if (video == null)
            {
                video = VideosManager.CreateInstant().GetVideoHome();
            }

            // load danh sach video
            DataTable tbl = VideosManager.CreateInstant().GetVideoListByCatTextId(CatTextId);
            repVideo.DataSource = tbl;
            repVideo.DataBind();
        }

        if (video != null)
        {
            VideoBox1.FileName = Library.Tools.UrlBuilder.RootUrl + video.Path;
            if (video.AutoStart)
                VideoBox1.AutoStart = 1;
            VideoBox1.VideoType = video.VideoTypeId;
            VideoBox1.Thumbnail = video.Thumbnail;
            VideoBox1.ObjectType = video.ObjectType;
            VideoBox1.CodeEmbeb = video.CodeEmbed;

            lk.NavigateUrl = Modules.Videos.UrlBuilder.ViewVideo(video.IntId, video.TextId);
            lk.ToolTip = video.VideoName;
            lk.Text = video.VideoName;

            lblDescription.Text = video.Descriptions;

            video.Views++;
            if (f)
                VideosManager.CreateInstant().Update(video);
        }
    }
}
