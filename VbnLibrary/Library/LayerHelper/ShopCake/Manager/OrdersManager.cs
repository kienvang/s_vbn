
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.OrdersManager
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
using System.Globalization;

namespace LayerHelper.ShopCake.BLL
{
	public class OrdersManager : OrdersManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public OrdersManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of OrdersManager
		/// </summary>
		/// <returns>An instant of OrdersManager class</returns>
		public static OrdersManager CreateInstant()
		{
			return new OrdersManager();
		}

        public DataTable Search(string OrderCode, string CustomerName, string OrderDate, string PaidComplete, int top)
        {
            DataTable table = new DataTable();

            string strSQL = "Select {0} o.*,p.PayName " +
                            "From Orders o LEFT JOIN PaymentMethod p ON o.PaymentMethod=p.PayId " +
                            "";

            if (top > 0)
                strSQL = string.Format(strSQL, " top " + top.ToString() + " ");
            else
                strSQL = string.Format(strSQL, "");

            SqlConnection conn = new SqlConnection(SqlHelper.ConnectionStringShopCake);
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Connection = conn;

            string tmpSQL = "";

            if (!string.IsNullOrEmpty(OrderCode))
            {
                tmpSQL += " and OrderCode=@OrderCode ";
                sqlCommand.Parameters.Add("@OrderCode", SqlDbType.VarChar).Value = OrderCode;
            }

            if (!string.IsNullOrEmpty(CustomerName))
            {
                tmpSQL += " and o.CustomerName=@CustomerName ";
                sqlCommand.Parameters.Add("@CustomerName", SqlDbType.VarChar).Value = OrderCode;
            }

            if (!string.IsNullOrEmpty(OrderDate))
            {
                DateTime dt = new DateTime();
                if (DateTime.TryParse(OrderDate, new CultureInfo("vi-VN", true), DateTimeStyles.NoCurrentDateDefault, out dt))
                {
                    sqlCommand.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = dt;
                    tmpSQL += " and DateDiff(Day,CreatedDate,@CreatedDate)=0 ";
                }
            }

            if (!string.IsNullOrEmpty(PaidComplete) && PaidComplete.ToString().ToLower() != "all")
            {
                bool paidComplete = false;
                if (bool.TryParse(PaidComplete, out paidComplete))
                {
                    tmpSQL += " and PaidCompleted=@PaidCompleted ";
                    sqlCommand.Parameters.Add("@PaidCompleted", SqlDbType.Bit).Value = paidComplete;
                }
            }

            if (!string.IsNullOrEmpty(tmpSQL))
            {
                strSQL += " Where ( " + tmpSQL.Substring(4) + " ) ";
            }

            strSQL += " Order By CreatedDate desc ";

            sqlCommand.CommandText = strSQL;

            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(table);
            sqlAdapter.Dispose();
            conn.Close();

            return table;
        }

        public OrdersEntity GetByOrderCode(string OrderCode)
        {
            EntityCollection<OrdersEntity> items = SelectByOrderCodeLST(OrderCode);
            if (items != null && items.Count > 0)
            {
                return items[0];
            }
            return null;
        }
	}
}
