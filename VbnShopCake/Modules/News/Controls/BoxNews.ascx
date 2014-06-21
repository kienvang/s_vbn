<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BoxNews.ascx.cs" Inherits="Modules_News_Controls_BoxNews" %>
<h2>
    Hướng dẫn thanh toán</h2>
<ul class="levMenu">
    <asp:Repeater ID="repNews" runat="server">
        <ItemTemplate>
            <li><a href='<%# Modules.UrlBuilder.GetNews(Eval("TextId").ToString()) %>' title='<%# Eval("Subject") %>'><%# Eval("Subject") %></a></li>
        </ItemTemplate>
    </asp:Repeater>
</ul>
