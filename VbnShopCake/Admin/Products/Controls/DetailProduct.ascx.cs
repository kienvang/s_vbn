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

public partial class Admin_Products_Controls_DetailProduct : System.Web.UI.UserControl
{
    public Guid ProductId
    {
        get
        {
            return !string.IsNullOrEmpty(Request["id"]) ? Util.IsGuid(Request["id"]) ? new Guid(Request["Id"]) : Guid.Empty : Guid.Empty;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadDetail();
        }
    }

    void LoadDetail()
    {
        ProductsEntity product = ProductsManager.CreateInstant().SelectOne(ProductId);
        if (product != null)
        {
            lblAbstract.Text = Filter.Encoding(product.Abstract);
            lblWaranty.Text = Filter.Encoding(product.Warranty);
            lblDetail.Text = product.Detail;
        }
    }
}
