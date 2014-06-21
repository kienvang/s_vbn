<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Videos.ascx.cs" Inherits="Modules_Home_Controls_Videos" %>
<%@ Register Src="../../Videos/Controls/VideoBox.ascx" TagName="VideoBox" TagPrefix="uc1" %>
<div class="videoContent">
    <div class="viewVideo">
        <h3>
            Videos</h3>
        
            <p>
                <uc1:VideoBox ID="VideoBox1" runat="server" />
            </p>
        
    </div>
    <div class="videoDetail">
        <h4>
            <span>Chi tiết video</span></h4>
        <ul>
            <asp:Repeater ID="repVideo" runat="server">
                <ItemTemplate>
                    <li><a href='<%# Modules.Videos.UrlBuilder.ViewVideo(int.Parse(Eval("IntId").ToString()), Eval("TextId").ToString()) %>' title='<%# Eval("VideoName") %>'><%# Eval("VideoName") %></a></li></ItemTemplate>
            </asp:Repeater>
        </ul>
    </div>
</div>
