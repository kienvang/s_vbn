
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.AdvertsPositionManager
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
	public class AdvertsPositionManager : AdvertsPositionManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public AdvertsPositionManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of AdvertsPositionManager
		/// </summary>
		/// <returns>An instant of AdvertsPositionManager class</returns>
		public static AdvertsPositionManager CreateInstant()
		{
			return new AdvertsPositionManager();
		}

        public void UpdateNumberOfGroup(Guid AdvertId)
        {
            string strSQL = "Advert_UpdateNumberOfGroup";
            SqlParameter param = new SqlParameter("@AdvertId", AdvertId);
            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStringShopCake, CommandType.StoredProcedure, strSQL, param);
        }

        public void InsertSetting(Guid AdvertId, string PositionId)
        {
            string strSQL = "Advert_AddSettingBasic";
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@AdvertId", AdvertId);
            param[1] = new SqlParameter("@PositionId", PositionId);
            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStringShopCake, CommandType.StoredProcedure, strSQL, param);
        }

        public void OrderRanking(Guid Id, int NewOrder, int OldOrder, string PositionId)
        {
            string strSQL = "prcUpdateOrder";
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@TableName", "AdvertsPosition");
            param[1] = new SqlParameter("@IdName", "Id");
            param[2] = new SqlParameter("@Id", Id);
            param[3] = new SqlParameter("@FieldOrder", AdvertsPositionFields.OrderIndex.Name);
            param[4] = new SqlParameter("@Whereclause", " and PositionId='" + PositionId + "' ");
            param[5] = new SqlParameter("@OldIndex", OldOrder);
            param[6] = new SqlParameter("@NewIndex", NewOrder);

            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStringShopCake, CommandType.StoredProcedure, strSQL, param);
        }

        public bool IsExistsGroupName(string GroupName, string PositionId)
        {
            EntityCollection<AdvertsPositionEntity> items = new EntityCollection<AdvertsPositionEntity>();

            IPredicateExpression predicate = new PredicateExpression();
            predicate.Add(AdvertsPositionFields.GroupName == GroupName);
            predicate.AddWithAnd(AdvertsPositionFields.PositionId == PositionId);

            RelationPredicateBucket filter = new RelationPredicateBucket();
            filter.PredicateExpression.Add(predicate);

            using (DataAccessAdapterBase adapter = new DataAccessAdapterFactory().CreateAdapter())
            {
                adapter.FetchEntityCollection(items, filter);
            }

            if (items != null && items.Count > 0)
                return true;
            return false;
        }

        public AdvertsPositionEntity GetById(Guid Id)
        {
            EntityCollection<AdvertsPositionEntity> items = SelectByIdLST(Id);
            if (items != null && items.Count > 0)
            {
                return items[0];
            }
            return null;
        }
	}
}
