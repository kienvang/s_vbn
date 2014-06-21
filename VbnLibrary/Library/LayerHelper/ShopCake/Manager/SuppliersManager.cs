
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.SuppliersManager
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
	public class SuppliersManager : SuppliersManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public SuppliersManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of SuppliersManager
		/// </summary>
		/// <returns>An instant of SuppliersManager class</returns>
		public static SuppliersManager CreateInstant()
		{
			return new SuppliersManager();
		}

        public SuppliersEntity GetMainSupplier()
        {
            EntityCollection<SuppliersEntity> items = SelectBySupplierTypeIdLST("MAIN");
            if (items != null && items.Count > 0)
                return items[0];
            return null;
        }

        public SuppliersEntity GetSupplier(string SupplierCode)
        {
            EntityCollection<SuppliersEntity> items = SelectBySupplierCodeLST(SupplierCode);
            if (items != null && items.Count > 0)
                return items[0];
            return null;
        }

        public string GetSupplierName(Guid Id)
        {
            SuppliersEntity supplier = SelectOne(Id);
            if (supplier != null)
                return supplier.SupplierName;
            return "";
        }
	}
}
