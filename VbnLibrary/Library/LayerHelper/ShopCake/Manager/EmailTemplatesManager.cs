
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.EmailTemplatesManager
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
using System.Web;
using System.IO;

using Library.Tools;

namespace LayerHelper.ShopCake.BLL
{
    public class EmailTemplatesManager : EmailTemplatesManagerBase
    {
        /// <summary>
        /// Purpose: Class constructor.
        /// </summary>
        public EmailTemplatesManager()
        {
            // Nothing for now.
        }

        /// <summary>
        /// Method to create an instance of EmailTemplatesManager
        /// </summary>
        /// <returns>An instant of EmailTemplatesManager class</returns>
        public static EmailTemplatesManager CreateInstant()
        {
            return new EmailTemplatesManager();
        }

        public EmailTemplatesEntity GetTemplateByTemplateCode(string TemplateCode)
        {
            EntityCollection<EmailTemplatesEntity> items = SelectByTemplateCodeLST(TemplateCode);
            if (items != null && items.Count > 0)
                return items[0];
            return null;
        }

        public EmailTemplatesEntity GetOrderCompleted(Guid OrderId, string detail)
        {
            EmailTemplatesEntity template = GetTemplateByTemplateCode("OrderComplete");
            if (template != null)
            {
                OrdersEntity order = OrdersManager.CreateInstant().SelectOne(OrderId);
                if (order != null)
                {
                    template.Subject = template.Subject.Replace("[OrderCode/]", order.OrderCode);

                    template.Body = template.Body.Replace("[OrderCode/]", order.OrderCode);
                    template.Body = template.Body.Replace("[CustomerName/]", order.CustomerName);
                    template.Body = template.Body.Replace("[CustomerEmail/]", order.CustomerEmail);
                    template.Body = template.Body.Replace("[CustomerPhone/]", order.CustomerPhone);
                    template.Body = template.Body.Replace("[CustomerAddress/]", order.CustomerAddress);

                    template.Body = template.Body.Replace("[detail/]", detail);
                }

                ShippingEntity ship = ShippingManager.CreateInstant().GetShipping(OrderId);
                if (ship != null)
                {
                    template.Body = template.Body.Replace("[ShipCustomerName/]", ship.ReceiverName);
                    template.Body = template.Body.Replace("[ShipCustomerEmail/]", ship.RecerverEmail);
                    template.Body = template.Body.Replace("[ShipCustomerPhone/]", ship.Phone1);
                    template.Body = template.Body.Replace("[ShipCustomerAddress/]", ship.Address);
                    template.Body = template.Body.Replace("[ShipDate/]", FDateTime.FormatDateTime(ship.ShipDate));
                    template.Body = template.Body.Replace("[ShipNote/]", ship.Note);
                }
            }
            return template;
        }

        public EmailTemplatesEntity GetOrderPayCompleted(Guid OrderId, string detail)
        {
            EmailTemplatesEntity template = GetTemplateByTemplateCode("PayComplete");
            if (template != null)
            {
                OrdersEntity order = OrdersManager.CreateInstant().SelectOne(OrderId);
                if (order != null)
                {
                    template.Subject = template.Subject.Replace("[OrderCode/]", order.OrderCode);

                    template.Body = template.Body.Replace("[OrderCode/]", order.OrderCode);
                    template.Body = template.Body.Replace("[CustomerName/]", order.CustomerName);
                    template.Body = template.Body.Replace("[CustomerEmail/]", order.CustomerEmail);
                    template.Body = template.Body.Replace("[CustomerPhone/]", order.CustomerPhone);
                    template.Body = template.Body.Replace("[CustomerAddress/]", order.CustomerAddress);

                    template.Body = template.Body.Replace("[detail/]", detail);
                }

                ShippingEntity ship = ShippingManager.CreateInstant().GetShipping(OrderId);
                if (ship != null)
                {
                    template.Body = template.Body.Replace("[ShipCustomerName/]", ship.ReceiverName);
                    template.Body = template.Body.Replace("[ShipCustomerEmail/]", ship.RecerverEmail);
                    template.Body = template.Body.Replace("[ShipCustomerPhone/]", ship.Phone1);
                    template.Body = template.Body.Replace("[ShipCustomerAddress/]", ship.Address);
                    template.Body = template.Body.Replace("[ShipDate/]", FDateTime.FormatDateTime(ship.ShipDate));
                    template.Body = template.Body.Replace("[ShipNote/]", ship.Note);
                }
            }
            return template;
        }

        public EmailTemplatesEntity GetOrderCompletedPDF(Guid OrderId, string detail)
        {
            EmailTemplatesEntity template = GetTemplateByTemplateCode("OrderCompletePDF");
            if (template != null)
            {
                OrdersEntity order = OrdersManager.CreateInstant().SelectOne(OrderId);
                if (order != null)
                {
                    template.Subject = template.Subject.Replace("[OrderCode/]", order.OrderCode);

                    template.Body = template.Body.Replace("[OrderCode/]", order.OrderCode);
                    template.Body = template.Body.Replace("[CustomerName/]", order.CustomerName);
                    template.Body = template.Body.Replace("[CustomerEmail/]", order.CustomerEmail);
                    template.Body = template.Body.Replace("[CustomerPhone/]", order.CustomerPhone);
                    template.Body = template.Body.Replace("[CustomerAddress/]", order.CustomerAddress);

                    template.Body = template.Body.Replace("[detail/]", detail);
                }

                ShippingEntity ship = ShippingManager.CreateInstant().GetShipping(OrderId);
                if (ship != null)
                {
                    template.Body = template.Body.Replace("[ShipCustomerName/]", ship.ReceiverName);
                    template.Body = template.Body.Replace("[ShipCustomerEmail/]", ship.RecerverEmail);
                    template.Body = template.Body.Replace("[ShipCustomerPhone/]", ship.Phone1);
                    template.Body = template.Body.Replace("[ShipCustomerAddress/]", ship.Address);
                    template.Body = template.Body.Replace("[ShipDate/]", FDateTime.FormatDateTime(ship.ShipDate));
                    template.Body = template.Body.Replace("[ShipNote/]", ship.Note);
                }
            }
            return template;
        }

        string GetFileTemplate()
        {
            string body = "";
            string filename = HttpContext.Current.Server.MapPath("~") + "/EmailTemplate/EmailTemplate.html";
            
            StreamReader reader = new StreamReader(filename);
            body = reader.ReadToEnd();
            reader.Close();
            return body;
        }

        string GetFileTemplatePDF()
        {
            string body = "";
            string filename = HttpContext.Current.Server.MapPath("~") + "/EmailTemplate/EmailTemplatePDF.html";

            StreamReader reader = new StreamReader(filename);
            body = reader.ReadToEnd();
            reader.Close();
            return body;
        }

        public EmailTemplatesEntity GetFormatEmail(string body)
        {
            EmailTemplatesEntity format = new EmailTemplatesEntity();
            string content = GetFileTemplate();
            format.Subject = "";
            format.Body = content.Replace("[body/]", body);
            return format;
        }

        public EmailTemplatesEntity GetFormatEmail(EmailTemplatesEntity template)
        {
            EmailTemplatesEntity format = new EmailTemplatesEntity();
            string body = GetFileTemplate();
            format.Subject = template.Subject;
            format.Body = body.Replace("[body/]", template.Body);
            return format;
        }

        public EmailTemplatesEntity GetFormatEmailPDF(EmailTemplatesEntity template)
        {
            EmailTemplatesEntity format = new EmailTemplatesEntity();
            string body = GetFileTemplatePDF();
            format.Subject = template.Subject;
            format.Body = body.Replace("[body/]", template.Body);
            return format;
        }
    }
}
