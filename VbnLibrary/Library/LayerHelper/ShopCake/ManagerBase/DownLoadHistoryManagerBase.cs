




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.DownLoadHistoryManagerBase
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
	public class DownLoadHistoryManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DownLoadHistoryManagerBase()
		{
			// Nothing for now.
		}
		
		public DownLoadHistoryEntity Insert(DownLoadHistoryEntity _DownLoadHistoryEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_DownLoadHistoryEntity, true);
			}
			return _DownLoadHistoryEntity;
		}

		
		public DownLoadHistoryEntity Insert(Guid Id, Guid CustomerId, Guid DocumentId, DateTime Date, long MarkBeforeDown, long MarkAfterDown, DateTime CreatedDate, string CreatedBy, DateTime UpdatedDate, string UpdatedBy, bool IsDeleted)
		{
			DownLoadHistoryEntity _DownLoadHistoryEntity = new DownLoadHistoryEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DownLoadHistoryEntity.Id = Id;
				_DownLoadHistoryEntity.CustomerId = CustomerId;
				_DownLoadHistoryEntity.DocumentId = DocumentId;
				_DownLoadHistoryEntity.Date = Date;
				_DownLoadHistoryEntity.MarkBeforeDown = MarkBeforeDown;
				_DownLoadHistoryEntity.MarkAfterDown = MarkAfterDown;
				_DownLoadHistoryEntity.CreatedDate = CreatedDate;
				_DownLoadHistoryEntity.CreatedBy = CreatedBy;
				_DownLoadHistoryEntity.UpdatedDate = UpdatedDate;
				_DownLoadHistoryEntity.UpdatedBy = UpdatedBy;
				_DownLoadHistoryEntity.IsDeleted = IsDeleted;
				adapter.SaveEntity(_DownLoadHistoryEntity, true);
			}
			return _DownLoadHistoryEntity;
		}

		public DownLoadHistoryEntity Insert(Guid CustomerId, Guid DocumentId, DateTime Date, long MarkBeforeDown, long MarkAfterDown, DateTime CreatedDate, string CreatedBy, DateTime UpdatedDate, string UpdatedBy, bool IsDeleted)
		{
			DownLoadHistoryEntity _DownLoadHistoryEntity = new DownLoadHistoryEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DownLoadHistoryEntity.CustomerId = CustomerId;
				_DownLoadHistoryEntity.DocumentId = DocumentId;
				_DownLoadHistoryEntity.Date = Date;
				_DownLoadHistoryEntity.MarkBeforeDown = MarkBeforeDown;
				_DownLoadHistoryEntity.MarkAfterDown = MarkAfterDown;
				_DownLoadHistoryEntity.CreatedDate = CreatedDate;
				_DownLoadHistoryEntity.CreatedBy = CreatedBy;
				_DownLoadHistoryEntity.UpdatedDate = UpdatedDate;
				_DownLoadHistoryEntity.UpdatedBy = UpdatedBy;
				_DownLoadHistoryEntity.IsDeleted = IsDeleted;
				adapter.SaveEntity(_DownLoadHistoryEntity, true);
			}
			return _DownLoadHistoryEntity;
		}

		public bool Update(DownLoadHistoryEntity _DownLoadHistoryEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(DownLoadHistoryFields.Id == _DownLoadHistoryEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DownLoadHistoryEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DownLoadHistoryEntity _DownLoadHistoryEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DownLoadHistoryEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, Guid CustomerId, Guid DocumentId, DateTime Date, long MarkBeforeDown, long MarkAfterDown, DateTime CreatedDate, string CreatedBy, DateTime UpdatedDate, string UpdatedBy, bool IsDeleted)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DownLoadHistoryEntity _DownLoadHistoryEntity = new DownLoadHistoryEntity(Id);
				if (adapter.FetchEntity(_DownLoadHistoryEntity))
				{
				
					_DownLoadHistoryEntity.CustomerId = CustomerId;
					_DownLoadHistoryEntity.DocumentId = DocumentId;
					_DownLoadHistoryEntity.Date = Date;
					_DownLoadHistoryEntity.MarkBeforeDown = MarkBeforeDown;
					_DownLoadHistoryEntity.MarkAfterDown = MarkAfterDown;
					_DownLoadHistoryEntity.CreatedDate = CreatedDate;
					_DownLoadHistoryEntity.CreatedBy = CreatedBy;
					_DownLoadHistoryEntity.UpdatedDate = UpdatedDate;
					_DownLoadHistoryEntity.UpdatedBy = UpdatedBy;
					_DownLoadHistoryEntity.IsDeleted = IsDeleted;
					adapter.SaveEntity(_DownLoadHistoryEntity, true);
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
				DownLoadHistoryEntity _DownLoadHistoryEntity = new DownLoadHistoryEntity(Id);
				if (adapter.FetchEntity(_DownLoadHistoryEntity))
				{
					adapter.DeleteEntity(_DownLoadHistoryEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DownLoadHistoryEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DownLoadHistoryEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCustomerId(Guid CustomerId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.CustomerId == CustomerId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DownLoadHistoryEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByDocumentId(Guid DocumentId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.DocumentId == DocumentId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DownLoadHistoryEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByDate(DateTime Date)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.Date == Date);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DownLoadHistoryEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMarkBeforeDown(long MarkBeforeDown)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.MarkBeforeDown == MarkBeforeDown);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DownLoadHistoryEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMarkAfterDown(long MarkAfterDown)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.MarkAfterDown == MarkAfterDown);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DownLoadHistoryEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCreatedDate(DateTime CreatedDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DownLoadHistoryEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCreatedBy(string CreatedBy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DownLoadHistoryEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByUpdatedDate(DateTime UpdatedDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DownLoadHistoryEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByUpdatedBy(string UpdatedBy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DownLoadHistoryEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIsDeleted(bool IsDeleted)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.IsDeleted == IsDeleted);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DownLoadHistoryEntity", filter);
			}
			return toReturn;
		}
		

		
		public DownLoadHistoryEntity SelectOne(Guid Id)
		{
			DownLoadHistoryEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DownLoadHistoryEntity _DownLoadHistoryEntity = new DownLoadHistoryEntity(Id);
				if (adapter.FetchEntity(_DownLoadHistoryEntity))
				{
					toReturn = _DownLoadHistoryEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DownLoadHistoryCollection = new EntityCollection(new DownLoadHistoryEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DownLoadHistoryCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<DownLoadHistoryEntity>
		public EntityCollection<DownLoadHistoryEntity> SelectAllLST()
		{
			EntityCollection<DownLoadHistoryEntity> _DownLoadHistoryCollection = new EntityCollection<DownLoadHistoryEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DownLoadHistoryCollection, null, 0, null);
			}
			return _DownLoadHistoryCollection;
		}
		
		// Return EntityCollection<DownLoadHistoryEntity>
		public EntityCollection<DownLoadHistoryEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<DownLoadHistoryEntity> _DownLoadHistoryCollection = new EntityCollection<DownLoadHistoryEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DownLoadHistoryCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _DownLoadHistoryCollection;
		}


		
		// Return EntityCollection<DownLoadHistoryEntity>
		public EntityCollection<DownLoadHistoryEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<DownLoadHistoryEntity> _DownLoadHistoryCollection = new EntityCollection<DownLoadHistoryEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DownLoadHistoryCollection, filter, 0, null);
			}
			return _DownLoadHistoryCollection;
		}
		
		// Return EntityCollection<DownLoadHistoryEntity>
		public EntityCollection<DownLoadHistoryEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<DownLoadHistoryEntity> _DownLoadHistoryCollection = new EntityCollection<DownLoadHistoryEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DownLoadHistoryCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DownLoadHistoryCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DownLoadHistoryCollection = new EntityCollection(new DownLoadHistoryEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DownLoadHistoryCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DownLoadHistoryCollection = new EntityCollection(new DownLoadHistoryEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DownLoadHistoryCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DownLoadHistoryEntity>
		public EntityCollection<DownLoadHistoryEntity> SelectByCustomerIdLST(Guid CustomerId)
		{
			EntityCollection<DownLoadHistoryEntity> _DownLoadHistoryCollection = new EntityCollection<DownLoadHistoryEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.CustomerId == CustomerId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DownLoadHistoryCollection, filter, 0, null);
			}
			return _DownLoadHistoryCollection;
		}
		
		// Return EntityCollection<DownLoadHistoryEntity>
		public EntityCollection<DownLoadHistoryEntity> SelectByCustomerIdLST_Paged(Guid CustomerId, int PageNumber, int PageSize)
		{
			EntityCollection<DownLoadHistoryEntity> _DownLoadHistoryCollection = new EntityCollection<DownLoadHistoryEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.CustomerId == CustomerId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DownLoadHistoryCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DownLoadHistoryCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCustomerIdRDT(Guid CustomerId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DownLoadHistoryCollection = new EntityCollection(new DownLoadHistoryEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.CustomerId == CustomerId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DownLoadHistoryCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCustomerIdRDT_Paged(Guid CustomerId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DownLoadHistoryCollection = new EntityCollection(new DownLoadHistoryEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.CustomerId == CustomerId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DownLoadHistoryCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DownLoadHistoryEntity>
		public EntityCollection<DownLoadHistoryEntity> SelectByDocumentIdLST(Guid DocumentId)
		{
			EntityCollection<DownLoadHistoryEntity> _DownLoadHistoryCollection = new EntityCollection<DownLoadHistoryEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.DocumentId == DocumentId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DownLoadHistoryCollection, filter, 0, null);
			}
			return _DownLoadHistoryCollection;
		}
		
		// Return EntityCollection<DownLoadHistoryEntity>
		public EntityCollection<DownLoadHistoryEntity> SelectByDocumentIdLST_Paged(Guid DocumentId, int PageNumber, int PageSize)
		{
			EntityCollection<DownLoadHistoryEntity> _DownLoadHistoryCollection = new EntityCollection<DownLoadHistoryEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.DocumentId == DocumentId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DownLoadHistoryCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DownLoadHistoryCollection;
		}
		
		// Return DataTable
		public DataTable SelectByDocumentIdRDT(Guid DocumentId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DownLoadHistoryCollection = new EntityCollection(new DownLoadHistoryEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.DocumentId == DocumentId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DownLoadHistoryCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByDocumentIdRDT_Paged(Guid DocumentId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DownLoadHistoryCollection = new EntityCollection(new DownLoadHistoryEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.DocumentId == DocumentId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DownLoadHistoryCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DownLoadHistoryEntity>
		public EntityCollection<DownLoadHistoryEntity> SelectByDateLST(DateTime Date)
		{
			EntityCollection<DownLoadHistoryEntity> _DownLoadHistoryCollection = new EntityCollection<DownLoadHistoryEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.Date == Date);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DownLoadHistoryCollection, filter, 0, null);
			}
			return _DownLoadHistoryCollection;
		}
		
		// Return EntityCollection<DownLoadHistoryEntity>
		public EntityCollection<DownLoadHistoryEntity> SelectByDateLST_Paged(DateTime Date, int PageNumber, int PageSize)
		{
			EntityCollection<DownLoadHistoryEntity> _DownLoadHistoryCollection = new EntityCollection<DownLoadHistoryEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.Date == Date);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DownLoadHistoryCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DownLoadHistoryCollection;
		}
		
		// Return DataTable
		public DataTable SelectByDateRDT(DateTime Date)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DownLoadHistoryCollection = new EntityCollection(new DownLoadHistoryEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.Date == Date);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DownLoadHistoryCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByDateRDT_Paged(DateTime Date, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DownLoadHistoryCollection = new EntityCollection(new DownLoadHistoryEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.Date == Date);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DownLoadHistoryCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DownLoadHistoryEntity>
		public EntityCollection<DownLoadHistoryEntity> SelectByMarkBeforeDownLST(long MarkBeforeDown)
		{
			EntityCollection<DownLoadHistoryEntity> _DownLoadHistoryCollection = new EntityCollection<DownLoadHistoryEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.MarkBeforeDown == MarkBeforeDown);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DownLoadHistoryCollection, filter, 0, null);
			}
			return _DownLoadHistoryCollection;
		}
		
		// Return EntityCollection<DownLoadHistoryEntity>
		public EntityCollection<DownLoadHistoryEntity> SelectByMarkBeforeDownLST_Paged(long MarkBeforeDown, int PageNumber, int PageSize)
		{
			EntityCollection<DownLoadHistoryEntity> _DownLoadHistoryCollection = new EntityCollection<DownLoadHistoryEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.MarkBeforeDown == MarkBeforeDown);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DownLoadHistoryCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DownLoadHistoryCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMarkBeforeDownRDT(long MarkBeforeDown)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DownLoadHistoryCollection = new EntityCollection(new DownLoadHistoryEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.MarkBeforeDown == MarkBeforeDown);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DownLoadHistoryCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMarkBeforeDownRDT_Paged(long MarkBeforeDown, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DownLoadHistoryCollection = new EntityCollection(new DownLoadHistoryEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.MarkBeforeDown == MarkBeforeDown);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DownLoadHistoryCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DownLoadHistoryEntity>
		public EntityCollection<DownLoadHistoryEntity> SelectByMarkAfterDownLST(long MarkAfterDown)
		{
			EntityCollection<DownLoadHistoryEntity> _DownLoadHistoryCollection = new EntityCollection<DownLoadHistoryEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.MarkAfterDown == MarkAfterDown);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DownLoadHistoryCollection, filter, 0, null);
			}
			return _DownLoadHistoryCollection;
		}
		
		// Return EntityCollection<DownLoadHistoryEntity>
		public EntityCollection<DownLoadHistoryEntity> SelectByMarkAfterDownLST_Paged(long MarkAfterDown, int PageNumber, int PageSize)
		{
			EntityCollection<DownLoadHistoryEntity> _DownLoadHistoryCollection = new EntityCollection<DownLoadHistoryEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.MarkAfterDown == MarkAfterDown);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DownLoadHistoryCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DownLoadHistoryCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMarkAfterDownRDT(long MarkAfterDown)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DownLoadHistoryCollection = new EntityCollection(new DownLoadHistoryEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.MarkAfterDown == MarkAfterDown);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DownLoadHistoryCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMarkAfterDownRDT_Paged(long MarkAfterDown, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DownLoadHistoryCollection = new EntityCollection(new DownLoadHistoryEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.MarkAfterDown == MarkAfterDown);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DownLoadHistoryCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DownLoadHistoryEntity>
		public EntityCollection<DownLoadHistoryEntity> SelectByCreatedDateLST(DateTime CreatedDate)
		{
			EntityCollection<DownLoadHistoryEntity> _DownLoadHistoryCollection = new EntityCollection<DownLoadHistoryEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DownLoadHistoryCollection, filter, 0, null);
			}
			return _DownLoadHistoryCollection;
		}
		
		// Return EntityCollection<DownLoadHistoryEntity>
		public EntityCollection<DownLoadHistoryEntity> SelectByCreatedDateLST_Paged(DateTime CreatedDate, int PageNumber, int PageSize)
		{
			EntityCollection<DownLoadHistoryEntity> _DownLoadHistoryCollection = new EntityCollection<DownLoadHistoryEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DownLoadHistoryCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DownLoadHistoryCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedDateRDT(DateTime CreatedDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DownLoadHistoryCollection = new EntityCollection(new DownLoadHistoryEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DownLoadHistoryCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedDateRDT_Paged(DateTime CreatedDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DownLoadHistoryCollection = new EntityCollection(new DownLoadHistoryEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DownLoadHistoryCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DownLoadHistoryEntity>
		public EntityCollection<DownLoadHistoryEntity> SelectByCreatedByLST(string CreatedBy)
		{
			EntityCollection<DownLoadHistoryEntity> _DownLoadHistoryCollection = new EntityCollection<DownLoadHistoryEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DownLoadHistoryCollection, filter, 0, null);
			}
			return _DownLoadHistoryCollection;
		}
		
		// Return EntityCollection<DownLoadHistoryEntity>
		public EntityCollection<DownLoadHistoryEntity> SelectByCreatedByLST_Paged(string CreatedBy, int PageNumber, int PageSize)
		{
			EntityCollection<DownLoadHistoryEntity> _DownLoadHistoryCollection = new EntityCollection<DownLoadHistoryEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DownLoadHistoryCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DownLoadHistoryCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedByRDT(string CreatedBy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DownLoadHistoryCollection = new EntityCollection(new DownLoadHistoryEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DownLoadHistoryCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedByRDT_Paged(string CreatedBy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DownLoadHistoryCollection = new EntityCollection(new DownLoadHistoryEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DownLoadHistoryCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DownLoadHistoryEntity>
		public EntityCollection<DownLoadHistoryEntity> SelectByUpdatedDateLST(DateTime UpdatedDate)
		{
			EntityCollection<DownLoadHistoryEntity> _DownLoadHistoryCollection = new EntityCollection<DownLoadHistoryEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DownLoadHistoryCollection, filter, 0, null);
			}
			return _DownLoadHistoryCollection;
		}
		
		// Return EntityCollection<DownLoadHistoryEntity>
		public EntityCollection<DownLoadHistoryEntity> SelectByUpdatedDateLST_Paged(DateTime UpdatedDate, int PageNumber, int PageSize)
		{
			EntityCollection<DownLoadHistoryEntity> _DownLoadHistoryCollection = new EntityCollection<DownLoadHistoryEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DownLoadHistoryCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DownLoadHistoryCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedDateRDT(DateTime UpdatedDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DownLoadHistoryCollection = new EntityCollection(new DownLoadHistoryEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DownLoadHistoryCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedDateRDT_Paged(DateTime UpdatedDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DownLoadHistoryCollection = new EntityCollection(new DownLoadHistoryEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DownLoadHistoryCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DownLoadHistoryEntity>
		public EntityCollection<DownLoadHistoryEntity> SelectByUpdatedByLST(string UpdatedBy)
		{
			EntityCollection<DownLoadHistoryEntity> _DownLoadHistoryCollection = new EntityCollection<DownLoadHistoryEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DownLoadHistoryCollection, filter, 0, null);
			}
			return _DownLoadHistoryCollection;
		}
		
		// Return EntityCollection<DownLoadHistoryEntity>
		public EntityCollection<DownLoadHistoryEntity> SelectByUpdatedByLST_Paged(string UpdatedBy, int PageNumber, int PageSize)
		{
			EntityCollection<DownLoadHistoryEntity> _DownLoadHistoryCollection = new EntityCollection<DownLoadHistoryEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DownLoadHistoryCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DownLoadHistoryCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedByRDT(string UpdatedBy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DownLoadHistoryCollection = new EntityCollection(new DownLoadHistoryEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DownLoadHistoryCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedByRDT_Paged(string UpdatedBy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DownLoadHistoryCollection = new EntityCollection(new DownLoadHistoryEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DownLoadHistoryCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DownLoadHistoryEntity>
		public EntityCollection<DownLoadHistoryEntity> SelectByIsDeletedLST(bool IsDeleted)
		{
			EntityCollection<DownLoadHistoryEntity> _DownLoadHistoryCollection = new EntityCollection<DownLoadHistoryEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.IsDeleted == IsDeleted);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DownLoadHistoryCollection, filter, 0, null);
			}
			return _DownLoadHistoryCollection;
		}
		
		// Return EntityCollection<DownLoadHistoryEntity>
		public EntityCollection<DownLoadHistoryEntity> SelectByIsDeletedLST_Paged(bool IsDeleted, int PageNumber, int PageSize)
		{
			EntityCollection<DownLoadHistoryEntity> _DownLoadHistoryCollection = new EntityCollection<DownLoadHistoryEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.IsDeleted == IsDeleted);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DownLoadHistoryCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DownLoadHistoryCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIsDeletedRDT(bool IsDeleted)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DownLoadHistoryCollection = new EntityCollection(new DownLoadHistoryEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.IsDeleted == IsDeleted);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DownLoadHistoryCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIsDeletedRDT_Paged(bool IsDeleted, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DownLoadHistoryCollection = new EntityCollection(new DownLoadHistoryEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DownLoadHistoryFields.IsDeleted == IsDeleted);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DownLoadHistoryCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
