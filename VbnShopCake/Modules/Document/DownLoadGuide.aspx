<%@ Page Language="C#" MasterPageFile="~/MasterPage-2col.master" AutoEventWireup="true" CodeFile="DownLoadGuide.aspx.cs" Inherits="Modules_Document_DownLoadGuide" Title="Untitled Page" %>

<%@ Register src="Control/DownLoadGuide.ascx" tagname="DownLoadGuide" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Left" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Holder_Content" Runat="Server">
    <uc1:DownLoadGuide ID="DownLoadGuide1" runat="server" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Footer" Runat="Server">
</asp:Content>

