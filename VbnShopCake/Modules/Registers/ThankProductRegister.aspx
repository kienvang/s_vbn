﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage-2col.master" AutoEventWireup="true" EnableViewState="False"
    CodeFile="ThankProductRegister.aspx.cs" Inherits="Modules_Registers_ThankProductRegister"
    Title="Đăng Ký Bán Hàng Thành Công" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Left" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Holder_Content" runat="Server">
    <h2 style="text-align: center">
        <asp:Label ID="lblSubject" runat="server"></asp:Label>
    </h2>
    <div style="min-height:500px">
        <asp:Label ID="lblBody" runat="server"></asp:Label>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
