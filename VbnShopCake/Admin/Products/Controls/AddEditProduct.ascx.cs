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
using Modules.Products;

using System.Globalization;
using Modules;

public partial class Admin_Products_Controls_AddEditProduct : System.Web.UI.UserControl
{
    public string stStatus = "Thêm";
    public Guid RegisterId
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
            if (RegisterId != Guid.Empty)
            {
                LoadData();
            }
        }
    }

    void LoadData()
    {
        ProductRegisterEntity register = ProductRegisterManager.CreateInstant().SelectOne(RegisterId);
        if (register != null)
        {
            txtProductName.Text = register.ProductName;
            txtPrice.Text = FNumber.FormatNumber(register.PriceSell).Replace(",", "");
            txtPricePo.Text = FNumber.FormatNumber(register.PriceBuy).Replace(",", "");
            txtAbstract.Text = register.Abstract;
            txtWarranty.Text = register.Warranty;
            txtDetail.Value = register.Detail;
            if (!string.IsNullOrEmpty(register.Thumbnail))
            {
                img.Visible = true;
                img.ImageUrl = register.Thumbnail + "?w=120&c=1";
            }
        }
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
    ProductsEntity getProduct()
    {
        ProductsEntity product = new ProductsEntity();

        product.Id = Guid.NewGuid();
        product.ProductName = Filter.GetMaxString(txtProductName.Text.Trim(), ProductsFields.ProductName.MaxLength);
        product.TextId = ProductsManager.CreateInstant().GetUniqueTextIdFromUnicodeText(product.ProductName);
        product.CatalogId = ucCatalogs.getCatId();
        product.SupplierId = new Guid(ddlSuppliers.SelectedValue);
        product.Price = decimal.Parse(txtPrice.Text.Trim(), new CultureInfo("en-US"));
        product.Abstract = Filter.GetMaxString(txtAbstract.Text.Trim(), ProductsFields.Abstract.MaxLength);
        product.Warranty = Filter.GetMaxString(txtWarranty.Text.Trim(), ProductsFields.Warranty.MaxLength);
        product.Detail = Filter.GetMaxString(txtDetail.Value.Trim(), ProductsFields.Detail.MaxLength);

        product.Thumbnail = "";
        if (fileThumbnail.HasFile)
        {
            product.Thumbnail = FileUploadControl.FullPath(fileThumbnail, EnumsFile.Thumbnails, product.TextId, ProductsFields.Thumbnail.MaxLength);
        }
        else
        {
            ProductRegisterEntity register = ProductRegisterManager.CreateInstant().SelectOne(RegisterId);
            if (register != null && !string.IsNullOrEmpty(register.Thumbnail))
            {
                product.Thumbnail = register.Thumbnail;
            }
        }

        product.CreatedDate = DateTime.Now;
        product.CreatedBy = Util.CurrentUserName;
        product.UpdatedDate = DateTime.Now;
        product.UpdatedBy = Util.CurrentUserName;
        
        return product;
    }

    ProductInfoEntity getProductInfo(ProductsEntity product)
    {
        ProductInfoEntity info = new ProductInfoEntity();

        info.Id = product.Id;
        info.PriceSell = product.Price;
        info.PriceBuy = FNumber.ConvertDecimal(txtPricePo.Text.Trim());
        info.Currency = "VND";

        return info;
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

    StorageEntity getStore(ProductsEntity product)
    {
        StorageEntity store = new StorageEntity();

        store.ProductId = product.Id;
        store.Import = 0;
        store.Export = 0;
        store.Price = product.Price;
        store.PoPrice = FNumber.ConvertDecimal(txtPricePo.Text.Trim());
        store.CreatedBy = Util.CurrentUserName;

        return store;
    }

    DealsEntity getDeal(ProductsEntity product)
    {
        DealsEntity deal = new DealsEntity();

        deal.ProductId = product.Id;
        deal.Price = product.Price;
        deal.PoPrice = FNumber.ConvertDecimal(txtPricePo.Text.Trim());
        deal.CreatedBy = Util.CurrentUserName;
        deal.CreatedDate = DateTime.Now;

        return deal;
    }
    #endregion
    
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            ProductsEntity product = getProduct();
            ProductInfoEntity info = getProductInfo(product);
            
            ProductInfoManager.CreateInstant().Insert(info);
            ProductsManager.CreateInstant().Insert(product);

            CatalogsManager.CreateInstant().UpdateTotalAmount(product.CatalogId);

            EntityCollection<ProductInCatalogEntity> items = getGetListCat(product);
            for (int i = 0; i < items.Count; i++)
                ProductInCatalogManager.CreateInstant().Insert(items[i]);

            StorageEntity store = getStore(product);
            StorageManager.CreateInstant().Insert(store);

            DealsEntity deal = getDeal(product);
            DealsManager.CreateInstant().Insert(deal);

            ProductRegisterEntity register = ProductRegisterManager.CreateInstant().SelectOne(RegisterId);
            if (register != null)
            {
                register.Approved = true;
                ProductRegisterManager.CreateInstant().Update(register);
            }

            CatalogsEntity cat = CatalogsManager.CreateInstant().SelectOne(product.CatalogId);
            ProductsEntity tmp = ProductsManager.CreateInstant().SelectOne(product.Id);
            if (cat != null && tmp != null)
            {
                tmp.ProductCode = cat.CatCode + "-" + tmp.IntId.ToString();
                ProductsManager.CreateInstant().Update(tmp);
            }

            HistoryProductManager.CreateInstant().AddHistory(EnumsAction.AddProuct, product.Id);

            Response.Redirect("/Admin/Products/Default.aspx");
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Admin/Products/Default.aspx");
    }

    protected void valProducts_ServerValidate(object source, ServerValidateEventArgs args)
    {
        args.IsValid = true;
        if (ProductsManager.CreateInstant().IsExist(txtProductName.Text.Trim()))
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
}
