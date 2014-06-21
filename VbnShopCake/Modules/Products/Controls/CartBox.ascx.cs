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

using System.Collections.Generic;
using Modules.Cart;

public partial class Modules_Products_Controls_CartBox : System.Web.UI.UserControl
{
    public int QuantityCart = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        List<CartItem> carts = CartsSession.CreateInstant().GetCarts(Page);
        if (carts != null && carts.Count > 0)
            QuantityCart = carts.Count;
        else
            this.Visible = false;
    }
}
