
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.VideoCatalogManager
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
	public class VideoCatalogManager : VideoCatalogManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public VideoCatalogManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of VideoCatalogManager
		/// </summary>
		/// <returns>An instant of VideoCatalogManager class</returns>
		public static VideoCatalogManager CreateInstant()
		{
			return new VideoCatalogManager();
		}

        public VideoCatalogEntity GetById(int Id)
        {
            EntityCollection<VideoCatalogEntity> items = SelectByIdLST(Id);
            if (items != null && items.Count > 0)
                return items[0];
            return null;
        }

        public VideoCatalogEntity GetByTextId(string TextId)
        {
            EntityCollection<VideoCatalogEntity> items = SelectByTextIdLST(TextId);
            if (items != null && items.Count > 0)
                return items[0];
            return null;
        }

        public void DeleteCatById(int Id)
        {
            string strSQL = "Update Videos " +
                            "Set CatalogId=0 " +
                            "Where CatalogId=" + Id.ToString();
            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStringShopCake, CommandType.Text, strSQL, null);

            strSQL = "Delete From VideoCatalog Where Id=" + Id.ToString();
            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStringShopCake, CommandType.Text, strSQL, null);
        }

        public string GetUniqueTextIdFromUnicodeText(string UnicodeText)
        {
            string strSql = "SELECT TextId FROM VideoCatalog WHERE TextId = @TextId";
            string textId = WebUtility.GetUniqueTextIdFromUnicodeText(UnicodeText, "@TextId", strSql
                , SqlHelper.ConnectionStringShopCake, VideoCatalogFields.TextId.MaxLength);
            return textId;
        }
	}
}
