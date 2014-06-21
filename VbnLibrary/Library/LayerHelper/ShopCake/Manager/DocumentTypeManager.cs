
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.DocumentTypeManager
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
    public class DocumentTypeManager : DocumentTypeManagerBase
    {
        /// <summary>
        /// Purpose: Class constructor.
        /// </summary>
        public DocumentTypeManager()
        {
            // Nothing for now.
        }

        /// <summary>
        /// Method to create an instance of DocumentTypeManager
        /// </summary>
        /// <returns>An instant of DocumentTypeManager class</returns>
        public static DocumentTypeManager CreateInstant()
        {
            return new DocumentTypeManager();
        }
        public DataTable GetAll()
        {
            string strSQL = "Select * from DocumentType where IsDeleted=0";
            return SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, CommandType.Text, strSQL);
        }
        public DocumentTypeEntity GetByCode(string code)
        {
            EntityCollection<DocumentTypeEntity> items = new EntityCollection<DocumentTypeEntity>();

            IPredicateExpression predicate = new PredicateExpression();
            predicate.Add(DocumentTypeFields.TypeCode == code);
            predicate.AddWithAnd(DocumentTypeFields.IsDeleted == false);

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
