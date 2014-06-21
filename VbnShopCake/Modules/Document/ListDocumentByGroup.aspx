<%@ Page Language="C#" MasterPageFile="~/MasterPage-2col.master" AutoEventWireup="true"
    CodeFile="ListDocumentByGroup.aspx.cs" Inherits="Modules_Document_Control_ListDocumentByGroup"
    Title="Untitled Page" %>

<%@ Register Src="Control/BreadCrumb.ascx" TagName="BreadCrumb" TagPrefix="uc4" %>
<%@ Register Src="Control/ListDocumentByGroup.ascx" TagName="ListDocumentByGroup"
    TagPrefix="uc1" %>
<%@ Register src="Control/TopDown.ascx" tagname="TopDown" tagprefix="uc2" %>
<%@ Register src="Control/TopNew.ascx" tagname="TopNew" tagprefix="uc3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Left" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Holder_Content" runat="Server">
    <uc4:BreadCrumb ID="BreadCrumb1" runat="server" />
    <uc1:ListDocumentByGroup ID="ListDocumentByGroup1" runat="server" />
    <uc2:TopDown ID="TopDown1" runat="server" />
    <uc3:TopNew ID="TopNew1" runat="server" />
    
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
