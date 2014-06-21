
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.EventsManager
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

using Modules.Events;

namespace LayerHelper.ShopCake.BLL
{
	public class EventsManager : EventsManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public EventsManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of EventsManager
		/// </summary>
		/// <returns>An instant of EventsManager class</returns>
		public static EventsManager CreateInstant()
		{
			return new EventsManager();
		}

        public void AddEvent(string EventName, string EventType)
        {
            AddEvent(EventName, EventType, "");
        }

        public void AddEvent(string EventName, string EventType, string Id)
        {
            string AddressUrl = "";

            switch (EventType)
            {
                case EnumsEvents.Order:
                    AddressUrl = UrlBuilder.Order(Id);
                    break;
                case EnumsEvents.RegisterProduct:
                    AddressUrl = UrlBuilder.RegisterProduct(Id);
                    break;
                case EnumsEvents.RegisterSupplier:
                    AddressUrl = UrlBuilder.RegisterSupplier();
                    break;
                case EnumsEvents.FeedBack:
                    AddressUrl = UrlBuilder.FeedBack();
                    break;
            }

            EventsEntity _event = new EventsEntity();
            _event.Id = Guid.NewGuid();
            _event.EventName = Library.Tools.Filter.GetMaxString(EventName, EventsFields.EventName.MaxLength);
            _event.EventType = EventType;
            _event.AddressUrl = AddressUrl;
            _event.CreatedBy = Library.Tools.Util.CurrentUserName;

            EventsManager.CreateInstant().Insert(_event);
        }

        public EntityCollection<EventsEntity> GetEvents(string EventType)
        {
            EntityCollection<EventsEntity> items = new EntityCollection<EventsEntity>();

            IPredicateExpression predicate = new PredicateExpression();
            predicate.Add(EventsFields.EventType == EventType);
            predicate.AddWithAnd(EventsFields.Approved == false);

            RelationPredicateBucket filter = new RelationPredicateBucket();
            filter.PredicateExpression.Add(predicate);

            SortExpression sort = new SortExpression();
            sort.Add(EventsFields.CreatedDate | SortOperator.Descending);

            using (DataAccessAdapterBase adapter = new DataAccessAdapterFactory().CreateAdapter())
            {
                adapter.FetchEntityCollection(items, filter);
            }

            return items;
        }
	}
}
