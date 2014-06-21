<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="Admin_EmailTemplates_Default" Title="Email Templates" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" runat="Server">
    <div style="margin: 5px 0">
        Tên template :
        <asp:DropDownList ID="ddlEmailTemplate" runat="server" AppendDataBoundItems="true"
            Width="350px" AutoPostBack="True" 
            onselectedindexchanged="ddlEmailTemplate_SelectedIndexChanged">
            <asp:ListItem Value="">Chọn template</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="lblTemplateCode" runat="server"></asp:Label>
    </div>
    <div style="margin: 5px 0; background-color:#E4E4E4"">
        <b>Subject</b> :
        <asp:Label ID="lblSubject" runat="server"></asp:Label>
    </div>
    <div style="margin: 5px 0">
        <b>Body</b>
    </div>
    <div style="margin: 5px 0; min-height:300px; background-color:#E4E4E4">
        <asp:Label ID="lblBody" runat="server"></asp:Label>
    </div>
    <div style="margin: 5px 0; background-color:#E4E4E4"">
        Cập nhật cuối cùng :
        <asp:Label ID="lblUpdateBy" runat="server"></asp:Label>
    </div>
    <div>
    <asp:Button ID="btnEdit" runat="server" Text="Cập nhật" onclick="btnEdit_Click"/>
    <asp:Button ID="btnAdd" runat="server" Text="Thêm mới" onclick="btnAdd_Click" />
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
