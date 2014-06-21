




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.SupplierInfoManagerBase
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
	public class SupplierInfoManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public SupplierInfoManagerBase()
		{
			// Nothing for now.
		}
		
		public SupplierInfoEntity Insert(SupplierInfoEntity _SupplierInfoEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_SupplierInfoEntity, true);
			}
			return _SupplierInfoEntity;
		}

		
		public SupplierInfoEntity Insert(Guid Id, string Phone, string CountryCode, string CityCode, string DistrictCode, string Address, string AboutContents, string Lat, string Lng, int Zoom)
		{
			SupplierInfoEntity _SupplierInfoEntity = new SupplierInfoEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_SupplierInfoEntity.Id = Id;
				_SupplierInfoEntity.Phone = Phone;
				_SupplierInfoEntity.CountryCode = CountryCode;
				_SupplierInfoEntity.CityCode = CityCode;
				_SupplierInfoEntity.DistrictCode = DistrictCode;
				_SupplierInfoEntity.Address = Address;
				_SupplierInfoEntity.AboutContents = AboutContents;
				_SupplierInfoEntity.Lat = Lat;
				_SupplierInfoEntity.Lng = Lng;
				_SupplierInfoEntity.Zoom = Zoom;
				adapter.SaveEntity(_SupplierInfoEntity, true);
			}
			return _SupplierInfoEntity;
		}

		public SupplierInfoEntity Insert(string Phone, string CountryCode, string CityCode, string DistrictCode, string Address, string AboutContents, string Lat, string Lng, int Zoom)
		{
			SupplierInfoEntity _SupplierInfoEntity = new SupplierInfoEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_SupplierInfoEntity.Phone = Phone;
				_SupplierInfoEntity.CountryCode = CountryCode;
				_SupplierInfoEntity.CityCode = CityCode;
				_SupplierInfoEntity.DistrictCode = DistrictCode;
				_SupplierInfoEntity.Address = Address;
				_SupplierInfoEntity.AboutContents = AboutContents;
				_SupplierInfoEntity.Lat = Lat;
				_SupplierInfoEntity.Lng = Lng;
				_SupplierInfoEntity.Zoom = Zoom;
				adapter.SaveEntity(_SupplierInfoEntity, true);
			}
			return _SupplierInfoEntity;
		}

		public bool Update(SupplierInfoEntity _SupplierInfoEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(SupplierInfoFields.Id == _SupplierInfoEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_SupplierInfoEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(SupplierInfoEntity _SupplierInfoEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_SupplierInfoEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string Phone, string CountryCode, string CityCode, string DistrictCode, string Address, string AboutContents, string Lat, string Lng, int Zoom)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				SupplierInfoEntity _SupplierInfoEntity = new SupplierInfoEntity(Id);
				if (adapter.FetchEntity(_SupplierInfoEntity))
				{
				
					_SupplierInfoEntity.Phone = Phone;
					_SupplierInfoEntity.CountryCode = CountryCode;
					_SupplierInfoEntity.CityCode = CityCode;
					_SupplierInfoEntity.DistrictCode = DistrictCode;
					_SupplierInfoEntity.Address = Address;
					_SupplierInfoEntity.AboutContents = AboutContents;
					_SupplierInfoEntity.Lat = Lat;
					_SupplierInfoEntity.Lng = Lng;
					_SupplierInfoEntity.Zoom = Zoom;
					adapter.SaveEntity(_SupplierInfoEntity, true);
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
				SupplierInfoEntity _SupplierInfoEntity = new SupplierInfoEntity(Id);
				if (adapter.FetchEntity(_SupplierInfoEntity))
				{
					adapter.DeleteEntity(_SupplierInfoEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("SupplierInfoEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SupplierInfoEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPhone(string Phone)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.Phone == Phone);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SupplierInfoEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCountryCode(string CountryCode)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.CountryCode == CountryCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SupplierInfoEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCityCode(string CityCode)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.CityCode == CityCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SupplierInfoEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByDistrictCode(string DistrictCode)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.DistrictCode == DistrictCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SupplierInfoEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByAddress(string Address)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.Address == Address);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SupplierInfoEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByAboutContents(string AboutContents)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.AboutContents == AboutContents);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SupplierInfoEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLat(string Lat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.Lat == Lat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SupplierInfoEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLng(string Lng)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.Lng == Lng);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SupplierInfoEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByZoom(int Zoom)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.Zoom == Zoom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SupplierInfoEntity", filter);
			}
			return toReturn;
		}
		

		
		public SupplierInfoEntity SelectOne(Guid Id)
		{
			SupplierInfoEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				SupplierInfoEntity _SupplierInfoEntity = new SupplierInfoEntity(Id);
				if (adapter.FetchEntity(_SupplierInfoEntity))
				{
					toReturn = _SupplierInfoEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierInfoCollection = new EntityCollection(new SupplierInfoEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierInfoCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<SupplierInfoEntity>
		public EntityCollection<SupplierInfoEntity> SelectAllLST()
		{
			EntityCollection<SupplierInfoEntity> _SupplierInfoCollection = new EntityCollection<SupplierInfoEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierInfoCollection, null, 0, null);
			}
			return _SupplierInfoCollection;
		}
		
		// Return EntityCollection<SupplierInfoEntity>
		public EntityCollection<SupplierInfoEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<SupplierInfoEntity> _SupplierInfoCollection = new EntityCollection<SupplierInfoEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierInfoCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _SupplierInfoCollection;
		}


		
		// Return EntityCollection<SupplierInfoEntity>
		public EntityCollection<SupplierInfoEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<SupplierInfoEntity> _SupplierInfoCollection = new EntityCollection<SupplierInfoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierInfoCollection, filter, 0, null);
			}
			return _SupplierInfoCollection;
		}
		
		// Return EntityCollection<SupplierInfoEntity>
		public EntityCollection<SupplierInfoEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<SupplierInfoEntity> _SupplierInfoCollection = new EntityCollection<SupplierInfoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierInfoCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _SupplierInfoCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierInfoCollection = new EntityCollection(new SupplierInfoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierInfoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierInfoCollection = new EntityCollection(new SupplierInfoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierInfoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<SupplierInfoEntity>
		public EntityCollection<SupplierInfoEntity> SelectByPhoneLST(string Phone)
		{
			EntityCollection<SupplierInfoEntity> _SupplierInfoCollection = new EntityCollection<SupplierInfoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.Phone == Phone);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierInfoCollection, filter, 0, null);
			}
			return _SupplierInfoCollection;
		}
		
		// Return EntityCollection<SupplierInfoEntity>
		public EntityCollection<SupplierInfoEntity> SelectByPhoneLST_Paged(string Phone, int PageNumber, int PageSize)
		{
			EntityCollection<SupplierInfoEntity> _SupplierInfoCollection = new EntityCollection<SupplierInfoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.Phone == Phone);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierInfoCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _SupplierInfoCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPhoneRDT(string Phone)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierInfoCollection = new EntityCollection(new SupplierInfoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.Phone == Phone);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierInfoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPhoneRDT_Paged(string Phone, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierInfoCollection = new EntityCollection(new SupplierInfoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.Phone == Phone);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierInfoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<SupplierInfoEntity>
		public EntityCollection<SupplierInfoEntity> SelectByCountryCodeLST(string CountryCode)
		{
			EntityCollection<SupplierInfoEntity> _SupplierInfoCollection = new EntityCollection<SupplierInfoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.CountryCode == CountryCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierInfoCollection, filter, 0, null);
			}
			return _SupplierInfoCollection;
		}
		
		// Return EntityCollection<SupplierInfoEntity>
		public EntityCollection<SupplierInfoEntity> SelectByCountryCodeLST_Paged(string CountryCode, int PageNumber, int PageSize)
		{
			EntityCollection<SupplierInfoEntity> _SupplierInfoCollection = new EntityCollection<SupplierInfoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.CountryCode == CountryCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierInfoCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _SupplierInfoCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCountryCodeRDT(string CountryCode)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierInfoCollection = new EntityCollection(new SupplierInfoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.CountryCode == CountryCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierInfoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCountryCodeRDT_Paged(string CountryCode, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierInfoCollection = new EntityCollection(new SupplierInfoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.CountryCode == CountryCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierInfoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<SupplierInfoEntity>
		public EntityCollection<SupplierInfoEntity> SelectByCityCodeLST(string CityCode)
		{
			EntityCollection<SupplierInfoEntity> _SupplierInfoCollection = new EntityCollection<SupplierInfoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.CityCode == CityCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierInfoCollection, filter, 0, null);
			}
			return _SupplierInfoCollection;
		}
		
		// Return EntityCollection<SupplierInfoEntity>
		public EntityCollection<SupplierInfoEntity> SelectByCityCodeLST_Paged(string CityCode, int PageNumber, int PageSize)
		{
			EntityCollection<SupplierInfoEntity> _SupplierInfoCollection = new EntityCollection<SupplierInfoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.CityCode == CityCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierInfoCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _SupplierInfoCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCityCodeRDT(string CityCode)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierInfoCollection = new EntityCollection(new SupplierInfoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.CityCode == CityCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierInfoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCityCodeRDT_Paged(string CityCode, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierInfoCollection = new EntityCollection(new SupplierInfoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.CityCode == CityCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierInfoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<SupplierInfoEntity>
		public EntityCollection<SupplierInfoEntity> SelectByDistrictCodeLST(string DistrictCode)
		{
			EntityCollection<SupplierInfoEntity> _SupplierInfoCollection = new EntityCollection<SupplierInfoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.DistrictCode == DistrictCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierInfoCollection, filter, 0, null);
			}
			return _SupplierInfoCollection;
		}
		
		// Return EntityCollection<SupplierInfoEntity>
		public EntityCollection<SupplierInfoEntity> SelectByDistrictCodeLST_Paged(string DistrictCode, int PageNumber, int PageSize)
		{
			EntityCollection<SupplierInfoEntity> _SupplierInfoCollection = new EntityCollection<SupplierInfoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.DistrictCode == DistrictCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierInfoCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _SupplierInfoCollection;
		}
		
		// Return DataTable
		public DataTable SelectByDistrictCodeRDT(string DistrictCode)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierInfoCollection = new EntityCollection(new SupplierInfoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.DistrictCode == DistrictCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierInfoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByDistrictCodeRDT_Paged(string DistrictCode, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierInfoCollection = new EntityCollection(new SupplierInfoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.DistrictCode == DistrictCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierInfoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<SupplierInfoEntity>
		public EntityCollection<SupplierInfoEntity> SelectByAddressLST(string Address)
		{
			EntityCollection<SupplierInfoEntity> _SupplierInfoCollection = new EntityCollection<SupplierInfoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.Address == Address);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierInfoCollection, filter, 0, null);
			}
			return _SupplierInfoCollection;
		}
		
		// Return EntityCollection<SupplierInfoEntity>
		public EntityCollection<SupplierInfoEntity> SelectByAddressLST_Paged(string Address, int PageNumber, int PageSize)
		{
			EntityCollection<SupplierInfoEntity> _SupplierInfoCollection = new EntityCollection<SupplierInfoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.Address == Address);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierInfoCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _SupplierInfoCollection;
		}
		
		// Return DataTable
		public DataTable SelectByAddressRDT(string Address)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierInfoCollection = new EntityCollection(new SupplierInfoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.Address == Address);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierInfoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByAddressRDT_Paged(string Address, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierInfoCollection = new EntityCollection(new SupplierInfoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.Address == Address);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierInfoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<SupplierInfoEntity>
		public EntityCollection<SupplierInfoEntity> SelectByAboutContentsLST(string AboutContents)
		{
			EntityCollection<SupplierInfoEntity> _SupplierInfoCollection = new EntityCollection<SupplierInfoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.AboutContents == AboutContents);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierInfoCollection, filter, 0, null);
			}
			return _SupplierInfoCollection;
		}
		
		// Return EntityCollection<SupplierInfoEntity>
		public EntityCollection<SupplierInfoEntity> SelectByAboutContentsLST_Paged(string AboutContents, int PageNumber, int PageSize)
		{
			EntityCollection<SupplierInfoEntity> _SupplierInfoCollection = new EntityCollection<SupplierInfoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.AboutContents == AboutContents);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierInfoCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _SupplierInfoCollection;
		}
		
		// Return DataTable
		public DataTable SelectByAboutContentsRDT(string AboutContents)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierInfoCollection = new EntityCollection(new SupplierInfoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.AboutContents == AboutContents);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierInfoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByAboutContentsRDT_Paged(string AboutContents, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierInfoCollection = new EntityCollection(new SupplierInfoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.AboutContents == AboutContents);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierInfoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<SupplierInfoEntity>
		public EntityCollection<SupplierInfoEntity> SelectByLatLST(string Lat)
		{
			EntityCollection<SupplierInfoEntity> _SupplierInfoCollection = new EntityCollection<SupplierInfoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.Lat == Lat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierInfoCollection, filter, 0, null);
			}
			return _SupplierInfoCollection;
		}
		
		// Return EntityCollection<SupplierInfoEntity>
		public EntityCollection<SupplierInfoEntity> SelectByLatLST_Paged(string Lat, int PageNumber, int PageSize)
		{
			EntityCollection<SupplierInfoEntity> _SupplierInfoCollection = new EntityCollection<SupplierInfoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.Lat == Lat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierInfoCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _SupplierInfoCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLatRDT(string Lat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierInfoCollection = new EntityCollection(new SupplierInfoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.Lat == Lat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierInfoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLatRDT_Paged(string Lat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierInfoCollection = new EntityCollection(new SupplierInfoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.Lat == Lat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierInfoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<SupplierInfoEntity>
		public EntityCollection<SupplierInfoEntity> SelectByLngLST(string Lng)
		{
			EntityCollection<SupplierInfoEntity> _SupplierInfoCollection = new EntityCollection<SupplierInfoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.Lng == Lng);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierInfoCollection, filter, 0, null);
			}
			return _SupplierInfoCollection;
		}
		
		// Return EntityCollection<SupplierInfoEntity>
		public EntityCollection<SupplierInfoEntity> SelectByLngLST_Paged(string Lng, int PageNumber, int PageSize)
		{
			EntityCollection<SupplierInfoEntity> _SupplierInfoCollection = new EntityCollection<SupplierInfoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.Lng == Lng);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierInfoCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _SupplierInfoCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLngRDT(string Lng)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierInfoCollection = new EntityCollection(new SupplierInfoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.Lng == Lng);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierInfoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLngRDT_Paged(string Lng, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierInfoCollection = new EntityCollection(new SupplierInfoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.Lng == Lng);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierInfoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<SupplierInfoEntity>
		public EntityCollection<SupplierInfoEntity> SelectByZoomLST(int Zoom)
		{
			EntityCollection<SupplierInfoEntity> _SupplierInfoCollection = new EntityCollection<SupplierInfoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.Zoom == Zoom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierInfoCollection, filter, 0, null);
			}
			return _SupplierInfoCollection;
		}
		
		// Return EntityCollection<SupplierInfoEntity>
		public EntityCollection<SupplierInfoEntity> SelectByZoomLST_Paged(int Zoom, int PageNumber, int PageSize)
		{
			EntityCollection<SupplierInfoEntity> _SupplierInfoCollection = new EntityCollection<SupplierInfoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.Zoom == Zoom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SupplierInfoCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _SupplierInfoCollection;
		}
		
		// Return DataTable
		public DataTable SelectByZoomRDT(int Zoom)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierInfoCollection = new EntityCollection(new SupplierInfoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.Zoom == Zoom);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierInfoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByZoomRDT_Paged(int Zoom, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SupplierInfoCollection = new EntityCollection(new SupplierInfoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SupplierInfoFields.Zoom == Zoom);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SupplierInfoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
