




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.PaymentsManagerBase
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
	public class PaymentsManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public PaymentsManagerBase()
		{
			// Nothing for now.
		}
		
		public PaymentsEntity Insert(PaymentsEntity _PaymentsEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_PaymentsEntity, true);
			}
			return _PaymentsEntity;
		}

		
		public PaymentsEntity Insert(Guid Id, Guid OrderId, string PaymentMethod, decimal Amount, DateTime PaymentDate, string PaymentBy)
		{
			PaymentsEntity _PaymentsEntity = new PaymentsEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_PaymentsEntity.Id = Id;
				_PaymentsEntity.OrderId = OrderId;
				_PaymentsEntity.PaymentMethod = PaymentMethod;
				_PaymentsEntity.Amount = Amount;
				_PaymentsEntity.PaymentDate = PaymentDate;
				_PaymentsEntity.PaymentBy = PaymentBy;
				adapter.SaveEntity(_PaymentsEntity, true);
			}
			return _PaymentsEntity;
		}

		public PaymentsEntity Insert(Guid OrderId, string PaymentMethod, decimal Amount, DateTime PaymentDate, string PaymentBy)
		{
			PaymentsEntity _PaymentsEntity = new PaymentsEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_PaymentsEntity.OrderId = OrderId;
				_PaymentsEntity.PaymentMethod = PaymentMethod;
				_PaymentsEntity.Amount = Amount;
				_PaymentsEntity.PaymentDate = PaymentDate;
				_PaymentsEntity.PaymentBy = PaymentBy;
				adapter.SaveEntity(_PaymentsEntity, true);
			}
			return _PaymentsEntity;
		}

		public bool Update(PaymentsEntity _PaymentsEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(PaymentsFields.Id == _PaymentsEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_PaymentsEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(PaymentsEntity _PaymentsEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_PaymentsEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, Guid OrderId, string PaymentMethod, decimal Amount, DateTime PaymentDate, string PaymentBy)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				PaymentsEntity _PaymentsEntity = new PaymentsEntity(Id);
				if (adapter.FetchEntity(_PaymentsEntity))
				{
				
					_PaymentsEntity.OrderId = OrderId;
					_PaymentsEntity.PaymentMethod = PaymentMethod;
					_PaymentsEntity.Amount = Amount;
					_PaymentsEntity.PaymentDate = PaymentDate;
					_PaymentsEntity.PaymentBy = PaymentBy;
					adapter.SaveEntity(_PaymentsEntity, true);
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
				PaymentsEntity _PaymentsEntity = new PaymentsEntity(Id);
				if (adapter.FetchEntity(_PaymentsEntity))
				{
					adapter.DeleteEntity(_PaymentsEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("PaymentsEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PaymentsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByOrderId(Guid OrderId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentsFields.OrderId == OrderId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PaymentsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPaymentMethod(string PaymentMethod)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentsFields.PaymentMethod == PaymentMethod);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PaymentsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByAmount(decimal Amount)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentsFields.Amount == Amount);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PaymentsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPaymentDate(DateTime PaymentDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentsFields.PaymentDate == PaymentDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PaymentsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPaymentBy(string PaymentBy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentsFields.PaymentBy == PaymentBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PaymentsEntity", filter);
			}
			return toReturn;
		}
		

		
		public PaymentsEntity SelectOne(Guid Id)
		{
			PaymentsEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				PaymentsEntity _PaymentsEntity = new PaymentsEntity(Id);
				if (adapter.FetchEntity(_PaymentsEntity))
				{
					toReturn = _PaymentsEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PaymentsCollection = new EntityCollection(new PaymentsEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PaymentsCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<PaymentsEntity>
		public EntityCollection<PaymentsEntity> SelectAllLST()
		{
			EntityCollection<PaymentsEntity> _PaymentsCollection = new EntityCollection<PaymentsEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PaymentsCollection, null, 0, null);
			}
			return _PaymentsCollection;
		}
		
		// Return EntityCollection<PaymentsEntity>
		public EntityCollection<PaymentsEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<PaymentsEntity> _PaymentsCollection = new EntityCollection<PaymentsEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PaymentsCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _PaymentsCollection;
		}


		
		// Return EntityCollection<PaymentsEntity>
		public EntityCollection<PaymentsEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<PaymentsEntity> _PaymentsCollection = new EntityCollection<PaymentsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PaymentsCollection, filter, 0, null);
			}
			return _PaymentsCollection;
		}
		
		// Return EntityCollection<PaymentsEntity>
		public EntityCollection<PaymentsEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<PaymentsEntity> _PaymentsCollection = new EntityCollection<PaymentsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PaymentsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PaymentsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PaymentsCollection = new EntityCollection(new PaymentsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PaymentsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PaymentsCollection = new EntityCollection(new PaymentsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PaymentsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PaymentsEntity>
		public EntityCollection<PaymentsEntity> SelectByOrderIdLST(Guid OrderId)
		{
			EntityCollection<PaymentsEntity> _PaymentsCollection = new EntityCollection<PaymentsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentsFields.OrderId == OrderId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PaymentsCollection, filter, 0, null);
			}
			return _PaymentsCollection;
		}
		
		// Return EntityCollection<PaymentsEntity>
		public EntityCollection<PaymentsEntity> SelectByOrderIdLST_Paged(Guid OrderId, int PageNumber, int PageSize)
		{
			EntityCollection<PaymentsEntity> _PaymentsCollection = new EntityCollection<PaymentsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentsFields.OrderId == OrderId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PaymentsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PaymentsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByOrderIdRDT(Guid OrderId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PaymentsCollection = new EntityCollection(new PaymentsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentsFields.OrderId == OrderId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PaymentsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByOrderIdRDT_Paged(Guid OrderId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PaymentsCollection = new EntityCollection(new PaymentsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentsFields.OrderId == OrderId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PaymentsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PaymentsEntity>
		public EntityCollection<PaymentsEntity> SelectByPaymentMethodLST(string PaymentMethod)
		{
			EntityCollection<PaymentsEntity> _PaymentsCollection = new EntityCollection<PaymentsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentsFields.PaymentMethod == PaymentMethod);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PaymentsCollection, filter, 0, null);
			}
			return _PaymentsCollection;
		}
		
		// Return EntityCollection<PaymentsEntity>
		public EntityCollection<PaymentsEntity> SelectByPaymentMethodLST_Paged(string PaymentMethod, int PageNumber, int PageSize)
		{
			EntityCollection<PaymentsEntity> _PaymentsCollection = new EntityCollection<PaymentsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentsFields.PaymentMethod == PaymentMethod);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PaymentsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PaymentsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPaymentMethodRDT(string PaymentMethod)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PaymentsCollection = new EntityCollection(new PaymentsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentsFields.PaymentMethod == PaymentMethod);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PaymentsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPaymentMethodRDT_Paged(string PaymentMethod, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PaymentsCollection = new EntityCollection(new PaymentsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentsFields.PaymentMethod == PaymentMethod);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PaymentsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PaymentsEntity>
		public EntityCollection<PaymentsEntity> SelectByAmountLST(decimal Amount)
		{
			EntityCollection<PaymentsEntity> _PaymentsCollection = new EntityCollection<PaymentsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentsFields.Amount == Amount);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PaymentsCollection, filter, 0, null);
			}
			return _PaymentsCollection;
		}
		
		// Return EntityCollection<PaymentsEntity>
		public EntityCollection<PaymentsEntity> SelectByAmountLST_Paged(decimal Amount, int PageNumber, int PageSize)
		{
			EntityCollection<PaymentsEntity> _PaymentsCollection = new EntityCollection<PaymentsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentsFields.Amount == Amount);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PaymentsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PaymentsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByAmountRDT(decimal Amount)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PaymentsCollection = new EntityCollection(new PaymentsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentsFields.Amount == Amount);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PaymentsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByAmountRDT_Paged(decimal Amount, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PaymentsCollection = new EntityCollection(new PaymentsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentsFields.Amount == Amount);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PaymentsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PaymentsEntity>
		public EntityCollection<PaymentsEntity> SelectByPaymentDateLST(DateTime PaymentDate)
		{
			EntityCollection<PaymentsEntity> _PaymentsCollection = new EntityCollection<PaymentsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentsFields.PaymentDate == PaymentDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PaymentsCollection, filter, 0, null);
			}
			return _PaymentsCollection;
		}
		
		// Return EntityCollection<PaymentsEntity>
		public EntityCollection<PaymentsEntity> SelectByPaymentDateLST_Paged(DateTime PaymentDate, int PageNumber, int PageSize)
		{
			EntityCollection<PaymentsEntity> _PaymentsCollection = new EntityCollection<PaymentsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentsFields.PaymentDate == PaymentDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PaymentsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PaymentsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPaymentDateRDT(DateTime PaymentDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PaymentsCollection = new EntityCollection(new PaymentsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentsFields.PaymentDate == PaymentDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PaymentsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPaymentDateRDT_Paged(DateTime PaymentDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PaymentsCollection = new EntityCollection(new PaymentsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentsFields.PaymentDate == PaymentDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PaymentsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PaymentsEntity>
		public EntityCollection<PaymentsEntity> SelectByPaymentByLST(string PaymentBy)
		{
			EntityCollection<PaymentsEntity> _PaymentsCollection = new EntityCollection<PaymentsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentsFields.PaymentBy == PaymentBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PaymentsCollection, filter, 0, null);
			}
			return _PaymentsCollection;
		}
		
		// Return EntityCollection<PaymentsEntity>
		public EntityCollection<PaymentsEntity> SelectByPaymentByLST_Paged(string PaymentBy, int PageNumber, int PageSize)
		{
			EntityCollection<PaymentsEntity> _PaymentsCollection = new EntityCollection<PaymentsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentsFields.PaymentBy == PaymentBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PaymentsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PaymentsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPaymentByRDT(string PaymentBy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PaymentsCollection = new EntityCollection(new PaymentsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentsFields.PaymentBy == PaymentBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PaymentsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPaymentByRDT_Paged(string PaymentBy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PaymentsCollection = new EntityCollection(new PaymentsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentsFields.PaymentBy == PaymentBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PaymentsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
