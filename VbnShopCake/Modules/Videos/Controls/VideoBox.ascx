<%@ Control Language="C#" AutoEventWireup="true" CodeFile="VideoBox.ascx.cs" Inherits="Modules_Videos_Controls_VideoBox" %>
<%if (VideoType == "FLASH")
  { %>
<div>
    <% if (ObjectType == "URL")
       {%>
    <embed height="<%= Height %>" width="<%= Width %>" flashvars="file=<%= CodeEmbeb %>&amp;image=<%= Thumbnail %>"
        allowfullscreen="true" vmode="transparent" quality="high" name="playlist" id="playlist"
        src="/img/mediaplayer.swf" type="application/x-shockwave-flash" wmode="transparent" />
    <%}
       else
       { %>
    <%= CodeEmbeb %>
    <%}
    %>
</div>
<%}
  else if (VideoType == "FLA")
  {%>
<object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" codebase="http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=6,0,40,0"
    height="<%= Height %>" width="<%= Width %>">
    <param name="flashvars" value="file=<%= FileName %>&image=<%= Thumbnail %>" />
    <param name="movie" value="/img/mediaplayer.swf" />
    <embed src="/img/mediaplayer.swf" height="<%= Height %>" width="<%= Width %>" type="application/x-shockwave-flash"
        pluginspage="http://www.macromedia.com/go/getflashplayer" flashvars="file=<%= FileName %>&image=<%= Thumbnail %>" /></object>
<%}
  else
  { %>
<object height="<%= Height %>" width="<%= Width %>" id="WMPlayer" codebase="http://activex.microsoft.com/activex/controls/mplayer/en/nsmp2inf.cab#Version=6,4,5,715"
    type="application/x-oleobject" standby="Loading Microsoft Windows Media Player components..."
    classid="CLSID:6BF52A52-394A-11D3-B153-00C04F79FAA6" name="winMediaPlayer">
    <param name="URL" value="<%= FileName %>" />
    <param name="rate" value="1" />
    <param name="balance" value="0" />
    <param name="currentPosition" value="2.1460625" />
    <param name="defaultFrame" value="0" />
    <param name="playCount" value="1" />
    <param name="autoStart" value="<%= AutoStart %>" />
    <embed height="<%= Height %>" width="<%= Width %>" type="application/x-mplayer2"
        pluginspage="http://www.microsoft.com/windows/windowsmedia/download/" src='<%= FileName %>'
        id="winMediaPlayerIDFF" autosize="-1" autostart="<%= AutoStart %>" clicktoplay="1"
        displaysize="4" enablecontextmenu="0" enablefullscreencontrols="1" enabletracker="1"
        mute="0" volume="100" playcount="1" showcontrols="1" />
</object>
<%} %>
<%--<object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" codebase="http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=6,0,40,0"
        width="480" height="360">
        <param name="flashvars" value="file=http://www.walkernews.net/wp-content/uploads/2008/01/LionLove.flv&image=http://www.walkernews.net/wp-content/uploads/2008/01/Lion-Hug-Rescuer.JPG" />
        <param name="movie" value="http://www.walkernews.net/mediaplayer.swf" />
        <embed src="http://www.walkernews.net/mediaplayer.swf" width="480" height="360" type="application/x-shockwave-flash"
            pluginspage="http://www.macromedia.com/go/getflashplayer" flashvars="file=http://www.walkernews.net/wp-content/uploads/2008/01/LionLove.flv&image=http://www.walkernews.net/wp-content/uploads/2008/01/Lion-Hug-Rescuer.JPG" /></object>--%>