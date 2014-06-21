
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.PositionTypeManager
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
	public class PositionTypeManager : PositionTypeManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public PositionTypeManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of PositionTypeManager
		/// </summary>
		/// <returns>An instant of PositionTypeManager class</returns>
		public static PositionTypeManager CreateInstant()
		{
			return new PositionTypeManager();
		}

        public PositionTypeEntity GetById(string Id)
        {
            EntityCollection<PositionTypeEntity> items = SelectByIdLST(Id);
            if (items != null && items.Count > 0)
            {
                return items[0];
            }
            return null;
        }
	}
}
