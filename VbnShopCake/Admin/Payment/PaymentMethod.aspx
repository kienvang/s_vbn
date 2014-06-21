<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true"
    CodeFile="PaymentMethod.aspx.cs" Inherits="Admin_Payment_PaymentMethod" Title="Phương thức thanh toán" %>

<%@ Register Src="Control/EditPayment.ascx" TagName="EditPayment" TagPrefix="uc1" %>
<%@ Register Src="Control/Payment.ascx" TagName="Payment" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" runat="Server">
    <% if (string.IsNullOrEmpty(Request["id"]))
       { %>
    <uc2:Payment ID="Payment1" runat="server" />
    <%}
       else
       { %>
    <uc1:EditPayment ID="EditPayment1" runat="server" />
    <%} %>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
