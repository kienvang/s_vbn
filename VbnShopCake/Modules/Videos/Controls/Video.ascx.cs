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

public partial class Modules_Videos_Controls_Video : System.Web.UI.UserControl
{
    public int IntId
    {
        get
        {
            return !string.IsNullOrEmpty(Request["IntId"]) ? FNumber.ConvertInt(Request["IntId"]) : 0;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        LoadVideo();
        LoadVideoTop();
    }

    void LoadVideo()
    {
        VideosEntity videohome = null;
        VideosEntity videoByIntId = null;

        videohome = VideosManager.CreateInstant().GetVideoHome();
        if (IntId > 0)
        {
            videoByIntId = VideosManager.CreateInstant().GetVideoByIntId(IntId);
        }

        VideosEntity video = null;
        if (videoByIntId != null)
        {
            video = videoByIntId;
        }
        else
        {
            if (videohome != null)
                video = videohome;
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
        }
    }

    void LoadVideoTop()
    {
        DataTable table = VideosManager.CreateInstant().GetVideoTop(Modules.Config.GetTopVideo());
        repVideoTop.DataSource = table;
        repVideoTop.DataBind();
    }
}
