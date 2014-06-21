<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DetailProduct.ascx.cs"
    Inherits="Admin_Products_Controls_DetailProduct" %>
<div>
    <table width="100%" cellpadding="2" cellspacing="2">
        <tr>
            <td width="120px">
                <b>Thông tin tóm tắt</b>
            </td>
            <td>
                <asp:Label ID="lblAbstract" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <b>Thông tin bảo hành</b>
            </td>
            <td><asp:Label ID="lblWaranty" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <b>Thông tin chi tiết</b>
            </td>
            <td><asp:Label ID="lblDetail" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</div>
