<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="CreateCode.aspx.cs" Inherits="Admin_Document_CreateCode" Title="Tạo thẻ nạp điểm" %>

<%@ Register src="Control/CreateCode.ascx" tagname="CreateCode" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" Runat="Server">
    <uc1:CreateCode ID="CreateCode1" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" Runat="Server">
</asp:Content>

