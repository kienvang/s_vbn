<%@ Page Language="C#" MasterPageFile="~/MasterPage-2col.master" AutoEventWireup="true" ValidateRequest="false"
    CodeFile="Payment.aspx.cs" Inherits="Modules_Products_Payment" Title="Untitled Page" %>

<%@ Register Src="Controls/CartInfo.ascx" TagName="CartInfo" TagPrefix="uc1" %>
<%@ Register Src="Controls/Payment.ascx" TagName="Payment" TagPrefix="uc2" %>
<%@ Register Src="../Adverts/Controls/Adverts2.ascx" TagName="Adverts" TagPrefix="uc5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" runat="Server">

    <script src="/js/jquery.timepicker.js" type="text/javascript"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Left" runat="Server">
    <uc5:Adverts ID="Adverts2" runat="server" PositionType="L" PositionId="ALL|PAY" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Holder_Content" runat="Server">
    <uc5:Adverts ID="Adverts1" runat="server" PositionType="T" PositionId="ALL|PAY" />
    <uc1:CartInfo ID="CartInfo1" runat="server" />
    <uc2:Payment ID="Payment1" runat="server" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
