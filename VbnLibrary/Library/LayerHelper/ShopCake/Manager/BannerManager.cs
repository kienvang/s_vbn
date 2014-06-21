
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.BannerManager
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
	public class BannerManager : BannerManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public BannerManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of BannerManager
		/// </summary>
		/// <returns>An instant of BannerManager class</returns>
		public static BannerManager CreateInstant()
		{
			return new BannerManager();
		}

        public BannerEntity GetBanner()
        {
            EntityCollection<BannerEntity> items = SelectAllLST();
            if (items != null && items.Count > 0)
                return items[0];
            return null;
        }
	}
}
