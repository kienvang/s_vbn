<%@ Page Language="C#" MasterPageFile="~/MasterPage-2col.master" AutoEventWireup="true" CodeFile="ThankSupplierRegister.aspx.cs" Inherits="Modules_Registers_ThankSupplierRegister" Title="Đăng Ký Nhà Cung Cấp Thành Công" EnableViewState="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Left" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Holder_Content" Runat="Server">
<h2 style="text-align: center">
        <asp:Label ID="lblSubject" runat="server"></asp:Label>
    </h2>
    <div style="min-height:500px">
        <asp:Label ID="lblBody" runat="server"></asp:Label>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Footer" Runat="Server">
</asp:Content>

