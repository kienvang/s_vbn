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

public partial class Admin_Banner_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogo_Click(object sender, EventArgs e)
    {
        if (fileLogo.HasFile)
        {
            BannerEntity banner = BannerManager.CreateInstant().GetBanner();
            if (banner != null)
            {
                banner.LogoUrl = FileUploadControl.FullPath(fileLogo, Modules.EnumsFile.Banner, "", BannerFields.LogoUrl.MaxLength);
                BannerManager.CreateInstant().Update(banner);
            }
            else
            {
                banner = new BannerEntity();
                banner.BannerUrl = "";
                banner.LogoUrl = FileUploadControl.FullPath(fileLogo, Modules.EnumsFile.Banner, "", BannerFields.LogoUrl.MaxLength);
                BannerManager.CreateInstant().Insert(banner);
            }
            Response.Redirect("/Admin/Banner");
        }
    }

    protected void btnBanner_Click(object sender, EventArgs e)
    {
        if (fileBanner.HasFile)
        {
            BannerEntity banner = BannerManager.CreateInstant().GetBanner();
            if (banner != null)
            {
                banner.BannerUrl = FileUploadControl.FullPath(fileBanner, Modules.EnumsFile.Banner, "", BannerFields.BannerUrl.MaxLength);
                BannerManager.CreateInstant().Update(banner);
            }
            else
            {
                banner = new BannerEntity();
                banner.LogoUrl = "";
                banner.BannerUrl = FileUploadControl.FullPath(fileBanner, Modules.EnumsFile.Banner, "", BannerFields.BannerUrl.MaxLength);
                BannerManager.CreateInstant().Insert(banner);
            }
            Response.Redirect("/Admin/Banner");
        }
    }
}
