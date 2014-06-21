




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.PositionManagerBase
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
	public class PositionManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public PositionManagerBase()
		{
			// Nothing for now.
		}
		
		public PositionEntity Insert(PositionEntity _PositionEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_PositionEntity, true);
			}
			return _PositionEntity;
		}

		
		public PositionEntity Insert(string Id, string PositionName, string ParentId, int OrderIndex)
		{
			PositionEntity _PositionEntity = new PositionEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_PositionEntity.Id = Id;
				_PositionEntity.PositionName = PositionName;
				_PositionEntity.ParentId = ParentId;
				_PositionEntity.OrderIndex = OrderIndex;
				adapter.SaveEntity(_PositionEntity, true);
			}
			return _PositionEntity;
		}

		public PositionEntity Insert(string PositionName, string ParentId, int OrderIndex)
		{
			PositionEntity _PositionEntity = new PositionEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_PositionEntity.PositionName = PositionName;
				_PositionEntity.ParentId = ParentId;
				_PositionEntity.OrderIndex = OrderIndex;
				adapter.SaveEntity(_PositionEntity, true);
			}
			return _PositionEntity;
		}

		public bool Update(PositionEntity _PositionEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(PositionFields.Id == _PositionEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_PositionEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(PositionEntity _PositionEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_PositionEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(string Id, string PositionName, string ParentId, int OrderIndex)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				PositionEntity _PositionEntity = new PositionEntity(Id);
				if (adapter.FetchEntity(_PositionEntity))
				{
				
					_PositionEntity.PositionName = PositionName;
					_PositionEntity.ParentId = ParentId;
					_PositionEntity.OrderIndex = OrderIndex;
					adapter.SaveEntity(_PositionEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(string Id)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				PositionEntity _PositionEntity = new PositionEntity(Id);
				if (adapter.FetchEntity(_PositionEntity))
				{
					adapter.DeleteEntity(_PositionEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("PositionEntity", null);
			}
		}
		
		
		public int DeleteById(string Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PositionFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PositionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPositionName(string PositionName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PositionFields.PositionName == PositionName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PositionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByParentId(string ParentId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PositionFields.ParentId == ParentId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PositionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByOrderIndex(int OrderIndex)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PositionFields.OrderIndex == OrderIndex);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PositionEntity", filter);
			}
			return toReturn;
		}
		

		
		public PositionEntity SelectOne(string Id)
		{
			PositionEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				PositionEntity _PositionEntity = new PositionEntity(Id);
				if (adapter.FetchEntity(_PositionEntity))
				{
					toReturn = _PositionEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PositionCollection = new EntityCollection(new PositionEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PositionCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<PositionEntity>
		public EntityCollection<PositionEntity> SelectAllLST()
		{
			EntityCollection<PositionEntity> _PositionCollection = new EntityCollection<PositionEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PositionCollection, null, 0, null);
			}
			return _PositionCollection;
		}
		
		// Return EntityCollection<PositionEntity>
		public EntityCollection<PositionEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<PositionEntity> _PositionCollection = new EntityCollection<PositionEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PositionCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _PositionCollection;
		}


		
		// Return EntityCollection<PositionEntity>
		public EntityCollection<PositionEntity> SelectByIdLST(string Id)
		{
			EntityCollection<PositionEntity> _PositionCollection = new EntityCollection<PositionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PositionFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PositionCollection, filter, 0, null);
			}
			return _PositionCollection;
		}
		
		// Return EntityCollection<PositionEntity>
		public EntityCollection<PositionEntity> SelectByIdLST_Paged(string Id, int PageNumber, int PageSize)
		{
			EntityCollection<PositionEntity> _PositionCollection = new EntityCollection<PositionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PositionFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PositionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PositionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(string Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PositionCollection = new EntityCollection(new PositionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PositionFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PositionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(string Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PositionCollection = new EntityCollection(new PositionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PositionFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PositionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PositionEntity>
		public EntityCollection<PositionEntity> SelectByPositionNameLST(string PositionName)
		{
			EntityCollection<PositionEntity> _PositionCollection = new EntityCollection<PositionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PositionFields.PositionName == PositionName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PositionCollection, filter, 0, null);
			}
			return _PositionCollection;
		}
		
		// Return EntityCollection<PositionEntity>
		public EntityCollection<PositionEntity> SelectByPositionNameLST_Paged(string PositionName, int PageNumber, int PageSize)
		{
			EntityCollection<PositionEntity> _PositionCollection = new EntityCollection<PositionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PositionFields.PositionName == PositionName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PositionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PositionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPositionNameRDT(string PositionName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PositionCollection = new EntityCollection(new PositionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PositionFields.PositionName == PositionName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PositionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPositionNameRDT_Paged(string PositionName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PositionCollection = new EntityCollection(new PositionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PositionFields.PositionName == PositionName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PositionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PositionEntity>
		public EntityCollection<PositionEntity> SelectByParentIdLST(string ParentId)
		{
			EntityCollection<PositionEntity> _PositionCollection = new EntityCollection<PositionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PositionFields.ParentId == ParentId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PositionCollection, filter, 0, null);
			}
			return _PositionCollection;
		}
		
		// Return EntityCollection<PositionEntity>
		public EntityCollection<PositionEntity> SelectByParentIdLST_Paged(string ParentId, int PageNumber, int PageSize)
		{
			EntityCollection<PositionEntity> _PositionCollection = new EntityCollection<PositionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PositionFields.ParentId == ParentId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PositionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PositionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByParentIdRDT(string ParentId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PositionCollection = new EntityCollection(new PositionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PositionFields.ParentId == ParentId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PositionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByParentIdRDT_Paged(string ParentId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PositionCollection = new EntityCollection(new PositionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PositionFields.ParentId == ParentId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PositionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PositionEntity>
		public EntityCollection<PositionEntity> SelectByOrderIndexLST(int OrderIndex)
		{
			EntityCollection<PositionEntity> _PositionCollection = new EntityCollection<PositionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PositionFields.OrderIndex == OrderIndex);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PositionCollection, filter, 0, null);
			}
			return _PositionCollection;
		}
		
		// Return EntityCollection<PositionEntity>
		public EntityCollection<PositionEntity> SelectByOrderIndexLST_Paged(int OrderIndex, int PageNumber, int PageSize)
		{
			EntityCollection<PositionEntity> _PositionCollection = new EntityCollection<PositionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PositionFields.OrderIndex == OrderIndex);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PositionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PositionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByOrderIndexRDT(int OrderIndex)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PositionCollection = new EntityCollection(new PositionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PositionFields.OrderIndex == OrderIndex);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PositionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByOrderIndexRDT_Paged(int OrderIndex, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PositionCollection = new EntityCollection(new PositionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PositionFields.OrderIndex == OrderIndex);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PositionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
