
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.OrdersJoinTagsManager
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
	public class OrdersJoinTagsManager : OrdersJoinTagsManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public OrdersJoinTagsManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of OrdersJoinTagsManager
		/// </summary>
		/// <returns>An instant of OrdersJoinTagsManager class</returns>
		public static OrdersJoinTagsManager CreateInstant()
		{
			return new OrdersJoinTagsManager();
		}

        public string GetTag(Guid OrderId)
        {
            string tagId = "WAT";
            string strSQL = "Select j.TagId " +
                            "From OrdersJoinTags j " +
                            "Where j.OrderId=@OrderId " +
                            "      and j.CreatedDate = (Select Max(j1.CreatedDate) " +
                            "                           From OrdersJoinTags j1 " +
                            "                           Where j1.OrderId=@OrderId)";

            SqlParameter param = new SqlParameter("@OrderId", OrderId);
            DataTable table = SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, CommandType.Text, strSQL, param);
            if (table != null && table.Rows.Count > 0)
                tagId = table.Rows[0]["TagId"].ToString();
            return tagId;
        }

        public void AddTag(string tagId, Guid OrderId)
        {
            OrdersJoinTagsEntity tags = new OrdersJoinTagsEntity();
            tags.OrderId = OrderId;
            tags.TagId = tagId;
            OrdersJoinTagsManager.CreateInstant().Insert(tags);
        }
	}
}
