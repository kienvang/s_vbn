




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.EventTypeManagerBase
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
	public class EventTypeManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public EventTypeManagerBase()
		{
			// Nothing for now.
		}
		
		public EventTypeEntity Insert(EventTypeEntity _EventTypeEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_EventTypeEntity, true);
			}
			return _EventTypeEntity;
		}

		
		public EventTypeEntity Insert(string Id, string TypeName)
		{
			EventTypeEntity _EventTypeEntity = new EventTypeEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_EventTypeEntity.Id = Id;
				_EventTypeEntity.TypeName = TypeName;
				adapter.SaveEntity(_EventTypeEntity, true);
			}
			return _EventTypeEntity;
		}

		public EventTypeEntity Insert(string TypeName)
		{
			EventTypeEntity _EventTypeEntity = new EventTypeEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_EventTypeEntity.TypeName = TypeName;
				adapter.SaveEntity(_EventTypeEntity, true);
			}
			return _EventTypeEntity;
		}

		public bool Update(EventTypeEntity _EventTypeEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(EventTypeFields.Id == _EventTypeEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_EventTypeEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(EventTypeEntity _EventTypeEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_EventTypeEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(string Id, string TypeName)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				EventTypeEntity _EventTypeEntity = new EventTypeEntity(Id);
				if (adapter.FetchEntity(_EventTypeEntity))
				{
				
					_EventTypeEntity.TypeName = TypeName;
					adapter.SaveEntity(_EventTypeEntity, true);
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
				EventTypeEntity _EventTypeEntity = new EventTypeEntity(Id);
				if (adapter.FetchEntity(_EventTypeEntity))
				{
					adapter.DeleteEntity(_EventTypeEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("EventTypeEntity", null);
			}
		}
		
		
		public int DeleteById(string Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventTypeFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("EventTypeEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTypeName(string TypeName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventTypeFields.TypeName == TypeName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("EventTypeEntity", filter);
			}
			return toReturn;
		}
		

		
		public EventTypeEntity SelectOne(string Id)
		{
			EventTypeEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				EventTypeEntity _EventTypeEntity = new EventTypeEntity(Id);
				if (adapter.FetchEntity(_EventTypeEntity))
				{
					toReturn = _EventTypeEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EventTypeCollection = new EntityCollection(new EventTypeEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EventTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<EventTypeEntity>
		public EntityCollection<EventTypeEntity> SelectAllLST()
		{
			EntityCollection<EventTypeEntity> _EventTypeCollection = new EntityCollection<EventTypeEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EventTypeCollection, null, 0, null);
			}
			return _EventTypeCollection;
		}
		
		// Return EntityCollection<EventTypeEntity>
		public EntityCollection<EventTypeEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<EventTypeEntity> _EventTypeCollection = new EntityCollection<EventTypeEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EventTypeCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _EventTypeCollection;
		}


		
		// Return EntityCollection<EventTypeEntity>
		public EntityCollection<EventTypeEntity> SelectByIdLST(string Id)
		{
			EntityCollection<EventTypeEntity> _EventTypeCollection = new EntityCollection<EventTypeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventTypeFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EventTypeCollection, filter, 0, null);
			}
			return _EventTypeCollection;
		}
		
		// Return EntityCollection<EventTypeEntity>
		public EntityCollection<EventTypeEntity> SelectByIdLST_Paged(string Id, int PageNumber, int PageSize)
		{
			EntityCollection<EventTypeEntity> _EventTypeCollection = new EntityCollection<EventTypeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventTypeFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EventTypeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _EventTypeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(string Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EventTypeCollection = new EntityCollection(new EventTypeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventTypeFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EventTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(string Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EventTypeCollection = new EntityCollection(new EventTypeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventTypeFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EventTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<EventTypeEntity>
		public EntityCollection<EventTypeEntity> SelectByTypeNameLST(string TypeName)
		{
			EntityCollection<EventTypeEntity> _EventTypeCollection = new EntityCollection<EventTypeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventTypeFields.TypeName == TypeName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EventTypeCollection, filter, 0, null);
			}
			return _EventTypeCollection;
		}
		
		// Return EntityCollection<EventTypeEntity>
		public EntityCollection<EventTypeEntity> SelectByTypeNameLST_Paged(string TypeName, int PageNumber, int PageSize)
		{
			EntityCollection<EventTypeEntity> _EventTypeCollection = new EntityCollection<EventTypeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventTypeFields.TypeName == TypeName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EventTypeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _EventTypeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTypeNameRDT(string TypeName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EventTypeCollection = new EntityCollection(new EventTypeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventTypeFields.TypeName == TypeName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EventTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTypeNameRDT_Paged(string TypeName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EventTypeCollection = new EntityCollection(new EventTypeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventTypeFields.TypeName == TypeName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EventTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
