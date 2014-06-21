
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.ProductInfoManager
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
	public class ProductInfoManager : ProductInfoManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public ProductInfoManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of ProductInfoManager
		/// </summary>
		/// <returns>An instant of ProductInfoManager class</returns>
		public static ProductInfoManager CreateInstant()
		{
			return new ProductInfoManager();
		}
	}
}
