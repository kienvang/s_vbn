
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.CodeMarkManager
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
	public class CodeMarkManager : CodeMarkManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public CodeMarkManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of CodeMarkManager
		/// </summary>
		/// <returns>An instant of CodeMarkManager class</returns>
		public static CodeMarkManager CreateInstant()
		{
			return new CodeMarkManager();
		}
        public CodeMarkEntity GetByCode(string code)
        {
            EntityCollection<CodeMarkEntity> items = new EntityCollection<CodeMarkEntity>();

            IPredicateExpression predicate = new PredicateExpression();
            predicate.Add(CodeMarkFields.Code == code);
            predicate.AddWithAnd(CodeMarkFields.IsDeleted == false);

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
