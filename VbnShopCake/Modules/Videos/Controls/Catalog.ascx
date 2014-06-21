<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Catalog.ascx.cs" Inherits="Modules_Videos_Controls_Catalog" %>
<h2>
    Videos</h2>
<ul class="levMenu">
    <asp:Repeater ID="repCatalog" runat="server">
        <ItemTemplate>
            <li><a <%# !string.IsNullOrEmpty(Request["CatTextId"]) ? (Eval("TextId").ToString() == Request["CatTextId"] ? "class='current'" : "") : "" %> href='<%# Modules.Videos.UrlBuilder.VideoCatalog(Eval("TextId").ToString()) %>' title='<%# Eval("CatName") %>'>
                <%#  Eval("CatName")%>
            </a></li>
        </ItemTemplate>
    </asp:Repeater>
</ul>
