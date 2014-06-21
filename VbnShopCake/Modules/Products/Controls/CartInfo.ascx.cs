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

using Modules.Cart;
using Library.Tools;

public partial class Modules_Products_Controls_CartInfo : System.Web.UI.UserControl
{
    public decimal Total = 0;

    protected void Page_Load(object sender, EventArgs e)
    {

        LoadData();

    }

    void LoadData()
    {
        DataTable table = CartsSession.CreateInstant().GetCartRDT(this.Page);
        repCart.DataSource = table;
        repCart.DataBind();

        if (table == null || table.Rows.Count <= 0)
            Response.Redirect(UrlBuilder.RootUrl);

        if (table == null || table.Rows.Count <= 0)
        {
            this.Visible = false;
        }
        else
        {
            foreach (DataRow r in table.Rows)
            {
                Total += (Convert.ToDecimal(r["Price"]) * Convert.ToDecimal(r["Total"]));
            }
        }
    }
}
