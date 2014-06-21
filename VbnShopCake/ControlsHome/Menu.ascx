<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Menu.ascx.cs" Inherits="ControlsHome_Menu" %>
<%@ Import Namespace="Library.Tools" %>

<script src="/js/jquery.urlEncode.js" type="text/javascript"></script>

<script src="/js/jquery.watermarkinput.js" type="text/javascript"></script>

<div class="jqueryslidemenu" id="myslidemenu">
    <ul>
        <li><a href="http://www.vbn.vn" class="menulevel0" title="Trang chủ">Trang chủ</a></li>
        <li><a href="<%= UrlBuilder.RootUrl %>" class="menulevel0" title="Sản phẩm">Sản phẩm</a></li>
        <li><a href="<%= Modules.Videos.UrlBuilder.Videos() %>" class="menulevel0" title="Videos">
            Videos</a></li>
        <li><a href="<%= Modules.UrlBuilder.ProductRegister() %>" class="menulevel0" title="Đăng ký bán hàng">
            Đăng ký bán hàng</a></li>
        <li><a href="<%= Modules.UrlBuilder.SupplierRegister() %>" class="menulevel0" title="Đăng ký bán hàng">
            Đăng ký nhà cung cấp</a></li>
        <li><a href="<%= Modules.Document.UrlBuilder.ListDocument() %>" title="Tải tài liệu"
            class="menulevel0">Tài liệu </a>
            <ul>
                <% if (IsSignIn())
                   { %>
                <li><a href='<%= Modules.Document.UrlBuilder.DownLoadHistory() %>'>Lịch sử tải tài liệu</a></li>
                <li><a href='<%= Modules.Document.UrlBuilder.MarkAddHistory() %>'>Lịch sử nạp điểm</a></li>
                <li><a href='/Modules/Document/Mark.aspx'>Nạp điểm tải tài liệu</a></li>
                <%} %>
                <li><a href='/tai-lieu/huong-dan-nap-diem.html'>Hướng dẫn nạp điểm</a></li>
            </ul>
        </li>
        <li><a href="<%= Modules.UrlBuilder.Contact() %>" title="Liên hệ">Giới thiệu</a></li>
        <li class="last"><a href="<%= Modules.UrlBuilder.FeedBack() %>" title="Liên hệ">Liên
            hệ</a></li>
    </ul>
</div>
<%--<fieldset>
    <input type="text" name="search" id="search" />
    <input type="image" src="/images/btn_search.gif" name="btnSearch" id="btnSearch"
        class="btnSearch" />
    
</fieldset>--%>

<script type="text/javascript">
    $(document).ready(function(){
        /*
        $("input.btnSearch").click(function(){
            var search = $("#search").val();
            
            if (search != "")
            {
                //alert($.URLEncode(search));
                
                var jsonStr = "{val:'" + search + "'}";
                    
                $.ajax({
		            type: "POST",
		            url: "/Admin/Webservices/WebService.asmx/Encoding",
		            contentType: "application/json; charset=utf-8",
		            dataType: "json",
		            data: jsonStr,
		            success: function(msg) {
		                window.location = msg.d;
			            return true;
		            },
		            error: function() {
		                return false;
		            }
	            });
            }
            
            return false;
        });
        */
    });
    
</script>

