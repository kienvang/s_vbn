




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.DocumentGroupManagerBase
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
	public class DocumentGroupManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DocumentGroupManagerBase()
		{
			// Nothing for now.
		}
		
		public DocumentGroupEntity Insert(DocumentGroupEntity _DocumentGroupEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_DocumentGroupEntity, true);
			}
			return _DocumentGroupEntity;
		}

		
		public DocumentGroupEntity Insert(Guid Id, long IntId, string GroupName, string GroupCode, string TextId, int OrderIndex, DateTime CreatedDate, string CreatedBy, DateTime UpdatedDate, string UpdatedBy, bool IsDeleted)
		{
			DocumentGroupEntity _DocumentGroupEntity = new DocumentGroupEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DocumentGroupEntity.Id = Id;
				_DocumentGroupEntity.GroupName = GroupName;
				_DocumentGroupEntity.GroupCode = GroupCode;
				_DocumentGroupEntity.TextId = TextId;
				_DocumentGroupEntity.OrderIndex = OrderIndex;
				_DocumentGroupEntity.CreatedDate = CreatedDate;
				_DocumentGroupEntity.CreatedBy = CreatedBy;
				_DocumentGroupEntity.UpdatedDate = UpdatedDate;
				_DocumentGroupEntity.UpdatedBy = UpdatedBy;
				_DocumentGroupEntity.IsDeleted = IsDeleted;
				adapter.SaveEntity(_DocumentGroupEntity, true);
			}
			return _DocumentGroupEntity;
		}

		public DocumentGroupEntity Insert(string GroupName, string GroupCode, string TextId, int OrderIndex, DateTime CreatedDate, string CreatedBy, DateTime UpdatedDate, string UpdatedBy, bool IsDeleted)
		{
			DocumentGroupEntity _DocumentGroupEntity = new DocumentGroupEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DocumentGroupEntity.GroupName = GroupName;
				_DocumentGroupEntity.GroupCode = GroupCode;
				_DocumentGroupEntity.TextId = TextId;
				_DocumentGroupEntity.OrderIndex = OrderIndex;
				_DocumentGroupEntity.CreatedDate = CreatedDate;
				_DocumentGroupEntity.CreatedBy = CreatedBy;
				_DocumentGroupEntity.UpdatedDate = UpdatedDate;
				_DocumentGroupEntity.UpdatedBy = UpdatedBy;
				_DocumentGroupEntity.IsDeleted = IsDeleted;
				adapter.SaveEntity(_DocumentGroupEntity, true);
			}
			return _DocumentGroupEntity;
		}

		public bool Update(DocumentGroupEntity _DocumentGroupEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(DocumentGroupFields.Id == _DocumentGroupEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DocumentGroupEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DocumentGroupEntity _DocumentGroupEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DocumentGroupEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, long IntId, string GroupName, string GroupCode, string TextId, int OrderIndex, DateTime CreatedDate, string CreatedBy, DateTime UpdatedDate, string UpdatedBy, bool IsDeleted)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DocumentGroupEntity _DocumentGroupEntity = new DocumentGroupEntity(Id);
				if (adapter.FetchEntity(_DocumentGroupEntity))
				{
				
					_DocumentGroupEntity.GroupName = GroupName;
					_DocumentGroupEntity.GroupCode = GroupCode;
					_DocumentGroupEntity.TextId = TextId;
					_DocumentGroupEntity.OrderIndex = OrderIndex;
					_DocumentGroupEntity.CreatedDate = CreatedDate;
					_DocumentGroupEntity.CreatedBy = CreatedBy;
					_DocumentGroupEntity.UpdatedDate = UpdatedDate;
					_DocumentGroupEntity.UpdatedBy = UpdatedBy;
					_DocumentGroupEntity.IsDeleted = IsDeleted;
					adapter.SaveEntity(_DocumentGroupEntity, true);
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
				DocumentGroupEntity _DocumentGroupEntity = new DocumentGroupEntity(Id);
				if (adapter.FetchEntity(_DocumentGroupEntity))
				{
					adapter.DeleteEntity(_DocumentGroupEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DocumentGroupEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DocumentGroupEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIntId(long IntId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.IntId == IntId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DocumentGroupEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGroupName(string GroupName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.GroupName == GroupName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DocumentGroupEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGroupCode(string GroupCode)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.GroupCode == GroupCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DocumentGroupEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTextId(string TextId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.TextId == TextId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DocumentGroupEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByOrderIndex(int OrderIndex)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.OrderIndex == OrderIndex);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DocumentGroupEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCreatedDate(DateTime CreatedDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DocumentGroupEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCreatedBy(string CreatedBy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DocumentGroupEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByUpdatedDate(DateTime UpdatedDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DocumentGroupEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByUpdatedBy(string UpdatedBy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DocumentGroupEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIsDeleted(bool IsDeleted)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.IsDeleted == IsDeleted);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DocumentGroupEntity", filter);
			}
			return toReturn;
		}
		

		
		public DocumentGroupEntity SelectOne(Guid Id)
		{
			DocumentGroupEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DocumentGroupEntity _DocumentGroupEntity = new DocumentGroupEntity(Id);
				if (adapter.FetchEntity(_DocumentGroupEntity))
				{
					toReturn = _DocumentGroupEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentGroupCollection = new EntityCollection(new DocumentGroupEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<DocumentGroupEntity>
		public EntityCollection<DocumentGroupEntity> SelectAllLST()
		{
			EntityCollection<DocumentGroupEntity> _DocumentGroupCollection = new EntityCollection<DocumentGroupEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentGroupCollection, null, 0, null);
			}
			return _DocumentGroupCollection;
		}
		
		// Return EntityCollection<DocumentGroupEntity>
		public EntityCollection<DocumentGroupEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<DocumentGroupEntity> _DocumentGroupCollection = new EntityCollection<DocumentGroupEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentGroupCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentGroupCollection;
		}


		
		// Return EntityCollection<DocumentGroupEntity>
		public EntityCollection<DocumentGroupEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<DocumentGroupEntity> _DocumentGroupCollection = new EntityCollection<DocumentGroupEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentGroupCollection, filter, 0, null);
			}
			return _DocumentGroupCollection;
		}
		
		// Return EntityCollection<DocumentGroupEntity>
		public EntityCollection<DocumentGroupEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<DocumentGroupEntity> _DocumentGroupCollection = new EntityCollection<DocumentGroupEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentGroupCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentGroupCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentGroupCollection = new EntityCollection(new DocumentGroupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentGroupCollection = new EntityCollection(new DocumentGroupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DocumentGroupEntity>
		public EntityCollection<DocumentGroupEntity> SelectByIntIdLST(long IntId)
		{
			EntityCollection<DocumentGroupEntity> _DocumentGroupCollection = new EntityCollection<DocumentGroupEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.IntId == IntId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentGroupCollection, filter, 0, null);
			}
			return _DocumentGroupCollection;
		}
		
		// Return EntityCollection<DocumentGroupEntity>
		public EntityCollection<DocumentGroupEntity> SelectByIntIdLST_Paged(long IntId, int PageNumber, int PageSize)
		{
			EntityCollection<DocumentGroupEntity> _DocumentGroupCollection = new EntityCollection<DocumentGroupEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.IntId == IntId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentGroupCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentGroupCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIntIdRDT(long IntId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentGroupCollection = new EntityCollection(new DocumentGroupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.IntId == IntId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIntIdRDT_Paged(long IntId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentGroupCollection = new EntityCollection(new DocumentGroupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.IntId == IntId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DocumentGroupEntity>
		public EntityCollection<DocumentGroupEntity> SelectByGroupNameLST(string GroupName)
		{
			EntityCollection<DocumentGroupEntity> _DocumentGroupCollection = new EntityCollection<DocumentGroupEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.GroupName == GroupName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentGroupCollection, filter, 0, null);
			}
			return _DocumentGroupCollection;
		}
		
		// Return EntityCollection<DocumentGroupEntity>
		public EntityCollection<DocumentGroupEntity> SelectByGroupNameLST_Paged(string GroupName, int PageNumber, int PageSize)
		{
			EntityCollection<DocumentGroupEntity> _DocumentGroupCollection = new EntityCollection<DocumentGroupEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.GroupName == GroupName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentGroupCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentGroupCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGroupNameRDT(string GroupName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentGroupCollection = new EntityCollection(new DocumentGroupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.GroupName == GroupName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGroupNameRDT_Paged(string GroupName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentGroupCollection = new EntityCollection(new DocumentGroupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.GroupName == GroupName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DocumentGroupEntity>
		public EntityCollection<DocumentGroupEntity> SelectByGroupCodeLST(string GroupCode)
		{
			EntityCollection<DocumentGroupEntity> _DocumentGroupCollection = new EntityCollection<DocumentGroupEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.GroupCode == GroupCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentGroupCollection, filter, 0, null);
			}
			return _DocumentGroupCollection;
		}
		
		// Return EntityCollection<DocumentGroupEntity>
		public EntityCollection<DocumentGroupEntity> SelectByGroupCodeLST_Paged(string GroupCode, int PageNumber, int PageSize)
		{
			EntityCollection<DocumentGroupEntity> _DocumentGroupCollection = new EntityCollection<DocumentGroupEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.GroupCode == GroupCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentGroupCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentGroupCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGroupCodeRDT(string GroupCode)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentGroupCollection = new EntityCollection(new DocumentGroupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.GroupCode == GroupCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGroupCodeRDT_Paged(string GroupCode, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentGroupCollection = new EntityCollection(new DocumentGroupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.GroupCode == GroupCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DocumentGroupEntity>
		public EntityCollection<DocumentGroupEntity> SelectByTextIdLST(string TextId)
		{
			EntityCollection<DocumentGroupEntity> _DocumentGroupCollection = new EntityCollection<DocumentGroupEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.TextId == TextId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentGroupCollection, filter, 0, null);
			}
			return _DocumentGroupCollection;
		}
		
		// Return EntityCollection<DocumentGroupEntity>
		public EntityCollection<DocumentGroupEntity> SelectByTextIdLST_Paged(string TextId, int PageNumber, int PageSize)
		{
			EntityCollection<DocumentGroupEntity> _DocumentGroupCollection = new EntityCollection<DocumentGroupEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.TextId == TextId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentGroupCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentGroupCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTextIdRDT(string TextId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentGroupCollection = new EntityCollection(new DocumentGroupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.TextId == TextId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTextIdRDT_Paged(string TextId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentGroupCollection = new EntityCollection(new DocumentGroupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.TextId == TextId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DocumentGroupEntity>
		public EntityCollection<DocumentGroupEntity> SelectByOrderIndexLST(int OrderIndex)
		{
			EntityCollection<DocumentGroupEntity> _DocumentGroupCollection = new EntityCollection<DocumentGroupEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.OrderIndex == OrderIndex);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentGroupCollection, filter, 0, null);
			}
			return _DocumentGroupCollection;
		}
		
		// Return EntityCollection<DocumentGroupEntity>
		public EntityCollection<DocumentGroupEntity> SelectByOrderIndexLST_Paged(int OrderIndex, int PageNumber, int PageSize)
		{
			EntityCollection<DocumentGroupEntity> _DocumentGroupCollection = new EntityCollection<DocumentGroupEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.OrderIndex == OrderIndex);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentGroupCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentGroupCollection;
		}
		
		// Return DataTable
		public DataTable SelectByOrderIndexRDT(int OrderIndex)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentGroupCollection = new EntityCollection(new DocumentGroupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.OrderIndex == OrderIndex);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByOrderIndexRDT_Paged(int OrderIndex, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentGroupCollection = new EntityCollection(new DocumentGroupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.OrderIndex == OrderIndex);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DocumentGroupEntity>
		public EntityCollection<DocumentGroupEntity> SelectByCreatedDateLST(DateTime CreatedDate)
		{
			EntityCollection<DocumentGroupEntity> _DocumentGroupCollection = new EntityCollection<DocumentGroupEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentGroupCollection, filter, 0, null);
			}
			return _DocumentGroupCollection;
		}
		
		// Return EntityCollection<DocumentGroupEntity>
		public EntityCollection<DocumentGroupEntity> SelectByCreatedDateLST_Paged(DateTime CreatedDate, int PageNumber, int PageSize)
		{
			EntityCollection<DocumentGroupEntity> _DocumentGroupCollection = new EntityCollection<DocumentGroupEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentGroupCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentGroupCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedDateRDT(DateTime CreatedDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentGroupCollection = new EntityCollection(new DocumentGroupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedDateRDT_Paged(DateTime CreatedDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentGroupCollection = new EntityCollection(new DocumentGroupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DocumentGroupEntity>
		public EntityCollection<DocumentGroupEntity> SelectByCreatedByLST(string CreatedBy)
		{
			EntityCollection<DocumentGroupEntity> _DocumentGroupCollection = new EntityCollection<DocumentGroupEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentGroupCollection, filter, 0, null);
			}
			return _DocumentGroupCollection;
		}
		
		// Return EntityCollection<DocumentGroupEntity>
		public EntityCollection<DocumentGroupEntity> SelectByCreatedByLST_Paged(string CreatedBy, int PageNumber, int PageSize)
		{
			EntityCollection<DocumentGroupEntity> _DocumentGroupCollection = new EntityCollection<DocumentGroupEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentGroupCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentGroupCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedByRDT(string CreatedBy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentGroupCollection = new EntityCollection(new DocumentGroupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedByRDT_Paged(string CreatedBy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentGroupCollection = new EntityCollection(new DocumentGroupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DocumentGroupEntity>
		public EntityCollection<DocumentGroupEntity> SelectByUpdatedDateLST(DateTime UpdatedDate)
		{
			EntityCollection<DocumentGroupEntity> _DocumentGroupCollection = new EntityCollection<DocumentGroupEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentGroupCollection, filter, 0, null);
			}
			return _DocumentGroupCollection;
		}
		
		// Return EntityCollection<DocumentGroupEntity>
		public EntityCollection<DocumentGroupEntity> SelectByUpdatedDateLST_Paged(DateTime UpdatedDate, int PageNumber, int PageSize)
		{
			EntityCollection<DocumentGroupEntity> _DocumentGroupCollection = new EntityCollection<DocumentGroupEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentGroupCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentGroupCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedDateRDT(DateTime UpdatedDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentGroupCollection = new EntityCollection(new DocumentGroupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedDateRDT_Paged(DateTime UpdatedDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentGroupCollection = new EntityCollection(new DocumentGroupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DocumentGroupEntity>
		public EntityCollection<DocumentGroupEntity> SelectByUpdatedByLST(string UpdatedBy)
		{
			EntityCollection<DocumentGroupEntity> _DocumentGroupCollection = new EntityCollection<DocumentGroupEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentGroupCollection, filter, 0, null);
			}
			return _DocumentGroupCollection;
		}
		
		// Return EntityCollection<DocumentGroupEntity>
		public EntityCollection<DocumentGroupEntity> SelectByUpdatedByLST_Paged(string UpdatedBy, int PageNumber, int PageSize)
		{
			EntityCollection<DocumentGroupEntity> _DocumentGroupCollection = new EntityCollection<DocumentGroupEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentGroupCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentGroupCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedByRDT(string UpdatedBy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentGroupCollection = new EntityCollection(new DocumentGroupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedByRDT_Paged(string UpdatedBy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentGroupCollection = new EntityCollection(new DocumentGroupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DocumentGroupEntity>
		public EntityCollection<DocumentGroupEntity> SelectByIsDeletedLST(bool IsDeleted)
		{
			EntityCollection<DocumentGroupEntity> _DocumentGroupCollection = new EntityCollection<DocumentGroupEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.IsDeleted == IsDeleted);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentGroupCollection, filter, 0, null);
			}
			return _DocumentGroupCollection;
		}
		
		// Return EntityCollection<DocumentGroupEntity>
		public EntityCollection<DocumentGroupEntity> SelectByIsDeletedLST_Paged(bool IsDeleted, int PageNumber, int PageSize)
		{
			EntityCollection<DocumentGroupEntity> _DocumentGroupCollection = new EntityCollection<DocumentGroupEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.IsDeleted == IsDeleted);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentGroupCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentGroupCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIsDeletedRDT(bool IsDeleted)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentGroupCollection = new EntityCollection(new DocumentGroupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.IsDeleted == IsDeleted);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIsDeletedRDT_Paged(bool IsDeleted, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentGroupCollection = new EntityCollection(new DocumentGroupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentGroupFields.IsDeleted == IsDeleted);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
