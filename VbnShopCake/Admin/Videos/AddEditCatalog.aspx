<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true"
    CodeFile="AddEditCatalog.aspx.cs" Inherits="Admin_Videos_AddEditCatalog" Title="Untitled Page" %>

<%@ Register Src="Controls/Menu.ascx" TagName="Menu" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" runat="Server">
    <uc1:Menu ID="Menu1" runat="server" />
    <h2>
        Danh mục Video</h2>
    <table width="100%">
        <tr>
            <td width="120px">
                <b>Tên danh mục</b>
            </td>
            <td>
                <asp:TextBox ID="txtCatName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                <asp:Button ID="btnAdd" runat="server" Text="Thêm" OnClick="btnAdd_Click" />
                <asp:Button ID="btnEdit" runat="server" Text="Cập nhật" OnClick="btnEdit_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="Quay ra" OnClick="btnCancel_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <b></b>
            </td>
            <td>
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
