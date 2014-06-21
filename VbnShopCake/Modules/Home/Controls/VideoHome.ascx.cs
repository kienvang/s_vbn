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

public partial class Modules_Home_Controls_VideoHome : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LoadVideoTop();
    }

    void LoadVideoTop()
    {
        DataTable table = VideosManager.CreateInstant().GetVideoTop(6);
        repVideoTop.DataSource = table;
        repVideoTop.DataBind();
    }
}
