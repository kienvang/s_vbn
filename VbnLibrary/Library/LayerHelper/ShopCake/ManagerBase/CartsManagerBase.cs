




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.CartsManagerBase
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
	public class CartsManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public CartsManagerBase()
		{
			// Nothing for now.
		}
		
		public CartsEntity Insert(CartsEntity _CartsEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_CartsEntity, true);
			}
			return _CartsEntity;
		}

		
		public CartsEntity Insert(Guid Id, Guid SessionId, Guid ProductId, Guid SupplierId, string ProductName, decimal Price, decimal TotalAmount)
		{
			CartsEntity _CartsEntity = new CartsEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_CartsEntity.Id = Id;
				_CartsEntity.SessionId = SessionId;
				_CartsEntity.ProductId = ProductId;
				_CartsEntity.SupplierId = SupplierId;
				_CartsEntity.ProductName = ProductName;
				_CartsEntity.Price = Price;
				_CartsEntity.TotalAmount = TotalAmount;
				adapter.SaveEntity(_CartsEntity, true);
			}
			return _CartsEntity;
		}

		public CartsEntity Insert(Guid SessionId, Guid ProductId, Guid SupplierId, string ProductName, decimal Price, decimal TotalAmount)
		{
			CartsEntity _CartsEntity = new CartsEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_CartsEntity.SessionId = SessionId;
				_CartsEntity.ProductId = ProductId;
				_CartsEntity.SupplierId = SupplierId;
				_CartsEntity.ProductName = ProductName;
				_CartsEntity.Price = Price;
				_CartsEntity.TotalAmount = TotalAmount;
				adapter.SaveEntity(_CartsEntity, true);
			}
			return _CartsEntity;
		}

		public bool Update(CartsEntity _CartsEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(CartsFields.Id == _CartsEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_CartsEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(CartsEntity _CartsEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_CartsEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, Guid SessionId, Guid ProductId, Guid SupplierId, string ProductName, decimal Price, decimal TotalAmount)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				CartsEntity _CartsEntity = new CartsEntity(Id);
				if (adapter.FetchEntity(_CartsEntity))
				{
				
					_CartsEntity.SessionId = SessionId;
					_CartsEntity.ProductId = ProductId;
					_CartsEntity.SupplierId = SupplierId;
					_CartsEntity.ProductName = ProductName;
					_CartsEntity.Price = Price;
					_CartsEntity.TotalAmount = TotalAmount;
					adapter.SaveEntity(_CartsEntity, true);
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
				CartsEntity _CartsEntity = new CartsEntity(Id);
				if (adapter.FetchEntity(_CartsEntity))
				{
					adapter.DeleteEntity(_CartsEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("CartsEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CartsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySessionId(Guid SessionId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartsFields.SessionId == SessionId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CartsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByProductId(Guid ProductId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartsFields.ProductId == ProductId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CartsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySupplierId(Guid SupplierId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartsFields.SupplierId == SupplierId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CartsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByProductName(string ProductName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartsFields.ProductName == ProductName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CartsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPrice(decimal Price)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartsFields.Price == Price);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CartsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTotalAmount(decimal TotalAmount)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartsFields.TotalAmount == TotalAmount);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CartsEntity", filter);
			}
			return toReturn;
		}
		

		
		public CartsEntity SelectOne(Guid Id)
		{
			CartsEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				CartsEntity _CartsEntity = new CartsEntity(Id);
				if (adapter.FetchEntity(_CartsEntity))
				{
					toReturn = _CartsEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CartsCollection = new EntityCollection(new CartsEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CartsCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<CartsEntity>
		public EntityCollection<CartsEntity> SelectAllLST()
		{
			EntityCollection<CartsEntity> _CartsCollection = new EntityCollection<CartsEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CartsCollection, null, 0, null);
			}
			return _CartsCollection;
		}
		
		// Return EntityCollection<CartsEntity>
		public EntityCollection<CartsEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<CartsEntity> _CartsCollection = new EntityCollection<CartsEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CartsCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _CartsCollection;
		}


		
		// Return EntityCollection<CartsEntity>
		public EntityCollection<CartsEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<CartsEntity> _CartsCollection = new EntityCollection<CartsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CartsCollection, filter, 0, null);
			}
			return _CartsCollection;
		}
		
		// Return EntityCollection<CartsEntity>
		public EntityCollection<CartsEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<CartsEntity> _CartsCollection = new EntityCollection<CartsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CartsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CartsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CartsCollection = new EntityCollection(new CartsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CartsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CartsCollection = new EntityCollection(new CartsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CartsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<CartsEntity>
		public EntityCollection<CartsEntity> SelectBySessionIdLST(Guid SessionId)
		{
			EntityCollection<CartsEntity> _CartsCollection = new EntityCollection<CartsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartsFields.SessionId == SessionId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CartsCollection, filter, 0, null);
			}
			return _CartsCollection;
		}
		
		// Return EntityCollection<CartsEntity>
		public EntityCollection<CartsEntity> SelectBySessionIdLST_Paged(Guid SessionId, int PageNumber, int PageSize)
		{
			EntityCollection<CartsEntity> _CartsCollection = new EntityCollection<CartsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartsFields.SessionId == SessionId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CartsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CartsCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySessionIdRDT(Guid SessionId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CartsCollection = new EntityCollection(new CartsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartsFields.SessionId == SessionId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CartsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySessionIdRDT_Paged(Guid SessionId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CartsCollection = new EntityCollection(new CartsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartsFields.SessionId == SessionId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CartsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<CartsEntity>
		public EntityCollection<CartsEntity> SelectByProductIdLST(Guid ProductId)
		{
			EntityCollection<CartsEntity> _CartsCollection = new EntityCollection<CartsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartsFields.ProductId == ProductId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CartsCollection, filter, 0, null);
			}
			return _CartsCollection;
		}
		
		// Return EntityCollection<CartsEntity>
		public EntityCollection<CartsEntity> SelectByProductIdLST_Paged(Guid ProductId, int PageNumber, int PageSize)
		{
			EntityCollection<CartsEntity> _CartsCollection = new EntityCollection<CartsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartsFields.ProductId == ProductId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CartsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CartsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByProductIdRDT(Guid ProductId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CartsCollection = new EntityCollection(new CartsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartsFields.ProductId == ProductId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CartsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByProductIdRDT_Paged(Guid ProductId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CartsCollection = new EntityCollection(new CartsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartsFields.ProductId == ProductId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CartsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<CartsEntity>
		public EntityCollection<CartsEntity> SelectBySupplierIdLST(Guid SupplierId)
		{
			EntityCollection<CartsEntity> _CartsCollection = new EntityCollection<CartsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartsFields.SupplierId == SupplierId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CartsCollection, filter, 0, null);
			}
			return _CartsCollection;
		}
		
		// Return EntityCollection<CartsEntity>
		public EntityCollection<CartsEntity> SelectBySupplierIdLST_Paged(Guid SupplierId, int PageNumber, int PageSize)
		{
			EntityCollection<CartsEntity> _CartsCollection = new EntityCollection<CartsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartsFields.SupplierId == SupplierId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CartsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CartsCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySupplierIdRDT(Guid SupplierId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CartsCollection = new EntityCollection(new CartsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartsFields.SupplierId == SupplierId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CartsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySupplierIdRDT_Paged(Guid SupplierId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CartsCollection = new EntityCollection(new CartsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartsFields.SupplierId == SupplierId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CartsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<CartsEntity>
		public EntityCollection<CartsEntity> SelectByProductNameLST(string ProductName)
		{
			EntityCollection<CartsEntity> _CartsCollection = new EntityCollection<CartsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartsFields.ProductName == ProductName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CartsCollection, filter, 0, null);
			}
			return _CartsCollection;
		}
		
		// Return EntityCollection<CartsEntity>
		public EntityCollection<CartsEntity> SelectByProductNameLST_Paged(string ProductName, int PageNumber, int PageSize)
		{
			EntityCollection<CartsEntity> _CartsCollection = new EntityCollection<CartsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartsFields.ProductName == ProductName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CartsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CartsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByProductNameRDT(string ProductName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CartsCollection = new EntityCollection(new CartsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartsFields.ProductName == ProductName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CartsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByProductNameRDT_Paged(string ProductName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CartsCollection = new EntityCollection(new CartsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartsFields.ProductName == ProductName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CartsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<CartsEntity>
		public EntityCollection<CartsEntity> SelectByPriceLST(decimal Price)
		{
			EntityCollection<CartsEntity> _CartsCollection = new EntityCollection<CartsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartsFields.Price == Price);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CartsCollection, filter, 0, null);
			}
			return _CartsCollection;
		}
		
		// Return EntityCollection<CartsEntity>
		public EntityCollection<CartsEntity> SelectByPriceLST_Paged(decimal Price, int PageNumber, int PageSize)
		{
			EntityCollection<CartsEntity> _CartsCollection = new EntityCollection<CartsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartsFields.Price == Price);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CartsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CartsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPriceRDT(decimal Price)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CartsCollection = new EntityCollection(new CartsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartsFields.Price == Price);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CartsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPriceRDT_Paged(decimal Price, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CartsCollection = new EntityCollection(new CartsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartsFields.Price == Price);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CartsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<CartsEntity>
		public EntityCollection<CartsEntity> SelectByTotalAmountLST(decimal TotalAmount)
		{
			EntityCollection<CartsEntity> _CartsCollection = new EntityCollection<CartsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartsFields.TotalAmount == TotalAmount);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CartsCollection, filter, 0, null);
			}
			return _CartsCollection;
		}
		
		// Return EntityCollection<CartsEntity>
		public EntityCollection<CartsEntity> SelectByTotalAmountLST_Paged(decimal TotalAmount, int PageNumber, int PageSize)
		{
			EntityCollection<CartsEntity> _CartsCollection = new EntityCollection<CartsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartsFields.TotalAmount == TotalAmount);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CartsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CartsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTotalAmountRDT(decimal TotalAmount)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CartsCollection = new EntityCollection(new CartsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartsFields.TotalAmount == TotalAmount);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CartsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTotalAmountRDT_Paged(decimal TotalAmount, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CartsCollection = new EntityCollection(new CartsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartsFields.TotalAmount == TotalAmount);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CartsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
