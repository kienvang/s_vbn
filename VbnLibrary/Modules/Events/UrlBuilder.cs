using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modules.Events
{
    public class UrlBuilder
    {
        public static string Order(string OrderNumber)
        {
            return "/Admin/Orders/OrderDetail.aspx?OrderNumber=" + OrderNumber;
        }

        public static string RegisterProduct(string Id)
        {
            return "/Admin/Registers/ProductRegisterDetail.aspx?id=" + Id;
        }

        public static string RegisterSupplier()
        {
            return "/Admin/Registers/SuppliersRegister.aspx";
        }

        public static string FeedBack()
        {
            return "/Admin/FeedBack/";
        }
    }
}
