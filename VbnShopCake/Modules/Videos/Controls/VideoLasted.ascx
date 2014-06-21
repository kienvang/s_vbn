<%@ Control Language="C#" AutoEventWireup="true" CodeFile="VideoLasted.ascx.cs" Inherits="Modules_Videos_Controls_VideoLasted" %>
<h2>
    Video mới nhất
</h2>
<ul class="li-video">
    <asp:Repeater runat="server" ID="repVideo">
        <ItemTemplate>
        <li><a href='<%# Modules.Videos.UrlBuilder.ViewVideo(Eval("CatTextId").ToString(),int.Parse(Eval("IntId").ToString()), Eval("TextId").ToString()) %>' title='<%# Eval("VideoName") %>'><%# Eval("VideoName") %></a></li>
        </ItemTemplate>
    </asp:Repeater>
</ul>
