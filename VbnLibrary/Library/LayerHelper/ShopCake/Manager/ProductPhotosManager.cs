
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.ProductPhotosManager
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
	public class ProductPhotosManager : ProductPhotosManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public ProductPhotosManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of ProductPhotosManager
		/// </summary>
		/// <returns>An instant of ProductPhotosManager class</returns>
		public static ProductPhotosManager CreateInstant()
		{
			return new ProductPhotosManager();
		}

        public DataTable GetProductPhotos(Guid ProductId, bool IsVisible)
        {
            string strSQL = "Select * " +
                            "From ProductPhotos " +
                            "Where ProductId=@ProductId and IsVisible=@IsVisible ";
            
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@ProductId", ProductId);
            param[1] = new SqlParameter("@IsVisible", IsVisible);

            return SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, CommandType.Text, strSQL, param);
        }
	}
}
