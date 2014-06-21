using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;

using Modules.Role;
using LayerHelper.ShopCake.BLL;
using LayerHelper.ShopCake.DAL.EntityClasses;

public partial class Admin_MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!CheckRoles.CreateInstant().IsRoles(EnumsRoles.Administrator))
        {
            Response.Redirect(CheckRoles.CreateInstant().GetUrlDirect(Request.RawUrl));
        }
        LoadBanner();
    }

    void LoadBanner()
    {
        BannerEntity banner = BannerManager.CreateInstant().GetBanner();
        if (banner != null)
        {
            if (!string.IsNullOrEmpty(banner.LogoUrl))
                imgLogo.ImageUrl = banner.LogoUrl;
            if (!string.IsNullOrEmpty(banner.BannerUrl))
                imgBanner.ImageUrl = banner.BannerUrl;
        }
    }

    protected void LoginStatus1_LoggedOut(object sender, EventArgs e)
    {
        Response.Redirect("/");
    }
}
