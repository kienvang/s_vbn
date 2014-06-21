




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.VideosManagerBase
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
	public class VideosManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public VideosManagerBase()
		{
			// Nothing for now.
		}
		
		public VideosEntity Insert(VideosEntity _VideosEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_VideosEntity, true);
			}
			return _VideosEntity;
		}

		
		public VideosEntity Insert(Guid Id, int CatalogId, int IntId, string VideoName, string TextId, string Thumbnail, string Path, string ObjectType, string CodeEmbed, bool IsEmbeb, string VideoTypeId, bool AutoStart, bool IsVisibleHome, string Descriptions, int Views, DateTime CreatedDate, string CreatedBy)
		{
			VideosEntity _VideosEntity = new VideosEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_VideosEntity.Id = Id;
				_VideosEntity.CatalogId = CatalogId;
				_VideosEntity.VideoName = VideoName;
				_VideosEntity.TextId = TextId;
				_VideosEntity.Thumbnail = Thumbnail;
				_VideosEntity.Path = Path;
				_VideosEntity.ObjectType = ObjectType;
				_VideosEntity.CodeEmbed = CodeEmbed;
				_VideosEntity.IsEmbeb = IsEmbeb;
				_VideosEntity.VideoTypeId = VideoTypeId;
				_VideosEntity.AutoStart = AutoStart;
				_VideosEntity.IsVisibleHome = IsVisibleHome;
				_VideosEntity.Descriptions = Descriptions;
				_VideosEntity.Views = Views;
				_VideosEntity.CreatedDate = CreatedDate;
				_VideosEntity.CreatedBy = CreatedBy;
				adapter.SaveEntity(_VideosEntity, true);
			}
			return _VideosEntity;
		}

		public VideosEntity Insert(int CatalogId, string VideoName, string TextId, string Thumbnail, string Path, string ObjectType, string CodeEmbed, bool IsEmbeb, string VideoTypeId, bool AutoStart, bool IsVisibleHome, string Descriptions, int Views, DateTime CreatedDate, string CreatedBy)
		{
			VideosEntity _VideosEntity = new VideosEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_VideosEntity.CatalogId = CatalogId;
				_VideosEntity.VideoName = VideoName;
				_VideosEntity.TextId = TextId;
				_VideosEntity.Thumbnail = Thumbnail;
				_VideosEntity.Path = Path;
				_VideosEntity.ObjectType = ObjectType;
				_VideosEntity.CodeEmbed = CodeEmbed;
				_VideosEntity.IsEmbeb = IsEmbeb;
				_VideosEntity.VideoTypeId = VideoTypeId;
				_VideosEntity.AutoStart = AutoStart;
				_VideosEntity.IsVisibleHome = IsVisibleHome;
				_VideosEntity.Descriptions = Descriptions;
				_VideosEntity.Views = Views;
				_VideosEntity.CreatedDate = CreatedDate;
				_VideosEntity.CreatedBy = CreatedBy;
				adapter.SaveEntity(_VideosEntity, true);
			}
			return _VideosEntity;
		}

		public bool Update(VideosEntity _VideosEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(VideosFields.Id == _VideosEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_VideosEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(VideosEntity _VideosEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_VideosEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, int CatalogId, int IntId, string VideoName, string TextId, string Thumbnail, string Path, string ObjectType, string CodeEmbed, bool IsEmbeb, string VideoTypeId, bool AutoStart, bool IsVisibleHome, string Descriptions, int Views, DateTime CreatedDate, string CreatedBy)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				VideosEntity _VideosEntity = new VideosEntity(Id);
				if (adapter.FetchEntity(_VideosEntity))
				{
				
					_VideosEntity.CatalogId = CatalogId;
					_VideosEntity.VideoName = VideoName;
					_VideosEntity.TextId = TextId;
					_VideosEntity.Thumbnail = Thumbnail;
					_VideosEntity.Path = Path;
					_VideosEntity.ObjectType = ObjectType;
					_VideosEntity.CodeEmbed = CodeEmbed;
					_VideosEntity.IsEmbeb = IsEmbeb;
					_VideosEntity.VideoTypeId = VideoTypeId;
					_VideosEntity.AutoStart = AutoStart;
					_VideosEntity.IsVisibleHome = IsVisibleHome;
					_VideosEntity.Descriptions = Descriptions;
					_VideosEntity.Views = Views;
					_VideosEntity.CreatedDate = CreatedDate;
					_VideosEntity.CreatedBy = CreatedBy;
					adapter.SaveEntity(_VideosEntity, true);
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
				VideosEntity _VideosEntity = new VideosEntity(Id);
				if (adapter.FetchEntity(_VideosEntity))
				{
					adapter.DeleteEntity(_VideosEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("VideosEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VideosEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCatalogId(int CatalogId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.CatalogId == CatalogId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VideosEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIntId(int IntId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.IntId == IntId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VideosEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByVideoName(string VideoName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.VideoName == VideoName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VideosEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTextId(string TextId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.TextId == TextId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VideosEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByThumbnail(string Thumbnail)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.Thumbnail == Thumbnail);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VideosEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPath(string Path)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.Path == Path);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VideosEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByObjectType(string ObjectType)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.ObjectType == ObjectType);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VideosEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCodeEmbed(string CodeEmbed)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.CodeEmbed == CodeEmbed);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VideosEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIsEmbeb(bool IsEmbeb)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.IsEmbeb == IsEmbeb);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VideosEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByVideoTypeId(string VideoTypeId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.VideoTypeId == VideoTypeId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VideosEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByAutoStart(bool AutoStart)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.AutoStart == AutoStart);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VideosEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIsVisibleHome(bool IsVisibleHome)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.IsVisibleHome == IsVisibleHome);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VideosEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByDescriptions(string Descriptions)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.Descriptions == Descriptions);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VideosEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByViews(int Views)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.Views == Views);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VideosEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCreatedDate(DateTime CreatedDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VideosEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCreatedBy(string CreatedBy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VideosEntity", filter);
			}
			return toReturn;
		}
		

		
		public VideosEntity SelectOne(Guid Id)
		{
			VideosEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				VideosEntity _VideosEntity = new VideosEntity(Id);
				if (adapter.FetchEntity(_VideosEntity))
				{
					toReturn = _VideosEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideosCollection = new EntityCollection(new VideosEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideosCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<VideosEntity>
		public EntityCollection<VideosEntity> SelectAllLST()
		{
			EntityCollection<VideosEntity> _VideosCollection = new EntityCollection<VideosEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideosCollection, null, 0, null);
			}
			return _VideosCollection;
		}
		
		// Return EntityCollection<VideosEntity>
		public EntityCollection<VideosEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<VideosEntity> _VideosCollection = new EntityCollection<VideosEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideosCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _VideosCollection;
		}


		
		// Return EntityCollection<VideosEntity>
		public EntityCollection<VideosEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<VideosEntity> _VideosCollection = new EntityCollection<VideosEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideosCollection, filter, 0, null);
			}
			return _VideosCollection;
		}
		
		// Return EntityCollection<VideosEntity>
		public EntityCollection<VideosEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<VideosEntity> _VideosCollection = new EntityCollection<VideosEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideosCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VideosCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideosCollection = new EntityCollection(new VideosEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideosCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideosCollection = new EntityCollection(new VideosEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideosCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VideosEntity>
		public EntityCollection<VideosEntity> SelectByCatalogIdLST(int CatalogId)
		{
			EntityCollection<VideosEntity> _VideosCollection = new EntityCollection<VideosEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.CatalogId == CatalogId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideosCollection, filter, 0, null);
			}
			return _VideosCollection;
		}
		
		// Return EntityCollection<VideosEntity>
		public EntityCollection<VideosEntity> SelectByCatalogIdLST_Paged(int CatalogId, int PageNumber, int PageSize)
		{
			EntityCollection<VideosEntity> _VideosCollection = new EntityCollection<VideosEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.CatalogId == CatalogId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideosCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VideosCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCatalogIdRDT(int CatalogId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideosCollection = new EntityCollection(new VideosEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.CatalogId == CatalogId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideosCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCatalogIdRDT_Paged(int CatalogId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideosCollection = new EntityCollection(new VideosEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.CatalogId == CatalogId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideosCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VideosEntity>
		public EntityCollection<VideosEntity> SelectByIntIdLST(int IntId)
		{
			EntityCollection<VideosEntity> _VideosCollection = new EntityCollection<VideosEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.IntId == IntId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideosCollection, filter, 0, null);
			}
			return _VideosCollection;
		}
		
		// Return EntityCollection<VideosEntity>
		public EntityCollection<VideosEntity> SelectByIntIdLST_Paged(int IntId, int PageNumber, int PageSize)
		{
			EntityCollection<VideosEntity> _VideosCollection = new EntityCollection<VideosEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.IntId == IntId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideosCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VideosCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIntIdRDT(int IntId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideosCollection = new EntityCollection(new VideosEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.IntId == IntId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideosCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIntIdRDT_Paged(int IntId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideosCollection = new EntityCollection(new VideosEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.IntId == IntId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideosCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VideosEntity>
		public EntityCollection<VideosEntity> SelectByVideoNameLST(string VideoName)
		{
			EntityCollection<VideosEntity> _VideosCollection = new EntityCollection<VideosEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.VideoName == VideoName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideosCollection, filter, 0, null);
			}
			return _VideosCollection;
		}
		
		// Return EntityCollection<VideosEntity>
		public EntityCollection<VideosEntity> SelectByVideoNameLST_Paged(string VideoName, int PageNumber, int PageSize)
		{
			EntityCollection<VideosEntity> _VideosCollection = new EntityCollection<VideosEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.VideoName == VideoName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideosCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VideosCollection;
		}
		
		// Return DataTable
		public DataTable SelectByVideoNameRDT(string VideoName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideosCollection = new EntityCollection(new VideosEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.VideoName == VideoName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideosCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByVideoNameRDT_Paged(string VideoName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideosCollection = new EntityCollection(new VideosEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.VideoName == VideoName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideosCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VideosEntity>
		public EntityCollection<VideosEntity> SelectByTextIdLST(string TextId)
		{
			EntityCollection<VideosEntity> _VideosCollection = new EntityCollection<VideosEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.TextId == TextId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideosCollection, filter, 0, null);
			}
			return _VideosCollection;
		}
		
		// Return EntityCollection<VideosEntity>
		public EntityCollection<VideosEntity> SelectByTextIdLST_Paged(string TextId, int PageNumber, int PageSize)
		{
			EntityCollection<VideosEntity> _VideosCollection = new EntityCollection<VideosEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.TextId == TextId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideosCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VideosCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTextIdRDT(string TextId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideosCollection = new EntityCollection(new VideosEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.TextId == TextId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideosCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTextIdRDT_Paged(string TextId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideosCollection = new EntityCollection(new VideosEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.TextId == TextId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideosCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VideosEntity>
		public EntityCollection<VideosEntity> SelectByThumbnailLST(string Thumbnail)
		{
			EntityCollection<VideosEntity> _VideosCollection = new EntityCollection<VideosEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.Thumbnail == Thumbnail);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideosCollection, filter, 0, null);
			}
			return _VideosCollection;
		}
		
		// Return EntityCollection<VideosEntity>
		public EntityCollection<VideosEntity> SelectByThumbnailLST_Paged(string Thumbnail, int PageNumber, int PageSize)
		{
			EntityCollection<VideosEntity> _VideosCollection = new EntityCollection<VideosEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.Thumbnail == Thumbnail);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideosCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VideosCollection;
		}
		
		// Return DataTable
		public DataTable SelectByThumbnailRDT(string Thumbnail)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideosCollection = new EntityCollection(new VideosEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.Thumbnail == Thumbnail);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideosCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByThumbnailRDT_Paged(string Thumbnail, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideosCollection = new EntityCollection(new VideosEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.Thumbnail == Thumbnail);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideosCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VideosEntity>
		public EntityCollection<VideosEntity> SelectByPathLST(string Path)
		{
			EntityCollection<VideosEntity> _VideosCollection = new EntityCollection<VideosEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.Path == Path);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideosCollection, filter, 0, null);
			}
			return _VideosCollection;
		}
		
		// Return EntityCollection<VideosEntity>
		public EntityCollection<VideosEntity> SelectByPathLST_Paged(string Path, int PageNumber, int PageSize)
		{
			EntityCollection<VideosEntity> _VideosCollection = new EntityCollection<VideosEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.Path == Path);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideosCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VideosCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPathRDT(string Path)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideosCollection = new EntityCollection(new VideosEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.Path == Path);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideosCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPathRDT_Paged(string Path, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideosCollection = new EntityCollection(new VideosEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.Path == Path);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideosCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VideosEntity>
		public EntityCollection<VideosEntity> SelectByObjectTypeLST(string ObjectType)
		{
			EntityCollection<VideosEntity> _VideosCollection = new EntityCollection<VideosEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.ObjectType == ObjectType);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideosCollection, filter, 0, null);
			}
			return _VideosCollection;
		}
		
		// Return EntityCollection<VideosEntity>
		public EntityCollection<VideosEntity> SelectByObjectTypeLST_Paged(string ObjectType, int PageNumber, int PageSize)
		{
			EntityCollection<VideosEntity> _VideosCollection = new EntityCollection<VideosEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.ObjectType == ObjectType);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideosCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VideosCollection;
		}
		
		// Return DataTable
		public DataTable SelectByObjectTypeRDT(string ObjectType)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideosCollection = new EntityCollection(new VideosEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.ObjectType == ObjectType);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideosCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByObjectTypeRDT_Paged(string ObjectType, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideosCollection = new EntityCollection(new VideosEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.ObjectType == ObjectType);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideosCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VideosEntity>
		public EntityCollection<VideosEntity> SelectByCodeEmbedLST(string CodeEmbed)
		{
			EntityCollection<VideosEntity> _VideosCollection = new EntityCollection<VideosEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.CodeEmbed == CodeEmbed);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideosCollection, filter, 0, null);
			}
			return _VideosCollection;
		}
		
		// Return EntityCollection<VideosEntity>
		public EntityCollection<VideosEntity> SelectByCodeEmbedLST_Paged(string CodeEmbed, int PageNumber, int PageSize)
		{
			EntityCollection<VideosEntity> _VideosCollection = new EntityCollection<VideosEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.CodeEmbed == CodeEmbed);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideosCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VideosCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCodeEmbedRDT(string CodeEmbed)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideosCollection = new EntityCollection(new VideosEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.CodeEmbed == CodeEmbed);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideosCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCodeEmbedRDT_Paged(string CodeEmbed, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideosCollection = new EntityCollection(new VideosEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.CodeEmbed == CodeEmbed);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideosCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VideosEntity>
		public EntityCollection<VideosEntity> SelectByIsEmbebLST(bool IsEmbeb)
		{
			EntityCollection<VideosEntity> _VideosCollection = new EntityCollection<VideosEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.IsEmbeb == IsEmbeb);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideosCollection, filter, 0, null);
			}
			return _VideosCollection;
		}
		
		// Return EntityCollection<VideosEntity>
		public EntityCollection<VideosEntity> SelectByIsEmbebLST_Paged(bool IsEmbeb, int PageNumber, int PageSize)
		{
			EntityCollection<VideosEntity> _VideosCollection = new EntityCollection<VideosEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.IsEmbeb == IsEmbeb);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideosCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VideosCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIsEmbebRDT(bool IsEmbeb)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideosCollection = new EntityCollection(new VideosEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.IsEmbeb == IsEmbeb);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideosCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIsEmbebRDT_Paged(bool IsEmbeb, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideosCollection = new EntityCollection(new VideosEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.IsEmbeb == IsEmbeb);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideosCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VideosEntity>
		public EntityCollection<VideosEntity> SelectByVideoTypeIdLST(string VideoTypeId)
		{
			EntityCollection<VideosEntity> _VideosCollection = new EntityCollection<VideosEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.VideoTypeId == VideoTypeId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideosCollection, filter, 0, null);
			}
			return _VideosCollection;
		}
		
		// Return EntityCollection<VideosEntity>
		public EntityCollection<VideosEntity> SelectByVideoTypeIdLST_Paged(string VideoTypeId, int PageNumber, int PageSize)
		{
			EntityCollection<VideosEntity> _VideosCollection = new EntityCollection<VideosEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.VideoTypeId == VideoTypeId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideosCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VideosCollection;
		}
		
		// Return DataTable
		public DataTable SelectByVideoTypeIdRDT(string VideoTypeId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideosCollection = new EntityCollection(new VideosEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.VideoTypeId == VideoTypeId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideosCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByVideoTypeIdRDT_Paged(string VideoTypeId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideosCollection = new EntityCollection(new VideosEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.VideoTypeId == VideoTypeId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideosCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VideosEntity>
		public EntityCollection<VideosEntity> SelectByAutoStartLST(bool AutoStart)
		{
			EntityCollection<VideosEntity> _VideosCollection = new EntityCollection<VideosEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.AutoStart == AutoStart);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideosCollection, filter, 0, null);
			}
			return _VideosCollection;
		}
		
		// Return EntityCollection<VideosEntity>
		public EntityCollection<VideosEntity> SelectByAutoStartLST_Paged(bool AutoStart, int PageNumber, int PageSize)
		{
			EntityCollection<VideosEntity> _VideosCollection = new EntityCollection<VideosEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.AutoStart == AutoStart);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideosCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VideosCollection;
		}
		
		// Return DataTable
		public DataTable SelectByAutoStartRDT(bool AutoStart)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideosCollection = new EntityCollection(new VideosEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.AutoStart == AutoStart);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideosCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByAutoStartRDT_Paged(bool AutoStart, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideosCollection = new EntityCollection(new VideosEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.AutoStart == AutoStart);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideosCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VideosEntity>
		public EntityCollection<VideosEntity> SelectByIsVisibleHomeLST(bool IsVisibleHome)
		{
			EntityCollection<VideosEntity> _VideosCollection = new EntityCollection<VideosEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.IsVisibleHome == IsVisibleHome);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideosCollection, filter, 0, null);
			}
			return _VideosCollection;
		}
		
		// Return EntityCollection<VideosEntity>
		public EntityCollection<VideosEntity> SelectByIsVisibleHomeLST_Paged(bool IsVisibleHome, int PageNumber, int PageSize)
		{
			EntityCollection<VideosEntity> _VideosCollection = new EntityCollection<VideosEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.IsVisibleHome == IsVisibleHome);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideosCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VideosCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIsVisibleHomeRDT(bool IsVisibleHome)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideosCollection = new EntityCollection(new VideosEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.IsVisibleHome == IsVisibleHome);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideosCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIsVisibleHomeRDT_Paged(bool IsVisibleHome, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideosCollection = new EntityCollection(new VideosEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.IsVisibleHome == IsVisibleHome);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideosCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VideosEntity>
		public EntityCollection<VideosEntity> SelectByDescriptionsLST(string Descriptions)
		{
			EntityCollection<VideosEntity> _VideosCollection = new EntityCollection<VideosEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.Descriptions == Descriptions);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideosCollection, filter, 0, null);
			}
			return _VideosCollection;
		}
		
		// Return EntityCollection<VideosEntity>
		public EntityCollection<VideosEntity> SelectByDescriptionsLST_Paged(string Descriptions, int PageNumber, int PageSize)
		{
			EntityCollection<VideosEntity> _VideosCollection = new EntityCollection<VideosEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.Descriptions == Descriptions);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideosCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VideosCollection;
		}
		
		// Return DataTable
		public DataTable SelectByDescriptionsRDT(string Descriptions)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideosCollection = new EntityCollection(new VideosEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.Descriptions == Descriptions);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideosCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByDescriptionsRDT_Paged(string Descriptions, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideosCollection = new EntityCollection(new VideosEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.Descriptions == Descriptions);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideosCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VideosEntity>
		public EntityCollection<VideosEntity> SelectByViewsLST(int Views)
		{
			EntityCollection<VideosEntity> _VideosCollection = new EntityCollection<VideosEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.Views == Views);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideosCollection, filter, 0, null);
			}
			return _VideosCollection;
		}
		
		// Return EntityCollection<VideosEntity>
		public EntityCollection<VideosEntity> SelectByViewsLST_Paged(int Views, int PageNumber, int PageSize)
		{
			EntityCollection<VideosEntity> _VideosCollection = new EntityCollection<VideosEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.Views == Views);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideosCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VideosCollection;
		}
		
		// Return DataTable
		public DataTable SelectByViewsRDT(int Views)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideosCollection = new EntityCollection(new VideosEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.Views == Views);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideosCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByViewsRDT_Paged(int Views, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideosCollection = new EntityCollection(new VideosEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.Views == Views);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideosCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VideosEntity>
		public EntityCollection<VideosEntity> SelectByCreatedDateLST(DateTime CreatedDate)
		{
			EntityCollection<VideosEntity> _VideosCollection = new EntityCollection<VideosEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideosCollection, filter, 0, null);
			}
			return _VideosCollection;
		}
		
		// Return EntityCollection<VideosEntity>
		public EntityCollection<VideosEntity> SelectByCreatedDateLST_Paged(DateTime CreatedDate, int PageNumber, int PageSize)
		{
			EntityCollection<VideosEntity> _VideosCollection = new EntityCollection<VideosEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideosCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VideosCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedDateRDT(DateTime CreatedDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideosCollection = new EntityCollection(new VideosEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideosCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedDateRDT_Paged(DateTime CreatedDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideosCollection = new EntityCollection(new VideosEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideosCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VideosEntity>
		public EntityCollection<VideosEntity> SelectByCreatedByLST(string CreatedBy)
		{
			EntityCollection<VideosEntity> _VideosCollection = new EntityCollection<VideosEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideosCollection, filter, 0, null);
			}
			return _VideosCollection;
		}
		
		// Return EntityCollection<VideosEntity>
		public EntityCollection<VideosEntity> SelectByCreatedByLST_Paged(string CreatedBy, int PageNumber, int PageSize)
		{
			EntityCollection<VideosEntity> _VideosCollection = new EntityCollection<VideosEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideosCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VideosCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedByRDT(string CreatedBy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideosCollection = new EntityCollection(new VideosEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideosCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedByRDT_Paged(string CreatedBy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideosCollection = new EntityCollection(new VideosEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideosFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideosCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
