




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.ProductRegisterManagerBase
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
	public class ProductRegisterManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public ProductRegisterManagerBase()
		{
			// Nothing for now.
		}
		
		public ProductRegisterEntity Insert(ProductRegisterEntity _ProductRegisterEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_ProductRegisterEntity, true);
			}
			return _ProductRegisterEntity;
		}

		
		public ProductRegisterEntity Insert(Guid Id, string UserName, string ProductName, string Abstract, string Thumbnail, string Warranty, int Quantity, decimal PriceBuy, decimal PriceSell, string Detail, DateTime CreatedDate, bool Approved, string CompanyName, string CompanyPhone, string CompanyAddress, string CompanyNumberTax, string CompanyEmail, string Note)
		{
			ProductRegisterEntity _ProductRegisterEntity = new ProductRegisterEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_ProductRegisterEntity.Id = Id;
				_ProductRegisterEntity.UserName = UserName;
				_ProductRegisterEntity.ProductName = ProductName;
				_ProductRegisterEntity.Abstract = Abstract;
				_ProductRegisterEntity.Thumbnail = Thumbnail;
				_ProductRegisterEntity.Warranty = Warranty;
				_ProductRegisterEntity.Quantity = Quantity;
				_ProductRegisterEntity.PriceBuy = PriceBuy;
				_ProductRegisterEntity.PriceSell = PriceSell;
				_ProductRegisterEntity.Detail = Detail;
				_ProductRegisterEntity.CreatedDate = CreatedDate;
				_ProductRegisterEntity.Approved = Approved;
				_ProductRegisterEntity.CompanyName = CompanyName;
				_ProductRegisterEntity.CompanyPhone = CompanyPhone;
				_ProductRegisterEntity.CompanyAddress = CompanyAddress;
				_ProductRegisterEntity.CompanyNumberTax = CompanyNumberTax;
				_ProductRegisterEntity.CompanyEmail = CompanyEmail;
				_ProductRegisterEntity.Note = Note;
				adapter.SaveEntity(_ProductRegisterEntity, true);
			}
			return _ProductRegisterEntity;
		}

		public ProductRegisterEntity Insert(string UserName, string ProductName, string Abstract, string Thumbnail, string Warranty, int Quantity, decimal PriceBuy, decimal PriceSell, string Detail, DateTime CreatedDate, bool Approved, string CompanyName, string CompanyPhone, string CompanyAddress, string CompanyNumberTax, string CompanyEmail, string Note)
		{
			ProductRegisterEntity _ProductRegisterEntity = new ProductRegisterEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_ProductRegisterEntity.UserName = UserName;
				_ProductRegisterEntity.ProductName = ProductName;
				_ProductRegisterEntity.Abstract = Abstract;
				_ProductRegisterEntity.Thumbnail = Thumbnail;
				_ProductRegisterEntity.Warranty = Warranty;
				_ProductRegisterEntity.Quantity = Quantity;
				_ProductRegisterEntity.PriceBuy = PriceBuy;
				_ProductRegisterEntity.PriceSell = PriceSell;
				_ProductRegisterEntity.Detail = Detail;
				_ProductRegisterEntity.CreatedDate = CreatedDate;
				_ProductRegisterEntity.Approved = Approved;
				_ProductRegisterEntity.CompanyName = CompanyName;
				_ProductRegisterEntity.CompanyPhone = CompanyPhone;
				_ProductRegisterEntity.CompanyAddress = CompanyAddress;
				_ProductRegisterEntity.CompanyNumberTax = CompanyNumberTax;
				_ProductRegisterEntity.CompanyEmail = CompanyEmail;
				_ProductRegisterEntity.Note = Note;
				adapter.SaveEntity(_ProductRegisterEntity, true);
			}
			return _ProductRegisterEntity;
		}

		public bool Update(ProductRegisterEntity _ProductRegisterEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(ProductRegisterFields.Id == _ProductRegisterEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_ProductRegisterEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(ProductRegisterEntity _ProductRegisterEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_ProductRegisterEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string UserName, string ProductName, string Abstract, string Thumbnail, string Warranty, int Quantity, decimal PriceBuy, decimal PriceSell, string Detail, DateTime CreatedDate, bool Approved, string CompanyName, string CompanyPhone, string CompanyAddress, string CompanyNumberTax, string CompanyEmail, string Note)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				ProductRegisterEntity _ProductRegisterEntity = new ProductRegisterEntity(Id);
				if (adapter.FetchEntity(_ProductRegisterEntity))
				{
				
					_ProductRegisterEntity.UserName = UserName;
					_ProductRegisterEntity.ProductName = ProductName;
					_ProductRegisterEntity.Abstract = Abstract;
					_ProductRegisterEntity.Thumbnail = Thumbnail;
					_ProductRegisterEntity.Warranty = Warranty;
					_ProductRegisterEntity.Quantity = Quantity;
					_ProductRegisterEntity.PriceBuy = PriceBuy;
					_ProductRegisterEntity.PriceSell = PriceSell;
					_ProductRegisterEntity.Detail = Detail;
					_ProductRegisterEntity.CreatedDate = CreatedDate;
					_ProductRegisterEntity.Approved = Approved;
					_ProductRegisterEntity.CompanyName = CompanyName;
					_ProductRegisterEntity.CompanyPhone = CompanyPhone;
					_ProductRegisterEntity.CompanyAddress = CompanyAddress;
					_ProductRegisterEntity.CompanyNumberTax = CompanyNumberTax;
					_ProductRegisterEntity.CompanyEmail = CompanyEmail;
					_ProductRegisterEntity.Note = Note;
					adapter.SaveEntity(_ProductRegisterEntity, true);
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
				ProductRegisterEntity _ProductRegisterEntity = new ProductRegisterEntity(Id);
				if (adapter.FetchEntity(_ProductRegisterEntity))
				{
					adapter.DeleteEntity(_ProductRegisterEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("ProductRegisterEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductRegisterEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByUserName(string UserName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.UserName == UserName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductRegisterEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByProductName(string ProductName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.ProductName == ProductName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductRegisterEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByAbstract(string Abstract)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.Abstract == Abstract);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductRegisterEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByThumbnail(string Thumbnail)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.Thumbnail == Thumbnail);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductRegisterEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByWarranty(string Warranty)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.Warranty == Warranty);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductRegisterEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByQuantity(int Quantity)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.Quantity == Quantity);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductRegisterEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPriceBuy(decimal PriceBuy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.PriceBuy == PriceBuy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductRegisterEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPriceSell(decimal PriceSell)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.PriceSell == PriceSell);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductRegisterEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByDetail(string Detail)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.Detail == Detail);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductRegisterEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCreatedDate(DateTime CreatedDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductRegisterEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByApproved(bool Approved)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.Approved == Approved);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductRegisterEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCompanyName(string CompanyName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.CompanyName == CompanyName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductRegisterEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCompanyPhone(string CompanyPhone)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.CompanyPhone == CompanyPhone);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductRegisterEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCompanyAddress(string CompanyAddress)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.CompanyAddress == CompanyAddress);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductRegisterEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCompanyNumberTax(string CompanyNumberTax)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.CompanyNumberTax == CompanyNumberTax);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductRegisterEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCompanyEmail(string CompanyEmail)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.CompanyEmail == CompanyEmail);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductRegisterEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNote(string Note)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.Note == Note);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ProductRegisterEntity", filter);
			}
			return toReturn;
		}
		

		
		public ProductRegisterEntity SelectOne(Guid Id)
		{
			ProductRegisterEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				ProductRegisterEntity _ProductRegisterEntity = new ProductRegisterEntity(Id);
				if (adapter.FetchEntity(_ProductRegisterEntity))
				{
					toReturn = _ProductRegisterEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductRegisterCollection = new EntityCollection(new ProductRegisterEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<ProductRegisterEntity>
		public EntityCollection<ProductRegisterEntity> SelectAllLST()
		{
			EntityCollection<ProductRegisterEntity> _ProductRegisterCollection = new EntityCollection<ProductRegisterEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductRegisterCollection, null, 0, null);
			}
			return _ProductRegisterCollection;
		}
		
		// Return EntityCollection<ProductRegisterEntity>
		public EntityCollection<ProductRegisterEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<ProductRegisterEntity> _ProductRegisterCollection = new EntityCollection<ProductRegisterEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductRegisterCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _ProductRegisterCollection;
		}


		
		// Return EntityCollection<ProductRegisterEntity>
		public EntityCollection<ProductRegisterEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<ProductRegisterEntity> _ProductRegisterCollection = new EntityCollection<ProductRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductRegisterCollection, filter, 0, null);
			}
			return _ProductRegisterCollection;
		}
		
		// Return EntityCollection<ProductRegisterEntity>
		public EntityCollection<ProductRegisterEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<ProductRegisterEntity> _ProductRegisterCollection = new EntityCollection<ProductRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductRegisterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductRegisterCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductRegisterCollection = new EntityCollection(new ProductRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductRegisterCollection = new EntityCollection(new ProductRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductRegisterEntity>
		public EntityCollection<ProductRegisterEntity> SelectByUserNameLST(string UserName)
		{
			EntityCollection<ProductRegisterEntity> _ProductRegisterCollection = new EntityCollection<ProductRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.UserName == UserName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductRegisterCollection, filter, 0, null);
			}
			return _ProductRegisterCollection;
		}
		
		// Return EntityCollection<ProductRegisterEntity>
		public EntityCollection<ProductRegisterEntity> SelectByUserNameLST_Paged(string UserName, int PageNumber, int PageSize)
		{
			EntityCollection<ProductRegisterEntity> _ProductRegisterCollection = new EntityCollection<ProductRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.UserName == UserName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductRegisterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductRegisterCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUserNameRDT(string UserName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductRegisterCollection = new EntityCollection(new ProductRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.UserName == UserName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUserNameRDT_Paged(string UserName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductRegisterCollection = new EntityCollection(new ProductRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.UserName == UserName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductRegisterEntity>
		public EntityCollection<ProductRegisterEntity> SelectByProductNameLST(string ProductName)
		{
			EntityCollection<ProductRegisterEntity> _ProductRegisterCollection = new EntityCollection<ProductRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.ProductName == ProductName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductRegisterCollection, filter, 0, null);
			}
			return _ProductRegisterCollection;
		}
		
		// Return EntityCollection<ProductRegisterEntity>
		public EntityCollection<ProductRegisterEntity> SelectByProductNameLST_Paged(string ProductName, int PageNumber, int PageSize)
		{
			EntityCollection<ProductRegisterEntity> _ProductRegisterCollection = new EntityCollection<ProductRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.ProductName == ProductName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductRegisterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductRegisterCollection;
		}
		
		// Return DataTable
		public DataTable SelectByProductNameRDT(string ProductName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductRegisterCollection = new EntityCollection(new ProductRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.ProductName == ProductName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByProductNameRDT_Paged(string ProductName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductRegisterCollection = new EntityCollection(new ProductRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.ProductName == ProductName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductRegisterEntity>
		public EntityCollection<ProductRegisterEntity> SelectByAbstractLST(string Abstract)
		{
			EntityCollection<ProductRegisterEntity> _ProductRegisterCollection = new EntityCollection<ProductRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.Abstract == Abstract);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductRegisterCollection, filter, 0, null);
			}
			return _ProductRegisterCollection;
		}
		
		// Return EntityCollection<ProductRegisterEntity>
		public EntityCollection<ProductRegisterEntity> SelectByAbstractLST_Paged(string Abstract, int PageNumber, int PageSize)
		{
			EntityCollection<ProductRegisterEntity> _ProductRegisterCollection = new EntityCollection<ProductRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.Abstract == Abstract);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductRegisterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductRegisterCollection;
		}
		
		// Return DataTable
		public DataTable SelectByAbstractRDT(string Abstract)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductRegisterCollection = new EntityCollection(new ProductRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.Abstract == Abstract);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByAbstractRDT_Paged(string Abstract, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductRegisterCollection = new EntityCollection(new ProductRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.Abstract == Abstract);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductRegisterEntity>
		public EntityCollection<ProductRegisterEntity> SelectByThumbnailLST(string Thumbnail)
		{
			EntityCollection<ProductRegisterEntity> _ProductRegisterCollection = new EntityCollection<ProductRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.Thumbnail == Thumbnail);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductRegisterCollection, filter, 0, null);
			}
			return _ProductRegisterCollection;
		}
		
		// Return EntityCollection<ProductRegisterEntity>
		public EntityCollection<ProductRegisterEntity> SelectByThumbnailLST_Paged(string Thumbnail, int PageNumber, int PageSize)
		{
			EntityCollection<ProductRegisterEntity> _ProductRegisterCollection = new EntityCollection<ProductRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.Thumbnail == Thumbnail);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductRegisterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductRegisterCollection;
		}
		
		// Return DataTable
		public DataTable SelectByThumbnailRDT(string Thumbnail)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductRegisterCollection = new EntityCollection(new ProductRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.Thumbnail == Thumbnail);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByThumbnailRDT_Paged(string Thumbnail, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductRegisterCollection = new EntityCollection(new ProductRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.Thumbnail == Thumbnail);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductRegisterEntity>
		public EntityCollection<ProductRegisterEntity> SelectByWarrantyLST(string Warranty)
		{
			EntityCollection<ProductRegisterEntity> _ProductRegisterCollection = new EntityCollection<ProductRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.Warranty == Warranty);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductRegisterCollection, filter, 0, null);
			}
			return _ProductRegisterCollection;
		}
		
		// Return EntityCollection<ProductRegisterEntity>
		public EntityCollection<ProductRegisterEntity> SelectByWarrantyLST_Paged(string Warranty, int PageNumber, int PageSize)
		{
			EntityCollection<ProductRegisterEntity> _ProductRegisterCollection = new EntityCollection<ProductRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.Warranty == Warranty);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductRegisterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductRegisterCollection;
		}
		
		// Return DataTable
		public DataTable SelectByWarrantyRDT(string Warranty)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductRegisterCollection = new EntityCollection(new ProductRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.Warranty == Warranty);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByWarrantyRDT_Paged(string Warranty, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductRegisterCollection = new EntityCollection(new ProductRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.Warranty == Warranty);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductRegisterEntity>
		public EntityCollection<ProductRegisterEntity> SelectByQuantityLST(int Quantity)
		{
			EntityCollection<ProductRegisterEntity> _ProductRegisterCollection = new EntityCollection<ProductRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.Quantity == Quantity);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductRegisterCollection, filter, 0, null);
			}
			return _ProductRegisterCollection;
		}
		
		// Return EntityCollection<ProductRegisterEntity>
		public EntityCollection<ProductRegisterEntity> SelectByQuantityLST_Paged(int Quantity, int PageNumber, int PageSize)
		{
			EntityCollection<ProductRegisterEntity> _ProductRegisterCollection = new EntityCollection<ProductRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.Quantity == Quantity);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductRegisterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductRegisterCollection;
		}
		
		// Return DataTable
		public DataTable SelectByQuantityRDT(int Quantity)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductRegisterCollection = new EntityCollection(new ProductRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.Quantity == Quantity);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByQuantityRDT_Paged(int Quantity, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductRegisterCollection = new EntityCollection(new ProductRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.Quantity == Quantity);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductRegisterEntity>
		public EntityCollection<ProductRegisterEntity> SelectByPriceBuyLST(decimal PriceBuy)
		{
			EntityCollection<ProductRegisterEntity> _ProductRegisterCollection = new EntityCollection<ProductRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.PriceBuy == PriceBuy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductRegisterCollection, filter, 0, null);
			}
			return _ProductRegisterCollection;
		}
		
		// Return EntityCollection<ProductRegisterEntity>
		public EntityCollection<ProductRegisterEntity> SelectByPriceBuyLST_Paged(decimal PriceBuy, int PageNumber, int PageSize)
		{
			EntityCollection<ProductRegisterEntity> _ProductRegisterCollection = new EntityCollection<ProductRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.PriceBuy == PriceBuy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductRegisterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductRegisterCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPriceBuyRDT(decimal PriceBuy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductRegisterCollection = new EntityCollection(new ProductRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.PriceBuy == PriceBuy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPriceBuyRDT_Paged(decimal PriceBuy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductRegisterCollection = new EntityCollection(new ProductRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.PriceBuy == PriceBuy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductRegisterEntity>
		public EntityCollection<ProductRegisterEntity> SelectByPriceSellLST(decimal PriceSell)
		{
			EntityCollection<ProductRegisterEntity> _ProductRegisterCollection = new EntityCollection<ProductRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.PriceSell == PriceSell);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductRegisterCollection, filter, 0, null);
			}
			return _ProductRegisterCollection;
		}
		
		// Return EntityCollection<ProductRegisterEntity>
		public EntityCollection<ProductRegisterEntity> SelectByPriceSellLST_Paged(decimal PriceSell, int PageNumber, int PageSize)
		{
			EntityCollection<ProductRegisterEntity> _ProductRegisterCollection = new EntityCollection<ProductRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.PriceSell == PriceSell);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductRegisterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductRegisterCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPriceSellRDT(decimal PriceSell)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductRegisterCollection = new EntityCollection(new ProductRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.PriceSell == PriceSell);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPriceSellRDT_Paged(decimal PriceSell, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductRegisterCollection = new EntityCollection(new ProductRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.PriceSell == PriceSell);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductRegisterEntity>
		public EntityCollection<ProductRegisterEntity> SelectByDetailLST(string Detail)
		{
			EntityCollection<ProductRegisterEntity> _ProductRegisterCollection = new EntityCollection<ProductRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.Detail == Detail);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductRegisterCollection, filter, 0, null);
			}
			return _ProductRegisterCollection;
		}
		
		// Return EntityCollection<ProductRegisterEntity>
		public EntityCollection<ProductRegisterEntity> SelectByDetailLST_Paged(string Detail, int PageNumber, int PageSize)
		{
			EntityCollection<ProductRegisterEntity> _ProductRegisterCollection = new EntityCollection<ProductRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.Detail == Detail);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductRegisterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductRegisterCollection;
		}
		
		// Return DataTable
		public DataTable SelectByDetailRDT(string Detail)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductRegisterCollection = new EntityCollection(new ProductRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.Detail == Detail);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByDetailRDT_Paged(string Detail, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductRegisterCollection = new EntityCollection(new ProductRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.Detail == Detail);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductRegisterEntity>
		public EntityCollection<ProductRegisterEntity> SelectByCreatedDateLST(DateTime CreatedDate)
		{
			EntityCollection<ProductRegisterEntity> _ProductRegisterCollection = new EntityCollection<ProductRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductRegisterCollection, filter, 0, null);
			}
			return _ProductRegisterCollection;
		}
		
		// Return EntityCollection<ProductRegisterEntity>
		public EntityCollection<ProductRegisterEntity> SelectByCreatedDateLST_Paged(DateTime CreatedDate, int PageNumber, int PageSize)
		{
			EntityCollection<ProductRegisterEntity> _ProductRegisterCollection = new EntityCollection<ProductRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductRegisterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductRegisterCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedDateRDT(DateTime CreatedDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductRegisterCollection = new EntityCollection(new ProductRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedDateRDT_Paged(DateTime CreatedDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductRegisterCollection = new EntityCollection(new ProductRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductRegisterEntity>
		public EntityCollection<ProductRegisterEntity> SelectByApprovedLST(bool Approved)
		{
			EntityCollection<ProductRegisterEntity> _ProductRegisterCollection = new EntityCollection<ProductRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.Approved == Approved);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductRegisterCollection, filter, 0, null);
			}
			return _ProductRegisterCollection;
		}
		
		// Return EntityCollection<ProductRegisterEntity>
		public EntityCollection<ProductRegisterEntity> SelectByApprovedLST_Paged(bool Approved, int PageNumber, int PageSize)
		{
			EntityCollection<ProductRegisterEntity> _ProductRegisterCollection = new EntityCollection<ProductRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.Approved == Approved);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductRegisterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductRegisterCollection;
		}
		
		// Return DataTable
		public DataTable SelectByApprovedRDT(bool Approved)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductRegisterCollection = new EntityCollection(new ProductRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.Approved == Approved);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByApprovedRDT_Paged(bool Approved, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductRegisterCollection = new EntityCollection(new ProductRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.Approved == Approved);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductRegisterEntity>
		public EntityCollection<ProductRegisterEntity> SelectByCompanyNameLST(string CompanyName)
		{
			EntityCollection<ProductRegisterEntity> _ProductRegisterCollection = new EntityCollection<ProductRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.CompanyName == CompanyName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductRegisterCollection, filter, 0, null);
			}
			return _ProductRegisterCollection;
		}
		
		// Return EntityCollection<ProductRegisterEntity>
		public EntityCollection<ProductRegisterEntity> SelectByCompanyNameLST_Paged(string CompanyName, int PageNumber, int PageSize)
		{
			EntityCollection<ProductRegisterEntity> _ProductRegisterCollection = new EntityCollection<ProductRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.CompanyName == CompanyName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductRegisterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductRegisterCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCompanyNameRDT(string CompanyName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductRegisterCollection = new EntityCollection(new ProductRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.CompanyName == CompanyName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCompanyNameRDT_Paged(string CompanyName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductRegisterCollection = new EntityCollection(new ProductRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.CompanyName == CompanyName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductRegisterEntity>
		public EntityCollection<ProductRegisterEntity> SelectByCompanyPhoneLST(string CompanyPhone)
		{
			EntityCollection<ProductRegisterEntity> _ProductRegisterCollection = new EntityCollection<ProductRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.CompanyPhone == CompanyPhone);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductRegisterCollection, filter, 0, null);
			}
			return _ProductRegisterCollection;
		}
		
		// Return EntityCollection<ProductRegisterEntity>
		public EntityCollection<ProductRegisterEntity> SelectByCompanyPhoneLST_Paged(string CompanyPhone, int PageNumber, int PageSize)
		{
			EntityCollection<ProductRegisterEntity> _ProductRegisterCollection = new EntityCollection<ProductRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.CompanyPhone == CompanyPhone);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductRegisterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductRegisterCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCompanyPhoneRDT(string CompanyPhone)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductRegisterCollection = new EntityCollection(new ProductRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.CompanyPhone == CompanyPhone);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCompanyPhoneRDT_Paged(string CompanyPhone, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductRegisterCollection = new EntityCollection(new ProductRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.CompanyPhone == CompanyPhone);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductRegisterEntity>
		public EntityCollection<ProductRegisterEntity> SelectByCompanyAddressLST(string CompanyAddress)
		{
			EntityCollection<ProductRegisterEntity> _ProductRegisterCollection = new EntityCollection<ProductRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.CompanyAddress == CompanyAddress);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductRegisterCollection, filter, 0, null);
			}
			return _ProductRegisterCollection;
		}
		
		// Return EntityCollection<ProductRegisterEntity>
		public EntityCollection<ProductRegisterEntity> SelectByCompanyAddressLST_Paged(string CompanyAddress, int PageNumber, int PageSize)
		{
			EntityCollection<ProductRegisterEntity> _ProductRegisterCollection = new EntityCollection<ProductRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.CompanyAddress == CompanyAddress);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductRegisterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductRegisterCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCompanyAddressRDT(string CompanyAddress)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductRegisterCollection = new EntityCollection(new ProductRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.CompanyAddress == CompanyAddress);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCompanyAddressRDT_Paged(string CompanyAddress, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductRegisterCollection = new EntityCollection(new ProductRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.CompanyAddress == CompanyAddress);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductRegisterEntity>
		public EntityCollection<ProductRegisterEntity> SelectByCompanyNumberTaxLST(string CompanyNumberTax)
		{
			EntityCollection<ProductRegisterEntity> _ProductRegisterCollection = new EntityCollection<ProductRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.CompanyNumberTax == CompanyNumberTax);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductRegisterCollection, filter, 0, null);
			}
			return _ProductRegisterCollection;
		}
		
		// Return EntityCollection<ProductRegisterEntity>
		public EntityCollection<ProductRegisterEntity> SelectByCompanyNumberTaxLST_Paged(string CompanyNumberTax, int PageNumber, int PageSize)
		{
			EntityCollection<ProductRegisterEntity> _ProductRegisterCollection = new EntityCollection<ProductRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.CompanyNumberTax == CompanyNumberTax);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductRegisterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductRegisterCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCompanyNumberTaxRDT(string CompanyNumberTax)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductRegisterCollection = new EntityCollection(new ProductRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.CompanyNumberTax == CompanyNumberTax);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCompanyNumberTaxRDT_Paged(string CompanyNumberTax, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductRegisterCollection = new EntityCollection(new ProductRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.CompanyNumberTax == CompanyNumberTax);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductRegisterEntity>
		public EntityCollection<ProductRegisterEntity> SelectByCompanyEmailLST(string CompanyEmail)
		{
			EntityCollection<ProductRegisterEntity> _ProductRegisterCollection = new EntityCollection<ProductRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.CompanyEmail == CompanyEmail);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductRegisterCollection, filter, 0, null);
			}
			return _ProductRegisterCollection;
		}
		
		// Return EntityCollection<ProductRegisterEntity>
		public EntityCollection<ProductRegisterEntity> SelectByCompanyEmailLST_Paged(string CompanyEmail, int PageNumber, int PageSize)
		{
			EntityCollection<ProductRegisterEntity> _ProductRegisterCollection = new EntityCollection<ProductRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.CompanyEmail == CompanyEmail);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductRegisterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductRegisterCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCompanyEmailRDT(string CompanyEmail)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductRegisterCollection = new EntityCollection(new ProductRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.CompanyEmail == CompanyEmail);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCompanyEmailRDT_Paged(string CompanyEmail, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductRegisterCollection = new EntityCollection(new ProductRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.CompanyEmail == CompanyEmail);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ProductRegisterEntity>
		public EntityCollection<ProductRegisterEntity> SelectByNoteLST(string Note)
		{
			EntityCollection<ProductRegisterEntity> _ProductRegisterCollection = new EntityCollection<ProductRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.Note == Note);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductRegisterCollection, filter, 0, null);
			}
			return _ProductRegisterCollection;
		}
		
		// Return EntityCollection<ProductRegisterEntity>
		public EntityCollection<ProductRegisterEntity> SelectByNoteLST_Paged(string Note, int PageNumber, int PageSize)
		{
			EntityCollection<ProductRegisterEntity> _ProductRegisterCollection = new EntityCollection<ProductRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.Note == Note);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ProductRegisterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ProductRegisterCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNoteRDT(string Note)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductRegisterCollection = new EntityCollection(new ProductRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.Note == Note);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNoteRDT_Paged(string Note, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ProductRegisterCollection = new EntityCollection(new ProductRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ProductRegisterFields.Note == Note);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ProductRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
