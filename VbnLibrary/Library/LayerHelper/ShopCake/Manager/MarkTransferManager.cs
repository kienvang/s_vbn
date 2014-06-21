
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.MarkTransferManager
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
	public class MarkTransferManager : MarkTransferManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public MarkTransferManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of MarkTransferManager
		/// </summary>
		/// <returns>An instant of MarkTransferManager class</returns>
		public static MarkTransferManager CreateInstant()
		{
			return new MarkTransferManager();
		}

        public MarkTransferEntity GetByCode(string code)
        {
            EntityCollection<MarkTransferEntity> items = SelectByCodeLST(code);
            if (items != null && items.Count > 0)
                return items[0];
            return null;
        }
	}
}
