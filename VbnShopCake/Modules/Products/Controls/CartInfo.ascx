<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CartInfo.ascx.cs" Inherits="Modules_Products_Controls_CartInfo" %>
<%@ Import Namespace="Library.Tools" %>
<table border="1" class="cart">
    <tr class="title">
        <td width="40px">
            STT
        </td>
        <td>
            Tên sản phẩm
        </td>
        <td width="80px">
            Mã sản phẩm
        </td>
        <td width="90px">
            Giá
        </td>
        <td width="70px">
            Số lượng
        </td>
        <td width="120px">
            Thành Tiền
        </td>
    </tr>
    <asp:Repeater ID="repCart" runat="server">
        <ItemTemplate>
            <tr>
                <td align="center">
                    <%# Container.ItemIndex + 1 %>
                </td>
                <td>
                    <%# Eval("ProductName") %>
                </td>
                <td>
                    <%# Eval("ProductCode") %>
                </td>
                <td align="right">
                    <%# Convert.ToDecimal(Eval("Price")) >0 ? Library.Tools.FNumber.FormatNumber(Eval("Price")) + " VND" : "Liên hệ sau" %>
                </td>
                <td align="right">
                    <%# FNumber.FormatNumber(Eval("Total")) %>
                </td>
                <td align="right">
                    <%# Convert.ToDecimal(Eval("Price")) > 0 ? FNumber.FormatNumber(Convert.ToDecimal(Eval("Price")) * Convert.ToInt32(Eval("Total"))) + "VND" : "Liên hệ sau" %>
                </td>
            </tr>
        </ItemTemplate>
    </asp:Repeater>
    <tr>
        <td colspan="6" align="right" style="font-family:Tahoma; font-size:14px">
            <b>Tổng cộng</b> :
            <%= FNumber.FormatNumber(Total) %> VND
        </td>
    </tr>
</table>
