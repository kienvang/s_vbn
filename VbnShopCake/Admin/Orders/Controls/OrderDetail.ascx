<%@ Control Language="C#" AutoEventWireup="true" CodeFile="OrderDetail.ascx.cs" Inherits="Admin_Orders_Controls_OrderDetail" %>
<%@ Register Src="DetailCarts.ascx" TagName="DetailCarts" TagPrefix="uc1" %>
<%@ Register Src="DetailShipping.ascx" TagName="DetailShipping" TagPrefix="uc2" %>
<%@ Register Src="DetailHistory.ascx" TagName="DetailHistory" TagPrefix="uc3" %>
<%@ Register Src="DetailEmail.ascx" TagName="DetailEmail" TagPrefix="uc4" %>
<%@ Register Src="../../../Modules/Payment/Controls/SingleOrderDetail.ascx" TagName="SingleOrderDetail"
    TagPrefix="uc5" %>
<link href="/Admin/css/style.css" rel="stylesheet" type="text/css" />
<link href="/Admin/css/grid.css" rel="stylesheet" type="text/css" />
<style type="text/css">
    .mnufunc
    {
        margin: 10px 0;
        padding: 5px 0;
        border-bottom: solid 1px #D49600;
        border-top: solid 1px #D49600;
    }
</style>
<div class="background-02" style="padding: 0 5; margin: 10px 0">
    <table width="100%" cellpadding="2" cellspacing="2" class="detail">
        <tr>
            <td width="120px">
                Mã hóa đơn
            </td>
            <td width="200px">
                :&nbsp;<a href="/Admin/Orders/OrderDetail.aspx?OrderNumber=<%= OrderNumber %>"><%= OrderNumber %></a>
            </td>
            <td width="120px">
                Ngày đặt hàng
            </td>
            <td>
                :&nbsp;<asp:Label ID="lblOrderDate" runat="server" CssClass="text-info"></asp:Label>
            </td>
            <td width="120px">
                Tình trạng thanh toán
            </td>
            <td width="160px">
                <div class="view-payment">
                    :&nbsp;
                    <% if (TagId != "CAN" && TagId != "PAY")
                       { %>
                    <span class="mnupayment click-no-line">
                        <%= GetStatusPaid()%>
                        <img src="/img/expand-all.gif" /></span>
                    <%}
                       else
                       {
                    %>
                    <span class="text-info">
                        <%= GetStatusPaid()%></span>
                    <%} %>
                </div>
                <div class="view-payment" style="display: none">
                    <img src="/img/ajax-loader.gif" />
                    Đang xử lý.....
                </div>
            </td>
        </tr>
        <tr>
            <td>
                Tên khách hàng
            </td>
            <td>
                :&nbsp;<asp:Label ID="lblCustomer" runat="server" CssClass="text-info"></asp:Label>
            </td>
            <td>
                Hình thức thanh toán
            </td>
            <td>
                :&nbsp;<asp:Label ID="lblPayment" runat="server"></asp:Label>
            </td>
            <td>
                Tình trạng giao hàng
            </td>
            <td>
                :&nbsp;<asp:Label ID="lblShipping" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
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
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
    </table>
</div>
<%--Begin Context Menu--%>
<ul id="mnucxtPayment" class="contextMenu">
    <li><a href="#pay-not-complete">Chờ thanh toán</a></li>
    <li><a href="#pay-complete">Thanh toán hoàn tất</a></li>
</ul>
<%--End Context Menu--%>
<div class="mnufunc">
    <asp:LinkButton ID="lkPdf" runat="server" OnClick="lkPdf_Click"><img src="/img/acroread.png" />Xuất file Pdf</asp:LinkButton>
</div>
<%--Begin Tabs--%>
<div id="tabs" style="margin: 10px 0; min-height: 250px; font-family: Arial;">
    <ul>
        <li><a href="#order-info">Phiếu đặt hàng</a></li>
        <li><a href="#tabs-cart">Giỏ Hàng</a></li>
        <li><a href="#tabs-shipping">Vận Chuyển</a></li>
        <%--<li><a href="#tabs-payment">Thanh Toán</a></li>--%>
        <li><a href="#tabs-history">Lịch Sử Cập Nhật</a></li>
        <li><a href="#tabs-email">Email</a></li>
    </ul>
    <div id="order-info">
        <uc5:SingleOrderDetail ID="viewOrder" runat="server" Visible="false" />
        <asp:Label ID="lblViewOrder" runat="server"></asp:Label>
    </div>
    <div id="tabs-cart">
        <uc1:DetailCarts ID="DetailCarts1" runat="server" />
    </div>
    <div id="tabs-shipping">
        <uc2:DetailShipping ID="DetailShipping1" runat="server" />
    </div>
    <%--<div id="tabs-payment">
        asd
    </div>--%>
    <div id="tabs-history">
        <uc3:DetailHistory ID="DetailHistory1" runat="server" />
    </div>
    <div id="tabs-email">
        <uc4:DetailEmail ID="DetailEmail1" runat="server" />
    </div>
</div>
<%--End Tabs--%>
<uc5:SingleOrderDetail ID="SingleOrderDetail1" runat="server" Visible="false" />
<%--script jquery--%>

<script type="text/javascript">
    $(document).ready(function(){
    
        $('#tabs').tabs({
            select: function(event, ui) {
                //alert(ui.panel.id);
                //$.cookie('tabs', ui.panel.id, { path : "/Admin/Products/"});
                return true;
            }
        });
        
        var $tabs = $("#tabs").tabs();
        
        //loadTabs();
        
        function loadTabs()
        {
            var cookie = $.cookie('tabs');
            if (cookie != null && cookie != "")
            {
                $tabs.tabs("select", cookie);
            }
            
        }
        
        // Begin Menu Context
        
        $(".mnupayment").contextMenu(
            { menu: 'mnucxtPayment', leftButton: true }, 
            function(action, el, pos) { 
                contextMenuPayment(action, el.parent("div"), pos); 
        });
        
        function contextMenuPayment(action, el, pos){
            switch(action)
            {
                case "pay-complete":
                {
                    $(".view-payment").toggle(1000);
                    SetPaidComplete(el);
                    break;
                }
                case "":
                {
                    break;
                }
            }
        };
        
        function SetPaidComplete(element)
        {
            var jsonStr = "{OrderCode:'<%= OrderNumber %>'}";
            //alert(jsonStr);
            $.ajax({
				type: "POST",
				url: "/Admin/Webservices/OrdersService.asmx/SetPaidComplete",
				contentType: "application/json; charset=utf-8",
				dataType: "json",
				data: jsonStr,
				success: function(msg) {
				    if (msg.d == true)
				    {
				        $(".mnupayment").text("Thanh toán hoàn tất");
				        $(".mnupayment").removeClass("click-no-line").addClass("text-info");
				        element.html(":&nbsp;<span class='text-info'>Thanh toán hoàn tất</span>");
				    }
				    $(".view-payment").toggle(1000);
					return true;
				},
				error: function() {
				    $(".view-payment").toggle(1000);
					return false;
				}
			});
        }
        
        // End Menu Context
    });
</script>

