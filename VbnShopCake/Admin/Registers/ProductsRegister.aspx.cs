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

public partial class Admin_Registers_ProductsRegister : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadData();
        }
    }

    void LoadData()
    {
        DataTable table = ProductRegisterManager.CreateInstant().SelectAllRDT();
        table.DefaultView.Sort = "Approved,CreatedDate desc";
        repProducts.DataSource = table.DefaultView;
        repProducts.DataBind();
    }

    protected void repProducts_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        switch (e.CommandName)
        {
            case "del":
                ProductRegisterManager.CreateInstant().Delete(new Guid(e.CommandArgument.ToString()));
                Response.Redirect(Request.RawUrl);
                break;
        }
    }
}
