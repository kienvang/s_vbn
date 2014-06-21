




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.AdvertsPositionManagerBase
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
	public class AdvertsPositionManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public AdvertsPositionManagerBase()
		{
			// Nothing for now.
		}
		
		public AdvertsPositionEntity Insert(AdvertsPositionEntity _AdvertsPositionEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_AdvertsPositionEntity, true);
			}
			return _AdvertsPositionEntity;
		}

		
		public AdvertsPositionEntity Insert(Guid Id, string GroupName, string PositionId, int OrderIndex, int Width, int Height, int NumberOfGroup, bool IsVisible, string PositionTypeId, bool IsSingle)
		{
			AdvertsPositionEntity _AdvertsPositionEntity = new AdvertsPositionEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_AdvertsPositionEntity.Id = Id;
				_AdvertsPositionEntity.GroupName = GroupName;
				_AdvertsPositionEntity.PositionId = PositionId;
				_AdvertsPositionEntity.OrderIndex = OrderIndex;
				_AdvertsPositionEntity.Width = Width;
				_AdvertsPositionEntity.Height = Height;
				_AdvertsPositionEntity.NumberOfGroup = NumberOfGroup;
				_AdvertsPositionEntity.IsVisible = IsVisible;
				_AdvertsPositionEntity.PositionTypeId = PositionTypeId;
				_AdvertsPositionEntity.IsSingle = IsSingle;
				adapter.SaveEntity(_AdvertsPositionEntity, true);
			}
			return _AdvertsPositionEntity;
		}

		public AdvertsPositionEntity Insert(string GroupName, string PositionId, int OrderIndex, int Width, int Height, int NumberOfGroup, bool IsVisible, string PositionTypeId, bool IsSingle)
		{
			AdvertsPositionEntity _AdvertsPositionEntity = new AdvertsPositionEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_AdvertsPositionEntity.GroupName = GroupName;
				_AdvertsPositionEntity.PositionId = PositionId;
				_AdvertsPositionEntity.OrderIndex = OrderIndex;
				_AdvertsPositionEntity.Width = Width;
				_AdvertsPositionEntity.Height = Height;
				_AdvertsPositionEntity.NumberOfGroup = NumberOfGroup;
				_AdvertsPositionEntity.IsVisible = IsVisible;
				_AdvertsPositionEntity.PositionTypeId = PositionTypeId;
				_AdvertsPositionEntity.IsSingle = IsSingle;
				adapter.SaveEntity(_AdvertsPositionEntity, true);
			}
			return _AdvertsPositionEntity;
		}

		public bool Update(AdvertsPositionEntity _AdvertsPositionEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(AdvertsPositionFields.Id == _AdvertsPositionEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_AdvertsPositionEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(AdvertsPositionEntity _AdvertsPositionEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_AdvertsPositionEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string GroupName, string PositionId, int OrderIndex, int Width, int Height, int NumberOfGroup, bool IsVisible, string PositionTypeId, bool IsSingle)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				AdvertsPositionEntity _AdvertsPositionEntity = new AdvertsPositionEntity(Id);
				if (adapter.FetchEntity(_AdvertsPositionEntity))
				{
				
					_AdvertsPositionEntity.GroupName = GroupName;
					_AdvertsPositionEntity.PositionId = PositionId;
					_AdvertsPositionEntity.OrderIndex = OrderIndex;
					_AdvertsPositionEntity.Width = Width;
					_AdvertsPositionEntity.Height = Height;
					_AdvertsPositionEntity.NumberOfGroup = NumberOfGroup;
					_AdvertsPositionEntity.IsVisible = IsVisible;
					_AdvertsPositionEntity.PositionTypeId = PositionTypeId;
					_AdvertsPositionEntity.IsSingle = IsSingle;
					adapter.SaveEntity(_AdvertsPositionEntity, true);
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
				AdvertsPositionEntity _AdvertsPositionEntity = new AdvertsPositionEntity(Id);
				if (adapter.FetchEntity(_AdvertsPositionEntity))
				{
					adapter.DeleteEntity(_AdvertsPositionEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("AdvertsPositionEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AdvertsPositionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGroupName(string GroupName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.GroupName == GroupName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AdvertsPositionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPositionId(string PositionId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.PositionId == PositionId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AdvertsPositionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByOrderIndex(int OrderIndex)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.OrderIndex == OrderIndex);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AdvertsPositionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByWidth(int Width)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.Width == Width);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AdvertsPositionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByHeight(int Height)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.Height == Height);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AdvertsPositionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNumberOfGroup(int NumberOfGroup)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.NumberOfGroup == NumberOfGroup);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AdvertsPositionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIsVisible(bool IsVisible)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.IsVisible == IsVisible);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AdvertsPositionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPositionTypeId(string PositionTypeId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.PositionTypeId == PositionTypeId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AdvertsPositionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIsSingle(bool IsSingle)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.IsSingle == IsSingle);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AdvertsPositionEntity", filter);
			}
			return toReturn;
		}
		

		
		public AdvertsPositionEntity SelectOne(Guid Id)
		{
			AdvertsPositionEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				AdvertsPositionEntity _AdvertsPositionEntity = new AdvertsPositionEntity(Id);
				if (adapter.FetchEntity(_AdvertsPositionEntity))
				{
					toReturn = _AdvertsPositionEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsPositionCollection = new EntityCollection(new AdvertsPositionEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsPositionCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<AdvertsPositionEntity>
		public EntityCollection<AdvertsPositionEntity> SelectAllLST()
		{
			EntityCollection<AdvertsPositionEntity> _AdvertsPositionCollection = new EntityCollection<AdvertsPositionEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsPositionCollection, null, 0, null);
			}
			return _AdvertsPositionCollection;
		}
		
		// Return EntityCollection<AdvertsPositionEntity>
		public EntityCollection<AdvertsPositionEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<AdvertsPositionEntity> _AdvertsPositionCollection = new EntityCollection<AdvertsPositionEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsPositionCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _AdvertsPositionCollection;
		}


		
		// Return EntityCollection<AdvertsPositionEntity>
		public EntityCollection<AdvertsPositionEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<AdvertsPositionEntity> _AdvertsPositionCollection = new EntityCollection<AdvertsPositionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsPositionCollection, filter, 0, null);
			}
			return _AdvertsPositionCollection;
		}
		
		// Return EntityCollection<AdvertsPositionEntity>
		public EntityCollection<AdvertsPositionEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<AdvertsPositionEntity> _AdvertsPositionCollection = new EntityCollection<AdvertsPositionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsPositionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AdvertsPositionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsPositionCollection = new EntityCollection(new AdvertsPositionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsPositionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsPositionCollection = new EntityCollection(new AdvertsPositionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsPositionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AdvertsPositionEntity>
		public EntityCollection<AdvertsPositionEntity> SelectByGroupNameLST(string GroupName)
		{
			EntityCollection<AdvertsPositionEntity> _AdvertsPositionCollection = new EntityCollection<AdvertsPositionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.GroupName == GroupName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsPositionCollection, filter, 0, null);
			}
			return _AdvertsPositionCollection;
		}
		
		// Return EntityCollection<AdvertsPositionEntity>
		public EntityCollection<AdvertsPositionEntity> SelectByGroupNameLST_Paged(string GroupName, int PageNumber, int PageSize)
		{
			EntityCollection<AdvertsPositionEntity> _AdvertsPositionCollection = new EntityCollection<AdvertsPositionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.GroupName == GroupName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsPositionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AdvertsPositionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGroupNameRDT(string GroupName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsPositionCollection = new EntityCollection(new AdvertsPositionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.GroupName == GroupName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsPositionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGroupNameRDT_Paged(string GroupName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsPositionCollection = new EntityCollection(new AdvertsPositionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.GroupName == GroupName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsPositionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AdvertsPositionEntity>
		public EntityCollection<AdvertsPositionEntity> SelectByPositionIdLST(string PositionId)
		{
			EntityCollection<AdvertsPositionEntity> _AdvertsPositionCollection = new EntityCollection<AdvertsPositionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.PositionId == PositionId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsPositionCollection, filter, 0, null);
			}
			return _AdvertsPositionCollection;
		}
		
		// Return EntityCollection<AdvertsPositionEntity>
		public EntityCollection<AdvertsPositionEntity> SelectByPositionIdLST_Paged(string PositionId, int PageNumber, int PageSize)
		{
			EntityCollection<AdvertsPositionEntity> _AdvertsPositionCollection = new EntityCollection<AdvertsPositionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.PositionId == PositionId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsPositionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AdvertsPositionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPositionIdRDT(string PositionId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsPositionCollection = new EntityCollection(new AdvertsPositionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.PositionId == PositionId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsPositionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPositionIdRDT_Paged(string PositionId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsPositionCollection = new EntityCollection(new AdvertsPositionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.PositionId == PositionId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsPositionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AdvertsPositionEntity>
		public EntityCollection<AdvertsPositionEntity> SelectByOrderIndexLST(int OrderIndex)
		{
			EntityCollection<AdvertsPositionEntity> _AdvertsPositionCollection = new EntityCollection<AdvertsPositionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.OrderIndex == OrderIndex);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsPositionCollection, filter, 0, null);
			}
			return _AdvertsPositionCollection;
		}
		
		// Return EntityCollection<AdvertsPositionEntity>
		public EntityCollection<AdvertsPositionEntity> SelectByOrderIndexLST_Paged(int OrderIndex, int PageNumber, int PageSize)
		{
			EntityCollection<AdvertsPositionEntity> _AdvertsPositionCollection = new EntityCollection<AdvertsPositionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.OrderIndex == OrderIndex);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsPositionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AdvertsPositionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByOrderIndexRDT(int OrderIndex)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsPositionCollection = new EntityCollection(new AdvertsPositionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.OrderIndex == OrderIndex);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsPositionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByOrderIndexRDT_Paged(int OrderIndex, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsPositionCollection = new EntityCollection(new AdvertsPositionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.OrderIndex == OrderIndex);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsPositionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AdvertsPositionEntity>
		public EntityCollection<AdvertsPositionEntity> SelectByWidthLST(int Width)
		{
			EntityCollection<AdvertsPositionEntity> _AdvertsPositionCollection = new EntityCollection<AdvertsPositionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.Width == Width);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsPositionCollection, filter, 0, null);
			}
			return _AdvertsPositionCollection;
		}
		
		// Return EntityCollection<AdvertsPositionEntity>
		public EntityCollection<AdvertsPositionEntity> SelectByWidthLST_Paged(int Width, int PageNumber, int PageSize)
		{
			EntityCollection<AdvertsPositionEntity> _AdvertsPositionCollection = new EntityCollection<AdvertsPositionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.Width == Width);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsPositionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AdvertsPositionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByWidthRDT(int Width)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsPositionCollection = new EntityCollection(new AdvertsPositionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.Width == Width);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsPositionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByWidthRDT_Paged(int Width, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsPositionCollection = new EntityCollection(new AdvertsPositionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.Width == Width);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsPositionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AdvertsPositionEntity>
		public EntityCollection<AdvertsPositionEntity> SelectByHeightLST(int Height)
		{
			EntityCollection<AdvertsPositionEntity> _AdvertsPositionCollection = new EntityCollection<AdvertsPositionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.Height == Height);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsPositionCollection, filter, 0, null);
			}
			return _AdvertsPositionCollection;
		}
		
		// Return EntityCollection<AdvertsPositionEntity>
		public EntityCollection<AdvertsPositionEntity> SelectByHeightLST_Paged(int Height, int PageNumber, int PageSize)
		{
			EntityCollection<AdvertsPositionEntity> _AdvertsPositionCollection = new EntityCollection<AdvertsPositionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.Height == Height);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsPositionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AdvertsPositionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByHeightRDT(int Height)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsPositionCollection = new EntityCollection(new AdvertsPositionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.Height == Height);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsPositionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByHeightRDT_Paged(int Height, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsPositionCollection = new EntityCollection(new AdvertsPositionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.Height == Height);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsPositionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AdvertsPositionEntity>
		public EntityCollection<AdvertsPositionEntity> SelectByNumberOfGroupLST(int NumberOfGroup)
		{
			EntityCollection<AdvertsPositionEntity> _AdvertsPositionCollection = new EntityCollection<AdvertsPositionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.NumberOfGroup == NumberOfGroup);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsPositionCollection, filter, 0, null);
			}
			return _AdvertsPositionCollection;
		}
		
		// Return EntityCollection<AdvertsPositionEntity>
		public EntityCollection<AdvertsPositionEntity> SelectByNumberOfGroupLST_Paged(int NumberOfGroup, int PageNumber, int PageSize)
		{
			EntityCollection<AdvertsPositionEntity> _AdvertsPositionCollection = new EntityCollection<AdvertsPositionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.NumberOfGroup == NumberOfGroup);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsPositionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AdvertsPositionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNumberOfGroupRDT(int NumberOfGroup)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsPositionCollection = new EntityCollection(new AdvertsPositionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.NumberOfGroup == NumberOfGroup);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsPositionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNumberOfGroupRDT_Paged(int NumberOfGroup, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsPositionCollection = new EntityCollection(new AdvertsPositionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.NumberOfGroup == NumberOfGroup);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsPositionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AdvertsPositionEntity>
		public EntityCollection<AdvertsPositionEntity> SelectByIsVisibleLST(bool IsVisible)
		{
			EntityCollection<AdvertsPositionEntity> _AdvertsPositionCollection = new EntityCollection<AdvertsPositionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.IsVisible == IsVisible);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsPositionCollection, filter, 0, null);
			}
			return _AdvertsPositionCollection;
		}
		
		// Return EntityCollection<AdvertsPositionEntity>
		public EntityCollection<AdvertsPositionEntity> SelectByIsVisibleLST_Paged(bool IsVisible, int PageNumber, int PageSize)
		{
			EntityCollection<AdvertsPositionEntity> _AdvertsPositionCollection = new EntityCollection<AdvertsPositionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.IsVisible == IsVisible);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsPositionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AdvertsPositionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIsVisibleRDT(bool IsVisible)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsPositionCollection = new EntityCollection(new AdvertsPositionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.IsVisible == IsVisible);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsPositionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIsVisibleRDT_Paged(bool IsVisible, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsPositionCollection = new EntityCollection(new AdvertsPositionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.IsVisible == IsVisible);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsPositionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AdvertsPositionEntity>
		public EntityCollection<AdvertsPositionEntity> SelectByPositionTypeIdLST(string PositionTypeId)
		{
			EntityCollection<AdvertsPositionEntity> _AdvertsPositionCollection = new EntityCollection<AdvertsPositionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.PositionTypeId == PositionTypeId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsPositionCollection, filter, 0, null);
			}
			return _AdvertsPositionCollection;
		}
		
		// Return EntityCollection<AdvertsPositionEntity>
		public EntityCollection<AdvertsPositionEntity> SelectByPositionTypeIdLST_Paged(string PositionTypeId, int PageNumber, int PageSize)
		{
			EntityCollection<AdvertsPositionEntity> _AdvertsPositionCollection = new EntityCollection<AdvertsPositionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.PositionTypeId == PositionTypeId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsPositionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AdvertsPositionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPositionTypeIdRDT(string PositionTypeId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsPositionCollection = new EntityCollection(new AdvertsPositionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.PositionTypeId == PositionTypeId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsPositionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPositionTypeIdRDT_Paged(string PositionTypeId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsPositionCollection = new EntityCollection(new AdvertsPositionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.PositionTypeId == PositionTypeId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsPositionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AdvertsPositionEntity>
		public EntityCollection<AdvertsPositionEntity> SelectByIsSingleLST(bool IsSingle)
		{
			EntityCollection<AdvertsPositionEntity> _AdvertsPositionCollection = new EntityCollection<AdvertsPositionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.IsSingle == IsSingle);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsPositionCollection, filter, 0, null);
			}
			return _AdvertsPositionCollection;
		}
		
		// Return EntityCollection<AdvertsPositionEntity>
		public EntityCollection<AdvertsPositionEntity> SelectByIsSingleLST_Paged(bool IsSingle, int PageNumber, int PageSize)
		{
			EntityCollection<AdvertsPositionEntity> _AdvertsPositionCollection = new EntityCollection<AdvertsPositionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.IsSingle == IsSingle);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AdvertsPositionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AdvertsPositionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIsSingleRDT(bool IsSingle)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsPositionCollection = new EntityCollection(new AdvertsPositionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.IsSingle == IsSingle);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsPositionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIsSingleRDT_Paged(bool IsSingle, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AdvertsPositionCollection = new EntityCollection(new AdvertsPositionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AdvertsPositionFields.IsSingle == IsSingle);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AdvertsPositionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
