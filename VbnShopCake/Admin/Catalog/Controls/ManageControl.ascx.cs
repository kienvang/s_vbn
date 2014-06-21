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

using Library.Tools;

public partial class Admin_Catalog_Controls_ManageControl : System.Web.UI.UserControl
{
    public CatalogsEntity _cat;
    public int catId
    {
        get
        {
            int CatId = 0;
            if (!string.IsNullOrEmpty(Request["catId"]))
            {
                if (int.TryParse(Request["catId"], out CatId) && CatId < 0)
                {
                    CatId = 0;
                }
            }
            return CatId;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        _cat = new CatalogsEntity();

        if (catId == 0)
            trHeader.Visible = false;
        else
        {
            _cat = CatalogsManager.CreateInstant().SelectOne(catId);
            if (_cat == null)
            {
                trHeader.Visible = false;
            }
            else
            {
                lkAdd.CommandArgument = _cat.Id.ToString();
            }
        }

        if (!IsPostBack)
        {
            //LoadCombo();
            LoadData();

            DataTable table = GetCatList();
            repListCat.DataSource = table;
            repListCat.DataBind();
        }
    }

    void LoadCombo(int Id, int ParentId)
    {
        EntityCollection<CatalogsEntity> cats = CatalogsManager.CreateInstant().GetByParentIdNotId(Id, ParentId);
        ddlCatalog.DataTextField = "CatalogName";
        ddlCatalog.DataValueField = "Id";
        ddlCatalog.DataSource = cats;
        ddlCatalog.DataBind();
    }

    void LoadData()
    {
        EntityCollection<CatalogsEntity> cats = CatalogsManager.CreateInstant().GetByParentId(catId);
        repCatalog.DataSource = cats;
        repCatalog.DataBind();
    }

    public DataTable GetCatList()
    {
        return CatalogsManager.CreateInstant().GetListCatalogById(catId);
    }

    public EntityCollection<CatalogsEntity> GetItems(int Id)
    {
        return CatalogsManager.CreateInstant().GetByParentId(Id, null);
    }

    string getString(string data, int len)
    {
        return Filter.GetMaxString(data, len);
    }

    CatalogsEntity getCat()
    {
        CatalogsEntity cat = new CatalogsEntity();
        cat.CatalogName = getString(txtCatalogName.Text.Trim(), CatalogsFields.CatalogName.MaxLength);
        cat.ParentId = int.Parse(ddlCatalog.SelectedValue);
        cat.ToolTip = getString(txtToolTip.Text.Trim(), CatalogsFields.CatalogName.MaxLength);
        cat.IsVisible = chkIsVisible.Checked;
        cat.CatCode = getString(txtCatCode.Text.Trim(), CatalogsFields.CatCode.MaxLength);

        return cat;
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            CatalogsEntity cat = getCat();
            cat.TextId = CatalogsManager.CreateInstant().GetUniqueTextIdFromUnicodeText(cat.CatalogName);
            cat.ParentId = int.Parse(hidId.Value);

            CatalogsManager.CreateInstant().Insert(cat);

            if (cat.ParentId != 0)
            {
                CatalogsManager.CreateInstant().UpdateIsLeaf(cat.ParentId);
            }

            //LoadCombo();
            //LoadData();

            WebUtility.Refesh(Page);
        }
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        if (Page.IsValid && !string.IsNullOrEmpty(hidId.Value))
        {
            int Id = int.Parse(hidId.Value);
            CatalogsEntity cat = getCat();
            CatalogsEntity tmp = CatalogsManager.CreateInstant().SelectOne(Id);

            if (tmp != null)
            {
                cat.Id = tmp.Id;
                if (ddlCatalog.SelectedValue == "-1")
                    cat.ParentId = tmp.ParentId;

                if (cat.CatalogName != tmp.CatalogName)
                    cat.TextId = CatalogsManager.CreateInstant().GetUniqueTextIdFromUnicodeText(cat.CatalogName);
                else
                    cat.TextId = tmp.TextId;

                CatalogsManager.CreateInstant().Update(cat);

                if (tmp.ParentId != 0)
                {
                    CatalogsManager.CreateInstant().UpdateIsLeaf(tmp.ParentId);
                }

                WebUtility.Refesh(Page);
            }
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        WebUtility.Refesh(Page);
    }

    void ItemCommand(object CommandArgument, string CommandName)
    {
        int Id = int.Parse(CommandArgument.ToString());
        CatalogsEntity cat = new CatalogsEntity();
        switch (CommandName)
        {
            case "add":
                cat = CatalogsManager.CreateInstant().SelectOne(Id);
                if (cat != null)
                {
                    divUpdate.Visible = true;

                    ddlCatalog.Items.Clear();
                    ddlCatalog.Items.Insert(0, new ListItem(cat.CatalogName, "-1"));
                    ddlCatalog.Enabled = false;

                    hidId.Value = cat.Id.ToString();
                }

                if (Id == 0)
                {
                    divUpdate.Visible = true;

                    ddlCatalog.Items.Clear();
                    ddlCatalog.Items.Insert(0, new ListItem("Danh mục gốc", "-1"));
                    ddlCatalog.Enabled = false;

                    hidId.Value = "0";
                }
                break;
            case "edit":

                cat = CatalogsManager.CreateInstant().SelectOne(Id);
                if (cat != null)
                {
                    btnAdd.Visible = false;
                    btnUpdate.Visible = true;
                    hidId.Value = Id.ToString();

                    divUpdate.Visible = true;

                    txtCatalogName.Text = cat.CatalogName;
                    txtToolTip.Text = cat.ToolTip;
                    chkIsVisible.Checked = cat.IsVisible;
                    txtCatCode.Text = cat.CatCode;


                    LoadCombo(cat.Id, cat.ParentId);
                    ddlCatalog.Items.Insert(0, new ListItem("----------------------------------------------", "-1"));
                }
                break;
            case "del":
                cat = CatalogsManager.CreateInstant().SelectOne(Id);
                if (cat != null)
                {
                    validUpdate.IsValid = true;
                    if (cat.ProductAmount != 0 || !cat.IsLeaf)
                    {
                        validUpdate.IsValid = false;
                        validUpdate.ErrorMessage = "Không thể xóa danh mục đang chứa sản phẩm hoặc không phải là danh mục con";
                    }

                    if (validUpdate.IsValid)
                    {
                        CatalogsManager.CreateInstant().Delete(Id);
                        WebUtility.Refesh(Page);
                    }
                }
                break;
            case "visible":
                cat = CatalogsManager.CreateInstant().SelectOne(Id);
                if (cat != null)
                {
                    cat.IsVisible = !cat.IsVisible;
                    CatalogsManager.CreateInstant().Update(cat);
                    WebUtility.Refesh(Page);
                }
                break;
            case "move-prev":
                cat = CatalogsManager.CreateInstant().SelectOne(Id);
                if (cat != null)
                {
                    CatalogsEntity parent = CatalogsManager.CreateInstant().SelectOne(cat.ParentId);
                    if (parent != null)
                    {
                        cat.ParentId = parent.ParentId;
                        CatalogsManager.CreateInstant().Update(cat);
                        CatalogsManager.CreateInstant().UpdateIsLeaf(parent.Id);

                        WebUtility.Refesh(Page);
                    }
                }
                break;
        }
    }

    protected void repCatalog_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        ItemCommand(e.CommandArgument, e.CommandName);
    }

    protected void lkAdd_Command(object sender, CommandEventArgs e)
    {
        ItemCommand(e.CommandArgument, e.CommandName);
    }

    protected void lkAddRoot_Command(object sender, CommandEventArgs e)
    {
        ItemCommand(e.CommandArgument, e.CommandName);
    }

    protected void valCatalogName_ServerValidate(object source, ServerValidateEventArgs args)
    {
        args.IsValid = true;
        if (string.IsNullOrEmpty(txtCatalogName.Text.Trim()))
        {
            args.IsValid = false;
        }
        else
        {
            // Them moi
            if (string.IsNullOrEmpty(hidId.Value))
            {
                if (CatalogsManager.CreateInstant().IsExistCatalogName(txtCatalogName.Text.Trim()))
                    args.IsValid = false;
            }
            else // Cap nhat
            {
                CatalogsEntity cat = CatalogsManager.CreateInstant().SelectOne(int.Parse(hidId.Value));
                if (cat != null)
                {
                    if (!cat.CatalogName.Equals(txtCatalogName.Text.Trim(), StringComparison.OrdinalIgnoreCase) && CatalogsManager.CreateInstant().IsExistCatalogName(txtCatalogName.Text.Trim()))
                        args.IsValid = false;
                }
            }
        }
    }

    protected void validUpdate_ServerValidate(object source, ServerValidateEventArgs args)
    {
        args.IsValid = true;
        // Them moi
        if (string.IsNullOrEmpty(hidId.Value))
        {
            if (CatalogsManager.CreateInstant().IsExistCatCode(txtCatCode.Text.Trim()))
            {
                args.IsValid = false;
                validUpdate.ErrorMessage = "Trùng mã danh mục";
            }
        }
        else
        {
            CatalogsEntity cat = CatalogsManager.CreateInstant().SelectOne(int.Parse(hidId.Value));
            if (cat != null)
            {
                if (!cat.CatCode.Equals(txtCatCode.Text.Trim()) && CatalogsManager.CreateInstant().IsExistCatCode(txtCatCode.Text.Trim()))
                {
                    args.IsValid = false;
                    validUpdate.ErrorMessage = "Trùng mã danh mục";
                }
            }
        }
    }


}
