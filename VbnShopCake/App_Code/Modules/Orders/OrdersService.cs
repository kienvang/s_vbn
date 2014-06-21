using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;

using LayerHelper.ShopCake.BLL;
using LayerHelper.ShopCake.DAL.EntityClasses;
using Modules;
using Library.Tools;

/// <summary>
/// Summary description for OrdersService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[System.Web.Script.Services.ScriptService]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class OrdersService : System.Web.Services.WebService {

    public OrdersService () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld() {
        return "Hello World";
    }

    [WebMethod]
    public bool SetPaidComplete(string OrderCode)
    {
        bool status = false;

        OrdersEntity order = OrdersManager.CreateInstant().GetByOrderCode(OrderCode);
        if (order != null && !order.PaidCompleted)
        {
            string tagId = OrdersJoinTagsManager.CreateInstant().GetTag(order.Id);
            if (tagId != EnumsTags.CANCEL && tagId != EnumsTags.PAID)
            {
                order.PaidCompleted = true;
                order.UpdatedBy = Util.CurrentUserName;
                order.UpdatedDate = DateTime.Now;

                OrdersManager.CreateInstant().Update(order);

                PaymentsManager.CreateInstant().AddPayment(order.Id, order.TotalPaid);

                OrdersJoinTagsManager.CreateInstant().AddTag(EnumsTags.PAID, order.Id);

                HistoryOrdersManager.CreateInstant().AddHistory("Thanh toán thành công", order.OrderCode);

                status = true;
            }
        }

        return status;
    }
}

