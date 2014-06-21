
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.DocumentGroupManager
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
	public class DocumentGroupManager : DocumentGroupManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DocumentGroupManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of DocumentGroupManager
		/// </summary>
		/// <returns>An instant of DocumentGroupManager class</returns>
		public static DocumentGroupManager CreateInstant()
		{
			return new DocumentGroupManager();
		}

        public string GetUniqueTextIdFromUnicodeText(string UnicodeText)
        {
            string strSql = "SELECT TextId FROM DocumentGroup WHERE TextId = @TextId";
            string textId = WebUtility.GetUniqueTextIdFromUnicodeText(UnicodeText, "@TextId", strSql
                , SqlHelper.ConnectionStringShopCake, DocumentGroupFields.TextId.MaxLength);
            return textId;
        }

        public DocumentGroupEntity GetByID(Guid ID)
        {
            EntityCollection<DocumentGroupEntity> items = new EntityCollection<DocumentGroupEntity>();

            IPredicateExpression predicate = new PredicateExpression();
            predicate.Add(DocumentGroupFields.Id == ID);
            predicate.AddWithAnd(DocumentGroupFields.IsDeleted == false);

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
        public DataTable selectbyIntId(int Id)
        {
            string strSQL = "select * from DocumentGroup where IntId=@Id and IsDeleted=0";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Id", Id);
            return SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, CommandType.Text, strSQL, param);
        }
        public DocumentGroupEntity GetByIntID(int ID)
        {
            EntityCollection<DocumentGroupEntity> items = new EntityCollection<DocumentGroupEntity>();

            IPredicateExpression predicate = new PredicateExpression();
            predicate.Add(DocumentGroupFields.IntId == ID);
            predicate.AddWithAnd(DocumentGroupFields.IsDeleted == false);

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

        public DocumentGroupEntity GetByGroupName(string groupname)
        {
            EntityCollection<DocumentGroupEntity> items = new EntityCollection<DocumentGroupEntity>();

            IPredicateExpression predicate = new PredicateExpression();
            predicate.Add(DocumentGroupFields.GroupName == groupname);
            predicate.AddWithAnd(DocumentGroupFields.IsDeleted == false);

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
	}
}
