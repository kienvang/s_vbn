<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SingleOrderDetail.ascx.cs"
    Inherits="Modules_Payment_Controls_SingleOrderDetail" %>
<%@ Import Namespace="Library.Tools" %>
<div id="divContent" runat="server">
    <table width="100%" border="1" style="border: 1px solid #dedede; border-collapse: collapse;">
        <tr align="center" style="border: 1px solid #dedede; background: #007dc4; color: White;
            font-size: 12px; font-weight: bold; padding: 5px; text-align: center; height: 26px;
            font-family: Tahoma" height="26px">
            <td width="40">
                STT
            </td>
            <td>
                Tên sản phẩm
            </td>
            <td width="60px">
                Mã
            </td>
            <td width="120">
            </td>
            <td width="100">
                Giá
            </td>
            <td width="60">
                Số lượng
            </td>
            <td width="120">
                Thành tiền
            </td>
        </tr>
        <asp:Repeater ID="repCart" runat="server">
            <ItemTemplate>
                <tr style="padding: 5px 10px; border: 1px solid #dedede; font-family: Arial; font-size: 13px;
                    height: 24px">
                    <td align="center">
                        <%# Container.ItemIndex + 1 %>
                    </td>
                    <td>
                        &nbsp;<%# string.IsNullOrEmpty(Eval("SubName").ToString()) ? Eval("ProductName") : Eval("SubName") %>
                    </td>
                    <td>
                        &nbsp;<%# Eval("ProductCode") %>
                    </td>
                    <td align="center">
                        <img src='<%# Library.Tools.UrlBuilder.RootUrl + Eval("Thumbnail").ToString() + "?w=100&h=120&c=0" %>' />
                    </td>
                    <td align="right">
                        <%# Convert.ToDecimal(Eval("PriceAfterTax")) > 0 ? FNumber.FormatNumber(Eval("PriceAfterTax")) : "Liên hệ sau" %>&nbsp;
                    </td>
                    <td align="right">
                        <%# FNumber.FormatNumber(Eval("Amount")) %>&nbsp;
                    </td>
                    <td align="right">
                        <%# Convert.ToDecimal(Eval("Total")) > 0 ? FNumber.FormatNumber(Eval("Total")) : "Liên hệ sau" %>&nbsp;
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
        <tr height="30px">
            <td align="right" colspan="7">
                Tổng tiền : <span style="font-weight: bold; font-size: 14px">
                    <%= FNumber.FormatNumber(Total) %></span>&nbsp;
            </td>
        </tr>
    </table>
    <% if (IsFooterSms)
       { %>
    <div style="margin: 10px 0">
        <asp:Label ID="lblFooterOrderSms" runat="server"></asp:Label>
    </div>
    <%} %>
</div>
