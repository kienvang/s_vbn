<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true"
    CodeFile="AddEdit.aspx.cs" Inherits="Admin_New_AddEdit" Title="Add - Edit News" %>

<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
<%@ Register src="Controls/Menu.ascx" tagname="Menu" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" runat="Server">
    <uc1:Menu ID="Menu1" runat="server" />
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    <asp:CustomValidator ID="valNew" runat="server" ErrorMessage="CustomValidator" Display="None"></asp:CustomValidator>
    <table width="100%">
        <tr>
            <td width="120px">
                <b>Tên tin tức</b>
            </td>
            <td>
                :&nbsp;<asp:TextBox ID="txtSubject" runat="server" Width="450px"></asp:TextBox>
                <asp:RequiredFieldValidator ControlToValidate="txtSubject" Display="Dynamic" Text="*"
                    ID="RequiredFieldValidator1" runat="server" ErrorMessage="Nhập tên tin tức"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr valign="top">
            <td>
                <b>Nội dung</b>
            </td>
            <td>
                <FCKeditorV2:FCKeditor ID="txtBody" runat="server" ToolbarSet="MyToolbar" Width="700px"
                    Height="450px">
                </FCKeditorV2:FCKeditor>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                <asp:Button ID="btnAdd" runat="server" Text="Thêm" onclick="btnAdd_Click" />
                <asp:Button ID="btnEdit" runat="server" Text="Cập nhật" Visible="false" 
                    onclick="btnEdit_Click" />
                <asp:Button ID="btnDelete" runat="server" Text="Xóa" ValidationGroup="del" Visible="false"
                    OnClientClick="return confirm('Xác nhận xóa')" onclick="btnDelete_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="Quay ra" ValidationGroup="cancel"
                    Visible="false" onclick="btnCancel_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
