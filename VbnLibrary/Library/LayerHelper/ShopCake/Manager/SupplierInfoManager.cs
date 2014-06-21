
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.SupplierInfoManager
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
	public class SupplierInfoManager : SupplierInfoManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public SupplierInfoManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of SupplierInfoManager
		/// </summary>
		/// <returns>An instant of SupplierInfoManager class</returns>
		public static SupplierInfoManager CreateInstant()
		{
			return new SupplierInfoManager();
		}
	}
}
