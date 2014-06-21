<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="MarkAddManager.aspx.cs" Inherits="Admin_Document_MarkAddManager" Title="Quản lý nạp điểm" %>

<%@ Register src="Control/MarkAddManager.ascx" tagname="MarkAddManager" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" Runat="Server">
    <uc1:MarkAddManager ID="MarkAddManager1" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" Runat="Server">
</asp:Content>

