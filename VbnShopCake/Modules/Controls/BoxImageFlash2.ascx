<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BoxImageFlash2.ascx.cs" Inherits="Modules_Controls_BoxImageFlash2" %>
<%@ Import Namespace="Modules" %>
<% if (MediaType == EnumsMediaType.Image)
   { %>
<a>
    <img src='<%= MediaPath %>?c=0&w=<%= FWidth %>&h=<%= FHeight %>' alt='<%= MediaName %>' title='<%= MediaName %>'  />
</a>
<%}
   else if (MediaType == EnumsMediaType.Flash)
   { %>
<div>
    <object codebase="http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=7,0,19,0"
        <%= FWidth > 0 ? "width='" + (FWidth).ToString() + "'" : "" %> <%= FHeight > 0 ? "height='" + FHeight.ToString() + "'" : "" %>>
        <param name="movie" value='<%= MediaPath %>' />
        <param name="quality" value="high" />
        <param name="bgColor" value="#ffffff"/>
        <param name="wmode" value="transparent"/>
        <embed src='<%= MediaPath %>' quality="high" pluginspage="http://www.macromedia.com/go/getflashplayer"
            type="application/x-shockwave-flash" <%= FWidth > 0 ? "width='" + (FWidth).ToString() + "'" : "" %>
            <%= FHeight > 0 ? "height='" + FHeight.ToString() + "'" : "" %>></embed>
    </object>
</div>
<%} %>