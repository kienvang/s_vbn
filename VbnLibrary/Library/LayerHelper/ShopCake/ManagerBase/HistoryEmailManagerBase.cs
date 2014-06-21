




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.HistoryEmailManagerBase
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
	public class HistoryEmailManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public HistoryEmailManagerBase()
		{
			// Nothing for now.
		}
		
		public HistoryEmailEntity Insert(HistoryEmailEntity _HistoryEmailEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_HistoryEmailEntity, true);
			}
			return _HistoryEmailEntity;
		}

		
		public HistoryEmailEntity Insert(Guid Id, string OrderCode, string EmailTo, string EmailFrom, string EmailCc, string EmailBcc, string Subject, string Body, DateTime ReceiveDated, string SendBy)
		{
			HistoryEmailEntity _HistoryEmailEntity = new HistoryEmailEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_HistoryEmailEntity.Id = Id;
				_HistoryEmailEntity.OrderCode = OrderCode;
				_HistoryEmailEntity.EmailTo = EmailTo;
				_HistoryEmailEntity.EmailFrom = EmailFrom;
				_HistoryEmailEntity.EmailCc = EmailCc;
				_HistoryEmailEntity.EmailBcc = EmailBcc;
				_HistoryEmailEntity.Subject = Subject;
				_HistoryEmailEntity.Body = Body;
				_HistoryEmailEntity.ReceiveDated = ReceiveDated;
				_HistoryEmailEntity.SendBy = SendBy;
				adapter.SaveEntity(_HistoryEmailEntity, true);
			}
			return _HistoryEmailEntity;
		}

		public HistoryEmailEntity Insert(string OrderCode, string EmailTo, string EmailFrom, string EmailCc, string EmailBcc, string Subject, string Body, DateTime ReceiveDated, string SendBy)
		{
			HistoryEmailEntity _HistoryEmailEntity = new HistoryEmailEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_HistoryEmailEntity.OrderCode = OrderCode;
				_HistoryEmailEntity.EmailTo = EmailTo;
				_HistoryEmailEntity.EmailFrom = EmailFrom;
				_HistoryEmailEntity.EmailCc = EmailCc;
				_HistoryEmailEntity.EmailBcc = EmailBcc;
				_HistoryEmailEntity.Subject = Subject;
				_HistoryEmailEntity.Body = Body;
				_HistoryEmailEntity.ReceiveDated = ReceiveDated;
				_HistoryEmailEntity.SendBy = SendBy;
				adapter.SaveEntity(_HistoryEmailEntity, true);
			}
			return _HistoryEmailEntity;
		}

		public bool Update(HistoryEmailEntity _HistoryEmailEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(HistoryEmailFields.Id == _HistoryEmailEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_HistoryEmailEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(HistoryEmailEntity _HistoryEmailEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_HistoryEmailEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string OrderCode, string EmailTo, string EmailFrom, string EmailCc, string EmailBcc, string Subject, string Body, DateTime ReceiveDated, string SendBy)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				HistoryEmailEntity _HistoryEmailEntity = new HistoryEmailEntity(Id);
				if (adapter.FetchEntity(_HistoryEmailEntity))
				{
				
					_HistoryEmailEntity.OrderCode = OrderCode;
					_HistoryEmailEntity.EmailTo = EmailTo;
					_HistoryEmailEntity.EmailFrom = EmailFrom;
					_HistoryEmailEntity.EmailCc = EmailCc;
					_HistoryEmailEntity.EmailBcc = EmailBcc;
					_HistoryEmailEntity.Subject = Subject;
					_HistoryEmailEntity.Body = Body;
					_HistoryEmailEntity.ReceiveDated = ReceiveDated;
					_HistoryEmailEntity.SendBy = SendBy;
					adapter.SaveEntity(_HistoryEmailEntity, true);
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
				HistoryEmailEntity _HistoryEmailEntity = new HistoryEmailEntity(Id);
				if (adapter.FetchEntity(_HistoryEmailEntity))
				{
					adapter.DeleteEntity(_HistoryEmailEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("HistoryEmailEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HistoryEmailEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByOrderCode(string OrderCode)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.OrderCode == OrderCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HistoryEmailEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByEmailTo(string EmailTo)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.EmailTo == EmailTo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HistoryEmailEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByEmailFrom(string EmailFrom)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.EmailFrom == EmailFrom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HistoryEmailEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByEmailCc(string EmailCc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.EmailCc == EmailCc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HistoryEmailEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByEmailBcc(string EmailBcc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.EmailBcc == EmailBcc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HistoryEmailEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySubject(string Subject)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.Subject == Subject);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HistoryEmailEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByBody(string Body)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.Body == Body);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HistoryEmailEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByReceiveDated(DateTime ReceiveDated)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.ReceiveDated == ReceiveDated);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HistoryEmailEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySendBy(string SendBy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.SendBy == SendBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HistoryEmailEntity", filter);
			}
			return toReturn;
		}
		

		
		public HistoryEmailEntity SelectOne(Guid Id)
		{
			HistoryEmailEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				HistoryEmailEntity _HistoryEmailEntity = new HistoryEmailEntity(Id);
				if (adapter.FetchEntity(_HistoryEmailEntity))
				{
					toReturn = _HistoryEmailEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HistoryEmailCollection = new EntityCollection(new HistoryEmailEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HistoryEmailCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<HistoryEmailEntity>
		public EntityCollection<HistoryEmailEntity> SelectAllLST()
		{
			EntityCollection<HistoryEmailEntity> _HistoryEmailCollection = new EntityCollection<HistoryEmailEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HistoryEmailCollection, null, 0, null);
			}
			return _HistoryEmailCollection;
		}
		
		// Return EntityCollection<HistoryEmailEntity>
		public EntityCollection<HistoryEmailEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<HistoryEmailEntity> _HistoryEmailCollection = new EntityCollection<HistoryEmailEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HistoryEmailCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _HistoryEmailCollection;
		}


		
		// Return EntityCollection<HistoryEmailEntity>
		public EntityCollection<HistoryEmailEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<HistoryEmailEntity> _HistoryEmailCollection = new EntityCollection<HistoryEmailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HistoryEmailCollection, filter, 0, null);
			}
			return _HistoryEmailCollection;
		}
		
		// Return EntityCollection<HistoryEmailEntity>
		public EntityCollection<HistoryEmailEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<HistoryEmailEntity> _HistoryEmailCollection = new EntityCollection<HistoryEmailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HistoryEmailCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HistoryEmailCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HistoryEmailCollection = new EntityCollection(new HistoryEmailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HistoryEmailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HistoryEmailCollection = new EntityCollection(new HistoryEmailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HistoryEmailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HistoryEmailEntity>
		public EntityCollection<HistoryEmailEntity> SelectByOrderCodeLST(string OrderCode)
		{
			EntityCollection<HistoryEmailEntity> _HistoryEmailCollection = new EntityCollection<HistoryEmailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.OrderCode == OrderCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HistoryEmailCollection, filter, 0, null);
			}
			return _HistoryEmailCollection;
		}
		
		// Return EntityCollection<HistoryEmailEntity>
		public EntityCollection<HistoryEmailEntity> SelectByOrderCodeLST_Paged(string OrderCode, int PageNumber, int PageSize)
		{
			EntityCollection<HistoryEmailEntity> _HistoryEmailCollection = new EntityCollection<HistoryEmailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.OrderCode == OrderCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HistoryEmailCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HistoryEmailCollection;
		}
		
		// Return DataTable
		public DataTable SelectByOrderCodeRDT(string OrderCode)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HistoryEmailCollection = new EntityCollection(new HistoryEmailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.OrderCode == OrderCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HistoryEmailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByOrderCodeRDT_Paged(string OrderCode, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HistoryEmailCollection = new EntityCollection(new HistoryEmailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.OrderCode == OrderCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HistoryEmailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HistoryEmailEntity>
		public EntityCollection<HistoryEmailEntity> SelectByEmailToLST(string EmailTo)
		{
			EntityCollection<HistoryEmailEntity> _HistoryEmailCollection = new EntityCollection<HistoryEmailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.EmailTo == EmailTo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HistoryEmailCollection, filter, 0, null);
			}
			return _HistoryEmailCollection;
		}
		
		// Return EntityCollection<HistoryEmailEntity>
		public EntityCollection<HistoryEmailEntity> SelectByEmailToLST_Paged(string EmailTo, int PageNumber, int PageSize)
		{
			EntityCollection<HistoryEmailEntity> _HistoryEmailCollection = new EntityCollection<HistoryEmailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.EmailTo == EmailTo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HistoryEmailCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HistoryEmailCollection;
		}
		
		// Return DataTable
		public DataTable SelectByEmailToRDT(string EmailTo)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HistoryEmailCollection = new EntityCollection(new HistoryEmailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.EmailTo == EmailTo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HistoryEmailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByEmailToRDT_Paged(string EmailTo, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HistoryEmailCollection = new EntityCollection(new HistoryEmailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.EmailTo == EmailTo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HistoryEmailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HistoryEmailEntity>
		public EntityCollection<HistoryEmailEntity> SelectByEmailFromLST(string EmailFrom)
		{
			EntityCollection<HistoryEmailEntity> _HistoryEmailCollection = new EntityCollection<HistoryEmailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.EmailFrom == EmailFrom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HistoryEmailCollection, filter, 0, null);
			}
			return _HistoryEmailCollection;
		}
		
		// Return EntityCollection<HistoryEmailEntity>
		public EntityCollection<HistoryEmailEntity> SelectByEmailFromLST_Paged(string EmailFrom, int PageNumber, int PageSize)
		{
			EntityCollection<HistoryEmailEntity> _HistoryEmailCollection = new EntityCollection<HistoryEmailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.EmailFrom == EmailFrom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HistoryEmailCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HistoryEmailCollection;
		}
		
		// Return DataTable
		public DataTable SelectByEmailFromRDT(string EmailFrom)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HistoryEmailCollection = new EntityCollection(new HistoryEmailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.EmailFrom == EmailFrom);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HistoryEmailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByEmailFromRDT_Paged(string EmailFrom, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HistoryEmailCollection = new EntityCollection(new HistoryEmailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.EmailFrom == EmailFrom);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HistoryEmailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HistoryEmailEntity>
		public EntityCollection<HistoryEmailEntity> SelectByEmailCcLST(string EmailCc)
		{
			EntityCollection<HistoryEmailEntity> _HistoryEmailCollection = new EntityCollection<HistoryEmailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.EmailCc == EmailCc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HistoryEmailCollection, filter, 0, null);
			}
			return _HistoryEmailCollection;
		}
		
		// Return EntityCollection<HistoryEmailEntity>
		public EntityCollection<HistoryEmailEntity> SelectByEmailCcLST_Paged(string EmailCc, int PageNumber, int PageSize)
		{
			EntityCollection<HistoryEmailEntity> _HistoryEmailCollection = new EntityCollection<HistoryEmailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.EmailCc == EmailCc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HistoryEmailCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HistoryEmailCollection;
		}
		
		// Return DataTable
		public DataTable SelectByEmailCcRDT(string EmailCc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HistoryEmailCollection = new EntityCollection(new HistoryEmailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.EmailCc == EmailCc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HistoryEmailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByEmailCcRDT_Paged(string EmailCc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HistoryEmailCollection = new EntityCollection(new HistoryEmailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.EmailCc == EmailCc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HistoryEmailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HistoryEmailEntity>
		public EntityCollection<HistoryEmailEntity> SelectByEmailBccLST(string EmailBcc)
		{
			EntityCollection<HistoryEmailEntity> _HistoryEmailCollection = new EntityCollection<HistoryEmailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.EmailBcc == EmailBcc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HistoryEmailCollection, filter, 0, null);
			}
			return _HistoryEmailCollection;
		}
		
		// Return EntityCollection<HistoryEmailEntity>
		public EntityCollection<HistoryEmailEntity> SelectByEmailBccLST_Paged(string EmailBcc, int PageNumber, int PageSize)
		{
			EntityCollection<HistoryEmailEntity> _HistoryEmailCollection = new EntityCollection<HistoryEmailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.EmailBcc == EmailBcc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HistoryEmailCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HistoryEmailCollection;
		}
		
		// Return DataTable
		public DataTable SelectByEmailBccRDT(string EmailBcc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HistoryEmailCollection = new EntityCollection(new HistoryEmailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.EmailBcc == EmailBcc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HistoryEmailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByEmailBccRDT_Paged(string EmailBcc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HistoryEmailCollection = new EntityCollection(new HistoryEmailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.EmailBcc == EmailBcc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HistoryEmailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HistoryEmailEntity>
		public EntityCollection<HistoryEmailEntity> SelectBySubjectLST(string Subject)
		{
			EntityCollection<HistoryEmailEntity> _HistoryEmailCollection = new EntityCollection<HistoryEmailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.Subject == Subject);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HistoryEmailCollection, filter, 0, null);
			}
			return _HistoryEmailCollection;
		}
		
		// Return EntityCollection<HistoryEmailEntity>
		public EntityCollection<HistoryEmailEntity> SelectBySubjectLST_Paged(string Subject, int PageNumber, int PageSize)
		{
			EntityCollection<HistoryEmailEntity> _HistoryEmailCollection = new EntityCollection<HistoryEmailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.Subject == Subject);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HistoryEmailCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HistoryEmailCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySubjectRDT(string Subject)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HistoryEmailCollection = new EntityCollection(new HistoryEmailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.Subject == Subject);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HistoryEmailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySubjectRDT_Paged(string Subject, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HistoryEmailCollection = new EntityCollection(new HistoryEmailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.Subject == Subject);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HistoryEmailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HistoryEmailEntity>
		public EntityCollection<HistoryEmailEntity> SelectByBodyLST(string Body)
		{
			EntityCollection<HistoryEmailEntity> _HistoryEmailCollection = new EntityCollection<HistoryEmailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.Body == Body);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HistoryEmailCollection, filter, 0, null);
			}
			return _HistoryEmailCollection;
		}
		
		// Return EntityCollection<HistoryEmailEntity>
		public EntityCollection<HistoryEmailEntity> SelectByBodyLST_Paged(string Body, int PageNumber, int PageSize)
		{
			EntityCollection<HistoryEmailEntity> _HistoryEmailCollection = new EntityCollection<HistoryEmailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.Body == Body);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HistoryEmailCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HistoryEmailCollection;
		}
		
		// Return DataTable
		public DataTable SelectByBodyRDT(string Body)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HistoryEmailCollection = new EntityCollection(new HistoryEmailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.Body == Body);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HistoryEmailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByBodyRDT_Paged(string Body, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HistoryEmailCollection = new EntityCollection(new HistoryEmailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.Body == Body);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HistoryEmailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HistoryEmailEntity>
		public EntityCollection<HistoryEmailEntity> SelectByReceiveDatedLST(DateTime ReceiveDated)
		{
			EntityCollection<HistoryEmailEntity> _HistoryEmailCollection = new EntityCollection<HistoryEmailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.ReceiveDated == ReceiveDated);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HistoryEmailCollection, filter, 0, null);
			}
			return _HistoryEmailCollection;
		}
		
		// Return EntityCollection<HistoryEmailEntity>
		public EntityCollection<HistoryEmailEntity> SelectByReceiveDatedLST_Paged(DateTime ReceiveDated, int PageNumber, int PageSize)
		{
			EntityCollection<HistoryEmailEntity> _HistoryEmailCollection = new EntityCollection<HistoryEmailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.ReceiveDated == ReceiveDated);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HistoryEmailCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HistoryEmailCollection;
		}
		
		// Return DataTable
		public DataTable SelectByReceiveDatedRDT(DateTime ReceiveDated)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HistoryEmailCollection = new EntityCollection(new HistoryEmailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.ReceiveDated == ReceiveDated);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HistoryEmailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByReceiveDatedRDT_Paged(DateTime ReceiveDated, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HistoryEmailCollection = new EntityCollection(new HistoryEmailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.ReceiveDated == ReceiveDated);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HistoryEmailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HistoryEmailEntity>
		public EntityCollection<HistoryEmailEntity> SelectBySendByLST(string SendBy)
		{
			EntityCollection<HistoryEmailEntity> _HistoryEmailCollection = new EntityCollection<HistoryEmailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.SendBy == SendBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HistoryEmailCollection, filter, 0, null);
			}
			return _HistoryEmailCollection;
		}
		
		// Return EntityCollection<HistoryEmailEntity>
		public EntityCollection<HistoryEmailEntity> SelectBySendByLST_Paged(string SendBy, int PageNumber, int PageSize)
		{
			EntityCollection<HistoryEmailEntity> _HistoryEmailCollection = new EntityCollection<HistoryEmailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.SendBy == SendBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HistoryEmailCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HistoryEmailCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySendByRDT(string SendBy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HistoryEmailCollection = new EntityCollection(new HistoryEmailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.SendBy == SendBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HistoryEmailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySendByRDT_Paged(string SendBy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HistoryEmailCollection = new EntityCollection(new HistoryEmailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HistoryEmailFields.SendBy == SendBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HistoryEmailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
