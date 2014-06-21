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

public partial class Admin_Adverts_AdvertSetting : System.Web.UI.Page
{
    public Guid Id
    {
        get
        {
            return !string.IsNullOrEmpty(Request["id"]) ? Util.IsGuid(Request["id"]) ? new Guid(Request["id"]) : Guid.Empty : Guid.Empty;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        LoadData();
        LoadSetting();
    }

    void LoadData()
    {
        AdvertsEntity advert = AdvertsManager.CreateInstant().GetById(Id);
        if (advert != null)
        {
            BoxImageFlash21.MediaAddress = advert.AddressUrl;
            BoxImageFlash21.MediaName = advert.AdvertName;
            BoxImageFlash21.MediaPath = advert.Path;
            BoxImageFlash21.MediaType = advert.Type;
        }
    }

    void LoadSetting()
    {
        DataTable table = AdvertsManager.CreateInstant().GetSetting(Id);
        repSetting.DataSource = table;
        repSetting.DataBind();
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        AdvertsManager.CreateInstant().DeleteAll(Id);
        AdvertsManager.CreateInstant().DeleteAdvertById(Id);
        AdvertsManager.CreateInstant().Delete(Id);
        Response.Redirect("/Admin/Adverts/");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Admin/Adverts/");
    }
}
