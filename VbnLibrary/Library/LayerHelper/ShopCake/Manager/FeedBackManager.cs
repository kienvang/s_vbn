
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.FeedBackManager
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
	public class FeedBackManager : FeedBackManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public FeedBackManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of FeedBackManager
		/// </summary>
		/// <returns>An instant of FeedBackManager class</returns>
		public static FeedBackManager CreateInstant()
		{
			return new FeedBackManager();
		}
	}
}
