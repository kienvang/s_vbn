
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.DownLoadHistoryManager
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
	public class DownLoadHistoryManager : DownLoadHistoryManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DownLoadHistoryManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of DownLoadHistoryManager
		/// </summary>
		/// <returns>An instant of DownLoadHistoryManager class</returns>
		public static DownLoadHistoryManager CreateInstant()
		{
			return new DownLoadHistoryManager();
		}

        public DataTable GetDownLoadHistory(string username)
        {
            string strSQL = "GetDownLoadHistory";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@username", username);
            return SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, CommandType.StoredProcedure, strSQL, param);
        }
        public DataTable GetDownLoadHistoryTop(string username)
        { 
            string strSQL = "GetDownLoadHistoryTop";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@username", username);
            return SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, CommandType.StoredProcedure, strSQL, param);
        }
	}
}
