<%@ Page Language="C#" MasterPageFile="~/MasterPage-2col.master" AutoEventWireup="true"
    CodeFile="Carts.aspx.cs" Inherits="Modules_Products_Carts" Title="Untitled Page" %>

<%@ Register Src="Controls/Carts.ascx" TagName="Carts" TagPrefix="uc1" %>
<%@ Register Src="../Adverts/Controls/Adverts2.ascx" TagName="Adverts" TagPrefix="uc5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" runat="Server">

    <script src="/js/jquery.numeric.js" type="text/javascript"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Left" runat="Server">
    <uc5:Adverts ID="Adverts2" runat="server" PositionType="L" PositionId="ALL|CART" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Holder_Content" runat="Server">
    <uc5:Adverts ID="Adverts1" runat="server" PositionType="T" PositionId="ALL|CART" />
    <uc1:Carts ID="Carts1" runat="server" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
