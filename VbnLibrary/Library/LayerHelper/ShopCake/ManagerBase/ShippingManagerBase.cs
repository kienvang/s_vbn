




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.ShippingManagerBase
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
	public class ShippingManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public ShippingManagerBase()
		{
			// Nothing for now.
		}
		
		public ShippingEntity Insert(ShippingEntity _ShippingEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_ShippingEntity, true);
			}
			return _ShippingEntity;
		}

		
		public ShippingEntity Insert(Guid Id, Guid OrderId, string ReceiverName, string RecerverEmail, string Address, string Phone1, string Phone2, decimal Cost, string Note, DateTime ShipDate)
		{
			ShippingEntity _ShippingEntity = new ShippingEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_ShippingEntity.Id = Id;
				_ShippingEntity.OrderId = OrderId;
				_ShippingEntity.ReceiverName = ReceiverName;
				_ShippingEntity.RecerverEmail = RecerverEmail;
				_ShippingEntity.Address = Address;
				_ShippingEntity.Phone1 = Phone1;
				_ShippingEntity.Phone2 = Phone2;
				_ShippingEntity.Cost = Cost;
				_ShippingEntity.Note = Note;
				_ShippingEntity.ShipDate = ShipDate;
				adapter.SaveEntity(_ShippingEntity, true);
			}
			return _ShippingEntity;
		}

		public ShippingEntity Insert(Guid OrderId, string ReceiverName, string RecerverEmail, string Address, string Phone1, string Phone2, decimal Cost, string Note, DateTime ShipDate)
		{
			ShippingEntity _ShippingEntity = new ShippingEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_ShippingEntity.OrderId = OrderId;
				_ShippingEntity.ReceiverName = ReceiverName;
				_ShippingEntity.RecerverEmail = RecerverEmail;
				_ShippingEntity.Address = Address;
				_ShippingEntity.Phone1 = Phone1;
				_ShippingEntity.Phone2 = Phone2;
				_ShippingEntity.Cost = Cost;
				_ShippingEntity.Note = Note;
				_ShippingEntity.ShipDate = ShipDate;
				adapter.SaveEntity(_ShippingEntity, true);
			}
			return _ShippingEntity;
		}

		public bool Update(ShippingEntity _ShippingEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(ShippingFields.Id == _ShippingEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_ShippingEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(ShippingEntity _ShippingEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_ShippingEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, Guid OrderId, string ReceiverName, string RecerverEmail, string Address, string Phone1, string Phone2, decimal Cost, string Note, DateTime ShipDate)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				ShippingEntity _ShippingEntity = new ShippingEntity(Id);
				if (adapter.FetchEntity(_ShippingEntity))
				{
				
					_ShippingEntity.OrderId = OrderId;
					_ShippingEntity.ReceiverName = ReceiverName;
					_ShippingEntity.RecerverEmail = RecerverEmail;
					_ShippingEntity.Address = Address;
					_ShippingEntity.Phone1 = Phone1;
					_ShippingEntity.Phone2 = Phone2;
					_ShippingEntity.Cost = Cost;
					_ShippingEntity.Note = Note;
					_ShippingEntity.ShipDate = ShipDate;
					adapter.SaveEntity(_ShippingEntity, true);
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
				ShippingEntity _ShippingEntity = new ShippingEntity(Id);
				if (adapter.FetchEntity(_ShippingEntity))
				{
					adapter.DeleteEntity(_ShippingEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("ShippingEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ShippingEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByOrderId(Guid OrderId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.OrderId == OrderId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ShippingEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByReceiverName(string ReceiverName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.ReceiverName == ReceiverName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ShippingEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByRecerverEmail(string RecerverEmail)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.RecerverEmail == RecerverEmail);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ShippingEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByAddress(string Address)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.Address == Address);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ShippingEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPhone1(string Phone1)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.Phone1 == Phone1);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ShippingEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPhone2(string Phone2)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.Phone2 == Phone2);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ShippingEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCost(decimal Cost)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.Cost == Cost);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ShippingEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNote(string Note)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.Note == Note);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ShippingEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByShipDate(DateTime ShipDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.ShipDate == ShipDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ShippingEntity", filter);
			}
			return toReturn;
		}
		

		
		public ShippingEntity SelectOne(Guid Id)
		{
			ShippingEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				ShippingEntity _ShippingEntity = new ShippingEntity(Id);
				if (adapter.FetchEntity(_ShippingEntity))
				{
					toReturn = _ShippingEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ShippingCollection = new EntityCollection(new ShippingEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ShippingCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<ShippingEntity>
		public EntityCollection<ShippingEntity> SelectAllLST()
		{
			EntityCollection<ShippingEntity> _ShippingCollection = new EntityCollection<ShippingEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ShippingCollection, null, 0, null);
			}
			return _ShippingCollection;
		}
		
		// Return EntityCollection<ShippingEntity>
		public EntityCollection<ShippingEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<ShippingEntity> _ShippingCollection = new EntityCollection<ShippingEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ShippingCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _ShippingCollection;
		}


		
		// Return EntityCollection<ShippingEntity>
		public EntityCollection<ShippingEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<ShippingEntity> _ShippingCollection = new EntityCollection<ShippingEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ShippingCollection, filter, 0, null);
			}
			return _ShippingCollection;
		}
		
		// Return EntityCollection<ShippingEntity>
		public EntityCollection<ShippingEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<ShippingEntity> _ShippingCollection = new EntityCollection<ShippingEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ShippingCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ShippingCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ShippingCollection = new EntityCollection(new ShippingEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ShippingCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ShippingCollection = new EntityCollection(new ShippingEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ShippingCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ShippingEntity>
		public EntityCollection<ShippingEntity> SelectByOrderIdLST(Guid OrderId)
		{
			EntityCollection<ShippingEntity> _ShippingCollection = new EntityCollection<ShippingEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.OrderId == OrderId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ShippingCollection, filter, 0, null);
			}
			return _ShippingCollection;
		}
		
		// Return EntityCollection<ShippingEntity>
		public EntityCollection<ShippingEntity> SelectByOrderIdLST_Paged(Guid OrderId, int PageNumber, int PageSize)
		{
			EntityCollection<ShippingEntity> _ShippingCollection = new EntityCollection<ShippingEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.OrderId == OrderId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ShippingCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ShippingCollection;
		}
		
		// Return DataTable
		public DataTable SelectByOrderIdRDT(Guid OrderId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ShippingCollection = new EntityCollection(new ShippingEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.OrderId == OrderId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ShippingCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByOrderIdRDT_Paged(Guid OrderId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ShippingCollection = new EntityCollection(new ShippingEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.OrderId == OrderId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ShippingCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ShippingEntity>
		public EntityCollection<ShippingEntity> SelectByReceiverNameLST(string ReceiverName)
		{
			EntityCollection<ShippingEntity> _ShippingCollection = new EntityCollection<ShippingEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.ReceiverName == ReceiverName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ShippingCollection, filter, 0, null);
			}
			return _ShippingCollection;
		}
		
		// Return EntityCollection<ShippingEntity>
		public EntityCollection<ShippingEntity> SelectByReceiverNameLST_Paged(string ReceiverName, int PageNumber, int PageSize)
		{
			EntityCollection<ShippingEntity> _ShippingCollection = new EntityCollection<ShippingEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.ReceiverName == ReceiverName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ShippingCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ShippingCollection;
		}
		
		// Return DataTable
		public DataTable SelectByReceiverNameRDT(string ReceiverName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ShippingCollection = new EntityCollection(new ShippingEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.ReceiverName == ReceiverName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ShippingCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByReceiverNameRDT_Paged(string ReceiverName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ShippingCollection = new EntityCollection(new ShippingEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.ReceiverName == ReceiverName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ShippingCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ShippingEntity>
		public EntityCollection<ShippingEntity> SelectByRecerverEmailLST(string RecerverEmail)
		{
			EntityCollection<ShippingEntity> _ShippingCollection = new EntityCollection<ShippingEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.RecerverEmail == RecerverEmail);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ShippingCollection, filter, 0, null);
			}
			return _ShippingCollection;
		}
		
		// Return EntityCollection<ShippingEntity>
		public EntityCollection<ShippingEntity> SelectByRecerverEmailLST_Paged(string RecerverEmail, int PageNumber, int PageSize)
		{
			EntityCollection<ShippingEntity> _ShippingCollection = new EntityCollection<ShippingEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.RecerverEmail == RecerverEmail);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ShippingCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ShippingCollection;
		}
		
		// Return DataTable
		public DataTable SelectByRecerverEmailRDT(string RecerverEmail)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ShippingCollection = new EntityCollection(new ShippingEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.RecerverEmail == RecerverEmail);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ShippingCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByRecerverEmailRDT_Paged(string RecerverEmail, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ShippingCollection = new EntityCollection(new ShippingEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.RecerverEmail == RecerverEmail);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ShippingCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ShippingEntity>
		public EntityCollection<ShippingEntity> SelectByAddressLST(string Address)
		{
			EntityCollection<ShippingEntity> _ShippingCollection = new EntityCollection<ShippingEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.Address == Address);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ShippingCollection, filter, 0, null);
			}
			return _ShippingCollection;
		}
		
		// Return EntityCollection<ShippingEntity>
		public EntityCollection<ShippingEntity> SelectByAddressLST_Paged(string Address, int PageNumber, int PageSize)
		{
			EntityCollection<ShippingEntity> _ShippingCollection = new EntityCollection<ShippingEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.Address == Address);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ShippingCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ShippingCollection;
		}
		
		// Return DataTable
		public DataTable SelectByAddressRDT(string Address)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ShippingCollection = new EntityCollection(new ShippingEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.Address == Address);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ShippingCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByAddressRDT_Paged(string Address, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ShippingCollection = new EntityCollection(new ShippingEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.Address == Address);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ShippingCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ShippingEntity>
		public EntityCollection<ShippingEntity> SelectByPhone1LST(string Phone1)
		{
			EntityCollection<ShippingEntity> _ShippingCollection = new EntityCollection<ShippingEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.Phone1 == Phone1);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ShippingCollection, filter, 0, null);
			}
			return _ShippingCollection;
		}
		
		// Return EntityCollection<ShippingEntity>
		public EntityCollection<ShippingEntity> SelectByPhone1LST_Paged(string Phone1, int PageNumber, int PageSize)
		{
			EntityCollection<ShippingEntity> _ShippingCollection = new EntityCollection<ShippingEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.Phone1 == Phone1);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ShippingCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ShippingCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPhone1RDT(string Phone1)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ShippingCollection = new EntityCollection(new ShippingEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.Phone1 == Phone1);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ShippingCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPhone1RDT_Paged(string Phone1, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ShippingCollection = new EntityCollection(new ShippingEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.Phone1 == Phone1);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ShippingCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ShippingEntity>
		public EntityCollection<ShippingEntity> SelectByPhone2LST(string Phone2)
		{
			EntityCollection<ShippingEntity> _ShippingCollection = new EntityCollection<ShippingEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.Phone2 == Phone2);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ShippingCollection, filter, 0, null);
			}
			return _ShippingCollection;
		}
		
		// Return EntityCollection<ShippingEntity>
		public EntityCollection<ShippingEntity> SelectByPhone2LST_Paged(string Phone2, int PageNumber, int PageSize)
		{
			EntityCollection<ShippingEntity> _ShippingCollection = new EntityCollection<ShippingEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.Phone2 == Phone2);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ShippingCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ShippingCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPhone2RDT(string Phone2)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ShippingCollection = new EntityCollection(new ShippingEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.Phone2 == Phone2);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ShippingCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPhone2RDT_Paged(string Phone2, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ShippingCollection = new EntityCollection(new ShippingEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.Phone2 == Phone2);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ShippingCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ShippingEntity>
		public EntityCollection<ShippingEntity> SelectByCostLST(decimal Cost)
		{
			EntityCollection<ShippingEntity> _ShippingCollection = new EntityCollection<ShippingEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.Cost == Cost);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ShippingCollection, filter, 0, null);
			}
			return _ShippingCollection;
		}
		
		// Return EntityCollection<ShippingEntity>
		public EntityCollection<ShippingEntity> SelectByCostLST_Paged(decimal Cost, int PageNumber, int PageSize)
		{
			EntityCollection<ShippingEntity> _ShippingCollection = new EntityCollection<ShippingEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.Cost == Cost);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ShippingCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ShippingCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCostRDT(decimal Cost)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ShippingCollection = new EntityCollection(new ShippingEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.Cost == Cost);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ShippingCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCostRDT_Paged(decimal Cost, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ShippingCollection = new EntityCollection(new ShippingEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.Cost == Cost);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ShippingCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ShippingEntity>
		public EntityCollection<ShippingEntity> SelectByNoteLST(string Note)
		{
			EntityCollection<ShippingEntity> _ShippingCollection = new EntityCollection<ShippingEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.Note == Note);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ShippingCollection, filter, 0, null);
			}
			return _ShippingCollection;
		}
		
		// Return EntityCollection<ShippingEntity>
		public EntityCollection<ShippingEntity> SelectByNoteLST_Paged(string Note, int PageNumber, int PageSize)
		{
			EntityCollection<ShippingEntity> _ShippingCollection = new EntityCollection<ShippingEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.Note == Note);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ShippingCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ShippingCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNoteRDT(string Note)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ShippingCollection = new EntityCollection(new ShippingEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.Note == Note);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ShippingCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNoteRDT_Paged(string Note, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ShippingCollection = new EntityCollection(new ShippingEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.Note == Note);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ShippingCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ShippingEntity>
		public EntityCollection<ShippingEntity> SelectByShipDateLST(DateTime ShipDate)
		{
			EntityCollection<ShippingEntity> _ShippingCollection = new EntityCollection<ShippingEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.ShipDate == ShipDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ShippingCollection, filter, 0, null);
			}
			return _ShippingCollection;
		}
		
		// Return EntityCollection<ShippingEntity>
		public EntityCollection<ShippingEntity> SelectByShipDateLST_Paged(DateTime ShipDate, int PageNumber, int PageSize)
		{
			EntityCollection<ShippingEntity> _ShippingCollection = new EntityCollection<ShippingEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.ShipDate == ShipDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ShippingCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ShippingCollection;
		}
		
		// Return DataTable
		public DataTable SelectByShipDateRDT(DateTime ShipDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ShippingCollection = new EntityCollection(new ShippingEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.ShipDate == ShipDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ShippingCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByShipDateRDT_Paged(DateTime ShipDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ShippingCollection = new EntityCollection(new ShippingEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ShippingFields.ShipDate == ShipDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ShippingCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
