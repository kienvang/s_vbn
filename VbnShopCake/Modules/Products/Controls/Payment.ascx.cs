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
using Library.Tools;
using Modules.Cart;

using System.Collections.Generic;
using Modules;
using Modules.Role;

public partial class Modules_Products_Controls_Payment : System.Web.UI.UserControl
{
    #region "Variable"

    decimal TotalAmountAfterTax = 0;
    decimal TotalAmountBeforeTax = 0;
    public string url = "";

    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        url = Library.Tools.UrlBuilder.RootUrl;

        if (!IsPostBack)
        {
            LoadCustomer();
        }
        if (string.IsNullOrEmpty(Util.CurrentUserName) && !(ucPayment.PaymentMethod == "CAH" || ucPayment.PaymentMethod == "CAR" || ucPayment.PaymentMethod == "BAK" || ucPayment.PaymentMethod == "VIS"))
            Response.Redirect(CheckRoles.CreateInstant().GetUrlDirect(Request.RawUrl));
    }

    void LoadCustomer()
    {
        //if (Convert.ToBoolean(Session["guest"]))
        //{
            CustomersEntity customer = CustomersManager.CreateInstant().GetByName(Util.CurrentUserName);
            if (customer != null && !string.IsNullOrEmpty(Util.CurrentUserName))
            {
                txtCustomerName.Text = customer.FullName;
                txtCustomerAddress.Text = customer.Address;
                txtCustomerEmail.Text = customer.Email;
                txtCustomerPhone.Text = customer.Mobi;

                txtShipCustomerName.Text = customer.FullName;
                txtShipCustomerAddress.Text = customer.Address;
                txtShipCustomerEmail.Text = customer.Email;
                txtShipCustomerPhone.Text = customer.Mobi;
            }
        //}
    }

    void LoadCart()
    {
        List<CartItem> items = CartsSession.CreateInstant().GetCarts(Page);
        for (int i = 0; i < items.Count; i++)
        {
            ProductsEntity product = ProductsManager.CreateInstant().SelectOne(items[i].ProductId);
            if (product != null)
            {
                int quantity = items[i].Total;
                if (quantity > Config.GetMaxItemInCart())
                    quantity = Config.GetMaxItemInCart();
                TotalAmountAfterTax += quantity * product.Price;
            }
        }
    }

    CustomersEntity getCustomer()
    {
        CustomersEntity customer = new CustomersEntity();

        customer.Id = Guid.NewGuid();
        customer.UserName = Util.CurrentUserName;
        customer.FullName = Filter.GetStringNoHtml(txtCustomerName.Text.Trim(), CustomersFields.FullName.MaxLength);
        customer.Email = Filter.GetMaxString(txtCustomerEmail.Text.Trim(), CustomersFields.Email.MaxLength);
        customer.Address = Filter.GetStringNoHtml(txtCustomerAddress.Text.Trim(), CustomersFields.Address.MaxLength);
        customer.Mobi = Filter.GetStringNoHtml(txtCustomerPhone.Text.Trim(), CustomersFields.Mobi.MaxLength);

        return customer;
    }

    OrdersEntity getOrder(CustomersEntity customer)
    {
        OrdersEntity order = new OrdersEntity();

        order.Id = Guid.NewGuid();
        order.OrderCode = OrderCode.CreateInstant().GetNumber();

        order.CustomerId = customer.Id;
        order.CustomerName = customer.FullName;
        order.CustomerEmail = customer.Email;
        order.CustomerPhone = customer.Mobi;
        order.CustomerAddress = customer.Address;

        order.TotalAmountBeforeTax = TotalAmountBeforeTax;
        order.TotalAmountAfterTax = TotalAmountAfterTax;
        order.TotalDiscount = 0;
        order.TotalOther = 0;
        order.TotalPaid = order.TotalAmountAfterTax + order.TotalOther - order.TotalDiscount;

        order.TotalCommission = 0;
        order.TotalAllSupplier = 0;

        order.PaymentMethod = ucPayment.PaymentMethod;

        return order;
    }

    OrderItemsEntity getOrderItem(OrdersEntity order)
    {
        OrderItemsEntity orderItem = new OrderItemsEntity();

        orderItem.Id = Guid.NewGuid();
        orderItem.OrderId = order.Id;

        orderItem.TotalAmountBeforeTax = order.TotalAmountBeforeTax;
        orderItem.TotalAmountAfterTax = order.TotalAmountAfterTax;
        orderItem.TotalDiscount = order.TotalDiscount;
        orderItem.SupplierId = CartsSession.CreateInstant().GetCarts(Page)[0].SupplierId;

        orderItem.TotalCommission = 0;
        orderItem.TotalToSupplier = 0;

        return orderItem;
    }

    OrderDetailEntity[] getOrderDetail(OrderItemsEntity item)
    {
        List<CartItem> carts = CartsSession.CreateInstant().GetCarts(Page);

        OrderDetailEntity[] details = new OrderDetailEntity[carts.Count];
        for (int i = 0; i < carts.Count; i++)
        {
            details[i] = new OrderDetailEntity();

            details[i].Id = Guid.NewGuid();

            if (carts[i].ProductParentId == Guid.Empty)
            {
                ProductsEntity product = ProductsManager.CreateInstant().SelectOne(carts[i].ProductId, true);
                if (product != null)
                {
                    int cnt = carts[i].Total;
                    if (cnt > Config.GetMaxItemInCart())
                        cnt = Config.GetMaxItemInCart();

                    details[i].ProductId = product.Id;
                    details[i].ProductName = product.ProductName;
                    details[i].OrderItemId = item.Id;
                    details[i].PriceBeforeTax = 0;
                    details[i].PriceAfterTax = product.Price;
                    details[i].Amount = cnt;
                    details[i].PoPrice = product.ProductInfo.PriceBuy;
                    details[i].ProductCode = product.ProductCode;
                }
            }
            else
            {
                ProductsEntity product = ProductsManager.CreateInstant().SelectOne(carts[i].ProductParentId, true);
                ProductSubEntity sub = ProductSubManager.CreateInstant().SelectOne(carts[i].ProductId);
                if (product != null && sub != null)
                {
                    int cnt = carts[i].Total;
                    if (cnt > Config.GetMaxItemInCart())
                        cnt = Config.GetMaxItemInCart();

                    details[i].ProductId = product.Id;
                    details[i].OrderItemId = item.Id;
                    details[i].PriceBeforeTax = 0;
                    details[i].PriceAfterTax = sub.Price;
                    details[i].Amount = cnt;
                    details[i].PoPrice = product.ProductInfo.PriceBuy;
                    details[i].ProductSubId = sub.Id;
                    details[i].ProductName = product.ProductName + " - " + sub.ProductName;
                    details[i].ProductCode = product.ProductCode;
                }
            }
        }

        return details;
    }

    DateTime getDateTime()
    {
        DateTime time = FDateTime.ConvertTime(txtShipTime.Text.Trim());
        DateTime date = FDateTime.ConvertDate(txtShipDate.Text.Trim());
        return new DateTime(date.Year, date.Month, date.Day, time.Hour, time.Minute, time.Second);
    }

    ShippingEntity getShipping(OrdersEntity order)
    {
        ShippingEntity ship = new ShippingEntity();

        ship.Id = Guid.NewGuid();
        ship.OrderId = order.Id;
        ship.ReceiverName = Filter.GetStringNoHtml(txtShipCustomerName.Text.Trim(), ShippingFields.ReceiverName.MaxLength);
        ship.RecerverEmail = Filter.GetMaxString(txtShipCustomerEmail.Text.Trim(), ShippingFields.RecerverEmail.MaxLength);
        ship.Address = Filter.GetStringNoHtml(txtShipCustomerAddress.Text.Trim(), ShippingFields.Address.MaxLength);
        ship.Phone1 = Filter.GetStringNoHtml(txtShipCustomerPhone.Text.Trim(), ShippingFields.Phone1.MaxLength);
        ship.Note = Filter.GetStringNoHtml(txtShipNote.Text.Trim(), ShippingFields.Note.MaxLength);
        ship.ShipDate = getDateTime();

        return ship;
    }

    ShippingDetailEntity[] getShipDetail(ShippingEntity ship, OrderDetailEntity[] orderDetail)
    {
        ShippingDetailEntity[] items = new ShippingDetailEntity[orderDetail.Length];
        for (int i = 0; i < orderDetail.Length; i++)
        {
            items[i] = new ShippingDetailEntity();

            items[i].Id = Guid.NewGuid();
            items[i].ShippingId = ship.Id;
            items[i].OrderDetailId = orderDetail[i].Id;
            items[i].Amount = orderDetail[i].Amount;
        }
        return items;
    }

    protected void btnPayment_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            LoadCart();

            CustomersEntity customer = getCustomer();
            CustomersEntity tmpCustomer = CustomersManager.CreateInstant().GetByName(Util.CurrentUserName);
            if (tmpCustomer == null || string.IsNullOrEmpty(Util.CurrentUserName))
            {
                CustomersManager.CreateInstant().Insert(customer);
            }
            else
            {
                customer.Id = tmpCustomer.Id;
                CustomersManager.CreateInstant().Update(customer);
            }

            OrdersEntity order = getOrder(customer);
            OrdersManager.CreateInstant().Insert(order);

            OrderItemsEntity orderItem = getOrderItem(order);
            OrderItemsManager.CreateInstant().Insert(orderItem);

            OrderDetailEntity[] orderDetail = getOrderDetail(orderItem);

            decimal TotalSupplier = 0;

            for (int i = 0; i < orderDetail.Length; i++)
            {
                OrderDetailManager.CreateInstant().Insert(orderDetail[i]);
                TotalSupplier += (orderDetail[i].PoPrice * orderDetail[i].Amount);
            }

            ShippingEntity ship = getShipping(order);
            ShippingManager.CreateInstant().Insert(ship);

            ShippingDetailEntity[] shipping = getShipDetail(ship, orderDetail);
            for (int i = 0; i < shipping.Length; i++)
            {
                ShippingDetailManager.CreateInstant().Insert(shipping[i]);
            }

            OrdersEntity tmpOrder = OrdersManager.CreateInstant().SelectOne(order.Id);
            tmpOrder.TotalAllSupplier = TotalSupplier;
            tmpOrder.TotalCommission += tmpOrder.TotalAmountAfterTax - TotalSupplier;
            OrdersManager.CreateInstant().Update(tmpOrder);

            OrderItemsEntity tmpOrderItem = OrderItemsManager.CreateInstant().SelectOne(orderItem.Id);
            tmpOrderItem.TotalToSupplier = tmpOrder.TotalAllSupplier;
            tmpOrderItem.TotalCommission = tmpOrder.TotalCommission;
            OrderItemsManager.CreateInstant().Update(tmpOrderItem);

            CartsSession.CreateInstant().DeleteCart(Page);

            string detail = "";
            SingleOrderDetail1.OrderId = order.Id;
            detail = SingleOrderDetail1.GetBody();

            EmailTemplatesEntity template = EmailTemplatesManager.CreateInstant().GetOrderCompleted(order.Id, detail);
            if (template != null)
            {
                template = EmailTemplatesManager.CreateInstant().GetFormatEmail(template);
                string subject = template.Subject;
                string body = template.Body;
                string from = GetEmail.EmailFrom;
                string to = order.CustomerEmail;
                string bcc = GetEmail.EmailTo;

                HistoryEmail.SendMailHistory(order.OrderCode, from, to, "", bcc, subject, body, "");
            }

            EventsManager.CreateInstant().AddEvent(order.OrderCode, Modules.Events.EnumsEvents.Order, order.OrderCode);

            Session["guest"] = false;
            switch (order.PaymentMethod)
            {
                case "CAH":
                case "BAK":
                case "CAR":
                case "VIS":
                    Response.Redirect("/Modules/Products/OrderComplete.aspx?id=" + order.Id.ToString());
                    break;
                case "NL":
                    string url = NganLuong.CreateInstant().buildCheckoutUrl(order.OrderCode, FNumber.FormatNumber(order.TotalAmountAfterTax).Replace(",", ""), NganLuong.PayShop);
                    Response.Redirect(url);
                    break;
            }

            
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect(Library.Tools.UrlBuilder.RootUrl);
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        CartsSession.CreateInstant().DeleteCart(Page);
        Response.Redirect(Library.Tools.UrlBuilder.RootUrl);
    }

    protected void valCart_ServerValidate(object source, ServerValidateEventArgs args)
    {
        args.IsValid = true;
        List<CartItem> carts = CartsSession.CreateInstant().GetCarts(Page);
        if (carts == null || carts.Count <= 0)
        {
            args.IsValid = false;
            valCart.ErrorMessage = "Giỏ hàng không tồn tại, bạn quay trở ra trang chủ để mua hàng.";

            return;
        }
        Captcha1.ValidateCaptcha(txtCaptcha.Text.Trim());
        if (!Captcha1.UserValidated)
        {
            args.IsValid = false;
            //valCart.ErrorMessage = "Mã xác nhận chưa chính xác";
            return;
        }
    }

    protected void chkCopy_CheckedChanged(object sender, EventArgs e)
    {
        txtShipCustomerName.Text = txtCustomerName.Text;
        txtShipCustomerAddress.Text = txtCustomerAddress.Text;
        txtShipCustomerEmail.Text = txtCustomerEmail.Text;
        txtShipCustomerPhone.Text = txtCustomerPhone.Text;
    }

}
