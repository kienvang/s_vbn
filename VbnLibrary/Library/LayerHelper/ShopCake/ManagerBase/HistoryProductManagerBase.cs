




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.HistoryProductManagerBase
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
	public class HistoryProductManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public HistoryProductManagerBase()
		{
			// Nothing for now.
		}
		
		public HistoryProductEntity Insert(HistoryProductEntity _HistoryProductEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_HistoryProductEntity, true);
			}
			return _HistoryProductEntity;
		}

		
		public HistoryProductEntity Insert(Guid Id, Guid ProductId, string ActionName, DateTime ActionDate, string ActionBy)
		{
			HistoryProductEntity _HistoryProductEntity = new HistoryProductEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_HistoryProductEntity.Id = Id;
				_HistoryProductEntity.ProductId = ProductId;
				_HistoryProductEntity.ActionName = ActionName;
				_HistoryProductEntity.ActionDate = ActionDate;
				_HistoryProductEntity.ActionBy = ActionBy;
				adapter.SaveEntity(_HistoryProductEntity, true);
			}
			return _HistoryProductEntity;
		}

		public HistoryProductEntity Insert(Guid ProductId, string ActionName, DateTime ActionDate, string ActionBy)
		{
			HistoryProductEntity _HistoryProductEntity = new HistoryProductEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_HistoryProductEntity.ProductId = ProductId;
				_HistoryProductEntity.ActionName = ActionName;
				_HistoryProductEntity.ActionDate = ActionDate;
				_HistoryProductEntity.ActionBy = ActionBy;
				adapter.SaveEntity(_HistoryProductEntity, true);
			}
			return _HistoryProductEntity;
		}

		public bool Update(HistoryProductEntity _HistoryProductEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(HistoryProductFields.Id == _HistoryProductEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_HistoryProductEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(HistoryProductEntity _HistoryProductEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_HistoryProductEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, Guid ProductId, string ActionName, DateTime ActionDate, string ActionBy)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				HistoryProductEntity _HistoryProductEntity = new HistoryProductEntity(Id);
				if (adapter.FetchEntity(_HistoryProductEntity))
				{
				
					_HistoryProductEntity.ProductId = ProductId;
					_HistoryProductEntity.ActionName = ActionName;
					_HistoryProductEntity.ActionDate = ActionDate;
					_HistoryProductEntity.ActionBy = ActionBy;
					adapter.SaveEntity(_HistoryProductEntity, true);
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
				HistoryProductEntity _HistoryProductEntity = new HistoryProductEntity(Id);
				if (adapter.FetchEntity(_HistoryProductEntity))
				{
					adapter.DeleteEntity(_HistoryProductEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("HistoryProductEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryProductFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HistoryProductEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByProductId(Guid ProductId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryProductFields.ProductId == ProductId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HistoryProductEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByActionName(string ActionName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryProductFields.ActionName == ActionName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HistoryProductEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByActionDate(DateTime ActionDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryProductFields.ActionDate == ActionDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HistoryProductEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByActionBy(string ActionBy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryProductFields.ActionBy == ActionBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HistoryProductEntity", filter);
			}
			return toReturn;
		}
		

		
		public HistoryProductEntity SelectOne(Guid Id)
		{
			HistoryProductEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				HistoryProductEntity _HistoryProductEntity = new HistoryProductEntity(Id);
				if (adapter.FetchEntity(_HistoryProductEntity))
				{
					toReturn = _HistoryProductEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HistoryProductCollection = new EntityCollection(new HistoryProductEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HistoryProductCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<HistoryProductEntity>
		public EntityCollection<HistoryProductEntity> SelectAllLST()
		{
			EntityCollection<HistoryProductEntity> _HistoryProductCollection = new EntityCollection<HistoryProductEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HistoryProductCollection, null, 0, null);
			}
			return _HistoryProductCollection;
		}
		
		// Return EntityCollection<HistoryProductEntity>
		public EntityCollection<HistoryProductEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<HistoryProductEntity> _HistoryProductCollection = new EntityCollection<HistoryProductEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HistoryProductCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _HistoryProductCollection;
		}


		
		// Return EntityCollection<HistoryProductEntity>
		public EntityCollection<HistoryProductEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<HistoryProductEntity> _HistoryProductCollection = new EntityCollection<HistoryProductEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryProductFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HistoryProductCollection, filter, 0, null);
			}
			return _HistoryProductCollection;
		}
		
		// Return EntityCollection<HistoryProductEntity>
		public EntityCollection<HistoryProductEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<HistoryProductEntity> _HistoryProductCollection = new EntityCollection<HistoryProductEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryProductFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HistoryProductCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HistoryProductCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HistoryProductCollection = new EntityCollection(new HistoryProductEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryProductFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HistoryProductCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HistoryProductCollection = new EntityCollection(new HistoryProductEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryProductFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HistoryProductCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HistoryProductEntity>
		public EntityCollection<HistoryProductEntity> SelectByProductIdLST(Guid ProductId)
		{
			EntityCollection<HistoryProductEntity> _HistoryProductCollection = new EntityCollection<HistoryProductEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryProductFields.ProductId == ProductId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HistoryProductCollection, filter, 0, null);
			}
			return _HistoryProductCollection;
		}
		
		// Return EntityCollection<HistoryProductEntity>
		public EntityCollection<HistoryProductEntity> SelectByProductIdLST_Paged(Guid ProductId, int PageNumber, int PageSize)
		{
			EntityCollection<HistoryProductEntity> _HistoryProductCollection = new EntityCollection<HistoryProductEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryProductFields.ProductId == ProductId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HistoryProductCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HistoryProductCollection;
		}
		
		// Return DataTable
		public DataTable SelectByProductIdRDT(Guid ProductId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HistoryProductCollection = new EntityCollection(new HistoryProductEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryProductFields.ProductId == ProductId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HistoryProductCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByProductIdRDT_Paged(Guid ProductId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HistoryProductCollection = new EntityCollection(new HistoryProductEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryProductFields.ProductId == ProductId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HistoryProductCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HistoryProductEntity>
		public EntityCollection<HistoryProductEntity> SelectByActionNameLST(string ActionName)
		{
			EntityCollection<HistoryProductEntity> _HistoryProductCollection = new EntityCollection<HistoryProductEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryProductFields.ActionName == ActionName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HistoryProductCollection, filter, 0, null);
			}
			return _HistoryProductCollection;
		}
		
		// Return EntityCollection<HistoryProductEntity>
		public EntityCollection<HistoryProductEntity> SelectByActionNameLST_Paged(string ActionName, int PageNumber, int PageSize)
		{
			EntityCollection<HistoryProductEntity> _HistoryProductCollection = new EntityCollection<HistoryProductEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryProductFields.ActionName == ActionName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HistoryProductCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HistoryProductCollection;
		}
		
		// Return DataTable
		public DataTable SelectByActionNameRDT(string ActionName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HistoryProductCollection = new EntityCollection(new HistoryProductEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryProductFields.ActionName == ActionName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HistoryProductCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByActionNameRDT_Paged(string ActionName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HistoryProductCollection = new EntityCollection(new HistoryProductEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryProductFields.ActionName == ActionName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HistoryProductCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HistoryProductEntity>
		public EntityCollection<HistoryProductEntity> SelectByActionDateLST(DateTime ActionDate)
		{
			EntityCollection<HistoryProductEntity> _HistoryProductCollection = new EntityCollection<HistoryProductEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryProductFields.ActionDate == ActionDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HistoryProductCollection, filter, 0, null);
			}
			return _HistoryProductCollection;
		}
		
		// Return EntityCollection<HistoryProductEntity>
		public EntityCollection<HistoryProductEntity> SelectByActionDateLST_Paged(DateTime ActionDate, int PageNumber, int PageSize)
		{
			EntityCollection<HistoryProductEntity> _HistoryProductCollection = new EntityCollection<HistoryProductEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryProductFields.ActionDate == ActionDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HistoryProductCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HistoryProductCollection;
		}
		
		// Return DataTable
		public DataTable SelectByActionDateRDT(DateTime ActionDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HistoryProductCollection = new EntityCollection(new HistoryProductEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryProductFields.ActionDate == ActionDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HistoryProductCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByActionDateRDT_Paged(DateTime ActionDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HistoryProductCollection = new EntityCollection(new HistoryProductEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryProductFields.ActionDate == ActionDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HistoryProductCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HistoryProductEntity>
		public EntityCollection<HistoryProductEntity> SelectByActionByLST(string ActionBy)
		{
			EntityCollection<HistoryProductEntity> _HistoryProductCollection = new EntityCollection<HistoryProductEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryProductFields.ActionBy == ActionBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HistoryProductCollection, filter, 0, null);
			}
			return _HistoryProductCollection;
		}
		
		// Return EntityCollection<HistoryProductEntity>
		public EntityCollection<HistoryProductEntity> SelectByActionByLST_Paged(string ActionBy, int PageNumber, int PageSize)
		{
			EntityCollection<HistoryProductEntity> _HistoryProductCollection = new EntityCollection<HistoryProductEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryProductFields.ActionBy == ActionBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HistoryProductCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HistoryProductCollection;
		}
		
		// Return DataTable
		public DataTable SelectByActionByRDT(string ActionBy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HistoryProductCollection = new EntityCollection(new HistoryProductEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryProductFields.ActionBy == ActionBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HistoryProductCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByActionByRDT_Paged(string ActionBy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HistoryProductCollection = new EntityCollection(new HistoryProductEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryProductFields.ActionBy == ActionBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HistoryProductCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
