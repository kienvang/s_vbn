
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.ReviewsManager
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
	public class ReviewsManager : ReviewsManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public ReviewsManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of ReviewsManager
		/// </summary>
		/// <returns>An instant of ReviewsManager class</returns>
		public static ReviewsManager CreateInstant()
		{
			return new ReviewsManager();
		}
	}
}
