<%@ Page Language="C#" MasterPageFile="~/MasterPage-2col.master" AutoEventWireup="true" EnableViewState="false"
    CodeFile="Contact.aspx.cs" Inherits="Contact" Title="Untitled Page" %>

<%@ Register src="Modules/GoogleMaps/Controls/Maps2.ascx" tagname="Maps2" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Left" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Holder_Content" runat="Server">
    <div class="listProducts">
        <h2>
            Liên hệ</h2>
        <div>
            <asp:Label ID="lblTemplate" runat="server"></asp:Label>
        </div>
        <div>
        
            <uc1:Maps2 ID="Maps21" runat="server" MapWidth="750" MapHeight="400" />
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
