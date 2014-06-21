<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="OrderDetail.aspx.cs" Inherits="Admin_Orders_OrderDetail" Title="Untitled Page" %>

<%@ Register src="Controls/OrderDetail.ascx" tagname="OrderDetail" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" Runat="Server">
    <uc1:OrderDetail ID="OrderDetail1" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" Runat="Server">
</asp:Content>

