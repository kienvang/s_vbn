




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.BannerManagerBase
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
	public class BannerManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public BannerManagerBase()
		{
			// Nothing for now.
		}
		
		public BannerEntity Insert(BannerEntity _BannerEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_BannerEntity, true);
			}
			return _BannerEntity;
		}

		
		public BannerEntity Insert(int Id, string BannerUrl, string LogoUrl)
		{
			BannerEntity _BannerEntity = new BannerEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_BannerEntity.Id = Id;
				_BannerEntity.BannerUrl = BannerUrl;
				_BannerEntity.LogoUrl = LogoUrl;
				adapter.SaveEntity(_BannerEntity, true);
			}
			return _BannerEntity;
		}

		public BannerEntity Insert(string BannerUrl, string LogoUrl)
		{
			BannerEntity _BannerEntity = new BannerEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_BannerEntity.BannerUrl = BannerUrl;
				_BannerEntity.LogoUrl = LogoUrl;
				adapter.SaveEntity(_BannerEntity, true);
			}
			return _BannerEntity;
		}

		public bool Update(BannerEntity _BannerEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(BannerFields.Id == _BannerEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_BannerEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(BannerEntity _BannerEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_BannerEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(int Id, string BannerUrl, string LogoUrl)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				BannerEntity _BannerEntity = new BannerEntity(Id);
				if (adapter.FetchEntity(_BannerEntity))
				{
				
					_BannerEntity.BannerUrl = BannerUrl;
					_BannerEntity.LogoUrl = LogoUrl;
					adapter.SaveEntity(_BannerEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(int Id)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				BannerEntity _BannerEntity = new BannerEntity(Id);
				if (adapter.FetchEntity(_BannerEntity))
				{
					adapter.DeleteEntity(_BannerEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("BannerEntity", null);
			}
		}
		
		
		public int DeleteById(int Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BannerFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("BannerEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByBannerUrl(string BannerUrl)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BannerFields.BannerUrl == BannerUrl);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("BannerEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLogoUrl(string LogoUrl)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BannerFields.LogoUrl == LogoUrl);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("BannerEntity", filter);
			}
			return toReturn;
		}
		

		
		public BannerEntity SelectOne(int Id)
		{
			BannerEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				BannerEntity _BannerEntity = new BannerEntity(Id);
				if (adapter.FetchEntity(_BannerEntity))
				{
					toReturn = _BannerEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BannerCollection = new EntityCollection(new BannerEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BannerCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<BannerEntity>
		public EntityCollection<BannerEntity> SelectAllLST()
		{
			EntityCollection<BannerEntity> _BannerCollection = new EntityCollection<BannerEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BannerCollection, null, 0, null);
			}
			return _BannerCollection;
		}
		
		// Return EntityCollection<BannerEntity>
		public EntityCollection<BannerEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<BannerEntity> _BannerCollection = new EntityCollection<BannerEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BannerCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _BannerCollection;
		}


		
		// Return EntityCollection<BannerEntity>
		public EntityCollection<BannerEntity> SelectByIdLST(int Id)
		{
			EntityCollection<BannerEntity> _BannerCollection = new EntityCollection<BannerEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BannerFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BannerCollection, filter, 0, null);
			}
			return _BannerCollection;
		}
		
		// Return EntityCollection<BannerEntity>
		public EntityCollection<BannerEntity> SelectByIdLST_Paged(int Id, int PageNumber, int PageSize)
		{
			EntityCollection<BannerEntity> _BannerCollection = new EntityCollection<BannerEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BannerFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BannerCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _BannerCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(int Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BannerCollection = new EntityCollection(new BannerEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BannerFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BannerCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(int Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BannerCollection = new EntityCollection(new BannerEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BannerFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BannerCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<BannerEntity>
		public EntityCollection<BannerEntity> SelectByBannerUrlLST(string BannerUrl)
		{
			EntityCollection<BannerEntity> _BannerCollection = new EntityCollection<BannerEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BannerFields.BannerUrl == BannerUrl);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BannerCollection, filter, 0, null);
			}
			return _BannerCollection;
		}
		
		// Return EntityCollection<BannerEntity>
		public EntityCollection<BannerEntity> SelectByBannerUrlLST_Paged(string BannerUrl, int PageNumber, int PageSize)
		{
			EntityCollection<BannerEntity> _BannerCollection = new EntityCollection<BannerEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BannerFields.BannerUrl == BannerUrl);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BannerCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _BannerCollection;
		}
		
		// Return DataTable
		public DataTable SelectByBannerUrlRDT(string BannerUrl)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BannerCollection = new EntityCollection(new BannerEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BannerFields.BannerUrl == BannerUrl);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BannerCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByBannerUrlRDT_Paged(string BannerUrl, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BannerCollection = new EntityCollection(new BannerEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BannerFields.BannerUrl == BannerUrl);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BannerCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<BannerEntity>
		public EntityCollection<BannerEntity> SelectByLogoUrlLST(string LogoUrl)
		{
			EntityCollection<BannerEntity> _BannerCollection = new EntityCollection<BannerEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BannerFields.LogoUrl == LogoUrl);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BannerCollection, filter, 0, null);
			}
			return _BannerCollection;
		}
		
		// Return EntityCollection<BannerEntity>
		public EntityCollection<BannerEntity> SelectByLogoUrlLST_Paged(string LogoUrl, int PageNumber, int PageSize)
		{
			EntityCollection<BannerEntity> _BannerCollection = new EntityCollection<BannerEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BannerFields.LogoUrl == LogoUrl);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BannerCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _BannerCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLogoUrlRDT(string LogoUrl)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BannerCollection = new EntityCollection(new BannerEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BannerFields.LogoUrl == LogoUrl);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BannerCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLogoUrlRDT_Paged(string LogoUrl, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BannerCollection = new EntityCollection(new BannerEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BannerFields.LogoUrl == LogoUrl);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BannerCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
