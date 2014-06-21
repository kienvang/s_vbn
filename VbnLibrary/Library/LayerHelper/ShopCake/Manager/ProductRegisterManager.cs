
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.ProductRegisterManager
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
	public class ProductRegisterManager : ProductRegisterManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public ProductRegisterManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of ProductRegisterManager
		/// </summary>
		/// <returns>An instant of ProductRegisterManager class</returns>
		public static ProductRegisterManager CreateInstant()
		{
			return new ProductRegisterManager();
		}
	}
}
