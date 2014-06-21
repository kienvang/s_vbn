<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" ValidateRequest="false"
    CodeFile="EditProduct.aspx.cs" Inherits="Admin_Products_EditProduct" Title="Cập Nhật Sản Phẩm" %>

<%@ Register Src="Controls/Menu.ascx" TagName="Menu" TagPrefix="uc1" %>
<%@ Register Src="Controls/EditProduct.ascx" TagName="EditProduct" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" runat="Server">
    <uc1:Menu ID="Menu1" runat="server" />
    <uc2:EditProduct ID="EditProduct1" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
