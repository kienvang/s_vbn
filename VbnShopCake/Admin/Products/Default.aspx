<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="Admin_Products_Default" Title="Sản Phẩm" %>

<%@ Register Src="Controls/ListProducts.ascx" TagName="ListProducts" TagPrefix="uc1" %>
<%@ Register Src="Controls/Menu.ascx" TagName="Menu" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" runat="Server">
    <div>
        <uc2:Menu ID="Menu1" runat="server" />
    </div>
    <div>
        <uc1:ListProducts ID="ListProducts1" runat="server" />
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
