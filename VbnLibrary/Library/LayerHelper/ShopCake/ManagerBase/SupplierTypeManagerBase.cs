




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.SupplierTypeManagerBase
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
	public class SupplierTypeManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public SupplierTypeManagerBase()
		{
			// Nothing for now.
		}
		
		public SupplierTypeEntity Insert(SupplierTypeEntity _SupplierTypeEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_SupplierTypeEntity, true);
			}
			return _SupplierTypeEntity;
		}

		
		public SupplierTypeEntity Insert(string Id, string TypeName)
		{
			SupplierTypeEntity _SupplierTypeEntity = new SupplierTypeEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_SupplierTypeEntity.Id = Id;
				_SupplierTypeEntity.TypeName = TypeName;
				adapter.SaveEntity(_SupplierTypeEntity, true);
			}
			return _SupplierTypeEntity;
		}

		public SupplierTypeEntity Insert(string TypeName)
		{
			SupplierTypeEntity _SupplierTypeEntity = new SupplierTypeEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_SupplierTypeEntity.TypeName = TypeName;
				adapter.SaveEntity(_SupplierTypeEntity, true);
			}
			return _SupplierTypeEntity;
		}

		public bool Update(SupplierTypeEntity _SupplierTypeEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(SupplierTypeFields.Id == _SupplierTypeEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_SupplierTypeEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(SupplierTypeEntity _SupplierTypeEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_SupplierTypeEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(string Id, string TypeName)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				SupplierTypeEntity _SupplierTypeEntity = new SupplierTypeEntity(Id);
				if (adapter.FetchEntity(_SupplierTypeEntity))
				{
				
					_SupplierTypeEntity.TypeName = TypeName;
					adapter.SaveEntity(_SupplierTypeEntity, true);
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
				SupplierTypeEntity _SupplierTypeEntity = new SupplierTypeEntity(Id);
				if (adapter.FetchEntity(_SupplierTypeEntity))
				{
					adapter.DeleteEntity(_SupplierTypeEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("SupplierTypeEntity", null);
			}
		}
		
		
		public int DeleteById(string Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierTypeFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SupplierTypeEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTypeName(string TypeName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierTypeFields.TypeName == TypeName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SupplierTypeEntity", filter);
			}
			return toReturn;
		}
		

		
		public SupplierTypeEntity SelectOne(string Id)
		{
			SupplierTypeEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				SupplierTypeEntity _SupplierTypeEntity = new SupplierTypeEntity(Id);
				if (adapter.FetchEntity(_SupplierTypeEntity))
				{
					toReturn = _SupplierTypeEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierTypeCollection = new EntityCollection(new SupplierTypeEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<SupplierTypeEntity>
		public EntityCollection<SupplierTypeEntity> SelectAllLST()
		{
			EntityCollection<SupplierTypeEntity> _SupplierTypeCollection = new EntityCollection<SupplierTypeEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierTypeCollection, null, 0, null);
			}
			return _SupplierTypeCollection;
		}
		
		// Return EntityCollection<SupplierTypeEntity>
		public EntityCollection<SupplierTypeEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<SupplierTypeEntity> _SupplierTypeCollection = new EntityCollection<SupplierTypeEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierTypeCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _SupplierTypeCollection;
		}


		
		// Return EntityCollection<SupplierTypeEntity>
		public EntityCollection<SupplierTypeEntity> SelectByIdLST(string Id)
		{
			EntityCollection<SupplierTypeEntity> _SupplierTypeCollection = new EntityCollection<SupplierTypeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierTypeFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierTypeCollection, filter, 0, null);
			}
			return _SupplierTypeCollection;
		}
		
		// Return EntityCollection<SupplierTypeEntity>
		public EntityCollection<SupplierTypeEntity> SelectByIdLST_Paged(string Id, int PageNumber, int PageSize)
		{
			EntityCollection<SupplierTypeEntity> _SupplierTypeCollection = new EntityCollection<SupplierTypeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierTypeFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierTypeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _SupplierTypeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(string Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierTypeCollection = new EntityCollection(new SupplierTypeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierTypeFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(string Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierTypeCollection = new EntityCollection(new SupplierTypeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierTypeFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<SupplierTypeEntity>
		public EntityCollection<SupplierTypeEntity> SelectByTypeNameLST(string TypeName)
		{
			EntityCollection<SupplierTypeEntity> _SupplierTypeCollection = new EntityCollection<SupplierTypeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierTypeFields.TypeName == TypeName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierTypeCollection, filter, 0, null);
			}
			return _SupplierTypeCollection;
		}
		
		// Return EntityCollection<SupplierTypeEntity>
		public EntityCollection<SupplierTypeEntity> SelectByTypeNameLST_Paged(string TypeName, int PageNumber, int PageSize)
		{
			EntityCollection<SupplierTypeEntity> _SupplierTypeCollection = new EntityCollection<SupplierTypeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierTypeFields.TypeName == TypeName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierTypeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _SupplierTypeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTypeNameRDT(string TypeName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierTypeCollection = new EntityCollection(new SupplierTypeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierTypeFields.TypeName == TypeName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTypeNameRDT_Paged(string TypeName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierTypeCollection = new EntityCollection(new SupplierTypeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierTypeFields.TypeName == TypeName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
