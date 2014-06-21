




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.ProductSubManagerBase
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
	public class ProductSubManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public ProductSubManagerBase()
		{
			// Nothing for now.
		}
		
		public ProductSubEntity Insert(ProductSubEntity _ProductSubEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_ProductSubEntity, true);
			}
			return _ProductSubEntity;
		}

		
		public ProductSubEntity Insert(Guid Id, Guid ProductId, string ProductName, decimal Price, string Description, string CreatedBy)
		{
			ProductSubEntity _ProductSubEntity = new ProductSubEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_ProductSubEntity.Id = Id;
				_ProductSubEntity.ProductId = ProductId;
				_ProductSubEntity.ProductName = ProductName;
				_ProductSubEntity.Price = Price;
				_ProductSubEntity.Description = Description;
				_ProductSubEntity.CreatedBy = CreatedBy;
				adapter.SaveEntity(_ProductSubEntity, true);
			}
			return _ProductSubEntity;
		}

		public ProductSubEntity Insert(Guid ProductId, string ProductName, decimal Price, string Description, string CreatedBy)
		{
			ProductSubEntity _ProductSubEntity = new ProductSubEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_ProductSubEntity.ProductId = ProductId;
				_ProductSubEntity.ProductName = ProductName;
				_ProductSubEntity.Price = Price;
				_ProductSubEntity.Description = Description;
				_ProductSubEntity.CreatedBy = CreatedBy;
				adapter.SaveEntity(_ProductSubEntity, true);
			}
			return _ProductSubEntity;
		}

		public bool Update(ProductSubEntity _ProductSubEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(ProductSubFields.Id == _ProductSubEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_ProductSubEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(ProductSubEntity _ProductSubEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_ProductSubEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, Guid ProductId, string ProductName, decimal Price, string Description, string CreatedBy)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				ProductSubEntity _ProductSubEntity = new ProductSubEntity(Id);
				if (adapter.FetchEntity(_ProductSubEntity))
				{
				
					_ProductSubEntity.ProductId = ProductId;
					_ProductSubEntity.ProductName = ProductName;
					_ProductSubEntity.Price = Price;
					_ProductSubEntity.Description = Description;
					_ProductSubEntity.CreatedBy = CreatedBy;
					adapter.SaveEntity(_ProductSubEntity, true);
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
				ProductSubEntity _ProductSubEntity = new ProductSubEntity(Id);
				if (adapter.FetchEntity(_ProductSubEntity))
				{
					adapter.DeleteEntity(_ProductSubEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("ProductSubEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductSubFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductSubEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByProductId(Guid ProductId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductSubFields.ProductId == ProductId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductSubEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByProductName(string ProductName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductSubFields.ProductName == ProductName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductSubEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPrice(decimal Price)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductSubFields.Price == Price);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductSubEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByDescription(string Description)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductSubFields.Description == Description);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductSubEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCreatedBy(string CreatedBy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductSubFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductSubEntity", filter);
			}
			return toReturn;
		}
		

		
		public ProductSubEntity SelectOne(Guid Id)
		{
			ProductSubEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				ProductSubEntity _ProductSubEntity = new ProductSubEntity(Id);
				if (adapter.FetchEntity(_ProductSubEntity))
				{
					toReturn = _ProductSubEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductSubCollection = new EntityCollection(new ProductSubEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductSubCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<ProductSubEntity>
		public EntityCollection<ProductSubEntity> SelectAllLST()
		{
			EntityCollection<ProductSubEntity> _ProductSubCollection = new EntityCollection<ProductSubEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductSubCollection, null, 0, null);
			}
			return _ProductSubCollection;
		}
		
		// Return EntityCollection<ProductSubEntity>
		public EntityCollection<ProductSubEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<ProductSubEntity> _ProductSubCollection = new EntityCollection<ProductSubEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductSubCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _ProductSubCollection;
		}


		
		// Return EntityCollection<ProductSubEntity>
		public EntityCollection<ProductSubEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<ProductSubEntity> _ProductSubCollection = new EntityCollection<ProductSubEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductSubFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductSubCollection, filter, 0, null);
			}
			return _ProductSubCollection;
		}
		
		// Return EntityCollection<ProductSubEntity>
		public EntityCollection<ProductSubEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<ProductSubEntity> _ProductSubCollection = new EntityCollection<ProductSubEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductSubFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductSubCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductSubCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductSubCollection = new EntityCollection(new ProductSubEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductSubFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductSubCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductSubCollection = new EntityCollection(new ProductSubEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductSubFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductSubCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductSubEntity>
		public EntityCollection<ProductSubEntity> SelectByProductIdLST(Guid ProductId)
		{
			EntityCollection<ProductSubEntity> _ProductSubCollection = new EntityCollection<ProductSubEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductSubFields.ProductId == ProductId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductSubCollection, filter, 0, null);
			}
			return _ProductSubCollection;
		}
		
		// Return EntityCollection<ProductSubEntity>
		public EntityCollection<ProductSubEntity> SelectByProductIdLST_Paged(Guid ProductId, int PageNumber, int PageSize)
		{
			EntityCollection<ProductSubEntity> _ProductSubCollection = new EntityCollection<ProductSubEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductSubFields.ProductId == ProductId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductSubCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductSubCollection;
		}
		
		// Return DataTable
		public DataTable SelectByProductIdRDT(Guid ProductId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductSubCollection = new EntityCollection(new ProductSubEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductSubFields.ProductId == ProductId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductSubCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByProductIdRDT_Paged(Guid ProductId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductSubCollection = new EntityCollection(new ProductSubEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductSubFields.ProductId == ProductId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductSubCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductSubEntity>
		public EntityCollection<ProductSubEntity> SelectByProductNameLST(string ProductName)
		{
			EntityCollection<ProductSubEntity> _ProductSubCollection = new EntityCollection<ProductSubEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductSubFields.ProductName == ProductName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductSubCollection, filter, 0, null);
			}
			return _ProductSubCollection;
		}
		
		// Return EntityCollection<ProductSubEntity>
		public EntityCollection<ProductSubEntity> SelectByProductNameLST_Paged(string ProductName, int PageNumber, int PageSize)
		{
			EntityCollection<ProductSubEntity> _ProductSubCollection = new EntityCollection<ProductSubEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductSubFields.ProductName == ProductName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductSubCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductSubCollection;
		}
		
		// Return DataTable
		public DataTable SelectByProductNameRDT(string ProductName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductSubCollection = new EntityCollection(new ProductSubEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductSubFields.ProductName == ProductName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductSubCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByProductNameRDT_Paged(string ProductName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductSubCollection = new EntityCollection(new ProductSubEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductSubFields.ProductName == ProductName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductSubCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductSubEntity>
		public EntityCollection<ProductSubEntity> SelectByPriceLST(decimal Price)
		{
			EntityCollection<ProductSubEntity> _ProductSubCollection = new EntityCollection<ProductSubEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductSubFields.Price == Price);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductSubCollection, filter, 0, null);
			}
			return _ProductSubCollection;
		}
		
		// Return EntityCollection<ProductSubEntity>
		public EntityCollection<ProductSubEntity> SelectByPriceLST_Paged(decimal Price, int PageNumber, int PageSize)
		{
			EntityCollection<ProductSubEntity> _ProductSubCollection = new EntityCollection<ProductSubEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductSubFields.Price == Price);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductSubCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductSubCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPriceRDT(decimal Price)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductSubCollection = new EntityCollection(new ProductSubEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductSubFields.Price == Price);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductSubCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPriceRDT_Paged(decimal Price, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductSubCollection = new EntityCollection(new ProductSubEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductSubFields.Price == Price);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductSubCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductSubEntity>
		public EntityCollection<ProductSubEntity> SelectByDescriptionLST(string Description)
		{
			EntityCollection<ProductSubEntity> _ProductSubCollection = new EntityCollection<ProductSubEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductSubFields.Description == Description);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductSubCollection, filter, 0, null);
			}
			return _ProductSubCollection;
		}
		
		// Return EntityCollection<ProductSubEntity>
		public EntityCollection<ProductSubEntity> SelectByDescriptionLST_Paged(string Description, int PageNumber, int PageSize)
		{
			EntityCollection<ProductSubEntity> _ProductSubCollection = new EntityCollection<ProductSubEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductSubFields.Description == Description);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductSubCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductSubCollection;
		}
		
		// Return DataTable
		public DataTable SelectByDescriptionRDT(string Description)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductSubCollection = new EntityCollection(new ProductSubEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductSubFields.Description == Description);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductSubCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByDescriptionRDT_Paged(string Description, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductSubCollection = new EntityCollection(new ProductSubEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductSubFields.Description == Description);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductSubCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductSubEntity>
		public EntityCollection<ProductSubEntity> SelectByCreatedByLST(string CreatedBy)
		{
			EntityCollection<ProductSubEntity> _ProductSubCollection = new EntityCollection<ProductSubEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductSubFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductSubCollection, filter, 0, null);
			}
			return _ProductSubCollection;
		}
		
		// Return EntityCollection<ProductSubEntity>
		public EntityCollection<ProductSubEntity> SelectByCreatedByLST_Paged(string CreatedBy, int PageNumber, int PageSize)
		{
			EntityCollection<ProductSubEntity> _ProductSubCollection = new EntityCollection<ProductSubEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductSubFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductSubCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductSubCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedByRDT(string CreatedBy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductSubCollection = new EntityCollection(new ProductSubEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductSubFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductSubCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedByRDT_Paged(string CreatedBy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductSubCollection = new EntityCollection(new ProductSubEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductSubFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductSubCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
