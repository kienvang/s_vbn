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

public partial class Payment_nganluongcheckin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(Util.CurrentUserName)) Response.Redirect("/");

        TransactionEntity trans;
        if (NganLuong.CreateInstant().verifyPaymentUrl(Page, out trans))
        {
            switch (trans.ProductType.ToUpper())
            {
                case NganLuong.PayShop:
                    Response.Redirect("/Payment/PayShop.aspx?t=" + trans.ProductType + "&ordercode=" + trans.OrderCode + "&status=1");
                    break;
                case NganLuong.PayDoc:
                    Response.Redirect("/Payment/PayDoc.aspx?t=" + trans.ProductType + "&code=" + trans.OrderCode + "&status=1");
                    break;
            }
            
        }
        switch (trans.ProductType.ToUpper())
        {
            case NganLuong.PayShop:
                Response.Redirect("/Payment/PayShop.aspx?status=0");
                break;
        }
    }
}
