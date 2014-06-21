




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.ShippingDetailManagerBase
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
	public class ShippingDetailManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public ShippingDetailManagerBase()
		{
			// Nothing for now.
		}
		
		public ShippingDetailEntity Insert(ShippingDetailEntity _ShippingDetailEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_ShippingDetailEntity, true);
			}
			return _ShippingDetailEntity;
		}

		
		public ShippingDetailEntity Insert(Guid Id, Guid ShippingId, Guid OrderDetailId, int Amount)
		{
			ShippingDetailEntity _ShippingDetailEntity = new ShippingDetailEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_ShippingDetailEntity.Id = Id;
				_ShippingDetailEntity.ShippingId = ShippingId;
				_ShippingDetailEntity.OrderDetailId = OrderDetailId;
				_ShippingDetailEntity.Amount = Amount;
				adapter.SaveEntity(_ShippingDetailEntity, true);
			}
			return _ShippingDetailEntity;
		}

		public ShippingDetailEntity Insert(Guid ShippingId, Guid OrderDetailId, int Amount)
		{
			ShippingDetailEntity _ShippingDetailEntity = new ShippingDetailEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_ShippingDetailEntity.ShippingId = ShippingId;
				_ShippingDetailEntity.OrderDetailId = OrderDetailId;
				_ShippingDetailEntity.Amount = Amount;
				adapter.SaveEntity(_ShippingDetailEntity, true);
			}
			return _ShippingDetailEntity;
		}

		public bool Update(ShippingDetailEntity _ShippingDetailEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(ShippingDetailFields.Id == _ShippingDetailEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_ShippingDetailEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(ShippingDetailEntity _ShippingDetailEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_ShippingDetailEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, Guid ShippingId, Guid OrderDetailId, int Amount)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				ShippingDetailEntity _ShippingDetailEntity = new ShippingDetailEntity(Id);
				if (adapter.FetchEntity(_ShippingDetailEntity))
				{
				
					_ShippingDetailEntity.ShippingId = ShippingId;
					_ShippingDetailEntity.OrderDetailId = OrderDetailId;
					_ShippingDetailEntity.Amount = Amount;
					adapter.SaveEntity(_ShippingDetailEntity, true);
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
				ShippingDetailEntity _ShippingDetailEntity = new ShippingDetailEntity(Id);
				if (adapter.FetchEntity(_ShippingDetailEntity))
				{
					adapter.DeleteEntity(_ShippingDetailEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("ShippingDetailEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingDetailFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ShippingDetailEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByShippingId(Guid ShippingId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingDetailFields.ShippingId == ShippingId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ShippingDetailEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByOrderDetailId(Guid OrderDetailId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingDetailFields.OrderDetailId == OrderDetailId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ShippingDetailEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByAmount(int Amount)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingDetailFields.Amount == Amount);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ShippingDetailEntity", filter);
			}
			return toReturn;
		}
		

		
		public ShippingDetailEntity SelectOne(Guid Id)
		{
			ShippingDetailEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				ShippingDetailEntity _ShippingDetailEntity = new ShippingDetailEntity(Id);
				if (adapter.FetchEntity(_ShippingDetailEntity))
				{
					toReturn = _ShippingDetailEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ShippingDetailCollection = new EntityCollection(new ShippingDetailEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ShippingDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<ShippingDetailEntity>
		public EntityCollection<ShippingDetailEntity> SelectAllLST()
		{
			EntityCollection<ShippingDetailEntity> _ShippingDetailCollection = new EntityCollection<ShippingDetailEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ShippingDetailCollection, null, 0, null);
			}
			return _ShippingDetailCollection;
		}
		
		// Return EntityCollection<ShippingDetailEntity>
		public EntityCollection<ShippingDetailEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<ShippingDetailEntity> _ShippingDetailCollection = new EntityCollection<ShippingDetailEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ShippingDetailCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _ShippingDetailCollection;
		}


		
		// Return EntityCollection<ShippingDetailEntity>
		public EntityCollection<ShippingDetailEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<ShippingDetailEntity> _ShippingDetailCollection = new EntityCollection<ShippingDetailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingDetailFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ShippingDetailCollection, filter, 0, null);
			}
			return _ShippingDetailCollection;
		}
		
		// Return EntityCollection<ShippingDetailEntity>
		public EntityCollection<ShippingDetailEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<ShippingDetailEntity> _ShippingDetailCollection = new EntityCollection<ShippingDetailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingDetailFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ShippingDetailCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ShippingDetailCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ShippingDetailCollection = new EntityCollection(new ShippingDetailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingDetailFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ShippingDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ShippingDetailCollection = new EntityCollection(new ShippingDetailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingDetailFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ShippingDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ShippingDetailEntity>
		public EntityCollection<ShippingDetailEntity> SelectByShippingIdLST(Guid ShippingId)
		{
			EntityCollection<ShippingDetailEntity> _ShippingDetailCollection = new EntityCollection<ShippingDetailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingDetailFields.ShippingId == ShippingId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ShippingDetailCollection, filter, 0, null);
			}
			return _ShippingDetailCollection;
		}
		
		// Return EntityCollection<ShippingDetailEntity>
		public EntityCollection<ShippingDetailEntity> SelectByShippingIdLST_Paged(Guid ShippingId, int PageNumber, int PageSize)
		{
			EntityCollection<ShippingDetailEntity> _ShippingDetailCollection = new EntityCollection<ShippingDetailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingDetailFields.ShippingId == ShippingId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ShippingDetailCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ShippingDetailCollection;
		}
		
		// Return DataTable
		public DataTable SelectByShippingIdRDT(Guid ShippingId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ShippingDetailCollection = new EntityCollection(new ShippingDetailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingDetailFields.ShippingId == ShippingId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ShippingDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByShippingIdRDT_Paged(Guid ShippingId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ShippingDetailCollection = new EntityCollection(new ShippingDetailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingDetailFields.ShippingId == ShippingId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ShippingDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ShippingDetailEntity>
		public EntityCollection<ShippingDetailEntity> SelectByOrderDetailIdLST(Guid OrderDetailId)
		{
			EntityCollection<ShippingDetailEntity> _ShippingDetailCollection = new EntityCollection<ShippingDetailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingDetailFields.OrderDetailId == OrderDetailId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ShippingDetailCollection, filter, 0, null);
			}
			return _ShippingDetailCollection;
		}
		
		// Return EntityCollection<ShippingDetailEntity>
		public EntityCollection<ShippingDetailEntity> SelectByOrderDetailIdLST_Paged(Guid OrderDetailId, int PageNumber, int PageSize)
		{
			EntityCollection<ShippingDetailEntity> _ShippingDetailCollection = new EntityCollection<ShippingDetailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingDetailFields.OrderDetailId == OrderDetailId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ShippingDetailCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ShippingDetailCollection;
		}
		
		// Return DataTable
		public DataTable SelectByOrderDetailIdRDT(Guid OrderDetailId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ShippingDetailCollection = new EntityCollection(new ShippingDetailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingDetailFields.OrderDetailId == OrderDetailId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ShippingDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByOrderDetailIdRDT_Paged(Guid OrderDetailId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ShippingDetailCollection = new EntityCollection(new ShippingDetailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingDetailFields.OrderDetailId == OrderDetailId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ShippingDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ShippingDetailEntity>
		public EntityCollection<ShippingDetailEntity> SelectByAmountLST(int Amount)
		{
			EntityCollection<ShippingDetailEntity> _ShippingDetailCollection = new EntityCollection<ShippingDetailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingDetailFields.Amount == Amount);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ShippingDetailCollection, filter, 0, null);
			}
			return _ShippingDetailCollection;
		}
		
		// Return EntityCollection<ShippingDetailEntity>
		public EntityCollection<ShippingDetailEntity> SelectByAmountLST_Paged(int Amount, int PageNumber, int PageSize)
		{
			EntityCollection<ShippingDetailEntity> _ShippingDetailCollection = new EntityCollection<ShippingDetailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingDetailFields.Amount == Amount);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ShippingDetailCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ShippingDetailCollection;
		}
		
		// Return DataTable
		public DataTable SelectByAmountRDT(int Amount)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ShippingDetailCollection = new EntityCollection(new ShippingDetailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingDetailFields.Amount == Amount);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ShippingDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByAmountRDT_Paged(int Amount, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ShippingDetailCollection = new EntityCollection(new ShippingDetailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingDetailFields.Amount == Amount);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ShippingDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
