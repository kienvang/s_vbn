<%@ Page Language="C#" MasterPageFile="~/MasterPage-2col.master" AutoEventWireup="true"
    CodeFile="Default2.aspx.cs" Inherits="Default2" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Left" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Holder_Content" runat="Server">
    <asp:Repeater ID="rep" runat="server" onitemcommand="rep_ItemCommand">
        <ItemTemplate>
            <div>
                <%# Eval("ProductName") %></div>
            <div>
                <asp:LinkButton ID="lk" runat="server" CommandArgument='<%# Eval("Id") %>' CommandName="order"><%# Eval("ProductName") %></asp:LinkButton></div>
        </ItemTemplate>
        <SeparatorTemplate>
            -------------------------------------------------
        </SeparatorTemplate>
    </asp:Repeater>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
