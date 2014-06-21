
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.StorageManager
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
	public class StorageManager : StorageManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public StorageManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of StorageManager
		/// </summary>
		/// <returns>An instant of StorageManager class</returns>
		public static StorageManager CreateInstant()
		{
			return new StorageManager();
		}
	}
}
