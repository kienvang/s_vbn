
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.HistoryOrdersManager
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
	public class HistoryOrdersManager : HistoryOrdersManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public HistoryOrdersManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of HistoryOrdersManager
		/// </summary>
		/// <returns>An instant of HistoryOrdersManager class</returns>
		public static HistoryOrdersManager CreateInstant()
		{
			return new HistoryOrdersManager();
		}

        public void AddHistory(string Action, string OrderCode)
        {
            AddHistory(Action, OrderCode, Util.CurrentUserName);
        }

        public void AddHistory(string Action, string OrderCode, string ActionBy)
        {
            HistoryOrdersEntity history = new HistoryOrdersEntity();
            history.ActionName = Action;
            history.OrderCode = OrderCode;
            history.ActionBy = ActionBy;
            history.ActionDate = DateTime.Now;
            Insert(history);
        }
	}
}
