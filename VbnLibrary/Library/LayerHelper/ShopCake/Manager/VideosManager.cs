
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.VideosManager
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
	public class VideosManager : VideosManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public VideosManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of VideosManager
		/// </summary>
		/// <returns>An instant of VideosManager class</returns>
		public static VideosManager CreateInstant()
		{
			return new VideosManager();
		}

        public string GetUniqueTextIdFromUnicodeText(string UnicodeText)
        {
            string strSql = "SELECT TextId FROM Videos WHERE TextId = @TextId";
            string textId = WebUtility.GetUniqueTextIdFromUnicodeText(UnicodeText, "@TextId", strSql
                , SqlHelper.ConnectionStringShopCake, VideosFields.TextId.MaxLength);
            return textId;
        }

        public DataTable GetAllVideo()
        {
            string strSQL = "Select v.*,vt.TypeName,c.CatName " +
                            "From (Videos v INNER JOIN VideoType vt ON v.VideoTypeId=vt.Id) " +
                            "      LEFT JOIN VideoCatalog c ON c.Id=v.CatalogId " +
                            "Order By v.CreatedDate desc ";
            return SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, CommandType.Text, strSQL, null);
        }

        public void UpdateVisibleVideo()
        {
            string strSQL = "Update Videos " +
                            "Set IsVisibleHome=0";
            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStringShopCake, CommandType.Text, strSQL, null);
        }

        public void UpdateSetVisibleVideo()
        {
            string strSQL = "Update Videos " +
                            "Set IsVisibleHome=1 " +
                            "Where Id=(Select top 1 Id From Videos Order By CreatedDate desc)";
            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStringShopCake, CommandType.Text, strSQL, null);
        }

        public DataTable GetVideoTop(int Top)
        {
            string strSQL = "Select top {0} v.*,vt.TypeName, c.TextId as CatTextId " +
                            "From Videos v, VideoType vt, VideoCatalog c " +
                            "Where v.VideoTypeId=vt.Id and v.CatalogId=c.Id " +
                            "Order By v.CreatedDate desc ";
            strSQL = string.Format(strSQL, Top.ToString());
            return SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, CommandType.Text, strSQL, null);
        }

        public VideosEntity GetVideoHome()
        {
            EntityCollection<VideosEntity> videos = new EntityCollection<VideosEntity>();

            IPredicateExpression predicate = new PredicateExpression();
            predicate.Add(VideosFields.IsVisibleHome == true);

            RelationPredicateBucket filter = new RelationPredicateBucket();
            filter.PredicateExpression.Add(predicate);

            using (DataAccessAdapterBase adapter = new DataAccessAdapterFactory().CreateAdapter())
            {
                adapter.FetchEntityCollection(videos, filter);
            }

            if (videos != null && videos.Count > 0)
            {
                return videos[0];
            }

            return null;
        }

        public VideosEntity GetVideoByIntId(int IntId)
        {
            EntityCollection<VideosEntity> videos = SelectByIntIdLST(IntId);
            if (videos != null && videos.Count > 0)
                return videos[0];
            return null;
        }

        public DataTable GetVideoLasted()
        {
            string strSQL = "Select top (5) v.*, c.TextId as CatTextId " +
                            "From Videos v, VideoCatalog c " +
                            "Where v.CatalogId=c.Id " +
                            "Order By v.CreatedDate Desc";
            return SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, CommandType.Text, strSQL, null);
        }

        public DataTable GetVideoBestView()
        {
            string strSQL = "Select top (5) v.*, c.TextId as CatTextId " +
                            "From Videos v, VideoCatalog c " +
                            "Where v.CatalogId=c.Id " +
                            "Order By v.Views desc, v.CreatedDate desc";
            return SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, CommandType.Text, strSQL, null);
        }

        public DataTable GetVideoListByCatTextId(string CatTextId)
        {
            string strSQL = "Select v.*, c.TextId as CatTextId " +
                            "From Videos v, VideoCatalog c " +
                            "Where v.CatalogId=c.Id and c.TextId=@TextId " +
                            "Order By v.CreatedDate desc";
            SqlParameter param = new SqlParameter("@TextId", CatTextId);
            return SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, CommandType.Text, strSQL, param);
        }

        public VideosEntity GetVideoByCatTextId(string TextId)
        {
            VideoCatalogEntity c = VideoCatalogManager.CreateInstant().GetByTextId(TextId);
            if (c != null)
            {
                EntityCollection<VideosEntity> items = new EntityCollection<VideosEntity>();
                IPredicateExpression pre = new PredicateExpression();
                pre.Add(VideosFields.CatalogId == c.Id);
                SortExpression sort = new SortExpression();
                sort.Add(VideosFields.Views | SortOperator.Descending);

                RelationPredicateBucket filter = new RelationPredicateBucket();
                filter.PredicateExpression.Add(pre);

                using (DataAccessAdapterBase adapter = new DataAccessAdapterFactory().CreateAdapter())
                {
                    adapter.FetchEntityCollection(items, filter, 1, sort);
                }

                if (items != null && items.Count > 0)
                    return items[0];
            }
            return null;
        }
	}
}
