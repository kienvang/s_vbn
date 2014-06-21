




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.OrderDetailManagerBase
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
	public class OrderDetailManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public OrderDetailManagerBase()
		{
			// Nothing for now.
		}
		
		public OrderDetailEntity Insert(OrderDetailEntity _OrderDetailEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_OrderDetailEntity, true);
			}
			return _OrderDetailEntity;
		}

		
		public OrderDetailEntity Insert(Guid Id, Guid ProductId, string ProductName, string ProductCode, Guid OrderItemId, decimal PriceBeforeTax, decimal PriceAfterTax, int Amount, decimal PoPrice, string Note, Guid ProductSubId)
		{
			OrderDetailEntity _OrderDetailEntity = new OrderDetailEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_OrderDetailEntity.Id = Id;
				_OrderDetailEntity.ProductId = ProductId;
				_OrderDetailEntity.ProductName = ProductName;
				_OrderDetailEntity.ProductCode = ProductCode;
				_OrderDetailEntity.OrderItemId = OrderItemId;
				_OrderDetailEntity.PriceBeforeTax = PriceBeforeTax;
				_OrderDetailEntity.PriceAfterTax = PriceAfterTax;
				_OrderDetailEntity.Amount = Amount;
				_OrderDetailEntity.PoPrice = PoPrice;
				_OrderDetailEntity.Note = Note;
				_OrderDetailEntity.ProductSubId = ProductSubId;
				adapter.SaveEntity(_OrderDetailEntity, true);
			}
			return _OrderDetailEntity;
		}

		public OrderDetailEntity Insert(Guid ProductId, string ProductName, string ProductCode, Guid OrderItemId, decimal PriceBeforeTax, decimal PriceAfterTax, int Amount, decimal PoPrice, string Note, Guid ProductSubId)
		{
			OrderDetailEntity _OrderDetailEntity = new OrderDetailEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_OrderDetailEntity.ProductId = ProductId;
				_OrderDetailEntity.ProductName = ProductName;
				_OrderDetailEntity.ProductCode = ProductCode;
				_OrderDetailEntity.OrderItemId = OrderItemId;
				_OrderDetailEntity.PriceBeforeTax = PriceBeforeTax;
				_OrderDetailEntity.PriceAfterTax = PriceAfterTax;
				_OrderDetailEntity.Amount = Amount;
				_OrderDetailEntity.PoPrice = PoPrice;
				_OrderDetailEntity.Note = Note;
				_OrderDetailEntity.ProductSubId = ProductSubId;
				adapter.SaveEntity(_OrderDetailEntity, true);
			}
			return _OrderDetailEntity;
		}

		public bool Update(OrderDetailEntity _OrderDetailEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(OrderDetailFields.Id == _OrderDetailEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_OrderDetailEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(OrderDetailEntity _OrderDetailEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_OrderDetailEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, Guid ProductId, string ProductName, string ProductCode, Guid OrderItemId, decimal PriceBeforeTax, decimal PriceAfterTax, int Amount, decimal PoPrice, string Note, Guid ProductSubId)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				OrderDetailEntity _OrderDetailEntity = new OrderDetailEntity(Id);
				if (adapter.FetchEntity(_OrderDetailEntity))
				{
				
					_OrderDetailEntity.ProductId = ProductId;
					_OrderDetailEntity.ProductName = ProductName;
					_OrderDetailEntity.ProductCode = ProductCode;
					_OrderDetailEntity.OrderItemId = OrderItemId;
					_OrderDetailEntity.PriceBeforeTax = PriceBeforeTax;
					_OrderDetailEntity.PriceAfterTax = PriceAfterTax;
					_OrderDetailEntity.Amount = Amount;
					_OrderDetailEntity.PoPrice = PoPrice;
					_OrderDetailEntity.Note = Note;
					_OrderDetailEntity.ProductSubId = ProductSubId;
					adapter.SaveEntity(_OrderDetailEntity, true);
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
				OrderDetailEntity _OrderDetailEntity = new OrderDetailEntity(Id);
				if (adapter.FetchEntity(_OrderDetailEntity))
				{
					adapter.DeleteEntity(_OrderDetailEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("OrderDetailEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrderDetailEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByProductId(Guid ProductId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.ProductId == ProductId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrderDetailEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByProductName(string ProductName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.ProductName == ProductName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrderDetailEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByProductCode(string ProductCode)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.ProductCode == ProductCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrderDetailEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByOrderItemId(Guid OrderItemId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.OrderItemId == OrderItemId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrderDetailEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPriceBeforeTax(decimal PriceBeforeTax)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.PriceBeforeTax == PriceBeforeTax);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrderDetailEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPriceAfterTax(decimal PriceAfterTax)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.PriceAfterTax == PriceAfterTax);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrderDetailEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByAmount(int Amount)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.Amount == Amount);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrderDetailEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPoPrice(decimal PoPrice)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.PoPrice == PoPrice);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrderDetailEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNote(string Note)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.Note == Note);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrderDetailEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByProductSubId(Guid ProductSubId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.ProductSubId == ProductSubId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrderDetailEntity", filter);
			}
			return toReturn;
		}
		

		
		public OrderDetailEntity SelectOne(Guid Id)
		{
			OrderDetailEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				OrderDetailEntity _OrderDetailEntity = new OrderDetailEntity(Id);
				if (adapter.FetchEntity(_OrderDetailEntity))
				{
					toReturn = _OrderDetailEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderDetailCollection = new EntityCollection(new OrderDetailEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<OrderDetailEntity>
		public EntityCollection<OrderDetailEntity> SelectAllLST()
		{
			EntityCollection<OrderDetailEntity> _OrderDetailCollection = new EntityCollection<OrderDetailEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderDetailCollection, null, 0, null);
			}
			return _OrderDetailCollection;
		}
		
		// Return EntityCollection<OrderDetailEntity>
		public EntityCollection<OrderDetailEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<OrderDetailEntity> _OrderDetailCollection = new EntityCollection<OrderDetailEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderDetailCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _OrderDetailCollection;
		}


		
		// Return EntityCollection<OrderDetailEntity>
		public EntityCollection<OrderDetailEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<OrderDetailEntity> _OrderDetailCollection = new EntityCollection<OrderDetailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderDetailCollection, filter, 0, null);
			}
			return _OrderDetailCollection;
		}
		
		// Return EntityCollection<OrderDetailEntity>
		public EntityCollection<OrderDetailEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<OrderDetailEntity> _OrderDetailCollection = new EntityCollection<OrderDetailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderDetailCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrderDetailCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderDetailCollection = new EntityCollection(new OrderDetailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderDetailCollection = new EntityCollection(new OrderDetailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrderDetailEntity>
		public EntityCollection<OrderDetailEntity> SelectByProductIdLST(Guid ProductId)
		{
			EntityCollection<OrderDetailEntity> _OrderDetailCollection = new EntityCollection<OrderDetailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.ProductId == ProductId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderDetailCollection, filter, 0, null);
			}
			return _OrderDetailCollection;
		}
		
		// Return EntityCollection<OrderDetailEntity>
		public EntityCollection<OrderDetailEntity> SelectByProductIdLST_Paged(Guid ProductId, int PageNumber, int PageSize)
		{
			EntityCollection<OrderDetailEntity> _OrderDetailCollection = new EntityCollection<OrderDetailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.ProductId == ProductId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderDetailCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrderDetailCollection;
		}
		
		// Return DataTable
		public DataTable SelectByProductIdRDT(Guid ProductId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderDetailCollection = new EntityCollection(new OrderDetailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.ProductId == ProductId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByProductIdRDT_Paged(Guid ProductId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderDetailCollection = new EntityCollection(new OrderDetailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.ProductId == ProductId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrderDetailEntity>
		public EntityCollection<OrderDetailEntity> SelectByProductNameLST(string ProductName)
		{
			EntityCollection<OrderDetailEntity> _OrderDetailCollection = new EntityCollection<OrderDetailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.ProductName == ProductName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderDetailCollection, filter, 0, null);
			}
			return _OrderDetailCollection;
		}
		
		// Return EntityCollection<OrderDetailEntity>
		public EntityCollection<OrderDetailEntity> SelectByProductNameLST_Paged(string ProductName, int PageNumber, int PageSize)
		{
			EntityCollection<OrderDetailEntity> _OrderDetailCollection = new EntityCollection<OrderDetailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.ProductName == ProductName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderDetailCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrderDetailCollection;
		}
		
		// Return DataTable
		public DataTable SelectByProductNameRDT(string ProductName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderDetailCollection = new EntityCollection(new OrderDetailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.ProductName == ProductName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByProductNameRDT_Paged(string ProductName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderDetailCollection = new EntityCollection(new OrderDetailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.ProductName == ProductName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrderDetailEntity>
		public EntityCollection<OrderDetailEntity> SelectByProductCodeLST(string ProductCode)
		{
			EntityCollection<OrderDetailEntity> _OrderDetailCollection = new EntityCollection<OrderDetailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.ProductCode == ProductCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderDetailCollection, filter, 0, null);
			}
			return _OrderDetailCollection;
		}
		
		// Return EntityCollection<OrderDetailEntity>
		public EntityCollection<OrderDetailEntity> SelectByProductCodeLST_Paged(string ProductCode, int PageNumber, int PageSize)
		{
			EntityCollection<OrderDetailEntity> _OrderDetailCollection = new EntityCollection<OrderDetailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.ProductCode == ProductCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderDetailCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrderDetailCollection;
		}
		
		// Return DataTable
		public DataTable SelectByProductCodeRDT(string ProductCode)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderDetailCollection = new EntityCollection(new OrderDetailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.ProductCode == ProductCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByProductCodeRDT_Paged(string ProductCode, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderDetailCollection = new EntityCollection(new OrderDetailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.ProductCode == ProductCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrderDetailEntity>
		public EntityCollection<OrderDetailEntity> SelectByOrderItemIdLST(Guid OrderItemId)
		{
			EntityCollection<OrderDetailEntity> _OrderDetailCollection = new EntityCollection<OrderDetailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.OrderItemId == OrderItemId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderDetailCollection, filter, 0, null);
			}
			return _OrderDetailCollection;
		}
		
		// Return EntityCollection<OrderDetailEntity>
		public EntityCollection<OrderDetailEntity> SelectByOrderItemIdLST_Paged(Guid OrderItemId, int PageNumber, int PageSize)
		{
			EntityCollection<OrderDetailEntity> _OrderDetailCollection = new EntityCollection<OrderDetailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.OrderItemId == OrderItemId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderDetailCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrderDetailCollection;
		}
		
		// Return DataTable
		public DataTable SelectByOrderItemIdRDT(Guid OrderItemId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderDetailCollection = new EntityCollection(new OrderDetailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.OrderItemId == OrderItemId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByOrderItemIdRDT_Paged(Guid OrderItemId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderDetailCollection = new EntityCollection(new OrderDetailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.OrderItemId == OrderItemId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrderDetailEntity>
		public EntityCollection<OrderDetailEntity> SelectByPriceBeforeTaxLST(decimal PriceBeforeTax)
		{
			EntityCollection<OrderDetailEntity> _OrderDetailCollection = new EntityCollection<OrderDetailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.PriceBeforeTax == PriceBeforeTax);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderDetailCollection, filter, 0, null);
			}
			return _OrderDetailCollection;
		}
		
		// Return EntityCollection<OrderDetailEntity>
		public EntityCollection<OrderDetailEntity> SelectByPriceBeforeTaxLST_Paged(decimal PriceBeforeTax, int PageNumber, int PageSize)
		{
			EntityCollection<OrderDetailEntity> _OrderDetailCollection = new EntityCollection<OrderDetailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.PriceBeforeTax == PriceBeforeTax);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderDetailCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrderDetailCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPriceBeforeTaxRDT(decimal PriceBeforeTax)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderDetailCollection = new EntityCollection(new OrderDetailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.PriceBeforeTax == PriceBeforeTax);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPriceBeforeTaxRDT_Paged(decimal PriceBeforeTax, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderDetailCollection = new EntityCollection(new OrderDetailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.PriceBeforeTax == PriceBeforeTax);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrderDetailEntity>
		public EntityCollection<OrderDetailEntity> SelectByPriceAfterTaxLST(decimal PriceAfterTax)
		{
			EntityCollection<OrderDetailEntity> _OrderDetailCollection = new EntityCollection<OrderDetailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.PriceAfterTax == PriceAfterTax);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderDetailCollection, filter, 0, null);
			}
			return _OrderDetailCollection;
		}
		
		// Return EntityCollection<OrderDetailEntity>
		public EntityCollection<OrderDetailEntity> SelectByPriceAfterTaxLST_Paged(decimal PriceAfterTax, int PageNumber, int PageSize)
		{
			EntityCollection<OrderDetailEntity> _OrderDetailCollection = new EntityCollection<OrderDetailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.PriceAfterTax == PriceAfterTax);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderDetailCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrderDetailCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPriceAfterTaxRDT(decimal PriceAfterTax)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderDetailCollection = new EntityCollection(new OrderDetailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.PriceAfterTax == PriceAfterTax);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPriceAfterTaxRDT_Paged(decimal PriceAfterTax, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderDetailCollection = new EntityCollection(new OrderDetailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.PriceAfterTax == PriceAfterTax);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrderDetailEntity>
		public EntityCollection<OrderDetailEntity> SelectByAmountLST(int Amount)
		{
			EntityCollection<OrderDetailEntity> _OrderDetailCollection = new EntityCollection<OrderDetailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.Amount == Amount);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderDetailCollection, filter, 0, null);
			}
			return _OrderDetailCollection;
		}
		
		// Return EntityCollection<OrderDetailEntity>
		public EntityCollection<OrderDetailEntity> SelectByAmountLST_Paged(int Amount, int PageNumber, int PageSize)
		{
			EntityCollection<OrderDetailEntity> _OrderDetailCollection = new EntityCollection<OrderDetailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.Amount == Amount);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderDetailCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrderDetailCollection;
		}
		
		// Return DataTable
		public DataTable SelectByAmountRDT(int Amount)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderDetailCollection = new EntityCollection(new OrderDetailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.Amount == Amount);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByAmountRDT_Paged(int Amount, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderDetailCollection = new EntityCollection(new OrderDetailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.Amount == Amount);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrderDetailEntity>
		public EntityCollection<OrderDetailEntity> SelectByPoPriceLST(decimal PoPrice)
		{
			EntityCollection<OrderDetailEntity> _OrderDetailCollection = new EntityCollection<OrderDetailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.PoPrice == PoPrice);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderDetailCollection, filter, 0, null);
			}
			return _OrderDetailCollection;
		}
		
		// Return EntityCollection<OrderDetailEntity>
		public EntityCollection<OrderDetailEntity> SelectByPoPriceLST_Paged(decimal PoPrice, int PageNumber, int PageSize)
		{
			EntityCollection<OrderDetailEntity> _OrderDetailCollection = new EntityCollection<OrderDetailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.PoPrice == PoPrice);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderDetailCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrderDetailCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPoPriceRDT(decimal PoPrice)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderDetailCollection = new EntityCollection(new OrderDetailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.PoPrice == PoPrice);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPoPriceRDT_Paged(decimal PoPrice, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderDetailCollection = new EntityCollection(new OrderDetailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.PoPrice == PoPrice);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrderDetailEntity>
		public EntityCollection<OrderDetailEntity> SelectByNoteLST(string Note)
		{
			EntityCollection<OrderDetailEntity> _OrderDetailCollection = new EntityCollection<OrderDetailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.Note == Note);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderDetailCollection, filter, 0, null);
			}
			return _OrderDetailCollection;
		}
		
		// Return EntityCollection<OrderDetailEntity>
		public EntityCollection<OrderDetailEntity> SelectByNoteLST_Paged(string Note, int PageNumber, int PageSize)
		{
			EntityCollection<OrderDetailEntity> _OrderDetailCollection = new EntityCollection<OrderDetailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.Note == Note);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderDetailCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrderDetailCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNoteRDT(string Note)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderDetailCollection = new EntityCollection(new OrderDetailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.Note == Note);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNoteRDT_Paged(string Note, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderDetailCollection = new EntityCollection(new OrderDetailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.Note == Note);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrderDetailEntity>
		public EntityCollection<OrderDetailEntity> SelectByProductSubIdLST(Guid ProductSubId)
		{
			EntityCollection<OrderDetailEntity> _OrderDetailCollection = new EntityCollection<OrderDetailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.ProductSubId == ProductSubId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderDetailCollection, filter, 0, null);
			}
			return _OrderDetailCollection;
		}
		
		// Return EntityCollection<OrderDetailEntity>
		public EntityCollection<OrderDetailEntity> SelectByProductSubIdLST_Paged(Guid ProductSubId, int PageNumber, int PageSize)
		{
			EntityCollection<OrderDetailEntity> _OrderDetailCollection = new EntityCollection<OrderDetailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.ProductSubId == ProductSubId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderDetailCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrderDetailCollection;
		}
		
		// Return DataTable
		public DataTable SelectByProductSubIdRDT(Guid ProductSubId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderDetailCollection = new EntityCollection(new OrderDetailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.ProductSubId == ProductSubId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByProductSubIdRDT_Paged(Guid ProductSubId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderDetailCollection = new EntityCollection(new OrderDetailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderDetailFields.ProductSubId == ProductSubId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
