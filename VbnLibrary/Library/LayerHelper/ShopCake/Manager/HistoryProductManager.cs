
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.HistoryProductManager
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
	public class HistoryProductManager : HistoryProductManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public HistoryProductManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of HistoryProductManager
		/// </summary>
		/// <returns>An instant of HistoryProductManager class</returns>
		public static HistoryProductManager CreateInstant()
		{
			return new HistoryProductManager();
		}

        public void AddHistory(string Action, Guid ProductId)
        {
            AddHistory(Action, ProductId, Util.CurrentUserName);
        }

        public void AddHistory(string Action, Guid ProductId, string ActionBy)
        {
            HistoryProductEntity history = new HistoryProductEntity();
            history.ActionName = Action;
            history.ProductId = ProductId;
            history.ActionBy = ActionBy;
            history.ActionDate = DateTime.Now;
            Insert(history);
        }
	}
}
