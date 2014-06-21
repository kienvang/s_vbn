<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Video.ascx.cs" Inherits="Modules_Videos_Controls_Video" %>
<%@ Register Src="VideoBox.ascx" TagName="VideoBox" TagPrefix="uc1" %>

<table width="100%" border="0">
    <tr>
        <td>
            <div class="videoContent">
                <div class="viewVideo">
                    <h3>
                        Videos</h3>
                    <p>
                        <uc1:VideoBox ID="VideoBox1" runat="server" />
                    </p>
                    <p style="margin:10px 0">
                        <asp:HyperLink ID="lk" runat="server"></asp:HyperLink>
                    </p>
                    <p>
                        <asp:Label ID="lblDescription" runat="server"></asp:Label>
                    </p>
                </div>
            </div>
        </td>
        <td class="videotop" align="center" valign="top">
            <asp:Repeater ID="repVideoTop" runat="server">
                <ItemTemplate>
                    <div class="video-item">
                        <a href='<%# Modules.Videos.UrlBuilder.ViewVideo(int.Parse(Eval("IntId").ToString()), Eval("TextId").ToString()) %>'
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
        </td>
    </tr>
</table>
