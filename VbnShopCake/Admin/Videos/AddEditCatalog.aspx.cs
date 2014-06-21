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

public partial class Admin_Videos_AddEditCatalog : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            loadData();
        }
    }

    public int Id
    {
        get { return !string.IsNullOrEmpty(Request["id"]) ? int.Parse(Request["id"]) : 0; }
    }

    void loadData()
    {
        VideoCatalogEntity cat = VideoCatalogManager.CreateInstant().GetById(Id);
        if (cat != null)
        {
            txtCatName.Text = cat.CatName;

            btnAdd.Visible = false;
            btnEdit.Visible = true;
        }
    }

    VideoCatalogEntity getCatalog()
    {
        VideoCatalogEntity ob = new VideoCatalogEntity();
        ob.CatName = txtCatName.Text.Trim();
        return ob;
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            VideoCatalogEntity cat = getCatalog();
            cat.TextId = VideoCatalogManager.CreateInstant().GetUniqueTextIdFromUnicodeText(cat.CatName);
            VideoCatalogManager.CreateInstant().Insert(cat);

            Response.Redirect("/Admin/Videos/Catalog.aspx");
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            VideoCatalogEntity cat = getCatalog();
            VideoCatalogEntity tmp = VideoCatalogManager.CreateInstant().GetById(Id);
            if (tmp != null)
            {
                cat.Id = tmp.Id;
                if (cat.CatName != tmp.CatName)
                    cat.TextId = VideoCatalogManager.CreateInstant().GetUniqueTextIdFromUnicodeText(cat.CatName);

                VideoCatalogManager.CreateInstant().Update(cat);
                Response.Redirect("/Admin/Videos/Catalog.aspx");
            }
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Admin/Videos/Catalog.aspx");
    }
}
