<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BreadCrumb.ascx.cs" Inherits="Modules_Catalogs_Controls_BreadCrumb" %>
<p class="marginB10">
    <a href="/" class="breadrum">Trang chủ</a>&nbsp;&nbsp;>
    <asp:Repeater ID="repBreadCrumb" runat="server">
        <ItemTemplate>
            <a href='<%# Modules.Catalogs.UrlBuilder.GetCatsByIdTextId(int.Parse(Eval("Id").ToString()), Eval("TextId").ToString()) %>'
                class="breadrum">
                <%# Eval("CatalogName") %>
            </a>
        </ItemTemplate>
        <SeparatorTemplate>
            &nbsp;&nbsp;>&nbsp;&nbsp;
        </SeparatorTemplate>
    </asp:Repeater>
</p>
