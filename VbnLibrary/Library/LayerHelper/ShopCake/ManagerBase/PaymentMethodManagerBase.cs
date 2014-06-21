


/*
'===============================================================================
'  LayerHelper.ShopCake.BL.PaymentMethodManagerBase
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
	public class PaymentMethodManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public PaymentMethodManagerBase()
		{
			// Nothing for now.
		}
		
		public PaymentMethodEntity Insert(PaymentMethodEntity _PaymentMethodEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_PaymentMethodEntity, true);
			}
			return _PaymentMethodEntity;
		}

		
		public PaymentMethodEntity Insert(string PayId, string PayName, bool IsEnable, bool IsVisible, string Link)
		{
			PaymentMethodEntity _PaymentMethodEntity = new PaymentMethodEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_PaymentMethodEntity.PayId = PayId;
				_PaymentMethodEntity.PayName = PayName;
				_PaymentMethodEntity.IsEnable = IsEnable;
				_PaymentMethodEntity.IsVisible = IsVisible;
				_PaymentMethodEntity.Link = Link;
				adapter.SaveEntity(_PaymentMethodEntity, true);
			}
			return _PaymentMethodEntity;
		}

		public PaymentMethodEntity Insert(string PayName, bool IsEnable, bool IsVisible, string Link)
		{
			PaymentMethodEntity _PaymentMethodEntity = new PaymentMethodEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_PaymentMethodEntity.PayName = PayName;
				_PaymentMethodEntity.IsEnable = IsEnable;
				_PaymentMethodEntity.IsVisible = IsVisible;
				_PaymentMethodEntity.Link = Link;
				adapter.SaveEntity(_PaymentMethodEntity, true);
			}
			return _PaymentMethodEntity;
		}

		public bool Update(PaymentMethodEntity _PaymentMethodEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(PaymentMethodFields.PayId == _PaymentMethodEntity.PayId);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_PaymentMethodEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(PaymentMethodEntity _PaymentMethodEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_PaymentMethodEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(string PayId, string PayName, bool IsEnable, bool IsVisible, string Link)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				PaymentMethodEntity _PaymentMethodEntity = new PaymentMethodEntity(PayId);
				if (adapter.FetchEntity(_PaymentMethodEntity))
				{
				
					_PaymentMethodEntity.PayName = PayName;
					_PaymentMethodEntity.IsEnable = IsEnable;
					_PaymentMethodEntity.IsVisible = IsVisible;
					_PaymentMethodEntity.Link = Link;
					adapter.SaveEntity(_PaymentMethodEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(string PayId)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				PaymentMethodEntity _PaymentMethodEntity = new PaymentMethodEntity(PayId);
				if (adapter.FetchEntity(_PaymentMethodEntity))
				{
					adapter.DeleteEntity(_PaymentMethodEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("PaymentMethodEntity", null);
			}
		}
		
		
		public int DeleteByPayId(string PayId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentMethodFields.PayId == PayId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PaymentMethodEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPayName(string PayName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentMethodFields.PayName == PayName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PaymentMethodEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIsEnable(bool IsEnable)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentMethodFields.IsEnable == IsEnable);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PaymentMethodEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIsVisible(bool IsVisible)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentMethodFields.IsVisible == IsVisible);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PaymentMethodEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLink(string Link)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentMethodFields.Link == Link);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PaymentMethodEntity", filter);
			}
			return toReturn;
		}
		

		
		public PaymentMethodEntity SelectOne(string PayId)
		{
			PaymentMethodEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				PaymentMethodEntity _PaymentMethodEntity = new PaymentMethodEntity(PayId);
				if (adapter.FetchEntity(_PaymentMethodEntity))
				{
					toReturn = _PaymentMethodEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PaymentMethodCollection = new EntityCollection(new PaymentMethodEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PaymentMethodCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<PaymentMethodEntity>
		public EntityCollection<PaymentMethodEntity> SelectAllLST()
		{
			EntityCollection<PaymentMethodEntity> _PaymentMethodCollection = new EntityCollection<PaymentMethodEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PaymentMethodCollection, null, 0, null);
			}
			return _PaymentMethodCollection;
		}
		
		// Return EntityCollection<PaymentMethodEntity>
		public EntityCollection<PaymentMethodEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<PaymentMethodEntity> _PaymentMethodCollection = new EntityCollection<PaymentMethodEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PaymentMethodCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _PaymentMethodCollection;
		}


		
		// Return EntityCollection<PaymentMethodEntity>
		public EntityCollection<PaymentMethodEntity> SelectByPayIdLST(string PayId)
		{
			EntityCollection<PaymentMethodEntity> _PaymentMethodCollection = new EntityCollection<PaymentMethodEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentMethodFields.PayId == PayId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PaymentMethodCollection, filter, 0, null);
			}
			return _PaymentMethodCollection;
		}
		
		// Return EntityCollection<PaymentMethodEntity>
		public EntityCollection<PaymentMethodEntity> SelectByPayIdLST_Paged(string PayId, int PageNumber, int PageSize)
		{
			EntityCollection<PaymentMethodEntity> _PaymentMethodCollection = new EntityCollection<PaymentMethodEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentMethodFields.PayId == PayId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PaymentMethodCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PaymentMethodCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPayIdRDT(string PayId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PaymentMethodCollection = new EntityCollection(new PaymentMethodEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentMethodFields.PayId == PayId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PaymentMethodCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPayIdRDT_Paged(string PayId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PaymentMethodCollection = new EntityCollection(new PaymentMethodEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentMethodFields.PayId == PayId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PaymentMethodCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PaymentMethodEntity>
		public EntityCollection<PaymentMethodEntity> SelectByPayNameLST(string PayName)
		{
			EntityCollection<PaymentMethodEntity> _PaymentMethodCollection = new EntityCollection<PaymentMethodEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentMethodFields.PayName == PayName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PaymentMethodCollection, filter, 0, null);
			}
			return _PaymentMethodCollection;
		}
		
		// Return EntityCollection<PaymentMethodEntity>
		public EntityCollection<PaymentMethodEntity> SelectByPayNameLST_Paged(string PayName, int PageNumber, int PageSize)
		{
			EntityCollection<PaymentMethodEntity> _PaymentMethodCollection = new EntityCollection<PaymentMethodEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentMethodFields.PayName == PayName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PaymentMethodCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PaymentMethodCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPayNameRDT(string PayName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PaymentMethodCollection = new EntityCollection(new PaymentMethodEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentMethodFields.PayName == PayName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PaymentMethodCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPayNameRDT_Paged(string PayName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PaymentMethodCollection = new EntityCollection(new PaymentMethodEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentMethodFields.PayName == PayName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PaymentMethodCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PaymentMethodEntity>
		public EntityCollection<PaymentMethodEntity> SelectByIsEnableLST(bool IsEnable)
		{
			EntityCollection<PaymentMethodEntity> _PaymentMethodCollection = new EntityCollection<PaymentMethodEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentMethodFields.IsEnable == IsEnable);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PaymentMethodCollection, filter, 0, null);
			}
			return _PaymentMethodCollection;
		}
		
		// Return EntityCollection<PaymentMethodEntity>
		public EntityCollection<PaymentMethodEntity> SelectByIsEnableLST_Paged(bool IsEnable, int PageNumber, int PageSize)
		{
			EntityCollection<PaymentMethodEntity> _PaymentMethodCollection = new EntityCollection<PaymentMethodEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentMethodFields.IsEnable == IsEnable);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PaymentMethodCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PaymentMethodCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIsEnableRDT(bool IsEnable)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PaymentMethodCollection = new EntityCollection(new PaymentMethodEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentMethodFields.IsEnable == IsEnable);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PaymentMethodCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIsEnableRDT_Paged(bool IsEnable, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PaymentMethodCollection = new EntityCollection(new PaymentMethodEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentMethodFields.IsEnable == IsEnable);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PaymentMethodCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PaymentMethodEntity>
		public EntityCollection<PaymentMethodEntity> SelectByIsVisibleLST(bool IsVisible)
		{
			EntityCollection<PaymentMethodEntity> _PaymentMethodCollection = new EntityCollection<PaymentMethodEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentMethodFields.IsVisible == IsVisible);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PaymentMethodCollection, filter, 0, null);
			}
			return _PaymentMethodCollection;
		}
		
		// Return EntityCollection<PaymentMethodEntity>
		public EntityCollection<PaymentMethodEntity> SelectByIsVisibleLST_Paged(bool IsVisible, int PageNumber, int PageSize)
		{
			EntityCollection<PaymentMethodEntity> _PaymentMethodCollection = new EntityCollection<PaymentMethodEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentMethodFields.IsVisible == IsVisible);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PaymentMethodCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PaymentMethodCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIsVisibleRDT(bool IsVisible)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PaymentMethodCollection = new EntityCollection(new PaymentMethodEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentMethodFields.IsVisible == IsVisible);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PaymentMethodCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIsVisibleRDT_Paged(bool IsVisible, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PaymentMethodCollection = new EntityCollection(new PaymentMethodEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentMethodFields.IsVisible == IsVisible);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PaymentMethodCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PaymentMethodEntity>
		public EntityCollection<PaymentMethodEntity> SelectByLinkLST(string Link)
		{
			EntityCollection<PaymentMethodEntity> _PaymentMethodCollection = new EntityCollection<PaymentMethodEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentMethodFields.Link == Link);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PaymentMethodCollection, filter, 0, null);
			}
			return _PaymentMethodCollection;
		}
		
		// Return EntityCollection<PaymentMethodEntity>
		public EntityCollection<PaymentMethodEntity> SelectByLinkLST_Paged(string Link, int PageNumber, int PageSize)
		{
			EntityCollection<PaymentMethodEntity> _PaymentMethodCollection = new EntityCollection<PaymentMethodEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentMethodFields.Link == Link);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PaymentMethodCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PaymentMethodCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLinkRDT(string Link)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PaymentMethodCollection = new EntityCollection(new PaymentMethodEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentMethodFields.Link == Link);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PaymentMethodCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLinkRDT_Paged(string Link, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PaymentMethodCollection = new EntityCollection(new PaymentMethodEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PaymentMethodFields.Link == Link);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PaymentMethodCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
