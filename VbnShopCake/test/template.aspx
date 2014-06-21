<%@ Page Language="C#" AutoEventWireup="true" CodeFile="template.aspx.cs" Inherits="test_template" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="0" width="100%" style="font-family: Arial; font-size: 13px;">
            <tbody>
                <tr height="24px">
                    <td colspan="4">
                        <b>Mã hóa đơn : </b>[OrderCode/]
                    </td>
                </tr>
                <tr height="24px">
                    <td colspan="4">
                        <b>Ngày giao hàng : </b>[ShipDate/]
                    </td>
                </tr>
                <tr height="10px">
                    <td colspan="4">&nbsp;
                    </td>
                </tr>
                <tr height="24px">
                    <td colspan="2">
                        <b>Thông tin khách hàng</b>
                    </td>
                    <td colspan="2">
                        <b>Thông tin giao hàng</b>
                    </td>
                </tr>
                <tr height="24px">
                    <td width="80px">
                        <b>Họ tên</b>
                    </td>
                    <td>
                        [CustomerName/]
                    </td>
                    <td width="80px">
                        <b>Họ tên</b>
                    </td>
                    <td>
                        [ShipCustomerName/]
                    </td>
                </tr>
                <tr height="24px">
                    <td>
                        <b>Email</b>
                    </td>
                    <td>
                        [CustomerEmail/]
                    </td>
                    <td>
                        <b>Email</b>
                    </td>
                    <td>
                        [ShipCustomerEmail/]
                    </td>
                </tr>
                <tr height="24px">
                    <td>
                        <b>Điện thoại</b>
                    </td>
                    <td>
                        [CustomerPhone/]
                    </td>
                    <td>
                        <b>Điện thoại</b>
                    </td>
                    <td>
                        [ShipCustomerPhone/]
                    </td>
                </tr>
                <tr height="24px">
                    <td>
                        <b>Địa chỉ</b>
                    </td>
                    <td>
                        [CustomerAddress/]
                    </td>
                    <td>
                        <b>Địa chỉ</b>
                    </td>
                    <td>
                        [ShipCustomerAddress/]
                    </td>
                </tr>
                <tr height="24px">
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        <b>Ghi chú</b>
                    </td>
                    <td>
                        [ShipNote/]
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
    </form>
</body>
</html>
