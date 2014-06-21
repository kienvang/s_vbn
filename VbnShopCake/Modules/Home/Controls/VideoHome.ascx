<%@ Control Language="C#" AutoEventWireup="true" CodeFile="VideoHome.ascx.cs" Inherits="Modules_Home_Controls_VideoHome" %>
<div class="vdo-header">
    <div class="vdo-01">
    </div>
    <div class="vdo-02">
        Video
    </div>
    <div class="vdo-03">
    </div>
    <div class="vdo-04">
    </div>
    <div class="vdo-05">
    </div>
</div>
<div class="clear">
</div>
<div class="vdo-content">
    <asp:Repeater ID="repVideoTop" runat="server">
        <ItemTemplate>
            <div class="vdo-item">
                <a href='<%# Modules.Videos.UrlBuilder.ViewVideo(Eval("CatTextId").ToString(),int.Parse(Eval("IntId").ToString()), Eval("TextId").ToString()) %>'
                    title='<%# Eval("VideoName") %>'>
                    <img src='<%# !string.IsNullOrEmpty(Eval("Thumbnail").ToString()) ? Eval("Thumbnail").ToString() + "?w=95&c=1" : "/images/no_img.gif" %>'
                        width="95px" height="95px" title='<%# Eval("VideoName") %>' alt='<%# Eval("VideoName") %>' />
                </a>
            </div>
        </ItemTemplate>
        <FooterTemplate>
            <div style="clear: both">
            </div>
        </FooterTemplate>
    </asp:Repeater>
</div>
