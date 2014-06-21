




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.OrdersJoinTagsManagerBase
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
	public class OrdersJoinTagsManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public OrdersJoinTagsManagerBase()
		{
			// Nothing for now.
		}
		
		public OrdersJoinTagsEntity Insert(OrdersJoinTagsEntity _OrdersJoinTagsEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_OrdersJoinTagsEntity, true);
			}
			return _OrdersJoinTagsEntity;
		}

		
		public OrdersJoinTagsEntity Insert(Guid Id, Guid OrderId, string TagId, DateTime CreatedDate)
		{
			OrdersJoinTagsEntity _OrdersJoinTagsEntity = new OrdersJoinTagsEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_OrdersJoinTagsEntity.Id = Id;
				_OrdersJoinTagsEntity.OrderId = OrderId;
				_OrdersJoinTagsEntity.TagId = TagId;
				_OrdersJoinTagsEntity.CreatedDate = CreatedDate;
				adapter.SaveEntity(_OrdersJoinTagsEntity, true);
			}
			return _OrdersJoinTagsEntity;
		}

		public OrdersJoinTagsEntity Insert(Guid OrderId, string TagId, DateTime CreatedDate)
		{
			OrdersJoinTagsEntity _OrdersJoinTagsEntity = new OrdersJoinTagsEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_OrdersJoinTagsEntity.OrderId = OrderId;
				_OrdersJoinTagsEntity.TagId = TagId;
				_OrdersJoinTagsEntity.CreatedDate = CreatedDate;
				adapter.SaveEntity(_OrdersJoinTagsEntity, true);
			}
			return _OrdersJoinTagsEntity;
		}

		public bool Update(OrdersJoinTagsEntity _OrdersJoinTagsEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(OrdersJoinTagsFields.Id == _OrdersJoinTagsEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_OrdersJoinTagsEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(OrdersJoinTagsEntity _OrdersJoinTagsEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_OrdersJoinTagsEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, Guid OrderId, string TagId, DateTime CreatedDate)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				OrdersJoinTagsEntity _OrdersJoinTagsEntity = new OrdersJoinTagsEntity(Id);
				if (adapter.FetchEntity(_OrdersJoinTagsEntity))
				{
				
					_OrdersJoinTagsEntity.OrderId = OrderId;
					_OrdersJoinTagsEntity.TagId = TagId;
					_OrdersJoinTagsEntity.CreatedDate = CreatedDate;
					adapter.SaveEntity(_OrdersJoinTagsEntity, true);
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
				OrdersJoinTagsEntity _OrdersJoinTagsEntity = new OrdersJoinTagsEntity(Id);
				if (adapter.FetchEntity(_OrdersJoinTagsEntity))
				{
					adapter.DeleteEntity(_OrdersJoinTagsEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("OrdersJoinTagsEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersJoinTagsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrdersJoinTagsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByOrderId(Guid OrderId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersJoinTagsFields.OrderId == OrderId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrdersJoinTagsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTagId(string TagId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersJoinTagsFields.TagId == TagId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrdersJoinTagsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCreatedDate(DateTime CreatedDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersJoinTagsFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrdersJoinTagsEntity", filter);
			}
			return toReturn;
		}
		

		
		public OrdersJoinTagsEntity SelectOne(Guid Id)
		{
			OrdersJoinTagsEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				OrdersJoinTagsEntity _OrdersJoinTagsEntity = new OrdersJoinTagsEntity(Id);
				if (adapter.FetchEntity(_OrdersJoinTagsEntity))
				{
					toReturn = _OrdersJoinTagsEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersJoinTagsCollection = new EntityCollection(new OrdersJoinTagsEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersJoinTagsCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<OrdersJoinTagsEntity>
		public EntityCollection<OrdersJoinTagsEntity> SelectAllLST()
		{
			EntityCollection<OrdersJoinTagsEntity> _OrdersJoinTagsCollection = new EntityCollection<OrdersJoinTagsEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersJoinTagsCollection, null, 0, null);
			}
			return _OrdersJoinTagsCollection;
		}
		
		// Return EntityCollection<OrdersJoinTagsEntity>
		public EntityCollection<OrdersJoinTagsEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<OrdersJoinTagsEntity> _OrdersJoinTagsCollection = new EntityCollection<OrdersJoinTagsEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersJoinTagsCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _OrdersJoinTagsCollection;
		}


		
		// Return EntityCollection<OrdersJoinTagsEntity>
		public EntityCollection<OrdersJoinTagsEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<OrdersJoinTagsEntity> _OrdersJoinTagsCollection = new EntityCollection<OrdersJoinTagsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersJoinTagsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersJoinTagsCollection, filter, 0, null);
			}
			return _OrdersJoinTagsCollection;
		}
		
		// Return EntityCollection<OrdersJoinTagsEntity>
		public EntityCollection<OrdersJoinTagsEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<OrdersJoinTagsEntity> _OrdersJoinTagsCollection = new EntityCollection<OrdersJoinTagsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersJoinTagsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersJoinTagsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrdersJoinTagsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersJoinTagsCollection = new EntityCollection(new OrdersJoinTagsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersJoinTagsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersJoinTagsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersJoinTagsCollection = new EntityCollection(new OrdersJoinTagsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersJoinTagsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersJoinTagsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrdersJoinTagsEntity>
		public EntityCollection<OrdersJoinTagsEntity> SelectByOrderIdLST(Guid OrderId)
		{
			EntityCollection<OrdersJoinTagsEntity> _OrdersJoinTagsCollection = new EntityCollection<OrdersJoinTagsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersJoinTagsFields.OrderId == OrderId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersJoinTagsCollection, filter, 0, null);
			}
			return _OrdersJoinTagsCollection;
		}
		
		// Return EntityCollection<OrdersJoinTagsEntity>
		public EntityCollection<OrdersJoinTagsEntity> SelectByOrderIdLST_Paged(Guid OrderId, int PageNumber, int PageSize)
		{
			EntityCollection<OrdersJoinTagsEntity> _OrdersJoinTagsCollection = new EntityCollection<OrdersJoinTagsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersJoinTagsFields.OrderId == OrderId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersJoinTagsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrdersJoinTagsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByOrderIdRDT(Guid OrderId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersJoinTagsCollection = new EntityCollection(new OrdersJoinTagsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersJoinTagsFields.OrderId == OrderId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersJoinTagsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByOrderIdRDT_Paged(Guid OrderId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersJoinTagsCollection = new EntityCollection(new OrdersJoinTagsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersJoinTagsFields.OrderId == OrderId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersJoinTagsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrdersJoinTagsEntity>
		public EntityCollection<OrdersJoinTagsEntity> SelectByTagIdLST(string TagId)
		{
			EntityCollection<OrdersJoinTagsEntity> _OrdersJoinTagsCollection = new EntityCollection<OrdersJoinTagsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersJoinTagsFields.TagId == TagId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersJoinTagsCollection, filter, 0, null);
			}
			return _OrdersJoinTagsCollection;
		}
		
		// Return EntityCollection<OrdersJoinTagsEntity>
		public EntityCollection<OrdersJoinTagsEntity> SelectByTagIdLST_Paged(string TagId, int PageNumber, int PageSize)
		{
			EntityCollection<OrdersJoinTagsEntity> _OrdersJoinTagsCollection = new EntityCollection<OrdersJoinTagsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersJoinTagsFields.TagId == TagId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersJoinTagsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrdersJoinTagsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTagIdRDT(string TagId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersJoinTagsCollection = new EntityCollection(new OrdersJoinTagsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersJoinTagsFields.TagId == TagId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersJoinTagsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTagIdRDT_Paged(string TagId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersJoinTagsCollection = new EntityCollection(new OrdersJoinTagsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersJoinTagsFields.TagId == TagId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersJoinTagsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrdersJoinTagsEntity>
		public EntityCollection<OrdersJoinTagsEntity> SelectByCreatedDateLST(DateTime CreatedDate)
		{
			EntityCollection<OrdersJoinTagsEntity> _OrdersJoinTagsCollection = new EntityCollection<OrdersJoinTagsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersJoinTagsFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersJoinTagsCollection, filter, 0, null);
			}
			return _OrdersJoinTagsCollection;
		}
		
		// Return EntityCollection<OrdersJoinTagsEntity>
		public EntityCollection<OrdersJoinTagsEntity> SelectByCreatedDateLST_Paged(DateTime CreatedDate, int PageNumber, int PageSize)
		{
			EntityCollection<OrdersJoinTagsEntity> _OrdersJoinTagsCollection = new EntityCollection<OrdersJoinTagsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersJoinTagsFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersJoinTagsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrdersJoinTagsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedDateRDT(DateTime CreatedDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersJoinTagsCollection = new EntityCollection(new OrdersJoinTagsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersJoinTagsFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersJoinTagsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedDateRDT_Paged(DateTime CreatedDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersJoinTagsCollection = new EntityCollection(new OrdersJoinTagsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersJoinTagsFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersJoinTagsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
