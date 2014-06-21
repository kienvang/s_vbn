
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.DocumentManager
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
	public class DocumentManager : DocumentManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DocumentManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of DocumentManager
		/// </summary>
		/// <returns>An instant of DocumentManager class</returns>
		public static DocumentManager CreateInstant()
		{
			return new DocumentManager();
		}

        public DataTable GetAll()
        {
            string strSQL = "select * from Document as doc inner join DocumentGroup as gr on doc.GroupId=gr.IntId where doc.IsDeleted=0 and gr.IsDeleted=0 order by doc.GroupId";
            return SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, CommandType.Text, strSQL);
        }

        public DataTable GetDocument()
        {
            string strSQL = "select top(10)* from Document where IsDeleted=0 and IsVisible=1";
            return SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, CommandType.Text, strSQL);

        }

        public DataTable GetTopDown()
        {
            string strSQL = "select top(12)* from Document where IsDeleted=0 and IsVisible=1 order by countdown desc";
            return SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, CommandType.Text, strSQL);

        }

        public DataTable Getnew()
        {
            string strSQL = "select top(12)* from Document where IsDeleted=0 and IsVisible=1 order by countdown";
            return SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, CommandType.Text, strSQL);

        }

        public DataTable GetByGroup(int GroupId)
        {
            string strSQL = "select top(12)* from Document where IsDeleted=0 and IsVisible=1 and GroupId=@GroupId order by countdown";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@GroupId", GroupId);
            return SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, CommandType.Text, strSQL,param);

        }
        public string GetUniqueTextIdFromUnicodeText(string UnicodeText)
        {
            string strSql = "SELECT TextId FROM Document WHERE TextId = @TextId";
            string textId = WebUtility.GetUniqueTextIdFromUnicodeText(UnicodeText, "@TextId", strSql
                , SqlHelper.ConnectionStringShopCake, DocumentFields.TextId.MaxLength);
            return textId;
        }
       
        public DocumentEntity GetByID(Guid ID)
        {
            EntityCollection<DocumentEntity> items = new EntityCollection<DocumentEntity>();

            IPredicateExpression predicate = new PredicateExpression();
            predicate.Add(DocumentFields.Id == ID);
            predicate.AddWithAnd(DocumentFields.IsDeleted == false);

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
        public DocumentEntity GetByIntId(int id)
        {
            EntityCollection<DocumentEntity> items = new EntityCollection<DocumentEntity>();

            IPredicateExpression predicate = new PredicateExpression();
            predicate.Add(DocumentFields.IntId == id);
            predicate.AddWithAnd(DocumentFields.IsDeleted == false);

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
        public DocumentEntity GetByName(string name)
        {
            EntityCollection<DocumentEntity> items = new EntityCollection<DocumentEntity>();

            IPredicateExpression predicate = new PredicateExpression();
            predicate.Add(DocumentFields.DocumentName == name);
            predicate.AddWithAnd(DocumentFields.IsDeleted == false);

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
