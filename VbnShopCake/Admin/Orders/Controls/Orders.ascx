<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Orders.ascx.cs" Inherits="Admin_Orders_Controls_Orders" %>
<%@ Register TagPrefix="avg" Namespace="Avg.Controls" Assembly="SmartPager" %>
<style type="text/css">
    .row
    {
        height: 28px;
    }
</style>
<div class="viet-blog box58">
    <div class="box58-container">
        <h2 class="a14 forecolor-01">
            Thông tin đặt mua hàng</h2>
        <div class="body" style="padding: 10px 0 10px 0; font-size: 11px; font-family: Verdana">
            <table width="100%" cellpadding="2" cellspacing="2">
                <tr class="row">
                    <td width="120px">
                        <b>Mã hóa đơn</b>
                    </td>
                    <td colspan="3">
                        <asp:TextBox ID="txtOrderCode" runat="server" Width="250px"></asp:TextBox>
                        <asp:Button ID="btnSearch" runat="server" Text="Tìm" 
                            onclick="btnSearch_Click" />
                    </td>
                </tr>
                <tr class="row">
                    <td width="120px">
                        <b>Tên khách hàng</b>
                    </td>
                    <td colspan="3">
                        <asp:TextBox ID="txtCustomer" runat="server" Width="250px"></asp:TextBox>
                    </td>
                </tr>
                <tr class="row">
                    <td>
                        <b>Ngày đặt hàng</b>
                    </td>
                    <td width="350px">
                        <asp:TextBox ID="txtCreatedDate" runat="server" Width="250px"></asp:TextBox>
                    </td>
                    <td>
                        <b>Tình trang thanh toán</b>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlStatusPay" runat="server">
                            <asp:ListItem Value="all" Selected="True">Chọn tình trạng thanh toán</asp:ListItem>
                            <asp:ListItem Value="true">Đã thanh toán</asp:ListItem>
                            <asp:ListItem Value="false">Chưa thanh toán</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
            </table>
        </div>
    </div>
</div>
<div>
    <table class="grid" border="1">
        <tr class="title">
            <th width="40px">
                STT
            </th>
            <th width="80px">
                Mã HĐ
            </th>
            <th>
                Tên khách hàng
            </th>
            <th width="150px">
                Ngày mua hàng
            </th>
            <th width="180px">
                Phương thức thanh toán
            </th>
            <th width="100px">
                Thanh toán
            </th>
        </tr>
        <asp:Repeater ID="repOrders" runat="server">
            <ItemTemplate>
                <tr class="row">
                    <td>
                        <%# Container.ItemIndex + 1 %>
                    </td>
                    <td>
                    <a href='/Admin/Orders/OrderDetail.aspx?OrderNumber=<%# Eval("OrderCode") %>' target="_blank">
                        <%# Eval("OrderCode") %></a>
                    </td>
                    <td>
                        <%# Eval("CustomerName") %>
                    </td>
                    <td align="center">
                        <%# DateTime.Parse(Eval("CreatedDate").ToString()).ToString("dd/MM/yyyy") %>
                    </td>
                    <td>
                    <%# Eval("PayName") %>
                    </td>
                    <td align="center">
                    <%# GetPayment(bool.Parse(Eval("PaidCompleted").ToString())) %>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
</div>
<avg:SmartPager ID="smartPager" runat="server" Visible="false"/>

<script type="text/javascript">
    $(function() {
	    $("#<%= txtCreatedDate.ClientID %>").datepicker({
	        showOn: 'both'
	        , buttonImage: '/img/button/calendar-up.gif'
	        , buttonImageOnly: true
	        , dateFormat: 'dd/mm/yy'
	    });
    });
</script>