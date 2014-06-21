
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.PromotionsManager
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
	public class PromotionsManager : PromotionsManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public PromotionsManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of PromotionsManager
		/// </summary>
		/// <returns>An instant of PromotionsManager class</returns>
		public static PromotionsManager CreateInstant()
		{
			return new PromotionsManager();
		}
	}
}
