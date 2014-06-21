<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true"
    CodeFile="Detail.aspx.cs" Inherits="Admin_Products_Detail" Title="Untitled Page" %>

<%@ Register Src="Controls/Detail.ascx" TagName="Detail" TagPrefix="uc1" %>
<%@ Register Src="Controls/Menu.ascx" TagName="Menu" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" runat="Server">
    <uc2:Menu ID="Menu1" runat="server" />
    <uc1:Detail ID="Detail1" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
