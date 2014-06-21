<%@ Page Language="C#" MasterPageFile="~/MasterPage-2col.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" Title="Untitled Page" EnableViewState="false" %>

<%@ Register Src="Modules/Home/Controls/Videos.ascx" TagName="Videos" TagPrefix="uc1" %>
<%@ Register Src="Modules/Home/Controls/ProductHome.ascx" TagName="ProductHome" TagPrefix="uc2" %>
<%@ Register src="Modules/Adverts/Controls/Adverts2.ascx" tagname="Adverts" tagprefix="uc3" %>
<%@ Register src="Modules/Home/Controls/VideoHome.ascx" tagname="VideoHome" tagprefix="uc4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" runat="Server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Left" runat="Server">
    <uc3:Adverts ID="Adverts1" runat="server" PositionId="ALL|HOME" PositionType="L"/>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Holder_Content" runat="Server">
<uc3:Adverts ID="Adverts2" runat="server" PositionId="ALL|HOME" PositionType="T"/>
    <uc4:VideoHome ID="VideoHome1" runat="server" />
    <uc1:Videos ID="Videos1" runat="server" Visible="false" />
    <uc2:ProductHome ID="ProductHome1" runat="server" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
