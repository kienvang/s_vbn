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
using Modules;
using Modules.Cart;
using Library.Tools;
using System.Collections.Specialized;
public partial class Default4 : System.Web.UI.Page
{
    NameValueCollection GetCollection(string value)
    {
        NameValueCollection collect = new NameValueCollection();

        if (!string.IsNullOrEmpty(value))
        {
            string[] param = value.Split('&');
            for (int i = 0; i < param.Length; i++)
            {
                string[] item = param[i].Split('=');
                collect.Add(item[0], item[1]);
            }
        }

        return collect;
    }

    string Decode(string value)
    {
        return HttpContext.Current.Server.UrlDecode(value);
    }

    CartItem GetItemCookie(string item)
    {
        return GetItemCookie(GetCollection(item));
    }

    CartItem GetItemCookie(NameValueCollection item)
    {
        CartItem cart = new CartItem();

        cart.SupplierId = new Guid(Decode(item[CartItem._SupplierId]));
        cart.ProductId = new Guid(Decode(item[CartItem._ProductId]));
        cart.ProductName = Decode(item[CartItem._ProductName]);
        cart.Price = FNumber.ConvertDecimal(Decode(item[CartItem._Price]));
        cart.Total = FNumber.ConvertInt(Decode(item[CartItem._Total]));
        cart.ProductParentId = new Guid(Decode(item[CartItem._ProductParentId]));
        cart.ProductCode = Decode(item[CartItem._ProductCode]);

        return cart;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        
        Response.Write(st);
    }
}
