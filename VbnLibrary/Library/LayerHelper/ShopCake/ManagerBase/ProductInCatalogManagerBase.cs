




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.ProductInCatalogManagerBase
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
	public class ProductInCatalogManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public ProductInCatalogManagerBase()
		{
			// Nothing for now.
		}
		
		public ProductInCatalogEntity Insert(ProductInCatalogEntity _ProductInCatalogEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_ProductInCatalogEntity, true);
			}
			return _ProductInCatalogEntity;
		}

		
		public ProductInCatalogEntity Insert(int Id, int CatId, Guid ProductId, int OrderIndex)
		{
			ProductInCatalogEntity _ProductInCatalogEntity = new ProductInCatalogEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_ProductInCatalogEntity.Id = Id;
				_ProductInCatalogEntity.CatId = CatId;
				_ProductInCatalogEntity.ProductId = ProductId;
				_ProductInCatalogEntity.OrderIndex = OrderIndex;
				adapter.SaveEntity(_ProductInCatalogEntity, true);
			}
			return _ProductInCatalogEntity;
		}

		public ProductInCatalogEntity Insert(int CatId, Guid ProductId, int OrderIndex)
		{
			ProductInCatalogEntity _ProductInCatalogEntity = new ProductInCatalogEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_ProductInCatalogEntity.CatId = CatId;
				_ProductInCatalogEntity.ProductId = ProductId;
				_ProductInCatalogEntity.OrderIndex = OrderIndex;
				adapter.SaveEntity(_ProductInCatalogEntity, true);
			}
			return _ProductInCatalogEntity;
		}

		public bool Update(ProductInCatalogEntity _ProductInCatalogEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(ProductInCatalogFields.Id == _ProductInCatalogEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_ProductInCatalogEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(ProductInCatalogEntity _ProductInCatalogEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_ProductInCatalogEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(int Id, int CatId, Guid ProductId, int OrderIndex)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				ProductInCatalogEntity _ProductInCatalogEntity = new ProductInCatalogEntity(Id);
				if (adapter.FetchEntity(_ProductInCatalogEntity))
				{
				
					_ProductInCatalogEntity.CatId = CatId;
					_ProductInCatalogEntity.ProductId = ProductId;
					_ProductInCatalogEntity.OrderIndex = OrderIndex;
					adapter.SaveEntity(_ProductInCatalogEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(int Id)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				ProductInCatalogEntity _ProductInCatalogEntity = new ProductInCatalogEntity(Id);
				if (adapter.FetchEntity(_ProductInCatalogEntity))
				{
					adapter.DeleteEntity(_ProductInCatalogEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("ProductInCatalogEntity", null);
			}
		}
		
		
		public int DeleteById(int Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductInCatalogFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductInCatalogEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCatId(int CatId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductInCatalogFields.CatId == CatId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductInCatalogEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByProductId(Guid ProductId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductInCatalogFields.ProductId == ProductId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductInCatalogEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByOrderIndex(int OrderIndex)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductInCatalogFields.OrderIndex == OrderIndex);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductInCatalogEntity", filter);
			}
			return toReturn;
		}
		

		
		public ProductInCatalogEntity SelectOne(int Id)
		{
			ProductInCatalogEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				ProductInCatalogEntity _ProductInCatalogEntity = new ProductInCatalogEntity(Id);
				if (adapter.FetchEntity(_ProductInCatalogEntity))
				{
					toReturn = _ProductInCatalogEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductInCatalogCollection = new EntityCollection(new ProductInCatalogEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductInCatalogCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<ProductInCatalogEntity>
		public EntityCollection<ProductInCatalogEntity> SelectAllLST()
		{
			EntityCollection<ProductInCatalogEntity> _ProductInCatalogCollection = new EntityCollection<ProductInCatalogEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductInCatalogCollection, null, 0, null);
			}
			return _ProductInCatalogCollection;
		}
		
		// Return EntityCollection<ProductInCatalogEntity>
		public EntityCollection<ProductInCatalogEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<ProductInCatalogEntity> _ProductInCatalogCollection = new EntityCollection<ProductInCatalogEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductInCatalogCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _ProductInCatalogCollection;
		}


		
		// Return EntityCollection<ProductInCatalogEntity>
		public EntityCollection<ProductInCatalogEntity> SelectByIdLST(int Id)
		{
			EntityCollection<ProductInCatalogEntity> _ProductInCatalogCollection = new EntityCollection<ProductInCatalogEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductInCatalogFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductInCatalogCollection, filter, 0, null);
			}
			return _ProductInCatalogCollection;
		}
		
		// Return EntityCollection<ProductInCatalogEntity>
		public EntityCollection<ProductInCatalogEntity> SelectByIdLST_Paged(int Id, int PageNumber, int PageSize)
		{
			EntityCollection<ProductInCatalogEntity> _ProductInCatalogCollection = new EntityCollection<ProductInCatalogEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductInCatalogFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductInCatalogCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductInCatalogCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(int Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductInCatalogCollection = new EntityCollection(new ProductInCatalogEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductInCatalogFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductInCatalogCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(int Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductInCatalogCollection = new EntityCollection(new ProductInCatalogEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductInCatalogFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductInCatalogCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductInCatalogEntity>
		public EntityCollection<ProductInCatalogEntity> SelectByCatIdLST(int CatId)
		{
			EntityCollection<ProductInCatalogEntity> _ProductInCatalogCollection = new EntityCollection<ProductInCatalogEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductInCatalogFields.CatId == CatId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductInCatalogCollection, filter, 0, null);
			}
			return _ProductInCatalogCollection;
		}
		
		// Return EntityCollection<ProductInCatalogEntity>
		public EntityCollection<ProductInCatalogEntity> SelectByCatIdLST_Paged(int CatId, int PageNumber, int PageSize)
		{
			EntityCollection<ProductInCatalogEntity> _ProductInCatalogCollection = new EntityCollection<ProductInCatalogEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductInCatalogFields.CatId == CatId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductInCatalogCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductInCatalogCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCatIdRDT(int CatId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductInCatalogCollection = new EntityCollection(new ProductInCatalogEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductInCatalogFields.CatId == CatId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductInCatalogCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCatIdRDT_Paged(int CatId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductInCatalogCollection = new EntityCollection(new ProductInCatalogEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductInCatalogFields.CatId == CatId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductInCatalogCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductInCatalogEntity>
		public EntityCollection<ProductInCatalogEntity> SelectByProductIdLST(Guid ProductId)
		{
			EntityCollection<ProductInCatalogEntity> _ProductInCatalogCollection = new EntityCollection<ProductInCatalogEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductInCatalogFields.ProductId == ProductId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductInCatalogCollection, filter, 0, null);
			}
			return _ProductInCatalogCollection;
		}
		
		// Return EntityCollection<ProductInCatalogEntity>
		public EntityCollection<ProductInCatalogEntity> SelectByProductIdLST_Paged(Guid ProductId, int PageNumber, int PageSize)
		{
			EntityCollection<ProductInCatalogEntity> _ProductInCatalogCollection = new EntityCollection<ProductInCatalogEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductInCatalogFields.ProductId == ProductId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductInCatalogCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductInCatalogCollection;
		}
		
		// Return DataTable
		public DataTable SelectByProductIdRDT(Guid ProductId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductInCatalogCollection = new EntityCollection(new ProductInCatalogEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductInCatalogFields.ProductId == ProductId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductInCatalogCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByProductIdRDT_Paged(Guid ProductId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductInCatalogCollection = new EntityCollection(new ProductInCatalogEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductInCatalogFields.ProductId == ProductId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductInCatalogCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductInCatalogEntity>
		public EntityCollection<ProductInCatalogEntity> SelectByOrderIndexLST(int OrderIndex)
		{
			EntityCollection<ProductInCatalogEntity> _ProductInCatalogCollection = new EntityCollection<ProductInCatalogEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductInCatalogFields.OrderIndex == OrderIndex);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductInCatalogCollection, filter, 0, null);
			}
			return _ProductInCatalogCollection;
		}
		
		// Return EntityCollection<ProductInCatalogEntity>
		public EntityCollection<ProductInCatalogEntity> SelectByOrderIndexLST_Paged(int OrderIndex, int PageNumber, int PageSize)
		{
			EntityCollection<ProductInCatalogEntity> _ProductInCatalogCollection = new EntityCollection<ProductInCatalogEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductInCatalogFields.OrderIndex == OrderIndex);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductInCatalogCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductInCatalogCollection;
		}
		
		// Return DataTable
		public DataTable SelectByOrderIndexRDT(int OrderIndex)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductInCatalogCollection = new EntityCollection(new ProductInCatalogEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductInCatalogFields.OrderIndex == OrderIndex);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductInCatalogCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByOrderIndexRDT_Paged(int OrderIndex, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductInCatalogCollection = new EntityCollection(new ProductInCatalogEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductInCatalogFields.OrderIndex == OrderIndex);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductInCatalogCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
