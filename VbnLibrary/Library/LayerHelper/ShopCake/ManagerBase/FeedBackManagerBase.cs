




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.FeedBackManagerBase
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
	public class FeedBackManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public FeedBackManagerBase()
		{
			// Nothing for now.
		}
		
		public FeedBackEntity Insert(FeedBackEntity _FeedBackEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_FeedBackEntity, true);
			}
			return _FeedBackEntity;
		}

		
		public FeedBackEntity Insert(Guid Id, string UserName, string Message, string Sender, string SenderEmail, DateTime SendDate, bool Approved, string UserIp)
		{
			FeedBackEntity _FeedBackEntity = new FeedBackEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_FeedBackEntity.Id = Id;
				_FeedBackEntity.UserName = UserName;
				_FeedBackEntity.Message = Message;
				_FeedBackEntity.Sender = Sender;
				_FeedBackEntity.SenderEmail = SenderEmail;
				_FeedBackEntity.SendDate = SendDate;
				_FeedBackEntity.Approved = Approved;
				_FeedBackEntity.UserIp = UserIp;
				adapter.SaveEntity(_FeedBackEntity, true);
			}
			return _FeedBackEntity;
		}

		public FeedBackEntity Insert(string UserName, string Message, string Sender, string SenderEmail, DateTime SendDate, bool Approved, string UserIp)
		{
			FeedBackEntity _FeedBackEntity = new FeedBackEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_FeedBackEntity.UserName = UserName;
				_FeedBackEntity.Message = Message;
				_FeedBackEntity.Sender = Sender;
				_FeedBackEntity.SenderEmail = SenderEmail;
				_FeedBackEntity.SendDate = SendDate;
				_FeedBackEntity.Approved = Approved;
				_FeedBackEntity.UserIp = UserIp;
				adapter.SaveEntity(_FeedBackEntity, true);
			}
			return _FeedBackEntity;
		}

		public bool Update(FeedBackEntity _FeedBackEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(FeedBackFields.Id == _FeedBackEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_FeedBackEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(FeedBackEntity _FeedBackEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_FeedBackEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string UserName, string Message, string Sender, string SenderEmail, DateTime SendDate, bool Approved, string UserIp)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				FeedBackEntity _FeedBackEntity = new FeedBackEntity(Id);
				if (adapter.FetchEntity(_FeedBackEntity))
				{
				
					_FeedBackEntity.UserName = UserName;
					_FeedBackEntity.Message = Message;
					_FeedBackEntity.Sender = Sender;
					_FeedBackEntity.SenderEmail = SenderEmail;
					_FeedBackEntity.SendDate = SendDate;
					_FeedBackEntity.Approved = Approved;
					_FeedBackEntity.UserIp = UserIp;
					adapter.SaveEntity(_FeedBackEntity, true);
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
				FeedBackEntity _FeedBackEntity = new FeedBackEntity(Id);
				if (adapter.FetchEntity(_FeedBackEntity))
				{
					adapter.DeleteEntity(_FeedBackEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("FeedBackEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedBackFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("FeedBackEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByUserName(string UserName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedBackFields.UserName == UserName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("FeedBackEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMessage(string Message)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedBackFields.Message == Message);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("FeedBackEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySender(string Sender)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedBackFields.Sender == Sender);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("FeedBackEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySenderEmail(string SenderEmail)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedBackFields.SenderEmail == SenderEmail);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("FeedBackEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySendDate(DateTime SendDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedBackFields.SendDate == SendDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("FeedBackEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByApproved(bool Approved)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedBackFields.Approved == Approved);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("FeedBackEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByUserIp(string UserIp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedBackFields.UserIp == UserIp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("FeedBackEntity", filter);
			}
			return toReturn;
		}
		

		
		public FeedBackEntity SelectOne(Guid Id)
		{
			FeedBackEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				FeedBackEntity _FeedBackEntity = new FeedBackEntity(Id);
				if (adapter.FetchEntity(_FeedBackEntity))
				{
					toReturn = _FeedBackEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _FeedBackCollection = new EntityCollection(new FeedBackEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_FeedBackCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<FeedBackEntity>
		public EntityCollection<FeedBackEntity> SelectAllLST()
		{
			EntityCollection<FeedBackEntity> _FeedBackCollection = new EntityCollection<FeedBackEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_FeedBackCollection, null, 0, null);
			}
			return _FeedBackCollection;
		}
		
		// Return EntityCollection<FeedBackEntity>
		public EntityCollection<FeedBackEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<FeedBackEntity> _FeedBackCollection = new EntityCollection<FeedBackEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_FeedBackCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _FeedBackCollection;
		}


		
		// Return EntityCollection<FeedBackEntity>
		public EntityCollection<FeedBackEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<FeedBackEntity> _FeedBackCollection = new EntityCollection<FeedBackEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedBackFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_FeedBackCollection, filter, 0, null);
			}
			return _FeedBackCollection;
		}
		
		// Return EntityCollection<FeedBackEntity>
		public EntityCollection<FeedBackEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<FeedBackEntity> _FeedBackCollection = new EntityCollection<FeedBackEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedBackFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_FeedBackCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _FeedBackCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _FeedBackCollection = new EntityCollection(new FeedBackEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedBackFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_FeedBackCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _FeedBackCollection = new EntityCollection(new FeedBackEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedBackFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_FeedBackCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<FeedBackEntity>
		public EntityCollection<FeedBackEntity> SelectByUserNameLST(string UserName)
		{
			EntityCollection<FeedBackEntity> _FeedBackCollection = new EntityCollection<FeedBackEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedBackFields.UserName == UserName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_FeedBackCollection, filter, 0, null);
			}
			return _FeedBackCollection;
		}
		
		// Return EntityCollection<FeedBackEntity>
		public EntityCollection<FeedBackEntity> SelectByUserNameLST_Paged(string UserName, int PageNumber, int PageSize)
		{
			EntityCollection<FeedBackEntity> _FeedBackCollection = new EntityCollection<FeedBackEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedBackFields.UserName == UserName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_FeedBackCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _FeedBackCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUserNameRDT(string UserName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _FeedBackCollection = new EntityCollection(new FeedBackEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedBackFields.UserName == UserName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_FeedBackCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUserNameRDT_Paged(string UserName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _FeedBackCollection = new EntityCollection(new FeedBackEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedBackFields.UserName == UserName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_FeedBackCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<FeedBackEntity>
		public EntityCollection<FeedBackEntity> SelectByMessageLST(string Message)
		{
			EntityCollection<FeedBackEntity> _FeedBackCollection = new EntityCollection<FeedBackEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedBackFields.Message == Message);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_FeedBackCollection, filter, 0, null);
			}
			return _FeedBackCollection;
		}
		
		// Return EntityCollection<FeedBackEntity>
		public EntityCollection<FeedBackEntity> SelectByMessageLST_Paged(string Message, int PageNumber, int PageSize)
		{
			EntityCollection<FeedBackEntity> _FeedBackCollection = new EntityCollection<FeedBackEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedBackFields.Message == Message);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_FeedBackCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _FeedBackCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMessageRDT(string Message)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _FeedBackCollection = new EntityCollection(new FeedBackEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedBackFields.Message == Message);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_FeedBackCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMessageRDT_Paged(string Message, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _FeedBackCollection = new EntityCollection(new FeedBackEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedBackFields.Message == Message);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_FeedBackCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<FeedBackEntity>
		public EntityCollection<FeedBackEntity> SelectBySenderLST(string Sender)
		{
			EntityCollection<FeedBackEntity> _FeedBackCollection = new EntityCollection<FeedBackEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedBackFields.Sender == Sender);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_FeedBackCollection, filter, 0, null);
			}
			return _FeedBackCollection;
		}
		
		// Return EntityCollection<FeedBackEntity>
		public EntityCollection<FeedBackEntity> SelectBySenderLST_Paged(string Sender, int PageNumber, int PageSize)
		{
			EntityCollection<FeedBackEntity> _FeedBackCollection = new EntityCollection<FeedBackEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedBackFields.Sender == Sender);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_FeedBackCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _FeedBackCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySenderRDT(string Sender)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _FeedBackCollection = new EntityCollection(new FeedBackEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedBackFields.Sender == Sender);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_FeedBackCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySenderRDT_Paged(string Sender, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _FeedBackCollection = new EntityCollection(new FeedBackEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedBackFields.Sender == Sender);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_FeedBackCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<FeedBackEntity>
		public EntityCollection<FeedBackEntity> SelectBySenderEmailLST(string SenderEmail)
		{
			EntityCollection<FeedBackEntity> _FeedBackCollection = new EntityCollection<FeedBackEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedBackFields.SenderEmail == SenderEmail);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_FeedBackCollection, filter, 0, null);
			}
			return _FeedBackCollection;
		}
		
		// Return EntityCollection<FeedBackEntity>
		public EntityCollection<FeedBackEntity> SelectBySenderEmailLST_Paged(string SenderEmail, int PageNumber, int PageSize)
		{
			EntityCollection<FeedBackEntity> _FeedBackCollection = new EntityCollection<FeedBackEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedBackFields.SenderEmail == SenderEmail);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_FeedBackCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _FeedBackCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySenderEmailRDT(string SenderEmail)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _FeedBackCollection = new EntityCollection(new FeedBackEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedBackFields.SenderEmail == SenderEmail);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_FeedBackCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySenderEmailRDT_Paged(string SenderEmail, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _FeedBackCollection = new EntityCollection(new FeedBackEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedBackFields.SenderEmail == SenderEmail);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_FeedBackCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<FeedBackEntity>
		public EntityCollection<FeedBackEntity> SelectBySendDateLST(DateTime SendDate)
		{
			EntityCollection<FeedBackEntity> _FeedBackCollection = new EntityCollection<FeedBackEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedBackFields.SendDate == SendDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_FeedBackCollection, filter, 0, null);
			}
			return _FeedBackCollection;
		}
		
		// Return EntityCollection<FeedBackEntity>
		public EntityCollection<FeedBackEntity> SelectBySendDateLST_Paged(DateTime SendDate, int PageNumber, int PageSize)
		{
			EntityCollection<FeedBackEntity> _FeedBackCollection = new EntityCollection<FeedBackEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedBackFields.SendDate == SendDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_FeedBackCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _FeedBackCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySendDateRDT(DateTime SendDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _FeedBackCollection = new EntityCollection(new FeedBackEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedBackFields.SendDate == SendDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_FeedBackCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySendDateRDT_Paged(DateTime SendDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _FeedBackCollection = new EntityCollection(new FeedBackEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedBackFields.SendDate == SendDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_FeedBackCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<FeedBackEntity>
		public EntityCollection<FeedBackEntity> SelectByApprovedLST(bool Approved)
		{
			EntityCollection<FeedBackEntity> _FeedBackCollection = new EntityCollection<FeedBackEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedBackFields.Approved == Approved);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_FeedBackCollection, filter, 0, null);
			}
			return _FeedBackCollection;
		}
		
		// Return EntityCollection<FeedBackEntity>
		public EntityCollection<FeedBackEntity> SelectByApprovedLST_Paged(bool Approved, int PageNumber, int PageSize)
		{
			EntityCollection<FeedBackEntity> _FeedBackCollection = new EntityCollection<FeedBackEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedBackFields.Approved == Approved);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_FeedBackCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _FeedBackCollection;
		}
		
		// Return DataTable
		public DataTable SelectByApprovedRDT(bool Approved)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _FeedBackCollection = new EntityCollection(new FeedBackEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedBackFields.Approved == Approved);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_FeedBackCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByApprovedRDT_Paged(bool Approved, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _FeedBackCollection = new EntityCollection(new FeedBackEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedBackFields.Approved == Approved);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_FeedBackCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<FeedBackEntity>
		public EntityCollection<FeedBackEntity> SelectByUserIpLST(string UserIp)
		{
			EntityCollection<FeedBackEntity> _FeedBackCollection = new EntityCollection<FeedBackEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedBackFields.UserIp == UserIp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_FeedBackCollection, filter, 0, null);
			}
			return _FeedBackCollection;
		}
		
		// Return EntityCollection<FeedBackEntity>
		public EntityCollection<FeedBackEntity> SelectByUserIpLST_Paged(string UserIp, int PageNumber, int PageSize)
		{
			EntityCollection<FeedBackEntity> _FeedBackCollection = new EntityCollection<FeedBackEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedBackFields.UserIp == UserIp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_FeedBackCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _FeedBackCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUserIpRDT(string UserIp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _FeedBackCollection = new EntityCollection(new FeedBackEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedBackFields.UserIp == UserIp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_FeedBackCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUserIpRDT_Paged(string UserIp, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _FeedBackCollection = new EntityCollection(new FeedBackEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedBackFields.UserIp == UserIp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_FeedBackCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
