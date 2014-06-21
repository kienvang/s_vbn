
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.AdvertsGroupManager
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
	public class AdvertsGroupManager : AdvertsGroupManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public AdvertsGroupManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of AdvertsGroupManager
		/// </summary>
		/// <returns>An instant of AdvertsGroupManager class</returns>
		public static AdvertsGroupManager CreateInstant()
		{
			return new AdvertsGroupManager();
		}
	}
}
