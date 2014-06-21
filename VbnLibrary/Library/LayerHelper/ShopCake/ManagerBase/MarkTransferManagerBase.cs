


/*
'===============================================================================
'  LayerHelper.ShopCake.BL.MarkTransferManagerBase
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
	public class MarkTransferManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public MarkTransferManagerBase()
		{
			// Nothing for now.
		}
		
		public MarkTransferEntity Insert(MarkTransferEntity _MarkTransferEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_MarkTransferEntity, true);
			}
			return _MarkTransferEntity;
		}

		
		public MarkTransferEntity Insert(Guid Id, string Code, int Mark, decimal Cost)
		{
			MarkTransferEntity _MarkTransferEntity = new MarkTransferEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_MarkTransferEntity.Id = Id;
				_MarkTransferEntity.Code = Code;
				_MarkTransferEntity.Mark = Mark;
				_MarkTransferEntity.Cost = Cost;
				adapter.SaveEntity(_MarkTransferEntity, true);
			}
			return _MarkTransferEntity;
		}

		public MarkTransferEntity Insert(string Code, int Mark, decimal Cost)
		{
			MarkTransferEntity _MarkTransferEntity = new MarkTransferEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_MarkTransferEntity.Code = Code;
				_MarkTransferEntity.Mark = Mark;
				_MarkTransferEntity.Cost = Cost;
				adapter.SaveEntity(_MarkTransferEntity, true);
			}
			return _MarkTransferEntity;
		}

		public bool Update(MarkTransferEntity _MarkTransferEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(MarkTransferFields.Id == _MarkTransferEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_MarkTransferEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(MarkTransferEntity _MarkTransferEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_MarkTransferEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string Code, int Mark, decimal Cost)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				MarkTransferEntity _MarkTransferEntity = new MarkTransferEntity(Id);
				if (adapter.FetchEntity(_MarkTransferEntity))
				{
				
					_MarkTransferEntity.Code = Code;
					_MarkTransferEntity.Mark = Mark;
					_MarkTransferEntity.Cost = Cost;
					adapter.SaveEntity(_MarkTransferEntity, true);
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
				MarkTransferEntity _MarkTransferEntity = new MarkTransferEntity(Id);
				if (adapter.FetchEntity(_MarkTransferEntity))
				{
					adapter.DeleteEntity(_MarkTransferEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("MarkTransferEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkTransferFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MarkTransferEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCode(string Code)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkTransferFields.Code == Code);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MarkTransferEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMark(int Mark)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkTransferFields.Mark == Mark);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MarkTransferEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCost(decimal Cost)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkTransferFields.Cost == Cost);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MarkTransferEntity", filter);
			}
			return toReturn;
		}
		

		
		public MarkTransferEntity SelectOne(Guid Id)
		{
			MarkTransferEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				MarkTransferEntity _MarkTransferEntity = new MarkTransferEntity(Id);
				if (adapter.FetchEntity(_MarkTransferEntity))
				{
					toReturn = _MarkTransferEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MarkTransferCollection = new EntityCollection(new MarkTransferEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MarkTransferCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<MarkTransferEntity>
		public EntityCollection<MarkTransferEntity> SelectAllLST()
		{
			EntityCollection<MarkTransferEntity> _MarkTransferCollection = new EntityCollection<MarkTransferEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MarkTransferCollection, null, 0, null);
			}
			return _MarkTransferCollection;
		}
		
		// Return EntityCollection<MarkTransferEntity>
		public EntityCollection<MarkTransferEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<MarkTransferEntity> _MarkTransferCollection = new EntityCollection<MarkTransferEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MarkTransferCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _MarkTransferCollection;
		}


		
		// Return EntityCollection<MarkTransferEntity>
		public EntityCollection<MarkTransferEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<MarkTransferEntity> _MarkTransferCollection = new EntityCollection<MarkTransferEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkTransferFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MarkTransferCollection, filter, 0, null);
			}
			return _MarkTransferCollection;
		}
		
		// Return EntityCollection<MarkTransferEntity>
		public EntityCollection<MarkTransferEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<MarkTransferEntity> _MarkTransferCollection = new EntityCollection<MarkTransferEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkTransferFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MarkTransferCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _MarkTransferCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MarkTransferCollection = new EntityCollection(new MarkTransferEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkTransferFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MarkTransferCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MarkTransferCollection = new EntityCollection(new MarkTransferEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkTransferFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MarkTransferCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<MarkTransferEntity>
		public EntityCollection<MarkTransferEntity> SelectByCodeLST(string Code)
		{
			EntityCollection<MarkTransferEntity> _MarkTransferCollection = new EntityCollection<MarkTransferEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkTransferFields.Code == Code);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MarkTransferCollection, filter, 0, null);
			}
			return _MarkTransferCollection;
		}
		
		// Return EntityCollection<MarkTransferEntity>
		public EntityCollection<MarkTransferEntity> SelectByCodeLST_Paged(string Code, int PageNumber, int PageSize)
		{
			EntityCollection<MarkTransferEntity> _MarkTransferCollection = new EntityCollection<MarkTransferEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkTransferFields.Code == Code);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MarkTransferCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _MarkTransferCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCodeRDT(string Code)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MarkTransferCollection = new EntityCollection(new MarkTransferEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkTransferFields.Code == Code);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MarkTransferCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCodeRDT_Paged(string Code, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MarkTransferCollection = new EntityCollection(new MarkTransferEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkTransferFields.Code == Code);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MarkTransferCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<MarkTransferEntity>
		public EntityCollection<MarkTransferEntity> SelectByMarkLST(int Mark)
		{
			EntityCollection<MarkTransferEntity> _MarkTransferCollection = new EntityCollection<MarkTransferEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkTransferFields.Mark == Mark);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MarkTransferCollection, filter, 0, null);
			}
			return _MarkTransferCollection;
		}
		
		// Return EntityCollection<MarkTransferEntity>
		public EntityCollection<MarkTransferEntity> SelectByMarkLST_Paged(int Mark, int PageNumber, int PageSize)
		{
			EntityCollection<MarkTransferEntity> _MarkTransferCollection = new EntityCollection<MarkTransferEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkTransferFields.Mark == Mark);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MarkTransferCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _MarkTransferCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMarkRDT(int Mark)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MarkTransferCollection = new EntityCollection(new MarkTransferEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkTransferFields.Mark == Mark);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MarkTransferCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMarkRDT_Paged(int Mark, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MarkTransferCollection = new EntityCollection(new MarkTransferEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkTransferFields.Mark == Mark);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MarkTransferCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<MarkTransferEntity>
		public EntityCollection<MarkTransferEntity> SelectByCostLST(decimal Cost)
		{
			EntityCollection<MarkTransferEntity> _MarkTransferCollection = new EntityCollection<MarkTransferEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkTransferFields.Cost == Cost);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MarkTransferCollection, filter, 0, null);
			}
			return _MarkTransferCollection;
		}
		
		// Return EntityCollection<MarkTransferEntity>
		public EntityCollection<MarkTransferEntity> SelectByCostLST_Paged(decimal Cost, int PageNumber, int PageSize)
		{
			EntityCollection<MarkTransferEntity> _MarkTransferCollection = new EntityCollection<MarkTransferEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkTransferFields.Cost == Cost);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MarkTransferCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _MarkTransferCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCostRDT(decimal Cost)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MarkTransferCollection = new EntityCollection(new MarkTransferEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkTransferFields.Cost == Cost);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MarkTransferCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCostRDT_Paged(decimal Cost, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MarkTransferCollection = new EntityCollection(new MarkTransferEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MarkTransferFields.Cost == Cost);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MarkTransferCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
