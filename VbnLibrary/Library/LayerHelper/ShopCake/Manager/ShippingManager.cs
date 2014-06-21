
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.ShippingManager
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
	public class ShippingManager : ShippingManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public ShippingManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of ShippingManager
		/// </summary>
		/// <returns>An instant of ShippingManager class</returns>
		public static ShippingManager CreateInstant()
		{
			return new ShippingManager();
		}

        public DataTable GetShippingByOrderCode(string OrderCode)
        {
            string strSQL = "Select s.* " +
                            "From Shipping s, Orders o " +
                            "Where s.OrderId=o.Id and o.OrderCode=@OrderCode";
            DataTable table = new DataTable();
            SqlParameter param = new SqlParameter("@OrderCode", OrderCode);
            table = SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, CommandType.Text, strSQL, param);
            return table;
        }

        public ShippingEntity GetShipping(Guid OrderId)
        {
            EntityCollection<ShippingEntity> items = SelectByOrderIdLST(OrderId);
            if (items != null && items.Count > 0)
                return items[0];
            return null;
        }
	}
}
