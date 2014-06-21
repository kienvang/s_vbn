<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="ListDocument.aspx.cs" Inherits="Admin_Document_ListDocument" Title="Quản lý danh sách tài liệu" %>

<%@ Register src="Control/ListDocument.ascx" tagname="ListDocument" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" Runat="Server">
    <uc1:ListDocument ID="ListDocument1" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" Runat="Server">
</asp:Content>

