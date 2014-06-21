
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.ShippingDetailManager
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
	public class ShippingDetailManager : ShippingDetailManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public ShippingDetailManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of ShippingDetailManager
		/// </summary>
		/// <returns>An instant of ShippingDetailManager class</returns>
		public static ShippingDetailManager CreateInstant()
		{
			return new ShippingDetailManager();
		}

        public DataTable GetShippingItem(Guid ShippingId)
        {
            string strSQL = "Select sd.ShippingId, p.ProductName, od.ProductName as SubName, od.PriceAfterTax, sd.Amount,od.PriceAfterTax*sd.Amount as TotalPriceAfterTax,od.ProductCode " +
                            "From ShippingDetail sd, OrderDetail od, Products p " +
                            "Where sd.OrderDetailId=od.Id and p.Id=od.ProductId " +
                            "      and sd.ShippingId=@ShippingId ";
            SqlParameter param = new SqlParameter("@ShippingId", ShippingId);
            DataTable table = new DataTable();
            table = SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, CommandType.Text, strSQL, param);
            return table;
        }

        public int GetTotalShipByShipId(Guid ShippingId)
        {
            int total = 1;
            string strSQL = "Select Count (*) " +
                            "From ShippingDetail sd " +
                            "Where ShippingId=@ShippingId";
            SqlParameter param = new SqlParameter("@ShippingId", ShippingId);
            DataTable table = new DataTable();
            table = SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, CommandType.Text, strSQL, param);

            if (table != null && table.Rows.Count > 0)
            {
                total = Convert.ToInt32(table.Rows[0][0]);
            }

            return total;
        }
	}
}
