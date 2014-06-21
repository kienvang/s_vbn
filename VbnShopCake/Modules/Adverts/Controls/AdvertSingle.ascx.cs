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

public partial class Modules_Adverts_Controls_AdvertSingle : System.Web.UI.UserControl
{
    public Guid AdvertPositionId { get; set; }
    public int FHeight { get; set; }
    public int FWidth { get; set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable table = AdvertsManager.CreateInstant().GetAdvert(AdvertPositionId);
        if (table != null && table.Rows.Count > 0)
        {
            DataRow r = table.Rows[0];

            BoxImageFlash1.MediaName = r["AdvertName"].ToString();
            BoxImageFlash1.MediaPath = r["Path"].ToString();
            BoxImageFlash1.MediaAddress = r["AddressUrl"].ToString();
            BoxImageFlash1.MediaType = r["Type"].ToString();
            BoxImageFlash1.FHeight = FHeight;
            BoxImageFlash1.FWidth = FWidth;
            BoxImageFlash1.FHeight2 = int.Parse(r["Height"].ToString());
            BoxImageFlash1.FWidth2 = int.Parse(r["Width"].ToString());
        }
        else
            this.Visible = false;
    }
}
