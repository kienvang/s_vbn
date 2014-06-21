
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.DiscountManager
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
	public class DiscountManager : DiscountManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DiscountManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of DiscountManager
		/// </summary>
		/// <returns>An instant of DiscountManager class</returns>
		public static DiscountManager CreateInstant()
		{
			return new DiscountManager();
		}
        
	}
}
