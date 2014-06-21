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

public partial class Modules_Controls_BoxImageFlash2 : System.Web.UI.UserControl
{
    string _MediaType = Modules.EnumsMediaType.Image;
    public string MediaType
    {
        get { return _MediaType; }
        set { _MediaType = value; }
    }

    string _MediaName;
    public string MediaName
    {
        get { return _MediaName; }
        set { _MediaName = value; }
    }

    string _MediaPath;
    public string MediaPath
    {
        get { return _MediaPath; }
        set { _MediaPath = value; }
    }

    public string _MediaAddress;
    public string MediaAddress
    {
        get { return _MediaAddress; }
        set { _MediaAddress = value; }
    }

    int _FHeight = 200;
    public int FHeight
    {
        get { return _FHeight; }
        set { _FHeight = value; }
    }

    int _FWidth = 300;
    public int FWidth
    {
        get { return _FWidth; }
        set { _FWidth = value; }
    }

    int _AutoStart;
    public int AutoStart
    {
        get { return _AutoStart; }
        set { _AutoStart = value; }
    }

    public Guid AdvertId;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (AdvertId == Guid.Empty)
        {
            //this.Visible = false;
            return;
        }

        AdvertsEntity ad = AdvertsManager.CreateInstant().GetById(AdvertId);
        if (ad != null)
        {
            MediaAddress = ad.AddressUrl;
            MediaName = ad.AdvertName;
            MediaPath = ad.Path;
            MediaType = ad.Type;
        }
    }
}
