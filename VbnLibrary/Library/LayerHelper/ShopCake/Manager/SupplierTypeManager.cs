
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.SupplierTypeManager
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

using Library.Tools;

namespace LayerHelper.ShopCake.BLL
{
	public class SupplierTypeManager : SupplierTypeManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public SupplierTypeManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of SupplierTypeManager
		/// </summary>
		/// <returns>An instant of SupplierTypeManager class</returns>
		public static SupplierTypeManager CreateInstant()
		{
			return new SupplierTypeManager();
		}

        public DataTable GetSupplierTypeNotMain()
        {
            string strSQL = "Select * " +
                            "From SupplierType " +
                            "Where Id<>'MAIN'";
            return SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, CommandType.Text, strSQL, null);
        }
	}
}
