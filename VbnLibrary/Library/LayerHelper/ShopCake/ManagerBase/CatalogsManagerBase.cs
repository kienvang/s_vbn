




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.CatalogsManagerBase
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
	public class CatalogsManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public CatalogsManagerBase()
		{
			// Nothing for now.
		}
		
		public CatalogsEntity Insert(CatalogsEntity _CatalogsEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_CatalogsEntity, true);
			}
			return _CatalogsEntity;
		}

		
		public CatalogsEntity Insert(int Id, string CatalogName, string CatCode, string TextId, string ToolTip, int ParentId, bool IsLeaf, int ProductAmount, bool IsVisible, bool IsVisibleHome, int OrderIndex)
		{
			CatalogsEntity _CatalogsEntity = new CatalogsEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_CatalogsEntity.Id = Id;
				_CatalogsEntity.CatalogName = CatalogName;
				_CatalogsEntity.CatCode = CatCode;
				_CatalogsEntity.TextId = TextId;
				_CatalogsEntity.ToolTip = ToolTip;
				_CatalogsEntity.ParentId = ParentId;
				_CatalogsEntity.IsLeaf = IsLeaf;
				_CatalogsEntity.ProductAmount = ProductAmount;
				_CatalogsEntity.IsVisible = IsVisible;
				_CatalogsEntity.IsVisibleHome = IsVisibleHome;
				_CatalogsEntity.OrderIndex = OrderIndex;
				adapter.SaveEntity(_CatalogsEntity, true);
			}
			return _CatalogsEntity;
		}

		public CatalogsEntity Insert(string CatalogName, string CatCode, string TextId, string ToolTip, int ParentId, bool IsLeaf, int ProductAmount, bool IsVisible, bool IsVisibleHome, int OrderIndex)
		{
			CatalogsEntity _CatalogsEntity = new CatalogsEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_CatalogsEntity.CatalogName = CatalogName;
				_CatalogsEntity.CatCode = CatCode;
				_CatalogsEntity.TextId = TextId;
				_CatalogsEntity.ToolTip = ToolTip;
				_CatalogsEntity.ParentId = ParentId;
				_CatalogsEntity.IsLeaf = IsLeaf;
				_CatalogsEntity.ProductAmount = ProductAmount;
				_CatalogsEntity.IsVisible = IsVisible;
				_CatalogsEntity.IsVisibleHome = IsVisibleHome;
				_CatalogsEntity.OrderIndex = OrderIndex;
				adapter.SaveEntity(_CatalogsEntity, true);
			}
			return _CatalogsEntity;
		}

		public bool Update(CatalogsEntity _CatalogsEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(CatalogsFields.Id == _CatalogsEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_CatalogsEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(CatalogsEntity _CatalogsEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_CatalogsEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(int Id, string CatalogName, string CatCode, string TextId, string ToolTip, int ParentId, bool IsLeaf, int ProductAmount, bool IsVisible, bool IsVisibleHome, int OrderIndex)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				CatalogsEntity _CatalogsEntity = new CatalogsEntity(Id);
				if (adapter.FetchEntity(_CatalogsEntity))
				{
				
					_CatalogsEntity.CatalogName = CatalogName;
					_CatalogsEntity.CatCode = CatCode;
					_CatalogsEntity.TextId = TextId;
					_CatalogsEntity.ToolTip = ToolTip;
					_CatalogsEntity.ParentId = ParentId;
					_CatalogsEntity.IsLeaf = IsLeaf;
					_CatalogsEntity.ProductAmount = ProductAmount;
					_CatalogsEntity.IsVisible = IsVisible;
					_CatalogsEntity.IsVisibleHome = IsVisibleHome;
					_CatalogsEntity.OrderIndex = OrderIndex;
					adapter.SaveEntity(_CatalogsEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(int Id)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				CatalogsEntity _CatalogsEntity = new CatalogsEntity(Id);
				if (adapter.FetchEntity(_CatalogsEntity))
				{
					adapter.DeleteEntity(_CatalogsEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("CatalogsEntity", null);
			}
		}
		
		
		public int DeleteById(int Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CatalogsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCatalogName(string CatalogName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.CatalogName == CatalogName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CatalogsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCatCode(string CatCode)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.CatCode == CatCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CatalogsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTextId(string TextId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.TextId == TextId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CatalogsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByToolTip(string ToolTip)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.ToolTip == ToolTip);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CatalogsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByParentId(int ParentId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.ParentId == ParentId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CatalogsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIsLeaf(bool IsLeaf)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.IsLeaf == IsLeaf);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CatalogsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByProductAmount(int ProductAmount)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.ProductAmount == ProductAmount);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CatalogsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIsVisible(bool IsVisible)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.IsVisible == IsVisible);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CatalogsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIsVisibleHome(bool IsVisibleHome)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.IsVisibleHome == IsVisibleHome);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CatalogsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByOrderIndex(int OrderIndex)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.OrderIndex == OrderIndex);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CatalogsEntity", filter);
			}
			return toReturn;
		}
		

		
		public CatalogsEntity SelectOne(int Id)
		{
			CatalogsEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				CatalogsEntity _CatalogsEntity = new CatalogsEntity(Id);
				if (adapter.FetchEntity(_CatalogsEntity))
				{
					toReturn = _CatalogsEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CatalogsCollection = new EntityCollection(new CatalogsEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CatalogsCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<CatalogsEntity>
		public EntityCollection<CatalogsEntity> SelectAllLST()
		{
			EntityCollection<CatalogsEntity> _CatalogsCollection = new EntityCollection<CatalogsEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CatalogsCollection, null, 0, null);
			}
			return _CatalogsCollection;
		}
		
		// Return EntityCollection<CatalogsEntity>
		public EntityCollection<CatalogsEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<CatalogsEntity> _CatalogsCollection = new EntityCollection<CatalogsEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CatalogsCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _CatalogsCollection;
		}


		
		// Return EntityCollection<CatalogsEntity>
		public EntityCollection<CatalogsEntity> SelectByIdLST(int Id)
		{
			EntityCollection<CatalogsEntity> _CatalogsCollection = new EntityCollection<CatalogsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CatalogsCollection, filter, 0, null);
			}
			return _CatalogsCollection;
		}
		
		// Return EntityCollection<CatalogsEntity>
		public EntityCollection<CatalogsEntity> SelectByIdLST_Paged(int Id, int PageNumber, int PageSize)
		{
			EntityCollection<CatalogsEntity> _CatalogsCollection = new EntityCollection<CatalogsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CatalogsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CatalogsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(int Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CatalogsCollection = new EntityCollection(new CatalogsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CatalogsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(int Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CatalogsCollection = new EntityCollection(new CatalogsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CatalogsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<CatalogsEntity>
		public EntityCollection<CatalogsEntity> SelectByCatalogNameLST(string CatalogName)
		{
			EntityCollection<CatalogsEntity> _CatalogsCollection = new EntityCollection<CatalogsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.CatalogName == CatalogName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CatalogsCollection, filter, 0, null);
			}
			return _CatalogsCollection;
		}
		
		// Return EntityCollection<CatalogsEntity>
		public EntityCollection<CatalogsEntity> SelectByCatalogNameLST_Paged(string CatalogName, int PageNumber, int PageSize)
		{
			EntityCollection<CatalogsEntity> _CatalogsCollection = new EntityCollection<CatalogsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.CatalogName == CatalogName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CatalogsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CatalogsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCatalogNameRDT(string CatalogName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CatalogsCollection = new EntityCollection(new CatalogsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.CatalogName == CatalogName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CatalogsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCatalogNameRDT_Paged(string CatalogName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CatalogsCollection = new EntityCollection(new CatalogsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.CatalogName == CatalogName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CatalogsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<CatalogsEntity>
		public EntityCollection<CatalogsEntity> SelectByCatCodeLST(string CatCode)
		{
			EntityCollection<CatalogsEntity> _CatalogsCollection = new EntityCollection<CatalogsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.CatCode == CatCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CatalogsCollection, filter, 0, null);
			}
			return _CatalogsCollection;
		}
		
		// Return EntityCollection<CatalogsEntity>
		public EntityCollection<CatalogsEntity> SelectByCatCodeLST_Paged(string CatCode, int PageNumber, int PageSize)
		{
			EntityCollection<CatalogsEntity> _CatalogsCollection = new EntityCollection<CatalogsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.CatCode == CatCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CatalogsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CatalogsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCatCodeRDT(string CatCode)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CatalogsCollection = new EntityCollection(new CatalogsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.CatCode == CatCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CatalogsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCatCodeRDT_Paged(string CatCode, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CatalogsCollection = new EntityCollection(new CatalogsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.CatCode == CatCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CatalogsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<CatalogsEntity>
		public EntityCollection<CatalogsEntity> SelectByTextIdLST(string TextId)
		{
			EntityCollection<CatalogsEntity> _CatalogsCollection = new EntityCollection<CatalogsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.TextId == TextId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CatalogsCollection, filter, 0, null);
			}
			return _CatalogsCollection;
		}
		
		// Return EntityCollection<CatalogsEntity>
		public EntityCollection<CatalogsEntity> SelectByTextIdLST_Paged(string TextId, int PageNumber, int PageSize)
		{
			EntityCollection<CatalogsEntity> _CatalogsCollection = new EntityCollection<CatalogsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.TextId == TextId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CatalogsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CatalogsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTextIdRDT(string TextId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CatalogsCollection = new EntityCollection(new CatalogsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.TextId == TextId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CatalogsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTextIdRDT_Paged(string TextId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CatalogsCollection = new EntityCollection(new CatalogsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.TextId == TextId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CatalogsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<CatalogsEntity>
		public EntityCollection<CatalogsEntity> SelectByToolTipLST(string ToolTip)
		{
			EntityCollection<CatalogsEntity> _CatalogsCollection = new EntityCollection<CatalogsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.ToolTip == ToolTip);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CatalogsCollection, filter, 0, null);
			}
			return _CatalogsCollection;
		}
		
		// Return EntityCollection<CatalogsEntity>
		public EntityCollection<CatalogsEntity> SelectByToolTipLST_Paged(string ToolTip, int PageNumber, int PageSize)
		{
			EntityCollection<CatalogsEntity> _CatalogsCollection = new EntityCollection<CatalogsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.ToolTip == ToolTip);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CatalogsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CatalogsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByToolTipRDT(string ToolTip)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CatalogsCollection = new EntityCollection(new CatalogsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.ToolTip == ToolTip);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CatalogsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByToolTipRDT_Paged(string ToolTip, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CatalogsCollection = new EntityCollection(new CatalogsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.ToolTip == ToolTip);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CatalogsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<CatalogsEntity>
		public EntityCollection<CatalogsEntity> SelectByParentIdLST(int ParentId)
		{
			EntityCollection<CatalogsEntity> _CatalogsCollection = new EntityCollection<CatalogsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.ParentId == ParentId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CatalogsCollection, filter, 0, null);
			}
			return _CatalogsCollection;
		}
		
		// Return EntityCollection<CatalogsEntity>
		public EntityCollection<CatalogsEntity> SelectByParentIdLST_Paged(int ParentId, int PageNumber, int PageSize)
		{
			EntityCollection<CatalogsEntity> _CatalogsCollection = new EntityCollection<CatalogsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.ParentId == ParentId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CatalogsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CatalogsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByParentIdRDT(int ParentId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CatalogsCollection = new EntityCollection(new CatalogsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.ParentId == ParentId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CatalogsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByParentIdRDT_Paged(int ParentId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CatalogsCollection = new EntityCollection(new CatalogsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.ParentId == ParentId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CatalogsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<CatalogsEntity>
		public EntityCollection<CatalogsEntity> SelectByIsLeafLST(bool IsLeaf)
		{
			EntityCollection<CatalogsEntity> _CatalogsCollection = new EntityCollection<CatalogsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.IsLeaf == IsLeaf);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CatalogsCollection, filter, 0, null);
			}
			return _CatalogsCollection;
		}
		
		// Return EntityCollection<CatalogsEntity>
		public EntityCollection<CatalogsEntity> SelectByIsLeafLST_Paged(bool IsLeaf, int PageNumber, int PageSize)
		{
			EntityCollection<CatalogsEntity> _CatalogsCollection = new EntityCollection<CatalogsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.IsLeaf == IsLeaf);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CatalogsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CatalogsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIsLeafRDT(bool IsLeaf)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CatalogsCollection = new EntityCollection(new CatalogsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.IsLeaf == IsLeaf);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CatalogsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIsLeafRDT_Paged(bool IsLeaf, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CatalogsCollection = new EntityCollection(new CatalogsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.IsLeaf == IsLeaf);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CatalogsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<CatalogsEntity>
		public EntityCollection<CatalogsEntity> SelectByProductAmountLST(int ProductAmount)
		{
			EntityCollection<CatalogsEntity> _CatalogsCollection = new EntityCollection<CatalogsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.ProductAmount == ProductAmount);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CatalogsCollection, filter, 0, null);
			}
			return _CatalogsCollection;
		}
		
		// Return EntityCollection<CatalogsEntity>
		public EntityCollection<CatalogsEntity> SelectByProductAmountLST_Paged(int ProductAmount, int PageNumber, int PageSize)
		{
			EntityCollection<CatalogsEntity> _CatalogsCollection = new EntityCollection<CatalogsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.ProductAmount == ProductAmount);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CatalogsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CatalogsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByProductAmountRDT(int ProductAmount)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CatalogsCollection = new EntityCollection(new CatalogsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.ProductAmount == ProductAmount);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CatalogsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByProductAmountRDT_Paged(int ProductAmount, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CatalogsCollection = new EntityCollection(new CatalogsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.ProductAmount == ProductAmount);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CatalogsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<CatalogsEntity>
		public EntityCollection<CatalogsEntity> SelectByIsVisibleLST(bool IsVisible)
		{
			EntityCollection<CatalogsEntity> _CatalogsCollection = new EntityCollection<CatalogsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.IsVisible == IsVisible);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CatalogsCollection, filter, 0, null);
			}
			return _CatalogsCollection;
		}
		
		// Return EntityCollection<CatalogsEntity>
		public EntityCollection<CatalogsEntity> SelectByIsVisibleLST_Paged(bool IsVisible, int PageNumber, int PageSize)
		{
			EntityCollection<CatalogsEntity> _CatalogsCollection = new EntityCollection<CatalogsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.IsVisible == IsVisible);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CatalogsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CatalogsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIsVisibleRDT(bool IsVisible)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CatalogsCollection = new EntityCollection(new CatalogsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.IsVisible == IsVisible);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CatalogsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIsVisibleRDT_Paged(bool IsVisible, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CatalogsCollection = new EntityCollection(new CatalogsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.IsVisible == IsVisible);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CatalogsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<CatalogsEntity>
		public EntityCollection<CatalogsEntity> SelectByIsVisibleHomeLST(bool IsVisibleHome)
		{
			EntityCollection<CatalogsEntity> _CatalogsCollection = new EntityCollection<CatalogsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.IsVisibleHome == IsVisibleHome);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CatalogsCollection, filter, 0, null);
			}
			return _CatalogsCollection;
		}
		
		// Return EntityCollection<CatalogsEntity>
		public EntityCollection<CatalogsEntity> SelectByIsVisibleHomeLST_Paged(bool IsVisibleHome, int PageNumber, int PageSize)
		{
			EntityCollection<CatalogsEntity> _CatalogsCollection = new EntityCollection<CatalogsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.IsVisibleHome == IsVisibleHome);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CatalogsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CatalogsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIsVisibleHomeRDT(bool IsVisibleHome)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CatalogsCollection = new EntityCollection(new CatalogsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.IsVisibleHome == IsVisibleHome);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CatalogsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIsVisibleHomeRDT_Paged(bool IsVisibleHome, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CatalogsCollection = new EntityCollection(new CatalogsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.IsVisibleHome == IsVisibleHome);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CatalogsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<CatalogsEntity>
		public EntityCollection<CatalogsEntity> SelectByOrderIndexLST(int OrderIndex)
		{
			EntityCollection<CatalogsEntity> _CatalogsCollection = new EntityCollection<CatalogsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.OrderIndex == OrderIndex);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CatalogsCollection, filter, 0, null);
			}
			return _CatalogsCollection;
		}
		
		// Return EntityCollection<CatalogsEntity>
		public EntityCollection<CatalogsEntity> SelectByOrderIndexLST_Paged(int OrderIndex, int PageNumber, int PageSize)
		{
			EntityCollection<CatalogsEntity> _CatalogsCollection = new EntityCollection<CatalogsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.OrderIndex == OrderIndex);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CatalogsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CatalogsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByOrderIndexRDT(int OrderIndex)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CatalogsCollection = new EntityCollection(new CatalogsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.OrderIndex == OrderIndex);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CatalogsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByOrderIndexRDT_Paged(int OrderIndex, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CatalogsCollection = new EntityCollection(new CatalogsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CatalogsFields.OrderIndex == OrderIndex);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CatalogsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
