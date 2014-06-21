




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.SupplierAccountManagerBase
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
	public class SupplierAccountManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public SupplierAccountManagerBase()
		{
			// Nothing for now.
		}
		
		public SupplierAccountEntity Insert(SupplierAccountEntity _SupplierAccountEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_SupplierAccountEntity, true);
			}
			return _SupplierAccountEntity;
		}

		
		public SupplierAccountEntity Insert(Guid SupplierId, string UserName, bool IsFullAccess)
		{
			SupplierAccountEntity _SupplierAccountEntity = new SupplierAccountEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_SupplierAccountEntity.SupplierId = SupplierId;
				_SupplierAccountEntity.UserName = UserName;
				_SupplierAccountEntity.IsFullAccess = IsFullAccess;
				adapter.SaveEntity(_SupplierAccountEntity, true);
			}
			return _SupplierAccountEntity;
		}

		public SupplierAccountEntity Insert(bool IsFullAccess)
		{
			SupplierAccountEntity _SupplierAccountEntity = new SupplierAccountEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_SupplierAccountEntity.IsFullAccess = IsFullAccess;
				adapter.SaveEntity(_SupplierAccountEntity, true);
			}
			return _SupplierAccountEntity;
		}

		public bool Update(SupplierAccountEntity _SupplierAccountEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(SupplierAccountFields.SupplierId == _SupplierAccountEntity.SupplierId);
					_PredicateExpression.Add(SupplierAccountFields.UserName == _SupplierAccountEntity.UserName);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_SupplierAccountEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(SupplierAccountEntity _SupplierAccountEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_SupplierAccountEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid SupplierId, string UserName, bool IsFullAccess)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				SupplierAccountEntity _SupplierAccountEntity = new SupplierAccountEntity(SupplierId, UserName);
				if (adapter.FetchEntity(_SupplierAccountEntity))
				{
				
					_SupplierAccountEntity.IsFullAccess = IsFullAccess;
					adapter.SaveEntity(_SupplierAccountEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(Guid SupplierId, string UserName)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				SupplierAccountEntity _SupplierAccountEntity = new SupplierAccountEntity(SupplierId, UserName);
				if (adapter.FetchEntity(_SupplierAccountEntity))
				{
					adapter.DeleteEntity(_SupplierAccountEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("SupplierAccountEntity", null);
			}
		}
		
		
		public int DeleteBySupplierId(Guid SupplierId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierAccountFields.SupplierId == SupplierId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SupplierAccountEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByUserName(string UserName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierAccountFields.UserName == UserName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SupplierAccountEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIsFullAccess(bool IsFullAccess)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierAccountFields.IsFullAccess == IsFullAccess);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SupplierAccountEntity", filter);
			}
			return toReturn;
		}
		

		
		public SupplierAccountEntity SelectOne(Guid SupplierId, string UserName)
		{
			SupplierAccountEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				SupplierAccountEntity _SupplierAccountEntity = new SupplierAccountEntity(SupplierId, UserName);
				if (adapter.FetchEntity(_SupplierAccountEntity))
				{
					toReturn = _SupplierAccountEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierAccountCollection = new EntityCollection(new SupplierAccountEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierAccountCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<SupplierAccountEntity>
		public EntityCollection<SupplierAccountEntity> SelectAllLST()
		{
			EntityCollection<SupplierAccountEntity> _SupplierAccountCollection = new EntityCollection<SupplierAccountEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierAccountCollection, null, 0, null);
			}
			return _SupplierAccountCollection;
		}
		
		// Return EntityCollection<SupplierAccountEntity>
		public EntityCollection<SupplierAccountEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<SupplierAccountEntity> _SupplierAccountCollection = new EntityCollection<SupplierAccountEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierAccountCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _SupplierAccountCollection;
		}


		
		// Return EntityCollection<SupplierAccountEntity>
		public EntityCollection<SupplierAccountEntity> SelectBySupplierIdLST(Guid SupplierId)
		{
			EntityCollection<SupplierAccountEntity> _SupplierAccountCollection = new EntityCollection<SupplierAccountEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierAccountFields.SupplierId == SupplierId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierAccountCollection, filter, 0, null);
			}
			return _SupplierAccountCollection;
		}
		
		// Return EntityCollection<SupplierAccountEntity>
		public EntityCollection<SupplierAccountEntity> SelectBySupplierIdLST_Paged(Guid SupplierId, int PageNumber, int PageSize)
		{
			EntityCollection<SupplierAccountEntity> _SupplierAccountCollection = new EntityCollection<SupplierAccountEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierAccountFields.SupplierId == SupplierId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierAccountCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _SupplierAccountCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySupplierIdRDT(Guid SupplierId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierAccountCollection = new EntityCollection(new SupplierAccountEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierAccountFields.SupplierId == SupplierId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierAccountCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySupplierIdRDT_Paged(Guid SupplierId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierAccountCollection = new EntityCollection(new SupplierAccountEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierAccountFields.SupplierId == SupplierId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierAccountCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<SupplierAccountEntity>
		public EntityCollection<SupplierAccountEntity> SelectByUserNameLST(string UserName)
		{
			EntityCollection<SupplierAccountEntity> _SupplierAccountCollection = new EntityCollection<SupplierAccountEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierAccountFields.UserName == UserName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierAccountCollection, filter, 0, null);
			}
			return _SupplierAccountCollection;
		}
		
		// Return EntityCollection<SupplierAccountEntity>
		public EntityCollection<SupplierAccountEntity> SelectByUserNameLST_Paged(string UserName, int PageNumber, int PageSize)
		{
			EntityCollection<SupplierAccountEntity> _SupplierAccountCollection = new EntityCollection<SupplierAccountEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierAccountFields.UserName == UserName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierAccountCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _SupplierAccountCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUserNameRDT(string UserName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierAccountCollection = new EntityCollection(new SupplierAccountEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierAccountFields.UserName == UserName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierAccountCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUserNameRDT_Paged(string UserName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierAccountCollection = new EntityCollection(new SupplierAccountEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierAccountFields.UserName == UserName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierAccountCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<SupplierAccountEntity>
		public EntityCollection<SupplierAccountEntity> SelectByIsFullAccessLST(bool IsFullAccess)
		{
			EntityCollection<SupplierAccountEntity> _SupplierAccountCollection = new EntityCollection<SupplierAccountEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierAccountFields.IsFullAccess == IsFullAccess);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierAccountCollection, filter, 0, null);
			}
			return _SupplierAccountCollection;
		}
		
		// Return EntityCollection<SupplierAccountEntity>
		public EntityCollection<SupplierAccountEntity> SelectByIsFullAccessLST_Paged(bool IsFullAccess, int PageNumber, int PageSize)
		{
			EntityCollection<SupplierAccountEntity> _SupplierAccountCollection = new EntityCollection<SupplierAccountEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierAccountFields.IsFullAccess == IsFullAccess);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierAccountCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _SupplierAccountCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIsFullAccessRDT(bool IsFullAccess)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierAccountCollection = new EntityCollection(new SupplierAccountEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierAccountFields.IsFullAccess == IsFullAccess);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierAccountCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIsFullAccessRDT_Paged(bool IsFullAccess, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierAccountCollection = new EntityCollection(new SupplierAccountEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierAccountFields.IsFullAccess == IsFullAccess);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierAccountCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
