<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ProductPhoto.ascx.cs"
    Inherits="Modules_Products_Controls_ProductPhoto" %>
<div class="product_gallery">
    <ul>
        <asp:Repeater ID="repPhoto" runat="server">
            <ItemTemplate>
                <li <%# Container.ItemIndex == Container.Controls.Count ? "class='last'":"" %> ><a href='<%# Eval("Path") %>?w=500&c=1' title='<%# !string.IsNullOrEmpty(Eval("PhotoName").ToString()) ? Eval("PhotoName") : ProductName %>'>
                    <img class="gallery" src='<%# Eval("Path") %>' alt="" width="78" height="78" />
                </a></li>
            </ItemTemplate>
        </asp:Repeater>
    </ul>
</div>
