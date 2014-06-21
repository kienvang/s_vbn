
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.UnitManager
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
	public class UnitManager : UnitManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public UnitManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of UnitManager
		/// </summary>
		/// <returns>An instant of UnitManager class</returns>
		public static UnitManager CreateInstant()
		{
			return new UnitManager();
		}
	}
}
