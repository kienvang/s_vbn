




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.ProductPhotosManagerBase
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
	public class ProductPhotosManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public ProductPhotosManagerBase()
		{
			// Nothing for now.
		}
		
		public ProductPhotosEntity Insert(ProductPhotosEntity _ProductPhotosEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_ProductPhotosEntity, true);
			}
			return _ProductPhotosEntity;
		}

		
		public ProductPhotosEntity Insert(Guid Id, Guid ProductId, string PhotoName, string Path, bool IsVisible)
		{
			ProductPhotosEntity _ProductPhotosEntity = new ProductPhotosEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_ProductPhotosEntity.Id = Id;
				_ProductPhotosEntity.ProductId = ProductId;
				_ProductPhotosEntity.PhotoName = PhotoName;
				_ProductPhotosEntity.Path = Path;
				_ProductPhotosEntity.IsVisible = IsVisible;
				adapter.SaveEntity(_ProductPhotosEntity, true);
			}
			return _ProductPhotosEntity;
		}

		public ProductPhotosEntity Insert(Guid ProductId, string PhotoName, string Path, bool IsVisible)
		{
			ProductPhotosEntity _ProductPhotosEntity = new ProductPhotosEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_ProductPhotosEntity.ProductId = ProductId;
				_ProductPhotosEntity.PhotoName = PhotoName;
				_ProductPhotosEntity.Path = Path;
				_ProductPhotosEntity.IsVisible = IsVisible;
				adapter.SaveEntity(_ProductPhotosEntity, true);
			}
			return _ProductPhotosEntity;
		}

		public bool Update(ProductPhotosEntity _ProductPhotosEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(ProductPhotosFields.Id == _ProductPhotosEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_ProductPhotosEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(ProductPhotosEntity _ProductPhotosEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_ProductPhotosEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, Guid ProductId, string PhotoName, string Path, bool IsVisible)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				ProductPhotosEntity _ProductPhotosEntity = new ProductPhotosEntity(Id);
				if (adapter.FetchEntity(_ProductPhotosEntity))
				{
				
					_ProductPhotosEntity.ProductId = ProductId;
					_ProductPhotosEntity.PhotoName = PhotoName;
					_ProductPhotosEntity.Path = Path;
					_ProductPhotosEntity.IsVisible = IsVisible;
					adapter.SaveEntity(_ProductPhotosEntity, true);
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
				ProductPhotosEntity _ProductPhotosEntity = new ProductPhotosEntity(Id);
				if (adapter.FetchEntity(_ProductPhotosEntity))
				{
					adapter.DeleteEntity(_ProductPhotosEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("ProductPhotosEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductPhotosFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductPhotosEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByProductId(Guid ProductId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductPhotosFields.ProductId == ProductId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductPhotosEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPhotoName(string PhotoName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductPhotosFields.PhotoName == PhotoName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductPhotosEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPath(string Path)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductPhotosFields.Path == Path);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductPhotosEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIsVisible(bool IsVisible)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductPhotosFields.IsVisible == IsVisible);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductPhotosEntity", filter);
			}
			return toReturn;
		}
		

		
		public ProductPhotosEntity SelectOne(Guid Id)
		{
			ProductPhotosEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				ProductPhotosEntity _ProductPhotosEntity = new ProductPhotosEntity(Id);
				if (adapter.FetchEntity(_ProductPhotosEntity))
				{
					toReturn = _ProductPhotosEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductPhotosCollection = new EntityCollection(new ProductPhotosEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductPhotosCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<ProductPhotosEntity>
		public EntityCollection<ProductPhotosEntity> SelectAllLST()
		{
			EntityCollection<ProductPhotosEntity> _ProductPhotosCollection = new EntityCollection<ProductPhotosEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductPhotosCollection, null, 0, null);
			}
			return _ProductPhotosCollection;
		}
		
		// Return EntityCollection<ProductPhotosEntity>
		public EntityCollection<ProductPhotosEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<ProductPhotosEntity> _ProductPhotosCollection = new EntityCollection<ProductPhotosEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductPhotosCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _ProductPhotosCollection;
		}


		
		// Return EntityCollection<ProductPhotosEntity>
		public EntityCollection<ProductPhotosEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<ProductPhotosEntity> _ProductPhotosCollection = new EntityCollection<ProductPhotosEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductPhotosFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductPhotosCollection, filter, 0, null);
			}
			return _ProductPhotosCollection;
		}
		
		// Return EntityCollection<ProductPhotosEntity>
		public EntityCollection<ProductPhotosEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<ProductPhotosEntity> _ProductPhotosCollection = new EntityCollection<ProductPhotosEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductPhotosFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductPhotosCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductPhotosCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductPhotosCollection = new EntityCollection(new ProductPhotosEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductPhotosFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductPhotosCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductPhotosCollection = new EntityCollection(new ProductPhotosEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductPhotosFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductPhotosCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductPhotosEntity>
		public EntityCollection<ProductPhotosEntity> SelectByProductIdLST(Guid ProductId)
		{
			EntityCollection<ProductPhotosEntity> _ProductPhotosCollection = new EntityCollection<ProductPhotosEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductPhotosFields.ProductId == ProductId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductPhotosCollection, filter, 0, null);
			}
			return _ProductPhotosCollection;
		}
		
		// Return EntityCollection<ProductPhotosEntity>
		public EntityCollection<ProductPhotosEntity> SelectByProductIdLST_Paged(Guid ProductId, int PageNumber, int PageSize)
		{
			EntityCollection<ProductPhotosEntity> _ProductPhotosCollection = new EntityCollection<ProductPhotosEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductPhotosFields.ProductId == ProductId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductPhotosCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductPhotosCollection;
		}
		
		// Return DataTable
		public DataTable SelectByProductIdRDT(Guid ProductId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductPhotosCollection = new EntityCollection(new ProductPhotosEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductPhotosFields.ProductId == ProductId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductPhotosCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByProductIdRDT_Paged(Guid ProductId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductPhotosCollection = new EntityCollection(new ProductPhotosEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductPhotosFields.ProductId == ProductId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductPhotosCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductPhotosEntity>
		public EntityCollection<ProductPhotosEntity> SelectByPhotoNameLST(string PhotoName)
		{
			EntityCollection<ProductPhotosEntity> _ProductPhotosCollection = new EntityCollection<ProductPhotosEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductPhotosFields.PhotoName == PhotoName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductPhotosCollection, filter, 0, null);
			}
			return _ProductPhotosCollection;
		}
		
		// Return EntityCollection<ProductPhotosEntity>
		public EntityCollection<ProductPhotosEntity> SelectByPhotoNameLST_Paged(string PhotoName, int PageNumber, int PageSize)
		{
			EntityCollection<ProductPhotosEntity> _ProductPhotosCollection = new EntityCollection<ProductPhotosEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductPhotosFields.PhotoName == PhotoName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductPhotosCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductPhotosCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPhotoNameRDT(string PhotoName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductPhotosCollection = new EntityCollection(new ProductPhotosEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductPhotosFields.PhotoName == PhotoName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductPhotosCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPhotoNameRDT_Paged(string PhotoName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductPhotosCollection = new EntityCollection(new ProductPhotosEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductPhotosFields.PhotoName == PhotoName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductPhotosCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductPhotosEntity>
		public EntityCollection<ProductPhotosEntity> SelectByPathLST(string Path)
		{
			EntityCollection<ProductPhotosEntity> _ProductPhotosCollection = new EntityCollection<ProductPhotosEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductPhotosFields.Path == Path);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductPhotosCollection, filter, 0, null);
			}
			return _ProductPhotosCollection;
		}
		
		// Return EntityCollection<ProductPhotosEntity>
		public EntityCollection<ProductPhotosEntity> SelectByPathLST_Paged(string Path, int PageNumber, int PageSize)
		{
			EntityCollection<ProductPhotosEntity> _ProductPhotosCollection = new EntityCollection<ProductPhotosEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductPhotosFields.Path == Path);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductPhotosCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductPhotosCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPathRDT(string Path)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductPhotosCollection = new EntityCollection(new ProductPhotosEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductPhotosFields.Path == Path);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductPhotosCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPathRDT_Paged(string Path, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductPhotosCollection = new EntityCollection(new ProductPhotosEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductPhotosFields.Path == Path);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductPhotosCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductPhotosEntity>
		public EntityCollection<ProductPhotosEntity> SelectByIsVisibleLST(bool IsVisible)
		{
			EntityCollection<ProductPhotosEntity> _ProductPhotosCollection = new EntityCollection<ProductPhotosEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductPhotosFields.IsVisible == IsVisible);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductPhotosCollection, filter, 0, null);
			}
			return _ProductPhotosCollection;
		}
		
		// Return EntityCollection<ProductPhotosEntity>
		public EntityCollection<ProductPhotosEntity> SelectByIsVisibleLST_Paged(bool IsVisible, int PageNumber, int PageSize)
		{
			EntityCollection<ProductPhotosEntity> _ProductPhotosCollection = new EntityCollection<ProductPhotosEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductPhotosFields.IsVisible == IsVisible);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductPhotosCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductPhotosCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIsVisibleRDT(bool IsVisible)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductPhotosCollection = new EntityCollection(new ProductPhotosEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductPhotosFields.IsVisible == IsVisible);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductPhotosCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIsVisibleRDT_Paged(bool IsVisible, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductPhotosCollection = new EntityCollection(new ProductPhotosEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductPhotosFields.IsVisible == IsVisible);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductPhotosCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
