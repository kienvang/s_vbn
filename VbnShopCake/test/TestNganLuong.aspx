<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TestNganLuong.aspx.cs" Inherits="test_TestNganLuong" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table width="100%">
            <tr>
                <td width="120">
                so tien
                </td>
                <td>
                <asp:TextBox ID="txtMoney" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                ma so
                </td>
                <td>
                <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                <asp:Button ID="btnPay" runat="server" Text="Ngan Luong" onclick="btnPay_Click"/>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
