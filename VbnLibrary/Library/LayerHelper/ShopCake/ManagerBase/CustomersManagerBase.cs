




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.CustomersManagerBase
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
	public class CustomersManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public CustomersManagerBase()
		{
			// Nothing for now.
		}
		
		public CustomersEntity Insert(CustomersEntity _CustomersEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_CustomersEntity, true);
			}
			return _CustomersEntity;
		}

		
		public CustomersEntity Insert(Guid Id, string UserName, string FullName, string Telphone, string Mobi, string Email, long Mark, string CountryCode, string CityCode, string DistrictCode, string Address)
		{
			CustomersEntity _CustomersEntity = new CustomersEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_CustomersEntity.Id = Id;
				_CustomersEntity.UserName = UserName;
				_CustomersEntity.FullName = FullName;
				_CustomersEntity.Telphone = Telphone;
				_CustomersEntity.Mobi = Mobi;
				_CustomersEntity.Email = Email;
				_CustomersEntity.Mark = Mark;
				_CustomersEntity.CountryCode = CountryCode;
				_CustomersEntity.CityCode = CityCode;
				_CustomersEntity.DistrictCode = DistrictCode;
				_CustomersEntity.Address = Address;
				adapter.SaveEntity(_CustomersEntity, true);
			}
			return _CustomersEntity;
		}

		public CustomersEntity Insert(string UserName, string FullName, string Telphone, string Mobi, string Email, long Mark, string CountryCode, string CityCode, string DistrictCode, string Address)
		{
			CustomersEntity _CustomersEntity = new CustomersEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_CustomersEntity.UserName = UserName;
				_CustomersEntity.FullName = FullName;
				_CustomersEntity.Telphone = Telphone;
				_CustomersEntity.Mobi = Mobi;
				_CustomersEntity.Email = Email;
				_CustomersEntity.Mark = Mark;
				_CustomersEntity.CountryCode = CountryCode;
				_CustomersEntity.CityCode = CityCode;
				_CustomersEntity.DistrictCode = DistrictCode;
				_CustomersEntity.Address = Address;
				adapter.SaveEntity(_CustomersEntity, true);
			}
			return _CustomersEntity;
		}

		public bool Update(CustomersEntity _CustomersEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(CustomersFields.Id == _CustomersEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_CustomersEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(CustomersEntity _CustomersEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_CustomersEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string UserName, string FullName, string Telphone, string Mobi, string Email, long Mark, string CountryCode, string CityCode, string DistrictCode, string Address)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				CustomersEntity _CustomersEntity = new CustomersEntity(Id);
				if (adapter.FetchEntity(_CustomersEntity))
				{
				
					_CustomersEntity.UserName = UserName;
					_CustomersEntity.FullName = FullName;
					_CustomersEntity.Telphone = Telphone;
					_CustomersEntity.Mobi = Mobi;
					_CustomersEntity.Email = Email;
					_CustomersEntity.Mark = Mark;
					_CustomersEntity.CountryCode = CountryCode;
					_CustomersEntity.CityCode = CityCode;
					_CustomersEntity.DistrictCode = DistrictCode;
					_CustomersEntity.Address = Address;
					adapter.SaveEntity(_CustomersEntity, true);
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
				CustomersEntity _CustomersEntity = new CustomersEntity(Id);
				if (adapter.FetchEntity(_CustomersEntity))
				{
					adapter.DeleteEntity(_CustomersEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("CustomersEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CustomersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByUserName(string UserName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.UserName == UserName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CustomersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByFullName(string FullName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.FullName == FullName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CustomersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTelphone(string Telphone)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.Telphone == Telphone);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CustomersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMobi(string Mobi)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.Mobi == Mobi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CustomersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByEmail(string Email)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.Email == Email);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CustomersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMark(long Mark)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.Mark == Mark);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CustomersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCountryCode(string CountryCode)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.CountryCode == CountryCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CustomersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCityCode(string CityCode)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.CityCode == CityCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CustomersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByDistrictCode(string DistrictCode)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.DistrictCode == DistrictCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CustomersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByAddress(string Address)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.Address == Address);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CustomersEntity", filter);
			}
			return toReturn;
		}
		

		
		public CustomersEntity SelectOne(Guid Id)
		{
			CustomersEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				CustomersEntity _CustomersEntity = new CustomersEntity(Id);
				if (adapter.FetchEntity(_CustomersEntity))
				{
					toReturn = _CustomersEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomersCollection = new EntityCollection(new CustomersEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomersCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<CustomersEntity>
		public EntityCollection<CustomersEntity> SelectAllLST()
		{
			EntityCollection<CustomersEntity> _CustomersCollection = new EntityCollection<CustomersEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomersCollection, null, 0, null);
			}
			return _CustomersCollection;
		}
		
		// Return EntityCollection<CustomersEntity>
		public EntityCollection<CustomersEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<CustomersEntity> _CustomersCollection = new EntityCollection<CustomersEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomersCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _CustomersCollection;
		}


		
		// Return EntityCollection<CustomersEntity>
		public EntityCollection<CustomersEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<CustomersEntity> _CustomersCollection = new EntityCollection<CustomersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomersCollection, filter, 0, null);
			}
			return _CustomersCollection;
		}
		
		// Return EntityCollection<CustomersEntity>
		public EntityCollection<CustomersEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<CustomersEntity> _CustomersCollection = new EntityCollection<CustomersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CustomersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomersCollection = new EntityCollection(new CustomersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomersCollection = new EntityCollection(new CustomersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<CustomersEntity>
		public EntityCollection<CustomersEntity> SelectByUserNameLST(string UserName)
		{
			EntityCollection<CustomersEntity> _CustomersCollection = new EntityCollection<CustomersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.UserName == UserName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomersCollection, filter, 0, null);
			}
			return _CustomersCollection;
		}
		
		// Return EntityCollection<CustomersEntity>
		public EntityCollection<CustomersEntity> SelectByUserNameLST_Paged(string UserName, int PageNumber, int PageSize)
		{
			EntityCollection<CustomersEntity> _CustomersCollection = new EntityCollection<CustomersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.UserName == UserName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CustomersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUserNameRDT(string UserName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomersCollection = new EntityCollection(new CustomersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.UserName == UserName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUserNameRDT_Paged(string UserName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomersCollection = new EntityCollection(new CustomersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.UserName == UserName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<CustomersEntity>
		public EntityCollection<CustomersEntity> SelectByFullNameLST(string FullName)
		{
			EntityCollection<CustomersEntity> _CustomersCollection = new EntityCollection<CustomersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.FullName == FullName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomersCollection, filter, 0, null);
			}
			return _CustomersCollection;
		}
		
		// Return EntityCollection<CustomersEntity>
		public EntityCollection<CustomersEntity> SelectByFullNameLST_Paged(string FullName, int PageNumber, int PageSize)
		{
			EntityCollection<CustomersEntity> _CustomersCollection = new EntityCollection<CustomersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.FullName == FullName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CustomersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByFullNameRDT(string FullName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomersCollection = new EntityCollection(new CustomersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.FullName == FullName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByFullNameRDT_Paged(string FullName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomersCollection = new EntityCollection(new CustomersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.FullName == FullName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<CustomersEntity>
		public EntityCollection<CustomersEntity> SelectByTelphoneLST(string Telphone)
		{
			EntityCollection<CustomersEntity> _CustomersCollection = new EntityCollection<CustomersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.Telphone == Telphone);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomersCollection, filter, 0, null);
			}
			return _CustomersCollection;
		}
		
		// Return EntityCollection<CustomersEntity>
		public EntityCollection<CustomersEntity> SelectByTelphoneLST_Paged(string Telphone, int PageNumber, int PageSize)
		{
			EntityCollection<CustomersEntity> _CustomersCollection = new EntityCollection<CustomersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.Telphone == Telphone);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CustomersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTelphoneRDT(string Telphone)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomersCollection = new EntityCollection(new CustomersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.Telphone == Telphone);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTelphoneRDT_Paged(string Telphone, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomersCollection = new EntityCollection(new CustomersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.Telphone == Telphone);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<CustomersEntity>
		public EntityCollection<CustomersEntity> SelectByMobiLST(string Mobi)
		{
			EntityCollection<CustomersEntity> _CustomersCollection = new EntityCollection<CustomersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.Mobi == Mobi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomersCollection, filter, 0, null);
			}
			return _CustomersCollection;
		}
		
		// Return EntityCollection<CustomersEntity>
		public EntityCollection<CustomersEntity> SelectByMobiLST_Paged(string Mobi, int PageNumber, int PageSize)
		{
			EntityCollection<CustomersEntity> _CustomersCollection = new EntityCollection<CustomersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.Mobi == Mobi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CustomersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMobiRDT(string Mobi)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomersCollection = new EntityCollection(new CustomersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.Mobi == Mobi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMobiRDT_Paged(string Mobi, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomersCollection = new EntityCollection(new CustomersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.Mobi == Mobi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<CustomersEntity>
		public EntityCollection<CustomersEntity> SelectByEmailLST(string Email)
		{
			EntityCollection<CustomersEntity> _CustomersCollection = new EntityCollection<CustomersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.Email == Email);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomersCollection, filter, 0, null);
			}
			return _CustomersCollection;
		}
		
		// Return EntityCollection<CustomersEntity>
		public EntityCollection<CustomersEntity> SelectByEmailLST_Paged(string Email, int PageNumber, int PageSize)
		{
			EntityCollection<CustomersEntity> _CustomersCollection = new EntityCollection<CustomersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.Email == Email);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CustomersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByEmailRDT(string Email)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomersCollection = new EntityCollection(new CustomersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.Email == Email);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByEmailRDT_Paged(string Email, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomersCollection = new EntityCollection(new CustomersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.Email == Email);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<CustomersEntity>
		public EntityCollection<CustomersEntity> SelectByMarkLST(long Mark)
		{
			EntityCollection<CustomersEntity> _CustomersCollection = new EntityCollection<CustomersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.Mark == Mark);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomersCollection, filter, 0, null);
			}
			return _CustomersCollection;
		}
		
		// Return EntityCollection<CustomersEntity>
		public EntityCollection<CustomersEntity> SelectByMarkLST_Paged(long Mark, int PageNumber, int PageSize)
		{
			EntityCollection<CustomersEntity> _CustomersCollection = new EntityCollection<CustomersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.Mark == Mark);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CustomersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMarkRDT(long Mark)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomersCollection = new EntityCollection(new CustomersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.Mark == Mark);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMarkRDT_Paged(long Mark, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomersCollection = new EntityCollection(new CustomersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.Mark == Mark);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<CustomersEntity>
		public EntityCollection<CustomersEntity> SelectByCountryCodeLST(string CountryCode)
		{
			EntityCollection<CustomersEntity> _CustomersCollection = new EntityCollection<CustomersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.CountryCode == CountryCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomersCollection, filter, 0, null);
			}
			return _CustomersCollection;
		}
		
		// Return EntityCollection<CustomersEntity>
		public EntityCollection<CustomersEntity> SelectByCountryCodeLST_Paged(string CountryCode, int PageNumber, int PageSize)
		{
			EntityCollection<CustomersEntity> _CustomersCollection = new EntityCollection<CustomersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.CountryCode == CountryCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CustomersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCountryCodeRDT(string CountryCode)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomersCollection = new EntityCollection(new CustomersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.CountryCode == CountryCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCountryCodeRDT_Paged(string CountryCode, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomersCollection = new EntityCollection(new CustomersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.CountryCode == CountryCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<CustomersEntity>
		public EntityCollection<CustomersEntity> SelectByCityCodeLST(string CityCode)
		{
			EntityCollection<CustomersEntity> _CustomersCollection = new EntityCollection<CustomersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.CityCode == CityCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomersCollection, filter, 0, null);
			}
			return _CustomersCollection;
		}
		
		// Return EntityCollection<CustomersEntity>
		public EntityCollection<CustomersEntity> SelectByCityCodeLST_Paged(string CityCode, int PageNumber, int PageSize)
		{
			EntityCollection<CustomersEntity> _CustomersCollection = new EntityCollection<CustomersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.CityCode == CityCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CustomersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCityCodeRDT(string CityCode)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomersCollection = new EntityCollection(new CustomersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.CityCode == CityCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCityCodeRDT_Paged(string CityCode, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomersCollection = new EntityCollection(new CustomersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.CityCode == CityCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<CustomersEntity>
		public EntityCollection<CustomersEntity> SelectByDistrictCodeLST(string DistrictCode)
		{
			EntityCollection<CustomersEntity> _CustomersCollection = new EntityCollection<CustomersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.DistrictCode == DistrictCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomersCollection, filter, 0, null);
			}
			return _CustomersCollection;
		}
		
		// Return EntityCollection<CustomersEntity>
		public EntityCollection<CustomersEntity> SelectByDistrictCodeLST_Paged(string DistrictCode, int PageNumber, int PageSize)
		{
			EntityCollection<CustomersEntity> _CustomersCollection = new EntityCollection<CustomersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.DistrictCode == DistrictCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CustomersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByDistrictCodeRDT(string DistrictCode)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomersCollection = new EntityCollection(new CustomersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.DistrictCode == DistrictCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByDistrictCodeRDT_Paged(string DistrictCode, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomersCollection = new EntityCollection(new CustomersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.DistrictCode == DistrictCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<CustomersEntity>
		public EntityCollection<CustomersEntity> SelectByAddressLST(string Address)
		{
			EntityCollection<CustomersEntity> _CustomersCollection = new EntityCollection<CustomersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.Address == Address);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomersCollection, filter, 0, null);
			}
			return _CustomersCollection;
		}
		
		// Return EntityCollection<CustomersEntity>
		public EntityCollection<CustomersEntity> SelectByAddressLST_Paged(string Address, int PageNumber, int PageSize)
		{
			EntityCollection<CustomersEntity> _CustomersCollection = new EntityCollection<CustomersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.Address == Address);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CustomersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByAddressRDT(string Address)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomersCollection = new EntityCollection(new CustomersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.Address == Address);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByAddressRDT_Paged(string Address, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomersCollection = new EntityCollection(new CustomersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomersFields.Address == Address);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
