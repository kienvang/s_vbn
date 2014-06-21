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
using System.IO;

public partial class Admin_Videos_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadData();
        }
    }

    void LoadData()
    {
        DataTable table = VideosManager.CreateInstant().GetAllVideo();
        repVideos.DataSource = table;
        repVideos.DataBind();
    }

    protected void repVideos_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        VideosEntity video = VideosManager.CreateInstant().SelectOne(new Guid(e.CommandArgument.ToString()));
        if (video != null)
        {
            switch (e.CommandName)
            {
                case "del":
                    VideosManager.CreateInstant().Delete(video.Id);
                    //File.Delete(Server.MapPath("~") + video.Path);
                    if (video.IsVisibleHome)
                        VideosManager.CreateInstant().UpdateSetVisibleVideo();
                    Response.Redirect("/Admin/Videos/");
                    break;
                case "autostart":
                    video.AutoStart = !video.AutoStart;
                    VideosManager.CreateInstant().Update(video);
                    Response.Redirect("/Admin/Videos/");
                    break;
            }
        }
    }
}
