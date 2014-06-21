
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.PaymentsManager
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

namespace LayerHelper.ShopCake.BLL
{
	public class PaymentsManager : PaymentsManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public PaymentsManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of PaymentsManager
		/// </summary>
		/// <returns>An instant of PaymentsManager class</returns>
		public static PaymentsManager CreateInstant()
		{
			return new PaymentsManager();
		}

        public void AddPayment(Guid OrderId, decimal Amount)
        {
            AddPayment(OrderId, Amount, "");
        }

        public void AddPayment(Guid OrderId, decimal Amount, string PayMethod)
        {
            PaymentsEntity pay = new PaymentsEntity();

            pay.Id = Guid.NewGuid();
            pay.OrderId = OrderId;
            pay.Amount = Amount;
            pay.PaymentMethod = PayMethod;

            PaymentsManager.CreateInstant().Insert(pay);
        }
	}
}
