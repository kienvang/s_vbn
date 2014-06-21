
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.SupplierAccountManager
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
	public class SupplierAccountManager : SupplierAccountManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public SupplierAccountManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of SupplierAccountManager
		/// </summary>
		/// <returns>An instant of SupplierAccountManager class</returns>
		public static SupplierAccountManager CreateInstant()
		{
			return new SupplierAccountManager();
		}
	}
}
