
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.AdvertsManager
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
    public class AdvertsManager : AdvertsManagerBase
    {
        /// <summary>
        /// Purpose: Class constructor.
        /// </summary>
        public AdvertsManager()
        {
            // Nothing for now.
        }

        /// <summary>
        /// Method to create an instance of AdvertsManager
        /// </summary>
        /// <returns>An instant of AdvertsManager class</returns>
        public static AdvertsManager CreateInstant()
        {
            return new AdvertsManager();
        }

        public void DeleteAdvertById(Guid AdvertId)
        {
            string strSQL = "Advert_DeleteByAdvertId";
            SqlParameter param = new SqlParameter("@AdvertId", AdvertId);
            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStringShopCake, CommandType.StoredProcedure, strSQL, param);
        }

        public DataTable GetAdvertSetting(string PositionId)
        {
            string strSQL = "Advert_ShowByPosition";
            SqlParameter param = new SqlParameter("@PositionId", PositionId);
            return SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, CommandType.StoredProcedure, strSQL, param);
        }

        public DataTable GetAdvertSettingGroup(Guid AdvertPositionId)
        {
            string strSQL = "Advert_ShowByGroup";
            SqlParameter param = new SqlParameter("@AdvertPositionId", AdvertPositionId);
            return SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, CommandType.StoredProcedure, strSQL, param);
        }

        public void UpdateGroup(Guid AdvertId, Guid AdvertPositionId)
        {
            string strSQL = "Advert_UpdateGroup";
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@AdvertId", AdvertId);
            param[1] = new SqlParameter("@AdvertPositionId", AdvertPositionId);
            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStringShopCake, CommandType.StoredProcedure, strSQL, param);
        }

        public DataTable GetAdvertByPositionId(string PositionId, string PositionType)
        {
            string strSQL = "Select ad.* " +
                            "From Adverts ad, AdvertsGroup adg, AdvertsPosition adp, Position p " +
                            "Where ad.Id=adg.AdvertId and adg.AdvertPositionId=adp.Id and adp.PositionId=p.Id " +
                            "      and adp.IsVisible=1 and adp.NumberOfGroup>0 " +
                            "      and DateDiff(Day,BeginDate,getDate())>=0 and DateDiff(Day,getdate(),EndDate)>=0 " +
                            "      and adp.PositionTypeId='" + PositionType + "' " +
                            "      {0} " +
                            "Order By p.OrderIndex, adp.OrderIndex, ad.AdvertName ";

            string[] p = PositionId.Split('|');
            string subSQL = "";
            for (int i = 0; i < p.Length; i++)
            {
                subSQL += " or adp.PositionId='" + p[i] + "' ";  
            }
            if (!string.IsNullOrEmpty(subSQL))
                subSQL = " and (" + subSQL.Substring(3) + ") ";

            strSQL = string.Format(strSQL, subSQL);

            return SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, CommandType.Text, strSQL, null);
        }

        public DataTable GetAdvertGroupByPositionId(string PositionId, string PositionType)
        {
            string strSQL = "Select adp.* " +
                            "From AdvertsPosition adp, Position p " +
                            "Where adp.PositionId=p.Id " +
                            "      and adp.IsVisible=1 and adp.NumberOfGroup>0 " +
                            "      and adp.PositionTypeId='" + PositionType + "' " +
                            "      {0} " +
                            "Order By p.OrderIndex, adp.OrderIndex ";

            string[] p = PositionId.Split('|');
            string subSQL = "";
            for (int i = 0; i < p.Length; i++)
            {
                subSQL += " or adp.PositionId='" + p[i] + "' ";
            }
            if (!string.IsNullOrEmpty(subSQL))
                subSQL = " and (" + subSQL.Substring(3) + ") ";

            strSQL = string.Format(strSQL, subSQL);

            return SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, CommandType.Text, strSQL, null);
        }

        public DataTable GetAdvert(Guid AdvertPositionId)
        {
            string strSQL = "Select ad.* " +
                            "From Adverts ad, AdvertsGroup adg, AdvertsPosition adp " +
                            "Where ad.Id=adg.AdvertId and adg.AdvertPositionId=adp.Id " +
                            "      and adp.IsVisible=1 and ad.IsVisible=1 " +
                            "      and DateDiff(Day,BeginDate,getDate())>=0 and DateDiff(Day,getdate(),EndDate)>=0 "+
                            "      and adp.Id=@AdvertPositionId";
            SqlParameter param = new SqlParameter("@AdvertPositionId", AdvertPositionId);
            return SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, CommandType.Text, strSQL, param);
        }

        public bool IsDelete(Guid AdvertId)
        {
            EntityCollection<AdvertsGroupEntity> items = AdvertsGroupManager.CreateInstant().SelectByAdvertIdLST(AdvertId);
            if (items != null && items.Count > 0)
                return false;
            return true;
        }

        public void DeleteAll(Guid AdvertId)
        {
            EntityCollection<AdvertsGroupEntity> items = AdvertsGroupManager.CreateInstant().SelectByAdvertIdLST(AdvertId);
            if (items != null && items.Count > 0)
            {
                for (int i = 0; i < items.Count; i++)
                {
                    AdvertsPositionManager.CreateInstant().Delete(items[i].AdvertPositionId);
                }
            }

            AdvertsGroupManager.CreateInstant().DeleteByAdvertId(AdvertId);
            AdvertsManager.CreateInstant().Delete(AdvertId);
        }

        public DataTable GetAllAdverts()
        {
            string strSQL = "prcGetAllAdvert";
            return SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, CommandType.StoredProcedure, strSQL, null);
        }

        public AdvertsEntity GetById(Guid Id)
        {
            EntityCollection<AdvertsEntity> items = SelectByIdLST(Id);
            if (items != null && items.Count > 0)
                return items[0];
            return null;
        }

        public DataTable GetSetting(Guid AdvertId)
        {
            string strSQL = "AdvertSetting";
            SqlParameter param = new SqlParameter("@AdvertId", AdvertId);
            return SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, CommandType.StoredProcedure, strSQL, param);
        }
    }
}
