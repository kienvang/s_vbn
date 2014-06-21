<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Catalogs.ascx.cs" Inherits="Modules_Home_Controls_Catalogs" %>
<h2>
    Danh mục shops</h2>
<ul class="levMenu">
    <asp:Repeater ID="repCatParent" runat="server">
        <ItemTemplate>
        
            <li >
            <a <%# int.Parse(Eval("Id").ToString()) == CatId ? "class='current'" : "" %> href='<%# Modules.Catalogs.UrlBuilder.GetCatsByIdTextId(int.Parse(Eval("Id").ToString()), Eval("TextId").ToString()) %>' title='<%# string.IsNullOrEmpty(Eval("ToolTip").ToString()) ? Eval("CatalogName").ToString() : "" %>'>
                <%#  Eval("CatalogName") %>
            </a>
                <asp:Repeater ID="repCatChild" runat="server" DataSource='<%# LoadChild(int.Parse(Eval("Id").ToString())) %>'>
                    <HeaderTemplate>
                        <ul>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <li <%# int.Parse(Eval("Id").ToString()) == CatId ? "class='current'" : "" %> ><a href='<%# Modules.Catalogs.UrlBuilder.GetCatsByIdTextId(int.Parse(Eval("Id").ToString()), Eval("TextId").ToString()) %>' title='<%# Eval("CatalogName") %>'><%# Eval("CatalogName") %></a></li>
                    </ItemTemplate>
                    <FooterTemplate>
                        </ul>
                    </FooterTemplate>
                </asp:Repeater>
            </li>
        </ItemTemplate>
    </asp:Repeater>
</ul>
