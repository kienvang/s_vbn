
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.DocumentConfigManager
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

namespace LayerHelper.ShopCake.BLL
{
	public class DocumentConfigManager : DocumentConfigManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DocumentConfigManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of DocumentConfigManager
		/// </summary>
		/// <returns>An instant of DocumentConfigManager class</returns>
		public static DocumentConfigManager CreateInstant()
		{
			return new DocumentConfigManager();
		}

        public DocumentConfigEntity GetByCode(string Code)
        {
            EntityCollection<DocumentConfigEntity> items = new EntityCollection<DocumentConfigEntity>();

            IPredicateExpression predicate = new PredicateExpression();
            predicate.Add(DocumentConfigFields.Code == Code);

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
