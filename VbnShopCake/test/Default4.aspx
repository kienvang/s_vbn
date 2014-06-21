<%@ Page Language="C#" MasterPageFile="~/MasterPage-2col.master" AutoEventWireup="true"
    CodeFile="Default4.aspx.cs" Inherits="test_Default4" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Left" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Holder_Content" runat="Server">
    <!--
  jCarousel library
-->

    <script type="text/javascript" src="/js/jcarousel/jquery.jcarousel.js"></script>

    <!--
  jCarousel core stylesheet
-->
    <link rel="stylesheet" type="text/css" href="/css/jcarousel/jquery.jcarousel.css" />

    <script type="text/javascript" src="/js/lightbox/jquery.lightbox.js"></script>

    <!--
  jCarousel skin stylesheet
-->
    <link rel="stylesheet" type="text/css" href="/css/jcarousel/jcarousel/skins/tango/skin.css" />
    <link rel="stylesheet" type="text/css" href="/css/lightbox/jquery.lightbox.css" media="screen" />
    <style type="text/css">
        img
        {
            border-style: none;
        }
    </style>

    <script type="text/javascript">

jQuery(document).ready(function() {
    jQuery('#mycarousel').jcarousel();
    $('#mycarousel a').lightBox();
});

    </script>

    <ul id="mycarousel" class="jcarousel-skin-tango">
        <li><a href="http://static.flickr.com/66/199481236_dc98b5abb3_s.jpg" title="chao ban">
            <img src="http://static.flickr.com/66/199481236_dc98b5abb3_s.jpg" width="75" height="75"
                alt="" /></a></li>
        <li><a href="http://static.flickr.com/75/199481072_b4a0d09597_s.jpg">
            <img src="http://static.flickr.com/75/199481072_b4a0d09597_s.jpg" width="75" height="75"
                alt="" /></a></li>
        <li><a href="http://static.flickr.com/57/199481087_33ae73a8de_s.jpg">
            <img src="http://static.flickr.com/57/199481087_33ae73a8de_s.jpg" width="75" height="75"
                alt="" /></a></li>
        <li><a href="http://static.flickr.com/77/199481108_4359e6b971_s.jpg">
            <img src="http://static.flickr.com/77/199481108_4359e6b971_s.jpg" width="75" height="75"
                alt="" /></a></li>
        <li><a href="http://static.flickr.com/58/199481143_3c148d9dd3_s.jpg">
            <img src="http://static.flickr.com/58/199481143_3c148d9dd3_s.jpg" width="75" height="75"
                alt="" /></a></li>
        <li><a href="http://static.flickr.com/72/199481203_ad4cdcf109_s.jpg">
            <img src="http://static.flickr.com/72/199481203_ad4cdcf109_s.jpg" width="75" height="75"
                alt="" /></a></li>
        <li><a href="http://static.flickr.com/58/199481218_264ce20da0_s.jpg">
            <img src="http://static.flickr.com/58/199481218_264ce20da0_s.jpg" width="75" height="75"
                alt="" /></a></li>
        <li><a href="http://static.flickr.com/69/199481255_fdfe885f87_s.jpg">
            <img src="http://static.flickr.com/69/199481255_fdfe885f87_s.jpg" width="75" height="75"
                alt="" /></a></li>
        <li><a href="http://static.flickr.com/60/199480111_87d4cb3e38_s.jpg">
            <img src="http://static.flickr.com/60/199480111_87d4cb3e38_s.jpg" width="75" height="75"
                alt="" /></a></li>
        <li><a href="http://static.flickr.com/70/229228324_08223b70fa_s.jpg">
            <img src="http://static.flickr.com/70/229228324_08223b70fa_s.jpg" width="75" height="75"
                alt="" /></a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
