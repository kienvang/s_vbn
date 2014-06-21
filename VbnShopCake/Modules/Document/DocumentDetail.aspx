<%@ Page Language="C#" MasterPageFile="~/MasterPage-2col.master" AutoEventWireup="true" CodeFile="DocumentDetail.aspx.cs" Inherits="Modules_Document_DocumentDetail" Title="Untitled Page" %>

<%@ Register src="Control/DocumentDetail.ascx" tagname="DocumentDetail" tagprefix="uc1" %>

<%@ Register src="Control/BreadCrumb.ascx" tagname="BreadCrumb" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Left" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Holder_Content" Runat="Server">
    <uc2:BreadCrumb ID="BreadCrumb1" runat="server" />
    <uc1:DocumentDetail ID="DocumentDetail1" runat="server" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Footer" Runat="Server">
</asp:Content>

