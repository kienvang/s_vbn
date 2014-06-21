




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.OrdersManagerBase
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
	public class OrdersManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public OrdersManagerBase()
		{
			// Nothing for now.
		}
		
		public OrdersEntity Insert(OrdersEntity _OrdersEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_OrdersEntity, true);
			}
			return _OrdersEntity;
		}

		
		public OrdersEntity Insert(Guid Id, string OrderCode, Guid CustomerId, string CustomerName, string CustomerEmail, string CustomerPhone, string CustomerAddress, decimal TotalAmountBeforeTax, decimal TotalAmountAfterTax, decimal TotalDiscount, decimal TotalOther, decimal TotalPaid, bool PaidCompleted, decimal TotalAllSupplier, decimal TotalCommission, string PaymentMethod, string CreatedBy, DateTime CreatedDate, string UpdatedBy, DateTime UpdatedDate, bool IsDelete)
		{
			OrdersEntity _OrdersEntity = new OrdersEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_OrdersEntity.Id = Id;
				_OrdersEntity.OrderCode = OrderCode;
				_OrdersEntity.CustomerId = CustomerId;
				_OrdersEntity.CustomerName = CustomerName;
				_OrdersEntity.CustomerEmail = CustomerEmail;
				_OrdersEntity.CustomerPhone = CustomerPhone;
				_OrdersEntity.CustomerAddress = CustomerAddress;
				_OrdersEntity.TotalAmountBeforeTax = TotalAmountBeforeTax;
				_OrdersEntity.TotalAmountAfterTax = TotalAmountAfterTax;
				_OrdersEntity.TotalDiscount = TotalDiscount;
				_OrdersEntity.TotalOther = TotalOther;
				_OrdersEntity.TotalPaid = TotalPaid;
				_OrdersEntity.PaidCompleted = PaidCompleted;
				_OrdersEntity.TotalAllSupplier = TotalAllSupplier;
				_OrdersEntity.TotalCommission = TotalCommission;
				_OrdersEntity.PaymentMethod = PaymentMethod;
				_OrdersEntity.CreatedBy = CreatedBy;
				_OrdersEntity.CreatedDate = CreatedDate;
				_OrdersEntity.UpdatedBy = UpdatedBy;
				_OrdersEntity.UpdatedDate = UpdatedDate;
				_OrdersEntity.IsDelete = IsDelete;
				adapter.SaveEntity(_OrdersEntity, true);
			}
			return _OrdersEntity;
		}

		public OrdersEntity Insert(string OrderCode, Guid CustomerId, string CustomerName, string CustomerEmail, string CustomerPhone, string CustomerAddress, decimal TotalAmountBeforeTax, decimal TotalAmountAfterTax, decimal TotalDiscount, decimal TotalOther, decimal TotalPaid, bool PaidCompleted, decimal TotalAllSupplier, decimal TotalCommission, string PaymentMethod, string CreatedBy, DateTime CreatedDate, string UpdatedBy, DateTime UpdatedDate, bool IsDelete)
		{
			OrdersEntity _OrdersEntity = new OrdersEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_OrdersEntity.OrderCode = OrderCode;
				_OrdersEntity.CustomerId = CustomerId;
				_OrdersEntity.CustomerName = CustomerName;
				_OrdersEntity.CustomerEmail = CustomerEmail;
				_OrdersEntity.CustomerPhone = CustomerPhone;
				_OrdersEntity.CustomerAddress = CustomerAddress;
				_OrdersEntity.TotalAmountBeforeTax = TotalAmountBeforeTax;
				_OrdersEntity.TotalAmountAfterTax = TotalAmountAfterTax;
				_OrdersEntity.TotalDiscount = TotalDiscount;
				_OrdersEntity.TotalOther = TotalOther;
				_OrdersEntity.TotalPaid = TotalPaid;
				_OrdersEntity.PaidCompleted = PaidCompleted;
				_OrdersEntity.TotalAllSupplier = TotalAllSupplier;
				_OrdersEntity.TotalCommission = TotalCommission;
				_OrdersEntity.PaymentMethod = PaymentMethod;
				_OrdersEntity.CreatedBy = CreatedBy;
				_OrdersEntity.CreatedDate = CreatedDate;
				_OrdersEntity.UpdatedBy = UpdatedBy;
				_OrdersEntity.UpdatedDate = UpdatedDate;
				_OrdersEntity.IsDelete = IsDelete;
				adapter.SaveEntity(_OrdersEntity, true);
			}
			return _OrdersEntity;
		}

		public bool Update(OrdersEntity _OrdersEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(OrdersFields.Id == _OrdersEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_OrdersEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(OrdersEntity _OrdersEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_OrdersEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string OrderCode, Guid CustomerId, string CustomerName, string CustomerEmail, string CustomerPhone, string CustomerAddress, decimal TotalAmountBeforeTax, decimal TotalAmountAfterTax, decimal TotalDiscount, decimal TotalOther, decimal TotalPaid, bool PaidCompleted, decimal TotalAllSupplier, decimal TotalCommission, string PaymentMethod, string CreatedBy, DateTime CreatedDate, string UpdatedBy, DateTime UpdatedDate, bool IsDelete)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				OrdersEntity _OrdersEntity = new OrdersEntity(Id);
				if (adapter.FetchEntity(_OrdersEntity))
				{
				
					_OrdersEntity.OrderCode = OrderCode;
					_OrdersEntity.CustomerId = CustomerId;
					_OrdersEntity.CustomerName = CustomerName;
					_OrdersEntity.CustomerEmail = CustomerEmail;
					_OrdersEntity.CustomerPhone = CustomerPhone;
					_OrdersEntity.CustomerAddress = CustomerAddress;
					_OrdersEntity.TotalAmountBeforeTax = TotalAmountBeforeTax;
					_OrdersEntity.TotalAmountAfterTax = TotalAmountAfterTax;
					_OrdersEntity.TotalDiscount = TotalDiscount;
					_OrdersEntity.TotalOther = TotalOther;
					_OrdersEntity.TotalPaid = TotalPaid;
					_OrdersEntity.PaidCompleted = PaidCompleted;
					_OrdersEntity.TotalAllSupplier = TotalAllSupplier;
					_OrdersEntity.TotalCommission = TotalCommission;
					_OrdersEntity.PaymentMethod = PaymentMethod;
					_OrdersEntity.CreatedBy = CreatedBy;
					_OrdersEntity.CreatedDate = CreatedDate;
					_OrdersEntity.UpdatedBy = UpdatedBy;
					_OrdersEntity.UpdatedDate = UpdatedDate;
					_OrdersEntity.IsDelete = IsDelete;
					adapter.SaveEntity(_OrdersEntity, true);
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
				OrdersEntity _OrdersEntity = new OrdersEntity(Id);
				if (adapter.FetchEntity(_OrdersEntity))
				{
					adapter.DeleteEntity(_OrdersEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("OrdersEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrdersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByOrderCode(string OrderCode)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.OrderCode == OrderCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrdersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCustomerId(Guid CustomerId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.CustomerId == CustomerId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrdersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCustomerName(string CustomerName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.CustomerName == CustomerName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrdersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCustomerEmail(string CustomerEmail)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.CustomerEmail == CustomerEmail);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrdersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCustomerPhone(string CustomerPhone)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.CustomerPhone == CustomerPhone);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrdersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCustomerAddress(string CustomerAddress)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.CustomerAddress == CustomerAddress);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrdersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTotalAmountBeforeTax(decimal TotalAmountBeforeTax)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.TotalAmountBeforeTax == TotalAmountBeforeTax);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrdersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTotalAmountAfterTax(decimal TotalAmountAfterTax)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.TotalAmountAfterTax == TotalAmountAfterTax);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrdersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTotalDiscount(decimal TotalDiscount)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.TotalDiscount == TotalDiscount);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrdersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTotalOther(decimal TotalOther)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.TotalOther == TotalOther);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrdersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTotalPaid(decimal TotalPaid)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.TotalPaid == TotalPaid);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrdersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPaidCompleted(bool PaidCompleted)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.PaidCompleted == PaidCompleted);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrdersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTotalAllSupplier(decimal TotalAllSupplier)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.TotalAllSupplier == TotalAllSupplier);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrdersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTotalCommission(decimal TotalCommission)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.TotalCommission == TotalCommission);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrdersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPaymentMethod(string PaymentMethod)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.PaymentMethod == PaymentMethod);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrdersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCreatedBy(string CreatedBy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrdersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCreatedDate(DateTime CreatedDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrdersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByUpdatedBy(string UpdatedBy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrdersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByUpdatedDate(DateTime UpdatedDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrdersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIsDelete(bool IsDelete)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.IsDelete == IsDelete);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrdersEntity", filter);
			}
			return toReturn;
		}
		

		
		public OrdersEntity SelectOne(Guid Id)
		{
			OrdersEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				OrdersEntity _OrdersEntity = new OrdersEntity(Id);
				if (adapter.FetchEntity(_OrdersEntity))
				{
					toReturn = _OrdersEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersCollection = new EntityCollection(new OrdersEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<OrdersEntity>
		public EntityCollection<OrdersEntity> SelectAllLST()
		{
			EntityCollection<OrdersEntity> _OrdersCollection = new EntityCollection<OrdersEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersCollection, null, 0, null);
			}
			return _OrdersCollection;
		}
		
		// Return EntityCollection<OrdersEntity>
		public EntityCollection<OrdersEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<OrdersEntity> _OrdersCollection = new EntityCollection<OrdersEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _OrdersCollection;
		}


		
		// Return EntityCollection<OrdersEntity>
		public EntityCollection<OrdersEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<OrdersEntity> _OrdersCollection = new EntityCollection<OrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersCollection, filter, 0, null);
			}
			return _OrdersCollection;
		}
		
		// Return EntityCollection<OrdersEntity>
		public EntityCollection<OrdersEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<OrdersEntity> _OrdersCollection = new EntityCollection<OrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrdersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersCollection = new EntityCollection(new OrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersCollection = new EntityCollection(new OrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrdersEntity>
		public EntityCollection<OrdersEntity> SelectByOrderCodeLST(string OrderCode)
		{
			EntityCollection<OrdersEntity> _OrdersCollection = new EntityCollection<OrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.OrderCode == OrderCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersCollection, filter, 0, null);
			}
			return _OrdersCollection;
		}
		
		// Return EntityCollection<OrdersEntity>
		public EntityCollection<OrdersEntity> SelectByOrderCodeLST_Paged(string OrderCode, int PageNumber, int PageSize)
		{
			EntityCollection<OrdersEntity> _OrdersCollection = new EntityCollection<OrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.OrderCode == OrderCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrdersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByOrderCodeRDT(string OrderCode)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersCollection = new EntityCollection(new OrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.OrderCode == OrderCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByOrderCodeRDT_Paged(string OrderCode, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersCollection = new EntityCollection(new OrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.OrderCode == OrderCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrdersEntity>
		public EntityCollection<OrdersEntity> SelectByCustomerIdLST(Guid CustomerId)
		{
			EntityCollection<OrdersEntity> _OrdersCollection = new EntityCollection<OrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.CustomerId == CustomerId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersCollection, filter, 0, null);
			}
			return _OrdersCollection;
		}
		
		// Return EntityCollection<OrdersEntity>
		public EntityCollection<OrdersEntity> SelectByCustomerIdLST_Paged(Guid CustomerId, int PageNumber, int PageSize)
		{
			EntityCollection<OrdersEntity> _OrdersCollection = new EntityCollection<OrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.CustomerId == CustomerId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrdersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCustomerIdRDT(Guid CustomerId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersCollection = new EntityCollection(new OrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.CustomerId == CustomerId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCustomerIdRDT_Paged(Guid CustomerId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersCollection = new EntityCollection(new OrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.CustomerId == CustomerId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrdersEntity>
		public EntityCollection<OrdersEntity> SelectByCustomerNameLST(string CustomerName)
		{
			EntityCollection<OrdersEntity> _OrdersCollection = new EntityCollection<OrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.CustomerName == CustomerName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersCollection, filter, 0, null);
			}
			return _OrdersCollection;
		}
		
		// Return EntityCollection<OrdersEntity>
		public EntityCollection<OrdersEntity> SelectByCustomerNameLST_Paged(string CustomerName, int PageNumber, int PageSize)
		{
			EntityCollection<OrdersEntity> _OrdersCollection = new EntityCollection<OrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.CustomerName == CustomerName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrdersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCustomerNameRDT(string CustomerName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersCollection = new EntityCollection(new OrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.CustomerName == CustomerName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCustomerNameRDT_Paged(string CustomerName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersCollection = new EntityCollection(new OrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.CustomerName == CustomerName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrdersEntity>
		public EntityCollection<OrdersEntity> SelectByCustomerEmailLST(string CustomerEmail)
		{
			EntityCollection<OrdersEntity> _OrdersCollection = new EntityCollection<OrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.CustomerEmail == CustomerEmail);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersCollection, filter, 0, null);
			}
			return _OrdersCollection;
		}
		
		// Return EntityCollection<OrdersEntity>
		public EntityCollection<OrdersEntity> SelectByCustomerEmailLST_Paged(string CustomerEmail, int PageNumber, int PageSize)
		{
			EntityCollection<OrdersEntity> _OrdersCollection = new EntityCollection<OrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.CustomerEmail == CustomerEmail);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrdersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCustomerEmailRDT(string CustomerEmail)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersCollection = new EntityCollection(new OrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.CustomerEmail == CustomerEmail);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCustomerEmailRDT_Paged(string CustomerEmail, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersCollection = new EntityCollection(new OrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.CustomerEmail == CustomerEmail);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrdersEntity>
		public EntityCollection<OrdersEntity> SelectByCustomerPhoneLST(string CustomerPhone)
		{
			EntityCollection<OrdersEntity> _OrdersCollection = new EntityCollection<OrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.CustomerPhone == CustomerPhone);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersCollection, filter, 0, null);
			}
			return _OrdersCollection;
		}
		
		// Return EntityCollection<OrdersEntity>
		public EntityCollection<OrdersEntity> SelectByCustomerPhoneLST_Paged(string CustomerPhone, int PageNumber, int PageSize)
		{
			EntityCollection<OrdersEntity> _OrdersCollection = new EntityCollection<OrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.CustomerPhone == CustomerPhone);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrdersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCustomerPhoneRDT(string CustomerPhone)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersCollection = new EntityCollection(new OrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.CustomerPhone == CustomerPhone);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCustomerPhoneRDT_Paged(string CustomerPhone, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersCollection = new EntityCollection(new OrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.CustomerPhone == CustomerPhone);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrdersEntity>
		public EntityCollection<OrdersEntity> SelectByCustomerAddressLST(string CustomerAddress)
		{
			EntityCollection<OrdersEntity> _OrdersCollection = new EntityCollection<OrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.CustomerAddress == CustomerAddress);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersCollection, filter, 0, null);
			}
			return _OrdersCollection;
		}
		
		// Return EntityCollection<OrdersEntity>
		public EntityCollection<OrdersEntity> SelectByCustomerAddressLST_Paged(string CustomerAddress, int PageNumber, int PageSize)
		{
			EntityCollection<OrdersEntity> _OrdersCollection = new EntityCollection<OrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.CustomerAddress == CustomerAddress);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrdersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCustomerAddressRDT(string CustomerAddress)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersCollection = new EntityCollection(new OrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.CustomerAddress == CustomerAddress);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCustomerAddressRDT_Paged(string CustomerAddress, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersCollection = new EntityCollection(new OrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.CustomerAddress == CustomerAddress);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrdersEntity>
		public EntityCollection<OrdersEntity> SelectByTotalAmountBeforeTaxLST(decimal TotalAmountBeforeTax)
		{
			EntityCollection<OrdersEntity> _OrdersCollection = new EntityCollection<OrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.TotalAmountBeforeTax == TotalAmountBeforeTax);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersCollection, filter, 0, null);
			}
			return _OrdersCollection;
		}
		
		// Return EntityCollection<OrdersEntity>
		public EntityCollection<OrdersEntity> SelectByTotalAmountBeforeTaxLST_Paged(decimal TotalAmountBeforeTax, int PageNumber, int PageSize)
		{
			EntityCollection<OrdersEntity> _OrdersCollection = new EntityCollection<OrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.TotalAmountBeforeTax == TotalAmountBeforeTax);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrdersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTotalAmountBeforeTaxRDT(decimal TotalAmountBeforeTax)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersCollection = new EntityCollection(new OrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.TotalAmountBeforeTax == TotalAmountBeforeTax);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTotalAmountBeforeTaxRDT_Paged(decimal TotalAmountBeforeTax, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersCollection = new EntityCollection(new OrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.TotalAmountBeforeTax == TotalAmountBeforeTax);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrdersEntity>
		public EntityCollection<OrdersEntity> SelectByTotalAmountAfterTaxLST(decimal TotalAmountAfterTax)
		{
			EntityCollection<OrdersEntity> _OrdersCollection = new EntityCollection<OrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.TotalAmountAfterTax == TotalAmountAfterTax);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersCollection, filter, 0, null);
			}
			return _OrdersCollection;
		}
		
		// Return EntityCollection<OrdersEntity>
		public EntityCollection<OrdersEntity> SelectByTotalAmountAfterTaxLST_Paged(decimal TotalAmountAfterTax, int PageNumber, int PageSize)
		{
			EntityCollection<OrdersEntity> _OrdersCollection = new EntityCollection<OrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.TotalAmountAfterTax == TotalAmountAfterTax);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrdersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTotalAmountAfterTaxRDT(decimal TotalAmountAfterTax)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersCollection = new EntityCollection(new OrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.TotalAmountAfterTax == TotalAmountAfterTax);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTotalAmountAfterTaxRDT_Paged(decimal TotalAmountAfterTax, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersCollection = new EntityCollection(new OrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.TotalAmountAfterTax == TotalAmountAfterTax);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrdersEntity>
		public EntityCollection<OrdersEntity> SelectByTotalDiscountLST(decimal TotalDiscount)
		{
			EntityCollection<OrdersEntity> _OrdersCollection = new EntityCollection<OrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.TotalDiscount == TotalDiscount);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersCollection, filter, 0, null);
			}
			return _OrdersCollection;
		}
		
		// Return EntityCollection<OrdersEntity>
		public EntityCollection<OrdersEntity> SelectByTotalDiscountLST_Paged(decimal TotalDiscount, int PageNumber, int PageSize)
		{
			EntityCollection<OrdersEntity> _OrdersCollection = new EntityCollection<OrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.TotalDiscount == TotalDiscount);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrdersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTotalDiscountRDT(decimal TotalDiscount)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersCollection = new EntityCollection(new OrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.TotalDiscount == TotalDiscount);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTotalDiscountRDT_Paged(decimal TotalDiscount, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersCollection = new EntityCollection(new OrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.TotalDiscount == TotalDiscount);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrdersEntity>
		public EntityCollection<OrdersEntity> SelectByTotalOtherLST(decimal TotalOther)
		{
			EntityCollection<OrdersEntity> _OrdersCollection = new EntityCollection<OrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.TotalOther == TotalOther);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersCollection, filter, 0, null);
			}
			return _OrdersCollection;
		}
		
		// Return EntityCollection<OrdersEntity>
		public EntityCollection<OrdersEntity> SelectByTotalOtherLST_Paged(decimal TotalOther, int PageNumber, int PageSize)
		{
			EntityCollection<OrdersEntity> _OrdersCollection = new EntityCollection<OrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.TotalOther == TotalOther);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrdersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTotalOtherRDT(decimal TotalOther)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersCollection = new EntityCollection(new OrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.TotalOther == TotalOther);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTotalOtherRDT_Paged(decimal TotalOther, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersCollection = new EntityCollection(new OrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.TotalOther == TotalOther);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrdersEntity>
		public EntityCollection<OrdersEntity> SelectByTotalPaidLST(decimal TotalPaid)
		{
			EntityCollection<OrdersEntity> _OrdersCollection = new EntityCollection<OrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.TotalPaid == TotalPaid);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersCollection, filter, 0, null);
			}
			return _OrdersCollection;
		}
		
		// Return EntityCollection<OrdersEntity>
		public EntityCollection<OrdersEntity> SelectByTotalPaidLST_Paged(decimal TotalPaid, int PageNumber, int PageSize)
		{
			EntityCollection<OrdersEntity> _OrdersCollection = new EntityCollection<OrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.TotalPaid == TotalPaid);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrdersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTotalPaidRDT(decimal TotalPaid)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersCollection = new EntityCollection(new OrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.TotalPaid == TotalPaid);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTotalPaidRDT_Paged(decimal TotalPaid, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersCollection = new EntityCollection(new OrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.TotalPaid == TotalPaid);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrdersEntity>
		public EntityCollection<OrdersEntity> SelectByPaidCompletedLST(bool PaidCompleted)
		{
			EntityCollection<OrdersEntity> _OrdersCollection = new EntityCollection<OrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.PaidCompleted == PaidCompleted);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersCollection, filter, 0, null);
			}
			return _OrdersCollection;
		}
		
		// Return EntityCollection<OrdersEntity>
		public EntityCollection<OrdersEntity> SelectByPaidCompletedLST_Paged(bool PaidCompleted, int PageNumber, int PageSize)
		{
			EntityCollection<OrdersEntity> _OrdersCollection = new EntityCollection<OrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.PaidCompleted == PaidCompleted);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrdersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPaidCompletedRDT(bool PaidCompleted)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersCollection = new EntityCollection(new OrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.PaidCompleted == PaidCompleted);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPaidCompletedRDT_Paged(bool PaidCompleted, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersCollection = new EntityCollection(new OrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.PaidCompleted == PaidCompleted);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrdersEntity>
		public EntityCollection<OrdersEntity> SelectByTotalAllSupplierLST(decimal TotalAllSupplier)
		{
			EntityCollection<OrdersEntity> _OrdersCollection = new EntityCollection<OrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.TotalAllSupplier == TotalAllSupplier);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersCollection, filter, 0, null);
			}
			return _OrdersCollection;
		}
		
		// Return EntityCollection<OrdersEntity>
		public EntityCollection<OrdersEntity> SelectByTotalAllSupplierLST_Paged(decimal TotalAllSupplier, int PageNumber, int PageSize)
		{
			EntityCollection<OrdersEntity> _OrdersCollection = new EntityCollection<OrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.TotalAllSupplier == TotalAllSupplier);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrdersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTotalAllSupplierRDT(decimal TotalAllSupplier)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersCollection = new EntityCollection(new OrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.TotalAllSupplier == TotalAllSupplier);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTotalAllSupplierRDT_Paged(decimal TotalAllSupplier, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersCollection = new EntityCollection(new OrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.TotalAllSupplier == TotalAllSupplier);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrdersEntity>
		public EntityCollection<OrdersEntity> SelectByTotalCommissionLST(decimal TotalCommission)
		{
			EntityCollection<OrdersEntity> _OrdersCollection = new EntityCollection<OrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.TotalCommission == TotalCommission);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersCollection, filter, 0, null);
			}
			return _OrdersCollection;
		}
		
		// Return EntityCollection<OrdersEntity>
		public EntityCollection<OrdersEntity> SelectByTotalCommissionLST_Paged(decimal TotalCommission, int PageNumber, int PageSize)
		{
			EntityCollection<OrdersEntity> _OrdersCollection = new EntityCollection<OrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.TotalCommission == TotalCommission);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrdersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTotalCommissionRDT(decimal TotalCommission)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersCollection = new EntityCollection(new OrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.TotalCommission == TotalCommission);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTotalCommissionRDT_Paged(decimal TotalCommission, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersCollection = new EntityCollection(new OrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.TotalCommission == TotalCommission);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrdersEntity>
		public EntityCollection<OrdersEntity> SelectByPaymentMethodLST(string PaymentMethod)
		{
			EntityCollection<OrdersEntity> _OrdersCollection = new EntityCollection<OrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.PaymentMethod == PaymentMethod);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersCollection, filter, 0, null);
			}
			return _OrdersCollection;
		}
		
		// Return EntityCollection<OrdersEntity>
		public EntityCollection<OrdersEntity> SelectByPaymentMethodLST_Paged(string PaymentMethod, int PageNumber, int PageSize)
		{
			EntityCollection<OrdersEntity> _OrdersCollection = new EntityCollection<OrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.PaymentMethod == PaymentMethod);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrdersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPaymentMethodRDT(string PaymentMethod)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersCollection = new EntityCollection(new OrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.PaymentMethod == PaymentMethod);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPaymentMethodRDT_Paged(string PaymentMethod, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersCollection = new EntityCollection(new OrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.PaymentMethod == PaymentMethod);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrdersEntity>
		public EntityCollection<OrdersEntity> SelectByCreatedByLST(string CreatedBy)
		{
			EntityCollection<OrdersEntity> _OrdersCollection = new EntityCollection<OrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersCollection, filter, 0, null);
			}
			return _OrdersCollection;
		}
		
		// Return EntityCollection<OrdersEntity>
		public EntityCollection<OrdersEntity> SelectByCreatedByLST_Paged(string CreatedBy, int PageNumber, int PageSize)
		{
			EntityCollection<OrdersEntity> _OrdersCollection = new EntityCollection<OrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrdersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedByRDT(string CreatedBy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersCollection = new EntityCollection(new OrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedByRDT_Paged(string CreatedBy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersCollection = new EntityCollection(new OrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrdersEntity>
		public EntityCollection<OrdersEntity> SelectByCreatedDateLST(DateTime CreatedDate)
		{
			EntityCollection<OrdersEntity> _OrdersCollection = new EntityCollection<OrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersCollection, filter, 0, null);
			}
			return _OrdersCollection;
		}
		
		// Return EntityCollection<OrdersEntity>
		public EntityCollection<OrdersEntity> SelectByCreatedDateLST_Paged(DateTime CreatedDate, int PageNumber, int PageSize)
		{
			EntityCollection<OrdersEntity> _OrdersCollection = new EntityCollection<OrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrdersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedDateRDT(DateTime CreatedDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersCollection = new EntityCollection(new OrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedDateRDT_Paged(DateTime CreatedDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersCollection = new EntityCollection(new OrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrdersEntity>
		public EntityCollection<OrdersEntity> SelectByUpdatedByLST(string UpdatedBy)
		{
			EntityCollection<OrdersEntity> _OrdersCollection = new EntityCollection<OrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersCollection, filter, 0, null);
			}
			return _OrdersCollection;
		}
		
		// Return EntityCollection<OrdersEntity>
		public EntityCollection<OrdersEntity> SelectByUpdatedByLST_Paged(string UpdatedBy, int PageNumber, int PageSize)
		{
			EntityCollection<OrdersEntity> _OrdersCollection = new EntityCollection<OrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrdersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedByRDT(string UpdatedBy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersCollection = new EntityCollection(new OrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedByRDT_Paged(string UpdatedBy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersCollection = new EntityCollection(new OrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrdersEntity>
		public EntityCollection<OrdersEntity> SelectByUpdatedDateLST(DateTime UpdatedDate)
		{
			EntityCollection<OrdersEntity> _OrdersCollection = new EntityCollection<OrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersCollection, filter, 0, null);
			}
			return _OrdersCollection;
		}
		
		// Return EntityCollection<OrdersEntity>
		public EntityCollection<OrdersEntity> SelectByUpdatedDateLST_Paged(DateTime UpdatedDate, int PageNumber, int PageSize)
		{
			EntityCollection<OrdersEntity> _OrdersCollection = new EntityCollection<OrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrdersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedDateRDT(DateTime UpdatedDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersCollection = new EntityCollection(new OrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedDateRDT_Paged(DateTime UpdatedDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersCollection = new EntityCollection(new OrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrdersEntity>
		public EntityCollection<OrdersEntity> SelectByIsDeleteLST(bool IsDelete)
		{
			EntityCollection<OrdersEntity> _OrdersCollection = new EntityCollection<OrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.IsDelete == IsDelete);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersCollection, filter, 0, null);
			}
			return _OrdersCollection;
		}
		
		// Return EntityCollection<OrdersEntity>
		public EntityCollection<OrdersEntity> SelectByIsDeleteLST_Paged(bool IsDelete, int PageNumber, int PageSize)
		{
			EntityCollection<OrdersEntity> _OrdersCollection = new EntityCollection<OrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.IsDelete == IsDelete);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrdersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrdersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIsDeleteRDT(bool IsDelete)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersCollection = new EntityCollection(new OrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.IsDelete == IsDelete);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIsDeleteRDT_Paged(bool IsDelete, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrdersCollection = new EntityCollection(new OrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrdersFields.IsDelete == IsDelete);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
