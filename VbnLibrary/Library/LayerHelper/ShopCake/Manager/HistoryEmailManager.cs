
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.HistoryEmailManager
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
	public class HistoryEmailManager : HistoryEmailManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public HistoryEmailManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of HistoryEmailManager
		/// </summary>
		/// <returns>An instant of HistoryEmailManager class</returns>
		public static HistoryEmailManager CreateInstant()
		{
			return new HistoryEmailManager();
		}
	}
}
