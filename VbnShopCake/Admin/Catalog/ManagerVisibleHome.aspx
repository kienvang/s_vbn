<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true"
    CodeFile="ManagerVisibleHome.aspx.cs" Inherits="Admin_Catalog_ManagerVisibleHome"
    Title="Thiết Lập Hiển Thị Trang Chủ" %>

<%@ Register Src="Controls/Menu.ascx" TagName="Menu" TagPrefix="uc1" %>
<%@ Register Src="Controls/VisibleInHome.ascx" TagName="VisibleInHome" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" runat="Server">
    <uc1:Menu ID="Menu1" runat="server" />
    <uc2:VisibleInHome ID="VisibleInHome1" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
