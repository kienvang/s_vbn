<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CatalogBox.ascx.cs" Inherits="Modules_Catalogs_Controls_CatalogBox" %>
<div class="listProducts">
    <h2>
        Danh mục con</h2>
    <div class="productsInfo">
        <asp:Repeater ID="repCatChild" runat="server">
            <HeaderTemplate>
                <div>
                    <ul class="item">
            </HeaderTemplate>
            <ItemTemplate>
                <li><a href='<%# Modules.Catalogs.UrlBuilder.GetCatsByIdTextId(int.Parse(Eval("Id").ToString()), Eval("TextId").ToString()) %>' title='<%# Eval("CatalogName") %>'><%# Eval("CatalogName") %></a></li>
                <%# Total == Container.ItemIndex + 1 ? "</ul></div><div><ul class='item'>" : ""%>
            </ItemTemplate>
            <FooterTemplate>
                </ul> </div>
            </FooterTemplate>
        </asp:Repeater>
    </div>
</div>
