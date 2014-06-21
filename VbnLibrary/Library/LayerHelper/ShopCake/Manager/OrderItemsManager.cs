
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.OrderItemsManager
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
	public class OrderItemsManager : OrderItemsManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public OrderItemsManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of OrderItemsManager
		/// </summary>
		/// <returns>An instant of OrderItemsManager class</returns>
		public static OrderItemsManager CreateInstant()
		{
			return new OrderItemsManager();
		}

        public DataTable GetItemsByOrderCode(string OrderCode)
        {
            string strSQL = "Select i.* " +
                            "From Orders o, OrderItems i " +
                            "Where o.Id = i.OrderId and o.OrderCode=@OrderCode";
            SqlParameter param = new SqlParameter("@OrderCode", OrderCode);
            DataTable table = new DataTable();
            table = SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, CommandType.Text, strSQL, param);
            return table;
        }

        public DataTable GetItemsDetailByOrderId(Guid OrderId)
        {
            string strSQL = @"Select p.ProductName,od.ProductName as SubName,od.ProductCode,
                                     od.PriceAfterTax,
                                     od.Amount,
                                     od.PriceAfterTax*od.Amount Total,
                                     od.Note,
                                     p.Thumbnail
                              From OrderItems oi, OrderDetail od,Products p 
                              Where oi.Id=od.OrderItemId and od.ProductId=p.Id
                                    and oi.OrderId=@OrderId 
                              Order By p.ProductName";
            SqlParameter param = new SqlParameter("@OrderId", OrderId);
            return SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, CommandType.Text, strSQL, param);
        }
	}
}
