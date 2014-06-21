
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.CustomersManager
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
	public class CustomersManager : CustomersManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public CustomersManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of CustomersManager
		/// </summary>
		/// <returns>An instant of CustomersManager class</returns>
		public static CustomersManager CreateInstant()
		{
			return new CustomersManager();
		}

        public CustomersEntity GetByName(string CustomerName)
        {
            EntityCollection<CustomersEntity> cus = new EntityCollection<CustomersEntity>();

            IPredicateExpression predicate = new PredicateExpression();
            predicate.Add(CustomersFields.UserName == CustomerName);
            //predicate.AddWithAnd(CustomersFields.Telphone == "");

            RelationPredicateBucket filter = new RelationPredicateBucket();
            filter.PredicateExpression.Add(predicate);

            SortExpression sort = new SortExpression();
            sort.Add(CustomersFields.UserName | SortOperator.Ascending);

            using (DataAccessAdapterBase adapter = new DataAccessAdapterFactory().CreateAdapter())
            {
                adapter.FetchEntityCollection(cus, filter, 0, sort);
            }

            if (cus != null && cus.Count > 0)
                return cus[0];
            return null;
        }
	}
}
