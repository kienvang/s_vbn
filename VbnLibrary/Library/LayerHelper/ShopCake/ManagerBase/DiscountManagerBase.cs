




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.DiscountManagerBase
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
	public class DiscountManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DiscountManagerBase()
		{
			// Nothing for now.
		}
		
		public DiscountEntity Insert(DiscountEntity _DiscountEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_DiscountEntity, true);
			}
			return _DiscountEntity;
		}

		
		public DiscountEntity Insert(Guid Id, string DiscountName, double PercentAmount, long IsActive)
		{
			DiscountEntity _DiscountEntity = new DiscountEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DiscountEntity.Id = Id;
				_DiscountEntity.DiscountName = DiscountName;
				_DiscountEntity.PercentAmount = PercentAmount;
				_DiscountEntity.IsActive = IsActive;
				adapter.SaveEntity(_DiscountEntity, true);
			}
			return _DiscountEntity;
		}

		public DiscountEntity Insert(string DiscountName, double PercentAmount, long IsActive)
		{
			DiscountEntity _DiscountEntity = new DiscountEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DiscountEntity.DiscountName = DiscountName;
				_DiscountEntity.PercentAmount = PercentAmount;
				_DiscountEntity.IsActive = IsActive;
				adapter.SaveEntity(_DiscountEntity, true);
			}
			return _DiscountEntity;
		}

		public bool Update(DiscountEntity _DiscountEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(DiscountFields.Id == _DiscountEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DiscountEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DiscountEntity _DiscountEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DiscountEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string DiscountName, double PercentAmount, long IsActive)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DiscountEntity _DiscountEntity = new DiscountEntity(Id);
				if (adapter.FetchEntity(_DiscountEntity))
				{
				
					_DiscountEntity.DiscountName = DiscountName;
					_DiscountEntity.PercentAmount = PercentAmount;
					_DiscountEntity.IsActive = IsActive;
					adapter.SaveEntity(_DiscountEntity, true);
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
				DiscountEntity _DiscountEntity = new DiscountEntity(Id);
				if (adapter.FetchEntity(_DiscountEntity))
				{
					adapter.DeleteEntity(_DiscountEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DiscountEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiscountFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DiscountEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByDiscountName(string DiscountName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiscountFields.DiscountName == DiscountName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DiscountEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPercentAmount(double PercentAmount)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiscountFields.PercentAmount == PercentAmount);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DiscountEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIsActive(long IsActive)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiscountFields.IsActive == IsActive);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DiscountEntity", filter);
			}
			return toReturn;
		}
		

		
		public DiscountEntity SelectOne(Guid Id)
		{
			DiscountEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DiscountEntity _DiscountEntity = new DiscountEntity(Id);
				if (adapter.FetchEntity(_DiscountEntity))
				{
					toReturn = _DiscountEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiscountCollection = new EntityCollection(new DiscountEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiscountCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<DiscountEntity>
		public EntityCollection<DiscountEntity> SelectAllLST()
		{
			EntityCollection<DiscountEntity> _DiscountCollection = new EntityCollection<DiscountEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiscountCollection, null, 0, null);
			}
			return _DiscountCollection;
		}
		
		// Return EntityCollection<DiscountEntity>
		public EntityCollection<DiscountEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<DiscountEntity> _DiscountCollection = new EntityCollection<DiscountEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiscountCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _DiscountCollection;
		}


		
		// Return EntityCollection<DiscountEntity>
		public EntityCollection<DiscountEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<DiscountEntity> _DiscountCollection = new EntityCollection<DiscountEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiscountFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiscountCollection, filter, 0, null);
			}
			return _DiscountCollection;
		}
		
		// Return EntityCollection<DiscountEntity>
		public EntityCollection<DiscountEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<DiscountEntity> _DiscountCollection = new EntityCollection<DiscountEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiscountFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiscountCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DiscountCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiscountCollection = new EntityCollection(new DiscountEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiscountFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiscountCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiscountCollection = new EntityCollection(new DiscountEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiscountFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiscountCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DiscountEntity>
		public EntityCollection<DiscountEntity> SelectByDiscountNameLST(string DiscountName)
		{
			EntityCollection<DiscountEntity> _DiscountCollection = new EntityCollection<DiscountEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiscountFields.DiscountName == DiscountName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiscountCollection, filter, 0, null);
			}
			return _DiscountCollection;
		}
		
		// Return EntityCollection<DiscountEntity>
		public EntityCollection<DiscountEntity> SelectByDiscountNameLST_Paged(string DiscountName, int PageNumber, int PageSize)
		{
			EntityCollection<DiscountEntity> _DiscountCollection = new EntityCollection<DiscountEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiscountFields.DiscountName == DiscountName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiscountCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DiscountCollection;
		}
		
		// Return DataTable
		public DataTable SelectByDiscountNameRDT(string DiscountName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiscountCollection = new EntityCollection(new DiscountEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiscountFields.DiscountName == DiscountName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiscountCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByDiscountNameRDT_Paged(string DiscountName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiscountCollection = new EntityCollection(new DiscountEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiscountFields.DiscountName == DiscountName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiscountCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DiscountEntity>
		public EntityCollection<DiscountEntity> SelectByPercentAmountLST(double PercentAmount)
		{
			EntityCollection<DiscountEntity> _DiscountCollection = new EntityCollection<DiscountEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiscountFields.PercentAmount == PercentAmount);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiscountCollection, filter, 0, null);
			}
			return _DiscountCollection;
		}
		
		// Return EntityCollection<DiscountEntity>
		public EntityCollection<DiscountEntity> SelectByPercentAmountLST_Paged(double PercentAmount, int PageNumber, int PageSize)
		{
			EntityCollection<DiscountEntity> _DiscountCollection = new EntityCollection<DiscountEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiscountFields.PercentAmount == PercentAmount);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiscountCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DiscountCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPercentAmountRDT(double PercentAmount)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiscountCollection = new EntityCollection(new DiscountEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiscountFields.PercentAmount == PercentAmount);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiscountCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPercentAmountRDT_Paged(double PercentAmount, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiscountCollection = new EntityCollection(new DiscountEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiscountFields.PercentAmount == PercentAmount);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiscountCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DiscountEntity>
		public EntityCollection<DiscountEntity> SelectByIsActiveLST(long IsActive)
		{
			EntityCollection<DiscountEntity> _DiscountCollection = new EntityCollection<DiscountEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiscountFields.IsActive == IsActive);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiscountCollection, filter, 0, null);
			}
			return _DiscountCollection;
		}
		
		// Return EntityCollection<DiscountEntity>
		public EntityCollection<DiscountEntity> SelectByIsActiveLST_Paged(long IsActive, int PageNumber, int PageSize)
		{
			EntityCollection<DiscountEntity> _DiscountCollection = new EntityCollection<DiscountEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiscountFields.IsActive == IsActive);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiscountCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DiscountCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIsActiveRDT(long IsActive)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiscountCollection = new EntityCollection(new DiscountEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiscountFields.IsActive == IsActive);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiscountCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIsActiveRDT_Paged(long IsActive, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiscountCollection = new EntityCollection(new DiscountEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiscountFields.IsActive == IsActive);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiscountCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
