<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Detail.ascx.cs" Inherits="Admin_Products_Controls_Detail" %>
<%@ Register Src="DetailProduct.ascx" TagName="DetailProduct" TagPrefix="uc1" %>
<%@ Register Src="DetailPhotos.ascx" TagName="DetailPhotos" TagPrefix="uc2" %>
<%@ Register Src="DetailDeals.ascx" TagName="DetailDeals" TagPrefix="uc3" %>
<%@ Register Src="DetailHistory.ascx" TagName="DetailHistory" TagPrefix="uc4" %>
<%@ Register Src="DetailStore.ascx" TagName="DetailStore" TagPrefix="uc5" %>
<%@ Register src="DetailSub.ascx" tagname="DetailSub" tagprefix="uc6" %>
<div class="background-02" style="padding: 0 5px">
    <table width="100%" class="detail" cellpadding="2" cellspacing="2">
        <tr class="row">
            <td width="120px">
                Mã Sản phẩm
            </td>
            <td>
                :&nbsp;<asp:Label ID="lblIntId" runat="server"></asp:Label>
            </td>
            <td width="120px">
                Danh mục
            </td>
            <td width="200px">
                :&nbsp;<a><asp:Label ID="lblCatalogName" runat="server"></asp:Label>
                </a>
            </td>
            <td width="200px" rowspan="5" align="center">
                <asp:Image ID="imgThumbnail" runat="server" Height="130px" Width="180px" />
            </td>
        </tr>
        <tr class="row">
            <td>
                Tên Sản phẩm
            </td>
            <td>
                :&nbsp;<a href='<%= Request.Path %>?id=<%= Request["id"] %>'><asp:Label ID="lblProductName"
                    runat="server"></asp:Label>
                </a><span style="padding-left:10px; padding-top:3px"><a href='/Admin/Products/EditProduct.aspx?Id=<%= Request["id"] %>&ReturnUrl=<%= Server.UrlEncode(Request.RawUrl) %>'>
                    <img src="/img/button/properties.png" />
                </a></span>
            </td>
            <td>
                Nhà cung cấp
            </td>
            <td>
                :&nbsp;<a><asp:Label ID="lblSupplierName" runat="server"></asp:Label></a>
            </td>
        </tr>
        <tr class="row">
            <td colspan="2" rowspan="3">
                <table width="200px" class="detail background-03">
                    <tr>
                        <td width="60px">
                            Giá mua
                        </td>
                        <td width="5px">
                            :
                        </td>
                        <td align="right">
                            <asp:Label ID="lblPriceBuy" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Giá bán
                        </td>
                        <td>
                            :
                        </td>
                        <td align="right">
                            <asp:Label ID="lblPriceSell" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Tiền lãi
                        </td>
                        <td>
                            :
                        </td>
                        <td align="right">
                            <asp:Label ID="lblCommission" runat="server"></asp:Label>
                        </td>
                    </tr>
                </table>
            </td>
            <td>
                Số lượng
            </td>
            <td>
                :&nbsp;<asp:Label ID="lblAmount" runat="server"></asp:Label>
            </td>
        </tr>
        <tr class="row">
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr class="row">
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
    </table>
</div>
<%--ddsd--%>
<div id="tabs" style="margin: 10px 0; min-height: 250px; font-family: Arial;">
    <ul>
        <li><a href="#tabs-info">Thông Tin Sản Phẩm</a></li>
        <li><a href="#tabs-photo">Hình Ảnh</a></li>
        <li><a href="#tabs-sub">Sản Phẩm Con</a></li>
        <li><a href="#tabs-price">Quản Lý Giá</a></li>
        <li><a href="#tabs-store">Quản Lý Nhập Xuất</a></li>
        <li><a href="#tabs-history">Lịch Sử Cập Nhật</a></li>
    </ul>
    <div id="tabs-info">
        <uc1:DetailProduct ID="DetailProduct1" runat="server" />
    </div>
    <div id="tabs-photo">
        <uc2:DetailPhotos ID="DetailPhotos1" runat="server" />
    </div>
    <div id="tabs-sub">
        <uc6:DetailSub ID="DetailSub1" runat="server" />
    </div>
    <div id="tabs-price">
        <uc3:DetailDeals ID="DetailDeals1" runat="server" />
    </div>
    <div id="tabs-store">
        <uc5:DetailStore ID="DetailStore1" runat="server" />
    </div>
    <div id="tabs-history">
        <uc4:DetailHistory ID="DetailHistory1" runat="server" />
    </div>
</div>
<%--script jquery--%>

<script type="text/javascript">
    $(document).ready(function(){
    
        $('#tabs').tabs({
            select: function(event, ui) {
                //alert(ui.panel.id);
                $.cookie('tabs', ui.panel.id, { path : "/Admin/Products/"});
                return true;
            }
        });
        
        var $tabs = $("#tabs").tabs();
        
        loadTabs();
        
        function loadTabs()
        {
            var cookie = $.cookie('tabs');
            if (cookie != null && cookie != "")
            {
                $tabs.tabs("select", cookie);
            }
            
        }
        
        
    });
</script>

