<%@ Page Language="C#" MasterPageFile="~/MasterPage-2col.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Modules_GoogleMaps_Default" Title="Untitled Page" %>

<%@ Register src="Controls/Maps2.ascx" tagname="Maps2" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Left" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Holder_Content" Runat="Server">
    <uc1:Maps2 ID="Maps21" runat="server"  MapHeight="300" MapWidth="400" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Footer" Runat="Server">
</asp:Content>

