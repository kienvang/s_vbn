<%@ Page Language="C#" AutoEventWireup="true" CodeFile="slider.aspx.cs" Inherits="test_slider" %>

<%@ Register Src="../Modules/Adverts/Controls/AdvertMulti.ascx" TagName="AdvertMulti"
    TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <link href="/css/s3Slider.css" rel="stylesheet" type="text/css" media="screen" />

    <script src="/js/jquery.js" type="text/javascript"></script>

    <script src="/js/s3Slider.js" type="text/javascript"></script>

    <script type="text/javascript">
    $(document).ready(function() {
        $('#slider').s3Slider({
            timeOut: 3000
        });
        
    });
    </script>

</head>
<body>
    <form id="form1" runat="server">
    <div id="abc" runat="server" visible="false">
        <div id="slider">
            <ul id="sliderContent">
                <li class="sliderImage"><a href="">
                    <img src="/images/410/1.jpg" alt="1" /></a> <span></span></li>
                <li class="sliderImage"><a href="">
                    <img src="/images/410/2.jpg" alt="2" /></a> <span></span></li>
                <li class="sliderImage">
                    <img src="/images/410/3.jpg" alt="3" />
                    <span class="bottom"></span></li>
                <li class="sliderImage">
                    <img src="/images/410/4.jpg" alt="4" />
                    <span class="bottom"></span></li>
                <li class="sliderImage">
                    <img src="/images/410/5.jpg" alt="5" />
                    <span class="top"></span></li>
                <div class="clear sliderImage">
                </div>
            </ul>
        </div>
    </div>
    <uc1:AdvertMulti ID="AdvertMulti1" runat="server" AdvertPositionId="f22e8afb-c762-4256-bb5f-43f9a63fc1f1"
        FHeight="120" FWidth="120" Visible="true" />
    <uc1:AdvertMulti ID="AdvertMulti2" runat="server" AdvertPositionId="f22e8afb-c762-4256-bb5f-43f9a63fc1f1"
        FHeight="120" FWidth="120" Visible="true" />
    </form>
</body>
</html>
