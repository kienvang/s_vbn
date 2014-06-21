<%@ Page Language="C#" MasterPageFile="~/MasterPage-2col.master" AutoEventWireup="true" CodeFile="Thankyou.aspx.cs" Inherits="Payment_Thankyou" Title="Untitled Page" %>

<%@ Register src="../Modules/Payment/Controls/SingleOrderDetail.ascx" tagname="SingleOrderDetail" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Left" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Holder_Content" Runat="Server">
    <asp:Label ID="lblMes" runat="server"></asp:Label>
    <uc1:SingleOrderDetail ID="SingleOrderDetail1" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Footer" Runat="Server">
</asp:Content>

