




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.SuppliersManagerBase
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
	public class SuppliersManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public SuppliersManagerBase()
		{
			// Nothing for now.
		}
		
		public SuppliersEntity Insert(SuppliersEntity _SuppliersEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_SuppliersEntity, true);
			}
			return _SuppliersEntity;
		}

		
		public SuppliersEntity Insert(Guid Id, string SupplierCode, string SupplierName, string SupplierTypeId, bool IsVisible, int SortOrder, string PositionId)
		{
			SuppliersEntity _SuppliersEntity = new SuppliersEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_SuppliersEntity.Id = Id;
				_SuppliersEntity.SupplierCode = SupplierCode;
				_SuppliersEntity.SupplierName = SupplierName;
				_SuppliersEntity.SupplierTypeId = SupplierTypeId;
				_SuppliersEntity.IsVisible = IsVisible;
				_SuppliersEntity.SortOrder = SortOrder;
				_SuppliersEntity.PositionId = PositionId;
				adapter.SaveEntity(_SuppliersEntity, true);
			}
			return _SuppliersEntity;
		}

		public SuppliersEntity Insert(string SupplierCode, string SupplierName, string SupplierTypeId, bool IsVisible, int SortOrder, string PositionId)
		{
			SuppliersEntity _SuppliersEntity = new SuppliersEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_SuppliersEntity.SupplierCode = SupplierCode;
				_SuppliersEntity.SupplierName = SupplierName;
				_SuppliersEntity.SupplierTypeId = SupplierTypeId;
				_SuppliersEntity.IsVisible = IsVisible;
				_SuppliersEntity.SortOrder = SortOrder;
				_SuppliersEntity.PositionId = PositionId;
				adapter.SaveEntity(_SuppliersEntity, true);
			}
			return _SuppliersEntity;
		}

		public bool Update(SuppliersEntity _SuppliersEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(SuppliersFields.Id == _SuppliersEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_SuppliersEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(SuppliersEntity _SuppliersEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_SuppliersEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string SupplierCode, string SupplierName, string SupplierTypeId, bool IsVisible, int SortOrder, string PositionId)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				SuppliersEntity _SuppliersEntity = new SuppliersEntity(Id);
				if (adapter.FetchEntity(_SuppliersEntity))
				{
				
					_SuppliersEntity.SupplierCode = SupplierCode;
					_SuppliersEntity.SupplierName = SupplierName;
					_SuppliersEntity.SupplierTypeId = SupplierTypeId;
					_SuppliersEntity.IsVisible = IsVisible;
					_SuppliersEntity.SortOrder = SortOrder;
					_SuppliersEntity.PositionId = PositionId;
					adapter.SaveEntity(_SuppliersEntity, true);
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
				SuppliersEntity _SuppliersEntity = new SuppliersEntity(Id);
				if (adapter.FetchEntity(_SuppliersEntity))
				{
					adapter.DeleteEntity(_SuppliersEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("SuppliersEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SuppliersFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SuppliersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySupplierCode(string SupplierCode)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SuppliersFields.SupplierCode == SupplierCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SuppliersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySupplierName(string SupplierName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SuppliersFields.SupplierName == SupplierName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SuppliersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySupplierTypeId(string SupplierTypeId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SuppliersFields.SupplierTypeId == SupplierTypeId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SuppliersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIsVisible(bool IsVisible)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SuppliersFields.IsVisible == IsVisible);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SuppliersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySortOrder(int SortOrder)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SuppliersFields.SortOrder == SortOrder);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SuppliersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPositionId(string PositionId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SuppliersFields.PositionId == PositionId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SuppliersEntity", filter);
			}
			return toReturn;
		}
		

		
		public SuppliersEntity SelectOne(Guid Id)
		{
			SuppliersEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				SuppliersEntity _SuppliersEntity = new SuppliersEntity(Id);
				if (adapter.FetchEntity(_SuppliersEntity))
				{
					toReturn = _SuppliersEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SuppliersCollection = new EntityCollection(new SuppliersEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SuppliersCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<SuppliersEntity>
		public EntityCollection<SuppliersEntity> SelectAllLST()
		{
			EntityCollection<SuppliersEntity> _SuppliersCollection = new EntityCollection<SuppliersEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SuppliersCollection, null, 0, null);
			}
			return _SuppliersCollection;
		}
		
		// Return EntityCollection<SuppliersEntity>
		public EntityCollection<SuppliersEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<SuppliersEntity> _SuppliersCollection = new EntityCollection<SuppliersEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SuppliersCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _SuppliersCollection;
		}


		
		// Return EntityCollection<SuppliersEntity>
		public EntityCollection<SuppliersEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<SuppliersEntity> _SuppliersCollection = new EntityCollection<SuppliersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SuppliersFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SuppliersCollection, filter, 0, null);
			}
			return _SuppliersCollection;
		}
		
		// Return EntityCollection<SuppliersEntity>
		public EntityCollection<SuppliersEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<SuppliersEntity> _SuppliersCollection = new EntityCollection<SuppliersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SuppliersFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SuppliersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _SuppliersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SuppliersCollection = new EntityCollection(new SuppliersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SuppliersFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SuppliersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SuppliersCollection = new EntityCollection(new SuppliersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SuppliersFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SuppliersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<SuppliersEntity>
		public EntityCollection<SuppliersEntity> SelectBySupplierCodeLST(string SupplierCode)
		{
			EntityCollection<SuppliersEntity> _SuppliersCollection = new EntityCollection<SuppliersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SuppliersFields.SupplierCode == SupplierCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SuppliersCollection, filter, 0, null);
			}
			return _SuppliersCollection;
		}
		
		// Return EntityCollection<SuppliersEntity>
		public EntityCollection<SuppliersEntity> SelectBySupplierCodeLST_Paged(string SupplierCode, int PageNumber, int PageSize)
		{
			EntityCollection<SuppliersEntity> _SuppliersCollection = new EntityCollection<SuppliersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SuppliersFields.SupplierCode == SupplierCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SuppliersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _SuppliersCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySupplierCodeRDT(string SupplierCode)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SuppliersCollection = new EntityCollection(new SuppliersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SuppliersFields.SupplierCode == SupplierCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SuppliersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySupplierCodeRDT_Paged(string SupplierCode, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SuppliersCollection = new EntityCollection(new SuppliersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SuppliersFields.SupplierCode == SupplierCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SuppliersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<SuppliersEntity>
		public EntityCollection<SuppliersEntity> SelectBySupplierNameLST(string SupplierName)
		{
			EntityCollection<SuppliersEntity> _SuppliersCollection = new EntityCollection<SuppliersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SuppliersFields.SupplierName == SupplierName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SuppliersCollection, filter, 0, null);
			}
			return _SuppliersCollection;
		}
		
		// Return EntityCollection<SuppliersEntity>
		public EntityCollection<SuppliersEntity> SelectBySupplierNameLST_Paged(string SupplierName, int PageNumber, int PageSize)
		{
			EntityCollection<SuppliersEntity> _SuppliersCollection = new EntityCollection<SuppliersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SuppliersFields.SupplierName == SupplierName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SuppliersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _SuppliersCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySupplierNameRDT(string SupplierName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SuppliersCollection = new EntityCollection(new SuppliersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SuppliersFields.SupplierName == SupplierName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SuppliersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySupplierNameRDT_Paged(string SupplierName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SuppliersCollection = new EntityCollection(new SuppliersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SuppliersFields.SupplierName == SupplierName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SuppliersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<SuppliersEntity>
		public EntityCollection<SuppliersEntity> SelectBySupplierTypeIdLST(string SupplierTypeId)
		{
			EntityCollection<SuppliersEntity> _SuppliersCollection = new EntityCollection<SuppliersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SuppliersFields.SupplierTypeId == SupplierTypeId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SuppliersCollection, filter, 0, null);
			}
			return _SuppliersCollection;
		}
		
		// Return EntityCollection<SuppliersEntity>
		public EntityCollection<SuppliersEntity> SelectBySupplierTypeIdLST_Paged(string SupplierTypeId, int PageNumber, int PageSize)
		{
			EntityCollection<SuppliersEntity> _SuppliersCollection = new EntityCollection<SuppliersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SuppliersFields.SupplierTypeId == SupplierTypeId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SuppliersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _SuppliersCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySupplierTypeIdRDT(string SupplierTypeId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SuppliersCollection = new EntityCollection(new SuppliersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SuppliersFields.SupplierTypeId == SupplierTypeId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SuppliersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySupplierTypeIdRDT_Paged(string SupplierTypeId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SuppliersCollection = new EntityCollection(new SuppliersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SuppliersFields.SupplierTypeId == SupplierTypeId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SuppliersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<SuppliersEntity>
		public EntityCollection<SuppliersEntity> SelectByIsVisibleLST(bool IsVisible)
		{
			EntityCollection<SuppliersEntity> _SuppliersCollection = new EntityCollection<SuppliersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SuppliersFields.IsVisible == IsVisible);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SuppliersCollection, filter, 0, null);
			}
			return _SuppliersCollection;
		}
		
		// Return EntityCollection<SuppliersEntity>
		public EntityCollection<SuppliersEntity> SelectByIsVisibleLST_Paged(bool IsVisible, int PageNumber, int PageSize)
		{
			EntityCollection<SuppliersEntity> _SuppliersCollection = new EntityCollection<SuppliersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SuppliersFields.IsVisible == IsVisible);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SuppliersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _SuppliersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIsVisibleRDT(bool IsVisible)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SuppliersCollection = new EntityCollection(new SuppliersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SuppliersFields.IsVisible == IsVisible);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SuppliersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIsVisibleRDT_Paged(bool IsVisible, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SuppliersCollection = new EntityCollection(new SuppliersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SuppliersFields.IsVisible == IsVisible);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SuppliersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<SuppliersEntity>
		public EntityCollection<SuppliersEntity> SelectBySortOrderLST(int SortOrder)
		{
			EntityCollection<SuppliersEntity> _SuppliersCollection = new EntityCollection<SuppliersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SuppliersFields.SortOrder == SortOrder);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SuppliersCollection, filter, 0, null);
			}
			return _SuppliersCollection;
		}
		
		// Return EntityCollection<SuppliersEntity>
		public EntityCollection<SuppliersEntity> SelectBySortOrderLST_Paged(int SortOrder, int PageNumber, int PageSize)
		{
			EntityCollection<SuppliersEntity> _SuppliersCollection = new EntityCollection<SuppliersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SuppliersFields.SortOrder == SortOrder);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SuppliersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _SuppliersCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySortOrderRDT(int SortOrder)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SuppliersCollection = new EntityCollection(new SuppliersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SuppliersFields.SortOrder == SortOrder);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SuppliersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySortOrderRDT_Paged(int SortOrder, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SuppliersCollection = new EntityCollection(new SuppliersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SuppliersFields.SortOrder == SortOrder);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SuppliersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<SuppliersEntity>
		public EntityCollection<SuppliersEntity> SelectByPositionIdLST(string PositionId)
		{
			EntityCollection<SuppliersEntity> _SuppliersCollection = new EntityCollection<SuppliersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SuppliersFields.PositionId == PositionId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SuppliersCollection, filter, 0, null);
			}
			return _SuppliersCollection;
		}
		
		// Return EntityCollection<SuppliersEntity>
		public EntityCollection<SuppliersEntity> SelectByPositionIdLST_Paged(string PositionId, int PageNumber, int PageSize)
		{
			EntityCollection<SuppliersEntity> _SuppliersCollection = new EntityCollection<SuppliersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SuppliersFields.PositionId == PositionId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SuppliersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _SuppliersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPositionIdRDT(string PositionId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SuppliersCollection = new EntityCollection(new SuppliersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SuppliersFields.PositionId == PositionId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SuppliersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPositionIdRDT_Paged(string PositionId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SuppliersCollection = new EntityCollection(new SuppliersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SuppliersFields.PositionId == PositionId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SuppliersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
