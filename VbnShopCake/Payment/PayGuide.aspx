<%@ Page Language="C#" MasterPageFile="~/MasterPage-2col.master" AutoEventWireup="true"
    CodeFile="PayGuide.aspx.cs" Inherits="Payment_PayGuide" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Left" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Holder_Content" runat="Server">
    <h2>
        <asp:Label ID="lblPayName" runat="server"></asp:Label>
    </h2>
    <div>
        <asp:Label ID="lblContent" runat="server"></asp:Label>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
