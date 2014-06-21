<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="test_Default" %>

<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
<%@ Register Src="../Admin/Catalog/Controls/Catalogs.ascx" TagName="Catalogs" TagPrefix="uc1" %>
<%@ Register Src="../Modules/Payment/Controls/SingleOrderDetail.ascx" TagName="SingleOrderDetail"
    TagPrefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <link href="/css/style.css" rel="stylesheet" type="text/css" />

    <script src="/js/jquery.js" type="text/javascript"></script>

    <%--
    <link href="/css/screen.css" rel="stylesheet" type="text/css" />

    <script src="/js/jcarousel/jquery.jcarousel.js" type="text/javascript"></script>

    <link href="/css/jcarousel/jquery.jcarousel.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" type="text/css" href="/css/jcarousel/skins/tango/skin.css" />--%>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table width="100%" border="0" style="font-family: Arial; font-size: 13px">
            <tr height="24px">
                <td width="120px">
                    <b>Tên khách hàng</b>
                </td>
                <td>
                    [CustomerName/]
                </td>
            </tr>
            <tr height="24px">
                <td>
                    <b>Địa chỉ mail</b>
                </td>
                <td>
                    [CustomerEmail/]
                </td>
            </tr>
            <tr height="24px">
                <td>
                    <b>Số điện thoại</b>
                </td>
                <td>
                    [CustomerPhone/]
                </td>
            </tr>
            <tr height="24px">
                <td>
                    <b>Địa chỉ</b>
                </td>
                <td>
                    [CustomerAddress/]
                </td>
            </tr>
        </table>
        <uc2:SingleOrderDetail ID="SingleOrderDetail1" runat="server" Visible="false" />
    </div>
    &#133;
    </form>
</body>
</html>
