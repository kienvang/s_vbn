


/*
'===============================================================================
'  LayerHelper.ShopCake.BL.DocumentManagerBase
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
	public class DocumentManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DocumentManagerBase()
		{
			// Nothing for now.
		}
		
		public DocumentEntity Insert(DocumentEntity _DocumentEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_DocumentEntity, true);
			}
			return _DocumentEntity;
		}

		
		public DocumentEntity Insert(Guid Id, long IntId, string DocumentName, string DocumentCode, string TextId, long GroupId, string Description, int Mark, int CountDown, int ReMark, string PathName, string DisplayImage, string VideoTrailer, bool ShowVideo, double FileSize, bool IsVisible, DateTime CreatedDate, string CreatedBy, DateTime UpdatedDate, string UpdatedBy, bool IsDeleted)
		{
			DocumentEntity _DocumentEntity = new DocumentEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DocumentEntity.Id = Id;
				_DocumentEntity.DocumentName = DocumentName;
				_DocumentEntity.DocumentCode = DocumentCode;
				_DocumentEntity.TextId = TextId;
				_DocumentEntity.GroupId = GroupId;
				_DocumentEntity.Description = Description;
				_DocumentEntity.Mark = Mark;
				_DocumentEntity.CountDown = CountDown;
				_DocumentEntity.ReMark = ReMark;
				_DocumentEntity.PathName = PathName;
				_DocumentEntity.DisplayImage = DisplayImage;
				_DocumentEntity.VideoTrailer = VideoTrailer;
				_DocumentEntity.ShowVideo = ShowVideo;
				_DocumentEntity.FileSize = FileSize;
				_DocumentEntity.IsVisible = IsVisible;
				_DocumentEntity.CreatedDate = CreatedDate;
				_DocumentEntity.CreatedBy = CreatedBy;
				_DocumentEntity.UpdatedDate = UpdatedDate;
				_DocumentEntity.UpdatedBy = UpdatedBy;
				_DocumentEntity.IsDeleted = IsDeleted;
				adapter.SaveEntity(_DocumentEntity, true);
			}
			return _DocumentEntity;
		}

		public DocumentEntity Insert(string DocumentName, string DocumentCode, string TextId, long GroupId, string Description, int Mark, int CountDown, int ReMark, string PathName, string DisplayImage, string VideoTrailer, bool ShowVideo, double FileSize, bool IsVisible, DateTime CreatedDate, string CreatedBy, DateTime UpdatedDate, string UpdatedBy, bool IsDeleted)
		{
			DocumentEntity _DocumentEntity = new DocumentEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DocumentEntity.DocumentName = DocumentName;
				_DocumentEntity.DocumentCode = DocumentCode;
				_DocumentEntity.TextId = TextId;
				_DocumentEntity.GroupId = GroupId;
				_DocumentEntity.Description = Description;
				_DocumentEntity.Mark = Mark;
				_DocumentEntity.CountDown = CountDown;
				_DocumentEntity.ReMark = ReMark;
				_DocumentEntity.PathName = PathName;
				_DocumentEntity.DisplayImage = DisplayImage;
				_DocumentEntity.VideoTrailer = VideoTrailer;
				_DocumentEntity.ShowVideo = ShowVideo;
				_DocumentEntity.FileSize = FileSize;
				_DocumentEntity.IsVisible = IsVisible;
				_DocumentEntity.CreatedDate = CreatedDate;
				_DocumentEntity.CreatedBy = CreatedBy;
				_DocumentEntity.UpdatedDate = UpdatedDate;
				_DocumentEntity.UpdatedBy = UpdatedBy;
				_DocumentEntity.IsDeleted = IsDeleted;
				adapter.SaveEntity(_DocumentEntity, true);
			}
			return _DocumentEntity;
		}

		public bool Update(DocumentEntity _DocumentEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(DocumentFields.Id == _DocumentEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DocumentEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DocumentEntity _DocumentEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DocumentEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, long IntId, string DocumentName, string DocumentCode, string TextId, long GroupId, string Description, int Mark, int CountDown, int ReMark, string PathName, string DisplayImage, string VideoTrailer, bool ShowVideo, double FileSize, bool IsVisible, DateTime CreatedDate, string CreatedBy, DateTime UpdatedDate, string UpdatedBy, bool IsDeleted)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DocumentEntity _DocumentEntity = new DocumentEntity(Id);
				if (adapter.FetchEntity(_DocumentEntity))
				{
				
					_DocumentEntity.DocumentName = DocumentName;
					_DocumentEntity.DocumentCode = DocumentCode;
					_DocumentEntity.TextId = TextId;
					_DocumentEntity.GroupId = GroupId;
					_DocumentEntity.Description = Description;
					_DocumentEntity.Mark = Mark;
					_DocumentEntity.CountDown = CountDown;
					_DocumentEntity.ReMark = ReMark;
					_DocumentEntity.PathName = PathName;
					_DocumentEntity.DisplayImage = DisplayImage;
					_DocumentEntity.VideoTrailer = VideoTrailer;
					_DocumentEntity.ShowVideo = ShowVideo;
					_DocumentEntity.FileSize = FileSize;
					_DocumentEntity.IsVisible = IsVisible;
					_DocumentEntity.CreatedDate = CreatedDate;
					_DocumentEntity.CreatedBy = CreatedBy;
					_DocumentEntity.UpdatedDate = UpdatedDate;
					_DocumentEntity.UpdatedBy = UpdatedBy;
					_DocumentEntity.IsDeleted = IsDeleted;
					adapter.SaveEntity(_DocumentEntity, true);
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
				DocumentEntity _DocumentEntity = new DocumentEntity(Id);
				if (adapter.FetchEntity(_DocumentEntity))
				{
					adapter.DeleteEntity(_DocumentEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DocumentEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DocumentEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIntId(long IntId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.IntId == IntId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DocumentEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByDocumentName(string DocumentName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.DocumentName == DocumentName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DocumentEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByDocumentCode(string DocumentCode)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.DocumentCode == DocumentCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DocumentEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTextId(string TextId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.TextId == TextId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DocumentEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGroupId(long GroupId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.GroupId == GroupId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DocumentEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByDescription(string Description)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.Description == Description);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DocumentEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMark(int Mark)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.Mark == Mark);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DocumentEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCountDown(int CountDown)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.CountDown == CountDown);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DocumentEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByReMark(int ReMark)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.ReMark == ReMark);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DocumentEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPathName(string PathName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.PathName == PathName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DocumentEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByDisplayImage(string DisplayImage)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.DisplayImage == DisplayImage);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DocumentEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByVideoTrailer(string VideoTrailer)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.VideoTrailer == VideoTrailer);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DocumentEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByShowVideo(bool ShowVideo)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.ShowVideo == ShowVideo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DocumentEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByFileSize(double FileSize)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.FileSize == FileSize);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DocumentEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIsVisible(bool IsVisible)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.IsVisible == IsVisible);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DocumentEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCreatedDate(DateTime CreatedDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DocumentEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCreatedBy(string CreatedBy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DocumentEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByUpdatedDate(DateTime UpdatedDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DocumentEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByUpdatedBy(string UpdatedBy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DocumentEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIsDeleted(bool IsDeleted)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.IsDeleted == IsDeleted);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DocumentEntity", filter);
			}
			return toReturn;
		}
		

		
		public DocumentEntity SelectOne(Guid Id)
		{
			DocumentEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DocumentEntity _DocumentEntity = new DocumentEntity(Id);
				if (adapter.FetchEntity(_DocumentEntity))
				{
					toReturn = _DocumentEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentCollection = new EntityCollection(new DocumentEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<DocumentEntity>
		public EntityCollection<DocumentEntity> SelectAllLST()
		{
			EntityCollection<DocumentEntity> _DocumentCollection = new EntityCollection<DocumentEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentCollection, null, 0, null);
			}
			return _DocumentCollection;
		}
		
		// Return EntityCollection<DocumentEntity>
		public EntityCollection<DocumentEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<DocumentEntity> _DocumentCollection = new EntityCollection<DocumentEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentCollection;
		}


		
		// Return EntityCollection<DocumentEntity>
		public EntityCollection<DocumentEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<DocumentEntity> _DocumentCollection = new EntityCollection<DocumentEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentCollection, filter, 0, null);
			}
			return _DocumentCollection;
		}
		
		// Return EntityCollection<DocumentEntity>
		public EntityCollection<DocumentEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<DocumentEntity> _DocumentCollection = new EntityCollection<DocumentEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentCollection = new EntityCollection(new DocumentEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentCollection = new EntityCollection(new DocumentEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DocumentEntity>
		public EntityCollection<DocumentEntity> SelectByIntIdLST(long IntId)
		{
			EntityCollection<DocumentEntity> _DocumentCollection = new EntityCollection<DocumentEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.IntId == IntId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentCollection, filter, 0, null);
			}
			return _DocumentCollection;
		}
		
		// Return EntityCollection<DocumentEntity>
		public EntityCollection<DocumentEntity> SelectByIntIdLST_Paged(long IntId, int PageNumber, int PageSize)
		{
			EntityCollection<DocumentEntity> _DocumentCollection = new EntityCollection<DocumentEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.IntId == IntId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIntIdRDT(long IntId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentCollection = new EntityCollection(new DocumentEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.IntId == IntId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIntIdRDT_Paged(long IntId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentCollection = new EntityCollection(new DocumentEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.IntId == IntId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DocumentEntity>
		public EntityCollection<DocumentEntity> SelectByDocumentNameLST(string DocumentName)
		{
			EntityCollection<DocumentEntity> _DocumentCollection = new EntityCollection<DocumentEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.DocumentName == DocumentName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentCollection, filter, 0, null);
			}
			return _DocumentCollection;
		}
		
		// Return EntityCollection<DocumentEntity>
		public EntityCollection<DocumentEntity> SelectByDocumentNameLST_Paged(string DocumentName, int PageNumber, int PageSize)
		{
			EntityCollection<DocumentEntity> _DocumentCollection = new EntityCollection<DocumentEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.DocumentName == DocumentName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentCollection;
		}
		
		// Return DataTable
		public DataTable SelectByDocumentNameRDT(string DocumentName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentCollection = new EntityCollection(new DocumentEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.DocumentName == DocumentName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByDocumentNameRDT_Paged(string DocumentName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentCollection = new EntityCollection(new DocumentEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.DocumentName == DocumentName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DocumentEntity>
		public EntityCollection<DocumentEntity> SelectByDocumentCodeLST(string DocumentCode)
		{
			EntityCollection<DocumentEntity> _DocumentCollection = new EntityCollection<DocumentEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.DocumentCode == DocumentCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentCollection, filter, 0, null);
			}
			return _DocumentCollection;
		}
		
		// Return EntityCollection<DocumentEntity>
		public EntityCollection<DocumentEntity> SelectByDocumentCodeLST_Paged(string DocumentCode, int PageNumber, int PageSize)
		{
			EntityCollection<DocumentEntity> _DocumentCollection = new EntityCollection<DocumentEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.DocumentCode == DocumentCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentCollection;
		}
		
		// Return DataTable
		public DataTable SelectByDocumentCodeRDT(string DocumentCode)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentCollection = new EntityCollection(new DocumentEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.DocumentCode == DocumentCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByDocumentCodeRDT_Paged(string DocumentCode, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentCollection = new EntityCollection(new DocumentEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.DocumentCode == DocumentCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DocumentEntity>
		public EntityCollection<DocumentEntity> SelectByTextIdLST(string TextId)
		{
			EntityCollection<DocumentEntity> _DocumentCollection = new EntityCollection<DocumentEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.TextId == TextId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentCollection, filter, 0, null);
			}
			return _DocumentCollection;
		}
		
		// Return EntityCollection<DocumentEntity>
		public EntityCollection<DocumentEntity> SelectByTextIdLST_Paged(string TextId, int PageNumber, int PageSize)
		{
			EntityCollection<DocumentEntity> _DocumentCollection = new EntityCollection<DocumentEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.TextId == TextId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTextIdRDT(string TextId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentCollection = new EntityCollection(new DocumentEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.TextId == TextId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTextIdRDT_Paged(string TextId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentCollection = new EntityCollection(new DocumentEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.TextId == TextId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DocumentEntity>
		public EntityCollection<DocumentEntity> SelectByGroupIdLST(long GroupId)
		{
			EntityCollection<DocumentEntity> _DocumentCollection = new EntityCollection<DocumentEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.GroupId == GroupId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentCollection, filter, 0, null);
			}
			return _DocumentCollection;
		}
		
		// Return EntityCollection<DocumentEntity>
		public EntityCollection<DocumentEntity> SelectByGroupIdLST_Paged(long GroupId, int PageNumber, int PageSize)
		{
			EntityCollection<DocumentEntity> _DocumentCollection = new EntityCollection<DocumentEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.GroupId == GroupId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGroupIdRDT(long GroupId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentCollection = new EntityCollection(new DocumentEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.GroupId == GroupId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGroupIdRDT_Paged(long GroupId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentCollection = new EntityCollection(new DocumentEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.GroupId == GroupId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DocumentEntity>
		public EntityCollection<DocumentEntity> SelectByDescriptionLST(string Description)
		{
			EntityCollection<DocumentEntity> _DocumentCollection = new EntityCollection<DocumentEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.Description == Description);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentCollection, filter, 0, null);
			}
			return _DocumentCollection;
		}
		
		// Return EntityCollection<DocumentEntity>
		public EntityCollection<DocumentEntity> SelectByDescriptionLST_Paged(string Description, int PageNumber, int PageSize)
		{
			EntityCollection<DocumentEntity> _DocumentCollection = new EntityCollection<DocumentEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.Description == Description);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentCollection;
		}
		
		// Return DataTable
		public DataTable SelectByDescriptionRDT(string Description)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentCollection = new EntityCollection(new DocumentEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.Description == Description);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByDescriptionRDT_Paged(string Description, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentCollection = new EntityCollection(new DocumentEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.Description == Description);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DocumentEntity>
		public EntityCollection<DocumentEntity> SelectByMarkLST(int Mark)
		{
			EntityCollection<DocumentEntity> _DocumentCollection = new EntityCollection<DocumentEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.Mark == Mark);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentCollection, filter, 0, null);
			}
			return _DocumentCollection;
		}
		
		// Return EntityCollection<DocumentEntity>
		public EntityCollection<DocumentEntity> SelectByMarkLST_Paged(int Mark, int PageNumber, int PageSize)
		{
			EntityCollection<DocumentEntity> _DocumentCollection = new EntityCollection<DocumentEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.Mark == Mark);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMarkRDT(int Mark)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentCollection = new EntityCollection(new DocumentEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.Mark == Mark);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMarkRDT_Paged(int Mark, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentCollection = new EntityCollection(new DocumentEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.Mark == Mark);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DocumentEntity>
		public EntityCollection<DocumentEntity> SelectByCountDownLST(int CountDown)
		{
			EntityCollection<DocumentEntity> _DocumentCollection = new EntityCollection<DocumentEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.CountDown == CountDown);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentCollection, filter, 0, null);
			}
			return _DocumentCollection;
		}
		
		// Return EntityCollection<DocumentEntity>
		public EntityCollection<DocumentEntity> SelectByCountDownLST_Paged(int CountDown, int PageNumber, int PageSize)
		{
			EntityCollection<DocumentEntity> _DocumentCollection = new EntityCollection<DocumentEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.CountDown == CountDown);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCountDownRDT(int CountDown)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentCollection = new EntityCollection(new DocumentEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.CountDown == CountDown);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCountDownRDT_Paged(int CountDown, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentCollection = new EntityCollection(new DocumentEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.CountDown == CountDown);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DocumentEntity>
		public EntityCollection<DocumentEntity> SelectByReMarkLST(int ReMark)
		{
			EntityCollection<DocumentEntity> _DocumentCollection = new EntityCollection<DocumentEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.ReMark == ReMark);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentCollection, filter, 0, null);
			}
			return _DocumentCollection;
		}
		
		// Return EntityCollection<DocumentEntity>
		public EntityCollection<DocumentEntity> SelectByReMarkLST_Paged(int ReMark, int PageNumber, int PageSize)
		{
			EntityCollection<DocumentEntity> _DocumentCollection = new EntityCollection<DocumentEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.ReMark == ReMark);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentCollection;
		}
		
		// Return DataTable
		public DataTable SelectByReMarkRDT(int ReMark)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentCollection = new EntityCollection(new DocumentEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.ReMark == ReMark);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByReMarkRDT_Paged(int ReMark, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentCollection = new EntityCollection(new DocumentEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.ReMark == ReMark);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DocumentEntity>
		public EntityCollection<DocumentEntity> SelectByPathNameLST(string PathName)
		{
			EntityCollection<DocumentEntity> _DocumentCollection = new EntityCollection<DocumentEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.PathName == PathName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentCollection, filter, 0, null);
			}
			return _DocumentCollection;
		}
		
		// Return EntityCollection<DocumentEntity>
		public EntityCollection<DocumentEntity> SelectByPathNameLST_Paged(string PathName, int PageNumber, int PageSize)
		{
			EntityCollection<DocumentEntity> _DocumentCollection = new EntityCollection<DocumentEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.PathName == PathName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPathNameRDT(string PathName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentCollection = new EntityCollection(new DocumentEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.PathName == PathName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPathNameRDT_Paged(string PathName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentCollection = new EntityCollection(new DocumentEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.PathName == PathName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DocumentEntity>
		public EntityCollection<DocumentEntity> SelectByDisplayImageLST(string DisplayImage)
		{
			EntityCollection<DocumentEntity> _DocumentCollection = new EntityCollection<DocumentEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.DisplayImage == DisplayImage);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentCollection, filter, 0, null);
			}
			return _DocumentCollection;
		}
		
		// Return EntityCollection<DocumentEntity>
		public EntityCollection<DocumentEntity> SelectByDisplayImageLST_Paged(string DisplayImage, int PageNumber, int PageSize)
		{
			EntityCollection<DocumentEntity> _DocumentCollection = new EntityCollection<DocumentEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.DisplayImage == DisplayImage);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentCollection;
		}
		
		// Return DataTable
		public DataTable SelectByDisplayImageRDT(string DisplayImage)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentCollection = new EntityCollection(new DocumentEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.DisplayImage == DisplayImage);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByDisplayImageRDT_Paged(string DisplayImage, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentCollection = new EntityCollection(new DocumentEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.DisplayImage == DisplayImage);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DocumentEntity>
		public EntityCollection<DocumentEntity> SelectByVideoTrailerLST(string VideoTrailer)
		{
			EntityCollection<DocumentEntity> _DocumentCollection = new EntityCollection<DocumentEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.VideoTrailer == VideoTrailer);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentCollection, filter, 0, null);
			}
			return _DocumentCollection;
		}
		
		// Return EntityCollection<DocumentEntity>
		public EntityCollection<DocumentEntity> SelectByVideoTrailerLST_Paged(string VideoTrailer, int PageNumber, int PageSize)
		{
			EntityCollection<DocumentEntity> _DocumentCollection = new EntityCollection<DocumentEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.VideoTrailer == VideoTrailer);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentCollection;
		}
		
		// Return DataTable
		public DataTable SelectByVideoTrailerRDT(string VideoTrailer)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentCollection = new EntityCollection(new DocumentEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.VideoTrailer == VideoTrailer);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByVideoTrailerRDT_Paged(string VideoTrailer, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentCollection = new EntityCollection(new DocumentEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.VideoTrailer == VideoTrailer);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DocumentEntity>
		public EntityCollection<DocumentEntity> SelectByShowVideoLST(bool ShowVideo)
		{
			EntityCollection<DocumentEntity> _DocumentCollection = new EntityCollection<DocumentEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.ShowVideo == ShowVideo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentCollection, filter, 0, null);
			}
			return _DocumentCollection;
		}
		
		// Return EntityCollection<DocumentEntity>
		public EntityCollection<DocumentEntity> SelectByShowVideoLST_Paged(bool ShowVideo, int PageNumber, int PageSize)
		{
			EntityCollection<DocumentEntity> _DocumentCollection = new EntityCollection<DocumentEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.ShowVideo == ShowVideo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentCollection;
		}
		
		// Return DataTable
		public DataTable SelectByShowVideoRDT(bool ShowVideo)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentCollection = new EntityCollection(new DocumentEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.ShowVideo == ShowVideo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByShowVideoRDT_Paged(bool ShowVideo, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentCollection = new EntityCollection(new DocumentEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.ShowVideo == ShowVideo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DocumentEntity>
		public EntityCollection<DocumentEntity> SelectByFileSizeLST(double FileSize)
		{
			EntityCollection<DocumentEntity> _DocumentCollection = new EntityCollection<DocumentEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.FileSize == FileSize);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentCollection, filter, 0, null);
			}
			return _DocumentCollection;
		}
		
		// Return EntityCollection<DocumentEntity>
		public EntityCollection<DocumentEntity> SelectByFileSizeLST_Paged(double FileSize, int PageNumber, int PageSize)
		{
			EntityCollection<DocumentEntity> _DocumentCollection = new EntityCollection<DocumentEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.FileSize == FileSize);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentCollection;
		}
		
		// Return DataTable
		public DataTable SelectByFileSizeRDT(double FileSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentCollection = new EntityCollection(new DocumentEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.FileSize == FileSize);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByFileSizeRDT_Paged(double FileSize, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentCollection = new EntityCollection(new DocumentEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.FileSize == FileSize);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DocumentEntity>
		public EntityCollection<DocumentEntity> SelectByIsVisibleLST(bool IsVisible)
		{
			EntityCollection<DocumentEntity> _DocumentCollection = new EntityCollection<DocumentEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.IsVisible == IsVisible);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentCollection, filter, 0, null);
			}
			return _DocumentCollection;
		}
		
		// Return EntityCollection<DocumentEntity>
		public EntityCollection<DocumentEntity> SelectByIsVisibleLST_Paged(bool IsVisible, int PageNumber, int PageSize)
		{
			EntityCollection<DocumentEntity> _DocumentCollection = new EntityCollection<DocumentEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.IsVisible == IsVisible);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIsVisibleRDT(bool IsVisible)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentCollection = new EntityCollection(new DocumentEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.IsVisible == IsVisible);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIsVisibleRDT_Paged(bool IsVisible, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentCollection = new EntityCollection(new DocumentEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.IsVisible == IsVisible);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DocumentEntity>
		public EntityCollection<DocumentEntity> SelectByCreatedDateLST(DateTime CreatedDate)
		{
			EntityCollection<DocumentEntity> _DocumentCollection = new EntityCollection<DocumentEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentCollection, filter, 0, null);
			}
			return _DocumentCollection;
		}
		
		// Return EntityCollection<DocumentEntity>
		public EntityCollection<DocumentEntity> SelectByCreatedDateLST_Paged(DateTime CreatedDate, int PageNumber, int PageSize)
		{
			EntityCollection<DocumentEntity> _DocumentCollection = new EntityCollection<DocumentEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedDateRDT(DateTime CreatedDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentCollection = new EntityCollection(new DocumentEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedDateRDT_Paged(DateTime CreatedDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentCollection = new EntityCollection(new DocumentEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DocumentEntity>
		public EntityCollection<DocumentEntity> SelectByCreatedByLST(string CreatedBy)
		{
			EntityCollection<DocumentEntity> _DocumentCollection = new EntityCollection<DocumentEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentCollection, filter, 0, null);
			}
			return _DocumentCollection;
		}
		
		// Return EntityCollection<DocumentEntity>
		public EntityCollection<DocumentEntity> SelectByCreatedByLST_Paged(string CreatedBy, int PageNumber, int PageSize)
		{
			EntityCollection<DocumentEntity> _DocumentCollection = new EntityCollection<DocumentEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedByRDT(string CreatedBy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentCollection = new EntityCollection(new DocumentEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedByRDT_Paged(string CreatedBy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentCollection = new EntityCollection(new DocumentEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DocumentEntity>
		public EntityCollection<DocumentEntity> SelectByUpdatedDateLST(DateTime UpdatedDate)
		{
			EntityCollection<DocumentEntity> _DocumentCollection = new EntityCollection<DocumentEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentCollection, filter, 0, null);
			}
			return _DocumentCollection;
		}
		
		// Return EntityCollection<DocumentEntity>
		public EntityCollection<DocumentEntity> SelectByUpdatedDateLST_Paged(DateTime UpdatedDate, int PageNumber, int PageSize)
		{
			EntityCollection<DocumentEntity> _DocumentCollection = new EntityCollection<DocumentEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedDateRDT(DateTime UpdatedDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentCollection = new EntityCollection(new DocumentEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedDateRDT_Paged(DateTime UpdatedDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentCollection = new EntityCollection(new DocumentEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DocumentEntity>
		public EntityCollection<DocumentEntity> SelectByUpdatedByLST(string UpdatedBy)
		{
			EntityCollection<DocumentEntity> _DocumentCollection = new EntityCollection<DocumentEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentCollection, filter, 0, null);
			}
			return _DocumentCollection;
		}
		
		// Return EntityCollection<DocumentEntity>
		public EntityCollection<DocumentEntity> SelectByUpdatedByLST_Paged(string UpdatedBy, int PageNumber, int PageSize)
		{
			EntityCollection<DocumentEntity> _DocumentCollection = new EntityCollection<DocumentEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedByRDT(string UpdatedBy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentCollection = new EntityCollection(new DocumentEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedByRDT_Paged(string UpdatedBy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentCollection = new EntityCollection(new DocumentEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DocumentEntity>
		public EntityCollection<DocumentEntity> SelectByIsDeletedLST(bool IsDeleted)
		{
			EntityCollection<DocumentEntity> _DocumentCollection = new EntityCollection<DocumentEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.IsDeleted == IsDeleted);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentCollection, filter, 0, null);
			}
			return _DocumentCollection;
		}
		
		// Return EntityCollection<DocumentEntity>
		public EntityCollection<DocumentEntity> SelectByIsDeletedLST_Paged(bool IsDeleted, int PageNumber, int PageSize)
		{
			EntityCollection<DocumentEntity> _DocumentCollection = new EntityCollection<DocumentEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.IsDeleted == IsDeleted);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DocumentCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DocumentCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIsDeletedRDT(bool IsDeleted)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentCollection = new EntityCollection(new DocumentEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.IsDeleted == IsDeleted);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIsDeletedRDT_Paged(bool IsDeleted, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DocumentCollection = new EntityCollection(new DocumentEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DocumentFields.IsDeleted == IsDeleted);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DocumentCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
