
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.OrderDetailManager
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
	public class OrderDetailManager : OrderDetailManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public OrderDetailManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of OrderDetailManager
		/// </summary>
		/// <returns>An instant of OrderDetailManager class</returns>
		public static OrderDetailManager CreateInstant()
		{
			return new OrderDetailManager();
		}

        public DataTable GetlByOrderItemId(Guid OrderItemId)
        {
            string strSQL = "Select *, PriceAfterTax*Amount as TotalPriceAfterTax, PoPrice * Amount as TotalPoPrice " +
                            "From OrderDetail " +
                            "Where OrderItemId=@OrderItemId";

            SqlParameter param = new SqlParameter("@OrderItemId", OrderItemId);

            DataTable table = new DataTable();

            table = SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, CommandType.Text, strSQL, param);

            return table;
        }
	}
}
