




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.VideoCatalogManagerBase
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
	public class VideoCatalogManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public VideoCatalogManagerBase()
		{
			// Nothing for now.
		}
		
		public VideoCatalogEntity Insert(VideoCatalogEntity _VideoCatalogEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_VideoCatalogEntity, true);
			}
			return _VideoCatalogEntity;
		}

		
		public VideoCatalogEntity Insert(int Id, string TextId, string CatName, int ParentId)
		{
			VideoCatalogEntity _VideoCatalogEntity = new VideoCatalogEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_VideoCatalogEntity.Id = Id;
				_VideoCatalogEntity.TextId = TextId;
				_VideoCatalogEntity.CatName = CatName;
				_VideoCatalogEntity.ParentId = ParentId;
				adapter.SaveEntity(_VideoCatalogEntity, true);
			}
			return _VideoCatalogEntity;
		}

		public VideoCatalogEntity Insert(string TextId, string CatName, int ParentId)
		{
			VideoCatalogEntity _VideoCatalogEntity = new VideoCatalogEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_VideoCatalogEntity.TextId = TextId;
				_VideoCatalogEntity.CatName = CatName;
				_VideoCatalogEntity.ParentId = ParentId;
				adapter.SaveEntity(_VideoCatalogEntity, true);
			}
			return _VideoCatalogEntity;
		}

		public bool Update(VideoCatalogEntity _VideoCatalogEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(VideoCatalogFields.Id == _VideoCatalogEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_VideoCatalogEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(VideoCatalogEntity _VideoCatalogEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_VideoCatalogEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(int Id, string TextId, string CatName, int ParentId)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				VideoCatalogEntity _VideoCatalogEntity = new VideoCatalogEntity(Id);
				if (adapter.FetchEntity(_VideoCatalogEntity))
				{
				
					_VideoCatalogEntity.TextId = TextId;
					_VideoCatalogEntity.CatName = CatName;
					_VideoCatalogEntity.ParentId = ParentId;
					adapter.SaveEntity(_VideoCatalogEntity, true);
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
				VideoCatalogEntity _VideoCatalogEntity = new VideoCatalogEntity(Id);
				if (adapter.FetchEntity(_VideoCatalogEntity))
				{
					adapter.DeleteEntity(_VideoCatalogEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("VideoCatalogEntity", null);
			}
		}
		
		
		public int DeleteById(int Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideoCatalogFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VideoCatalogEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTextId(string TextId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideoCatalogFields.TextId == TextId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VideoCatalogEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCatName(string CatName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideoCatalogFields.CatName == CatName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VideoCatalogEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByParentId(int ParentId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideoCatalogFields.ParentId == ParentId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VideoCatalogEntity", filter);
			}
			return toReturn;
		}
		

		
		public VideoCatalogEntity SelectOne(int Id)
		{
			VideoCatalogEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				VideoCatalogEntity _VideoCatalogEntity = new VideoCatalogEntity(Id);
				if (adapter.FetchEntity(_VideoCatalogEntity))
				{
					toReturn = _VideoCatalogEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideoCatalogCollection = new EntityCollection(new VideoCatalogEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideoCatalogCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<VideoCatalogEntity>
		public EntityCollection<VideoCatalogEntity> SelectAllLST()
		{
			EntityCollection<VideoCatalogEntity> _VideoCatalogCollection = new EntityCollection<VideoCatalogEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideoCatalogCollection, null, 0, null);
			}
			return _VideoCatalogCollection;
		}
		
		// Return EntityCollection<VideoCatalogEntity>
		public EntityCollection<VideoCatalogEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<VideoCatalogEntity> _VideoCatalogCollection = new EntityCollection<VideoCatalogEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideoCatalogCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _VideoCatalogCollection;
		}


		
		// Return EntityCollection<VideoCatalogEntity>
		public EntityCollection<VideoCatalogEntity> SelectByIdLST(int Id)
		{
			EntityCollection<VideoCatalogEntity> _VideoCatalogCollection = new EntityCollection<VideoCatalogEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideoCatalogFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideoCatalogCollection, filter, 0, null);
			}
			return _VideoCatalogCollection;
		}
		
		// Return EntityCollection<VideoCatalogEntity>
		public EntityCollection<VideoCatalogEntity> SelectByIdLST_Paged(int Id, int PageNumber, int PageSize)
		{
			EntityCollection<VideoCatalogEntity> _VideoCatalogCollection = new EntityCollection<VideoCatalogEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideoCatalogFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideoCatalogCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VideoCatalogCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(int Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideoCatalogCollection = new EntityCollection(new VideoCatalogEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideoCatalogFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideoCatalogCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(int Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideoCatalogCollection = new EntityCollection(new VideoCatalogEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideoCatalogFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideoCatalogCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VideoCatalogEntity>
		public EntityCollection<VideoCatalogEntity> SelectByTextIdLST(string TextId)
		{
			EntityCollection<VideoCatalogEntity> _VideoCatalogCollection = new EntityCollection<VideoCatalogEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideoCatalogFields.TextId == TextId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideoCatalogCollection, filter, 0, null);
			}
			return _VideoCatalogCollection;
		}
		
		// Return EntityCollection<VideoCatalogEntity>
		public EntityCollection<VideoCatalogEntity> SelectByTextIdLST_Paged(string TextId, int PageNumber, int PageSize)
		{
			EntityCollection<VideoCatalogEntity> _VideoCatalogCollection = new EntityCollection<VideoCatalogEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideoCatalogFields.TextId == TextId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideoCatalogCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VideoCatalogCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTextIdRDT(string TextId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideoCatalogCollection = new EntityCollection(new VideoCatalogEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideoCatalogFields.TextId == TextId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideoCatalogCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTextIdRDT_Paged(string TextId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideoCatalogCollection = new EntityCollection(new VideoCatalogEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideoCatalogFields.TextId == TextId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideoCatalogCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VideoCatalogEntity>
		public EntityCollection<VideoCatalogEntity> SelectByCatNameLST(string CatName)
		{
			EntityCollection<VideoCatalogEntity> _VideoCatalogCollection = new EntityCollection<VideoCatalogEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideoCatalogFields.CatName == CatName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideoCatalogCollection, filter, 0, null);
			}
			return _VideoCatalogCollection;
		}
		
		// Return EntityCollection<VideoCatalogEntity>
		public EntityCollection<VideoCatalogEntity> SelectByCatNameLST_Paged(string CatName, int PageNumber, int PageSize)
		{
			EntityCollection<VideoCatalogEntity> _VideoCatalogCollection = new EntityCollection<VideoCatalogEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideoCatalogFields.CatName == CatName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideoCatalogCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VideoCatalogCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCatNameRDT(string CatName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideoCatalogCollection = new EntityCollection(new VideoCatalogEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideoCatalogFields.CatName == CatName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideoCatalogCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCatNameRDT_Paged(string CatName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideoCatalogCollection = new EntityCollection(new VideoCatalogEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideoCatalogFields.CatName == CatName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideoCatalogCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VideoCatalogEntity>
		public EntityCollection<VideoCatalogEntity> SelectByParentIdLST(int ParentId)
		{
			EntityCollection<VideoCatalogEntity> _VideoCatalogCollection = new EntityCollection<VideoCatalogEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideoCatalogFields.ParentId == ParentId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideoCatalogCollection, filter, 0, null);
			}
			return _VideoCatalogCollection;
		}
		
		// Return EntityCollection<VideoCatalogEntity>
		public EntityCollection<VideoCatalogEntity> SelectByParentIdLST_Paged(int ParentId, int PageNumber, int PageSize)
		{
			EntityCollection<VideoCatalogEntity> _VideoCatalogCollection = new EntityCollection<VideoCatalogEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideoCatalogFields.ParentId == ParentId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VideoCatalogCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VideoCatalogCollection;
		}
		
		// Return DataTable
		public DataTable SelectByParentIdRDT(int ParentId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideoCatalogCollection = new EntityCollection(new VideoCatalogEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideoCatalogFields.ParentId == ParentId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideoCatalogCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByParentIdRDT_Paged(int ParentId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VideoCatalogCollection = new EntityCollection(new VideoCatalogEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VideoCatalogFields.ParentId == ParentId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VideoCatalogCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
