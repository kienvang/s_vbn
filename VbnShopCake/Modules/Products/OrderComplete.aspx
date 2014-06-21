<%@ Page Language="C#" MasterPageFile="~/MasterPage-2col.master" AutoEventWireup="true" CodeFile="OrderComplete.aspx.cs" Inherits="Modules_Products_OrderComplete" Title="Untitled Page" %>

<%@ Register src="../Payment/Controls/SingleOrderDetail.ascx" tagname="SingleOrderDetail" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Left" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Holder_Content" Runat="Server">
    <uc1:SingleOrderDetail ID="SingleOrderDetail1" runat="server" Visible="false" />
    <asp:Label ID="lblMes" runat="server"></asp:Label>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Footer" Runat="Server">
</asp:Content>

