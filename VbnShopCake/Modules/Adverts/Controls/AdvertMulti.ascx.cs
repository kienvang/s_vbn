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

public partial class Modules_Adverts_Controls_AdvertMulti : System.Web.UI.UserControl
{
    public Guid AdvertPositionId { get; set; }
    public int FHeight { get; set; }
    public int FWidth { get; set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        this.Visible = false;
        DataTable table = AdvertsManager.CreateInstant().GetAdvert(AdvertPositionId);
        if (table != null && table.Rows.Count > 0)
        {
            repAdvert.DataSource = table;
            repAdvert.DataBind();
            this.Visible = true;
        }
        
    }
}
