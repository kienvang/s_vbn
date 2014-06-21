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

public partial class Modules_Home_Controls_Videos : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LoadVideo();
        LoadVideoHome();
    }

    void LoadVideoHome()
    {
        VideosEntity video = VideosManager.CreateInstant().GetVideoHome();
        if (video != null)
        {
            VideoBox1.FileName =  Library.Tools.UrlBuilder.RootUrl + video.Path;
            VideoBox1.VideoType = video.VideoTypeId;
            VideoBox1.Thumbnail = video.Thumbnail;
            VideoBox1.ObjectType = video.ObjectType;
            VideoBox1.CodeEmbeb = video.CodeEmbed;
            if (video.AutoStart)
                VideoBox1.AutoStart = 1;
            else
                VideoBox1.AutoStart = 0;
        }
    }

    void LoadVideo()
    {
        DataTable table = VideosManager.CreateInstant().GetVideoTop(Config.GetTopVideo());
        repVideo.DataSource = table;
        repVideo.DataBind();
    }
}
