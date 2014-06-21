




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.EventsManagerBase
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
	public class EventsManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public EventsManagerBase()
		{
			// Nothing for now.
		}
		
		public EventsEntity Insert(EventsEntity _EventsEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_EventsEntity, true);
			}
			return _EventsEntity;
		}

		
		public EventsEntity Insert(Guid Id, string EventName, string EventType, string AddressUrl, string CreatedBy, DateTime CreatedDate, bool Approved, string ApprovedBy, DateTime ApprovedDate)
		{
			EventsEntity _EventsEntity = new EventsEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_EventsEntity.Id = Id;
				_EventsEntity.EventName = EventName;
				_EventsEntity.EventType = EventType;
				_EventsEntity.AddressUrl = AddressUrl;
				_EventsEntity.CreatedBy = CreatedBy;
				_EventsEntity.CreatedDate = CreatedDate;
				_EventsEntity.Approved = Approved;
				_EventsEntity.ApprovedBy = ApprovedBy;
				_EventsEntity.ApprovedDate = ApprovedDate;
				adapter.SaveEntity(_EventsEntity, true);
			}
			return _EventsEntity;
		}

		public EventsEntity Insert(string EventName, string EventType, string AddressUrl, string CreatedBy, DateTime CreatedDate, bool Approved, string ApprovedBy, DateTime ApprovedDate)
		{
			EventsEntity _EventsEntity = new EventsEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_EventsEntity.EventName = EventName;
				_EventsEntity.EventType = EventType;
				_EventsEntity.AddressUrl = AddressUrl;
				_EventsEntity.CreatedBy = CreatedBy;
				_EventsEntity.CreatedDate = CreatedDate;
				_EventsEntity.Approved = Approved;
				_EventsEntity.ApprovedBy = ApprovedBy;
				_EventsEntity.ApprovedDate = ApprovedDate;
				adapter.SaveEntity(_EventsEntity, true);
			}
			return _EventsEntity;
		}

		public bool Update(EventsEntity _EventsEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(EventsFields.Id == _EventsEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_EventsEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(EventsEntity _EventsEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_EventsEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string EventName, string EventType, string AddressUrl, string CreatedBy, DateTime CreatedDate, bool Approved, string ApprovedBy, DateTime ApprovedDate)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				EventsEntity _EventsEntity = new EventsEntity(Id);
				if (adapter.FetchEntity(_EventsEntity))
				{
				
					_EventsEntity.EventName = EventName;
					_EventsEntity.EventType = EventType;
					_EventsEntity.AddressUrl = AddressUrl;
					_EventsEntity.CreatedBy = CreatedBy;
					_EventsEntity.CreatedDate = CreatedDate;
					_EventsEntity.Approved = Approved;
					_EventsEntity.ApprovedBy = ApprovedBy;
					_EventsEntity.ApprovedDate = ApprovedDate;
					adapter.SaveEntity(_EventsEntity, true);
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
				EventsEntity _EventsEntity = new EventsEntity(Id);
				if (adapter.FetchEntity(_EventsEntity))
				{
					adapter.DeleteEntity(_EventsEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("EventsEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("EventsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByEventName(string EventName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventsFields.EventName == EventName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("EventsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByEventType(string EventType)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventsFields.EventType == EventType);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("EventsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByAddressUrl(string AddressUrl)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventsFields.AddressUrl == AddressUrl);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("EventsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCreatedBy(string CreatedBy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventsFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("EventsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCreatedDate(DateTime CreatedDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventsFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("EventsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByApproved(bool Approved)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventsFields.Approved == Approved);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("EventsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByApprovedBy(string ApprovedBy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventsFields.ApprovedBy == ApprovedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("EventsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByApprovedDate(DateTime ApprovedDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventsFields.ApprovedDate == ApprovedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("EventsEntity", filter);
			}
			return toReturn;
		}
		

		
		public EventsEntity SelectOne(Guid Id)
		{
			EventsEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				EventsEntity _EventsEntity = new EventsEntity(Id);
				if (adapter.FetchEntity(_EventsEntity))
				{
					toReturn = _EventsEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EventsCollection = new EntityCollection(new EventsEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EventsCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<EventsEntity>
		public EntityCollection<EventsEntity> SelectAllLST()
		{
			EntityCollection<EventsEntity> _EventsCollection = new EntityCollection<EventsEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EventsCollection, null, 0, null);
			}
			return _EventsCollection;
		}
		
		// Return EntityCollection<EventsEntity>
		public EntityCollection<EventsEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<EventsEntity> _EventsCollection = new EntityCollection<EventsEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EventsCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _EventsCollection;
		}


		
		// Return EntityCollection<EventsEntity>
		public EntityCollection<EventsEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<EventsEntity> _EventsCollection = new EntityCollection<EventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EventsCollection, filter, 0, null);
			}
			return _EventsCollection;
		}
		
		// Return EntityCollection<EventsEntity>
		public EntityCollection<EventsEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<EventsEntity> _EventsCollection = new EntityCollection<EventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EventsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _EventsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EventsCollection = new EntityCollection(new EventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EventsCollection = new EntityCollection(new EventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<EventsEntity>
		public EntityCollection<EventsEntity> SelectByEventNameLST(string EventName)
		{
			EntityCollection<EventsEntity> _EventsCollection = new EntityCollection<EventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventsFields.EventName == EventName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EventsCollection, filter, 0, null);
			}
			return _EventsCollection;
		}
		
		// Return EntityCollection<EventsEntity>
		public EntityCollection<EventsEntity> SelectByEventNameLST_Paged(string EventName, int PageNumber, int PageSize)
		{
			EntityCollection<EventsEntity> _EventsCollection = new EntityCollection<EventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventsFields.EventName == EventName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EventsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _EventsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByEventNameRDT(string EventName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EventsCollection = new EntityCollection(new EventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventsFields.EventName == EventName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByEventNameRDT_Paged(string EventName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EventsCollection = new EntityCollection(new EventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventsFields.EventName == EventName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<EventsEntity>
		public EntityCollection<EventsEntity> SelectByEventTypeLST(string EventType)
		{
			EntityCollection<EventsEntity> _EventsCollection = new EntityCollection<EventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventsFields.EventType == EventType);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EventsCollection, filter, 0, null);
			}
			return _EventsCollection;
		}
		
		// Return EntityCollection<EventsEntity>
		public EntityCollection<EventsEntity> SelectByEventTypeLST_Paged(string EventType, int PageNumber, int PageSize)
		{
			EntityCollection<EventsEntity> _EventsCollection = new EntityCollection<EventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventsFields.EventType == EventType);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EventsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _EventsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByEventTypeRDT(string EventType)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EventsCollection = new EntityCollection(new EventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventsFields.EventType == EventType);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByEventTypeRDT_Paged(string EventType, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EventsCollection = new EntityCollection(new EventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventsFields.EventType == EventType);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<EventsEntity>
		public EntityCollection<EventsEntity> SelectByAddressUrlLST(string AddressUrl)
		{
			EntityCollection<EventsEntity> _EventsCollection = new EntityCollection<EventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventsFields.AddressUrl == AddressUrl);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EventsCollection, filter, 0, null);
			}
			return _EventsCollection;
		}
		
		// Return EntityCollection<EventsEntity>
		public EntityCollection<EventsEntity> SelectByAddressUrlLST_Paged(string AddressUrl, int PageNumber, int PageSize)
		{
			EntityCollection<EventsEntity> _EventsCollection = new EntityCollection<EventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventsFields.AddressUrl == AddressUrl);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EventsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _EventsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByAddressUrlRDT(string AddressUrl)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EventsCollection = new EntityCollection(new EventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventsFields.AddressUrl == AddressUrl);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByAddressUrlRDT_Paged(string AddressUrl, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EventsCollection = new EntityCollection(new EventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventsFields.AddressUrl == AddressUrl);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<EventsEntity>
		public EntityCollection<EventsEntity> SelectByCreatedByLST(string CreatedBy)
		{
			EntityCollection<EventsEntity> _EventsCollection = new EntityCollection<EventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventsFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EventsCollection, filter, 0, null);
			}
			return _EventsCollection;
		}
		
		// Return EntityCollection<EventsEntity>
		public EntityCollection<EventsEntity> SelectByCreatedByLST_Paged(string CreatedBy, int PageNumber, int PageSize)
		{
			EntityCollection<EventsEntity> _EventsCollection = new EntityCollection<EventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventsFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EventsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _EventsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedByRDT(string CreatedBy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EventsCollection = new EntityCollection(new EventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventsFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedByRDT_Paged(string CreatedBy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EventsCollection = new EntityCollection(new EventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventsFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<EventsEntity>
		public EntityCollection<EventsEntity> SelectByCreatedDateLST(DateTime CreatedDate)
		{
			EntityCollection<EventsEntity> _EventsCollection = new EntityCollection<EventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventsFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EventsCollection, filter, 0, null);
			}
			return _EventsCollection;
		}
		
		// Return EntityCollection<EventsEntity>
		public EntityCollection<EventsEntity> SelectByCreatedDateLST_Paged(DateTime CreatedDate, int PageNumber, int PageSize)
		{
			EntityCollection<EventsEntity> _EventsCollection = new EntityCollection<EventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventsFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EventsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _EventsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedDateRDT(DateTime CreatedDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EventsCollection = new EntityCollection(new EventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventsFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedDateRDT_Paged(DateTime CreatedDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EventsCollection = new EntityCollection(new EventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventsFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<EventsEntity>
		public EntityCollection<EventsEntity> SelectByApprovedLST(bool Approved)
		{
			EntityCollection<EventsEntity> _EventsCollection = new EntityCollection<EventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventsFields.Approved == Approved);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EventsCollection, filter, 0, null);
			}
			return _EventsCollection;
		}
		
		// Return EntityCollection<EventsEntity>
		public EntityCollection<EventsEntity> SelectByApprovedLST_Paged(bool Approved, int PageNumber, int PageSize)
		{
			EntityCollection<EventsEntity> _EventsCollection = new EntityCollection<EventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventsFields.Approved == Approved);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EventsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _EventsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByApprovedRDT(bool Approved)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EventsCollection = new EntityCollection(new EventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventsFields.Approved == Approved);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByApprovedRDT_Paged(bool Approved, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EventsCollection = new EntityCollection(new EventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventsFields.Approved == Approved);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<EventsEntity>
		public EntityCollection<EventsEntity> SelectByApprovedByLST(string ApprovedBy)
		{
			EntityCollection<EventsEntity> _EventsCollection = new EntityCollection<EventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventsFields.ApprovedBy == ApprovedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EventsCollection, filter, 0, null);
			}
			return _EventsCollection;
		}
		
		// Return EntityCollection<EventsEntity>
		public EntityCollection<EventsEntity> SelectByApprovedByLST_Paged(string ApprovedBy, int PageNumber, int PageSize)
		{
			EntityCollection<EventsEntity> _EventsCollection = new EntityCollection<EventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventsFields.ApprovedBy == ApprovedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EventsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _EventsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByApprovedByRDT(string ApprovedBy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EventsCollection = new EntityCollection(new EventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventsFields.ApprovedBy == ApprovedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByApprovedByRDT_Paged(string ApprovedBy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EventsCollection = new EntityCollection(new EventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventsFields.ApprovedBy == ApprovedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<EventsEntity>
		public EntityCollection<EventsEntity> SelectByApprovedDateLST(DateTime ApprovedDate)
		{
			EntityCollection<EventsEntity> _EventsCollection = new EntityCollection<EventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventsFields.ApprovedDate == ApprovedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EventsCollection, filter, 0, null);
			}
			return _EventsCollection;
		}
		
		// Return EntityCollection<EventsEntity>
		public EntityCollection<EventsEntity> SelectByApprovedDateLST_Paged(DateTime ApprovedDate, int PageNumber, int PageSize)
		{
			EntityCollection<EventsEntity> _EventsCollection = new EntityCollection<EventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventsFields.ApprovedDate == ApprovedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EventsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _EventsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByApprovedDateRDT(DateTime ApprovedDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EventsCollection = new EntityCollection(new EventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventsFields.ApprovedDate == ApprovedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByApprovedDateRDT_Paged(DateTime ApprovedDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EventsCollection = new EntityCollection(new EventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EventsFields.ApprovedDate == ApprovedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
