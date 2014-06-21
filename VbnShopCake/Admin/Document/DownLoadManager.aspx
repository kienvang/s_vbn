<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="DownLoadManager.aspx.cs" Inherits="Admin_Document_DownLoadManager" Title="Quản lý nạp thẻ" %>

<%@ Register src="Control/DownLoadManager.ascx" tagname="DownLoadManager" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" Runat="Server">
    <uc1:DownLoadManager ID="DownLoadManager1" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" Runat="Server">
</asp:Content>

