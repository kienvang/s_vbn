




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.DocumentTypeManagerBase
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
	public class DocumentTypeManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DocumentTypeManagerBase()
		{
			// Nothing for now.
		}
		
		public DocumentTypeEntity Insert(DocumentTypeEntity _DocumentTypeEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_DocumentTypeEntity, true);
			}
			return _DocumentTypeEntity;
		}

		
		public DocumentTypeEntity Insert(Guid Id, string TypeCode, string TypeName, string Description, int DisplayType, DateTime CreatedDate, string CreatedBy, DateTime UpdatedDate, string UpdatedBy, bool IsDeleted)
		{
			DocumentTypeEntity _DocumentTypeEntity = new DocumentTypeEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DocumentTypeEntity.Id = Id;
				_DocumentTypeEntity.TypeCode = TypeCode;
				_DocumentTypeEntity.TypeName = TypeName;
				_DocumentTypeEntity.Description = Description;
				_DocumentTypeEntity.DisplayType = DisplayType;
				_DocumentTypeEntity.CreatedDate = CreatedDate;
				_DocumentTypeEntity.CreatedBy = CreatedBy;
				_DocumentTypeEntity.UpdatedDate = UpdatedDate;
				_DocumentTypeEntity.UpdatedBy = UpdatedBy;
				_DocumentTypeEntity.IsDeleted = IsDeleted;
				adapter.SaveEntity(_DocumentTypeEntity, true);
			}
			return _DocumentTypeEntity;
		}

		public DocumentTypeEntity Insert(string TypeCode, string TypeName, string Description, int DisplayType, DateTime CreatedDate, string CreatedBy, DateTime UpdatedDate, string UpdatedBy, bool IsDeleted)
		{
			DocumentTypeEntity _DocumentTypeEntity = new DocumentTypeEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DocumentTypeEntity.TypeCode = TypeCode;
				_DocumentTypeEntity.TypeName = TypeName;
				_DocumentTypeEntity.Description = Description;
				_DocumentTypeEntity.DisplayType = DisplayType;
				_DocumentTypeEntity.CreatedDate = CreatedDate;
				_DocumentTypeEntity.CreatedBy = CreatedBy;
				_DocumentTypeEntity.UpdatedDate = UpdatedDate;
				_DocumentTypeEntity.UpdatedBy = UpdatedBy;
				_DocumentTypeEntity.IsDeleted = IsDeleted;
				adapter.SaveEntity(_DocumentTypeEntity, true);
			}
			return _DocumentTypeEntity;
		}

		public bool Update(DocumentTypeEntity _DocumentTypeEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(DocumentTypeFields.Id == _DocumentTypeEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DocumentTypeEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DocumentTypeEntity _DocumentTypeEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DocumentTypeEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string TypeCode, string TypeName, string Description, int DisplayType, DateTime CreatedDate, string CreatedBy, DateTime UpdatedDate, string UpdatedBy, bool IsDeleted)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DocumentTypeEntity _DocumentTypeEntity = new DocumentTypeEntity(Id);
				if (adapter.FetchEntity(_DocumentTypeEntity))
				{
				
					_DocumentTypeEntity.TypeCode = TypeCode;
					_DocumentTypeEntity.TypeName = TypeName;
					_DocumentTypeEntity.Description = Description;
					_DocumentTypeEntity.DisplayType = DisplayType;
					_DocumentTypeEntity.CreatedDate = CreatedDate;
					_DocumentTypeEntity.CreatedBy = CreatedBy;
					_DocumentTypeEntity.UpdatedDate = UpdatedDate;
					_DocumentTypeEntity.UpdatedBy = UpdatedBy;
					_DocumentTypeEntity.IsDeleted = IsDeleted;
					adapter.SaveEntity(_DocumentTypeEntity, true);
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
				DocumentTypeEntity _DocumentTypeEntity = new DocumentTypeEntity(Id);
				if (adapter.FetchEntity(_DocumentTypeEntity))
				{
					adapter.DeleteEntity(_DocumentTypeEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DocumentTypeEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DocumentTypeEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTypeCode(string TypeCode)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.TypeCode == TypeCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DocumentTypeEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTypeName(string TypeName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.TypeName == TypeName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DocumentTypeEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByDescription(string Description)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.Description == Description);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DocumentTypeEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByDisplayType(int DisplayType)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.DisplayType == DisplayType);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DocumentTypeEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCreatedDate(DateTime CreatedDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DocumentTypeEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCreatedBy(string CreatedBy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DocumentTypeEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByUpdatedDate(DateTime UpdatedDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DocumentTypeEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByUpdatedBy(string UpdatedBy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DocumentTypeEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIsDeleted(bool IsDeleted)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.IsDeleted == IsDeleted);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DocumentTypeEntity", filter);
			}
			return toReturn;
		}
		

		
		public DocumentTypeEntity SelectOne(Guid Id)
		{
			DocumentTypeEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DocumentTypeEntity _DocumentTypeEntity = new DocumentTypeEntity(Id);
				if (adapter.FetchEntity(_DocumentTypeEntity))
				{
					toReturn = _DocumentTypeEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentTypeCollection = new EntityCollection(new DocumentTypeEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<DocumentTypeEntity>
		public EntityCollection<DocumentTypeEntity> SelectAllLST()
		{
			EntityCollection<DocumentTypeEntity> _DocumentTypeCollection = new EntityCollection<DocumentTypeEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentTypeCollection, null, 0, null);
			}
			return _DocumentTypeCollection;
		}
		
		// Return EntityCollection<DocumentTypeEntity>
		public EntityCollection<DocumentTypeEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<DocumentTypeEntity> _DocumentTypeCollection = new EntityCollection<DocumentTypeEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentTypeCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentTypeCollection;
		}


		
		// Return EntityCollection<DocumentTypeEntity>
		public EntityCollection<DocumentTypeEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<DocumentTypeEntity> _DocumentTypeCollection = new EntityCollection<DocumentTypeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentTypeCollection, filter, 0, null);
			}
			return _DocumentTypeCollection;
		}
		
		// Return EntityCollection<DocumentTypeEntity>
		public EntityCollection<DocumentTypeEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<DocumentTypeEntity> _DocumentTypeCollection = new EntityCollection<DocumentTypeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentTypeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentTypeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentTypeCollection = new EntityCollection(new DocumentTypeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentTypeCollection = new EntityCollection(new DocumentTypeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DocumentTypeEntity>
		public EntityCollection<DocumentTypeEntity> SelectByTypeCodeLST(string TypeCode)
		{
			EntityCollection<DocumentTypeEntity> _DocumentTypeCollection = new EntityCollection<DocumentTypeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.TypeCode == TypeCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentTypeCollection, filter, 0, null);
			}
			return _DocumentTypeCollection;
		}
		
		// Return EntityCollection<DocumentTypeEntity>
		public EntityCollection<DocumentTypeEntity> SelectByTypeCodeLST_Paged(string TypeCode, int PageNumber, int PageSize)
		{
			EntityCollection<DocumentTypeEntity> _DocumentTypeCollection = new EntityCollection<DocumentTypeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.TypeCode == TypeCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentTypeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentTypeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTypeCodeRDT(string TypeCode)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentTypeCollection = new EntityCollection(new DocumentTypeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.TypeCode == TypeCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTypeCodeRDT_Paged(string TypeCode, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentTypeCollection = new EntityCollection(new DocumentTypeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.TypeCode == TypeCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DocumentTypeEntity>
		public EntityCollection<DocumentTypeEntity> SelectByTypeNameLST(string TypeName)
		{
			EntityCollection<DocumentTypeEntity> _DocumentTypeCollection = new EntityCollection<DocumentTypeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.TypeName == TypeName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentTypeCollection, filter, 0, null);
			}
			return _DocumentTypeCollection;
		}
		
		// Return EntityCollection<DocumentTypeEntity>
		public EntityCollection<DocumentTypeEntity> SelectByTypeNameLST_Paged(string TypeName, int PageNumber, int PageSize)
		{
			EntityCollection<DocumentTypeEntity> _DocumentTypeCollection = new EntityCollection<DocumentTypeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.TypeName == TypeName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentTypeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentTypeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTypeNameRDT(string TypeName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentTypeCollection = new EntityCollection(new DocumentTypeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.TypeName == TypeName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTypeNameRDT_Paged(string TypeName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentTypeCollection = new EntityCollection(new DocumentTypeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.TypeName == TypeName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DocumentTypeEntity>
		public EntityCollection<DocumentTypeEntity> SelectByDescriptionLST(string Description)
		{
			EntityCollection<DocumentTypeEntity> _DocumentTypeCollection = new EntityCollection<DocumentTypeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.Description == Description);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentTypeCollection, filter, 0, null);
			}
			return _DocumentTypeCollection;
		}
		
		// Return EntityCollection<DocumentTypeEntity>
		public EntityCollection<DocumentTypeEntity> SelectByDescriptionLST_Paged(string Description, int PageNumber, int PageSize)
		{
			EntityCollection<DocumentTypeEntity> _DocumentTypeCollection = new EntityCollection<DocumentTypeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.Description == Description);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentTypeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentTypeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByDescriptionRDT(string Description)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentTypeCollection = new EntityCollection(new DocumentTypeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.Description == Description);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByDescriptionRDT_Paged(string Description, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentTypeCollection = new EntityCollection(new DocumentTypeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.Description == Description);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DocumentTypeEntity>
		public EntityCollection<DocumentTypeEntity> SelectByDisplayTypeLST(int DisplayType)
		{
			EntityCollection<DocumentTypeEntity> _DocumentTypeCollection = new EntityCollection<DocumentTypeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.DisplayType == DisplayType);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentTypeCollection, filter, 0, null);
			}
			return _DocumentTypeCollection;
		}
		
		// Return EntityCollection<DocumentTypeEntity>
		public EntityCollection<DocumentTypeEntity> SelectByDisplayTypeLST_Paged(int DisplayType, int PageNumber, int PageSize)
		{
			EntityCollection<DocumentTypeEntity> _DocumentTypeCollection = new EntityCollection<DocumentTypeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.DisplayType == DisplayType);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentTypeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentTypeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByDisplayTypeRDT(int DisplayType)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentTypeCollection = new EntityCollection(new DocumentTypeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.DisplayType == DisplayType);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByDisplayTypeRDT_Paged(int DisplayType, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentTypeCollection = new EntityCollection(new DocumentTypeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.DisplayType == DisplayType);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DocumentTypeEntity>
		public EntityCollection<DocumentTypeEntity> SelectByCreatedDateLST(DateTime CreatedDate)
		{
			EntityCollection<DocumentTypeEntity> _DocumentTypeCollection = new EntityCollection<DocumentTypeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentTypeCollection, filter, 0, null);
			}
			return _DocumentTypeCollection;
		}
		
		// Return EntityCollection<DocumentTypeEntity>
		public EntityCollection<DocumentTypeEntity> SelectByCreatedDateLST_Paged(DateTime CreatedDate, int PageNumber, int PageSize)
		{
			EntityCollection<DocumentTypeEntity> _DocumentTypeCollection = new EntityCollection<DocumentTypeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentTypeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentTypeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedDateRDT(DateTime CreatedDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentTypeCollection = new EntityCollection(new DocumentTypeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedDateRDT_Paged(DateTime CreatedDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentTypeCollection = new EntityCollection(new DocumentTypeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DocumentTypeEntity>
		public EntityCollection<DocumentTypeEntity> SelectByCreatedByLST(string CreatedBy)
		{
			EntityCollection<DocumentTypeEntity> _DocumentTypeCollection = new EntityCollection<DocumentTypeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentTypeCollection, filter, 0, null);
			}
			return _DocumentTypeCollection;
		}
		
		// Return EntityCollection<DocumentTypeEntity>
		public EntityCollection<DocumentTypeEntity> SelectByCreatedByLST_Paged(string CreatedBy, int PageNumber, int PageSize)
		{
			EntityCollection<DocumentTypeEntity> _DocumentTypeCollection = new EntityCollection<DocumentTypeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentTypeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentTypeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedByRDT(string CreatedBy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentTypeCollection = new EntityCollection(new DocumentTypeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedByRDT_Paged(string CreatedBy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentTypeCollection = new EntityCollection(new DocumentTypeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DocumentTypeEntity>
		public EntityCollection<DocumentTypeEntity> SelectByUpdatedDateLST(DateTime UpdatedDate)
		{
			EntityCollection<DocumentTypeEntity> _DocumentTypeCollection = new EntityCollection<DocumentTypeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentTypeCollection, filter, 0, null);
			}
			return _DocumentTypeCollection;
		}
		
		// Return EntityCollection<DocumentTypeEntity>
		public EntityCollection<DocumentTypeEntity> SelectByUpdatedDateLST_Paged(DateTime UpdatedDate, int PageNumber, int PageSize)
		{
			EntityCollection<DocumentTypeEntity> _DocumentTypeCollection = new EntityCollection<DocumentTypeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentTypeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentTypeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedDateRDT(DateTime UpdatedDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentTypeCollection = new EntityCollection(new DocumentTypeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedDateRDT_Paged(DateTime UpdatedDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentTypeCollection = new EntityCollection(new DocumentTypeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DocumentTypeEntity>
		public EntityCollection<DocumentTypeEntity> SelectByUpdatedByLST(string UpdatedBy)
		{
			EntityCollection<DocumentTypeEntity> _DocumentTypeCollection = new EntityCollection<DocumentTypeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentTypeCollection, filter, 0, null);
			}
			return _DocumentTypeCollection;
		}
		
		// Return EntityCollection<DocumentTypeEntity>
		public EntityCollection<DocumentTypeEntity> SelectByUpdatedByLST_Paged(string UpdatedBy, int PageNumber, int PageSize)
		{
			EntityCollection<DocumentTypeEntity> _DocumentTypeCollection = new EntityCollection<DocumentTypeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentTypeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentTypeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedByRDT(string UpdatedBy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentTypeCollection = new EntityCollection(new DocumentTypeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedByRDT_Paged(string UpdatedBy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentTypeCollection = new EntityCollection(new DocumentTypeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DocumentTypeEntity>
		public EntityCollection<DocumentTypeEntity> SelectByIsDeletedLST(bool IsDeleted)
		{
			EntityCollection<DocumentTypeEntity> _DocumentTypeCollection = new EntityCollection<DocumentTypeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.IsDeleted == IsDeleted);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentTypeCollection, filter, 0, null);
			}
			return _DocumentTypeCollection;
		}
		
		// Return EntityCollection<DocumentTypeEntity>
		public EntityCollection<DocumentTypeEntity> SelectByIsDeletedLST_Paged(bool IsDeleted, int PageNumber, int PageSize)
		{
			EntityCollection<DocumentTypeEntity> _DocumentTypeCollection = new EntityCollection<DocumentTypeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.IsDeleted == IsDeleted);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentTypeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentTypeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIsDeletedRDT(bool IsDeleted)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentTypeCollection = new EntityCollection(new DocumentTypeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.IsDeleted == IsDeleted);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIsDeletedRDT_Paged(bool IsDeleted, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentTypeCollection = new EntityCollection(new DocumentTypeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentTypeFields.IsDeleted == IsDeleted);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
