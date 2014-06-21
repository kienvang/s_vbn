<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TestMenu.aspx.cs" Inherits="Admin_Test_TestMenu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <link rel="stylesheet" type="text/css" href="/css/jquery.slidemenu.css" />
    <!--[if lte IE 7]>
        <style type="text/css">
        html .jqueryslidemenu{height: 1%;} /*Holly Hack for IE7 and below*/
        </style>
    <![endif]-->

    <script type="text/javascript" src="/Admin/js/jquery.js"></script>

    <script type="text/javascript" src="/js/jquery.slidemenu.js"></script>

</head>
<body>
    <form id="form1" runat="server">
    <div>
        <%--<div id="myslidemenu" class="jqueryslidemenu">
            <ul>
                <li><a href="http://www.dynamicdrive.com">Item 1</a></li>
                <li><a href="#">Item 2</a></li>
                <li><a href="#">Folder 1</a>
                    <ul>
                        <li><a href="#">Sub Item 1.1</a></li>
                        <li><a href="#">Sub Item 1.2</a></li>
                        <li><a href="#">Sub Item 1.3</a></li>
                        <li><a href="#">Sub Item 1.4</a></li>
                    </ul>
                </li>
                <li><a href="#">Item 3</a></li>
                <li><a href="#">Folder 2</a>
                    <ul>
                        <li><a href="#">Sub Item 2.1</a></li>
                        <li><a href="#">Folder 2.1</a>
                            <ul>
                                <li><a href="#">Sub Item 2.1.1</a></li>
                                <li><a href="#">Sub Item 2.1.2</a></li>
                                <li><a href="#">Folder 3.1.1</a>
                                    <ul>
                                        <li><a href="#">Sub Item 3.1.1.1</a></li>
                                        <li><a href="#">Sub Item 3.1.1.2</a></li>
                                        <li><a href="#">Sub Item 3.1.1.3</a></li>
                                        <li><a href="#">Sub Item 3.1.1.4</a></li>
                                        <li><a href="#">Sub Item 3.1.1.5</a></li>
                                    </ul>
                                </li>
                                <li><a href="#">Sub Item 2.1.4</a></li>
                            </ul>
                        </li>
                    </ul>
                </li>
                <li><a href="http://www.dynamicdrive.com/style/">Item 4</a></li>
            </ul>
            <br style="clear: left" />
        </div>--%>
        <div class="jqueryslidemenu" id="myslidemenu">
            <ul>
                <li><a href="/" class="menulevel0">Trang Chủ</a> </li>
                <li><a href="/Admin/" class="menulevel0">Quản Trị</a> </li>
                <li><a href="/Admin/Catalog/" class="menulevel0">Danh Mục</a> </li>
                <li><a href="/Admin/Products/" class="menulevel0">Sản Phẩm</a> </li>
                <li><a href="/Admin/Orders/" class="menulevel0">Quản Lý Đơn Đặt Hàng</a> </li>
            </ul>
            <ul>
                <li><a href="#" class="menulevel0">Tools</a>
                    <ul>
                        <li><a href="/Admin/EmailTemplates/">Email Templates</a></li>
                        <li><a href="/Admin/Adverts/">Quảng Cáo</a></li>
                        <li><a href="/Admin/Registers/SuppliersRegister.aspx">Đăng Ký Nhà Cung Cấp</a></li>
                        <li><a href="/Admin/Registers/ProductsRegister.aspx">Đăng Ký Bán Hàng</a></li>
                        <li><a href="/Admin/Videos/">Videos</a></li>
                        <li><a href="/Admin/FeedBack/">Feed Back</a></li>
                        <li><a href="/Admin/Banner/">Quản Lý Banner</a></li>
                        <li><a href="/Admin/New/">Quản Lý Tin Tức</a></li>
                    </ul>
                </li>
            </ul>
            <br style="clear: left;" />
        </div>
    </div>
    </form>
</body>
</html>
