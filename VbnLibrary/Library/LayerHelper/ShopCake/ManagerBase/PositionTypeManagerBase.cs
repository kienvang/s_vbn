




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.PositionTypeManagerBase
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
	public class PositionTypeManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public PositionTypeManagerBase()
		{
			// Nothing for now.
		}
		
		public PositionTypeEntity Insert(PositionTypeEntity _PositionTypeEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_PositionTypeEntity, true);
			}
			return _PositionTypeEntity;
		}

		
		public PositionTypeEntity Insert(string Id, string TypeName, int Height, int Width)
		{
			PositionTypeEntity _PositionTypeEntity = new PositionTypeEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_PositionTypeEntity.Id = Id;
				_PositionTypeEntity.TypeName = TypeName;
				_PositionTypeEntity.Height = Height;
				_PositionTypeEntity.Width = Width;
				adapter.SaveEntity(_PositionTypeEntity, true);
			}
			return _PositionTypeEntity;
		}

		public PositionTypeEntity Insert(string TypeName, int Height, int Width)
		{
			PositionTypeEntity _PositionTypeEntity = new PositionTypeEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_PositionTypeEntity.TypeName = TypeName;
				_PositionTypeEntity.Height = Height;
				_PositionTypeEntity.Width = Width;
				adapter.SaveEntity(_PositionTypeEntity, true);
			}
			return _PositionTypeEntity;
		}

		public bool Update(PositionTypeEntity _PositionTypeEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(PositionTypeFields.Id == _PositionTypeEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_PositionTypeEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(PositionTypeEntity _PositionTypeEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_PositionTypeEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(string Id, string TypeName, int Height, int Width)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				PositionTypeEntity _PositionTypeEntity = new PositionTypeEntity(Id);
				if (adapter.FetchEntity(_PositionTypeEntity))
				{
				
					_PositionTypeEntity.TypeName = TypeName;
					_PositionTypeEntity.Height = Height;
					_PositionTypeEntity.Width = Width;
					adapter.SaveEntity(_PositionTypeEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(string Id)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				PositionTypeEntity _PositionTypeEntity = new PositionTypeEntity(Id);
				if (adapter.FetchEntity(_PositionTypeEntity))
				{
					adapter.DeleteEntity(_PositionTypeEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("PositionTypeEntity", null);
			}
		}
		
		
		public int DeleteById(string Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PositionTypeFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PositionTypeEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTypeName(string TypeName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PositionTypeFields.TypeName == TypeName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PositionTypeEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByHeight(int Height)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PositionTypeFields.Height == Height);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PositionTypeEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByWidth(int Width)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PositionTypeFields.Width == Width);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PositionTypeEntity", filter);
			}
			return toReturn;
		}
		

		
		public PositionTypeEntity SelectOne(string Id)
		{
			PositionTypeEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				PositionTypeEntity _PositionTypeEntity = new PositionTypeEntity(Id);
				if (adapter.FetchEntity(_PositionTypeEntity))
				{
					toReturn = _PositionTypeEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PositionTypeCollection = new EntityCollection(new PositionTypeEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PositionTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<PositionTypeEntity>
		public EntityCollection<PositionTypeEntity> SelectAllLST()
		{
			EntityCollection<PositionTypeEntity> _PositionTypeCollection = new EntityCollection<PositionTypeEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PositionTypeCollection, null, 0, null);
			}
			return _PositionTypeCollection;
		}
		
		// Return EntityCollection<PositionTypeEntity>
		public EntityCollection<PositionTypeEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<PositionTypeEntity> _PositionTypeCollection = new EntityCollection<PositionTypeEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PositionTypeCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _PositionTypeCollection;
		}


		
		// Return EntityCollection<PositionTypeEntity>
		public EntityCollection<PositionTypeEntity> SelectByIdLST(string Id)
		{
			EntityCollection<PositionTypeEntity> _PositionTypeCollection = new EntityCollection<PositionTypeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PositionTypeFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PositionTypeCollection, filter, 0, null);
			}
			return _PositionTypeCollection;
		}
		
		// Return EntityCollection<PositionTypeEntity>
		public EntityCollection<PositionTypeEntity> SelectByIdLST_Paged(string Id, int PageNumber, int PageSize)
		{
			EntityCollection<PositionTypeEntity> _PositionTypeCollection = new EntityCollection<PositionTypeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PositionTypeFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PositionTypeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PositionTypeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(string Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PositionTypeCollection = new EntityCollection(new PositionTypeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PositionTypeFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PositionTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(string Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PositionTypeCollection = new EntityCollection(new PositionTypeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PositionTypeFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PositionTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PositionTypeEntity>
		public EntityCollection<PositionTypeEntity> SelectByTypeNameLST(string TypeName)
		{
			EntityCollection<PositionTypeEntity> _PositionTypeCollection = new EntityCollection<PositionTypeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PositionTypeFields.TypeName == TypeName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PositionTypeCollection, filter, 0, null);
			}
			return _PositionTypeCollection;
		}
		
		// Return EntityCollection<PositionTypeEntity>
		public EntityCollection<PositionTypeEntity> SelectByTypeNameLST_Paged(string TypeName, int PageNumber, int PageSize)
		{
			EntityCollection<PositionTypeEntity> _PositionTypeCollection = new EntityCollection<PositionTypeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PositionTypeFields.TypeName == TypeName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PositionTypeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PositionTypeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTypeNameRDT(string TypeName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PositionTypeCollection = new EntityCollection(new PositionTypeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PositionTypeFields.TypeName == TypeName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PositionTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTypeNameRDT_Paged(string TypeName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PositionTypeCollection = new EntityCollection(new PositionTypeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PositionTypeFields.TypeName == TypeName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PositionTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PositionTypeEntity>
		public EntityCollection<PositionTypeEntity> SelectByHeightLST(int Height)
		{
			EntityCollection<PositionTypeEntity> _PositionTypeCollection = new EntityCollection<PositionTypeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PositionTypeFields.Height == Height);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PositionTypeCollection, filter, 0, null);
			}
			return _PositionTypeCollection;
		}
		
		// Return EntityCollection<PositionTypeEntity>
		public EntityCollection<PositionTypeEntity> SelectByHeightLST_Paged(int Height, int PageNumber, int PageSize)
		{
			EntityCollection<PositionTypeEntity> _PositionTypeCollection = new EntityCollection<PositionTypeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PositionTypeFields.Height == Height);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PositionTypeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PositionTypeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByHeightRDT(int Height)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PositionTypeCollection = new EntityCollection(new PositionTypeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PositionTypeFields.Height == Height);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PositionTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByHeightRDT_Paged(int Height, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PositionTypeCollection = new EntityCollection(new PositionTypeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PositionTypeFields.Height == Height);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PositionTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PositionTypeEntity>
		public EntityCollection<PositionTypeEntity> SelectByWidthLST(int Width)
		{
			EntityCollection<PositionTypeEntity> _PositionTypeCollection = new EntityCollection<PositionTypeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PositionTypeFields.Width == Width);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PositionTypeCollection, filter, 0, null);
			}
			return _PositionTypeCollection;
		}
		
		// Return EntityCollection<PositionTypeEntity>
		public EntityCollection<PositionTypeEntity> SelectByWidthLST_Paged(int Width, int PageNumber, int PageSize)
		{
			EntityCollection<PositionTypeEntity> _PositionTypeCollection = new EntityCollection<PositionTypeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PositionTypeFields.Width == Width);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PositionTypeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PositionTypeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByWidthRDT(int Width)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PositionTypeCollection = new EntityCollection(new PositionTypeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PositionTypeFields.Width == Width);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PositionTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByWidthRDT_Paged(int Width, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PositionTypeCollection = new EntityCollection(new PositionTypeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PositionTypeFields.Width == Width);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PositionTypeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
