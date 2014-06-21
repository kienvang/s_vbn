




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.ProductInfoManagerBase
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
	public class ProductInfoManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public ProductInfoManagerBase()
		{
			// Nothing for now.
		}
		
		public ProductInfoEntity Insert(ProductInfoEntity _ProductInfoEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_ProductInfoEntity, true);
			}
			return _ProductInfoEntity;
		}

		
		public ProductInfoEntity Insert(Guid Id, decimal PriceBuy, decimal PriceSell, string Currency, double CommissionPercent)
		{
			ProductInfoEntity _ProductInfoEntity = new ProductInfoEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_ProductInfoEntity.Id = Id;
				_ProductInfoEntity.PriceBuy = PriceBuy;
				_ProductInfoEntity.PriceSell = PriceSell;
				_ProductInfoEntity.Currency = Currency;
				_ProductInfoEntity.CommissionPercent = CommissionPercent;
				adapter.SaveEntity(_ProductInfoEntity, true);
			}
			return _ProductInfoEntity;
		}

		public ProductInfoEntity Insert(decimal PriceBuy, decimal PriceSell, string Currency, double CommissionPercent)
		{
			ProductInfoEntity _ProductInfoEntity = new ProductInfoEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_ProductInfoEntity.PriceBuy = PriceBuy;
				_ProductInfoEntity.PriceSell = PriceSell;
				_ProductInfoEntity.Currency = Currency;
				_ProductInfoEntity.CommissionPercent = CommissionPercent;
				adapter.SaveEntity(_ProductInfoEntity, true);
			}
			return _ProductInfoEntity;
		}

		public bool Update(ProductInfoEntity _ProductInfoEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(ProductInfoFields.Id == _ProductInfoEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_ProductInfoEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(ProductInfoEntity _ProductInfoEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_ProductInfoEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, decimal PriceBuy, decimal PriceSell, string Currency, double CommissionPercent)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				ProductInfoEntity _ProductInfoEntity = new ProductInfoEntity(Id);
				if (adapter.FetchEntity(_ProductInfoEntity))
				{
				
					_ProductInfoEntity.PriceBuy = PriceBuy;
					_ProductInfoEntity.PriceSell = PriceSell;
					_ProductInfoEntity.Currency = Currency;
					_ProductInfoEntity.CommissionPercent = CommissionPercent;
					adapter.SaveEntity(_ProductInfoEntity, true);
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
				ProductInfoEntity _ProductInfoEntity = new ProductInfoEntity(Id);
				if (adapter.FetchEntity(_ProductInfoEntity))
				{
					adapter.DeleteEntity(_ProductInfoEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("ProductInfoEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductInfoFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductInfoEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPriceBuy(decimal PriceBuy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductInfoFields.PriceBuy == PriceBuy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductInfoEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPriceSell(decimal PriceSell)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductInfoFields.PriceSell == PriceSell);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductInfoEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCurrency(string Currency)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductInfoFields.Currency == Currency);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductInfoEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCommissionPercent(double CommissionPercent)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductInfoFields.CommissionPercent == CommissionPercent);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductInfoEntity", filter);
			}
			return toReturn;
		}
		

		
		public ProductInfoEntity SelectOne(Guid Id)
		{
			ProductInfoEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				ProductInfoEntity _ProductInfoEntity = new ProductInfoEntity(Id);
				if (adapter.FetchEntity(_ProductInfoEntity))
				{
					toReturn = _ProductInfoEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductInfoCollection = new EntityCollection(new ProductInfoEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductInfoCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<ProductInfoEntity>
		public EntityCollection<ProductInfoEntity> SelectAllLST()
		{
			EntityCollection<ProductInfoEntity> _ProductInfoCollection = new EntityCollection<ProductInfoEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductInfoCollection, null, 0, null);
			}
			return _ProductInfoCollection;
		}
		
		// Return EntityCollection<ProductInfoEntity>
		public EntityCollection<ProductInfoEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<ProductInfoEntity> _ProductInfoCollection = new EntityCollection<ProductInfoEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductInfoCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _ProductInfoCollection;
		}


		
		// Return EntityCollection<ProductInfoEntity>
		public EntityCollection<ProductInfoEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<ProductInfoEntity> _ProductInfoCollection = new EntityCollection<ProductInfoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductInfoFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductInfoCollection, filter, 0, null);
			}
			return _ProductInfoCollection;
		}
		
		// Return EntityCollection<ProductInfoEntity>
		public EntityCollection<ProductInfoEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<ProductInfoEntity> _ProductInfoCollection = new EntityCollection<ProductInfoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductInfoFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductInfoCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductInfoCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductInfoCollection = new EntityCollection(new ProductInfoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductInfoFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductInfoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductInfoCollection = new EntityCollection(new ProductInfoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductInfoFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductInfoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductInfoEntity>
		public EntityCollection<ProductInfoEntity> SelectByPriceBuyLST(decimal PriceBuy)
		{
			EntityCollection<ProductInfoEntity> _ProductInfoCollection = new EntityCollection<ProductInfoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductInfoFields.PriceBuy == PriceBuy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductInfoCollection, filter, 0, null);
			}
			return _ProductInfoCollection;
		}
		
		// Return EntityCollection<ProductInfoEntity>
		public EntityCollection<ProductInfoEntity> SelectByPriceBuyLST_Paged(decimal PriceBuy, int PageNumber, int PageSize)
		{
			EntityCollection<ProductInfoEntity> _ProductInfoCollection = new EntityCollection<ProductInfoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductInfoFields.PriceBuy == PriceBuy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductInfoCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductInfoCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPriceBuyRDT(decimal PriceBuy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductInfoCollection = new EntityCollection(new ProductInfoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductInfoFields.PriceBuy == PriceBuy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductInfoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPriceBuyRDT_Paged(decimal PriceBuy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductInfoCollection = new EntityCollection(new ProductInfoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductInfoFields.PriceBuy == PriceBuy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductInfoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductInfoEntity>
		public EntityCollection<ProductInfoEntity> SelectByPriceSellLST(decimal PriceSell)
		{
			EntityCollection<ProductInfoEntity> _ProductInfoCollection = new EntityCollection<ProductInfoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductInfoFields.PriceSell == PriceSell);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductInfoCollection, filter, 0, null);
			}
			return _ProductInfoCollection;
		}
		
		// Return EntityCollection<ProductInfoEntity>
		public EntityCollection<ProductInfoEntity> SelectByPriceSellLST_Paged(decimal PriceSell, int PageNumber, int PageSize)
		{
			EntityCollection<ProductInfoEntity> _ProductInfoCollection = new EntityCollection<ProductInfoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductInfoFields.PriceSell == PriceSell);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductInfoCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductInfoCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPriceSellRDT(decimal PriceSell)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductInfoCollection = new EntityCollection(new ProductInfoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductInfoFields.PriceSell == PriceSell);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductInfoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPriceSellRDT_Paged(decimal PriceSell, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductInfoCollection = new EntityCollection(new ProductInfoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductInfoFields.PriceSell == PriceSell);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductInfoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductInfoEntity>
		public EntityCollection<ProductInfoEntity> SelectByCurrencyLST(string Currency)
		{
			EntityCollection<ProductInfoEntity> _ProductInfoCollection = new EntityCollection<ProductInfoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductInfoFields.Currency == Currency);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductInfoCollection, filter, 0, null);
			}
			return _ProductInfoCollection;
		}
		
		// Return EntityCollection<ProductInfoEntity>
		public EntityCollection<ProductInfoEntity> SelectByCurrencyLST_Paged(string Currency, int PageNumber, int PageSize)
		{
			EntityCollection<ProductInfoEntity> _ProductInfoCollection = new EntityCollection<ProductInfoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductInfoFields.Currency == Currency);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductInfoCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductInfoCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCurrencyRDT(string Currency)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductInfoCollection = new EntityCollection(new ProductInfoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductInfoFields.Currency == Currency);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductInfoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCurrencyRDT_Paged(string Currency, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductInfoCollection = new EntityCollection(new ProductInfoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductInfoFields.Currency == Currency);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductInfoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductInfoEntity>
		public EntityCollection<ProductInfoEntity> SelectByCommissionPercentLST(double CommissionPercent)
		{
			EntityCollection<ProductInfoEntity> _ProductInfoCollection = new EntityCollection<ProductInfoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductInfoFields.CommissionPercent == CommissionPercent);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductInfoCollection, filter, 0, null);
			}
			return _ProductInfoCollection;
		}
		
		// Return EntityCollection<ProductInfoEntity>
		public EntityCollection<ProductInfoEntity> SelectByCommissionPercentLST_Paged(double CommissionPercent, int PageNumber, int PageSize)
		{
			EntityCollection<ProductInfoEntity> _ProductInfoCollection = new EntityCollection<ProductInfoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductInfoFields.CommissionPercent == CommissionPercent);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductInfoCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductInfoCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCommissionPercentRDT(double CommissionPercent)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductInfoCollection = new EntityCollection(new ProductInfoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductInfoFields.CommissionPercent == CommissionPercent);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductInfoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCommissionPercentRDT_Paged(double CommissionPercent, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductInfoCollection = new EntityCollection(new ProductInfoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductInfoFields.CommissionPercent == CommissionPercent);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductInfoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
