




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.MarkAddHistoryManagerBase
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
	public class MarkAddHistoryManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public MarkAddHistoryManagerBase()
		{
			// Nothing for now.
		}
		
		public MarkAddHistoryEntity Insert(MarkAddHistoryEntity _MarkAddHistoryEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_MarkAddHistoryEntity, true);
			}
			return _MarkAddHistoryEntity;
		}

		
		public MarkAddHistoryEntity Insert(Guid Id, Guid CustomerId, Guid CodeMarkId, DateTime Date, long MarkBeforeAdd, long MarkAfterAdd, DateTime CreatedDate, string CreatedBy, DateTime UpdatedDate, string UpdatedBy, bool IsDeleted)
		{
			MarkAddHistoryEntity _MarkAddHistoryEntity = new MarkAddHistoryEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_MarkAddHistoryEntity.Id = Id;
				_MarkAddHistoryEntity.CustomerId = CustomerId;
				_MarkAddHistoryEntity.CodeMarkId = CodeMarkId;
				_MarkAddHistoryEntity.Date = Date;
				_MarkAddHistoryEntity.MarkBeforeAdd = MarkBeforeAdd;
				_MarkAddHistoryEntity.MarkAfterAdd = MarkAfterAdd;
				_MarkAddHistoryEntity.CreatedDate = CreatedDate;
				_MarkAddHistoryEntity.CreatedBy = CreatedBy;
				_MarkAddHistoryEntity.UpdatedDate = UpdatedDate;
				_MarkAddHistoryEntity.UpdatedBy = UpdatedBy;
				_MarkAddHistoryEntity.IsDeleted = IsDeleted;
				adapter.SaveEntity(_MarkAddHistoryEntity, true);
			}
			return _MarkAddHistoryEntity;
		}

		public MarkAddHistoryEntity Insert(Guid CustomerId, Guid CodeMarkId, DateTime Date, long MarkBeforeAdd, long MarkAfterAdd, DateTime CreatedDate, string CreatedBy, DateTime UpdatedDate, string UpdatedBy, bool IsDeleted)
		{
			MarkAddHistoryEntity _MarkAddHistoryEntity = new MarkAddHistoryEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_MarkAddHistoryEntity.CustomerId = CustomerId;
				_MarkAddHistoryEntity.CodeMarkId = CodeMarkId;
				_MarkAddHistoryEntity.Date = Date;
				_MarkAddHistoryEntity.MarkBeforeAdd = MarkBeforeAdd;
				_MarkAddHistoryEntity.MarkAfterAdd = MarkAfterAdd;
				_MarkAddHistoryEntity.CreatedDate = CreatedDate;
				_MarkAddHistoryEntity.CreatedBy = CreatedBy;
				_MarkAddHistoryEntity.UpdatedDate = UpdatedDate;
				_MarkAddHistoryEntity.UpdatedBy = UpdatedBy;
				_MarkAddHistoryEntity.IsDeleted = IsDeleted;
				adapter.SaveEntity(_MarkAddHistoryEntity, true);
			}
			return _MarkAddHistoryEntity;
		}

		public bool Update(MarkAddHistoryEntity _MarkAddHistoryEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(MarkAddHistoryFields.Id == _MarkAddHistoryEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_MarkAddHistoryEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(MarkAddHistoryEntity _MarkAddHistoryEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_MarkAddHistoryEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, Guid CustomerId, Guid CodeMarkId, DateTime Date, long MarkBeforeAdd, long MarkAfterAdd, DateTime CreatedDate, string CreatedBy, DateTime UpdatedDate, string UpdatedBy, bool IsDeleted)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				MarkAddHistoryEntity _MarkAddHistoryEntity = new MarkAddHistoryEntity(Id);
				if (adapter.FetchEntity(_MarkAddHistoryEntity))
				{
				
					_MarkAddHistoryEntity.CustomerId = CustomerId;
					_MarkAddHistoryEntity.CodeMarkId = CodeMarkId;
					_MarkAddHistoryEntity.Date = Date;
					_MarkAddHistoryEntity.MarkBeforeAdd = MarkBeforeAdd;
					_MarkAddHistoryEntity.MarkAfterAdd = MarkAfterAdd;
					_MarkAddHistoryEntity.CreatedDate = CreatedDate;
					_MarkAddHistoryEntity.CreatedBy = CreatedBy;
					_MarkAddHistoryEntity.UpdatedDate = UpdatedDate;
					_MarkAddHistoryEntity.UpdatedBy = UpdatedBy;
					_MarkAddHistoryEntity.IsDeleted = IsDeleted;
					adapter.SaveEntity(_MarkAddHistoryEntity, true);
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
				MarkAddHistoryEntity _MarkAddHistoryEntity = new MarkAddHistoryEntity(Id);
				if (adapter.FetchEntity(_MarkAddHistoryEntity))
				{
					adapter.DeleteEntity(_MarkAddHistoryEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("MarkAddHistoryEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MarkAddHistoryEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCustomerId(Guid CustomerId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.CustomerId == CustomerId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MarkAddHistoryEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCodeMarkId(Guid CodeMarkId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.CodeMarkId == CodeMarkId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MarkAddHistoryEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByDate(DateTime Date)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.Date == Date);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MarkAddHistoryEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMarkBeforeAdd(long MarkBeforeAdd)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.MarkBeforeAdd == MarkBeforeAdd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MarkAddHistoryEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMarkAfterAdd(long MarkAfterAdd)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.MarkAfterAdd == MarkAfterAdd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MarkAddHistoryEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCreatedDate(DateTime CreatedDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MarkAddHistoryEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCreatedBy(string CreatedBy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MarkAddHistoryEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByUpdatedDate(DateTime UpdatedDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MarkAddHistoryEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByUpdatedBy(string UpdatedBy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MarkAddHistoryEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIsDeleted(bool IsDeleted)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.IsDeleted == IsDeleted);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MarkAddHistoryEntity", filter);
			}
			return toReturn;
		}
		

		
		public MarkAddHistoryEntity SelectOne(Guid Id)
		{
			MarkAddHistoryEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				MarkAddHistoryEntity _MarkAddHistoryEntity = new MarkAddHistoryEntity(Id);
				if (adapter.FetchEntity(_MarkAddHistoryEntity))
				{
					toReturn = _MarkAddHistoryEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MarkAddHistoryCollection = new EntityCollection(new MarkAddHistoryEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MarkAddHistoryCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<MarkAddHistoryEntity>
		public EntityCollection<MarkAddHistoryEntity> SelectAllLST()
		{
			EntityCollection<MarkAddHistoryEntity> _MarkAddHistoryCollection = new EntityCollection<MarkAddHistoryEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MarkAddHistoryCollection, null, 0, null);
			}
			return _MarkAddHistoryCollection;
		}
		
		// Return EntityCollection<MarkAddHistoryEntity>
		public EntityCollection<MarkAddHistoryEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<MarkAddHistoryEntity> _MarkAddHistoryCollection = new EntityCollection<MarkAddHistoryEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MarkAddHistoryCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _MarkAddHistoryCollection;
		}


		
		// Return EntityCollection<MarkAddHistoryEntity>
		public EntityCollection<MarkAddHistoryEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<MarkAddHistoryEntity> _MarkAddHistoryCollection = new EntityCollection<MarkAddHistoryEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MarkAddHistoryCollection, filter, 0, null);
			}
			return _MarkAddHistoryCollection;
		}
		
		// Return EntityCollection<MarkAddHistoryEntity>
		public EntityCollection<MarkAddHistoryEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<MarkAddHistoryEntity> _MarkAddHistoryCollection = new EntityCollection<MarkAddHistoryEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MarkAddHistoryCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _MarkAddHistoryCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MarkAddHistoryCollection = new EntityCollection(new MarkAddHistoryEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MarkAddHistoryCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MarkAddHistoryCollection = new EntityCollection(new MarkAddHistoryEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MarkAddHistoryCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<MarkAddHistoryEntity>
		public EntityCollection<MarkAddHistoryEntity> SelectByCustomerIdLST(Guid CustomerId)
		{
			EntityCollection<MarkAddHistoryEntity> _MarkAddHistoryCollection = new EntityCollection<MarkAddHistoryEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.CustomerId == CustomerId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MarkAddHistoryCollection, filter, 0, null);
			}
			return _MarkAddHistoryCollection;
		}
		
		// Return EntityCollection<MarkAddHistoryEntity>
		public EntityCollection<MarkAddHistoryEntity> SelectByCustomerIdLST_Paged(Guid CustomerId, int PageNumber, int PageSize)
		{
			EntityCollection<MarkAddHistoryEntity> _MarkAddHistoryCollection = new EntityCollection<MarkAddHistoryEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.CustomerId == CustomerId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MarkAddHistoryCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _MarkAddHistoryCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCustomerIdRDT(Guid CustomerId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MarkAddHistoryCollection = new EntityCollection(new MarkAddHistoryEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.CustomerId == CustomerId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MarkAddHistoryCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCustomerIdRDT_Paged(Guid CustomerId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MarkAddHistoryCollection = new EntityCollection(new MarkAddHistoryEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.CustomerId == CustomerId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MarkAddHistoryCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<MarkAddHistoryEntity>
		public EntityCollection<MarkAddHistoryEntity> SelectByCodeMarkIdLST(Guid CodeMarkId)
		{
			EntityCollection<MarkAddHistoryEntity> _MarkAddHistoryCollection = new EntityCollection<MarkAddHistoryEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.CodeMarkId == CodeMarkId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MarkAddHistoryCollection, filter, 0, null);
			}
			return _MarkAddHistoryCollection;
		}
		
		// Return EntityCollection<MarkAddHistoryEntity>
		public EntityCollection<MarkAddHistoryEntity> SelectByCodeMarkIdLST_Paged(Guid CodeMarkId, int PageNumber, int PageSize)
		{
			EntityCollection<MarkAddHistoryEntity> _MarkAddHistoryCollection = new EntityCollection<MarkAddHistoryEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.CodeMarkId == CodeMarkId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MarkAddHistoryCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _MarkAddHistoryCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCodeMarkIdRDT(Guid CodeMarkId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MarkAddHistoryCollection = new EntityCollection(new MarkAddHistoryEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.CodeMarkId == CodeMarkId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MarkAddHistoryCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCodeMarkIdRDT_Paged(Guid CodeMarkId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MarkAddHistoryCollection = new EntityCollection(new MarkAddHistoryEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.CodeMarkId == CodeMarkId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MarkAddHistoryCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<MarkAddHistoryEntity>
		public EntityCollection<MarkAddHistoryEntity> SelectByDateLST(DateTime Date)
		{
			EntityCollection<MarkAddHistoryEntity> _MarkAddHistoryCollection = new EntityCollection<MarkAddHistoryEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.Date == Date);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MarkAddHistoryCollection, filter, 0, null);
			}
			return _MarkAddHistoryCollection;
		}
		
		// Return EntityCollection<MarkAddHistoryEntity>
		public EntityCollection<MarkAddHistoryEntity> SelectByDateLST_Paged(DateTime Date, int PageNumber, int PageSize)
		{
			EntityCollection<MarkAddHistoryEntity> _MarkAddHistoryCollection = new EntityCollection<MarkAddHistoryEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.Date == Date);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MarkAddHistoryCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _MarkAddHistoryCollection;
		}
		
		// Return DataTable
		public DataTable SelectByDateRDT(DateTime Date)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MarkAddHistoryCollection = new EntityCollection(new MarkAddHistoryEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.Date == Date);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MarkAddHistoryCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByDateRDT_Paged(DateTime Date, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MarkAddHistoryCollection = new EntityCollection(new MarkAddHistoryEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.Date == Date);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MarkAddHistoryCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<MarkAddHistoryEntity>
		public EntityCollection<MarkAddHistoryEntity> SelectByMarkBeforeAddLST(long MarkBeforeAdd)
		{
			EntityCollection<MarkAddHistoryEntity> _MarkAddHistoryCollection = new EntityCollection<MarkAddHistoryEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.MarkBeforeAdd == MarkBeforeAdd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MarkAddHistoryCollection, filter, 0, null);
			}
			return _MarkAddHistoryCollection;
		}
		
		// Return EntityCollection<MarkAddHistoryEntity>
		public EntityCollection<MarkAddHistoryEntity> SelectByMarkBeforeAddLST_Paged(long MarkBeforeAdd, int PageNumber, int PageSize)
		{
			EntityCollection<MarkAddHistoryEntity> _MarkAddHistoryCollection = new EntityCollection<MarkAddHistoryEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.MarkBeforeAdd == MarkBeforeAdd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MarkAddHistoryCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _MarkAddHistoryCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMarkBeforeAddRDT(long MarkBeforeAdd)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MarkAddHistoryCollection = new EntityCollection(new MarkAddHistoryEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.MarkBeforeAdd == MarkBeforeAdd);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MarkAddHistoryCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMarkBeforeAddRDT_Paged(long MarkBeforeAdd, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MarkAddHistoryCollection = new EntityCollection(new MarkAddHistoryEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.MarkBeforeAdd == MarkBeforeAdd);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MarkAddHistoryCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<MarkAddHistoryEntity>
		public EntityCollection<MarkAddHistoryEntity> SelectByMarkAfterAddLST(long MarkAfterAdd)
		{
			EntityCollection<MarkAddHistoryEntity> _MarkAddHistoryCollection = new EntityCollection<MarkAddHistoryEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.MarkAfterAdd == MarkAfterAdd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MarkAddHistoryCollection, filter, 0, null);
			}
			return _MarkAddHistoryCollection;
		}
		
		// Return EntityCollection<MarkAddHistoryEntity>
		public EntityCollection<MarkAddHistoryEntity> SelectByMarkAfterAddLST_Paged(long MarkAfterAdd, int PageNumber, int PageSize)
		{
			EntityCollection<MarkAddHistoryEntity> _MarkAddHistoryCollection = new EntityCollection<MarkAddHistoryEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.MarkAfterAdd == MarkAfterAdd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MarkAddHistoryCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _MarkAddHistoryCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMarkAfterAddRDT(long MarkAfterAdd)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MarkAddHistoryCollection = new EntityCollection(new MarkAddHistoryEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.MarkAfterAdd == MarkAfterAdd);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MarkAddHistoryCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMarkAfterAddRDT_Paged(long MarkAfterAdd, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MarkAddHistoryCollection = new EntityCollection(new MarkAddHistoryEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.MarkAfterAdd == MarkAfterAdd);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MarkAddHistoryCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<MarkAddHistoryEntity>
		public EntityCollection<MarkAddHistoryEntity> SelectByCreatedDateLST(DateTime CreatedDate)
		{
			EntityCollection<MarkAddHistoryEntity> _MarkAddHistoryCollection = new EntityCollection<MarkAddHistoryEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MarkAddHistoryCollection, filter, 0, null);
			}
			return _MarkAddHistoryCollection;
		}
		
		// Return EntityCollection<MarkAddHistoryEntity>
		public EntityCollection<MarkAddHistoryEntity> SelectByCreatedDateLST_Paged(DateTime CreatedDate, int PageNumber, int PageSize)
		{
			EntityCollection<MarkAddHistoryEntity> _MarkAddHistoryCollection = new EntityCollection<MarkAddHistoryEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MarkAddHistoryCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _MarkAddHistoryCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedDateRDT(DateTime CreatedDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MarkAddHistoryCollection = new EntityCollection(new MarkAddHistoryEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MarkAddHistoryCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedDateRDT_Paged(DateTime CreatedDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MarkAddHistoryCollection = new EntityCollection(new MarkAddHistoryEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MarkAddHistoryCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<MarkAddHistoryEntity>
		public EntityCollection<MarkAddHistoryEntity> SelectByCreatedByLST(string CreatedBy)
		{
			EntityCollection<MarkAddHistoryEntity> _MarkAddHistoryCollection = new EntityCollection<MarkAddHistoryEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MarkAddHistoryCollection, filter, 0, null);
			}
			return _MarkAddHistoryCollection;
		}
		
		// Return EntityCollection<MarkAddHistoryEntity>
		public EntityCollection<MarkAddHistoryEntity> SelectByCreatedByLST_Paged(string CreatedBy, int PageNumber, int PageSize)
		{
			EntityCollection<MarkAddHistoryEntity> _MarkAddHistoryCollection = new EntityCollection<MarkAddHistoryEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MarkAddHistoryCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _MarkAddHistoryCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedByRDT(string CreatedBy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MarkAddHistoryCollection = new EntityCollection(new MarkAddHistoryEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MarkAddHistoryCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedByRDT_Paged(string CreatedBy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MarkAddHistoryCollection = new EntityCollection(new MarkAddHistoryEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MarkAddHistoryCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<MarkAddHistoryEntity>
		public EntityCollection<MarkAddHistoryEntity> SelectByUpdatedDateLST(DateTime UpdatedDate)
		{
			EntityCollection<MarkAddHistoryEntity> _MarkAddHistoryCollection = new EntityCollection<MarkAddHistoryEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MarkAddHistoryCollection, filter, 0, null);
			}
			return _MarkAddHistoryCollection;
		}
		
		// Return EntityCollection<MarkAddHistoryEntity>
		public EntityCollection<MarkAddHistoryEntity> SelectByUpdatedDateLST_Paged(DateTime UpdatedDate, int PageNumber, int PageSize)
		{
			EntityCollection<MarkAddHistoryEntity> _MarkAddHistoryCollection = new EntityCollection<MarkAddHistoryEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MarkAddHistoryCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _MarkAddHistoryCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedDateRDT(DateTime UpdatedDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MarkAddHistoryCollection = new EntityCollection(new MarkAddHistoryEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MarkAddHistoryCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedDateRDT_Paged(DateTime UpdatedDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MarkAddHistoryCollection = new EntityCollection(new MarkAddHistoryEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MarkAddHistoryCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<MarkAddHistoryEntity>
		public EntityCollection<MarkAddHistoryEntity> SelectByUpdatedByLST(string UpdatedBy)
		{
			EntityCollection<MarkAddHistoryEntity> _MarkAddHistoryCollection = new EntityCollection<MarkAddHistoryEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MarkAddHistoryCollection, filter, 0, null);
			}
			return _MarkAddHistoryCollection;
		}
		
		// Return EntityCollection<MarkAddHistoryEntity>
		public EntityCollection<MarkAddHistoryEntity> SelectByUpdatedByLST_Paged(string UpdatedBy, int PageNumber, int PageSize)
		{
			EntityCollection<MarkAddHistoryEntity> _MarkAddHistoryCollection = new EntityCollection<MarkAddHistoryEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MarkAddHistoryCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _MarkAddHistoryCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedByRDT(string UpdatedBy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MarkAddHistoryCollection = new EntityCollection(new MarkAddHistoryEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MarkAddHistoryCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedByRDT_Paged(string UpdatedBy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MarkAddHistoryCollection = new EntityCollection(new MarkAddHistoryEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MarkAddHistoryCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<MarkAddHistoryEntity>
		public EntityCollection<MarkAddHistoryEntity> SelectByIsDeletedLST(bool IsDeleted)
		{
			EntityCollection<MarkAddHistoryEntity> _MarkAddHistoryCollection = new EntityCollection<MarkAddHistoryEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.IsDeleted == IsDeleted);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MarkAddHistoryCollection, filter, 0, null);
			}
			return _MarkAddHistoryCollection;
		}
		
		// Return EntityCollection<MarkAddHistoryEntity>
		public EntityCollection<MarkAddHistoryEntity> SelectByIsDeletedLST_Paged(bool IsDeleted, int PageNumber, int PageSize)
		{
			EntityCollection<MarkAddHistoryEntity> _MarkAddHistoryCollection = new EntityCollection<MarkAddHistoryEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.IsDeleted == IsDeleted);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MarkAddHistoryCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _MarkAddHistoryCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIsDeletedRDT(bool IsDeleted)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MarkAddHistoryCollection = new EntityCollection(new MarkAddHistoryEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.IsDeleted == IsDeleted);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MarkAddHistoryCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIsDeletedRDT_Paged(bool IsDeleted, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MarkAddHistoryCollection = new EntityCollection(new MarkAddHistoryEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkAddHistoryFields.IsDeleted == IsDeleted);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MarkAddHistoryCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
