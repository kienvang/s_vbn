using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;

using LayerHelper.ShopCake.BLL;
using LayerHelper.ShopCake.DAL.EntityClasses;
using LayerHelper.ShopCake.DAL.HelperClasses;

using Library.Tools;
/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[System.Web.Script.Services.ScriptService]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService {

    public WebService () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld() {
        return "Hello World";
    }

    [WebMethod]
    public void UpdateVisibleHome(string videoid)
    {
        if (Util.IsGuid(videoid))
        {
            VideosEntity video = VideosManager.CreateInstant().SelectOne(new Guid(videoid));
            if (video != null)
            {
                VideosManager.CreateInstant().UpdateVisibleVideo();
                video.IsVisibleHome = true;
                VideosManager.CreateInstant().Update(video);
            }
        }
    }

    [WebMethod]
    public bool UpdatePositionType(string AdvertPositionId, string PositionType)
    {
        if (Util.IsGuid(AdvertPositionId))
        {
            AdvertsPositionEntity advert = AdvertsPositionManager.CreateInstant().SelectOne(new Guid(AdvertPositionId));
            if (advert != null)
            {
                advert.PositionTypeId = PositionType;
                AdvertsPositionManager.CreateInstant().Update(advert);
            }
        }
        return true;
    }

    [WebMethod]
    public string Encoding(string val)
    {
        return Modules.Products.UrlBuilder.QuickSearch(Server.UrlEncode(val));
    }

    [WebMethod]
    public string Search(string ProductName, string Price, string CatalogName)
    {
        return Modules.Products.UrlBuilder.Search(ProductName, Price, CatalogName);
    }

    [WebMethod]
    public void ApprovedEvent(string EventId)
    {
        if (Util.IsGuid(EventId))
        {
            EventsEntity eve = EventsManager.CreateInstant().SelectOne(new Guid(EventId));
            if (eve != null)
            {
                eve.Approved = true;
                eve.ApprovedBy = Util.CurrentUserName;
                eve.ApprovedDate = DateTime.Now;

                EventsManager.CreateInstant().Update(eve);
            }
        }
    }

    [WebMethod]
    public bool UpdateAdvertPosition(string id, string typeid)
    {
        if (Util.IsGuid(id))
        {
            AdvertsPositionEntity item = AdvertsPositionManager.CreateInstant().GetById(new Guid(id));
            if (item != null)
            {
                item.PositionTypeId = typeid;
                AdvertsPositionManager.CreateInstant().Update(item);

                return true;
            }
        }
        return false;
    }

    [WebMethod]
    public void UpdateDocument(Guid ID)
    {
        DocumentEntity obj = DocumentManager.CreateInstant().GetByID(ID);
        if (obj != null)
        {
            obj.IsVisible = !obj.IsVisible;
            DocumentManager.CreateInstant().Update(obj);
        }
    }

    [WebMethod]
    public void UpdateDocumentVideo(Guid ID)
    {
        DocumentEntity obj = DocumentManager.CreateInstant().GetByID(ID);
        if (obj != null)
        {
            obj.ShowVideo = !obj.ShowVideo;
            DocumentManager.CreateInstant().Update(obj);
        }
    }

    [WebMethod]
    public void UpdateReMark(string id, string mark)
    {
        if (!string.IsNullOrEmpty(id))
        {
            DocumentEntity obj = DocumentManager.CreateInstant().GetByIntId(int.Parse(id));
            if (obj != null)
            {
                int intMark = 0;
                if (!string.IsNullOrEmpty(mark))
                    intMark = int.Parse(mark);
                obj.ReMark = obj.ReMark + intMark;
                DocumentManager.CreateInstant().Update(obj);
            }
        }
    }
}

