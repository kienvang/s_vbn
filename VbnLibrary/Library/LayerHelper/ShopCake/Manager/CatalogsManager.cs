
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.CatalogsManager
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

namespace LayerHelper.ShopCake.BLL
{
    public class CatalogsManager : CatalogsManagerBase
    {
        /// <summary>
        /// Purpose: Class constructor.
        /// </summary>
        public CatalogsManager()
        {
            // Nothing for now.
        }

        /// <summary>
        /// Method to create an instance of CatalogsManager
        /// </summary>
        /// <returns>An instant of CatalogsManager class</returns>
        public static CatalogsManager CreateInstant()
        {
            return new CatalogsManager();
        }

        public string GetUniqueTextIdFromUnicodeText(string UnicodeText)
        {
            string strSql = "SELECT TextId FROM Catalogs WHERE TextId = @TextId";
            string textId = WebUtility.GetUniqueTextIdFromUnicodeText(UnicodeText, "@TextId", strSql
                , SqlHelper.ConnectionStringShopCake, CatalogsFields.TextId.MaxLength);
            return textId;
        }

        public EntityCollection<CatalogsEntity> GetAllParent(SortExpression sort)
        {
            EntityCollection<CatalogsEntity> cats = new EntityCollection<CatalogsEntity>();

            SortExpression _sort = new SortExpression();
            if (sort != null)
            {
                _sort = sort;
            }
            else
            {
                _sort.Add(CatalogsFields.CatalogName | SortOperator.Ascending);
            }

            IPredicateExpression predicate = new PredicateExpression();
            predicate.Add(CatalogsFields.ParentId == 0);
            predicate.AddWithAnd(CatalogsFields.IsVisible == true);

            RelationPredicateBucket filter = new RelationPredicateBucket();
            filter.PredicateExpression.Add(predicate);

            using (DataAccessAdapterBase adapter = new DataAccessAdapterFactory().CreateAdapter())
            {
                adapter.FetchEntityCollection(cats, filter, 0, _sort);
            }

            return cats;
        }

        public EntityCollection<CatalogsEntity> GetByParentId(int ParentId)
        {
            return GetByParentId(ParentId, null);
        }

        public EntityCollection<CatalogsEntity> GetByParentId(int ParentId, SortExpression sort)
        {
            EntityCollection<CatalogsEntity> cats = new EntityCollection<CatalogsEntity>();

            SortExpression _sort = new SortExpression();
            if (sort != null)
            {
                _sort = sort;
            }
            else
            {
                _sort.Add(CatalogsFields.CatalogName | SortOperator.Ascending);
            }

            IPredicateExpression predicate = new PredicateExpression();
            predicate.Add(CatalogsFields.ParentId == ParentId);

            RelationPredicateBucket filter = new RelationPredicateBucket();
            filter.PredicateExpression.Add(predicate);

            using (DataAccessAdapterBase adapter = new DataAccessAdapterFactory().CreateAdapter())
            {
                adapter.FetchEntityCollection(cats, filter, 0, _sort);
            }

            return cats;
        }

        public EntityCollection<CatalogsEntity> GetByParentId2(int ParentId)
        {
            EntityCollection<CatalogsEntity> cats = new EntityCollection<CatalogsEntity>();

            SortExpression _sort = new SortExpression();
            _sort.Add(CatalogsFields.CatalogName | SortOperator.Ascending);

            IPredicateExpression predicate = new PredicateExpression();
            predicate.Add(CatalogsFields.ParentId == ParentId);
            predicate.AddWithAnd(CatalogsFields.IsVisible == true);

            RelationPredicateBucket filter = new RelationPredicateBucket();
            filter.PredicateExpression.Add(predicate);

            using (DataAccessAdapterBase adapter = new DataAccessAdapterFactory().CreateAdapter())
            {
                adapter.FetchEntityCollection(cats, filter, 0, _sort);
            }

            return cats;
        }

        public EntityCollection<CatalogsEntity> GetByParentIdNotId(int Id, int ParentId)
        {
            EntityCollection<CatalogsEntity> cats = new EntityCollection<CatalogsEntity>();

            SortExpression _sort = new SortExpression();
            _sort.Add(CatalogsFields.CatalogName | SortOperator.Ascending);

            IPredicateExpression predicate = new PredicateExpression();
            predicate.Add(CatalogsFields.ParentId == ParentId);
            predicate.AddWithAnd(CatalogsFields.Id != Id);

            RelationPredicateBucket filter = new RelationPredicateBucket();
            filter.PredicateExpression.Add(predicate);

            using (DataAccessAdapterBase adapter = new DataAccessAdapterFactory().CreateAdapter())
            {
                adapter.FetchEntityCollection(cats, filter, 0, _sort);
            }

            return cats;
        }

        public bool IsExistCatalogName(string CatalogName)
        {
            EntityCollection<CatalogsEntity> items = SelectByCatalogNameLST(CatalogName);
            if (items != null && items.Count > 0)
                return true;
            return false;
        }

        public bool IsExistCatCode(string CatCode)
        {
            EntityCollection<CatalogsEntity> items = SelectByCatCodeLST(CatCode);
            if (items != null && items.Count > 0)
                return true;
            return false;
        }

        public void UpdateIsLeaf(int CatalogId)
        {
            EntityCollection<CatalogsEntity> items = SelectByParentIdLST(CatalogId);
            CatalogsEntity cat = SelectOne(CatalogId);

            if (items != null && items.Count > 0)
            {
                cat.IsLeaf = false;
            }
            else
            {
                cat.IsLeaf = true;
            }

            CatalogsManager.CreateInstant().Update(cat);
        }

        public DataTable GetListCatalogById(int CatId)
        {
            string strSQL = "getListCatalog";
            DataTable table = new DataTable();

            SqlParameter param = new SqlParameter("@Id", CatId);

            table = SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, CommandType.StoredProcedure, strSQL, param);

            return table;
        }

        public string GetCatalogName(int Id)
        {
            CatalogsEntity cat = SelectOne(Id);
            if (cat != null)
                return cat.CatalogName;
            return "";
        }

        public void UpdateTotalAmount(int CatId)
        {
            string strSQL = "Catalogs_UpdateTotalAmount";
            SqlParameter param = new SqlParameter("@CatId", CatId);
            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStringShopCake, CommandType.StoredProcedure, strSQL, param);
        }

        public void OrderInHome(int Id, int NewOrder, int OldOrder)
        {
            string strSQL = "prcUpdateOrder2";
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@TableName", "Catalogs");
            param[1] = new SqlParameter("@IdName", "Id");
            param[2] = new SqlParameter("@Id", Id);
            param[3] = new SqlParameter("@FieldOrder", CatalogsFields.OrderIndex.Name);
            param[4] = new SqlParameter("@Whereclause", "");
            param[5] = new SqlParameter("@OldIndex", OldOrder);
            param[6] = new SqlParameter("@NewIndex", NewOrder);

            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStringShopCake, CommandType.StoredProcedure, strSQL, param);
        }

        public DataTable GetVisibleInHome()
        {
            string strSQL = "Select * " +
                            "From Catalogs " +
                            "Where IsVisible=1 and IsVisibleHome=1 " +
                            "      and Id In (Select CatId From ProductInCatalog ) " +
                            "Order By OrderIndex";
            DataTable table = new DataTable();
            table = SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, CommandType.Text, strSQL, null);
            return table;
        }
    }
}
