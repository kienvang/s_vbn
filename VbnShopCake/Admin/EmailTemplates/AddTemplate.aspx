<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true"
    CodeFile="AddTemplate.aspx.cs" Inherits="Admin_EmailTemplates_AddTemplate" Title="Add Email Template" %>

<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" runat="Server">
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    <table width="100%" border="0">
        <tr>
            <td width="120px">
                Mã template
            </td>
            <td>
                <asp:TextBox ID="txtTemplateCode" runat="server" Width="350px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtTemplateCode"
                    ErrorMessage="Nhập mã code" Text="*" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                Tên template
            </td>
            <td>
                <asp:TextBox ID="txtTemplateName" runat="server" Width="350px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtTemplateName"
                    ErrorMessage="Nhập tên template" Text="*" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                Tiêu đề
            </td>
            <td>
                <asp:TextBox ID="txtSubject" runat="server" Width="350px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtSubject"
                    ErrorMessage="Nhập tiêu đề template" Text="*" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                Nội dung
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <FCKeditorV2:FCKeditor ID="txtBody" runat="server" ToolbarSet="MyToolbar" Width="700px"
                    Height="300px">
                </FCKeditorV2:FCKeditor>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btnAdd" runat="server" Text="Thêm" OnClick="btnAdd_Click" />
                <asp:Button ID="btnCancel" runat="server" ValidationGroup="cancel" Text="Quay ra"
                    OnClick="btnCancel_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
