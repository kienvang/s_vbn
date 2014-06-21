<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CartBox.ascx.cs" Inherits="Modules_Products_Controls_CartBox" %>
<div class="shop_cart profile height">
    <h4>
        Thông tin giỏ hàng</h4>
    <p>
        Giỏ hàng của bạn hiện có <%= QuantityCart %> sản phẩm</p>
    <p class="marginT10">
        <a href="<%= Modules.Products.UrlBuilder.Carts() %>" title="">
            <img src="/images/shopcart.gif" alt="" class="icon" /></a>
    <a href="<%= Modules.Products.UrlBuilder.Carts() %>" title="" class="button">
        Chi tiết giỏ hàng</a></p>
</div>
