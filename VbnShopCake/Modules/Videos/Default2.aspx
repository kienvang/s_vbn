<%@ Page Language="C#" MasterPageFile="~/Modules/Videos/MasterPage.master" AutoEventWireup="true"
    CodeFile="Default2.aspx.cs" Inherits="Modules_Videos_Default2" Title="Untitled Page" %>

<%@ Register Src="Controls/VideoLasted.ascx" TagName="VideoLasted" TagPrefix="uc1" %>
<%@ Register Src="Controls/VideoBestView.ascx" TagName="VideoBestView" TagPrefix="uc2" %>
<%@ Register Src="Controls/VideoBox.ascx" TagName="VideoBox" TagPrefix="uc3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" runat="Server">
    <div class="videoContent">
        <div class="viewVideo">
            <h3>
                Videos</h3>
            <p>
                <uc3:VideoBox ID="VideoBox1" runat="server" />
            </p>
            <p style="margin: 10px 0">
                <asp:HyperLink ID="lk" runat="server"></asp:HyperLink>
            </p>
            <p>
                <asp:Label ID="lblDescription" runat="server"></asp:Label>
            </p>
        </div>
    </div>
    <div class="vdo-list">
        <asp:Repeater ID="repVideo" runat="server">
            <HeaderTemplate>
            <h3>
            Danh sách videos
            </h3>
            </HeaderTemplate>
            <ItemTemplate>
                <div class="item">
                    <div>
                        <a href='<%# Modules.Videos.UrlBuilder.ViewVideo(Eval("CatTextId").ToString(),int.Parse(Eval("IntId").ToString()), Eval("TextId").ToString()) %>'
                            title='<%# Eval("VideoName") %>'>
                            <img src='<%# !string.IsNullOrEmpty(Eval("Thumbnail").ToString()) ? Eval("Thumbnail").ToString() + "?w=95&c=1" : "/images/no_img.gif" %>'
                                width="75px" height="75px" title='<%# Eval("VideoName") %>' alt='<%# Eval("VideoName") %>' />
                        </a>
                    </div>
                    
                        <h2>
                            <a href='<%# Modules.Videos.UrlBuilder.ViewVideo(Eval("CatTextId").ToString(),int.Parse(Eval("IntId").ToString()), Eval("TextId").ToString()) %>'
                                title='<%# Eval("VideoName") %>'>
                                <%# Eval("VideoName") %>
                            </a>
                        </h2>
                    
                    <div style="clear: both">
                    </div>
                </div>
            </ItemTemplate>
            <FooterTemplate>
                <div style="clear: both">
                </div>
            </FooterTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Holder_Left" runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Holder_Right" runat="Server">
    <uc1:VideoLasted ID="VideoLasted1" runat="server" />
    <uc2:VideoBestView ID="VideoBestView1" runat="server" />
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
