
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.VideoTypeManager
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
	public class VideoTypeManager : VideoTypeManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public VideoTypeManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of VideoTypeManager
		/// </summary>
		/// <returns>An instant of VideoTypeManager class</returns>
		public static VideoTypeManager CreateInstant()
		{
			return new VideoTypeManager();
		}
	}
}
