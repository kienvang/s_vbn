
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.PaymentMethodManager
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
	public class PaymentMethodManager : PaymentMethodManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public PaymentMethodManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of PaymentMethodManager
		/// </summary>
		/// <returns>An instant of PaymentMethodManager class</returns>
		public static PaymentMethodManager CreateInstant()
		{
			return new PaymentMethodManager();
		}
	}
}
