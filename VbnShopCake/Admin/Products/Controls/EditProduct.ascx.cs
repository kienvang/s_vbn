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
using Modules;
using Modules.Products;

public partial class Admin_Products_Controls_EditProduct : System.Web.UI.UserControl
{
    public Guid ProductId
    {
        get
        {
            return !string.IsNullOrEmpty(Request["id"]) ? Util.IsGuid(Request["id"]) ? new Guid(Request["id"]) : Guid.Empty : Guid.Empty;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadCombo();
            LoadData();
        }
    }

    void LoadData()
    {
        ProductsEntity product = ProductsManager.CreateInstant().SelectOne(ProductId);
        if (product == null)
        {
            Response.Redirect("/Admin/Products/Default.aspx");
            return;
        }

        txtProductName.Text = product.ProductName;
        txtAbstract.Text = product.Abstract;
        txtDetail.Value = product.Detail;
        txtWarranty.Text = product.Warranty;
        ddlSuppliers.SelectedValue = product.SupplierId.ToString();
        ucCatalogs.catId = product.CatalogId;

        if (string.IsNullOrEmpty(product.Thumbnail))
            img.ImageUrl = "/images/no_img.gif";
        else
            img.ImageUrl = product.Thumbnail + "?w=120&c=1";
    }

    void LoadCombo()
    {
        DataTable table = new DataTable();

        table = SuppliersManager.CreateInstant().SelectByIsVisibleRDT(true);
        ddlSuppliers.DataTextField = "SupplierName";
        ddlSuppliers.DataValueField = "Id";
        ddlSuppliers.DataSource = table;
        ddlSuppliers.DataBind();
    }

    #region "Get Entity"
    ProductsEntity getProduct(ProductsEntity _product)
    {
        ProductsEntity product = new ProductsEntity();

        product.Id = _product.Id;
        product.ProductName = Filter.GetMaxString(txtProductName.Text.Trim(), ProductsFields.ProductName.MaxLength);
        if (_product.ProductName != txtProductName.Text.Trim())
            product.TextId = ProductsManager.CreateInstant().GetUniqueTextIdFromUnicodeText(product.ProductName);
        else
            product.TextId = _product.TextId;
        product.CatalogId = ucCatalogs.getCatId();
        product.SupplierId = new Guid(ddlSuppliers.SelectedValue);
        product.Abstract = Filter.GetMaxString(txtAbstract.Text.Trim(), ProductsFields.Abstract.MaxLength);
        product.Warranty = Filter.GetMaxString(txtWarranty.Text.Trim(), ProductsFields.Warranty.MaxLength);
        product.Detail = Filter.GetMaxString(txtDetail.Value.Trim(), ProductsFields.Detail.MaxLength);

        if (!fileThumbnail.HasFile)
            product.Thumbnail = _product.Thumbnail;
        else
            product.Thumbnail = FileUploadControl.FullPath(fileThumbnail, EnumsFile.Thumbnails, product.TextId, ProductsFields.Thumbnail.MaxLength);

        product.CreatedDate = _product.CreatedDate;
        product.CreatedBy = _product.CreatedBy;
        product.UpdatedDate = DateTime.Now;
        product.UpdatedBy = Util.CurrentUserName;

        return product;
    }

    EntityCollection<ProductInCatalogEntity> getGetListCat(ProductsEntity product)
    {
        EntityCollection<ProductInCatalogEntity> items = new EntityCollection<ProductInCatalogEntity>();

        int[] cats = ucCatalogs.getListCatId();
        for (int i = 0; i < cats.Length; i++)
        {
            ProductInCatalogEntity item = new ProductInCatalogEntity();
            item.ProductId = product.Id;
            item.CatId = cats[i];
            item.OrderIndex = i;

            items.Add(item);
        }

        return items;
    }
    #endregion

    protected void valProducts_ServerValidate(object source, ServerValidateEventArgs args)
    {
        args.IsValid = true;
        string ProductName = ProductsManager.CreateInstant().GetProductNameById(ProductId);
        if (ProductName != txtProductName.Text.Trim() && ProductsManager.CreateInstant().IsExist(txtProductName.Text.Trim()))
        {
            args.IsValid = false;
            valProducts.ErrorMessage = "Trùng tên sản phẩm.";
            return;
        }

        int catId = ucCatalogs.getCatId();
        int[] lst = ucCatalogs.getListCatId();

        if (catId <= 0 || lst == null)
        {
            args.IsValid = false;
            valProducts.ErrorMessage = "Chọn danh mục";
            return;
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            ProductsEntity tmp = ProductsManager.CreateInstant().SelectOne(ProductId);
            if (tmp != null)
            {
                ProductsEntity product = getProduct(tmp);
                ProductsManager.CreateInstant().Update(product);

                if (ucCatalogs.IsDirty())
                {
                    ProductInCatalogManager.CreateInstant().DeleteByProductId(product.Id);
                    EntityCollection<ProductInCatalogEntity> list = getGetListCat(product);
                    for (int i = 0; i < list.Count; i++)
                        ProductInCatalogManager.CreateInstant().Insert(list[i]);

                    CatalogsManager.CreateInstant().UpdateTotalAmount(tmp.CatalogId);
                    CatalogsManager.CreateInstant().UpdateTotalAmount(product.CatalogId);
                }

                HistoryProductManager.CreateInstant().AddHistory(EnumsAction.UpdateInfos, product.Id);

                Response.Redirect("/Admin/Products/Default.aspx");
            }
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        ProductsEntity tmp = ProductsManager.CreateInstant().SelectOne(ProductId);
        if (tmp != null)
        {
            tmp.IsDelete = true;
            ProductsManager.CreateInstant().Update(tmp);
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request["ReturnUrl"]))
            Response.Redirect(Request["ReturnUrl"]);
        else
            Response.Redirect("/Admin/Products/Default.aspx");
    }
}
