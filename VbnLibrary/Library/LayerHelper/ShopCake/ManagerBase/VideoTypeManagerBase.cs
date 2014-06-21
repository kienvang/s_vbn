




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.VideoTypeManagerBase
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
	public class VideoTypeManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public VideoTypeManagerBase()
		{
			// Nothing for now.
		}
		
		public VideoTypeEntity Insert(VideoTypeEntity _VideoTypeEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_VideoTypeEntity, true);
			}
			return _VideoTypeEntity;
		}

		
		public VideoTypeEntity Insert(string Id, string TypeName, string ParentId)
		{
			VideoTypeEntity _VideoTypeEntity = new VideoTypeEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_VideoTypeEntity.Id = Id;
				_VideoTypeEntity.TypeName = TypeName;
				_VideoTypeEntity.ParentId = ParentId;
				adapter.SaveEntity(_VideoTypeEntity, true);
			}
			return _VideoTypeEntity;
		}

		public VideoTypeEntity Insert(string TypeName, string ParentId)
		{
			VideoTypeEntity _VideoTypeEntity = new VideoTypeEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_VideoTypeEntity.TypeName = TypeName;
				_VideoTypeEntity.ParentId = ParentId;
				adapter.SaveEntity(_VideoTypeEntity, true);
			}
			return _VideoTypeEntity;
		}

		public bool Update(VideoTypeEntity _VideoTypeEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(VideoTypeFields.Id == _VideoTypeEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_VideoTypeEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(VideoTypeEntity _VideoTypeEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_VideoTypeEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(string Id, string TypeName, string ParentId)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				VideoTypeEntity _VideoTypeEntity = new VideoTypeEntity(Id);
				if (adapter.FetchEntity(_VideoTypeEntity))
				{
				
					_VideoTypeEntity.TypeName = TypeName;
					_VideoTypeEntity.ParentId = ParentId;
					adapter.SaveEntity(_VideoTypeEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(string Id)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				VideoTypeEntity _VideoTypeEntity = new VideoTypeEntity(Id);
				if (adapter.FetchEntity(_VideoTypeEntity))
				{
					adapter.DeleteEntity(_VideoTypeEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("VideoTypeEntity", null);
			}
		}
		
		
		public int DeleteById(string Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideoTypeFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VideoTypeEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTypeName(string TypeName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideoTypeFields.TypeName == TypeName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VideoTypeEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByParentId(string ParentId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideoTypeFields.ParentId == ParentId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VideoTypeEntity", filter);
			}
			return toReturn;
		}
		

		
		public VideoTypeEntity SelectOne(string Id)
		{
			VideoTypeEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				VideoTypeEntity _VideoTypeEntity = new VideoTypeEntity(Id);
				if (adapter.FetchEntity(_VideoTypeEntity))
				{
					toReturn = _VideoTypeEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideoTypeCollection = new EntityCollection(new VideoTypeEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideoTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<VideoTypeEntity>
		public EntityCollection<VideoTypeEntity> SelectAllLST()
		{
			EntityCollection<VideoTypeEntity> _VideoTypeCollection = new EntityCollection<VideoTypeEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideoTypeCollection, null, 0, null);
			}
			return _VideoTypeCollection;
		}
		
		// Return EntityCollection<VideoTypeEntity>
		public EntityCollection<VideoTypeEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<VideoTypeEntity> _VideoTypeCollection = new EntityCollection<VideoTypeEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideoTypeCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _VideoTypeCollection;
		}


		
		// Return EntityCollection<VideoTypeEntity>
		public EntityCollection<VideoTypeEntity> SelectByIdLST(string Id)
		{
			EntityCollection<VideoTypeEntity> _VideoTypeCollection = new EntityCollection<VideoTypeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideoTypeFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideoTypeCollection, filter, 0, null);
			}
			return _VideoTypeCollection;
		}
		
		// Return EntityCollection<VideoTypeEntity>
		public EntityCollection<VideoTypeEntity> SelectByIdLST_Paged(string Id, int PageNumber, int PageSize)
		{
			EntityCollection<VideoTypeEntity> _VideoTypeCollection = new EntityCollection<VideoTypeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideoTypeFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideoTypeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VideoTypeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(string Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideoTypeCollection = new EntityCollection(new VideoTypeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideoTypeFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideoTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(string Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideoTypeCollection = new EntityCollection(new VideoTypeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideoTypeFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideoTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VideoTypeEntity>
		public EntityCollection<VideoTypeEntity> SelectByTypeNameLST(string TypeName)
		{
			EntityCollection<VideoTypeEntity> _VideoTypeCollection = new EntityCollection<VideoTypeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideoTypeFields.TypeName == TypeName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideoTypeCollection, filter, 0, null);
			}
			return _VideoTypeCollection;
		}
		
		// Return EntityCollection<VideoTypeEntity>
		public EntityCollection<VideoTypeEntity> SelectByTypeNameLST_Paged(string TypeName, int PageNumber, int PageSize)
		{
			EntityCollection<VideoTypeEntity> _VideoTypeCollection = new EntityCollection<VideoTypeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideoTypeFields.TypeName == TypeName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideoTypeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VideoTypeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTypeNameRDT(string TypeName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideoTypeCollection = new EntityCollection(new VideoTypeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideoTypeFields.TypeName == TypeName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideoTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTypeNameRDT_Paged(string TypeName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideoTypeCollection = new EntityCollection(new VideoTypeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideoTypeFields.TypeName == TypeName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideoTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VideoTypeEntity>
		public EntityCollection<VideoTypeEntity> SelectByParentIdLST(string ParentId)
		{
			EntityCollection<VideoTypeEntity> _VideoTypeCollection = new EntityCollection<VideoTypeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideoTypeFields.ParentId == ParentId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideoTypeCollection, filter, 0, null);
			}
			return _VideoTypeCollection;
		}
		
		// Return EntityCollection<VideoTypeEntity>
		public EntityCollection<VideoTypeEntity> SelectByParentIdLST_Paged(string ParentId, int PageNumber, int PageSize)
		{
			EntityCollection<VideoTypeEntity> _VideoTypeCollection = new EntityCollection<VideoTypeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideoTypeFields.ParentId == ParentId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideoTypeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VideoTypeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByParentIdRDT(string ParentId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideoTypeCollection = new EntityCollection(new VideoTypeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideoTypeFields.ParentId == ParentId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideoTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByParentIdRDT_Paged(string ParentId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideoTypeCollection = new EntityCollection(new VideoTypeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideoTypeFields.ParentId == ParentId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideoTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
