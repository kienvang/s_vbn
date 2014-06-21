




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.ReviewsManagerBase
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
	public class ReviewsManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public ReviewsManagerBase()
		{
			// Nothing for now.
		}
		
		public ReviewsEntity Insert(ReviewsEntity _ReviewsEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_ReviewsEntity, true);
			}
			return _ReviewsEntity;
		}

		
		public ReviewsEntity Insert(Guid Id, Guid ReferId, string ReviewContent, string CreatedBy, DateTime CreatedDate, byte[] UpdatedBy, DateTime UpdatedDate, bool IsVisible)
		{
			ReviewsEntity _ReviewsEntity = new ReviewsEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_ReviewsEntity.Id = Id;
				_ReviewsEntity.ReferId = ReferId;
				_ReviewsEntity.ReviewContent = ReviewContent;
				_ReviewsEntity.CreatedBy = CreatedBy;
				_ReviewsEntity.CreatedDate = CreatedDate;
				_ReviewsEntity.UpdatedBy = UpdatedBy;
				_ReviewsEntity.UpdatedDate = UpdatedDate;
				_ReviewsEntity.IsVisible = IsVisible;
				adapter.SaveEntity(_ReviewsEntity, true);
			}
			return _ReviewsEntity;
		}

		public ReviewsEntity Insert(Guid ReferId, string ReviewContent, string CreatedBy, DateTime CreatedDate, byte[] UpdatedBy, DateTime UpdatedDate, bool IsVisible)
		{
			ReviewsEntity _ReviewsEntity = new ReviewsEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_ReviewsEntity.ReferId = ReferId;
				_ReviewsEntity.ReviewContent = ReviewContent;
				_ReviewsEntity.CreatedBy = CreatedBy;
				_ReviewsEntity.CreatedDate = CreatedDate;
				_ReviewsEntity.UpdatedBy = UpdatedBy;
				_ReviewsEntity.UpdatedDate = UpdatedDate;
				_ReviewsEntity.IsVisible = IsVisible;
				adapter.SaveEntity(_ReviewsEntity, true);
			}
			return _ReviewsEntity;
		}

		public bool Update(ReviewsEntity _ReviewsEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(ReviewsFields.Id == _ReviewsEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_ReviewsEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(ReviewsEntity _ReviewsEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_ReviewsEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, Guid ReferId, string ReviewContent, string CreatedBy, DateTime CreatedDate, byte[] UpdatedBy, DateTime UpdatedDate, bool IsVisible)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				ReviewsEntity _ReviewsEntity = new ReviewsEntity(Id);
				if (adapter.FetchEntity(_ReviewsEntity))
				{
				
					_ReviewsEntity.ReferId = ReferId;
					_ReviewsEntity.ReviewContent = ReviewContent;
					_ReviewsEntity.CreatedBy = CreatedBy;
					_ReviewsEntity.CreatedDate = CreatedDate;
					_ReviewsEntity.UpdatedBy = UpdatedBy;
					_ReviewsEntity.UpdatedDate = UpdatedDate;
					_ReviewsEntity.IsVisible = IsVisible;
					adapter.SaveEntity(_ReviewsEntity, true);
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
				ReviewsEntity _ReviewsEntity = new ReviewsEntity(Id);
				if (adapter.FetchEntity(_ReviewsEntity))
				{
					adapter.DeleteEntity(_ReviewsEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("ReviewsEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ReviewsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ReviewsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByReferId(Guid ReferId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ReviewsFields.ReferId == ReferId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ReviewsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByReviewContent(string ReviewContent)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ReviewsFields.ReviewContent == ReviewContent);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ReviewsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCreatedBy(string CreatedBy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ReviewsFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ReviewsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCreatedDate(DateTime CreatedDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ReviewsFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ReviewsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByUpdatedBy(byte[] UpdatedBy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ReviewsFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ReviewsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByUpdatedDate(DateTime UpdatedDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ReviewsFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ReviewsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIsVisible(bool IsVisible)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ReviewsFields.IsVisible == IsVisible);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ReviewsEntity", filter);
			}
			return toReturn;
		}
		

		
		public ReviewsEntity SelectOne(Guid Id)
		{
			ReviewsEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				ReviewsEntity _ReviewsEntity = new ReviewsEntity(Id);
				if (adapter.FetchEntity(_ReviewsEntity))
				{
					toReturn = _ReviewsEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ReviewsCollection = new EntityCollection(new ReviewsEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ReviewsCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<ReviewsEntity>
		public EntityCollection<ReviewsEntity> SelectAllLST()
		{
			EntityCollection<ReviewsEntity> _ReviewsCollection = new EntityCollection<ReviewsEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ReviewsCollection, null, 0, null);
			}
			return _ReviewsCollection;
		}
		
		// Return EntityCollection<ReviewsEntity>
		public EntityCollection<ReviewsEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<ReviewsEntity> _ReviewsCollection = new EntityCollection<ReviewsEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ReviewsCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _ReviewsCollection;
		}


		
		// Return EntityCollection<ReviewsEntity>
		public EntityCollection<ReviewsEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<ReviewsEntity> _ReviewsCollection = new EntityCollection<ReviewsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ReviewsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ReviewsCollection, filter, 0, null);
			}
			return _ReviewsCollection;
		}
		
		// Return EntityCollection<ReviewsEntity>
		public EntityCollection<ReviewsEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<ReviewsEntity> _ReviewsCollection = new EntityCollection<ReviewsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ReviewsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ReviewsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ReviewsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ReviewsCollection = new EntityCollection(new ReviewsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ReviewsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ReviewsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ReviewsCollection = new EntityCollection(new ReviewsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ReviewsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ReviewsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ReviewsEntity>
		public EntityCollection<ReviewsEntity> SelectByReferIdLST(Guid ReferId)
		{
			EntityCollection<ReviewsEntity> _ReviewsCollection = new EntityCollection<ReviewsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ReviewsFields.ReferId == ReferId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ReviewsCollection, filter, 0, null);
			}
			return _ReviewsCollection;
		}
		
		// Return EntityCollection<ReviewsEntity>
		public EntityCollection<ReviewsEntity> SelectByReferIdLST_Paged(Guid ReferId, int PageNumber, int PageSize)
		{
			EntityCollection<ReviewsEntity> _ReviewsCollection = new EntityCollection<ReviewsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ReviewsFields.ReferId == ReferId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ReviewsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ReviewsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByReferIdRDT(Guid ReferId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ReviewsCollection = new EntityCollection(new ReviewsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ReviewsFields.ReferId == ReferId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ReviewsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByReferIdRDT_Paged(Guid ReferId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ReviewsCollection = new EntityCollection(new ReviewsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ReviewsFields.ReferId == ReferId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ReviewsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ReviewsEntity>
		public EntityCollection<ReviewsEntity> SelectByReviewContentLST(string ReviewContent)
		{
			EntityCollection<ReviewsEntity> _ReviewsCollection = new EntityCollection<ReviewsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ReviewsFields.ReviewContent == ReviewContent);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ReviewsCollection, filter, 0, null);
			}
			return _ReviewsCollection;
		}
		
		// Return EntityCollection<ReviewsEntity>
		public EntityCollection<ReviewsEntity> SelectByReviewContentLST_Paged(string ReviewContent, int PageNumber, int PageSize)
		{
			EntityCollection<ReviewsEntity> _ReviewsCollection = new EntityCollection<ReviewsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ReviewsFields.ReviewContent == ReviewContent);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ReviewsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ReviewsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByReviewContentRDT(string ReviewContent)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ReviewsCollection = new EntityCollection(new ReviewsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ReviewsFields.ReviewContent == ReviewContent);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ReviewsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByReviewContentRDT_Paged(string ReviewContent, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ReviewsCollection = new EntityCollection(new ReviewsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ReviewsFields.ReviewContent == ReviewContent);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ReviewsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ReviewsEntity>
		public EntityCollection<ReviewsEntity> SelectByCreatedByLST(string CreatedBy)
		{
			EntityCollection<ReviewsEntity> _ReviewsCollection = new EntityCollection<ReviewsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ReviewsFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ReviewsCollection, filter, 0, null);
			}
			return _ReviewsCollection;
		}
		
		// Return EntityCollection<ReviewsEntity>
		public EntityCollection<ReviewsEntity> SelectByCreatedByLST_Paged(string CreatedBy, int PageNumber, int PageSize)
		{
			EntityCollection<ReviewsEntity> _ReviewsCollection = new EntityCollection<ReviewsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ReviewsFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ReviewsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ReviewsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedByRDT(string CreatedBy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ReviewsCollection = new EntityCollection(new ReviewsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ReviewsFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ReviewsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedByRDT_Paged(string CreatedBy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ReviewsCollection = new EntityCollection(new ReviewsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ReviewsFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ReviewsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ReviewsEntity>
		public EntityCollection<ReviewsEntity> SelectByCreatedDateLST(DateTime CreatedDate)
		{
			EntityCollection<ReviewsEntity> _ReviewsCollection = new EntityCollection<ReviewsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ReviewsFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ReviewsCollection, filter, 0, null);
			}
			return _ReviewsCollection;
		}
		
		// Return EntityCollection<ReviewsEntity>
		public EntityCollection<ReviewsEntity> SelectByCreatedDateLST_Paged(DateTime CreatedDate, int PageNumber, int PageSize)
		{
			EntityCollection<ReviewsEntity> _ReviewsCollection = new EntityCollection<ReviewsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ReviewsFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ReviewsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ReviewsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedDateRDT(DateTime CreatedDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ReviewsCollection = new EntityCollection(new ReviewsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ReviewsFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ReviewsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedDateRDT_Paged(DateTime CreatedDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ReviewsCollection = new EntityCollection(new ReviewsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ReviewsFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ReviewsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ReviewsEntity>
		public EntityCollection<ReviewsEntity> SelectByUpdatedByLST(byte[] UpdatedBy)
		{
			EntityCollection<ReviewsEntity> _ReviewsCollection = new EntityCollection<ReviewsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ReviewsFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ReviewsCollection, filter, 0, null);
			}
			return _ReviewsCollection;
		}
		
		// Return EntityCollection<ReviewsEntity>
		public EntityCollection<ReviewsEntity> SelectByUpdatedByLST_Paged(byte[] UpdatedBy, int PageNumber, int PageSize)
		{
			EntityCollection<ReviewsEntity> _ReviewsCollection = new EntityCollection<ReviewsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ReviewsFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ReviewsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ReviewsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedByRDT(byte[] UpdatedBy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ReviewsCollection = new EntityCollection(new ReviewsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ReviewsFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ReviewsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedByRDT_Paged(byte[] UpdatedBy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ReviewsCollection = new EntityCollection(new ReviewsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ReviewsFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ReviewsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ReviewsEntity>
		public EntityCollection<ReviewsEntity> SelectByUpdatedDateLST(DateTime UpdatedDate)
		{
			EntityCollection<ReviewsEntity> _ReviewsCollection = new EntityCollection<ReviewsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ReviewsFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ReviewsCollection, filter, 0, null);
			}
			return _ReviewsCollection;
		}
		
		// Return EntityCollection<ReviewsEntity>
		public EntityCollection<ReviewsEntity> SelectByUpdatedDateLST_Paged(DateTime UpdatedDate, int PageNumber, int PageSize)
		{
			EntityCollection<ReviewsEntity> _ReviewsCollection = new EntityCollection<ReviewsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ReviewsFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ReviewsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ReviewsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedDateRDT(DateTime UpdatedDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ReviewsCollection = new EntityCollection(new ReviewsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ReviewsFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ReviewsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedDateRDT_Paged(DateTime UpdatedDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ReviewsCollection = new EntityCollection(new ReviewsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ReviewsFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ReviewsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ReviewsEntity>
		public EntityCollection<ReviewsEntity> SelectByIsVisibleLST(bool IsVisible)
		{
			EntityCollection<ReviewsEntity> _ReviewsCollection = new EntityCollection<ReviewsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ReviewsFields.IsVisible == IsVisible);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ReviewsCollection, filter, 0, null);
			}
			return _ReviewsCollection;
		}
		
		// Return EntityCollection<ReviewsEntity>
		public EntityCollection<ReviewsEntity> SelectByIsVisibleLST_Paged(bool IsVisible, int PageNumber, int PageSize)
		{
			EntityCollection<ReviewsEntity> _ReviewsCollection = new EntityCollection<ReviewsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ReviewsFields.IsVisible == IsVisible);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ReviewsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ReviewsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIsVisibleRDT(bool IsVisible)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ReviewsCollection = new EntityCollection(new ReviewsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ReviewsFields.IsVisible == IsVisible);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ReviewsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIsVisibleRDT_Paged(bool IsVisible, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ReviewsCollection = new EntityCollection(new ReviewsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ReviewsFields.IsVisible == IsVisible);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ReviewsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
