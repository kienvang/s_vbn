<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BoxImageFlash.ascx.cs"
    Inherits="Modules_Controls_BoxImageFlash" %>
<%@ Import Namespace="Modules" %>
<% if (MediaType == EnumsMediaType.Image)
   { %>
<a href='<%= MediaAddress %>' title='<%= MediaName %>' rel="nofollow" target="_blank">
    <img src='<%= MediaPath %>' alt='<%= MediaName %>' title='<%= MediaName %>' <%= FWidth > 0 ? "width='" + FWidth.ToString() + "px'" : "" %>
        <%= FHeight > 0 ? "height='" + FHeight.ToString() + "px'" : "" %> />
</a>
<%}
   else if (MediaType == EnumsMediaType.Flash)
   { %>
<div>
    <object codebase="http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=7,0,19,0"
        <%= FWidth2 > 0 ? "width='" + (FWidth2).ToString() + "'" : "" %> <%= FHeight2 > 0 ? "height='" + FHeight2.ToString() + "'" : "" %>>
        <param name="movie" value='<%= MediaPath %>' />
        <param name="quality" value="high" />
        <param name="bgColor" value="#ffffff"/>
        <param name="wmode" value="transparent"/>
        <embed src='<%= MediaPath %>' quality="high" pluginspage="http://www.macromedia.com/go/getflashplayer"
            type="application/x-shockwave-flash" <%= FWidth2 > 0 ? "width='" + (FWidth2).ToString() + "'" : "" %>
            <%= FHeight2 > 0 ? "height='" + FHeight2.ToString() + "'" : "" %>></embed>
    </object>
</div>
<%} %>
