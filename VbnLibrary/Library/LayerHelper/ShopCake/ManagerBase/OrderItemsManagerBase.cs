




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.OrderItemsManagerBase
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
	public class OrderItemsManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public OrderItemsManagerBase()
		{
			// Nothing for now.
		}
		
		public OrderItemsEntity Insert(OrderItemsEntity _OrderItemsEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_OrderItemsEntity, true);
			}
			return _OrderItemsEntity;
		}

		
		public OrderItemsEntity Insert(Guid Id, Guid OrderId, Guid SupplierId, decimal TotalAmountBeforeTax, decimal TotalAmountAfterTax, decimal TotalDiscount, decimal TotalToSupplier, bool PaidComplete, decimal TotalCommission, string CreatedBy, DateTime CreatedDate, string UpdatedBy, DateTime UpdatedDate)
		{
			OrderItemsEntity _OrderItemsEntity = new OrderItemsEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_OrderItemsEntity.Id = Id;
				_OrderItemsEntity.OrderId = OrderId;
				_OrderItemsEntity.SupplierId = SupplierId;
				_OrderItemsEntity.TotalAmountBeforeTax = TotalAmountBeforeTax;
				_OrderItemsEntity.TotalAmountAfterTax = TotalAmountAfterTax;
				_OrderItemsEntity.TotalDiscount = TotalDiscount;
				_OrderItemsEntity.TotalToSupplier = TotalToSupplier;
				_OrderItemsEntity.PaidComplete = PaidComplete;
				_OrderItemsEntity.TotalCommission = TotalCommission;
				_OrderItemsEntity.CreatedBy = CreatedBy;
				_OrderItemsEntity.CreatedDate = CreatedDate;
				_OrderItemsEntity.UpdatedBy = UpdatedBy;
				_OrderItemsEntity.UpdatedDate = UpdatedDate;
				adapter.SaveEntity(_OrderItemsEntity, true);
			}
			return _OrderItemsEntity;
		}

		public OrderItemsEntity Insert(Guid OrderId, Guid SupplierId, decimal TotalAmountBeforeTax, decimal TotalAmountAfterTax, decimal TotalDiscount, decimal TotalToSupplier, bool PaidComplete, decimal TotalCommission, string CreatedBy, DateTime CreatedDate, string UpdatedBy, DateTime UpdatedDate)
		{
			OrderItemsEntity _OrderItemsEntity = new OrderItemsEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_OrderItemsEntity.OrderId = OrderId;
				_OrderItemsEntity.SupplierId = SupplierId;
				_OrderItemsEntity.TotalAmountBeforeTax = TotalAmountBeforeTax;
				_OrderItemsEntity.TotalAmountAfterTax = TotalAmountAfterTax;
				_OrderItemsEntity.TotalDiscount = TotalDiscount;
				_OrderItemsEntity.TotalToSupplier = TotalToSupplier;
				_OrderItemsEntity.PaidComplete = PaidComplete;
				_OrderItemsEntity.TotalCommission = TotalCommission;
				_OrderItemsEntity.CreatedBy = CreatedBy;
				_OrderItemsEntity.CreatedDate = CreatedDate;
				_OrderItemsEntity.UpdatedBy = UpdatedBy;
				_OrderItemsEntity.UpdatedDate = UpdatedDate;
				adapter.SaveEntity(_OrderItemsEntity, true);
			}
			return _OrderItemsEntity;
		}

		public bool Update(OrderItemsEntity _OrderItemsEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(OrderItemsFields.Id == _OrderItemsEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_OrderItemsEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(OrderItemsEntity _OrderItemsEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_OrderItemsEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, Guid OrderId, Guid SupplierId, decimal TotalAmountBeforeTax, decimal TotalAmountAfterTax, decimal TotalDiscount, decimal TotalToSupplier, bool PaidComplete, decimal TotalCommission, string CreatedBy, DateTime CreatedDate, string UpdatedBy, DateTime UpdatedDate)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				OrderItemsEntity _OrderItemsEntity = new OrderItemsEntity(Id);
				if (adapter.FetchEntity(_OrderItemsEntity))
				{
				
					_OrderItemsEntity.OrderId = OrderId;
					_OrderItemsEntity.SupplierId = SupplierId;
					_OrderItemsEntity.TotalAmountBeforeTax = TotalAmountBeforeTax;
					_OrderItemsEntity.TotalAmountAfterTax = TotalAmountAfterTax;
					_OrderItemsEntity.TotalDiscount = TotalDiscount;
					_OrderItemsEntity.TotalToSupplier = TotalToSupplier;
					_OrderItemsEntity.PaidComplete = PaidComplete;
					_OrderItemsEntity.TotalCommission = TotalCommission;
					_OrderItemsEntity.CreatedBy = CreatedBy;
					_OrderItemsEntity.CreatedDate = CreatedDate;
					_OrderItemsEntity.UpdatedBy = UpdatedBy;
					_OrderItemsEntity.UpdatedDate = UpdatedDate;
					adapter.SaveEntity(_OrderItemsEntity, true);
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
				OrderItemsEntity _OrderItemsEntity = new OrderItemsEntity(Id);
				if (adapter.FetchEntity(_OrderItemsEntity))
				{
					adapter.DeleteEntity(_OrderItemsEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("OrderItemsEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrderItemsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByOrderId(Guid OrderId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.OrderId == OrderId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrderItemsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySupplierId(Guid SupplierId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.SupplierId == SupplierId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrderItemsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTotalAmountBeforeTax(decimal TotalAmountBeforeTax)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.TotalAmountBeforeTax == TotalAmountBeforeTax);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrderItemsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTotalAmountAfterTax(decimal TotalAmountAfterTax)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.TotalAmountAfterTax == TotalAmountAfterTax);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrderItemsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTotalDiscount(decimal TotalDiscount)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.TotalDiscount == TotalDiscount);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrderItemsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTotalToSupplier(decimal TotalToSupplier)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.TotalToSupplier == TotalToSupplier);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrderItemsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPaidComplete(bool PaidComplete)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.PaidComplete == PaidComplete);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrderItemsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTotalCommission(decimal TotalCommission)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.TotalCommission == TotalCommission);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrderItemsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCreatedBy(string CreatedBy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrderItemsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCreatedDate(DateTime CreatedDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrderItemsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByUpdatedBy(string UpdatedBy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrderItemsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByUpdatedDate(DateTime UpdatedDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrderItemsEntity", filter);
			}
			return toReturn;
		}
		

		
		public OrderItemsEntity SelectOne(Guid Id)
		{
			OrderItemsEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				OrderItemsEntity _OrderItemsEntity = new OrderItemsEntity(Id);
				if (adapter.FetchEntity(_OrderItemsEntity))
				{
					toReturn = _OrderItemsEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderItemsCollection = new EntityCollection(new OrderItemsEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderItemsCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<OrderItemsEntity>
		public EntityCollection<OrderItemsEntity> SelectAllLST()
		{
			EntityCollection<OrderItemsEntity> _OrderItemsCollection = new EntityCollection<OrderItemsEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderItemsCollection, null, 0, null);
			}
			return _OrderItemsCollection;
		}
		
		// Return EntityCollection<OrderItemsEntity>
		public EntityCollection<OrderItemsEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<OrderItemsEntity> _OrderItemsCollection = new EntityCollection<OrderItemsEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderItemsCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _OrderItemsCollection;
		}


		
		// Return EntityCollection<OrderItemsEntity>
		public EntityCollection<OrderItemsEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<OrderItemsEntity> _OrderItemsCollection = new EntityCollection<OrderItemsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderItemsCollection, filter, 0, null);
			}
			return _OrderItemsCollection;
		}
		
		// Return EntityCollection<OrderItemsEntity>
		public EntityCollection<OrderItemsEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<OrderItemsEntity> _OrderItemsCollection = new EntityCollection<OrderItemsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderItemsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrderItemsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderItemsCollection = new EntityCollection(new OrderItemsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderItemsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderItemsCollection = new EntityCollection(new OrderItemsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderItemsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrderItemsEntity>
		public EntityCollection<OrderItemsEntity> SelectByOrderIdLST(Guid OrderId)
		{
			EntityCollection<OrderItemsEntity> _OrderItemsCollection = new EntityCollection<OrderItemsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.OrderId == OrderId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderItemsCollection, filter, 0, null);
			}
			return _OrderItemsCollection;
		}
		
		// Return EntityCollection<OrderItemsEntity>
		public EntityCollection<OrderItemsEntity> SelectByOrderIdLST_Paged(Guid OrderId, int PageNumber, int PageSize)
		{
			EntityCollection<OrderItemsEntity> _OrderItemsCollection = new EntityCollection<OrderItemsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.OrderId == OrderId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderItemsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrderItemsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByOrderIdRDT(Guid OrderId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderItemsCollection = new EntityCollection(new OrderItemsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.OrderId == OrderId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderItemsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByOrderIdRDT_Paged(Guid OrderId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderItemsCollection = new EntityCollection(new OrderItemsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.OrderId == OrderId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderItemsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrderItemsEntity>
		public EntityCollection<OrderItemsEntity> SelectBySupplierIdLST(Guid SupplierId)
		{
			EntityCollection<OrderItemsEntity> _OrderItemsCollection = new EntityCollection<OrderItemsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.SupplierId == SupplierId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderItemsCollection, filter, 0, null);
			}
			return _OrderItemsCollection;
		}
		
		// Return EntityCollection<OrderItemsEntity>
		public EntityCollection<OrderItemsEntity> SelectBySupplierIdLST_Paged(Guid SupplierId, int PageNumber, int PageSize)
		{
			EntityCollection<OrderItemsEntity> _OrderItemsCollection = new EntityCollection<OrderItemsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.SupplierId == SupplierId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderItemsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrderItemsCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySupplierIdRDT(Guid SupplierId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderItemsCollection = new EntityCollection(new OrderItemsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.SupplierId == SupplierId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderItemsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySupplierIdRDT_Paged(Guid SupplierId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderItemsCollection = new EntityCollection(new OrderItemsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.SupplierId == SupplierId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderItemsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrderItemsEntity>
		public EntityCollection<OrderItemsEntity> SelectByTotalAmountBeforeTaxLST(decimal TotalAmountBeforeTax)
		{
			EntityCollection<OrderItemsEntity> _OrderItemsCollection = new EntityCollection<OrderItemsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.TotalAmountBeforeTax == TotalAmountBeforeTax);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderItemsCollection, filter, 0, null);
			}
			return _OrderItemsCollection;
		}
		
		// Return EntityCollection<OrderItemsEntity>
		public EntityCollection<OrderItemsEntity> SelectByTotalAmountBeforeTaxLST_Paged(decimal TotalAmountBeforeTax, int PageNumber, int PageSize)
		{
			EntityCollection<OrderItemsEntity> _OrderItemsCollection = new EntityCollection<OrderItemsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.TotalAmountBeforeTax == TotalAmountBeforeTax);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderItemsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrderItemsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTotalAmountBeforeTaxRDT(decimal TotalAmountBeforeTax)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderItemsCollection = new EntityCollection(new OrderItemsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.TotalAmountBeforeTax == TotalAmountBeforeTax);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderItemsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTotalAmountBeforeTaxRDT_Paged(decimal TotalAmountBeforeTax, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderItemsCollection = new EntityCollection(new OrderItemsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.TotalAmountBeforeTax == TotalAmountBeforeTax);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderItemsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrderItemsEntity>
		public EntityCollection<OrderItemsEntity> SelectByTotalAmountAfterTaxLST(decimal TotalAmountAfterTax)
		{
			EntityCollection<OrderItemsEntity> _OrderItemsCollection = new EntityCollection<OrderItemsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.TotalAmountAfterTax == TotalAmountAfterTax);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderItemsCollection, filter, 0, null);
			}
			return _OrderItemsCollection;
		}
		
		// Return EntityCollection<OrderItemsEntity>
		public EntityCollection<OrderItemsEntity> SelectByTotalAmountAfterTaxLST_Paged(decimal TotalAmountAfterTax, int PageNumber, int PageSize)
		{
			EntityCollection<OrderItemsEntity> _OrderItemsCollection = new EntityCollection<OrderItemsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.TotalAmountAfterTax == TotalAmountAfterTax);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderItemsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrderItemsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTotalAmountAfterTaxRDT(decimal TotalAmountAfterTax)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderItemsCollection = new EntityCollection(new OrderItemsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.TotalAmountAfterTax == TotalAmountAfterTax);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderItemsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTotalAmountAfterTaxRDT_Paged(decimal TotalAmountAfterTax, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderItemsCollection = new EntityCollection(new OrderItemsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.TotalAmountAfterTax == TotalAmountAfterTax);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderItemsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrderItemsEntity>
		public EntityCollection<OrderItemsEntity> SelectByTotalDiscountLST(decimal TotalDiscount)
		{
			EntityCollection<OrderItemsEntity> _OrderItemsCollection = new EntityCollection<OrderItemsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.TotalDiscount == TotalDiscount);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderItemsCollection, filter, 0, null);
			}
			return _OrderItemsCollection;
		}
		
		// Return EntityCollection<OrderItemsEntity>
		public EntityCollection<OrderItemsEntity> SelectByTotalDiscountLST_Paged(decimal TotalDiscount, int PageNumber, int PageSize)
		{
			EntityCollection<OrderItemsEntity> _OrderItemsCollection = new EntityCollection<OrderItemsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.TotalDiscount == TotalDiscount);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderItemsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrderItemsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTotalDiscountRDT(decimal TotalDiscount)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderItemsCollection = new EntityCollection(new OrderItemsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.TotalDiscount == TotalDiscount);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderItemsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTotalDiscountRDT_Paged(decimal TotalDiscount, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderItemsCollection = new EntityCollection(new OrderItemsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.TotalDiscount == TotalDiscount);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderItemsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrderItemsEntity>
		public EntityCollection<OrderItemsEntity> SelectByTotalToSupplierLST(decimal TotalToSupplier)
		{
			EntityCollection<OrderItemsEntity> _OrderItemsCollection = new EntityCollection<OrderItemsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.TotalToSupplier == TotalToSupplier);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderItemsCollection, filter, 0, null);
			}
			return _OrderItemsCollection;
		}
		
		// Return EntityCollection<OrderItemsEntity>
		public EntityCollection<OrderItemsEntity> SelectByTotalToSupplierLST_Paged(decimal TotalToSupplier, int PageNumber, int PageSize)
		{
			EntityCollection<OrderItemsEntity> _OrderItemsCollection = new EntityCollection<OrderItemsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.TotalToSupplier == TotalToSupplier);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderItemsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrderItemsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTotalToSupplierRDT(decimal TotalToSupplier)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderItemsCollection = new EntityCollection(new OrderItemsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.TotalToSupplier == TotalToSupplier);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderItemsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTotalToSupplierRDT_Paged(decimal TotalToSupplier, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderItemsCollection = new EntityCollection(new OrderItemsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.TotalToSupplier == TotalToSupplier);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderItemsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrderItemsEntity>
		public EntityCollection<OrderItemsEntity> SelectByPaidCompleteLST(bool PaidComplete)
		{
			EntityCollection<OrderItemsEntity> _OrderItemsCollection = new EntityCollection<OrderItemsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.PaidComplete == PaidComplete);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderItemsCollection, filter, 0, null);
			}
			return _OrderItemsCollection;
		}
		
		// Return EntityCollection<OrderItemsEntity>
		public EntityCollection<OrderItemsEntity> SelectByPaidCompleteLST_Paged(bool PaidComplete, int PageNumber, int PageSize)
		{
			EntityCollection<OrderItemsEntity> _OrderItemsCollection = new EntityCollection<OrderItemsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.PaidComplete == PaidComplete);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderItemsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrderItemsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPaidCompleteRDT(bool PaidComplete)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderItemsCollection = new EntityCollection(new OrderItemsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.PaidComplete == PaidComplete);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderItemsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPaidCompleteRDT_Paged(bool PaidComplete, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderItemsCollection = new EntityCollection(new OrderItemsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.PaidComplete == PaidComplete);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderItemsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrderItemsEntity>
		public EntityCollection<OrderItemsEntity> SelectByTotalCommissionLST(decimal TotalCommission)
		{
			EntityCollection<OrderItemsEntity> _OrderItemsCollection = new EntityCollection<OrderItemsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.TotalCommission == TotalCommission);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderItemsCollection, filter, 0, null);
			}
			return _OrderItemsCollection;
		}
		
		// Return EntityCollection<OrderItemsEntity>
		public EntityCollection<OrderItemsEntity> SelectByTotalCommissionLST_Paged(decimal TotalCommission, int PageNumber, int PageSize)
		{
			EntityCollection<OrderItemsEntity> _OrderItemsCollection = new EntityCollection<OrderItemsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.TotalCommission == TotalCommission);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderItemsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrderItemsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTotalCommissionRDT(decimal TotalCommission)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderItemsCollection = new EntityCollection(new OrderItemsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.TotalCommission == TotalCommission);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderItemsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTotalCommissionRDT_Paged(decimal TotalCommission, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderItemsCollection = new EntityCollection(new OrderItemsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.TotalCommission == TotalCommission);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderItemsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrderItemsEntity>
		public EntityCollection<OrderItemsEntity> SelectByCreatedByLST(string CreatedBy)
		{
			EntityCollection<OrderItemsEntity> _OrderItemsCollection = new EntityCollection<OrderItemsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderItemsCollection, filter, 0, null);
			}
			return _OrderItemsCollection;
		}
		
		// Return EntityCollection<OrderItemsEntity>
		public EntityCollection<OrderItemsEntity> SelectByCreatedByLST_Paged(string CreatedBy, int PageNumber, int PageSize)
		{
			EntityCollection<OrderItemsEntity> _OrderItemsCollection = new EntityCollection<OrderItemsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderItemsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrderItemsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedByRDT(string CreatedBy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderItemsCollection = new EntityCollection(new OrderItemsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderItemsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedByRDT_Paged(string CreatedBy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderItemsCollection = new EntityCollection(new OrderItemsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderItemsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrderItemsEntity>
		public EntityCollection<OrderItemsEntity> SelectByCreatedDateLST(DateTime CreatedDate)
		{
			EntityCollection<OrderItemsEntity> _OrderItemsCollection = new EntityCollection<OrderItemsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderItemsCollection, filter, 0, null);
			}
			return _OrderItemsCollection;
		}
		
		// Return EntityCollection<OrderItemsEntity>
		public EntityCollection<OrderItemsEntity> SelectByCreatedDateLST_Paged(DateTime CreatedDate, int PageNumber, int PageSize)
		{
			EntityCollection<OrderItemsEntity> _OrderItemsCollection = new EntityCollection<OrderItemsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderItemsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrderItemsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedDateRDT(DateTime CreatedDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderItemsCollection = new EntityCollection(new OrderItemsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderItemsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedDateRDT_Paged(DateTime CreatedDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderItemsCollection = new EntityCollection(new OrderItemsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderItemsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrderItemsEntity>
		public EntityCollection<OrderItemsEntity> SelectByUpdatedByLST(string UpdatedBy)
		{
			EntityCollection<OrderItemsEntity> _OrderItemsCollection = new EntityCollection<OrderItemsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderItemsCollection, filter, 0, null);
			}
			return _OrderItemsCollection;
		}
		
		// Return EntityCollection<OrderItemsEntity>
		public EntityCollection<OrderItemsEntity> SelectByUpdatedByLST_Paged(string UpdatedBy, int PageNumber, int PageSize)
		{
			EntityCollection<OrderItemsEntity> _OrderItemsCollection = new EntityCollection<OrderItemsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderItemsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrderItemsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedByRDT(string UpdatedBy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderItemsCollection = new EntityCollection(new OrderItemsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderItemsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedByRDT_Paged(string UpdatedBy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderItemsCollection = new EntityCollection(new OrderItemsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderItemsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrderItemsEntity>
		public EntityCollection<OrderItemsEntity> SelectByUpdatedDateLST(DateTime UpdatedDate)
		{
			EntityCollection<OrderItemsEntity> _OrderItemsCollection = new EntityCollection<OrderItemsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderItemsCollection, filter, 0, null);
			}
			return _OrderItemsCollection;
		}
		
		// Return EntityCollection<OrderItemsEntity>
		public EntityCollection<OrderItemsEntity> SelectByUpdatedDateLST_Paged(DateTime UpdatedDate, int PageNumber, int PageSize)
		{
			EntityCollection<OrderItemsEntity> _OrderItemsCollection = new EntityCollection<OrderItemsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderItemsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrderItemsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedDateRDT(DateTime UpdatedDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderItemsCollection = new EntityCollection(new OrderItemsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderItemsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedDateRDT_Paged(DateTime UpdatedDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderItemsCollection = new EntityCollection(new OrderItemsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderItemsFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderItemsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
