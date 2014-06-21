




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.EmailTemplatesManagerBase
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
	public class EmailTemplatesManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public EmailTemplatesManagerBase()
		{
			// Nothing for now.
		}
		
		public EmailTemplatesEntity Insert(EmailTemplatesEntity _EmailTemplatesEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_EmailTemplatesEntity, true);
			}
			return _EmailTemplatesEntity;
		}

		
		public EmailTemplatesEntity Insert(Guid Id, string TemplateCode, string TemplateName, string Subject, string Body, string CreatedBy, DateTime CreatedDate, string UpdatedBy, DateTime UpdatedDate)
		{
			EmailTemplatesEntity _EmailTemplatesEntity = new EmailTemplatesEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_EmailTemplatesEntity.Id = Id;
				_EmailTemplatesEntity.TemplateCode = TemplateCode;
				_EmailTemplatesEntity.TemplateName = TemplateName;
				_EmailTemplatesEntity.Subject = Subject;
				_EmailTemplatesEntity.Body = Body;
				_EmailTemplatesEntity.CreatedBy = CreatedBy;
				_EmailTemplatesEntity.CreatedDate = CreatedDate;
				_EmailTemplatesEntity.UpdatedBy = UpdatedBy;
				_EmailTemplatesEntity.UpdatedDate = UpdatedDate;
				adapter.SaveEntity(_EmailTemplatesEntity, true);
			}
			return _EmailTemplatesEntity;
		}

		public EmailTemplatesEntity Insert(string TemplateCode, string TemplateName, string Subject, string Body, string CreatedBy, DateTime CreatedDate, string UpdatedBy, DateTime UpdatedDate)
		{
			EmailTemplatesEntity _EmailTemplatesEntity = new EmailTemplatesEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_EmailTemplatesEntity.TemplateCode = TemplateCode;
				_EmailTemplatesEntity.TemplateName = TemplateName;
				_EmailTemplatesEntity.Subject = Subject;
				_EmailTemplatesEntity.Body = Body;
				_EmailTemplatesEntity.CreatedBy = CreatedBy;
				_EmailTemplatesEntity.CreatedDate = CreatedDate;
				_EmailTemplatesEntity.UpdatedBy = UpdatedBy;
				_EmailTemplatesEntity.UpdatedDate = UpdatedDate;
				adapter.SaveEntity(_EmailTemplatesEntity, true);
			}
			return _EmailTemplatesEntity;
		}

		public bool Update(EmailTemplatesEntity _EmailTemplatesEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(EmailTemplatesFields.Id == _EmailTemplatesEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_EmailTemplatesEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(EmailTemplatesEntity _EmailTemplatesEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_EmailTemplatesEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string TemplateCode, string TemplateName, string Subject, string Body, string CreatedBy, DateTime CreatedDate, string UpdatedBy, DateTime UpdatedDate)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				EmailTemplatesEntity _EmailTemplatesEntity = new EmailTemplatesEntity(Id);
				if (adapter.FetchEntity(_EmailTemplatesEntity))
				{
				
					_EmailTemplatesEntity.TemplateCode = TemplateCode;
					_EmailTemplatesEntity.TemplateName = TemplateName;
					_EmailTemplatesEntity.Subject = Subject;
					_EmailTemplatesEntity.Body = Body;
					_EmailTemplatesEntity.CreatedBy = CreatedBy;
					_EmailTemplatesEntity.CreatedDate = CreatedDate;
					_EmailTemplatesEntity.UpdatedBy = UpdatedBy;
					_EmailTemplatesEntity.UpdatedDate = UpdatedDate;
					adapter.SaveEntity(_EmailTemplatesEntity, true);
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
				EmailTemplatesEntity _EmailTemplatesEntity = new EmailTemplatesEntity(Id);
				if (adapter.FetchEntity(_EmailTemplatesEntity))
				{
					adapter.DeleteEntity(_EmailTemplatesEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("EmailTemplatesEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmailTemplatesFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("EmailTemplatesEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTemplateCode(string TemplateCode)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmailTemplatesFields.TemplateCode == TemplateCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("EmailTemplatesEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTemplateName(string TemplateName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmailTemplatesFields.TemplateName == TemplateName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("EmailTemplatesEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySubject(string Subject)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmailTemplatesFields.Subject == Subject);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("EmailTemplatesEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByBody(string Body)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmailTemplatesFields.Body == Body);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("EmailTemplatesEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCreatedBy(string CreatedBy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmailTemplatesFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("EmailTemplatesEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCreatedDate(DateTime CreatedDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmailTemplatesFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("EmailTemplatesEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByUpdatedBy(string UpdatedBy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmailTemplatesFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("EmailTemplatesEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByUpdatedDate(DateTime UpdatedDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmailTemplatesFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("EmailTemplatesEntity", filter);
			}
			return toReturn;
		}
		

		
		public EmailTemplatesEntity SelectOne(Guid Id)
		{
			EmailTemplatesEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				EmailTemplatesEntity _EmailTemplatesEntity = new EmailTemplatesEntity(Id);
				if (adapter.FetchEntity(_EmailTemplatesEntity))
				{
					toReturn = _EmailTemplatesEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EmailTemplatesCollection = new EntityCollection(new EmailTemplatesEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EmailTemplatesCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<EmailTemplatesEntity>
		public EntityCollection<EmailTemplatesEntity> SelectAllLST()
		{
			EntityCollection<EmailTemplatesEntity> _EmailTemplatesCollection = new EntityCollection<EmailTemplatesEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EmailTemplatesCollection, null, 0, null);
			}
			return _EmailTemplatesCollection;
		}
		
		// Return EntityCollection<EmailTemplatesEntity>
		public EntityCollection<EmailTemplatesEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<EmailTemplatesEntity> _EmailTemplatesCollection = new EntityCollection<EmailTemplatesEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EmailTemplatesCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _EmailTemplatesCollection;
		}


		
		// Return EntityCollection<EmailTemplatesEntity>
		public EntityCollection<EmailTemplatesEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<EmailTemplatesEntity> _EmailTemplatesCollection = new EntityCollection<EmailTemplatesEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmailTemplatesFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EmailTemplatesCollection, filter, 0, null);
			}
			return _EmailTemplatesCollection;
		}
		
		// Return EntityCollection<EmailTemplatesEntity>
		public EntityCollection<EmailTemplatesEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<EmailTemplatesEntity> _EmailTemplatesCollection = new EntityCollection<EmailTemplatesEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmailTemplatesFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EmailTemplatesCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _EmailTemplatesCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EmailTemplatesCollection = new EntityCollection(new EmailTemplatesEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmailTemplatesFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EmailTemplatesCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EmailTemplatesCollection = new EntityCollection(new EmailTemplatesEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmailTemplatesFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EmailTemplatesCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<EmailTemplatesEntity>
		public EntityCollection<EmailTemplatesEntity> SelectByTemplateCodeLST(string TemplateCode)
		{
			EntityCollection<EmailTemplatesEntity> _EmailTemplatesCollection = new EntityCollection<EmailTemplatesEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmailTemplatesFields.TemplateCode == TemplateCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EmailTemplatesCollection, filter, 0, null);
			}
			return _EmailTemplatesCollection;
		}
		
		// Return EntityCollection<EmailTemplatesEntity>
		public EntityCollection<EmailTemplatesEntity> SelectByTemplateCodeLST_Paged(string TemplateCode, int PageNumber, int PageSize)
		{
			EntityCollection<EmailTemplatesEntity> _EmailTemplatesCollection = new EntityCollection<EmailTemplatesEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmailTemplatesFields.TemplateCode == TemplateCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EmailTemplatesCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _EmailTemplatesCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTemplateCodeRDT(string TemplateCode)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EmailTemplatesCollection = new EntityCollection(new EmailTemplatesEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmailTemplatesFields.TemplateCode == TemplateCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EmailTemplatesCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTemplateCodeRDT_Paged(string TemplateCode, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EmailTemplatesCollection = new EntityCollection(new EmailTemplatesEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmailTemplatesFields.TemplateCode == TemplateCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EmailTemplatesCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<EmailTemplatesEntity>
		public EntityCollection<EmailTemplatesEntity> SelectByTemplateNameLST(string TemplateName)
		{
			EntityCollection<EmailTemplatesEntity> _EmailTemplatesCollection = new EntityCollection<EmailTemplatesEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmailTemplatesFields.TemplateName == TemplateName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EmailTemplatesCollection, filter, 0, null);
			}
			return _EmailTemplatesCollection;
		}
		
		// Return EntityCollection<EmailTemplatesEntity>
		public EntityCollection<EmailTemplatesEntity> SelectByTemplateNameLST_Paged(string TemplateName, int PageNumber, int PageSize)
		{
			EntityCollection<EmailTemplatesEntity> _EmailTemplatesCollection = new EntityCollection<EmailTemplatesEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmailTemplatesFields.TemplateName == TemplateName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EmailTemplatesCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _EmailTemplatesCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTemplateNameRDT(string TemplateName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EmailTemplatesCollection = new EntityCollection(new EmailTemplatesEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmailTemplatesFields.TemplateName == TemplateName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EmailTemplatesCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTemplateNameRDT_Paged(string TemplateName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EmailTemplatesCollection = new EntityCollection(new EmailTemplatesEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmailTemplatesFields.TemplateName == TemplateName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EmailTemplatesCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<EmailTemplatesEntity>
		public EntityCollection<EmailTemplatesEntity> SelectBySubjectLST(string Subject)
		{
			EntityCollection<EmailTemplatesEntity> _EmailTemplatesCollection = new EntityCollection<EmailTemplatesEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmailTemplatesFields.Subject == Subject);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EmailTemplatesCollection, filter, 0, null);
			}
			return _EmailTemplatesCollection;
		}
		
		// Return EntityCollection<EmailTemplatesEntity>
		public EntityCollection<EmailTemplatesEntity> SelectBySubjectLST_Paged(string Subject, int PageNumber, int PageSize)
		{
			EntityCollection<EmailTemplatesEntity> _EmailTemplatesCollection = new EntityCollection<EmailTemplatesEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmailTemplatesFields.Subject == Subject);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EmailTemplatesCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _EmailTemplatesCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySubjectRDT(string Subject)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EmailTemplatesCollection = new EntityCollection(new EmailTemplatesEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmailTemplatesFields.Subject == Subject);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EmailTemplatesCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySubjectRDT_Paged(string Subject, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EmailTemplatesCollection = new EntityCollection(new EmailTemplatesEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmailTemplatesFields.Subject == Subject);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EmailTemplatesCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<EmailTemplatesEntity>
		public EntityCollection<EmailTemplatesEntity> SelectByBodyLST(string Body)
		{
			EntityCollection<EmailTemplatesEntity> _EmailTemplatesCollection = new EntityCollection<EmailTemplatesEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmailTemplatesFields.Body == Body);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EmailTemplatesCollection, filter, 0, null);
			}
			return _EmailTemplatesCollection;
		}
		
		// Return EntityCollection<EmailTemplatesEntity>
		public EntityCollection<EmailTemplatesEntity> SelectByBodyLST_Paged(string Body, int PageNumber, int PageSize)
		{
			EntityCollection<EmailTemplatesEntity> _EmailTemplatesCollection = new EntityCollection<EmailTemplatesEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmailTemplatesFields.Body == Body);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EmailTemplatesCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _EmailTemplatesCollection;
		}
		
		// Return DataTable
		public DataTable SelectByBodyRDT(string Body)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EmailTemplatesCollection = new EntityCollection(new EmailTemplatesEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmailTemplatesFields.Body == Body);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EmailTemplatesCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByBodyRDT_Paged(string Body, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EmailTemplatesCollection = new EntityCollection(new EmailTemplatesEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmailTemplatesFields.Body == Body);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EmailTemplatesCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<EmailTemplatesEntity>
		public EntityCollection<EmailTemplatesEntity> SelectByCreatedByLST(string CreatedBy)
		{
			EntityCollection<EmailTemplatesEntity> _EmailTemplatesCollection = new EntityCollection<EmailTemplatesEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmailTemplatesFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EmailTemplatesCollection, filter, 0, null);
			}
			return _EmailTemplatesCollection;
		}
		
		// Return EntityCollection<EmailTemplatesEntity>
		public EntityCollection<EmailTemplatesEntity> SelectByCreatedByLST_Paged(string CreatedBy, int PageNumber, int PageSize)
		{
			EntityCollection<EmailTemplatesEntity> _EmailTemplatesCollection = new EntityCollection<EmailTemplatesEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmailTemplatesFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EmailTemplatesCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _EmailTemplatesCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedByRDT(string CreatedBy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EmailTemplatesCollection = new EntityCollection(new EmailTemplatesEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmailTemplatesFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EmailTemplatesCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedByRDT_Paged(string CreatedBy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EmailTemplatesCollection = new EntityCollection(new EmailTemplatesEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmailTemplatesFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EmailTemplatesCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<EmailTemplatesEntity>
		public EntityCollection<EmailTemplatesEntity> SelectByCreatedDateLST(DateTime CreatedDate)
		{
			EntityCollection<EmailTemplatesEntity> _EmailTemplatesCollection = new EntityCollection<EmailTemplatesEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmailTemplatesFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EmailTemplatesCollection, filter, 0, null);
			}
			return _EmailTemplatesCollection;
		}
		
		// Return EntityCollection<EmailTemplatesEntity>
		public EntityCollection<EmailTemplatesEntity> SelectByCreatedDateLST_Paged(DateTime CreatedDate, int PageNumber, int PageSize)
		{
			EntityCollection<EmailTemplatesEntity> _EmailTemplatesCollection = new EntityCollection<EmailTemplatesEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmailTemplatesFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EmailTemplatesCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _EmailTemplatesCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedDateRDT(DateTime CreatedDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EmailTemplatesCollection = new EntityCollection(new EmailTemplatesEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmailTemplatesFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EmailTemplatesCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedDateRDT_Paged(DateTime CreatedDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EmailTemplatesCollection = new EntityCollection(new EmailTemplatesEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmailTemplatesFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EmailTemplatesCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<EmailTemplatesEntity>
		public EntityCollection<EmailTemplatesEntity> SelectByUpdatedByLST(string UpdatedBy)
		{
			EntityCollection<EmailTemplatesEntity> _EmailTemplatesCollection = new EntityCollection<EmailTemplatesEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmailTemplatesFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EmailTemplatesCollection, filter, 0, null);
			}
			return _EmailTemplatesCollection;
		}
		
		// Return EntityCollection<EmailTemplatesEntity>
		public EntityCollection<EmailTemplatesEntity> SelectByUpdatedByLST_Paged(string UpdatedBy, int PageNumber, int PageSize)
		{
			EntityCollection<EmailTemplatesEntity> _EmailTemplatesCollection = new EntityCollection<EmailTemplatesEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmailTemplatesFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EmailTemplatesCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _EmailTemplatesCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedByRDT(string UpdatedBy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EmailTemplatesCollection = new EntityCollection(new EmailTemplatesEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmailTemplatesFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EmailTemplatesCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedByRDT_Paged(string UpdatedBy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EmailTemplatesCollection = new EntityCollection(new EmailTemplatesEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmailTemplatesFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EmailTemplatesCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<EmailTemplatesEntity>
		public EntityCollection<EmailTemplatesEntity> SelectByUpdatedDateLST(DateTime UpdatedDate)
		{
			EntityCollection<EmailTemplatesEntity> _EmailTemplatesCollection = new EntityCollection<EmailTemplatesEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmailTemplatesFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EmailTemplatesCollection, filter, 0, null);
			}
			return _EmailTemplatesCollection;
		}
		
		// Return EntityCollection<EmailTemplatesEntity>
		public EntityCollection<EmailTemplatesEntity> SelectByUpdatedDateLST_Paged(DateTime UpdatedDate, int PageNumber, int PageSize)
		{
			EntityCollection<EmailTemplatesEntity> _EmailTemplatesCollection = new EntityCollection<EmailTemplatesEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmailTemplatesFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EmailTemplatesCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _EmailTemplatesCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedDateRDT(DateTime UpdatedDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EmailTemplatesCollection = new EntityCollection(new EmailTemplatesEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmailTemplatesFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EmailTemplatesCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedDateRDT_Paged(DateTime UpdatedDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EmailTemplatesCollection = new EntityCollection(new EmailTemplatesEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmailTemplatesFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EmailTemplatesCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
