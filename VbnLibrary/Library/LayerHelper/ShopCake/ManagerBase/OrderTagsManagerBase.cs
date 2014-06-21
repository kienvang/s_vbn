




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.OrderTagsManagerBase
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
	public class OrderTagsManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public OrderTagsManagerBase()
		{
			// Nothing for now.
		}
		
		public OrderTagsEntity Insert(OrderTagsEntity _OrderTagsEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_OrderTagsEntity, true);
			}
			return _OrderTagsEntity;
		}

		
		public OrderTagsEntity Insert(string Id, string TagName, string ParentId)
		{
			OrderTagsEntity _OrderTagsEntity = new OrderTagsEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_OrderTagsEntity.Id = Id;
				_OrderTagsEntity.TagName = TagName;
				_OrderTagsEntity.ParentId = ParentId;
				adapter.SaveEntity(_OrderTagsEntity, true);
			}
			return _OrderTagsEntity;
		}

		public OrderTagsEntity Insert(string TagName, string ParentId)
		{
			OrderTagsEntity _OrderTagsEntity = new OrderTagsEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_OrderTagsEntity.TagName = TagName;
				_OrderTagsEntity.ParentId = ParentId;
				adapter.SaveEntity(_OrderTagsEntity, true);
			}
			return _OrderTagsEntity;
		}

		public bool Update(OrderTagsEntity _OrderTagsEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(OrderTagsFields.Id == _OrderTagsEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_OrderTagsEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(OrderTagsEntity _OrderTagsEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_OrderTagsEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(string Id, string TagName, string ParentId)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				OrderTagsEntity _OrderTagsEntity = new OrderTagsEntity(Id);
				if (adapter.FetchEntity(_OrderTagsEntity))
				{
				
					_OrderTagsEntity.TagName = TagName;
					_OrderTagsEntity.ParentId = ParentId;
					adapter.SaveEntity(_OrderTagsEntity, true);
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
				OrderTagsEntity _OrderTagsEntity = new OrderTagsEntity(Id);
				if (adapter.FetchEntity(_OrderTagsEntity))
				{
					adapter.DeleteEntity(_OrderTagsEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("OrderTagsEntity", null);
			}
		}
		
		
		public int DeleteById(string Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTagsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrderTagsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTagName(string TagName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTagsFields.TagName == TagName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrderTagsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByParentId(string ParentId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTagsFields.ParentId == ParentId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrderTagsEntity", filter);
			}
			return toReturn;
		}
		

		
		public OrderTagsEntity SelectOne(string Id)
		{
			OrderTagsEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				OrderTagsEntity _OrderTagsEntity = new OrderTagsEntity(Id);
				if (adapter.FetchEntity(_OrderTagsEntity))
				{
					toReturn = _OrderTagsEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderTagsCollection = new EntityCollection(new OrderTagsEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderTagsCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<OrderTagsEntity>
		public EntityCollection<OrderTagsEntity> SelectAllLST()
		{
			EntityCollection<OrderTagsEntity> _OrderTagsCollection = new EntityCollection<OrderTagsEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderTagsCollection, null, 0, null);
			}
			return _OrderTagsCollection;
		}
		
		// Return EntityCollection<OrderTagsEntity>
		public EntityCollection<OrderTagsEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<OrderTagsEntity> _OrderTagsCollection = new EntityCollection<OrderTagsEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderTagsCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _OrderTagsCollection;
		}


		
		// Return EntityCollection<OrderTagsEntity>
		public EntityCollection<OrderTagsEntity> SelectByIdLST(string Id)
		{
			EntityCollection<OrderTagsEntity> _OrderTagsCollection = new EntityCollection<OrderTagsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTagsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderTagsCollection, filter, 0, null);
			}
			return _OrderTagsCollection;
		}
		
		// Return EntityCollection<OrderTagsEntity>
		public EntityCollection<OrderTagsEntity> SelectByIdLST_Paged(string Id, int PageNumber, int PageSize)
		{
			EntityCollection<OrderTagsEntity> _OrderTagsCollection = new EntityCollection<OrderTagsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTagsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderTagsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrderTagsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(string Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderTagsCollection = new EntityCollection(new OrderTagsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTagsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderTagsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(string Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderTagsCollection = new EntityCollection(new OrderTagsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTagsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderTagsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrderTagsEntity>
		public EntityCollection<OrderTagsEntity> SelectByTagNameLST(string TagName)
		{
			EntityCollection<OrderTagsEntity> _OrderTagsCollection = new EntityCollection<OrderTagsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTagsFields.TagName == TagName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderTagsCollection, filter, 0, null);
			}
			return _OrderTagsCollection;
		}
		
		// Return EntityCollection<OrderTagsEntity>
		public EntityCollection<OrderTagsEntity> SelectByTagNameLST_Paged(string TagName, int PageNumber, int PageSize)
		{
			EntityCollection<OrderTagsEntity> _OrderTagsCollection = new EntityCollection<OrderTagsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTagsFields.TagName == TagName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderTagsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrderTagsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTagNameRDT(string TagName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderTagsCollection = new EntityCollection(new OrderTagsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTagsFields.TagName == TagName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderTagsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTagNameRDT_Paged(string TagName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderTagsCollection = new EntityCollection(new OrderTagsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTagsFields.TagName == TagName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderTagsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrderTagsEntity>
		public EntityCollection<OrderTagsEntity> SelectByParentIdLST(string ParentId)
		{
			EntityCollection<OrderTagsEntity> _OrderTagsCollection = new EntityCollection<OrderTagsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTagsFields.ParentId == ParentId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderTagsCollection, filter, 0, null);
			}
			return _OrderTagsCollection;
		}
		
		// Return EntityCollection<OrderTagsEntity>
		public EntityCollection<OrderTagsEntity> SelectByParentIdLST_Paged(string ParentId, int PageNumber, int PageSize)
		{
			EntityCollection<OrderTagsEntity> _OrderTagsCollection = new EntityCollection<OrderTagsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTagsFields.ParentId == ParentId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderTagsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrderTagsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByParentIdRDT(string ParentId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderTagsCollection = new EntityCollection(new OrderTagsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTagsFields.ParentId == ParentId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderTagsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByParentIdRDT_Paged(string ParentId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderTagsCollection = new EntityCollection(new OrderTagsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTagsFields.ParentId == ParentId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderTagsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
