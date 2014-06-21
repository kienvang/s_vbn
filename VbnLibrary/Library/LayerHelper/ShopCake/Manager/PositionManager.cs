
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.PositionManager
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
	public class PositionManager : PositionManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public PositionManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of PositionManager
		/// </summary>
		/// <returns>An instant of PositionManager class</returns>
		public static PositionManager CreateInstant()
		{
			return new PositionManager();
		}
	}
}
