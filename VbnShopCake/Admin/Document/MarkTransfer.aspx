<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true"
    CodeFile="MarkTransfer.aspx.cs" Inherits="Admin_Document_MarkTransfer" Title="Diem Giao Dich" %>

<%@ Import Namespace="Library.Tools" %>
<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" runat="Server">
    <h2>
        Loại điểm giao dịch</h2>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="error" />
    <asp:CustomValidator ID="invalid" runat="server" ErrorMessage="CustomValidator" Display="None"
        OnServerValidate="invalid_ServerValidate"></asp:CustomValidator>
    <table width="100%">
        <tr>
            <td width="120px">
                <b>Mã</b>
            </td>
            <td>
                <asp:TextBox ID="txtCode" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtCode"
                    Display="Dynamic" ErrorMessage="Nhập mã">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <b>Số điểm</b>
            </td>
            <td>
                <asp:TextBox ID="txtMark" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtMark"
                    Display="Dynamic" ErrorMessage="Nhập điểm">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ControlToValidate="txtMark" ValidationExpression="[\d]{0,5}"
                    ID="RegularExpressionValidator1" runat="server" ErrorMessage="Nhập số điểm là số"
                    Display="Dynamic" Text="*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>
                <b>Số tiền</b>
            </td>
            <td>
                <asp:TextBox ID="txtCost" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtCost"
                    Display="Dynamic" ErrorMessage="Nhập số tiền">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ControlToValidate="txtCost" ValidationExpression="[\d]{0,9}"
                    ID="RegularExpressionValidator2" runat="server" ErrorMessage="Nhập số tiền là số"
                    Display="Dynamic" Text="*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>
                <b></b>
            </td>
            <td>
                <asp:Button ID="btnAdd" runat="server" Text="Thêm" OnClick="btnAdd_Click" />
            </td>
        </tr>
    </table>
    <table class="grid">
        <tr>
            <th width="40px">
            </th>
            <th width="120px">
                Mã
            </th>
            <th>
                Số điểm
            </th>
            <th width="150px">
                Số tiền
            </th>
            <th width="40px">
            </th>
        </tr>
        <asp:Repeater ID="rep" runat="server" OnItemCommand="rep_ItemCommand">
            <ItemTemplate>
                <tr class="row">
                    <td align="center">
                        <%# Container.ItemIndex +1 %>
                    </td>
                    <td>
                        <%# Eval("Code") %>
                    </td>
                    <td>
                        <%# FNumber.FormatNumber(Eval("Mark")) %>
                    </td>
                    <td align="right">
                        <%# FNumber.FormatNumber(Eval("Cost")) %>
                    </td>
                    <td align="center">
                        <asp:LinkButton ValidationGroup="del" ID="lkDel" runat="server" CommandName="del"
                            CommandArgument='<%# Eval("Id") %>' OnClientClick="return confirm('Xác nhận xóa?')"><img src="/img/button/exit.png" /></asp:LinkButton>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
