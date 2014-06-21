
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.ProductsManager
'===============================================================================
*/

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using LayerHelper.ShopCake.BLL;
using LayerHelper.ShopCake.DAL;
using LayerHelper.ShopCake.DAL.EntityClasses;
using LayerHelper.ShopCake.DAL.FactoryClasses;
using LayerHelper.ShopCake.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

using Library.Tools;
using Modules;
using System.Collections.Generic;
using System.Collections;

namespace LayerHelper.ShopCake.BLL
{
    public class ProductsManager : ProductsManagerBase
    {
        /// <summary>
        /// Purpose: Class constructor.
        /// </summary>
        public ProductsManager()
        {
            // Nothing for now.
        }

        /// <summary>
        /// Method to create an instance of ProductsManager
        /// </summary>
        /// <returns>An instant of ProductsManager class</returns>
        public static ProductsManager CreateInstant()
        {
            return new ProductsManager();
        }

        public string GetUniqueTextIdFromUnicodeText(string UnicodeText)
        {
            string strSql = "SELECT TextId FROM Products WHERE TextId = @TextId";
            string textId = WebUtility.GetUniqueTextIdFromUnicodeText(UnicodeText, "@TextId", strSql
                , SqlHelper.ConnectionStringShopCake, ProductsFields.TextId.MaxLength);
            return textId;
        }

        public bool IsExist(string ProductName)
        {
            EntityCollection<ProductsEntity> items = new EntityCollection<ProductsEntity>();

            IPredicateExpression predicate = new PredicateExpression();
            predicate.Add(ProductsFields.ProductName == ProductName);
            predicate.AddWithAnd(ProductsFields.IsDelete == false);

            RelationPredicateBucket filter = new RelationPredicateBucket();
            filter.PredicateExpression.Add(predicate);

            using (DataAccessAdapterBase adapter = new DataAccessAdapterFactory().CreateAdapter())
            {
                adapter.FetchEntityCollection(items, filter);
            }

            if (items != null && items.Count > 0)
                return true;
            return false;
        }

        public DataTable GetAll()
        {
            string strSQL = "Product_GetAll";
            DataTable table = new DataTable();
            table = SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, CommandType.StoredProcedure, strSQL, null);
            return table;
        }

        public string GetProductNameById(Guid Id)
        {
            ProductsEntity product = SelectOne(Id);
            if (product != null)
                return product.ProductName;
            return "";
        }

        public ProductsEntity SelectOne(Guid Id, bool IsFetch)
        {
            ProductsEntity item = null;

            using (DataAccessAdapterBase adapter = new DataAccessAdapterFactory().CreateAdapter())
            {
                ProductsEntity _item = new ProductsEntity(Id);
                IPrefetchPath2 prefetch = new PrefetchPath2((int)EntityType.ProductsEntity);
                if (IsFetch)
                {
                    prefetch.Add(ProductsEntity.PrefetchPathProductInfo);
                    prefetch.Add(ProductsEntity.PrefetchPathUnit);
                }
                if (adapter.FetchEntity(_item, prefetch))
                {
                    item = _item;
                }
            }

            return item;
        }

        public DataTable GetQuickUpdatePrice()
        {
            DataTable table = new DataTable();

            string strSQL = "Select p.*,c.CatalogName,i.Currency,i.PriceBuy " +
                            "From Products p, Catalogs c,ProductInfo i " +
                            "Where p.CatalogId=c.Id and i.Id=p.Id and p.IsDelete=0 " +
                            "Order By ProductName";
            table = SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, CommandType.Text, strSQL, null);
            return table;
        }

        public DataTable GetProductInCatalog(int CatId)
        {
            return GetProductInCatalog(CatId, Config.GetTopHome());
        }

        public DataTable GetProductInCatalog(int CatId, int top)
        {
            string strSQL = "Select {0}  p.*,c.Id as CatId,c.TextId as CatTextId " +
                            "From Products p, ProductInCatalog pc, Catalogs c " +
                            "Where p.Id=pc.ProductId and p.CatalogId=c.Id " +
                            "      and p.IsDelete=0 " +
                            "      and pc.CatId=" + CatId.ToString() + " " +
                            "Order By p.CreatedDate desc";
            if (top > 0)
                strSQL = string.Format(strSQL, " top " + top.ToString());
            else
                strSQL = string.Format(strSQL, "");
            DataTable table = new DataTable();

            table = SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, CommandType.Text, strSQL, null);

            return table;
        }

        public ProductsEntity GetProductByIntIdTextId(int IntId, string TextId)
        {
            EntityCollection<ProductsEntity> items = new EntityCollection<ProductsEntity>();

            IPredicateExpression predicate = new PredicateExpression();
            predicate.Add(ProductsFields.IntId == IntId);
            predicate.AddWithAnd(ProductsFields.TextId == TextId);
            predicate.AddWithAnd(ProductsFields.IsDelete == false);

            RelationPredicateBucket filter = new RelationPredicateBucket();
            filter.PredicateExpression.Add(predicate);

            using (DataAccessAdapterBase adapter = new DataAccessAdapterFactory().CreateAdapter())
            {
                adapter.FetchEntityCollection(items, filter);
            }

            if (items != null && items.Count > 0)
                return items[0];
            return null;
        }

        public DataTable GetProductTopInParent(int ParentId)
        {
            return GetProductTopInParent(ParentId, Config.GetTopHome());
        }

        public DataTable GetProductTopInParent(int ParentId, int Top)
        {
            string strSQL = "Select {0} p.*,c.Id CatId,c.TextId CatTextId " +
                            "From Products p, Catalogs c " +
                            "Where p.CatalogId=c.Id and c.ParentId=@ParentId " +
                            "      and p.IsDelete=0 " +
                            "Order By p.CreatedDate desc ";

            if (Top > 0)
                strSQL = string.Format(strSQL, " top " + Top.ToString());
            else
                strSQL = string.Format(strSQL, "");

            SqlParameter param = new SqlParameter("@ParentId", ParentId);
            return SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, CommandType.Text, strSQL, param);
        }

        public DataTable GetQuickSearch(string ProductName)
        {
            string strSQL = "Select p.*,c.Id CatId,c.TextId CatTextId " +
                            "From Products p, Catalogs c " +
                            "Where p.CatalogId=c.Id and p.ProductName like + '%' + @ProductName + '%' " +
                            "      and p.IsDelete=0 " +
                            "Order By p.CreatedDate desc ";

            SqlParameter param = new SqlParameter("@ProductName", ProductName);
            return SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, CommandType.Text, strSQL, param);
        }

        public DataTable Search(string ProductName, string Price)
        {
            return Search(ProductName, Price, "");
        }

        public DataTable Search(string ProductName, string Price, string catalog)
        {
            DataTable table = new DataTable();
            string strSQL = "Select p.*,c.CatalogName, c.Id as CatId, c.TextId as CatTextId,i.Currency,i.PriceBuy " +
                            "From Products p, Catalogs c,ProductInfo i " +
                            "Where p.CatalogId=c.Id and i.Id=p.Id and p.IsDelete=0 ";

            Hashtable para = new Hashtable();
            string tmp = "";

            if (!string.IsNullOrEmpty(ProductName))
            {
                tmp += " and p.ProductName like + '%' + @ProductName + '%' ";
                para.Add("ProductName", ProductName.Trim());
            }

            if (!string.IsNullOrEmpty(catalog))
            {
                tmp += " and c.CatalogName like + '%' + @CatalogName + '%' ";
                para.Add("CatalogName", catalog.Trim());
            }

            if (!string.IsNullOrEmpty(Price) && Price != "0")
            {
                switch (Price)
                {
                    case "1":
                        tmp += " and p.Price<= 100000 ";
                        break;
                    case "1-1.5":
                        tmp += " and p.Price>= 100000 and p.Price<= 150000 ";
                        break;
                    case "1.5-2":
                        tmp += " and p.Price>= 150000 and p.Price<= 200000 ";
                        break;
                    case "2-2.5":
                        tmp += " and p.Price>= 200000 and p.Price<= 250000 ";
                        break;
                    case "2.5-3":
                        tmp += " and p.Price>= 250000 and p.Price<= 300000 ";
                        break;
                    case "3-4":
                        tmp += " and p.Price>= 300000 and p.Price<= 400000 ";
                        break;
                    case "4-10":
                        tmp += " and p.Price>= 400000 and p.Price<= 1000000 ";
                        break;
                    case "10-30":
                        tmp += " and p.Price>= 1000000 and p.Price<=3000000 ";
                        break;
                    case "30-50":
                        tmp += " and p.Price>= 3000000 and p.Price<=5000000 ";
                        break;
                    case "50-100":
                        tmp += " and p.Price>= 5000000 and p.Price<=10000000 ";
                        break;
                    case "100":
                        tmp += " and p.Price>= 10000000 ";
                        break;
                }
            }

            strSQL += tmp + " Order By p.CreatedDate";

            table = SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, para, CommandType.Text, strSQL);
            return table;
        }

        

        public ProductsEntity GetById(Guid Id)
        {
            IPredicateExpression predicate = new PredicateExpression();
            predicate.Add(ProductsFields.Id == Id);
            RelationPredicateBucket filter = new RelationPredicateBucket();
            filter.PredicateExpression.Add(predicate); ;

            EntityCollection<ProductsEntity> items = new EntityCollection<ProductsEntity>();

            using (DataAccessAdapterBase adapter = new DataAccessAdapterFactory().CreateAdapter())
            {
                adapter.FetchEntityCollection(items, filter);
            }

            if (items != null && items.Count > 0)
                return items[0];
            return null;
        }
    }
}
