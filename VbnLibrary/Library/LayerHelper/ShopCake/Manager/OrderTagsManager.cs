
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.OrderTagsManager
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
using Library.Tools;

namespace LayerHelper.ShopCake.BLL
{
	public class OrderTagsManager : OrderTagsManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public OrderTagsManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of OrderTagsManager
		/// </summary>
		/// <returns>An instant of OrderTagsManager class</returns>
		public static OrderTagsManager CreateInstant()
		{
			return new OrderTagsManager();
		}
	}
}
