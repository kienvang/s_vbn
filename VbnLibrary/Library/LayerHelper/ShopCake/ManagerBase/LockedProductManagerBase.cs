




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.LockedProductManagerBase
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
	public class LockedProductManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LockedProductManagerBase()
		{
			// Nothing for now.
		}
		
		public LockedProductEntity Insert(LockedProductEntity _LockedProductEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_LockedProductEntity, true);
			}
			return _LockedProductEntity;
		}

		
		public LockedProductEntity Insert(Guid Id, Guid ProductId, int Quantity, DateTime LockedDate, int LockedTime)
		{
			LockedProductEntity _LockedProductEntity = new LockedProductEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_LockedProductEntity.Id = Id;
				_LockedProductEntity.ProductId = ProductId;
				_LockedProductEntity.Quantity = Quantity;
				_LockedProductEntity.LockedDate = LockedDate;
				_LockedProductEntity.LockedTime = LockedTime;
				adapter.SaveEntity(_LockedProductEntity, true);
			}
			return _LockedProductEntity;
		}

		public LockedProductEntity Insert(Guid ProductId, int Quantity, DateTime LockedDate, int LockedTime)
		{
			LockedProductEntity _LockedProductEntity = new LockedProductEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_LockedProductEntity.ProductId = ProductId;
				_LockedProductEntity.Quantity = Quantity;
				_LockedProductEntity.LockedDate = LockedDate;
				_LockedProductEntity.LockedTime = LockedTime;
				adapter.SaveEntity(_LockedProductEntity, true);
			}
			return _LockedProductEntity;
		}

		public bool Update(LockedProductEntity _LockedProductEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(LockedProductFields.Id == _LockedProductEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_LockedProductEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(LockedProductEntity _LockedProductEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_LockedProductEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, Guid ProductId, int Quantity, DateTime LockedDate, int LockedTime)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				LockedProductEntity _LockedProductEntity = new LockedProductEntity(Id);
				if (adapter.FetchEntity(_LockedProductEntity))
				{
				
					_LockedProductEntity.ProductId = ProductId;
					_LockedProductEntity.Quantity = Quantity;
					_LockedProductEntity.LockedDate = LockedDate;
					_LockedProductEntity.LockedTime = LockedTime;
					adapter.SaveEntity(_LockedProductEntity, true);
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
				LockedProductEntity _LockedProductEntity = new LockedProductEntity(Id);
				if (adapter.FetchEntity(_LockedProductEntity))
				{
					adapter.DeleteEntity(_LockedProductEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("LockedProductEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LockedProductFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LockedProductEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByProductId(Guid ProductId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LockedProductFields.ProductId == ProductId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LockedProductEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByQuantity(int Quantity)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LockedProductFields.Quantity == Quantity);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LockedProductEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLockedDate(DateTime LockedDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LockedProductFields.LockedDate == LockedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LockedProductEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLockedTime(int LockedTime)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LockedProductFields.LockedTime == LockedTime);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LockedProductEntity", filter);
			}
			return toReturn;
		}
		

		
		public LockedProductEntity SelectOne(Guid Id)
		{
			LockedProductEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				LockedProductEntity _LockedProductEntity = new LockedProductEntity(Id);
				if (adapter.FetchEntity(_LockedProductEntity))
				{
					toReturn = _LockedProductEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LockedProductCollection = new EntityCollection(new LockedProductEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LockedProductCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<LockedProductEntity>
		public EntityCollection<LockedProductEntity> SelectAllLST()
		{
			EntityCollection<LockedProductEntity> _LockedProductCollection = new EntityCollection<LockedProductEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LockedProductCollection, null, 0, null);
			}
			return _LockedProductCollection;
		}
		
		// Return EntityCollection<LockedProductEntity>
		public EntityCollection<LockedProductEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<LockedProductEntity> _LockedProductCollection = new EntityCollection<LockedProductEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LockedProductCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _LockedProductCollection;
		}


		
		// Return EntityCollection<LockedProductEntity>
		public EntityCollection<LockedProductEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<LockedProductEntity> _LockedProductCollection = new EntityCollection<LockedProductEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LockedProductFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LockedProductCollection, filter, 0, null);
			}
			return _LockedProductCollection;
		}
		
		// Return EntityCollection<LockedProductEntity>
		public EntityCollection<LockedProductEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<LockedProductEntity> _LockedProductCollection = new EntityCollection<LockedProductEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LockedProductFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LockedProductCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LockedProductCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LockedProductCollection = new EntityCollection(new LockedProductEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LockedProductFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LockedProductCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LockedProductCollection = new EntityCollection(new LockedProductEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LockedProductFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LockedProductCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LockedProductEntity>
		public EntityCollection<LockedProductEntity> SelectByProductIdLST(Guid ProductId)
		{
			EntityCollection<LockedProductEntity> _LockedProductCollection = new EntityCollection<LockedProductEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LockedProductFields.ProductId == ProductId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LockedProductCollection, filter, 0, null);
			}
			return _LockedProductCollection;
		}
		
		// Return EntityCollection<LockedProductEntity>
		public EntityCollection<LockedProductEntity> SelectByProductIdLST_Paged(Guid ProductId, int PageNumber, int PageSize)
		{
			EntityCollection<LockedProductEntity> _LockedProductCollection = new EntityCollection<LockedProductEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LockedProductFields.ProductId == ProductId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LockedProductCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LockedProductCollection;
		}
		
		// Return DataTable
		public DataTable SelectByProductIdRDT(Guid ProductId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LockedProductCollection = new EntityCollection(new LockedProductEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LockedProductFields.ProductId == ProductId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LockedProductCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByProductIdRDT_Paged(Guid ProductId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LockedProductCollection = new EntityCollection(new LockedProductEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LockedProductFields.ProductId == ProductId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LockedProductCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LockedProductEntity>
		public EntityCollection<LockedProductEntity> SelectByQuantityLST(int Quantity)
		{
			EntityCollection<LockedProductEntity> _LockedProductCollection = new EntityCollection<LockedProductEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LockedProductFields.Quantity == Quantity);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LockedProductCollection, filter, 0, null);
			}
			return _LockedProductCollection;
		}
		
		// Return EntityCollection<LockedProductEntity>
		public EntityCollection<LockedProductEntity> SelectByQuantityLST_Paged(int Quantity, int PageNumber, int PageSize)
		{
			EntityCollection<LockedProductEntity> _LockedProductCollection = new EntityCollection<LockedProductEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LockedProductFields.Quantity == Quantity);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LockedProductCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LockedProductCollection;
		}
		
		// Return DataTable
		public DataTable SelectByQuantityRDT(int Quantity)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LockedProductCollection = new EntityCollection(new LockedProductEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LockedProductFields.Quantity == Quantity);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LockedProductCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByQuantityRDT_Paged(int Quantity, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LockedProductCollection = new EntityCollection(new LockedProductEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LockedProductFields.Quantity == Quantity);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LockedProductCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LockedProductEntity>
		public EntityCollection<LockedProductEntity> SelectByLockedDateLST(DateTime LockedDate)
		{
			EntityCollection<LockedProductEntity> _LockedProductCollection = new EntityCollection<LockedProductEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LockedProductFields.LockedDate == LockedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LockedProductCollection, filter, 0, null);
			}
			return _LockedProductCollection;
		}
		
		// Return EntityCollection<LockedProductEntity>
		public EntityCollection<LockedProductEntity> SelectByLockedDateLST_Paged(DateTime LockedDate, int PageNumber, int PageSize)
		{
			EntityCollection<LockedProductEntity> _LockedProductCollection = new EntityCollection<LockedProductEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LockedProductFields.LockedDate == LockedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LockedProductCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LockedProductCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLockedDateRDT(DateTime LockedDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LockedProductCollection = new EntityCollection(new LockedProductEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LockedProductFields.LockedDate == LockedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LockedProductCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLockedDateRDT_Paged(DateTime LockedDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LockedProductCollection = new EntityCollection(new LockedProductEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LockedProductFields.LockedDate == LockedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LockedProductCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LockedProductEntity>
		public EntityCollection<LockedProductEntity> SelectByLockedTimeLST(int LockedTime)
		{
			EntityCollection<LockedProductEntity> _LockedProductCollection = new EntityCollection<LockedProductEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LockedProductFields.LockedTime == LockedTime);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LockedProductCollection, filter, 0, null);
			}
			return _LockedProductCollection;
		}
		
		// Return EntityCollection<LockedProductEntity>
		public EntityCollection<LockedProductEntity> SelectByLockedTimeLST_Paged(int LockedTime, int PageNumber, int PageSize)
		{
			EntityCollection<LockedProductEntity> _LockedProductCollection = new EntityCollection<LockedProductEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LockedProductFields.LockedTime == LockedTime);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LockedProductCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LockedProductCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLockedTimeRDT(int LockedTime)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LockedProductCollection = new EntityCollection(new LockedProductEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LockedProductFields.LockedTime == LockedTime);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LockedProductCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLockedTimeRDT_Paged(int LockedTime, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LockedProductCollection = new EntityCollection(new LockedProductEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LockedProductFields.LockedTime == LockedTime);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LockedProductCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
