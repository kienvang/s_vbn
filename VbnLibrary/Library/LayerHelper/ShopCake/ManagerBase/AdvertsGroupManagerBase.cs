




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.AdvertsGroupManagerBase
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
	public class AdvertsGroupManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public AdvertsGroupManagerBase()
		{
			// Nothing for now.
		}
		
		public AdvertsGroupEntity Insert(AdvertsGroupEntity _AdvertsGroupEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_AdvertsGroupEntity, true);
			}
			return _AdvertsGroupEntity;
		}

		
		public AdvertsGroupEntity Insert(Guid Id, Guid AdvertId, Guid AdvertPositionId)
		{
			AdvertsGroupEntity _AdvertsGroupEntity = new AdvertsGroupEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_AdvertsGroupEntity.Id = Id;
				_AdvertsGroupEntity.AdvertId = AdvertId;
				_AdvertsGroupEntity.AdvertPositionId = AdvertPositionId;
				adapter.SaveEntity(_AdvertsGroupEntity, true);
			}
			return _AdvertsGroupEntity;
		}

		public AdvertsGroupEntity Insert(Guid AdvertId, Guid AdvertPositionId)
		{
			AdvertsGroupEntity _AdvertsGroupEntity = new AdvertsGroupEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_AdvertsGroupEntity.AdvertId = AdvertId;
				_AdvertsGroupEntity.AdvertPositionId = AdvertPositionId;
				adapter.SaveEntity(_AdvertsGroupEntity, true);
			}
			return _AdvertsGroupEntity;
		}

		public bool Update(AdvertsGroupEntity _AdvertsGroupEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(AdvertsGroupFields.Id == _AdvertsGroupEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_AdvertsGroupEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(AdvertsGroupEntity _AdvertsGroupEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_AdvertsGroupEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, Guid AdvertId, Guid AdvertPositionId)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				AdvertsGroupEntity _AdvertsGroupEntity = new AdvertsGroupEntity(Id);
				if (adapter.FetchEntity(_AdvertsGroupEntity))
				{
				
					_AdvertsGroupEntity.AdvertId = AdvertId;
					_AdvertsGroupEntity.AdvertPositionId = AdvertPositionId;
					adapter.SaveEntity(_AdvertsGroupEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(Guid Id)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				AdvertsGroupEntity _AdvertsGroupEntity = new AdvertsGroupEntity(Id);
				if (adapter.FetchEntity(_AdvertsGroupEntity))
				{
					adapter.DeleteEntity(_AdvertsGroupEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("AdvertsGroupEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsGroupFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AdvertsGroupEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByAdvertId(Guid AdvertId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsGroupFields.AdvertId == AdvertId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AdvertsGroupEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByAdvertPositionId(Guid AdvertPositionId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsGroupFields.AdvertPositionId == AdvertPositionId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AdvertsGroupEntity", filter);
			}
			return toReturn;
		}
		

		
		public AdvertsGroupEntity SelectOne(Guid Id)
		{
			AdvertsGroupEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				AdvertsGroupEntity _AdvertsGroupEntity = new AdvertsGroupEntity(Id);
				if (adapter.FetchEntity(_AdvertsGroupEntity))
				{
					toReturn = _AdvertsGroupEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsGroupCollection = new EntityCollection(new AdvertsGroupEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<AdvertsGroupEntity>
		public EntityCollection<AdvertsGroupEntity> SelectAllLST()
		{
			EntityCollection<AdvertsGroupEntity> _AdvertsGroupCollection = new EntityCollection<AdvertsGroupEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsGroupCollection, null, 0, null);
			}
			return _AdvertsGroupCollection;
		}
		
		// Return EntityCollection<AdvertsGroupEntity>
		public EntityCollection<AdvertsGroupEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<AdvertsGroupEntity> _AdvertsGroupCollection = new EntityCollection<AdvertsGroupEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsGroupCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _AdvertsGroupCollection;
		}


		
		// Return EntityCollection<AdvertsGroupEntity>
		public EntityCollection<AdvertsGroupEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<AdvertsGroupEntity> _AdvertsGroupCollection = new EntityCollection<AdvertsGroupEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsGroupFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsGroupCollection, filter, 0, null);
			}
			return _AdvertsGroupCollection;
		}
		
		// Return EntityCollection<AdvertsGroupEntity>
		public EntityCollection<AdvertsGroupEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<AdvertsGroupEntity> _AdvertsGroupCollection = new EntityCollection<AdvertsGroupEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsGroupFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsGroupCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AdvertsGroupCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsGroupCollection = new EntityCollection(new AdvertsGroupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsGroupFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsGroupCollection = new EntityCollection(new AdvertsGroupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsGroupFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AdvertsGroupEntity>
		public EntityCollection<AdvertsGroupEntity> SelectByAdvertIdLST(Guid AdvertId)
		{
			EntityCollection<AdvertsGroupEntity> _AdvertsGroupCollection = new EntityCollection<AdvertsGroupEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsGroupFields.AdvertId == AdvertId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsGroupCollection, filter, 0, null);
			}
			return _AdvertsGroupCollection;
		}
		
		// Return EntityCollection<AdvertsGroupEntity>
		public EntityCollection<AdvertsGroupEntity> SelectByAdvertIdLST_Paged(Guid AdvertId, int PageNumber, int PageSize)
		{
			EntityCollection<AdvertsGroupEntity> _AdvertsGroupCollection = new EntityCollection<AdvertsGroupEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsGroupFields.AdvertId == AdvertId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsGroupCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AdvertsGroupCollection;
		}
		
		// Return DataTable
		public DataTable SelectByAdvertIdRDT(Guid AdvertId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsGroupCollection = new EntityCollection(new AdvertsGroupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsGroupFields.AdvertId == AdvertId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByAdvertIdRDT_Paged(Guid AdvertId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsGroupCollection = new EntityCollection(new AdvertsGroupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsGroupFields.AdvertId == AdvertId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AdvertsGroupEntity>
		public EntityCollection<AdvertsGroupEntity> SelectByAdvertPositionIdLST(Guid AdvertPositionId)
		{
			EntityCollection<AdvertsGroupEntity> _AdvertsGroupCollection = new EntityCollection<AdvertsGroupEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsGroupFields.AdvertPositionId == AdvertPositionId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsGroupCollection, filter, 0, null);
			}
			return _AdvertsGroupCollection;
		}
		
		// Return EntityCollection<AdvertsGroupEntity>
		public EntityCollection<AdvertsGroupEntity> SelectByAdvertPositionIdLST_Paged(Guid AdvertPositionId, int PageNumber, int PageSize)
		{
			EntityCollection<AdvertsGroupEntity> _AdvertsGroupCollection = new EntityCollection<AdvertsGroupEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsGroupFields.AdvertPositionId == AdvertPositionId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsGroupCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AdvertsGroupCollection;
		}
		
		// Return DataTable
		public DataTable SelectByAdvertPositionIdRDT(Guid AdvertPositionId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsGroupCollection = new EntityCollection(new AdvertsGroupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsGroupFields.AdvertPositionId == AdvertPositionId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByAdvertPositionIdRDT_Paged(Guid AdvertPositionId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsGroupCollection = new EntityCollection(new AdvertsGroupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsGroupFields.AdvertPositionId == AdvertPositionId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
