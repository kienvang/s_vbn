




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.TransactionManagerBase
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
	public class TransactionManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public TransactionManagerBase()
		{
			// Nothing for now.
		}
		
		public TransactionEntity Insert(TransactionEntity _TransactionEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_TransactionEntity, true);
			}
			return _TransactionEntity;
		}

		
		public TransactionEntity Insert(Guid Id, string PayId, string TransType, string ProductType, string UrlCheckOut, decimal Price, string OrderCode, string ClientIp, string UrlReturn, string MachineId, string UrlReturn2, bool Status, DateTime CreatedDate, string CreatedBy, DateTime UpdatedDate, string UpdatedBy)
		{
			TransactionEntity _TransactionEntity = new TransactionEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_TransactionEntity.Id = Id;
				_TransactionEntity.PayId = PayId;
				_TransactionEntity.TransType = TransType;
				_TransactionEntity.ProductType = ProductType;
				_TransactionEntity.UrlCheckOut = UrlCheckOut;
				_TransactionEntity.Price = Price;
				_TransactionEntity.OrderCode = OrderCode;
				_TransactionEntity.ClientIp = ClientIp;
				_TransactionEntity.UrlReturn = UrlReturn;
				_TransactionEntity.MachineId = MachineId;
				_TransactionEntity.UrlReturn2 = UrlReturn2;
				_TransactionEntity.Status = Status;
				_TransactionEntity.CreatedDate = CreatedDate;
				_TransactionEntity.CreatedBy = CreatedBy;
				_TransactionEntity.UpdatedDate = UpdatedDate;
				_TransactionEntity.UpdatedBy = UpdatedBy;
				adapter.SaveEntity(_TransactionEntity, true);
			}
			return _TransactionEntity;
		}

		public TransactionEntity Insert(string PayId, string TransType, string ProductType, string UrlCheckOut, decimal Price, string OrderCode, string ClientIp, string UrlReturn, string MachineId, string UrlReturn2, bool Status, DateTime CreatedDate, string CreatedBy, DateTime UpdatedDate, string UpdatedBy)
		{
			TransactionEntity _TransactionEntity = new TransactionEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_TransactionEntity.PayId = PayId;
				_TransactionEntity.TransType = TransType;
				_TransactionEntity.ProductType = ProductType;
				_TransactionEntity.UrlCheckOut = UrlCheckOut;
				_TransactionEntity.Price = Price;
				_TransactionEntity.OrderCode = OrderCode;
				_TransactionEntity.ClientIp = ClientIp;
				_TransactionEntity.UrlReturn = UrlReturn;
				_TransactionEntity.MachineId = MachineId;
				_TransactionEntity.UrlReturn2 = UrlReturn2;
				_TransactionEntity.Status = Status;
				_TransactionEntity.CreatedDate = CreatedDate;
				_TransactionEntity.CreatedBy = CreatedBy;
				_TransactionEntity.UpdatedDate = UpdatedDate;
				_TransactionEntity.UpdatedBy = UpdatedBy;
				adapter.SaveEntity(_TransactionEntity, true);
			}
			return _TransactionEntity;
		}

		public bool Update(TransactionEntity _TransactionEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(TransactionFields.Id == _TransactionEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_TransactionEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(TransactionEntity _TransactionEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_TransactionEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string PayId, string TransType, string ProductType, string UrlCheckOut, decimal Price, string OrderCode, string ClientIp, string UrlReturn, string MachineId, string UrlReturn2, bool Status, DateTime CreatedDate, string CreatedBy, DateTime UpdatedDate, string UpdatedBy)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				TransactionEntity _TransactionEntity = new TransactionEntity(Id);
				if (adapter.FetchEntity(_TransactionEntity))
				{
				
					_TransactionEntity.PayId = PayId;
					_TransactionEntity.TransType = TransType;
					_TransactionEntity.ProductType = ProductType;
					_TransactionEntity.UrlCheckOut = UrlCheckOut;
					_TransactionEntity.Price = Price;
					_TransactionEntity.OrderCode = OrderCode;
					_TransactionEntity.ClientIp = ClientIp;
					_TransactionEntity.UrlReturn = UrlReturn;
					_TransactionEntity.MachineId = MachineId;
					_TransactionEntity.UrlReturn2 = UrlReturn2;
					_TransactionEntity.Status = Status;
					_TransactionEntity.CreatedDate = CreatedDate;
					_TransactionEntity.CreatedBy = CreatedBy;
					_TransactionEntity.UpdatedDate = UpdatedDate;
					_TransactionEntity.UpdatedBy = UpdatedBy;
					adapter.SaveEntity(_TransactionEntity, true);
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
				TransactionEntity _TransactionEntity = new TransactionEntity(Id);
				if (adapter.FetchEntity(_TransactionEntity))
				{
					adapter.DeleteEntity(_TransactionEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("TransactionEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TransactionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPayId(string PayId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.PayId == PayId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TransactionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTransType(string TransType)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.TransType == TransType);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TransactionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByProductType(string ProductType)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.ProductType == ProductType);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TransactionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByUrlCheckOut(string UrlCheckOut)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.UrlCheckOut == UrlCheckOut);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TransactionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPrice(decimal Price)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.Price == Price);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TransactionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByOrderCode(string OrderCode)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.OrderCode == OrderCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TransactionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByClientIp(string ClientIp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.ClientIp == ClientIp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TransactionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByUrlReturn(string UrlReturn)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.UrlReturn == UrlReturn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TransactionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMachineId(string MachineId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.MachineId == MachineId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TransactionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByUrlReturn2(string UrlReturn2)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.UrlReturn2 == UrlReturn2);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TransactionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByStatus(bool Status)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.Status == Status);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TransactionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCreatedDate(DateTime CreatedDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TransactionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCreatedBy(string CreatedBy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TransactionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByUpdatedDate(DateTime UpdatedDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TransactionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByUpdatedBy(string UpdatedBy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TransactionEntity", filter);
			}
			return toReturn;
		}
		

		
		public TransactionEntity SelectOne(Guid Id)
		{
			TransactionEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				TransactionEntity _TransactionEntity = new TransactionEntity(Id);
				if (adapter.FetchEntity(_TransactionEntity))
				{
					toReturn = _TransactionEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TransactionCollection = new EntityCollection(new TransactionEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TransactionCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<TransactionEntity>
		public EntityCollection<TransactionEntity> SelectAllLST()
		{
			EntityCollection<TransactionEntity> _TransactionCollection = new EntityCollection<TransactionEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TransactionCollection, null, 0, null);
			}
			return _TransactionCollection;
		}
		
		// Return EntityCollection<TransactionEntity>
		public EntityCollection<TransactionEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<TransactionEntity> _TransactionCollection = new EntityCollection<TransactionEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TransactionCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _TransactionCollection;
		}


		
		// Return EntityCollection<TransactionEntity>
		public EntityCollection<TransactionEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<TransactionEntity> _TransactionCollection = new EntityCollection<TransactionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TransactionCollection, filter, 0, null);
			}
			return _TransactionCollection;
		}
		
		// Return EntityCollection<TransactionEntity>
		public EntityCollection<TransactionEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<TransactionEntity> _TransactionCollection = new EntityCollection<TransactionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TransactionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TransactionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TransactionCollection = new EntityCollection(new TransactionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TransactionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TransactionCollection = new EntityCollection(new TransactionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TransactionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TransactionEntity>
		public EntityCollection<TransactionEntity> SelectByPayIdLST(string PayId)
		{
			EntityCollection<TransactionEntity> _TransactionCollection = new EntityCollection<TransactionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.PayId == PayId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TransactionCollection, filter, 0, null);
			}
			return _TransactionCollection;
		}
		
		// Return EntityCollection<TransactionEntity>
		public EntityCollection<TransactionEntity> SelectByPayIdLST_Paged(string PayId, int PageNumber, int PageSize)
		{
			EntityCollection<TransactionEntity> _TransactionCollection = new EntityCollection<TransactionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.PayId == PayId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TransactionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TransactionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPayIdRDT(string PayId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TransactionCollection = new EntityCollection(new TransactionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.PayId == PayId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TransactionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPayIdRDT_Paged(string PayId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TransactionCollection = new EntityCollection(new TransactionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.PayId == PayId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TransactionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TransactionEntity>
		public EntityCollection<TransactionEntity> SelectByTransTypeLST(string TransType)
		{
			EntityCollection<TransactionEntity> _TransactionCollection = new EntityCollection<TransactionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.TransType == TransType);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TransactionCollection, filter, 0, null);
			}
			return _TransactionCollection;
		}
		
		// Return EntityCollection<TransactionEntity>
		public EntityCollection<TransactionEntity> SelectByTransTypeLST_Paged(string TransType, int PageNumber, int PageSize)
		{
			EntityCollection<TransactionEntity> _TransactionCollection = new EntityCollection<TransactionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.TransType == TransType);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TransactionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TransactionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTransTypeRDT(string TransType)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TransactionCollection = new EntityCollection(new TransactionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.TransType == TransType);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TransactionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTransTypeRDT_Paged(string TransType, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TransactionCollection = new EntityCollection(new TransactionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.TransType == TransType);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TransactionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TransactionEntity>
		public EntityCollection<TransactionEntity> SelectByProductTypeLST(string ProductType)
		{
			EntityCollection<TransactionEntity> _TransactionCollection = new EntityCollection<TransactionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.ProductType == ProductType);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TransactionCollection, filter, 0, null);
			}
			return _TransactionCollection;
		}
		
		// Return EntityCollection<TransactionEntity>
		public EntityCollection<TransactionEntity> SelectByProductTypeLST_Paged(string ProductType, int PageNumber, int PageSize)
		{
			EntityCollection<TransactionEntity> _TransactionCollection = new EntityCollection<TransactionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.ProductType == ProductType);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TransactionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TransactionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByProductTypeRDT(string ProductType)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TransactionCollection = new EntityCollection(new TransactionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.ProductType == ProductType);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TransactionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByProductTypeRDT_Paged(string ProductType, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TransactionCollection = new EntityCollection(new TransactionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.ProductType == ProductType);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TransactionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TransactionEntity>
		public EntityCollection<TransactionEntity> SelectByUrlCheckOutLST(string UrlCheckOut)
		{
			EntityCollection<TransactionEntity> _TransactionCollection = new EntityCollection<TransactionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.UrlCheckOut == UrlCheckOut);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TransactionCollection, filter, 0, null);
			}
			return _TransactionCollection;
		}
		
		// Return EntityCollection<TransactionEntity>
		public EntityCollection<TransactionEntity> SelectByUrlCheckOutLST_Paged(string UrlCheckOut, int PageNumber, int PageSize)
		{
			EntityCollection<TransactionEntity> _TransactionCollection = new EntityCollection<TransactionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.UrlCheckOut == UrlCheckOut);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TransactionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TransactionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUrlCheckOutRDT(string UrlCheckOut)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TransactionCollection = new EntityCollection(new TransactionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.UrlCheckOut == UrlCheckOut);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TransactionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUrlCheckOutRDT_Paged(string UrlCheckOut, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TransactionCollection = new EntityCollection(new TransactionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.UrlCheckOut == UrlCheckOut);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TransactionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TransactionEntity>
		public EntityCollection<TransactionEntity> SelectByPriceLST(decimal Price)
		{
			EntityCollection<TransactionEntity> _TransactionCollection = new EntityCollection<TransactionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.Price == Price);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TransactionCollection, filter, 0, null);
			}
			return _TransactionCollection;
		}
		
		// Return EntityCollection<TransactionEntity>
		public EntityCollection<TransactionEntity> SelectByPriceLST_Paged(decimal Price, int PageNumber, int PageSize)
		{
			EntityCollection<TransactionEntity> _TransactionCollection = new EntityCollection<TransactionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.Price == Price);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TransactionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TransactionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPriceRDT(decimal Price)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TransactionCollection = new EntityCollection(new TransactionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.Price == Price);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TransactionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPriceRDT_Paged(decimal Price, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TransactionCollection = new EntityCollection(new TransactionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.Price == Price);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TransactionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TransactionEntity>
		public EntityCollection<TransactionEntity> SelectByOrderCodeLST(string OrderCode)
		{
			EntityCollection<TransactionEntity> _TransactionCollection = new EntityCollection<TransactionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.OrderCode == OrderCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TransactionCollection, filter, 0, null);
			}
			return _TransactionCollection;
		}
		
		// Return EntityCollection<TransactionEntity>
		public EntityCollection<TransactionEntity> SelectByOrderCodeLST_Paged(string OrderCode, int PageNumber, int PageSize)
		{
			EntityCollection<TransactionEntity> _TransactionCollection = new EntityCollection<TransactionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.OrderCode == OrderCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TransactionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TransactionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByOrderCodeRDT(string OrderCode)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TransactionCollection = new EntityCollection(new TransactionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.OrderCode == OrderCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TransactionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByOrderCodeRDT_Paged(string OrderCode, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TransactionCollection = new EntityCollection(new TransactionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.OrderCode == OrderCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TransactionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TransactionEntity>
		public EntityCollection<TransactionEntity> SelectByClientIpLST(string ClientIp)
		{
			EntityCollection<TransactionEntity> _TransactionCollection = new EntityCollection<TransactionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.ClientIp == ClientIp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TransactionCollection, filter, 0, null);
			}
			return _TransactionCollection;
		}
		
		// Return EntityCollection<TransactionEntity>
		public EntityCollection<TransactionEntity> SelectByClientIpLST_Paged(string ClientIp, int PageNumber, int PageSize)
		{
			EntityCollection<TransactionEntity> _TransactionCollection = new EntityCollection<TransactionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.ClientIp == ClientIp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TransactionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TransactionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByClientIpRDT(string ClientIp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TransactionCollection = new EntityCollection(new TransactionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.ClientIp == ClientIp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TransactionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByClientIpRDT_Paged(string ClientIp, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TransactionCollection = new EntityCollection(new TransactionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.ClientIp == ClientIp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TransactionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TransactionEntity>
		public EntityCollection<TransactionEntity> SelectByUrlReturnLST(string UrlReturn)
		{
			EntityCollection<TransactionEntity> _TransactionCollection = new EntityCollection<TransactionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.UrlReturn == UrlReturn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TransactionCollection, filter, 0, null);
			}
			return _TransactionCollection;
		}
		
		// Return EntityCollection<TransactionEntity>
		public EntityCollection<TransactionEntity> SelectByUrlReturnLST_Paged(string UrlReturn, int PageNumber, int PageSize)
		{
			EntityCollection<TransactionEntity> _TransactionCollection = new EntityCollection<TransactionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.UrlReturn == UrlReturn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TransactionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TransactionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUrlReturnRDT(string UrlReturn)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TransactionCollection = new EntityCollection(new TransactionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.UrlReturn == UrlReturn);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TransactionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUrlReturnRDT_Paged(string UrlReturn, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TransactionCollection = new EntityCollection(new TransactionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.UrlReturn == UrlReturn);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TransactionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TransactionEntity>
		public EntityCollection<TransactionEntity> SelectByMachineIdLST(string MachineId)
		{
			EntityCollection<TransactionEntity> _TransactionCollection = new EntityCollection<TransactionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.MachineId == MachineId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TransactionCollection, filter, 0, null);
			}
			return _TransactionCollection;
		}
		
		// Return EntityCollection<TransactionEntity>
		public EntityCollection<TransactionEntity> SelectByMachineIdLST_Paged(string MachineId, int PageNumber, int PageSize)
		{
			EntityCollection<TransactionEntity> _TransactionCollection = new EntityCollection<TransactionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.MachineId == MachineId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TransactionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TransactionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMachineIdRDT(string MachineId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TransactionCollection = new EntityCollection(new TransactionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.MachineId == MachineId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TransactionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMachineIdRDT_Paged(string MachineId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TransactionCollection = new EntityCollection(new TransactionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.MachineId == MachineId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TransactionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TransactionEntity>
		public EntityCollection<TransactionEntity> SelectByUrlReturn2LST(string UrlReturn2)
		{
			EntityCollection<TransactionEntity> _TransactionCollection = new EntityCollection<TransactionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.UrlReturn2 == UrlReturn2);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TransactionCollection, filter, 0, null);
			}
			return _TransactionCollection;
		}
		
		// Return EntityCollection<TransactionEntity>
		public EntityCollection<TransactionEntity> SelectByUrlReturn2LST_Paged(string UrlReturn2, int PageNumber, int PageSize)
		{
			EntityCollection<TransactionEntity> _TransactionCollection = new EntityCollection<TransactionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.UrlReturn2 == UrlReturn2);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TransactionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TransactionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUrlReturn2RDT(string UrlReturn2)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TransactionCollection = new EntityCollection(new TransactionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.UrlReturn2 == UrlReturn2);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TransactionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUrlReturn2RDT_Paged(string UrlReturn2, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TransactionCollection = new EntityCollection(new TransactionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.UrlReturn2 == UrlReturn2);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TransactionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TransactionEntity>
		public EntityCollection<TransactionEntity> SelectByStatusLST(bool Status)
		{
			EntityCollection<TransactionEntity> _TransactionCollection = new EntityCollection<TransactionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.Status == Status);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TransactionCollection, filter, 0, null);
			}
			return _TransactionCollection;
		}
		
		// Return EntityCollection<TransactionEntity>
		public EntityCollection<TransactionEntity> SelectByStatusLST_Paged(bool Status, int PageNumber, int PageSize)
		{
			EntityCollection<TransactionEntity> _TransactionCollection = new EntityCollection<TransactionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.Status == Status);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TransactionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TransactionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByStatusRDT(bool Status)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TransactionCollection = new EntityCollection(new TransactionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.Status == Status);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TransactionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByStatusRDT_Paged(bool Status, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TransactionCollection = new EntityCollection(new TransactionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.Status == Status);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TransactionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TransactionEntity>
		public EntityCollection<TransactionEntity> SelectByCreatedDateLST(DateTime CreatedDate)
		{
			EntityCollection<TransactionEntity> _TransactionCollection = new EntityCollection<TransactionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TransactionCollection, filter, 0, null);
			}
			return _TransactionCollection;
		}
		
		// Return EntityCollection<TransactionEntity>
		public EntityCollection<TransactionEntity> SelectByCreatedDateLST_Paged(DateTime CreatedDate, int PageNumber, int PageSize)
		{
			EntityCollection<TransactionEntity> _TransactionCollection = new EntityCollection<TransactionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TransactionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TransactionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedDateRDT(DateTime CreatedDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TransactionCollection = new EntityCollection(new TransactionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TransactionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedDateRDT_Paged(DateTime CreatedDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TransactionCollection = new EntityCollection(new TransactionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TransactionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TransactionEntity>
		public EntityCollection<TransactionEntity> SelectByCreatedByLST(string CreatedBy)
		{
			EntityCollection<TransactionEntity> _TransactionCollection = new EntityCollection<TransactionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TransactionCollection, filter, 0, null);
			}
			return _TransactionCollection;
		}
		
		// Return EntityCollection<TransactionEntity>
		public EntityCollection<TransactionEntity> SelectByCreatedByLST_Paged(string CreatedBy, int PageNumber, int PageSize)
		{
			EntityCollection<TransactionEntity> _TransactionCollection = new EntityCollection<TransactionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TransactionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TransactionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedByRDT(string CreatedBy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TransactionCollection = new EntityCollection(new TransactionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TransactionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedByRDT_Paged(string CreatedBy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TransactionCollection = new EntityCollection(new TransactionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TransactionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TransactionEntity>
		public EntityCollection<TransactionEntity> SelectByUpdatedDateLST(DateTime UpdatedDate)
		{
			EntityCollection<TransactionEntity> _TransactionCollection = new EntityCollection<TransactionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TransactionCollection, filter, 0, null);
			}
			return _TransactionCollection;
		}
		
		// Return EntityCollection<TransactionEntity>
		public EntityCollection<TransactionEntity> SelectByUpdatedDateLST_Paged(DateTime UpdatedDate, int PageNumber, int PageSize)
		{
			EntityCollection<TransactionEntity> _TransactionCollection = new EntityCollection<TransactionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TransactionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TransactionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedDateRDT(DateTime UpdatedDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TransactionCollection = new EntityCollection(new TransactionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TransactionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedDateRDT_Paged(DateTime UpdatedDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TransactionCollection = new EntityCollection(new TransactionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TransactionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TransactionEntity>
		public EntityCollection<TransactionEntity> SelectByUpdatedByLST(string UpdatedBy)
		{
			EntityCollection<TransactionEntity> _TransactionCollection = new EntityCollection<TransactionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TransactionCollection, filter, 0, null);
			}
			return _TransactionCollection;
		}
		
		// Return EntityCollection<TransactionEntity>
		public EntityCollection<TransactionEntity> SelectByUpdatedByLST_Paged(string UpdatedBy, int PageNumber, int PageSize)
		{
			EntityCollection<TransactionEntity> _TransactionCollection = new EntityCollection<TransactionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TransactionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TransactionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedByRDT(string UpdatedBy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TransactionCollection = new EntityCollection(new TransactionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TransactionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedByRDT_Paged(string UpdatedBy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TransactionCollection = new EntityCollection(new TransactionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TransactionFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TransactionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
