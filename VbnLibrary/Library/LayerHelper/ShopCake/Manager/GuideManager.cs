
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.GuideManager
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
	public class GuideManager : GuideManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public GuideManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of GuideManager
		/// </summary>
		/// <returns>An instant of GuideManager class</returns>
		public static GuideManager CreateInstant()
		{
			return new GuideManager();
		}
	}
}
