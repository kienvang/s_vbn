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

public partial class Admin_Registers_SuppliersRegister : System.Web.UI.Page
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
        DataTable table = SupplierRegisterManager.CreateInstant().GetRegister();
        repSupplier.DataSource = table;
        repSupplier.DataBind();
    }

    protected void repSupplier_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        SupplierRegisterEntity register = SupplierRegisterManager.CreateInstant().SelectOne(new Guid(e.CommandArgument.ToString()));
        if (register != null)
        {
            switch (e.CommandName)
            {
                case "del":
                    SupplierRegisterManager.CreateInstant().Delete(register.Id);
                    Response.Redirect(Request.RawUrl);
                    break;
            }
        }
    }
}
