<%@ Page Language="C#" MasterPageFile="~/MasterPage-2col.master" AutoEventWireup="true"
    EnableViewState="false" CodeFile="ProductList.aspx.cs" Inherits="Modules_Products_ProductList"
    Title="Untitled Page" %>

<%@ Register Src="../Catalogs/Controls/BreadCrumb.ascx" TagName="BreadCrumb" TagPrefix="uc1" %>
<%@ Register Src="Controls/ProductList.ascx" TagName="ProductList" TagPrefix="uc2" %>
<%@ Register Src="Controls/ProductTopNew.ascx" TagName="ProductTopNew" TagPrefix="uc3" %>
<%@ Register Src="../Catalogs/Controls/CatalogBox.ascx" TagName="CatalogBox" TagPrefix="uc4" %>
<%@ Register src="../Adverts/Controls/Adverts2.ascx" tagname="Adverts" tagprefix="uc5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Left" runat="Server">
    <uc5:Adverts ID="Adverts1" runat="server" PositionType="L" PositionId="ALL|P"/>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Holder_Content" runat="Server">
    <uc1:BreadCrumb ID="BreadCrumb1" runat="server" />
    <uc5:Adverts ID="Adverts2" runat="server" PositionType="T" PositionId="ALL|P"/>
    <uc4:CatalogBox ID="CatalogBox1" runat="server" />
    <uc3:ProductTopNew ID="ProductTopNew1" runat="server"/>
    <uc2:ProductList ID="ProductList1" runat="server" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
