




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.SupplierRegisterManagerBase
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
	public class SupplierRegisterManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public SupplierRegisterManagerBase()
		{
			// Nothing for now.
		}
		
		public SupplierRegisterEntity Insert(SupplierRegisterEntity _SupplierRegisterEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_SupplierRegisterEntity, true);
			}
			return _SupplierRegisterEntity;
		}

		
		public SupplierRegisterEntity Insert(Guid Id, string UserName, string Email, string SupplierName, string SupplierTypeId, string Phone, string CountryCode, string CityCode, string DistrictCode, string Address, string AboutContents, bool Approved, string AutomationCode, DateTime CreatedDate)
		{
			SupplierRegisterEntity _SupplierRegisterEntity = new SupplierRegisterEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_SupplierRegisterEntity.Id = Id;
				_SupplierRegisterEntity.UserName = UserName;
				_SupplierRegisterEntity.Email = Email;
				_SupplierRegisterEntity.SupplierName = SupplierName;
				_SupplierRegisterEntity.SupplierTypeId = SupplierTypeId;
				_SupplierRegisterEntity.Phone = Phone;
				_SupplierRegisterEntity.CountryCode = CountryCode;
				_SupplierRegisterEntity.CityCode = CityCode;
				_SupplierRegisterEntity.DistrictCode = DistrictCode;
				_SupplierRegisterEntity.Address = Address;
				_SupplierRegisterEntity.AboutContents = AboutContents;
				_SupplierRegisterEntity.Approved = Approved;
				_SupplierRegisterEntity.AutomationCode = AutomationCode;
				_SupplierRegisterEntity.CreatedDate = CreatedDate;
				adapter.SaveEntity(_SupplierRegisterEntity, true);
			}
			return _SupplierRegisterEntity;
		}

		public SupplierRegisterEntity Insert(string UserName, string Email, string SupplierName, string SupplierTypeId, string Phone, string CountryCode, string CityCode, string DistrictCode, string Address, string AboutContents, bool Approved, string AutomationCode, DateTime CreatedDate)
		{
			SupplierRegisterEntity _SupplierRegisterEntity = new SupplierRegisterEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_SupplierRegisterEntity.UserName = UserName;
				_SupplierRegisterEntity.Email = Email;
				_SupplierRegisterEntity.SupplierName = SupplierName;
				_SupplierRegisterEntity.SupplierTypeId = SupplierTypeId;
				_SupplierRegisterEntity.Phone = Phone;
				_SupplierRegisterEntity.CountryCode = CountryCode;
				_SupplierRegisterEntity.CityCode = CityCode;
				_SupplierRegisterEntity.DistrictCode = DistrictCode;
				_SupplierRegisterEntity.Address = Address;
				_SupplierRegisterEntity.AboutContents = AboutContents;
				_SupplierRegisterEntity.Approved = Approved;
				_SupplierRegisterEntity.AutomationCode = AutomationCode;
				_SupplierRegisterEntity.CreatedDate = CreatedDate;
				adapter.SaveEntity(_SupplierRegisterEntity, true);
			}
			return _SupplierRegisterEntity;
		}

		public bool Update(SupplierRegisterEntity _SupplierRegisterEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(SupplierRegisterFields.Id == _SupplierRegisterEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_SupplierRegisterEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(SupplierRegisterEntity _SupplierRegisterEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_SupplierRegisterEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string UserName, string Email, string SupplierName, string SupplierTypeId, string Phone, string CountryCode, string CityCode, string DistrictCode, string Address, string AboutContents, bool Approved, string AutomationCode, DateTime CreatedDate)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				SupplierRegisterEntity _SupplierRegisterEntity = new SupplierRegisterEntity(Id);
				if (adapter.FetchEntity(_SupplierRegisterEntity))
				{
				
					_SupplierRegisterEntity.UserName = UserName;
					_SupplierRegisterEntity.Email = Email;
					_SupplierRegisterEntity.SupplierName = SupplierName;
					_SupplierRegisterEntity.SupplierTypeId = SupplierTypeId;
					_SupplierRegisterEntity.Phone = Phone;
					_SupplierRegisterEntity.CountryCode = CountryCode;
					_SupplierRegisterEntity.CityCode = CityCode;
					_SupplierRegisterEntity.DistrictCode = DistrictCode;
					_SupplierRegisterEntity.Address = Address;
					_SupplierRegisterEntity.AboutContents = AboutContents;
					_SupplierRegisterEntity.Approved = Approved;
					_SupplierRegisterEntity.AutomationCode = AutomationCode;
					_SupplierRegisterEntity.CreatedDate = CreatedDate;
					adapter.SaveEntity(_SupplierRegisterEntity, true);
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
				SupplierRegisterEntity _SupplierRegisterEntity = new SupplierRegisterEntity(Id);
				if (adapter.FetchEntity(_SupplierRegisterEntity))
				{
					adapter.DeleteEntity(_SupplierRegisterEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("SupplierRegisterEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SupplierRegisterEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByUserName(string UserName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.UserName == UserName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SupplierRegisterEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByEmail(string Email)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.Email == Email);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SupplierRegisterEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySupplierName(string SupplierName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.SupplierName == SupplierName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SupplierRegisterEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySupplierTypeId(string SupplierTypeId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.SupplierTypeId == SupplierTypeId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SupplierRegisterEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPhone(string Phone)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.Phone == Phone);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SupplierRegisterEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCountryCode(string CountryCode)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.CountryCode == CountryCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SupplierRegisterEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCityCode(string CityCode)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.CityCode == CityCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SupplierRegisterEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByDistrictCode(string DistrictCode)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.DistrictCode == DistrictCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SupplierRegisterEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByAddress(string Address)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.Address == Address);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SupplierRegisterEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByAboutContents(string AboutContents)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.AboutContents == AboutContents);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SupplierRegisterEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByApproved(bool Approved)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.Approved == Approved);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SupplierRegisterEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByAutomationCode(string AutomationCode)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.AutomationCode == AutomationCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SupplierRegisterEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCreatedDate(DateTime CreatedDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SupplierRegisterEntity", filter);
			}
			return toReturn;
		}
		

		
		public SupplierRegisterEntity SelectOne(Guid Id)
		{
			SupplierRegisterEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				SupplierRegisterEntity _SupplierRegisterEntity = new SupplierRegisterEntity(Id);
				if (adapter.FetchEntity(_SupplierRegisterEntity))
				{
					toReturn = _SupplierRegisterEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierRegisterCollection = new EntityCollection(new SupplierRegisterEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<SupplierRegisterEntity>
		public EntityCollection<SupplierRegisterEntity> SelectAllLST()
		{
			EntityCollection<SupplierRegisterEntity> _SupplierRegisterCollection = new EntityCollection<SupplierRegisterEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierRegisterCollection, null, 0, null);
			}
			return _SupplierRegisterCollection;
		}
		
		// Return EntityCollection<SupplierRegisterEntity>
		public EntityCollection<SupplierRegisterEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<SupplierRegisterEntity> _SupplierRegisterCollection = new EntityCollection<SupplierRegisterEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierRegisterCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _SupplierRegisterCollection;
		}


		
		// Return EntityCollection<SupplierRegisterEntity>
		public EntityCollection<SupplierRegisterEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<SupplierRegisterEntity> _SupplierRegisterCollection = new EntityCollection<SupplierRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierRegisterCollection, filter, 0, null);
			}
			return _SupplierRegisterCollection;
		}
		
		// Return EntityCollection<SupplierRegisterEntity>
		public EntityCollection<SupplierRegisterEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<SupplierRegisterEntity> _SupplierRegisterCollection = new EntityCollection<SupplierRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierRegisterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _SupplierRegisterCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierRegisterCollection = new EntityCollection(new SupplierRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierRegisterCollection = new EntityCollection(new SupplierRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<SupplierRegisterEntity>
		public EntityCollection<SupplierRegisterEntity> SelectByUserNameLST(string UserName)
		{
			EntityCollection<SupplierRegisterEntity> _SupplierRegisterCollection = new EntityCollection<SupplierRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.UserName == UserName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierRegisterCollection, filter, 0, null);
			}
			return _SupplierRegisterCollection;
		}
		
		// Return EntityCollection<SupplierRegisterEntity>
		public EntityCollection<SupplierRegisterEntity> SelectByUserNameLST_Paged(string UserName, int PageNumber, int PageSize)
		{
			EntityCollection<SupplierRegisterEntity> _SupplierRegisterCollection = new EntityCollection<SupplierRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.UserName == UserName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierRegisterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _SupplierRegisterCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUserNameRDT(string UserName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierRegisterCollection = new EntityCollection(new SupplierRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.UserName == UserName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUserNameRDT_Paged(string UserName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierRegisterCollection = new EntityCollection(new SupplierRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.UserName == UserName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<SupplierRegisterEntity>
		public EntityCollection<SupplierRegisterEntity> SelectByEmailLST(string Email)
		{
			EntityCollection<SupplierRegisterEntity> _SupplierRegisterCollection = new EntityCollection<SupplierRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.Email == Email);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierRegisterCollection, filter, 0, null);
			}
			return _SupplierRegisterCollection;
		}
		
		// Return EntityCollection<SupplierRegisterEntity>
		public EntityCollection<SupplierRegisterEntity> SelectByEmailLST_Paged(string Email, int PageNumber, int PageSize)
		{
			EntityCollection<SupplierRegisterEntity> _SupplierRegisterCollection = new EntityCollection<SupplierRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.Email == Email);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierRegisterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _SupplierRegisterCollection;
		}
		
		// Return DataTable
		public DataTable SelectByEmailRDT(string Email)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierRegisterCollection = new EntityCollection(new SupplierRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.Email == Email);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByEmailRDT_Paged(string Email, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierRegisterCollection = new EntityCollection(new SupplierRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.Email == Email);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<SupplierRegisterEntity>
		public EntityCollection<SupplierRegisterEntity> SelectBySupplierNameLST(string SupplierName)
		{
			EntityCollection<SupplierRegisterEntity> _SupplierRegisterCollection = new EntityCollection<SupplierRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.SupplierName == SupplierName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierRegisterCollection, filter, 0, null);
			}
			return _SupplierRegisterCollection;
		}
		
		// Return EntityCollection<SupplierRegisterEntity>
		public EntityCollection<SupplierRegisterEntity> SelectBySupplierNameLST_Paged(string SupplierName, int PageNumber, int PageSize)
		{
			EntityCollection<SupplierRegisterEntity> _SupplierRegisterCollection = new EntityCollection<SupplierRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.SupplierName == SupplierName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierRegisterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _SupplierRegisterCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySupplierNameRDT(string SupplierName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierRegisterCollection = new EntityCollection(new SupplierRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.SupplierName == SupplierName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySupplierNameRDT_Paged(string SupplierName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierRegisterCollection = new EntityCollection(new SupplierRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.SupplierName == SupplierName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<SupplierRegisterEntity>
		public EntityCollection<SupplierRegisterEntity> SelectBySupplierTypeIdLST(string SupplierTypeId)
		{
			EntityCollection<SupplierRegisterEntity> _SupplierRegisterCollection = new EntityCollection<SupplierRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.SupplierTypeId == SupplierTypeId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierRegisterCollection, filter, 0, null);
			}
			return _SupplierRegisterCollection;
		}
		
		// Return EntityCollection<SupplierRegisterEntity>
		public EntityCollection<SupplierRegisterEntity> SelectBySupplierTypeIdLST_Paged(string SupplierTypeId, int PageNumber, int PageSize)
		{
			EntityCollection<SupplierRegisterEntity> _SupplierRegisterCollection = new EntityCollection<SupplierRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.SupplierTypeId == SupplierTypeId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierRegisterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _SupplierRegisterCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySupplierTypeIdRDT(string SupplierTypeId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierRegisterCollection = new EntityCollection(new SupplierRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.SupplierTypeId == SupplierTypeId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySupplierTypeIdRDT_Paged(string SupplierTypeId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierRegisterCollection = new EntityCollection(new SupplierRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.SupplierTypeId == SupplierTypeId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<SupplierRegisterEntity>
		public EntityCollection<SupplierRegisterEntity> SelectByPhoneLST(string Phone)
		{
			EntityCollection<SupplierRegisterEntity> _SupplierRegisterCollection = new EntityCollection<SupplierRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.Phone == Phone);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierRegisterCollection, filter, 0, null);
			}
			return _SupplierRegisterCollection;
		}
		
		// Return EntityCollection<SupplierRegisterEntity>
		public EntityCollection<SupplierRegisterEntity> SelectByPhoneLST_Paged(string Phone, int PageNumber, int PageSize)
		{
			EntityCollection<SupplierRegisterEntity> _SupplierRegisterCollection = new EntityCollection<SupplierRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.Phone == Phone);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierRegisterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _SupplierRegisterCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPhoneRDT(string Phone)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierRegisterCollection = new EntityCollection(new SupplierRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.Phone == Phone);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPhoneRDT_Paged(string Phone, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierRegisterCollection = new EntityCollection(new SupplierRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.Phone == Phone);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<SupplierRegisterEntity>
		public EntityCollection<SupplierRegisterEntity> SelectByCountryCodeLST(string CountryCode)
		{
			EntityCollection<SupplierRegisterEntity> _SupplierRegisterCollection = new EntityCollection<SupplierRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.CountryCode == CountryCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierRegisterCollection, filter, 0, null);
			}
			return _SupplierRegisterCollection;
		}
		
		// Return EntityCollection<SupplierRegisterEntity>
		public EntityCollection<SupplierRegisterEntity> SelectByCountryCodeLST_Paged(string CountryCode, int PageNumber, int PageSize)
		{
			EntityCollection<SupplierRegisterEntity> _SupplierRegisterCollection = new EntityCollection<SupplierRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.CountryCode == CountryCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierRegisterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _SupplierRegisterCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCountryCodeRDT(string CountryCode)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierRegisterCollection = new EntityCollection(new SupplierRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.CountryCode == CountryCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCountryCodeRDT_Paged(string CountryCode, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierRegisterCollection = new EntityCollection(new SupplierRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.CountryCode == CountryCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<SupplierRegisterEntity>
		public EntityCollection<SupplierRegisterEntity> SelectByCityCodeLST(string CityCode)
		{
			EntityCollection<SupplierRegisterEntity> _SupplierRegisterCollection = new EntityCollection<SupplierRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.CityCode == CityCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierRegisterCollection, filter, 0, null);
			}
			return _SupplierRegisterCollection;
		}
		
		// Return EntityCollection<SupplierRegisterEntity>
		public EntityCollection<SupplierRegisterEntity> SelectByCityCodeLST_Paged(string CityCode, int PageNumber, int PageSize)
		{
			EntityCollection<SupplierRegisterEntity> _SupplierRegisterCollection = new EntityCollection<SupplierRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.CityCode == CityCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierRegisterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _SupplierRegisterCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCityCodeRDT(string CityCode)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierRegisterCollection = new EntityCollection(new SupplierRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.CityCode == CityCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCityCodeRDT_Paged(string CityCode, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierRegisterCollection = new EntityCollection(new SupplierRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.CityCode == CityCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<SupplierRegisterEntity>
		public EntityCollection<SupplierRegisterEntity> SelectByDistrictCodeLST(string DistrictCode)
		{
			EntityCollection<SupplierRegisterEntity> _SupplierRegisterCollection = new EntityCollection<SupplierRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.DistrictCode == DistrictCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierRegisterCollection, filter, 0, null);
			}
			return _SupplierRegisterCollection;
		}
		
		// Return EntityCollection<SupplierRegisterEntity>
		public EntityCollection<SupplierRegisterEntity> SelectByDistrictCodeLST_Paged(string DistrictCode, int PageNumber, int PageSize)
		{
			EntityCollection<SupplierRegisterEntity> _SupplierRegisterCollection = new EntityCollection<SupplierRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.DistrictCode == DistrictCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierRegisterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _SupplierRegisterCollection;
		}
		
		// Return DataTable
		public DataTable SelectByDistrictCodeRDT(string DistrictCode)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierRegisterCollection = new EntityCollection(new SupplierRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.DistrictCode == DistrictCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByDistrictCodeRDT_Paged(string DistrictCode, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierRegisterCollection = new EntityCollection(new SupplierRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.DistrictCode == DistrictCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<SupplierRegisterEntity>
		public EntityCollection<SupplierRegisterEntity> SelectByAddressLST(string Address)
		{
			EntityCollection<SupplierRegisterEntity> _SupplierRegisterCollection = new EntityCollection<SupplierRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.Address == Address);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierRegisterCollection, filter, 0, null);
			}
			return _SupplierRegisterCollection;
		}
		
		// Return EntityCollection<SupplierRegisterEntity>
		public EntityCollection<SupplierRegisterEntity> SelectByAddressLST_Paged(string Address, int PageNumber, int PageSize)
		{
			EntityCollection<SupplierRegisterEntity> _SupplierRegisterCollection = new EntityCollection<SupplierRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.Address == Address);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierRegisterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _SupplierRegisterCollection;
		}
		
		// Return DataTable
		public DataTable SelectByAddressRDT(string Address)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierRegisterCollection = new EntityCollection(new SupplierRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.Address == Address);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByAddressRDT_Paged(string Address, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierRegisterCollection = new EntityCollection(new SupplierRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.Address == Address);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<SupplierRegisterEntity>
		public EntityCollection<SupplierRegisterEntity> SelectByAboutContentsLST(string AboutContents)
		{
			EntityCollection<SupplierRegisterEntity> _SupplierRegisterCollection = new EntityCollection<SupplierRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.AboutContents == AboutContents);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierRegisterCollection, filter, 0, null);
			}
			return _SupplierRegisterCollection;
		}
		
		// Return EntityCollection<SupplierRegisterEntity>
		public EntityCollection<SupplierRegisterEntity> SelectByAboutContentsLST_Paged(string AboutContents, int PageNumber, int PageSize)
		{
			EntityCollection<SupplierRegisterEntity> _SupplierRegisterCollection = new EntityCollection<SupplierRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.AboutContents == AboutContents);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierRegisterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _SupplierRegisterCollection;
		}
		
		// Return DataTable
		public DataTable SelectByAboutContentsRDT(string AboutContents)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierRegisterCollection = new EntityCollection(new SupplierRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.AboutContents == AboutContents);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByAboutContentsRDT_Paged(string AboutContents, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierRegisterCollection = new EntityCollection(new SupplierRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.AboutContents == AboutContents);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<SupplierRegisterEntity>
		public EntityCollection<SupplierRegisterEntity> SelectByApprovedLST(bool Approved)
		{
			EntityCollection<SupplierRegisterEntity> _SupplierRegisterCollection = new EntityCollection<SupplierRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.Approved == Approved);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierRegisterCollection, filter, 0, null);
			}
			return _SupplierRegisterCollection;
		}
		
		// Return EntityCollection<SupplierRegisterEntity>
		public EntityCollection<SupplierRegisterEntity> SelectByApprovedLST_Paged(bool Approved, int PageNumber, int PageSize)
		{
			EntityCollection<SupplierRegisterEntity> _SupplierRegisterCollection = new EntityCollection<SupplierRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.Approved == Approved);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierRegisterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _SupplierRegisterCollection;
		}
		
		// Return DataTable
		public DataTable SelectByApprovedRDT(bool Approved)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierRegisterCollection = new EntityCollection(new SupplierRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.Approved == Approved);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByApprovedRDT_Paged(bool Approved, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierRegisterCollection = new EntityCollection(new SupplierRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.Approved == Approved);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<SupplierRegisterEntity>
		public EntityCollection<SupplierRegisterEntity> SelectByAutomationCodeLST(string AutomationCode)
		{
			EntityCollection<SupplierRegisterEntity> _SupplierRegisterCollection = new EntityCollection<SupplierRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.AutomationCode == AutomationCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierRegisterCollection, filter, 0, null);
			}
			return _SupplierRegisterCollection;
		}
		
		// Return EntityCollection<SupplierRegisterEntity>
		public EntityCollection<SupplierRegisterEntity> SelectByAutomationCodeLST_Paged(string AutomationCode, int PageNumber, int PageSize)
		{
			EntityCollection<SupplierRegisterEntity> _SupplierRegisterCollection = new EntityCollection<SupplierRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.AutomationCode == AutomationCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierRegisterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _SupplierRegisterCollection;
		}
		
		// Return DataTable
		public DataTable SelectByAutomationCodeRDT(string AutomationCode)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierRegisterCollection = new EntityCollection(new SupplierRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.AutomationCode == AutomationCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByAutomationCodeRDT_Paged(string AutomationCode, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierRegisterCollection = new EntityCollection(new SupplierRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.AutomationCode == AutomationCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<SupplierRegisterEntity>
		public EntityCollection<SupplierRegisterEntity> SelectByCreatedDateLST(DateTime CreatedDate)
		{
			EntityCollection<SupplierRegisterEntity> _SupplierRegisterCollection = new EntityCollection<SupplierRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierRegisterCollection, filter, 0, null);
			}
			return _SupplierRegisterCollection;
		}
		
		// Return EntityCollection<SupplierRegisterEntity>
		public EntityCollection<SupplierRegisterEntity> SelectByCreatedDateLST_Paged(DateTime CreatedDate, int PageNumber, int PageSize)
		{
			EntityCollection<SupplierRegisterEntity> _SupplierRegisterCollection = new EntityCollection<SupplierRegisterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierRegisterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _SupplierRegisterCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedDateRDT(DateTime CreatedDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierRegisterCollection = new EntityCollection(new SupplierRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedDateRDT_Paged(DateTime CreatedDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierRegisterCollection = new EntityCollection(new SupplierRegisterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierRegisterFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierRegisterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
