
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.ProductSubManager
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
	public class ProductSubManager : ProductSubManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public ProductSubManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of ProductSubManager
		/// </summary>
		/// <returns>An instant of ProductSubManager class</returns>
		public static ProductSubManager CreateInstant()
		{
			return new ProductSubManager();
		}
	}
}
