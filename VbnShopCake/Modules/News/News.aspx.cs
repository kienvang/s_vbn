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

public partial class Modules_News_News : System.Web.UI.Page
{
    public string TextId
    {
        get
        {
            return !string.IsNullOrEmpty(Request["textId"]) ? Request["textId"] : "";
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        NewsEntity news = NewsManager.CreateInstant().GetNews(TextId);
        if (news != null)
        {
            lblSubject.Text = news.Subject;
            lblBody.Text = news.Body;
        }
    }
}
