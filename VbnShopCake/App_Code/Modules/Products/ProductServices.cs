using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;

using LayerHelper.ShopCake.BLL;
using LayerHelper.ShopCake.DAL.EntityClasses;
using LayerHelper.ShopCake.DAL.HelperClasses;

using Library.Tools;
using Modules.Products;

/// <summary>
/// Summary description for ProductServices
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[System.Web.Script.Services.ScriptService]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class ProductServices : System.Web.Services.WebService
{

    public ProductServices()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string[] HelloWorld(string st)
    {
        string[] d = new string[2];
        d[0] = "ngay hom qua";
        d[1] = "ngay hom nay";
        return d;
    }

    [WebMethod]
    public string[] UpdatePrice(string _ProductId, string _Price)
    {
        string[] updates = null;
        decimal Price = 0;
        if (Util.IsGuid(_ProductId) && FNumber.IsDecimal(_Price))
        {
            Guid productId = new Guid(_ProductId);
            Price = FNumber.ConvertDecimal(_Price);
            string action = "";

            ProductsEntity product = ProductsManager.CreateInstant().SelectOne(productId);
            if (product != null)
            {
                product.Price = Price;
                product.UpdatedBy = Util.CurrentUserName;
                product.UpdatedDate = DateTime.Now;

                ProductsManager.CreateInstant().Update(product);
            }

            ProductInfoEntity info = ProductInfoManager.CreateInstant().SelectOne(productId);
            if (info != null)
            {
                action = EnumsAction.UpdatePrice.Replace("[priceold/]", FNumber.FormatNumber(info.PriceSell)).Replace("[pricenew/]", FNumber.FormatNumber(Price));
                info.PriceSell = Price;
                ProductInfoManager.CreateInstant().Update(info);

                DealsEntity deal = new DealsEntity();
                deal.ProductId = info.Id;
                deal.PoPrice = info.PriceBuy;
                deal.Price = info.PriceSell;
                deal.CreatedBy = Util.CurrentUserName;
                DealsManager.CreateInstant().Insert(deal);

                HistoryProductManager.CreateInstant().AddHistory(action, productId);
            }

            updates = new string[1];
            updates[0] = FNumber.FormatNumber(Price);
        }

        return updates;
    }

    [WebMethod]
    public string[] UpdatePriceBuy(string _ProductId, string _Price)
    {
        string[] updates = null;
        decimal Price = 0;
        if (Util.IsGuid(_ProductId) && FNumber.IsDecimal(_Price))
        {
            Guid productId = new Guid(_ProductId);
            Price = FNumber.ConvertDecimal(_Price);
            string action = "";

            ProductInfoEntity info = ProductInfoManager.CreateInstant().SelectOne(productId);
            if (info != null)
            {
                action = EnumsAction.UpdatePricePo.Replace("[priceold/]", FNumber.FormatNumber(info.PriceSell)).Replace("[pricenew/]", FNumber.FormatNumber(Price));
                info.PriceBuy = Price;
                ProductInfoManager.CreateInstant().Update(info);

                DealsEntity deal = new DealsEntity();
                deal.ProductId = info.Id;
                deal.PoPrice = info.PriceBuy;
                deal.Price = info.PriceSell;
                deal.CreatedBy = Util.CurrentUserName;
                DealsManager.CreateInstant().Insert(deal);

                HistoryProductManager.CreateInstant().AddHistory(action, productId);
            }

            updates = new string[1];
            updates[0] = FNumber.FormatNumber(Price);
        }

        return updates;
    }
}

