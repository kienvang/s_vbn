




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.DocumentConfigManagerBase
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
	public class DocumentConfigManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DocumentConfigManagerBase()
		{
			// Nothing for now.
		}
		
		public DocumentConfigEntity Insert(DocumentConfigEntity _DocumentConfigEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_DocumentConfigEntity, true);
			}
			return _DocumentConfigEntity;
		}

		
		public DocumentConfigEntity Insert(Guid Id, string Code, string Description, string Value)
		{
			DocumentConfigEntity _DocumentConfigEntity = new DocumentConfigEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DocumentConfigEntity.Id = Id;
				_DocumentConfigEntity.Code = Code;
				_DocumentConfigEntity.Description = Description;
				_DocumentConfigEntity.Value = Value;
				adapter.SaveEntity(_DocumentConfigEntity, true);
			}
			return _DocumentConfigEntity;
		}

		public DocumentConfigEntity Insert(string Code, string Description, string Value)
		{
			DocumentConfigEntity _DocumentConfigEntity = new DocumentConfigEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DocumentConfigEntity.Code = Code;
				_DocumentConfigEntity.Description = Description;
				_DocumentConfigEntity.Value = Value;
				adapter.SaveEntity(_DocumentConfigEntity, true);
			}
			return _DocumentConfigEntity;
		}

		public bool Update(DocumentConfigEntity _DocumentConfigEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(DocumentConfigFields.Id == _DocumentConfigEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DocumentConfigEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DocumentConfigEntity _DocumentConfigEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DocumentConfigEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string Code, string Description, string Value)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DocumentConfigEntity _DocumentConfigEntity = new DocumentConfigEntity(Id);
				if (adapter.FetchEntity(_DocumentConfigEntity))
				{
				
					_DocumentConfigEntity.Code = Code;
					_DocumentConfigEntity.Description = Description;
					_DocumentConfigEntity.Value = Value;
					adapter.SaveEntity(_DocumentConfigEntity, true);
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
				DocumentConfigEntity _DocumentConfigEntity = new DocumentConfigEntity(Id);
				if (adapter.FetchEntity(_DocumentConfigEntity))
				{
					adapter.DeleteEntity(_DocumentConfigEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DocumentConfigEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentConfigFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DocumentConfigEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCode(string Code)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentConfigFields.Code == Code);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DocumentConfigEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByDescription(string Description)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentConfigFields.Description == Description);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DocumentConfigEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByValue(string Value)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentConfigFields.Value == Value);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DocumentConfigEntity", filter);
			}
			return toReturn;
		}
		

		
		public DocumentConfigEntity SelectOne(Guid Id)
		{
			DocumentConfigEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DocumentConfigEntity _DocumentConfigEntity = new DocumentConfigEntity(Id);
				if (adapter.FetchEntity(_DocumentConfigEntity))
				{
					toReturn = _DocumentConfigEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentConfigCollection = new EntityCollection(new DocumentConfigEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentConfigCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<DocumentConfigEntity>
		public EntityCollection<DocumentConfigEntity> SelectAllLST()
		{
			EntityCollection<DocumentConfigEntity> _DocumentConfigCollection = new EntityCollection<DocumentConfigEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentConfigCollection, null, 0, null);
			}
			return _DocumentConfigCollection;
		}
		
		// Return EntityCollection<DocumentConfigEntity>
		public EntityCollection<DocumentConfigEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<DocumentConfigEntity> _DocumentConfigCollection = new EntityCollection<DocumentConfigEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentConfigCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentConfigCollection;
		}


		
		// Return EntityCollection<DocumentConfigEntity>
		public EntityCollection<DocumentConfigEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<DocumentConfigEntity> _DocumentConfigCollection = new EntityCollection<DocumentConfigEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentConfigFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentConfigCollection, filter, 0, null);
			}
			return _DocumentConfigCollection;
		}
		
		// Return EntityCollection<DocumentConfigEntity>
		public EntityCollection<DocumentConfigEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<DocumentConfigEntity> _DocumentConfigCollection = new EntityCollection<DocumentConfigEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentConfigFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentConfigCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentConfigCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentConfigCollection = new EntityCollection(new DocumentConfigEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentConfigFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentConfigCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentConfigCollection = new EntityCollection(new DocumentConfigEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentConfigFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentConfigCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DocumentConfigEntity>
		public EntityCollection<DocumentConfigEntity> SelectByCodeLST(string Code)
		{
			EntityCollection<DocumentConfigEntity> _DocumentConfigCollection = new EntityCollection<DocumentConfigEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentConfigFields.Code == Code);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentConfigCollection, filter, 0, null);
			}
			return _DocumentConfigCollection;
		}
		
		// Return EntityCollection<DocumentConfigEntity>
		public EntityCollection<DocumentConfigEntity> SelectByCodeLST_Paged(string Code, int PageNumber, int PageSize)
		{
			EntityCollection<DocumentConfigEntity> _DocumentConfigCollection = new EntityCollection<DocumentConfigEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentConfigFields.Code == Code);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentConfigCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentConfigCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCodeRDT(string Code)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentConfigCollection = new EntityCollection(new DocumentConfigEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentConfigFields.Code == Code);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentConfigCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCodeRDT_Paged(string Code, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentConfigCollection = new EntityCollection(new DocumentConfigEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentConfigFields.Code == Code);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentConfigCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DocumentConfigEntity>
		public EntityCollection<DocumentConfigEntity> SelectByDescriptionLST(string Description)
		{
			EntityCollection<DocumentConfigEntity> _DocumentConfigCollection = new EntityCollection<DocumentConfigEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentConfigFields.Description == Description);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentConfigCollection, filter, 0, null);
			}
			return _DocumentConfigCollection;
		}
		
		// Return EntityCollection<DocumentConfigEntity>
		public EntityCollection<DocumentConfigEntity> SelectByDescriptionLST_Paged(string Description, int PageNumber, int PageSize)
		{
			EntityCollection<DocumentConfigEntity> _DocumentConfigCollection = new EntityCollection<DocumentConfigEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentConfigFields.Description == Description);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentConfigCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentConfigCollection;
		}
		
		// Return DataTable
		public DataTable SelectByDescriptionRDT(string Description)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentConfigCollection = new EntityCollection(new DocumentConfigEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentConfigFields.Description == Description);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentConfigCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByDescriptionRDT_Paged(string Description, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentConfigCollection = new EntityCollection(new DocumentConfigEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentConfigFields.Description == Description);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentConfigCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DocumentConfigEntity>
		public EntityCollection<DocumentConfigEntity> SelectByValueLST(string Value)
		{
			EntityCollection<DocumentConfigEntity> _DocumentConfigCollection = new EntityCollection<DocumentConfigEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentConfigFields.Value == Value);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentConfigCollection, filter, 0, null);
			}
			return _DocumentConfigCollection;
		}
		
		// Return EntityCollection<DocumentConfigEntity>
		public EntityCollection<DocumentConfigEntity> SelectByValueLST_Paged(string Value, int PageNumber, int PageSize)
		{
			EntityCollection<DocumentConfigEntity> _DocumentConfigCollection = new EntityCollection<DocumentConfigEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentConfigFields.Value == Value);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentConfigCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentConfigCollection;
		}
		
		// Return DataTable
		public DataTable SelectByValueRDT(string Value)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentConfigCollection = new EntityCollection(new DocumentConfigEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentConfigFields.Value == Value);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentConfigCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByValueRDT_Paged(string Value, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentConfigCollection = new EntityCollection(new DocumentConfigEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentConfigFields.Value == Value);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentConfigCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
