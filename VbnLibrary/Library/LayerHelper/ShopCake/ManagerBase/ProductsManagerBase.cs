




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.ProductsManagerBase
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
	public class ProductsManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public ProductsManagerBase()
		{
			// Nothing for now.
		}
		
		public ProductsEntity Insert(ProductsEntity _ProductsEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_ProductsEntity, true);
			}
			return _ProductsEntity;
		}

		
		public ProductsEntity Insert(Guid Id, long IntId, string ProductName, string ProductCode, string TextId, string Abstract, decimal Price, string UnitCode, string Thumbnail, string Warranty, string Detail, int Amount, int Locked, int Views, Guid SupplierId, bool IsVisible, int SortOrder, string PositionId, int CatalogId, bool IsPromotion, bool IsDiscount, string CreatedBy, DateTime CreatedDate, string UpdatedBy, DateTime UpdatedDate, bool IsDelete)
		{
			ProductsEntity _ProductsEntity = new ProductsEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_ProductsEntity.Id = Id;
				_ProductsEntity.ProductName = ProductName;
				_ProductsEntity.ProductCode = ProductCode;
				_ProductsEntity.TextId = TextId;
				_ProductsEntity.Abstract = Abstract;
				_ProductsEntity.Price = Price;
				_ProductsEntity.UnitCode = UnitCode;
				_ProductsEntity.Thumbnail = Thumbnail;
				_ProductsEntity.Warranty = Warranty;
				_ProductsEntity.Detail = Detail;
				_ProductsEntity.Amount = Amount;
				_ProductsEntity.Locked = Locked;
				_ProductsEntity.Views = Views;
				_ProductsEntity.SupplierId = SupplierId;
				_ProductsEntity.IsVisible = IsVisible;
				_ProductsEntity.SortOrder = SortOrder;
				_ProductsEntity.PositionId = PositionId;
				_ProductsEntity.CatalogId = CatalogId;
				_ProductsEntity.IsPromotion = IsPromotion;
				_ProductsEntity.IsDiscount = IsDiscount;
				_ProductsEntity.CreatedBy = CreatedBy;
				_ProductsEntity.CreatedDate = CreatedDate;
				_ProductsEntity.UpdatedBy = UpdatedBy;
				_ProductsEntity.UpdatedDate = UpdatedDate;
				_ProductsEntity.IsDelete = IsDelete;
				adapter.SaveEntity(_ProductsEntity, true);
			}
			return _ProductsEntity;
		}

		public ProductsEntity Insert(string ProductName, string ProductCode, string TextId, string Abstract, decimal Price, string UnitCode, string Thumbnail, string Warranty, string Detail, int Amount, int Locked, int Views, Guid SupplierId, bool IsVisible, int SortOrder, string PositionId, int CatalogId, bool IsPromotion, bool IsDiscount, string CreatedBy, DateTime CreatedDate, string UpdatedBy, DateTime UpdatedDate, bool IsDelete)
		{
			ProductsEntity _ProductsEntity = new ProductsEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_ProductsEntity.ProductName = ProductName;
				_ProductsEntity.ProductCode = ProductCode;
				_ProductsEntity.TextId = TextId;
				_ProductsEntity.Abstract = Abstract;
				_ProductsEntity.Price = Price;
				_ProductsEntity.UnitCode = UnitCode;
				_ProductsEntity.Thumbnail = Thumbnail;
				_ProductsEntity.Warranty = Warranty;
				_ProductsEntity.Detail = Detail;
				_ProductsEntity.Amount = Amount;
				_ProductsEntity.Locked = Locked;
				_ProductsEntity.Views = Views;
				_ProductsEntity.SupplierId = SupplierId;
				_ProductsEntity.IsVisible = IsVisible;
				_ProductsEntity.SortOrder = SortOrder;
				_ProductsEntity.PositionId = PositionId;
				_ProductsEntity.CatalogId = CatalogId;
				_ProductsEntity.IsPromotion = IsPromotion;
				_ProductsEntity.IsDiscount = IsDiscount;
				_ProductsEntity.CreatedBy = CreatedBy;
				_ProductsEntity.CreatedDate = CreatedDate;
				_ProductsEntity.UpdatedBy = UpdatedBy;
				_ProductsEntity.UpdatedDate = UpdatedDate;
				_ProductsEntity.IsDelete = IsDelete;
				adapter.SaveEntity(_ProductsEntity, true);
			}
			return _ProductsEntity;
		}

		public bool Update(ProductsEntity _ProductsEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(ProductsFields.Id == _ProductsEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_ProductsEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(ProductsEntity _ProductsEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_ProductsEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, long IntId, string ProductName, string ProductCode, string TextId, string Abstract, decimal Price, string UnitCode, string Thumbnail, string Warranty, string Detail, int Amount, int Locked, int Views, Guid SupplierId, bool IsVisible, int SortOrder, string PositionId, int CatalogId, bool IsPromotion, bool IsDiscount, string CreatedBy, DateTime CreatedDate, string UpdatedBy, DateTime UpdatedDate, bool IsDelete)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				ProductsEntity _ProductsEntity = new ProductsEntity(Id);
				if (adapter.FetchEntity(_ProductsEntity))
				{
				
					_ProductsEntity.ProductName = ProductName;
					_ProductsEntity.ProductCode = ProductCode;
					_ProductsEntity.TextId = TextId;
					_ProductsEntity.Abstract = Abstract;
					_ProductsEntity.Price = Price;
					_ProductsEntity.UnitCode = UnitCode;
					_ProductsEntity.Thumbnail = Thumbnail;
					_ProductsEntity.Warranty = Warranty;
					_ProductsEntity.Detail = Detail;
					_ProductsEntity.Amount = Amount;
					_ProductsEntity.Locked = Locked;
					_ProductsEntity.Views = Views;
					_ProductsEntity.SupplierId = SupplierId;
					_ProductsEntity.IsVisible = IsVisible;
					_ProductsEntity.SortOrder = SortOrder;
					_ProductsEntity.PositionId = PositionId;
					_ProductsEntity.CatalogId = CatalogId;
					_ProductsEntity.IsPromotion = IsPromotion;
					_ProductsEntity.IsDiscount = IsDiscount;
					_ProductsEntity.CreatedBy = CreatedBy;
					_ProductsEntity.CreatedDate = CreatedDate;
					_ProductsEntity.UpdatedBy = UpdatedBy;
					_ProductsEntity.UpdatedDate = UpdatedDate;
					_ProductsEntity.IsDelete = IsDelete;
					adapter.SaveEntity(_ProductsEntity, true);
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
				ProductsEntity _ProductsEntity = new ProductsEntity(Id);
				if (adapter.FetchEntity(_ProductsEntity))
				{
					adapter.DeleteEntity(_ProductsEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("ProductsEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIntId(long IntId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.IntId == IntId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByProductName(string ProductName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.ProductName == ProductName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByProductCode(string ProductCode)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.ProductCode == ProductCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTextId(string TextId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.TextId == TextId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByAbstract(string Abstract)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.Abstract == Abstract);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPrice(decimal Price)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.Price == Price);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByUnitCode(string UnitCode)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.UnitCode == UnitCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByThumbnail(string Thumbnail)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.Thumbnail == Thumbnail);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByWarranty(string Warranty)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.Warranty == Warranty);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByDetail(string Detail)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.Detail == Detail);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByAmount(int Amount)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.Amount == Amount);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLocked(int Locked)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.Locked == Locked);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByViews(int Views)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.Views == Views);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySupplierId(Guid SupplierId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.SupplierId == SupplierId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIsVisible(bool IsVisible)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.IsVisible == IsVisible);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySortOrder(int SortOrder)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.SortOrder == SortOrder);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPositionId(string PositionId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.PositionId == PositionId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCatalogId(int CatalogId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.CatalogId == CatalogId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIsPromotion(bool IsPromotion)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.IsPromotion == IsPromotion);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIsDiscount(bool IsDiscount)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.IsDiscount == IsDiscount);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCreatedBy(string CreatedBy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCreatedDate(DateTime CreatedDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByUpdatedBy(string UpdatedBy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByUpdatedDate(DateTime UpdatedDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIsDelete(bool IsDelete)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.IsDelete == IsDelete);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductsEntity", filter);
			}
			return toReturn;
		}
		

		
		public ProductsEntity SelectOne(Guid Id)
		{
			ProductsEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				ProductsEntity _ProductsEntity = new ProductsEntity(Id);
				if (adapter.FetchEntity(_ProductsEntity))
				{
					toReturn = _ProductsEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectAllLST()
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, null, 0, null);
			}
			return _ProductsCollection;
		}
		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _ProductsCollection;
		}


		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null);
			}
			return _ProductsCollection;
		}
		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByIntIdLST(long IntId)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.IntId == IntId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null);
			}
			return _ProductsCollection;
		}
		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByIntIdLST_Paged(long IntId, int PageNumber, int PageSize)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.IntId == IntId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIntIdRDT(long IntId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.IntId == IntId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIntIdRDT_Paged(long IntId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.IntId == IntId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByProductNameLST(string ProductName)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.ProductName == ProductName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null);
			}
			return _ProductsCollection;
		}
		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByProductNameLST_Paged(string ProductName, int PageNumber, int PageSize)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.ProductName == ProductName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByProductNameRDT(string ProductName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.ProductName == ProductName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByProductNameRDT_Paged(string ProductName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.ProductName == ProductName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByProductCodeLST(string ProductCode)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.ProductCode == ProductCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null);
			}
			return _ProductsCollection;
		}
		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByProductCodeLST_Paged(string ProductCode, int PageNumber, int PageSize)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.ProductCode == ProductCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByProductCodeRDT(string ProductCode)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.ProductCode == ProductCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByProductCodeRDT_Paged(string ProductCode, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.ProductCode == ProductCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByTextIdLST(string TextId)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.TextId == TextId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null);
			}
			return _ProductsCollection;
		}
		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByTextIdLST_Paged(string TextId, int PageNumber, int PageSize)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.TextId == TextId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTextIdRDT(string TextId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.TextId == TextId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTextIdRDT_Paged(string TextId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.TextId == TextId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByAbstractLST(string Abstract)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.Abstract == Abstract);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null);
			}
			return _ProductsCollection;
		}
		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByAbstractLST_Paged(string Abstract, int PageNumber, int PageSize)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.Abstract == Abstract);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByAbstractRDT(string Abstract)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.Abstract == Abstract);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByAbstractRDT_Paged(string Abstract, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.Abstract == Abstract);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByPriceLST(decimal Price)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.Price == Price);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null);
			}
			return _ProductsCollection;
		}
		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByPriceLST_Paged(decimal Price, int PageNumber, int PageSize)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.Price == Price);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPriceRDT(decimal Price)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.Price == Price);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPriceRDT_Paged(decimal Price, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.Price == Price);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByUnitCodeLST(string UnitCode)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.UnitCode == UnitCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null);
			}
			return _ProductsCollection;
		}
		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByUnitCodeLST_Paged(string UnitCode, int PageNumber, int PageSize)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.UnitCode == UnitCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUnitCodeRDT(string UnitCode)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.UnitCode == UnitCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUnitCodeRDT_Paged(string UnitCode, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.UnitCode == UnitCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByThumbnailLST(string Thumbnail)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.Thumbnail == Thumbnail);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null);
			}
			return _ProductsCollection;
		}
		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByThumbnailLST_Paged(string Thumbnail, int PageNumber, int PageSize)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.Thumbnail == Thumbnail);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByThumbnailRDT(string Thumbnail)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.Thumbnail == Thumbnail);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByThumbnailRDT_Paged(string Thumbnail, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.Thumbnail == Thumbnail);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByWarrantyLST(string Warranty)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.Warranty == Warranty);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null);
			}
			return _ProductsCollection;
		}
		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByWarrantyLST_Paged(string Warranty, int PageNumber, int PageSize)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.Warranty == Warranty);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByWarrantyRDT(string Warranty)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.Warranty == Warranty);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByWarrantyRDT_Paged(string Warranty, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.Warranty == Warranty);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByDetailLST(string Detail)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.Detail == Detail);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null);
			}
			return _ProductsCollection;
		}
		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByDetailLST_Paged(string Detail, int PageNumber, int PageSize)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.Detail == Detail);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByDetailRDT(string Detail)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.Detail == Detail);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByDetailRDT_Paged(string Detail, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.Detail == Detail);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByAmountLST(int Amount)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.Amount == Amount);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null);
			}
			return _ProductsCollection;
		}
		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByAmountLST_Paged(int Amount, int PageNumber, int PageSize)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.Amount == Amount);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByAmountRDT(int Amount)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.Amount == Amount);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByAmountRDT_Paged(int Amount, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.Amount == Amount);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByLockedLST(int Locked)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.Locked == Locked);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null);
			}
			return _ProductsCollection;
		}
		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByLockedLST_Paged(int Locked, int PageNumber, int PageSize)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.Locked == Locked);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLockedRDT(int Locked)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.Locked == Locked);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLockedRDT_Paged(int Locked, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.Locked == Locked);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByViewsLST(int Views)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.Views == Views);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null);
			}
			return _ProductsCollection;
		}
		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByViewsLST_Paged(int Views, int PageNumber, int PageSize)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.Views == Views);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByViewsRDT(int Views)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.Views == Views);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByViewsRDT_Paged(int Views, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.Views == Views);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectBySupplierIdLST(Guid SupplierId)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.SupplierId == SupplierId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null);
			}
			return _ProductsCollection;
		}
		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectBySupplierIdLST_Paged(Guid SupplierId, int PageNumber, int PageSize)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.SupplierId == SupplierId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductsCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySupplierIdRDT(Guid SupplierId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.SupplierId == SupplierId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySupplierIdRDT_Paged(Guid SupplierId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.SupplierId == SupplierId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByIsVisibleLST(bool IsVisible)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.IsVisible == IsVisible);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null);
			}
			return _ProductsCollection;
		}
		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByIsVisibleLST_Paged(bool IsVisible, int PageNumber, int PageSize)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.IsVisible == IsVisible);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIsVisibleRDT(bool IsVisible)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.IsVisible == IsVisible);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIsVisibleRDT_Paged(bool IsVisible, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.IsVisible == IsVisible);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectBySortOrderLST(int SortOrder)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.SortOrder == SortOrder);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null);
			}
			return _ProductsCollection;
		}
		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectBySortOrderLST_Paged(int SortOrder, int PageNumber, int PageSize)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.SortOrder == SortOrder);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductsCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySortOrderRDT(int SortOrder)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.SortOrder == SortOrder);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySortOrderRDT_Paged(int SortOrder, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.SortOrder == SortOrder);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByPositionIdLST(string PositionId)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.PositionId == PositionId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null);
			}
			return _ProductsCollection;
		}
		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByPositionIdLST_Paged(string PositionId, int PageNumber, int PageSize)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.PositionId == PositionId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPositionIdRDT(string PositionId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.PositionId == PositionId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPositionIdRDT_Paged(string PositionId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.PositionId == PositionId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByCatalogIdLST(int CatalogId)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.CatalogId == CatalogId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null);
			}
			return _ProductsCollection;
		}
		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByCatalogIdLST_Paged(int CatalogId, int PageNumber, int PageSize)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.CatalogId == CatalogId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCatalogIdRDT(int CatalogId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.CatalogId == CatalogId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCatalogIdRDT_Paged(int CatalogId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.CatalogId == CatalogId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByIsPromotionLST(bool IsPromotion)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.IsPromotion == IsPromotion);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null);
			}
			return _ProductsCollection;
		}
		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByIsPromotionLST_Paged(bool IsPromotion, int PageNumber, int PageSize)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.IsPromotion == IsPromotion);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIsPromotionRDT(bool IsPromotion)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.IsPromotion == IsPromotion);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIsPromotionRDT_Paged(bool IsPromotion, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.IsPromotion == IsPromotion);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByIsDiscountLST(bool IsDiscount)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.IsDiscount == IsDiscount);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null);
			}
			return _ProductsCollection;
		}
		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByIsDiscountLST_Paged(bool IsDiscount, int PageNumber, int PageSize)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.IsDiscount == IsDiscount);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIsDiscountRDT(bool IsDiscount)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.IsDiscount == IsDiscount);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIsDiscountRDT_Paged(bool IsDiscount, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.IsDiscount == IsDiscount);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByCreatedByLST(string CreatedBy)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null);
			}
			return _ProductsCollection;
		}
		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByCreatedByLST_Paged(string CreatedBy, int PageNumber, int PageSize)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedByRDT(string CreatedBy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedByRDT_Paged(string CreatedBy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByCreatedDateLST(DateTime CreatedDate)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null);
			}
			return _ProductsCollection;
		}
		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByCreatedDateLST_Paged(DateTime CreatedDate, int PageNumber, int PageSize)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedDateRDT(DateTime CreatedDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedDateRDT_Paged(DateTime CreatedDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByUpdatedByLST(string UpdatedBy)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null);
			}
			return _ProductsCollection;
		}
		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByUpdatedByLST_Paged(string UpdatedBy, int PageNumber, int PageSize)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedByRDT(string UpdatedBy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedByRDT_Paged(string UpdatedBy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByUpdatedDateLST(DateTime UpdatedDate)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null);
			}
			return _ProductsCollection;
		}
		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByUpdatedDateLST_Paged(DateTime UpdatedDate, int PageNumber, int PageSize)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedDateRDT(DateTime UpdatedDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedDateRDT_Paged(DateTime UpdatedDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByIsDeleteLST(bool IsDelete)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.IsDelete == IsDelete);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null);
			}
			return _ProductsCollection;
		}
		
		// Return EntityCollection<ProductsEntity>
		public EntityCollection<ProductsEntity> SelectByIsDeleteLST_Paged(bool IsDelete, int PageNumber, int PageSize)
		{
			EntityCollection<ProductsEntity> _ProductsCollection = new EntityCollection<ProductsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.IsDelete == IsDelete);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIsDeleteRDT(bool IsDelete)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.IsDelete == IsDelete);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIsDeleteRDT_Paged(bool IsDelete, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductsCollection = new EntityCollection(new ProductsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductsFields.IsDelete == IsDelete);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
