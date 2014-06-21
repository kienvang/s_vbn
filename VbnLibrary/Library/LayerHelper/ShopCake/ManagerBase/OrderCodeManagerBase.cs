




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.OrderCodeManagerBase
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
	public class OrderCodeManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public OrderCodeManagerBase()
		{
			// Nothing for now.
		}
		
		public OrderCodeEntity Insert(OrderCodeEntity _OrderCodeEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_OrderCodeEntity, true);
			}
			return _OrderCodeEntity;
		}

		
		public OrderCodeEntity Insert(decimal Id, string NumberYear, string NumberMonth, string NumberDay, long NumberId)
		{
			OrderCodeEntity _OrderCodeEntity = new OrderCodeEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_OrderCodeEntity.NumberYear = NumberYear;
				_OrderCodeEntity.NumberMonth = NumberMonth;
				_OrderCodeEntity.NumberDay = NumberDay;
				_OrderCodeEntity.NumberId = NumberId;
				adapter.SaveEntity(_OrderCodeEntity, true);
			}
			return _OrderCodeEntity;
		}

		public OrderCodeEntity Insert(string NumberYear, string NumberMonth, string NumberDay, long NumberId)
		{
			OrderCodeEntity _OrderCodeEntity = new OrderCodeEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_OrderCodeEntity.NumberYear = NumberYear;
				_OrderCodeEntity.NumberMonth = NumberMonth;
				_OrderCodeEntity.NumberDay = NumberDay;
				_OrderCodeEntity.NumberId = NumberId;
				adapter.SaveEntity(_OrderCodeEntity, true);
			}
			return _OrderCodeEntity;
		}

		public bool Update(OrderCodeEntity _OrderCodeEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_OrderCodeEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(OrderCodeEntity _OrderCodeEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_OrderCodeEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(decimal Id, string NumberYear, string NumberMonth, string NumberDay, long NumberId)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				OrderCodeEntity _OrderCodeEntity = new OrderCodeEntity();
				if (adapter.FetchEntity(_OrderCodeEntity))
				{
				
					_OrderCodeEntity.NumberYear = NumberYear;
					_OrderCodeEntity.NumberMonth = NumberMonth;
					_OrderCodeEntity.NumberDay = NumberDay;
					_OrderCodeEntity.NumberId = NumberId;
					adapter.SaveEntity(_OrderCodeEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete()
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				OrderCodeEntity _OrderCodeEntity = new OrderCodeEntity();
				if (adapter.FetchEntity(_OrderCodeEntity))
				{
					adapter.DeleteEntity(_OrderCodeEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("OrderCodeEntity", null);
			}
		}
		
		
		public int DeleteById(decimal Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderCodeFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrderCodeEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNumberYear(string NumberYear)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderCodeFields.NumberYear == NumberYear);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrderCodeEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNumberMonth(string NumberMonth)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderCodeFields.NumberMonth == NumberMonth);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrderCodeEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNumberDay(string NumberDay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderCodeFields.NumberDay == NumberDay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrderCodeEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNumberId(long NumberId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderCodeFields.NumberId == NumberId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrderCodeEntity", filter);
			}
			return toReturn;
		}
		

		
		public OrderCodeEntity SelectOne()
		{
			OrderCodeEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				OrderCodeEntity _OrderCodeEntity = new OrderCodeEntity();
				if (adapter.FetchEntity(_OrderCodeEntity))
				{
					toReturn = _OrderCodeEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderCodeCollection = new EntityCollection(new OrderCodeEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderCodeCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<OrderCodeEntity>
		public EntityCollection<OrderCodeEntity> SelectAllLST()
		{
			EntityCollection<OrderCodeEntity> _OrderCodeCollection = new EntityCollection<OrderCodeEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderCodeCollection, null, 0, null);
			}
			return _OrderCodeCollection;
		}
		
		// Return EntityCollection<OrderCodeEntity>
		public EntityCollection<OrderCodeEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<OrderCodeEntity> _OrderCodeCollection = new EntityCollection<OrderCodeEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderCodeCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _OrderCodeCollection;
		}


		
		// Return EntityCollection<OrderCodeEntity>
		public EntityCollection<OrderCodeEntity> SelectByIdLST(decimal Id)
		{
			EntityCollection<OrderCodeEntity> _OrderCodeCollection = new EntityCollection<OrderCodeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderCodeFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderCodeCollection, filter, 0, null);
			}
			return _OrderCodeCollection;
		}
		
		// Return EntityCollection<OrderCodeEntity>
		public EntityCollection<OrderCodeEntity> SelectByIdLST_Paged(decimal Id, int PageNumber, int PageSize)
		{
			EntityCollection<OrderCodeEntity> _OrderCodeCollection = new EntityCollection<OrderCodeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderCodeFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderCodeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrderCodeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(decimal Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderCodeCollection = new EntityCollection(new OrderCodeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderCodeFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderCodeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(decimal Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderCodeCollection = new EntityCollection(new OrderCodeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderCodeFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderCodeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrderCodeEntity>
		public EntityCollection<OrderCodeEntity> SelectByNumberYearLST(string NumberYear)
		{
			EntityCollection<OrderCodeEntity> _OrderCodeCollection = new EntityCollection<OrderCodeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderCodeFields.NumberYear == NumberYear);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderCodeCollection, filter, 0, null);
			}
			return _OrderCodeCollection;
		}
		
		// Return EntityCollection<OrderCodeEntity>
		public EntityCollection<OrderCodeEntity> SelectByNumberYearLST_Paged(string NumberYear, int PageNumber, int PageSize)
		{
			EntityCollection<OrderCodeEntity> _OrderCodeCollection = new EntityCollection<OrderCodeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderCodeFields.NumberYear == NumberYear);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderCodeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrderCodeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNumberYearRDT(string NumberYear)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderCodeCollection = new EntityCollection(new OrderCodeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderCodeFields.NumberYear == NumberYear);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderCodeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNumberYearRDT_Paged(string NumberYear, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderCodeCollection = new EntityCollection(new OrderCodeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderCodeFields.NumberYear == NumberYear);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderCodeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrderCodeEntity>
		public EntityCollection<OrderCodeEntity> SelectByNumberMonthLST(string NumberMonth)
		{
			EntityCollection<OrderCodeEntity> _OrderCodeCollection = new EntityCollection<OrderCodeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderCodeFields.NumberMonth == NumberMonth);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderCodeCollection, filter, 0, null);
			}
			return _OrderCodeCollection;
		}
		
		// Return EntityCollection<OrderCodeEntity>
		public EntityCollection<OrderCodeEntity> SelectByNumberMonthLST_Paged(string NumberMonth, int PageNumber, int PageSize)
		{
			EntityCollection<OrderCodeEntity> _OrderCodeCollection = new EntityCollection<OrderCodeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderCodeFields.NumberMonth == NumberMonth);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderCodeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrderCodeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNumberMonthRDT(string NumberMonth)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderCodeCollection = new EntityCollection(new OrderCodeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderCodeFields.NumberMonth == NumberMonth);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderCodeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNumberMonthRDT_Paged(string NumberMonth, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderCodeCollection = new EntityCollection(new OrderCodeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderCodeFields.NumberMonth == NumberMonth);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderCodeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrderCodeEntity>
		public EntityCollection<OrderCodeEntity> SelectByNumberDayLST(string NumberDay)
		{
			EntityCollection<OrderCodeEntity> _OrderCodeCollection = new EntityCollection<OrderCodeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderCodeFields.NumberDay == NumberDay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderCodeCollection, filter, 0, null);
			}
			return _OrderCodeCollection;
		}
		
		// Return EntityCollection<OrderCodeEntity>
		public EntityCollection<OrderCodeEntity> SelectByNumberDayLST_Paged(string NumberDay, int PageNumber, int PageSize)
		{
			EntityCollection<OrderCodeEntity> _OrderCodeCollection = new EntityCollection<OrderCodeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderCodeFields.NumberDay == NumberDay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderCodeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrderCodeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNumberDayRDT(string NumberDay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderCodeCollection = new EntityCollection(new OrderCodeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderCodeFields.NumberDay == NumberDay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderCodeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNumberDayRDT_Paged(string NumberDay, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderCodeCollection = new EntityCollection(new OrderCodeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderCodeFields.NumberDay == NumberDay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderCodeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrderCodeEntity>
		public EntityCollection<OrderCodeEntity> SelectByNumberIdLST(long NumberId)
		{
			EntityCollection<OrderCodeEntity> _OrderCodeCollection = new EntityCollection<OrderCodeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderCodeFields.NumberId == NumberId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderCodeCollection, filter, 0, null);
			}
			return _OrderCodeCollection;
		}
		
		// Return EntityCollection<OrderCodeEntity>
		public EntityCollection<OrderCodeEntity> SelectByNumberIdLST_Paged(long NumberId, int PageNumber, int PageSize)
		{
			EntityCollection<OrderCodeEntity> _OrderCodeCollection = new EntityCollection<OrderCodeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderCodeFields.NumberId == NumberId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderCodeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrderCodeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNumberIdRDT(long NumberId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderCodeCollection = new EntityCollection(new OrderCodeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderCodeFields.NumberId == NumberId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderCodeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNumberIdRDT_Paged(long NumberId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderCodeCollection = new EntityCollection(new OrderCodeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderCodeFields.NumberId == NumberId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderCodeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
