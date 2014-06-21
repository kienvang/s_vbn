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

public partial class Modules_Adverts_Controls_BoxAdvert : System.Web.UI.UserControl
{
    public Guid AdvertPositionId { get; set; }
    public bool IsSingle { get; set; }
    public int FHeight { get; set; }
    public int FWidth { get; set; }
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsSingle)
        {
            AdvertSingle1.AdvertPositionId = AdvertPositionId;
            AdvertSingle1.FHeight = FHeight;
            AdvertSingle1.FWidth = FWidth;

            AdvertSingle1.Visible = true;
        }
        else
        {
            AdvertMulti1.AdvertPositionId = AdvertPositionId;
            AdvertMulti1.FWidth = FWidth;
            AdvertMulti1.FHeight = FHeight;
            AdvertsPositionEntity group = AdvertsPositionManager.CreateInstant().SelectOne(AdvertPositionId);
            if (group != null)
                AdvertMulti1.FHeight = group.Height;
            AdvertMulti1.Visible = true;
        }
    }
}
