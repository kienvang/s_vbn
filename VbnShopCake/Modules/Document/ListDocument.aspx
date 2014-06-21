<%@ Page Language="C#" MasterPageFile="~/MasterPage-2col.master" AutoEventWireup="true" CodeFile="ListDocument.aspx.cs" Inherits="Modules_Document_ListDocument" Title="Untitled Page" %>

<%@ Register src="Control/ListDocument.ascx" tagname="ListDocument" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Left" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Holder_Content" Runat="Server">
    <uc1:ListDocument ID="ListDocument1" runat="server" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Footer" Runat="Server">
</asp:Content>

