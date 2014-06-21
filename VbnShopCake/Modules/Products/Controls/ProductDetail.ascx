<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ProductDetail.ascx.cs"
    Inherits="Modules_Products_Controls_ProductDetail" %>
<%@ Register Src="ProductPhoto.ascx" TagName="ProductPhoto" TagPrefix="uc1" %>

<script type="text/javascript">
    $(function() {
        $('.product_gallery a').lightBox();
        $('.iphoto').lightBox();		
		$('.product_gallery').jcarousel();
    });
</script>

<div class="listProducts" style="margin-bottom: 20px">
    <h2>
        Sản phẩm</h2>
    <%--<div class="productsInfo">--%>
    <div class="product_detail">
        <a href="<%= path %>?w=500&c=1" title="<%= ProductName %>" class="large_img iphoto">
            <asp:Image ID="img" runat="server" />
        </a>
        <h3>
            <p class="orange" style="font-weight: bold; font-size:18px">
                <asp:Label ID="lblProductCode" runat="server"></asp:Label></p>
            <a href="<%= Request.RawUrl %>" title="Bánh kem 001">
                <asp:Label ID="lblProductName" runat="server"></asp:Label></a></h3>
        <p>
            <strong>
                <asp:Label ID="lblAbstract" runat="server" CssClass="orange"></asp:Label></strong>
        </p>
        <p>
            Thời gian bảo hành : <span>
                <asp:Label ID="lblWarranty" runat="server"></asp:Label></span></p>
        <p id="itemPrice" runat="server" visible="false">
            Giá : <span>
                <asp:Label ID="lblPrice" runat="server" CssClass="orange"></asp:Label></span></p>
        <p id="itemSingle" runat="server" visible="false">
            Số lượng:
            <asp:TextBox ID="txtQuantity" runat="server" Width="30px" CssClass="numeric"></asp:TextBox>&nbsp;
            <asp:LinkButton ID="btnOrder" runat="server" class="button" OnClick="btnOrder_Click">Đặt hàng</asp:LinkButton>
        </p>
        <p>
            <%--<iframe src="http://www.facebook.com/plugins/like.php?href=<%= Server.UrlEncode(Library.Tools.UrlBuilder.RootUrl + Request.RawUrl)%>&amp;layout=standard&amp;show_faces=true&amp;width=400&amp;action=like&amp;colorscheme=light&amp;height=80"
                scrolling="no" frameborder="0" style="border: none; overflow: hidden; width: 400px;
                height: 80px;" allowtransparency="true"></iframe>--%>
            <a name="fb_share" type="button_count" share_url='<%= ("http://shop.vbn.vn" + Request.RawUrl)%>'></a>

            <script src="http://static.ak.fbcdn.net/connect.php/js/FB.Share" type="text/javascript">
            </script>

        </p>
        <div id="itemGroup" runat="server" visible="false" class="item_group_radio">
            <asp:RadioButtonList ID="rdoListSub" runat="server">
            </asp:RadioButtonList>
            <asp:LinkButton ID="btnOrderSub" runat="server" class="button" OnClick="btnOrderSub_Click">Đặt hàng</asp:LinkButton>
        </div>
        <p class="info_detail">
            <asp:Label ID="lblDetail" runat="server"></asp:Label>
        </p>
    </div>
    <div class="clear">
    </div>
    <uc1:ProductPhoto ID="ProductPhoto1" runat="server" />
    <%--</div>--%>
</div>
