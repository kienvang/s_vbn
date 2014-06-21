
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.SupplierRegisterManager
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
	public class SupplierRegisterManager : SupplierRegisterManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public SupplierRegisterManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of SupplierRegisterManager
		/// </summary>
		/// <returns>An instant of SupplierRegisterManager class</returns>
		public static SupplierRegisterManager CreateInstant()
		{
			return new SupplierRegisterManager();
		}

        public DataTable GetRegister()
        {
            string strSQL = "Select sr.*, st.TypeName " +
                            "From SupplierRegister sr, SupplierType st " +
                            "Where sr.SupplierTypeId=st.Id " +
                            "Order By sr.CreatedDate";
            return SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, CommandType.Text, strSQL, null);
        }
	}
}
