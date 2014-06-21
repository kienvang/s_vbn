


/*
'===============================================================================
'  LayerHelper.ShopCake.BL.AdvertsManagerBase
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
	public class AdvertsManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public AdvertsManagerBase()
		{
			// Nothing for now.
		}
		
		public AdvertsEntity Insert(AdvertsEntity _AdvertsEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_AdvertsEntity, true);
			}
			return _AdvertsEntity;
		}

		
		public AdvertsEntity Insert(Guid Id, string AdvertName, DateTime BeginDate, DateTime EndDate, bool IsVisible, string Path, string AddressUrl, int Width, int Height, string Type, DateTime CreatedDate, string CreatedBy, DateTime UpdatedDate, string UpdatedBy)
		{
			AdvertsEntity _AdvertsEntity = new AdvertsEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_AdvertsEntity.Id = Id;
				_AdvertsEntity.AdvertName = AdvertName;
				_AdvertsEntity.BeginDate = BeginDate;
				_AdvertsEntity.EndDate = EndDate;
				_AdvertsEntity.IsVisible = IsVisible;
				_AdvertsEntity.Path = Path;
				_AdvertsEntity.AddressUrl = AddressUrl;
				_AdvertsEntity.Width = Width;
				_AdvertsEntity.Height = Height;
				_AdvertsEntity.Type = Type;
				_AdvertsEntity.CreatedDate = CreatedDate;
				_AdvertsEntity.CreatedBy = CreatedBy;
				_AdvertsEntity.UpdatedDate = UpdatedDate;
				_AdvertsEntity.UpdatedBy = UpdatedBy;
				adapter.SaveEntity(_AdvertsEntity, true);
			}
			return _AdvertsEntity;
		}

		public AdvertsEntity Insert(string AdvertName, DateTime BeginDate, DateTime EndDate, bool IsVisible, string Path, string AddressUrl, int Width, int Height, string Type, DateTime CreatedDate, string CreatedBy, DateTime UpdatedDate, string UpdatedBy)
		{
			AdvertsEntity _AdvertsEntity = new AdvertsEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_AdvertsEntity.AdvertName = AdvertName;
				_AdvertsEntity.BeginDate = BeginDate;
				_AdvertsEntity.EndDate = EndDate;
				_AdvertsEntity.IsVisible = IsVisible;
				_AdvertsEntity.Path = Path;
				_AdvertsEntity.AddressUrl = AddressUrl;
				_AdvertsEntity.Width = Width;
				_AdvertsEntity.Height = Height;
				_AdvertsEntity.Type = Type;
				_AdvertsEntity.CreatedDate = CreatedDate;
				_AdvertsEntity.CreatedBy = CreatedBy;
				_AdvertsEntity.UpdatedDate = UpdatedDate;
				_AdvertsEntity.UpdatedBy = UpdatedBy;
				adapter.SaveEntity(_AdvertsEntity, true);
			}
			return _AdvertsEntity;
		}

		public bool Update(AdvertsEntity _AdvertsEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(AdvertsFields.Id == _AdvertsEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_AdvertsEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(AdvertsEntity _AdvertsEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_AdvertsEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string AdvertName, DateTime BeginDate, DateTime EndDate, bool IsVisible, string Path, string AddressUrl, int Width, int Height, string Type, DateTime CreatedDate, string CreatedBy, DateTime UpdatedDate, string UpdatedBy)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				AdvertsEntity _AdvertsEntity = new AdvertsEntity(Id);
				if (adapter.FetchEntity(_AdvertsEntity))
				{
				
					_AdvertsEntity.AdvertName = AdvertName;
					_AdvertsEntity.BeginDate = BeginDate;
					_AdvertsEntity.EndDate = EndDate;
					_AdvertsEntity.IsVisible = IsVisible;
					_AdvertsEntity.Path = Path;
					_AdvertsEntity.AddressUrl = AddressUrl;
					_AdvertsEntity.Width = Width;
					_AdvertsEntity.Height = Height;
					_AdvertsEntity.Type = Type;
					_AdvertsEntity.CreatedDate = CreatedDate;
					_AdvertsEntity.CreatedBy = CreatedBy;
					_AdvertsEntity.UpdatedDate = UpdatedDate;
					_AdvertsEntity.UpdatedBy = UpdatedBy;
					adapter.SaveEntity(_AdvertsEntity, true);
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
				AdvertsEntity _AdvertsEntity = new AdvertsEntity(Id);
				if (adapter.FetchEntity(_AdvertsEntity))
				{
					adapter.DeleteEntity(_AdvertsEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("AdvertsEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AdvertsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByAdvertName(string AdvertName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.AdvertName == AdvertName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AdvertsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByBeginDate(DateTime BeginDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.BeginDate == BeginDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AdvertsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByEndDate(DateTime EndDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.EndDate == EndDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AdvertsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIsVisible(bool IsVisible)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.IsVisible == IsVisible);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AdvertsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPath(string Path)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.Path == Path);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AdvertsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByAddressUrl(string AddressUrl)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.AddressUrl == AddressUrl);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AdvertsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByWidth(int Width)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.Width == Width);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AdvertsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByHeight(int Height)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.Height == Height);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AdvertsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByType(string Type)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.Type == Type);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AdvertsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCreatedDate(DateTime CreatedDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AdvertsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCreatedBy(string CreatedBy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AdvertsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByUpdatedDate(DateTime UpdatedDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AdvertsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByUpdatedBy(string UpdatedBy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AdvertsEntity", filter);
			}
			return toReturn;
		}
		

		
		public AdvertsEntity SelectOne(Guid Id)
		{
			AdvertsEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				AdvertsEntity _AdvertsEntity = new AdvertsEntity(Id);
				if (adapter.FetchEntity(_AdvertsEntity))
				{
					toReturn = _AdvertsEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsCollection = new EntityCollection(new AdvertsEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<AdvertsEntity>
		public EntityCollection<AdvertsEntity> SelectAllLST()
		{
			EntityCollection<AdvertsEntity> _AdvertsCollection = new EntityCollection<AdvertsEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsCollection, null, 0, null);
			}
			return _AdvertsCollection;
		}
		
		// Return EntityCollection<AdvertsEntity>
		public EntityCollection<AdvertsEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<AdvertsEntity> _AdvertsCollection = new EntityCollection<AdvertsEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _AdvertsCollection;
		}


		
		// Return EntityCollection<AdvertsEntity>
		public EntityCollection<AdvertsEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<AdvertsEntity> _AdvertsCollection = new EntityCollection<AdvertsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsCollection, filter, 0, null);
			}
			return _AdvertsCollection;
		}
		
		// Return EntityCollection<AdvertsEntity>
		public EntityCollection<AdvertsEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<AdvertsEntity> _AdvertsCollection = new EntityCollection<AdvertsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AdvertsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsCollection = new EntityCollection(new AdvertsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsCollection = new EntityCollection(new AdvertsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AdvertsEntity>
		public EntityCollection<AdvertsEntity> SelectByAdvertNameLST(string AdvertName)
		{
			EntityCollection<AdvertsEntity> _AdvertsCollection = new EntityCollection<AdvertsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.AdvertName == AdvertName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsCollection, filter, 0, null);
			}
			return _AdvertsCollection;
		}
		
		// Return EntityCollection<AdvertsEntity>
		public EntityCollection<AdvertsEntity> SelectByAdvertNameLST_Paged(string AdvertName, int PageNumber, int PageSize)
		{
			EntityCollection<AdvertsEntity> _AdvertsCollection = new EntityCollection<AdvertsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.AdvertName == AdvertName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AdvertsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByAdvertNameRDT(string AdvertName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsCollection = new EntityCollection(new AdvertsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.AdvertName == AdvertName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByAdvertNameRDT_Paged(string AdvertName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsCollection = new EntityCollection(new AdvertsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.AdvertName == AdvertName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AdvertsEntity>
		public EntityCollection<AdvertsEntity> SelectByBeginDateLST(DateTime BeginDate)
		{
			EntityCollection<AdvertsEntity> _AdvertsCollection = new EntityCollection<AdvertsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.BeginDate == BeginDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsCollection, filter, 0, null);
			}
			return _AdvertsCollection;
		}
		
		// Return EntityCollection<AdvertsEntity>
		public EntityCollection<AdvertsEntity> SelectByBeginDateLST_Paged(DateTime BeginDate, int PageNumber, int PageSize)
		{
			EntityCollection<AdvertsEntity> _AdvertsCollection = new EntityCollection<AdvertsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.BeginDate == BeginDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AdvertsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByBeginDateRDT(DateTime BeginDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsCollection = new EntityCollection(new AdvertsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.BeginDate == BeginDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByBeginDateRDT_Paged(DateTime BeginDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsCollection = new EntityCollection(new AdvertsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.BeginDate == BeginDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AdvertsEntity>
		public EntityCollection<AdvertsEntity> SelectByEndDateLST(DateTime EndDate)
		{
			EntityCollection<AdvertsEntity> _AdvertsCollection = new EntityCollection<AdvertsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.EndDate == EndDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsCollection, filter, 0, null);
			}
			return _AdvertsCollection;
		}
		
		// Return EntityCollection<AdvertsEntity>
		public EntityCollection<AdvertsEntity> SelectByEndDateLST_Paged(DateTime EndDate, int PageNumber, int PageSize)
		{
			EntityCollection<AdvertsEntity> _AdvertsCollection = new EntityCollection<AdvertsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.EndDate == EndDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AdvertsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByEndDateRDT(DateTime EndDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsCollection = new EntityCollection(new AdvertsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.EndDate == EndDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByEndDateRDT_Paged(DateTime EndDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsCollection = new EntityCollection(new AdvertsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.EndDate == EndDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AdvertsEntity>
		public EntityCollection<AdvertsEntity> SelectByIsVisibleLST(bool IsVisible)
		{
			EntityCollection<AdvertsEntity> _AdvertsCollection = new EntityCollection<AdvertsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.IsVisible == IsVisible);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsCollection, filter, 0, null);
			}
			return _AdvertsCollection;
		}
		
		// Return EntityCollection<AdvertsEntity>
		public EntityCollection<AdvertsEntity> SelectByIsVisibleLST_Paged(bool IsVisible, int PageNumber, int PageSize)
		{
			EntityCollection<AdvertsEntity> _AdvertsCollection = new EntityCollection<AdvertsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.IsVisible == IsVisible);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AdvertsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIsVisibleRDT(bool IsVisible)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsCollection = new EntityCollection(new AdvertsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.IsVisible == IsVisible);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIsVisibleRDT_Paged(bool IsVisible, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsCollection = new EntityCollection(new AdvertsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.IsVisible == IsVisible);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AdvertsEntity>
		public EntityCollection<AdvertsEntity> SelectByPathLST(string Path)
		{
			EntityCollection<AdvertsEntity> _AdvertsCollection = new EntityCollection<AdvertsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.Path == Path);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsCollection, filter, 0, null);
			}
			return _AdvertsCollection;
		}
		
		// Return EntityCollection<AdvertsEntity>
		public EntityCollection<AdvertsEntity> SelectByPathLST_Paged(string Path, int PageNumber, int PageSize)
		{
			EntityCollection<AdvertsEntity> _AdvertsCollection = new EntityCollection<AdvertsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.Path == Path);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AdvertsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPathRDT(string Path)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsCollection = new EntityCollection(new AdvertsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.Path == Path);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPathRDT_Paged(string Path, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsCollection = new EntityCollection(new AdvertsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.Path == Path);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AdvertsEntity>
		public EntityCollection<AdvertsEntity> SelectByAddressUrlLST(string AddressUrl)
		{
			EntityCollection<AdvertsEntity> _AdvertsCollection = new EntityCollection<AdvertsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.AddressUrl == AddressUrl);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsCollection, filter, 0, null);
			}
			return _AdvertsCollection;
		}
		
		// Return EntityCollection<AdvertsEntity>
		public EntityCollection<AdvertsEntity> SelectByAddressUrlLST_Paged(string AddressUrl, int PageNumber, int PageSize)
		{
			EntityCollection<AdvertsEntity> _AdvertsCollection = new EntityCollection<AdvertsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.AddressUrl == AddressUrl);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AdvertsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByAddressUrlRDT(string AddressUrl)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsCollection = new EntityCollection(new AdvertsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.AddressUrl == AddressUrl);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByAddressUrlRDT_Paged(string AddressUrl, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsCollection = new EntityCollection(new AdvertsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.AddressUrl == AddressUrl);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AdvertsEntity>
		public EntityCollection<AdvertsEntity> SelectByWidthLST(int Width)
		{
			EntityCollection<AdvertsEntity> _AdvertsCollection = new EntityCollection<AdvertsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.Width == Width);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsCollection, filter, 0, null);
			}
			return _AdvertsCollection;
		}
		
		// Return EntityCollection<AdvertsEntity>
		public EntityCollection<AdvertsEntity> SelectByWidthLST_Paged(int Width, int PageNumber, int PageSize)
		{
			EntityCollection<AdvertsEntity> _AdvertsCollection = new EntityCollection<AdvertsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.Width == Width);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AdvertsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByWidthRDT(int Width)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsCollection = new EntityCollection(new AdvertsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.Width == Width);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByWidthRDT_Paged(int Width, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsCollection = new EntityCollection(new AdvertsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.Width == Width);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AdvertsEntity>
		public EntityCollection<AdvertsEntity> SelectByHeightLST(int Height)
		{
			EntityCollection<AdvertsEntity> _AdvertsCollection = new EntityCollection<AdvertsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.Height == Height);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsCollection, filter, 0, null);
			}
			return _AdvertsCollection;
		}
		
		// Return EntityCollection<AdvertsEntity>
		public EntityCollection<AdvertsEntity> SelectByHeightLST_Paged(int Height, int PageNumber, int PageSize)
		{
			EntityCollection<AdvertsEntity> _AdvertsCollection = new EntityCollection<AdvertsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.Height == Height);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AdvertsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByHeightRDT(int Height)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsCollection = new EntityCollection(new AdvertsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.Height == Height);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByHeightRDT_Paged(int Height, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsCollection = new EntityCollection(new AdvertsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.Height == Height);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AdvertsEntity>
		public EntityCollection<AdvertsEntity> SelectByTypeLST(string Type)
		{
			EntityCollection<AdvertsEntity> _AdvertsCollection = new EntityCollection<AdvertsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.Type == Type);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsCollection, filter, 0, null);
			}
			return _AdvertsCollection;
		}
		
		// Return EntityCollection<AdvertsEntity>
		public EntityCollection<AdvertsEntity> SelectByTypeLST_Paged(string Type, int PageNumber, int PageSize)
		{
			EntityCollection<AdvertsEntity> _AdvertsCollection = new EntityCollection<AdvertsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.Type == Type);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AdvertsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTypeRDT(string Type)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsCollection = new EntityCollection(new AdvertsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.Type == Type);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTypeRDT_Paged(string Type, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsCollection = new EntityCollection(new AdvertsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.Type == Type);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AdvertsEntity>
		public EntityCollection<AdvertsEntity> SelectByCreatedDateLST(DateTime CreatedDate)
		{
			EntityCollection<AdvertsEntity> _AdvertsCollection = new EntityCollection<AdvertsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsCollection, filter, 0, null);
			}
			return _AdvertsCollection;
		}
		
		// Return EntityCollection<AdvertsEntity>
		public EntityCollection<AdvertsEntity> SelectByCreatedDateLST_Paged(DateTime CreatedDate, int PageNumber, int PageSize)
		{
			EntityCollection<AdvertsEntity> _AdvertsCollection = new EntityCollection<AdvertsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AdvertsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedDateRDT(DateTime CreatedDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsCollection = new EntityCollection(new AdvertsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedDateRDT_Paged(DateTime CreatedDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsCollection = new EntityCollection(new AdvertsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AdvertsEntity>
		public EntityCollection<AdvertsEntity> SelectByCreatedByLST(string CreatedBy)
		{
			EntityCollection<AdvertsEntity> _AdvertsCollection = new EntityCollection<AdvertsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsCollection, filter, 0, null);
			}
			return _AdvertsCollection;
		}
		
		// Return EntityCollection<AdvertsEntity>
		public EntityCollection<AdvertsEntity> SelectByCreatedByLST_Paged(string CreatedBy, int PageNumber, int PageSize)
		{
			EntityCollection<AdvertsEntity> _AdvertsCollection = new EntityCollection<AdvertsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AdvertsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedByRDT(string CreatedBy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsCollection = new EntityCollection(new AdvertsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedByRDT_Paged(string CreatedBy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsCollection = new EntityCollection(new AdvertsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AdvertsEntity>
		public EntityCollection<AdvertsEntity> SelectByUpdatedDateLST(DateTime UpdatedDate)
		{
			EntityCollection<AdvertsEntity> _AdvertsCollection = new EntityCollection<AdvertsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsCollection, filter, 0, null);
			}
			return _AdvertsCollection;
		}
		
		// Return EntityCollection<AdvertsEntity>
		public EntityCollection<AdvertsEntity> SelectByUpdatedDateLST_Paged(DateTime UpdatedDate, int PageNumber, int PageSize)
		{
			EntityCollection<AdvertsEntity> _AdvertsCollection = new EntityCollection<AdvertsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AdvertsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedDateRDT(DateTime UpdatedDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsCollection = new EntityCollection(new AdvertsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedDateRDT_Paged(DateTime UpdatedDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsCollection = new EntityCollection(new AdvertsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AdvertsEntity>
		public EntityCollection<AdvertsEntity> SelectByUpdatedByLST(string UpdatedBy)
		{
			EntityCollection<AdvertsEntity> _AdvertsCollection = new EntityCollection<AdvertsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsCollection, filter, 0, null);
			}
			return _AdvertsCollection;
		}
		
		// Return EntityCollection<AdvertsEntity>
		public EntityCollection<AdvertsEntity> SelectByUpdatedByLST_Paged(string UpdatedBy, int PageNumber, int PageSize)
		{
			EntityCollection<AdvertsEntity> _AdvertsCollection = new EntityCollection<AdvertsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AdvertsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedByRDT(string UpdatedBy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsCollection = new EntityCollection(new AdvertsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedByRDT_Paged(string UpdatedBy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsCollection = new EntityCollection(new AdvertsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
