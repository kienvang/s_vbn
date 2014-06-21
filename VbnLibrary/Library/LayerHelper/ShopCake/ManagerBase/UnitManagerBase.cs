




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.UnitManagerBase
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
	public class UnitManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public UnitManagerBase()
		{
			// Nothing for now.
		}
		
		public UnitEntity Insert(UnitEntity _UnitEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_UnitEntity, true);
			}
			return _UnitEntity;
		}

		
		public UnitEntity Insert(string UnitCode, string UnitName)
		{
			UnitEntity _UnitEntity = new UnitEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_UnitEntity.UnitCode = UnitCode;
				_UnitEntity.UnitName = UnitName;
				adapter.SaveEntity(_UnitEntity, true);
			}
			return _UnitEntity;
		}

		public UnitEntity Insert(string UnitName)
		{
			UnitEntity _UnitEntity = new UnitEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_UnitEntity.UnitName = UnitName;
				adapter.SaveEntity(_UnitEntity, true);
			}
			return _UnitEntity;
		}

		public bool Update(UnitEntity _UnitEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(UnitFields.UnitCode == _UnitEntity.UnitCode);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_UnitEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(UnitEntity _UnitEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_UnitEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(string UnitCode, string UnitName)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				UnitEntity _UnitEntity = new UnitEntity(UnitCode);
				if (adapter.FetchEntity(_UnitEntity))
				{
				
					_UnitEntity.UnitName = UnitName;
					adapter.SaveEntity(_UnitEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(string UnitCode)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				UnitEntity _UnitEntity = new UnitEntity(UnitCode);
				if (adapter.FetchEntity(_UnitEntity))
				{
					adapter.DeleteEntity(_UnitEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("UnitEntity", null);
			}
		}
		
		
		public int DeleteByUnitCode(string UnitCode)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(UnitFields.UnitCode == UnitCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("UnitEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByUnitName(string UnitName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(UnitFields.UnitName == UnitName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("UnitEntity", filter);
			}
			return toReturn;
		}
		

		
		public UnitEntity SelectOne(string UnitCode)
		{
			UnitEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				UnitEntity _UnitEntity = new UnitEntity(UnitCode);
				if (adapter.FetchEntity(_UnitEntity))
				{
					toReturn = _UnitEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _UnitCollection = new EntityCollection(new UnitEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_UnitCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<UnitEntity>
		public EntityCollection<UnitEntity> SelectAllLST()
		{
			EntityCollection<UnitEntity> _UnitCollection = new EntityCollection<UnitEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_UnitCollection, null, 0, null);
			}
			return _UnitCollection;
		}
		
		// Return EntityCollection<UnitEntity>
		public EntityCollection<UnitEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<UnitEntity> _UnitCollection = new EntityCollection<UnitEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_UnitCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _UnitCollection;
		}


		
		// Return EntityCollection<UnitEntity>
		public EntityCollection<UnitEntity> SelectByUnitCodeLST(string UnitCode)
		{
			EntityCollection<UnitEntity> _UnitCollection = new EntityCollection<UnitEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(UnitFields.UnitCode == UnitCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_UnitCollection, filter, 0, null);
			}
			return _UnitCollection;
		}
		
		// Return EntityCollection<UnitEntity>
		public EntityCollection<UnitEntity> SelectByUnitCodeLST_Paged(string UnitCode, int PageNumber, int PageSize)
		{
			EntityCollection<UnitEntity> _UnitCollection = new EntityCollection<UnitEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(UnitFields.UnitCode == UnitCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_UnitCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _UnitCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUnitCodeRDT(string UnitCode)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _UnitCollection = new EntityCollection(new UnitEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(UnitFields.UnitCode == UnitCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_UnitCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUnitCodeRDT_Paged(string UnitCode, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _UnitCollection = new EntityCollection(new UnitEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(UnitFields.UnitCode == UnitCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_UnitCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<UnitEntity>
		public EntityCollection<UnitEntity> SelectByUnitNameLST(string UnitName)
		{
			EntityCollection<UnitEntity> _UnitCollection = new EntityCollection<UnitEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(UnitFields.UnitName == UnitName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_UnitCollection, filter, 0, null);
			}
			return _UnitCollection;
		}
		
		// Return EntityCollection<UnitEntity>
		public EntityCollection<UnitEntity> SelectByUnitNameLST_Paged(string UnitName, int PageNumber, int PageSize)
		{
			EntityCollection<UnitEntity> _UnitCollection = new EntityCollection<UnitEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(UnitFields.UnitName == UnitName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_UnitCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _UnitCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUnitNameRDT(string UnitName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _UnitCollection = new EntityCollection(new UnitEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(UnitFields.UnitName == UnitName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_UnitCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUnitNameRDT_Paged(string UnitName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _UnitCollection = new EntityCollection(new UnitEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(UnitFields.UnitName == UnitName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_UnitCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
