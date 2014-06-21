<%@ Page Language="C#" MasterPageFile="~/MasterPage-2col.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Modules_Videos_Default" Title="Untitled Page" EnableViewState="false" %>

<%@ Register src="Controls/Video.ascx" tagname="Video" tagprefix="uc1" %>


<%@ Register src="Controls/Catalog.ascx" tagname="Catalog" tagprefix="uc2" %>


<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Left" Runat="Server">
    
    <uc2:Catalog ID="Catalog1" runat="server" />
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Holder_Content" Runat="Server">
<uc1:Video ID="Video1" runat="server" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Footer" Runat="Server">
</asp:Content>

