




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.PromotionsManagerBase
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
	public class PromotionsManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public PromotionsManagerBase()
		{
			// Nothing for now.
		}
		
		public PromotionsEntity Insert(PromotionsEntity _PromotionsEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_PromotionsEntity, true);
			}
			return _PromotionsEntity;
		}

		
		public PromotionsEntity Insert(Guid Id, string PromotionName, decimal Price, string Note, string Photo, bool IsActive)
		{
			PromotionsEntity _PromotionsEntity = new PromotionsEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_PromotionsEntity.Id = Id;
				_PromotionsEntity.PromotionName = PromotionName;
				_PromotionsEntity.Price = Price;
				_PromotionsEntity.Note = Note;
				_PromotionsEntity.Photo = Photo;
				_PromotionsEntity.IsActive = IsActive;
				adapter.SaveEntity(_PromotionsEntity, true);
			}
			return _PromotionsEntity;
		}

		public PromotionsEntity Insert(string PromotionName, decimal Price, string Note, string Photo, bool IsActive)
		{
			PromotionsEntity _PromotionsEntity = new PromotionsEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_PromotionsEntity.PromotionName = PromotionName;
				_PromotionsEntity.Price = Price;
				_PromotionsEntity.Note = Note;
				_PromotionsEntity.Photo = Photo;
				_PromotionsEntity.IsActive = IsActive;
				adapter.SaveEntity(_PromotionsEntity, true);
			}
			return _PromotionsEntity;
		}

		public bool Update(PromotionsEntity _PromotionsEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(PromotionsFields.Id == _PromotionsEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_PromotionsEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(PromotionsEntity _PromotionsEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_PromotionsEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string PromotionName, decimal Price, string Note, string Photo, bool IsActive)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				PromotionsEntity _PromotionsEntity = new PromotionsEntity(Id);
				if (adapter.FetchEntity(_PromotionsEntity))
				{
				
					_PromotionsEntity.PromotionName = PromotionName;
					_PromotionsEntity.Price = Price;
					_PromotionsEntity.Note = Note;
					_PromotionsEntity.Photo = Photo;
					_PromotionsEntity.IsActive = IsActive;
					adapter.SaveEntity(_PromotionsEntity, true);
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
				PromotionsEntity _PromotionsEntity = new PromotionsEntity(Id);
				if (adapter.FetchEntity(_PromotionsEntity))
				{
					adapter.DeleteEntity(_PromotionsEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("PromotionsEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PromotionsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PromotionsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPromotionName(string PromotionName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PromotionsFields.PromotionName == PromotionName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PromotionsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPrice(decimal Price)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PromotionsFields.Price == Price);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PromotionsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNote(string Note)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PromotionsFields.Note == Note);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PromotionsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPhoto(string Photo)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PromotionsFields.Photo == Photo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PromotionsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIsActive(bool IsActive)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PromotionsFields.IsActive == IsActive);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PromotionsEntity", filter);
			}
			return toReturn;
		}
		

		
		public PromotionsEntity SelectOne(Guid Id)
		{
			PromotionsEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				PromotionsEntity _PromotionsEntity = new PromotionsEntity(Id);
				if (adapter.FetchEntity(_PromotionsEntity))
				{
					toReturn = _PromotionsEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PromotionsCollection = new EntityCollection(new PromotionsEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PromotionsCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<PromotionsEntity>
		public EntityCollection<PromotionsEntity> SelectAllLST()
		{
			EntityCollection<PromotionsEntity> _PromotionsCollection = new EntityCollection<PromotionsEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PromotionsCollection, null, 0, null);
			}
			return _PromotionsCollection;
		}
		
		// Return EntityCollection<PromotionsEntity>
		public EntityCollection<PromotionsEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<PromotionsEntity> _PromotionsCollection = new EntityCollection<PromotionsEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PromotionsCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _PromotionsCollection;
		}


		
		// Return EntityCollection<PromotionsEntity>
		public EntityCollection<PromotionsEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<PromotionsEntity> _PromotionsCollection = new EntityCollection<PromotionsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PromotionsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PromotionsCollection, filter, 0, null);
			}
			return _PromotionsCollection;
		}
		
		// Return EntityCollection<PromotionsEntity>
		public EntityCollection<PromotionsEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<PromotionsEntity> _PromotionsCollection = new EntityCollection<PromotionsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PromotionsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PromotionsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PromotionsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PromotionsCollection = new EntityCollection(new PromotionsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PromotionsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PromotionsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PromotionsCollection = new EntityCollection(new PromotionsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PromotionsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PromotionsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PromotionsEntity>
		public EntityCollection<PromotionsEntity> SelectByPromotionNameLST(string PromotionName)
		{
			EntityCollection<PromotionsEntity> _PromotionsCollection = new EntityCollection<PromotionsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PromotionsFields.PromotionName == PromotionName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PromotionsCollection, filter, 0, null);
			}
			return _PromotionsCollection;
		}
		
		// Return EntityCollection<PromotionsEntity>
		public EntityCollection<PromotionsEntity> SelectByPromotionNameLST_Paged(string PromotionName, int PageNumber, int PageSize)
		{
			EntityCollection<PromotionsEntity> _PromotionsCollection = new EntityCollection<PromotionsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PromotionsFields.PromotionName == PromotionName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PromotionsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PromotionsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPromotionNameRDT(string PromotionName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PromotionsCollection = new EntityCollection(new PromotionsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PromotionsFields.PromotionName == PromotionName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PromotionsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPromotionNameRDT_Paged(string PromotionName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PromotionsCollection = new EntityCollection(new PromotionsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PromotionsFields.PromotionName == PromotionName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PromotionsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PromotionsEntity>
		public EntityCollection<PromotionsEntity> SelectByPriceLST(decimal Price)
		{
			EntityCollection<PromotionsEntity> _PromotionsCollection = new EntityCollection<PromotionsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PromotionsFields.Price == Price);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PromotionsCollection, filter, 0, null);
			}
			return _PromotionsCollection;
		}
		
		// Return EntityCollection<PromotionsEntity>
		public EntityCollection<PromotionsEntity> SelectByPriceLST_Paged(decimal Price, int PageNumber, int PageSize)
		{
			EntityCollection<PromotionsEntity> _PromotionsCollection = new EntityCollection<PromotionsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PromotionsFields.Price == Price);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PromotionsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PromotionsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPriceRDT(decimal Price)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PromotionsCollection = new EntityCollection(new PromotionsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PromotionsFields.Price == Price);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PromotionsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPriceRDT_Paged(decimal Price, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PromotionsCollection = new EntityCollection(new PromotionsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PromotionsFields.Price == Price);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PromotionsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PromotionsEntity>
		public EntityCollection<PromotionsEntity> SelectByNoteLST(string Note)
		{
			EntityCollection<PromotionsEntity> _PromotionsCollection = new EntityCollection<PromotionsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PromotionsFields.Note == Note);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PromotionsCollection, filter, 0, null);
			}
			return _PromotionsCollection;
		}
		
		// Return EntityCollection<PromotionsEntity>
		public EntityCollection<PromotionsEntity> SelectByNoteLST_Paged(string Note, int PageNumber, int PageSize)
		{
			EntityCollection<PromotionsEntity> _PromotionsCollection = new EntityCollection<PromotionsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PromotionsFields.Note == Note);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PromotionsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PromotionsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNoteRDT(string Note)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PromotionsCollection = new EntityCollection(new PromotionsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PromotionsFields.Note == Note);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PromotionsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNoteRDT_Paged(string Note, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PromotionsCollection = new EntityCollection(new PromotionsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PromotionsFields.Note == Note);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PromotionsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PromotionsEntity>
		public EntityCollection<PromotionsEntity> SelectByPhotoLST(string Photo)
		{
			EntityCollection<PromotionsEntity> _PromotionsCollection = new EntityCollection<PromotionsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PromotionsFields.Photo == Photo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PromotionsCollection, filter, 0, null);
			}
			return _PromotionsCollection;
		}
		
		// Return EntityCollection<PromotionsEntity>
		public EntityCollection<PromotionsEntity> SelectByPhotoLST_Paged(string Photo, int PageNumber, int PageSize)
		{
			EntityCollection<PromotionsEntity> _PromotionsCollection = new EntityCollection<PromotionsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PromotionsFields.Photo == Photo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PromotionsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PromotionsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPhotoRDT(string Photo)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PromotionsCollection = new EntityCollection(new PromotionsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PromotionsFields.Photo == Photo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PromotionsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPhotoRDT_Paged(string Photo, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PromotionsCollection = new EntityCollection(new PromotionsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PromotionsFields.Photo == Photo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PromotionsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PromotionsEntity>
		public EntityCollection<PromotionsEntity> SelectByIsActiveLST(bool IsActive)
		{
			EntityCollection<PromotionsEntity> _PromotionsCollection = new EntityCollection<PromotionsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PromotionsFields.IsActive == IsActive);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PromotionsCollection, filter, 0, null);
			}
			return _PromotionsCollection;
		}
		
		// Return EntityCollection<PromotionsEntity>
		public EntityCollection<PromotionsEntity> SelectByIsActiveLST_Paged(bool IsActive, int PageNumber, int PageSize)
		{
			EntityCollection<PromotionsEntity> _PromotionsCollection = new EntityCollection<PromotionsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PromotionsFields.IsActive == IsActive);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PromotionsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PromotionsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIsActiveRDT(bool IsActive)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PromotionsCollection = new EntityCollection(new PromotionsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PromotionsFields.IsActive == IsActive);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PromotionsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIsActiveRDT_Paged(bool IsActive, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PromotionsCollection = new EntityCollection(new PromotionsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PromotionsFields.IsActive == IsActive);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PromotionsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
