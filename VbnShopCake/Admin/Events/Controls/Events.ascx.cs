using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

using LayerHelper.ShopCake.BLL;
using LayerHelper.ShopCake.DAL.EntityClasses;
using LayerHelper.ShopCake.DAL.HelperClasses;

public partial class Admin_Events_Controls_Events : System.Web.UI.UserControl
{
    public string EventType { get; set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        LoadEventType();
        LoadEvent();
    }

    void LoadEventType()
    {
        EventTypeEntity type = EventTypeManager.CreateInstant().SelectOne(EventType);
        if (type != null)
        {
            lblEventType.Text = type.TypeName;
        }
    }

    void LoadEvent()
    {
        EntityCollection<EventsEntity> events = EventsManager.CreateInstant().GetEvents(EventType);
        if (events != null && events.Count > 0)
        {
            lblNote.Visible = false;

            repEvent.DataSource = events;
            repEvent.DataBind();
        }
    }
}
