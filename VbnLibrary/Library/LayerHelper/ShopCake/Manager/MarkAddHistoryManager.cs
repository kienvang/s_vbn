
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.MarkAddHistoryManager
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
	public class MarkAddHistoryManager : MarkAddHistoryManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public MarkAddHistoryManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of MarkAddHistoryManager
		/// </summary>
		/// <returns>An instant of MarkAddHistoryManager class</returns>
		public static MarkAddHistoryManager CreateInstant()
		{
			return new MarkAddHistoryManager();
		}

        public DataTable GetMarkAddHistory(string username)
        {
            string strSQL = "GetAddMarkHistory";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@username", username);
            return SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, CommandType.StoredProcedure, strSQL, param);
        }
	}
}
