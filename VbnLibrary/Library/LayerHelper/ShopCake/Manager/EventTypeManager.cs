
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.EventTypeManager
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
	public class EventTypeManager : EventTypeManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public EventTypeManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of EventTypeManager
		/// </summary>
		/// <returns>An instant of EventTypeManager class</returns>
		public static EventTypeManager CreateInstant()
		{
			return new EventTypeManager();
		}
	}
}
