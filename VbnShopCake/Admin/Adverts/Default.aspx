<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Admin_Adverts_Default" Title="Danh Sách Quảng Cáo" %>

<%@ Register src="Controls/ListAdverts.ascx" tagname="ListAdverts" tagprefix="uc1" %>


<%@ Register src="Controls/Menu.ascx" tagname="Menu" tagprefix="uc2" %>


<asp:Content ID="Content1" ContentPlaceHolderID="header" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" Runat="Server">

    <uc2:Menu ID="Menu1" runat="server" />

    <uc1:ListAdverts ID="ListAdverts1" runat="server" />

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" Runat="Server">
</asp:Content>

