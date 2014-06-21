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
using LayerHelper.ShopCake.DAL.HelperClasses;

public partial class Admin_Catalog_Controls_GetCatalogs : System.Web.UI.UserControl
{
    public int catId = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //LoadCombo();
            LoadData();

            if (catId > 0)
            {
                CatalogsEntity cat = CatalogsManager.CreateInstant().SelectOne(catId);
                if (cat != null)
                {
                    lblCatName.Text = cat.CatCode + " - " + cat.CatalogName;
                    hidCatId.Value = cat.Id.ToString();
                    txt.Text = cat.Id.ToString();
                }
            }

            hidIsDirty.Value = "false";
        }
    }

    void LoadHeader(int Id)
    {
        CatalogsEntity _cat = CatalogsManager.CreateInstant().SelectOne(Id);
        if (_cat == null)
        {
            trHeader.Visible = false;
        }
        else
        {
            trHeader.Visible = true;
            lkPrev.CommandArgument = _cat.ParentId.ToString();
            lkPrev.Text = _cat.Id.ToString();
            lblCatName0.Text = _cat.CatalogName;
            lblAmount.Text = _cat.ProductAmount.ToString();

            lkSelect.CommandArgument = _cat.Id.ToString();
        }
    }

    void LoadData()
    {
        if (catId == 0)
            trHeader.Visible = false;
        else
        {
            LoadHeader(catId);
        }

        EntityCollection<CatalogsEntity> cats = CatalogsManager.CreateInstant().GetByParentId(catId);
        repCatalog.DataSource = cats;
        repCatalog.DataBind();

        GetCatList();
        
    }

    void GetCatList()
    {
        DataTable table = CatalogsManager.CreateInstant().GetListCatalogById(catId);
        repListCat.DataSource = table;
        repListCat.DataBind();

        hidListCats.Value = "";
        if (table != null && table.Rows.Count > 0)
        {
            string st = "";
            for (int i = 0; i < table.Rows.Count; i++)
            {
                st += table.Rows[i]["Id"].ToString() + "|";
            }
            hidListCats.Value = st.TrimEnd('|');
        }
    }

    void ItemCommand(object CommandArgument, string CommandName)
    {
        if (string.IsNullOrEmpty(CommandArgument.ToString()) || string.IsNullOrEmpty(CommandName))
            return;
        int Id = int.Parse(CommandArgument.ToString());

        CatalogsEntity cat = new CatalogsEntity();
        switch (CommandName)
        {
            case "selectfirst":
                cat = CatalogsManager.CreateInstant().SelectOne(Id);
                if (cat != null)
                {
                    lblCatName.Text = cat.CatCode + " - " + cat.CatalogName;
                    hidCatId.Value = Id.ToString();
                    txt.Text = cat.Id.ToString();
                    catId = Id;
                    LoadHeader(Id);
                    GetCatList();
                    hidIsDirty.Value = "true";
                }
                break;
            case "select":
                cat = CatalogsManager.CreateInstant().SelectOne(Id);
                if (cat != null)
                {
                    lblCatName.Text = cat.CatCode + " - " + cat.CatalogName;
                    hidCatId.Value = Id.ToString();
                    txt.Text = cat.Id.ToString();
                    catId = Id;
                    LoadHeader(cat.ParentId);
                    GetCatList();
                    hidIsDirty.Value = "true";
                }
                break;
            case "prev":
                //hidCatId.Value = "";
                catId = Id;
                LoadData();
                break;
            case "next":
                //hidCatId.Value = "";
                catId = Id;
                LoadData();
                break;
        }
    }

    protected void repCatalog_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        ItemCommand(e.CommandArgument, e.CommandName);
    }

    protected void lkPrev_Command(object sender, CommandEventArgs e)
    {
        ItemCommand(e.CommandArgument, e.CommandName);
    }

    protected void lkSelect_Command(object sender, CommandEventArgs e)
    {
        ItemCommand(e.CommandArgument, e.CommandName);
    }

    public int getCatId()
    {
        int Id = 0;
        int.TryParse(hidCatId.Value, out Id);
        return Id;
    }

    public int[] getListCatId()
    {
        string[] st = hidListCats.Value.Split('|');
        if (st.Length > 0)
        {
            int[] Ids = new int[st.Length];
            for (int i = 0; i < st.Length; i++)
            {
                int t = 0;
                if (!int.TryParse(st[i], out t) || t <= 0)
                    return null;
                Ids[i] = t;
            }
            return Ids;
        }
        return null;
    }

    public bool IsDirty()
    {
        if (hidIsDirty.Value == "false")
            return false;
        return true;
    }
}
