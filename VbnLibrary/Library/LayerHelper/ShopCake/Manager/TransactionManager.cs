
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.TransactionManager
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
	public class TransactionManager : TransactionManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public TransactionManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of TransactionManager
		/// </summary>
		/// <returns>An instant of TransactionManager class</returns>
		public static TransactionManager CreateInstant()
		{
			return new TransactionManager();
		}
	}
}
