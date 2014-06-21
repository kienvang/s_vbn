




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.HistoryOrdersManagerBase
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
	public class HistoryOrdersManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public HistoryOrdersManagerBase()
		{
			// Nothing for now.
		}
		
		public HistoryOrdersEntity Insert(HistoryOrdersEntity _HistoryOrdersEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_HistoryOrdersEntity, true);
			}
			return _HistoryOrdersEntity;
		}

		
		public HistoryOrdersEntity Insert(Guid Id, string OrderCode, string ActionName, DateTime ActionDate, string ActionBy)
		{
			HistoryOrdersEntity _HistoryOrdersEntity = new HistoryOrdersEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_HistoryOrdersEntity.Id = Id;
				_HistoryOrdersEntity.OrderCode = OrderCode;
				_HistoryOrdersEntity.ActionName = ActionName;
				_HistoryOrdersEntity.ActionDate = ActionDate;
				_HistoryOrdersEntity.ActionBy = ActionBy;
				adapter.SaveEntity(_HistoryOrdersEntity, true);
			}
			return _HistoryOrdersEntity;
		}

		public HistoryOrdersEntity Insert(string OrderCode, string ActionName, DateTime ActionDate, string ActionBy)
		{
			HistoryOrdersEntity _HistoryOrdersEntity = new HistoryOrdersEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_HistoryOrdersEntity.OrderCode = OrderCode;
				_HistoryOrdersEntity.ActionName = ActionName;
				_HistoryOrdersEntity.ActionDate = ActionDate;
				_HistoryOrdersEntity.ActionBy = ActionBy;
				adapter.SaveEntity(_HistoryOrdersEntity, true);
			}
			return _HistoryOrdersEntity;
		}

		public bool Update(HistoryOrdersEntity _HistoryOrdersEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(HistoryOrdersFields.Id == _HistoryOrdersEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_HistoryOrdersEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(HistoryOrdersEntity _HistoryOrdersEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_HistoryOrdersEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string OrderCode, string ActionName, DateTime ActionDate, string ActionBy)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				HistoryOrdersEntity _HistoryOrdersEntity = new HistoryOrdersEntity(Id);
				if (adapter.FetchEntity(_HistoryOrdersEntity))
				{
				
					_HistoryOrdersEntity.OrderCode = OrderCode;
					_HistoryOrdersEntity.ActionName = ActionName;
					_HistoryOrdersEntity.ActionDate = ActionDate;
					_HistoryOrdersEntity.ActionBy = ActionBy;
					adapter.SaveEntity(_HistoryOrdersEntity, true);
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
				HistoryOrdersEntity _HistoryOrdersEntity = new HistoryOrdersEntity(Id);
				if (adapter.FetchEntity(_HistoryOrdersEntity))
				{
					adapter.DeleteEntity(_HistoryOrdersEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("HistoryOrdersEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryOrdersFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HistoryOrdersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByOrderCode(string OrderCode)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryOrdersFields.OrderCode == OrderCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HistoryOrdersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByActionName(string ActionName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryOrdersFields.ActionName == ActionName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HistoryOrdersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByActionDate(DateTime ActionDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryOrdersFields.ActionDate == ActionDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HistoryOrdersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByActionBy(string ActionBy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryOrdersFields.ActionBy == ActionBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HistoryOrdersEntity", filter);
			}
			return toReturn;
		}
		

		
		public HistoryOrdersEntity SelectOne(Guid Id)
		{
			HistoryOrdersEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				HistoryOrdersEntity _HistoryOrdersEntity = new HistoryOrdersEntity(Id);
				if (adapter.FetchEntity(_HistoryOrdersEntity))
				{
					toReturn = _HistoryOrdersEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HistoryOrdersCollection = new EntityCollection(new HistoryOrdersEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HistoryOrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<HistoryOrdersEntity>
		public EntityCollection<HistoryOrdersEntity> SelectAllLST()
		{
			EntityCollection<HistoryOrdersEntity> _HistoryOrdersCollection = new EntityCollection<HistoryOrdersEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HistoryOrdersCollection, null, 0, null);
			}
			return _HistoryOrdersCollection;
		}
		
		// Return EntityCollection<HistoryOrdersEntity>
		public EntityCollection<HistoryOrdersEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<HistoryOrdersEntity> _HistoryOrdersCollection = new EntityCollection<HistoryOrdersEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HistoryOrdersCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _HistoryOrdersCollection;
		}


		
		// Return EntityCollection<HistoryOrdersEntity>
		public EntityCollection<HistoryOrdersEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<HistoryOrdersEntity> _HistoryOrdersCollection = new EntityCollection<HistoryOrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryOrdersFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HistoryOrdersCollection, filter, 0, null);
			}
			return _HistoryOrdersCollection;
		}
		
		// Return EntityCollection<HistoryOrdersEntity>
		public EntityCollection<HistoryOrdersEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<HistoryOrdersEntity> _HistoryOrdersCollection = new EntityCollection<HistoryOrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryOrdersFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HistoryOrdersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HistoryOrdersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HistoryOrdersCollection = new EntityCollection(new HistoryOrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryOrdersFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HistoryOrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HistoryOrdersCollection = new EntityCollection(new HistoryOrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryOrdersFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HistoryOrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HistoryOrdersEntity>
		public EntityCollection<HistoryOrdersEntity> SelectByOrderCodeLST(string OrderCode)
		{
			EntityCollection<HistoryOrdersEntity> _HistoryOrdersCollection = new EntityCollection<HistoryOrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryOrdersFields.OrderCode == OrderCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HistoryOrdersCollection, filter, 0, null);
			}
			return _HistoryOrdersCollection;
		}
		
		// Return EntityCollection<HistoryOrdersEntity>
		public EntityCollection<HistoryOrdersEntity> SelectByOrderCodeLST_Paged(string OrderCode, int PageNumber, int PageSize)
		{
			EntityCollection<HistoryOrdersEntity> _HistoryOrdersCollection = new EntityCollection<HistoryOrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryOrdersFields.OrderCode == OrderCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HistoryOrdersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HistoryOrdersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByOrderCodeRDT(string OrderCode)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HistoryOrdersCollection = new EntityCollection(new HistoryOrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryOrdersFields.OrderCode == OrderCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HistoryOrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByOrderCodeRDT_Paged(string OrderCode, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HistoryOrdersCollection = new EntityCollection(new HistoryOrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryOrdersFields.OrderCode == OrderCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HistoryOrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HistoryOrdersEntity>
		public EntityCollection<HistoryOrdersEntity> SelectByActionNameLST(string ActionName)
		{
			EntityCollection<HistoryOrdersEntity> _HistoryOrdersCollection = new EntityCollection<HistoryOrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryOrdersFields.ActionName == ActionName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HistoryOrdersCollection, filter, 0, null);
			}
			return _HistoryOrdersCollection;
		}
		
		// Return EntityCollection<HistoryOrdersEntity>
		public EntityCollection<HistoryOrdersEntity> SelectByActionNameLST_Paged(string ActionName, int PageNumber, int PageSize)
		{
			EntityCollection<HistoryOrdersEntity> _HistoryOrdersCollection = new EntityCollection<HistoryOrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryOrdersFields.ActionName == ActionName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HistoryOrdersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HistoryOrdersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByActionNameRDT(string ActionName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HistoryOrdersCollection = new EntityCollection(new HistoryOrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryOrdersFields.ActionName == ActionName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HistoryOrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByActionNameRDT_Paged(string ActionName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HistoryOrdersCollection = new EntityCollection(new HistoryOrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryOrdersFields.ActionName == ActionName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HistoryOrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HistoryOrdersEntity>
		public EntityCollection<HistoryOrdersEntity> SelectByActionDateLST(DateTime ActionDate)
		{
			EntityCollection<HistoryOrdersEntity> _HistoryOrdersCollection = new EntityCollection<HistoryOrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryOrdersFields.ActionDate == ActionDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HistoryOrdersCollection, filter, 0, null);
			}
			return _HistoryOrdersCollection;
		}
		
		// Return EntityCollection<HistoryOrdersEntity>
		public EntityCollection<HistoryOrdersEntity> SelectByActionDateLST_Paged(DateTime ActionDate, int PageNumber, int PageSize)
		{
			EntityCollection<HistoryOrdersEntity> _HistoryOrdersCollection = new EntityCollection<HistoryOrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryOrdersFields.ActionDate == ActionDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HistoryOrdersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HistoryOrdersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByActionDateRDT(DateTime ActionDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HistoryOrdersCollection = new EntityCollection(new HistoryOrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryOrdersFields.ActionDate == ActionDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HistoryOrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByActionDateRDT_Paged(DateTime ActionDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HistoryOrdersCollection = new EntityCollection(new HistoryOrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryOrdersFields.ActionDate == ActionDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HistoryOrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HistoryOrdersEntity>
		public EntityCollection<HistoryOrdersEntity> SelectByActionByLST(string ActionBy)
		{
			EntityCollection<HistoryOrdersEntity> _HistoryOrdersCollection = new EntityCollection<HistoryOrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryOrdersFields.ActionBy == ActionBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HistoryOrdersCollection, filter, 0, null);
			}
			return _HistoryOrdersCollection;
		}
		
		// Return EntityCollection<HistoryOrdersEntity>
		public EntityCollection<HistoryOrdersEntity> SelectByActionByLST_Paged(string ActionBy, int PageNumber, int PageSize)
		{
			EntityCollection<HistoryOrdersEntity> _HistoryOrdersCollection = new EntityCollection<HistoryOrdersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryOrdersFields.ActionBy == ActionBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HistoryOrdersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HistoryOrdersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByActionByRDT(string ActionBy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HistoryOrdersCollection = new EntityCollection(new HistoryOrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryOrdersFields.ActionBy == ActionBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HistoryOrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByActionByRDT_Paged(string ActionBy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HistoryOrdersCollection = new EntityCollection(new HistoryOrdersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryOrdersFields.ActionBy == ActionBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HistoryOrdersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
