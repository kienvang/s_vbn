<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DetailDeals.ascx.cs" Inherits="Admin_Products_Controls_DetailDeals" %>
<%@ Import Namespace="Library.Tools" %>
<div>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="deals" CssClass="error"/>
    <table width="100%">
        <tr>
            <td width="120px">
                Giá bán
            </td>
            <td>
                :
                <asp:TextBox ID="txtPrice" runat="server" ValidationGroup="deals"></asp:TextBox>
                <asp:RequiredFieldValidator ControlToValidate="txtPrice" ID="RequiredFieldValidator1"
                    runat="server" ErrorMessage="Nhập giá bán" Text="*" Display="Dynamic" ValidationGroup="deals"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ControlToValidate="txtPrice" ID="RegularExpressionValidator1"
                    runat="server" ValidationExpression="[\d]{1,8}" ErrorMessage="Nhập chữ số" Text="*" Display="Dynamic" ValidationGroup="deals"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>
                Giá mua
            </td>
            <td>
                :
                <asp:TextBox ID="txtPoPrice" runat="server" ValidationGroup="deals"></asp:TextBox>
                <asp:RequiredFieldValidator ControlToValidate="txtPoPrice" ID="RequiredFieldValidator2"
                    runat="server" ErrorMessage="Nhập giá mua" Text="*" Display="Dynamic" ValidationGroup="deals"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ControlToValidate="txtPoPrice" ID="RegularExpressionValidator2"
                    runat="server" ValidationExpression="[\d]{1,8}" ErrorMessage="Nhập chữ số" Text="*" Display="Dynamic" ValidationGroup="deals"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                <asp:Button ID="btnAdd" runat="server" Text="Thêm" ValidationGroup="deals" 
                    onclick="btnAdd_Click" />
            </td>
        </tr>
    </table>
</div>
<div>
    <table border="1" class="grid-sub">
        <tr class="title">
            <th width="40px">
                STT
            </th>
            <th width="150px">
                Giá Bán
            </th>
            <th width="150px">
                Giá Mua
            </th>
            <th width="100px">
                Ngày Tạo
            </th>
            <td width="200px">
                Người Tạo
            </td>
        </tr>
        <asp:Repeater ID="repDeals" runat="server">
            <ItemTemplate>
                <tr class="row">
                    <td align="center">
                        <%# Container.ItemIndex + 1 %>
                    </td>
                    <td align="right">
                        <%# FNumber.FormatNumber(Eval("Price")) %>
                        <%# Eval("Currency") %>
                    </td>
                    <td align="right">
                        <%# FNumber.FormatNumber(Eval("PoPrice")) %>
                        <%# Eval("Currency") %>
                    </td>
                    <td align="center">
                        <%# DateTime.Parse(Eval("CreatedDate").ToString()).ToString("dd/MM/yyyy") %>
                    </td>
                    <td>
                        <%# Eval("CreatedBy") %>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
</div>
