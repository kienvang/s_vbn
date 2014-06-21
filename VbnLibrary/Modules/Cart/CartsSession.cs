using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;

using System.Web.UI;
using System.Collections.Generic;
using System.Collections.Specialized;

using LayerHelper.ShopCake.BLL;
using LayerHelper.ShopCake.DAL.EntityClasses;

using Modules;
using Library.Tools;

/// <summary>
/// Summary description for CartsSession
/// </summary>
namespace Modules.Cart
{
    public class CartsSession
    {
        public const string cookieCart = "cart";

        public static CartsSession CreateInstant()
        {
            return new CartsSession();
        }

        string Encode(string value)
        {
            return HttpContext.Current.Server.UrlEncode(value);
        }

        string Decode(string value)
        {
            return HttpContext.Current.Server.UrlDecode(value);
        }

        HttpCookie InitCookie(Page page)
        {
            HttpCookie cookie = page.Request.Cookies[cookieCart];
            string sessionId = "";
            if (page.Request.Cookies["ASP.NET_SessionId"] != null)
                sessionId = page.Request.Cookies["ASP.NET_SessionId"].Value;

            if (cookie == null)
            {
                cookie = new HttpCookie(cookieCart);
                cookie.Path = "/";
                cookie.Value = "ss=" + sessionId + "&c=";
                cookie.Expires = DateTime.Now.AddDays(1);
            }
            else
            {
                if (string.IsNullOrEmpty(cookie["ss"]) || (!string.IsNullOrEmpty(cookie["ss"]) && !cookie["ss"].Equals(sessionId)))
                    cookie.Value = "ss=" + sessionId + "&c=";
                cookie.Path = "/";
            }
            //page.Response.Cookies.Add(cookie);
            return cookie;
        }

        string ToString(NameValueCollection collection)
        {
            string st = "";
            for (int i = 0; i < collection.Count; i++)
            {
                st += collection.GetKey(i) + "=" + collection.Get(i) + "&";
            }
            return st.Trim('&');
        }

        string InitItem(CartItem cart)
        {
            NameValueCollection item = new NameValueCollection();
            item.Add(CartItem._SupplierId, Encode(cart.SupplierId.ToString()));
            item.Add(CartItem._ProductId, Encode(cart.ProductId.ToString()));
            item.Add(CartItem._ProductName, Encode(cart.ProductName));
            item.Add(CartItem._Price, Encode(FNumber.FormatNumber(cart.Price)));
            item.Add(CartItem._Total, Encode(cart.Total.ToString()));
            item.Add(CartItem._ProductParentId, Encode(cart.ProductParentId.ToString()));
            item.Add(CartItem._ProductCode, Encode(cart.ProductCode));

            return Encode(ToString(item));
        }

        NameValueCollection GetCollection(string value)
        {
            NameValueCollection collect = new NameValueCollection();

            if (!string.IsNullOrEmpty(value))
            {
                string[] param = value.Split('&');
                for (int i = 0; i < param.Length; i++)
                {
                    string[] item = param[i].Split('=');
                    collect.Add(item[0], item[1]);
                }
            }

            return collect;
        }

        CartItem GetItemCookie(string item)
        {
            return GetItemCookie(GetCollection(item));
        }

        CartItem GetItemCookie(NameValueCollection item)
        {
            CartItem cart = new CartItem();

            cart.SupplierId = new Guid(Decode(item[CartItem._SupplierId]));
            cart.ProductId = new Guid(Decode(item[CartItem._ProductId]));
            cart.ProductName = Decode(item[CartItem._ProductName]);
            cart.Price = FNumber.ConvertDecimal(Decode(item[CartItem._Price]));
            cart.Total = FNumber.ConvertInt(Decode(item[CartItem._Total]));
            cart.ProductParentId = new Guid(Decode(item[CartItem._ProductParentId]));
            cart.ProductCode = Decode(item[CartItem._ProductCode]);

            return cart;
        }

        void AddItemCookie(Page page, CartItem cart)
        {
            HttpCookie cookie = InitCookie(page);

            NameValueCollection collect = GetCollection(Decode(cookie["c"]));

            string item = InitItem(cart);
            collect.Add("c" + (collect.Count + 1).ToString(), item);

            cookie["c"] = Encode(ToString(collect));
            cookie.Path = "/";
            cookie.Expires = DateTime.Now.AddDays(1);

            page.Response.Cookies.Add(cookie);
            //page.Response.SetCookie(cookie);
        }

        void EditItemCookie(Page page, CartItem cart, string key)
        {
            EditItemCookie(page, cart, key, true);
        }

        void EditItemCookie(Page page, CartItem cart, string key, bool IsAdd)
        {
            HttpCookie cookie = InitCookie(page);
            if (cookie == null)
                AddItemCookie(page, cart);
            else
            {
                NameValueCollection collect = GetCollection(Decode(cookie["c"]));
                CartItem tmp = GetItemCookie(Decode(collect[key]));
                if (tmp.Total <= Config.GetMaxItemInCart() && tmp.Total + cart.Total <= Config.GetMaxItemInCart())
                {
                    if (IsAdd)
                        tmp.Total += cart.Total;
                    else
                        tmp.Total = cart.Total;

                    collect.Set(key, InitItem(tmp));

                    cookie["c"] = Encode(ToString(collect));
                    cookie.Path = "/";
                    cookie.Expires = DateTime.Now.AddDays(1);

                    page.Response.SetCookie(cookie);
                }
            }
        }

        void DeleteItemCookie(Page page, Guid ProductId)
        {
            HttpCookie cookie = InitCookie(page);
            if (cookie != null)
            {
                NameValueCollection collect = GetCollection(Decode(cookie["c"]));
                for (int i = 0; i < collect.Count; i++)
                {
                    CartItem tmp = GetItemCookie(Decode(collect[i]));
                    if (tmp.ProductId == ProductId)
                    {
                        collect.Remove(collect.GetKey(i));
                        cookie["c"] = Encode(ToString(collect));
                        cookie.Path = "/";
                        cookie.Expires = DateTime.Now.AddDays(1);

                        page.Response.SetCookie(cookie);

                        break;
                    }
                }
            }
        }

        void AddCookie(Page page, CartItem cart)
        {
            AddCookie(page, cart, true);
        }

        void AddCookie(Page page, CartItem cart, bool IsAdd)
        {
            bool _IsAdd = true;

            HttpCookie cookie = InitCookie(page);
            if (cookie == null)
                AddItemCookie(page, cart);
            else
            {
                NameValueCollection collect = GetCollection(Decode(cookie["c"]));
                for (int i = 0; i < collect.Count; i++)
                {
                    string key = collect.GetKey(i);
                    CartItem tmp = GetItemCookie(Decode(collect[i]));
                    if (tmp.ProductId == cart.ProductId)
                    {
                        EditItemCookie(page, cart, key, IsAdd);
                        _IsAdd = false;
                        break;
                    }
                }

                if (_IsAdd)
                {
                    AddItemCookie(page, cart);
                }
            }
        }

        public bool AddCart(Page page, Guid ProductId, int count)
        {
            return AddCart(page, ProductId, count, Guid.Empty);
        }

        public bool AddCart(Page page, Guid ProductId, Guid SubId)
        {
            return AddCart(page, ProductId, 1, SubId);
        }

        public bool AddCart(Page page, Guid ProductId, int count, Guid SubId)
        {
            bool status = false;
            if (count <= 0 || count > Config.GetMaxItemInCart()) count = 1;

            ProductsEntity product = ProductsManager.CreateInstant().SelectOne(ProductId);
            ProductSubEntity sub = ProductSubManager.CreateInstant().SelectOne(SubId);

            if (product != null && count > 0)
            {
                CartItem cart = null;
                if (SubId == Guid.Empty)
                {
                    cart = new CartItem();
                    cart.ProductId = ProductId;
                    cart.SupplierId = product.SupplierId;
                    cart.ProductName = product.ProductName;
                    cart.Price = product.Price;
                    cart.Total = count;
                    cart.ProductParentId = Guid.Empty;
                    cart.ProductCode = product.ProductCode;
                }
                else
                {
                    if (sub != null)
                    {
                        cart = new CartItem();
                        cart.ProductId = SubId;
                        cart.SupplierId = product.SupplierId;
                        cart.ProductName = product.ProductName + " - " + sub.ProductName;
                        cart.Price = sub.Price;
                        cart.Total = count;
                        cart.ProductParentId = ProductId;
                        cart.ProductCode = product.ProductCode;
                    }
                }

                if (cart != null)
                    AddCookie(page, cart);
            }

            return status;
        }

        public bool UpdateCart(Page page, List<CartItem> carts)
        {
            bool status = true;

            HttpCookie cookie = InitCookie(page);

            string c = "";
            NameValueCollection collection = new NameValueCollection();
            for (int i = 0; i < carts.Count; i++)
            {
                collection.Add("c" + (i + 1).ToString(), InitItem(carts[i]));
            }

            cookie["c"] = Encode(ToString(collection));
            cookie.Path = "/";
            cookie.Expires = DateTime.Now.AddDays(1);

            page.Response.SetCookie(cookie);

            return status;
        }

        public bool DeleteItem(Page page, Guid ProductId)
        {
            bool status = false;
            //ProductsEntity product = ProductsManager.CreateInstant().SelectOne(ProductId);

            //if (product != null)
            //{
            //    CartItem cart = new CartItem();
            //    cart.SupplierId = product.SupplierId;
            //    cart.ProductName = product.ProductName;
            //    cart.Price = product.Price;

            DeleteItemCookie(page, ProductId);
            //}

            return status;
        }

        public List<CartItem> GetCarts(Page page)
        {
            List<CartItem> carts = null;

            HttpCookie cookie = InitCookie(page);

            if (cookie != null)
            {
                carts = new List<CartItem>();
                NameValueCollection collection = GetCollection(Decode(cookie["c"]));
                for (int i = 0; i < collection.Count; i++)
                {
                    CartItem cart = GetItemCookie(Decode(collection[i]));
                    carts.Add(cart);
                }
            }

            return carts;
        }

        DataTable InitTable()
        {
            DataTable table = new DataTable();

            DataColumn column;

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Guid");
            column.ColumnName = CartItem._SupplierId;
            column.ReadOnly = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Guid");
            column.ColumnName = CartItem._ProductId;
            column.ReadOnly = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Guid");
            column.ColumnName = CartItem._ProductParentId;
            column.ReadOnly = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = CartItem._ProductName;
            column.ReadOnly = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = CartItem._ProductCode;
            column.ReadOnly = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Decimal");
            column.ColumnName = CartItem._Price;
            column.ReadOnly = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = CartItem._Total;
            column.ReadOnly = false;
            table.Columns.Add(column);

            return table;
        }

        public DataTable GetCartRDT(Page page)
        {
            DataTable table = new DataTable();

            List<CartItem> carts = GetCarts(page);
            if (carts != null && carts.Count > 0)
            {
                table = InitTable();
                for (int i = 0; i < carts.Count; i++)
                {
                    DataRow r = table.NewRow();
                    r[CartItem._SupplierId] = carts[i].SupplierId;
                    r[CartItem._ProductId] = carts[i].ProductId;
                    r[CartItem._ProductName] = carts[i].ProductName;
                    r[CartItem._Price] = carts[i].Price;
                    r[CartItem._Total] = carts[i].Total;
                    r[CartItem._ProductParentId] = carts[i].ProductParentId;
                    r[CartItem._ProductCode] = carts[i].ProductCode;

                    table.Rows.Add(r);
                }
            }

            return table;
        }

        public void DeleteCart(Page page)
        {
            HttpCookie cookie = page.Request.Cookies[cookieCart];

            if (cookie != null)
            {
                cookie.Expires = DateTime.Now.AddDays(-10);
                page.Response.SetCookie(cookie);
            }
        }
    }
}