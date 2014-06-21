
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.DealsManager
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
	public class DealsManager : DealsManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DealsManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of DealsManager
		/// </summary>
		/// <returns>An instant of DealsManager class</returns>
		public static DealsManager CreateInstant()
		{
			return new DealsManager();
		}
	}
}
