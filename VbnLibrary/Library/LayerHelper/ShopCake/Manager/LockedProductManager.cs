
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.LockedProductManager
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
	public class LockedProductManager : LockedProductManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LockedProductManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of LockedProductManager
		/// </summary>
		/// <returns>An instant of LockedProductManager class</returns>
		public static LockedProductManager CreateInstant()
		{
			return new LockedProductManager();
		}
	}
}
