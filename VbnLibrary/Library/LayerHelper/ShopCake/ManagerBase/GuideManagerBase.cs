




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.GuideManagerBase
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
	public class GuideManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public GuideManagerBase()
		{
			// Nothing for now.
		}
		
		public GuideEntity Insert(GuideEntity _GuideEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_GuideEntity, true);
			}
			return _GuideEntity;
		}

		
		public GuideEntity Insert(Guid Id, string Guide)
		{
			GuideEntity _GuideEntity = new GuideEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_GuideEntity.Id = Id;
				_GuideEntity.Guide = Guide;
				adapter.SaveEntity(_GuideEntity, true);
			}
			return _GuideEntity;
		}

		public GuideEntity Insert(string Guide)
		{
			GuideEntity _GuideEntity = new GuideEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_GuideEntity.Guide = Guide;
				adapter.SaveEntity(_GuideEntity, true);
			}
			return _GuideEntity;
		}

		public bool Update(GuideEntity _GuideEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(GuideFields.Id == _GuideEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_GuideEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(GuideEntity _GuideEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_GuideEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string Guide)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				GuideEntity _GuideEntity = new GuideEntity(Id);
				if (adapter.FetchEntity(_GuideEntity))
				{
				
					_GuideEntity.Guide = Guide;
					adapter.SaveEntity(_GuideEntity, true);
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
				GuideEntity _GuideEntity = new GuideEntity(Id);
				if (adapter.FetchEntity(_GuideEntity))
				{
					adapter.DeleteEntity(_GuideEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("GuideEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GuideFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("GuideEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGuide(string Guide)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GuideFields.Guide == Guide);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("GuideEntity", filter);
			}
			return toReturn;
		}
		

		
		public GuideEntity SelectOne(Guid Id)
		{
			GuideEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				GuideEntity _GuideEntity = new GuideEntity(Id);
				if (adapter.FetchEntity(_GuideEntity))
				{
					toReturn = _GuideEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _GuideCollection = new EntityCollection(new GuideEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_GuideCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<GuideEntity>
		public EntityCollection<GuideEntity> SelectAllLST()
		{
			EntityCollection<GuideEntity> _GuideCollection = new EntityCollection<GuideEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_GuideCollection, null, 0, null);
			}
			return _GuideCollection;
		}
		
		// Return EntityCollection<GuideEntity>
		public EntityCollection<GuideEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<GuideEntity> _GuideCollection = new EntityCollection<GuideEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_GuideCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _GuideCollection;
		}


		
		// Return EntityCollection<GuideEntity>
		public EntityCollection<GuideEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<GuideEntity> _GuideCollection = new EntityCollection<GuideEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GuideFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_GuideCollection, filter, 0, null);
			}
			return _GuideCollection;
		}
		
		// Return EntityCollection<GuideEntity>
		public EntityCollection<GuideEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<GuideEntity> _GuideCollection = new EntityCollection<GuideEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GuideFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_GuideCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _GuideCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _GuideCollection = new EntityCollection(new GuideEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GuideFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_GuideCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _GuideCollection = new EntityCollection(new GuideEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GuideFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_GuideCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<GuideEntity>
		public EntityCollection<GuideEntity> SelectByGuideLST(string Guide)
		{
			EntityCollection<GuideEntity> _GuideCollection = new EntityCollection<GuideEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GuideFields.Guide == Guide);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_GuideCollection, filter, 0, null);
			}
			return _GuideCollection;
		}
		
		// Return EntityCollection<GuideEntity>
		public EntityCollection<GuideEntity> SelectByGuideLST_Paged(string Guide, int PageNumber, int PageSize)
		{
			EntityCollection<GuideEntity> _GuideCollection = new EntityCollection<GuideEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GuideFields.Guide == Guide);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_GuideCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _GuideCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGuideRDT(string Guide)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _GuideCollection = new EntityCollection(new GuideEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GuideFields.Guide == Guide);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_GuideCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGuideRDT_Paged(string Guide, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _GuideCollection = new EntityCollection(new GuideEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GuideFields.Guide == Guide);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_GuideCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
