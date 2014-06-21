<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TestPDF.aspx.cs" Inherits="test_TestPDF" %>

<%@ Register Src="../Modules/Payment/Controls/SingleOrderDetail.ascx" TagName="SingleOrderDetail"
    TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Button" onclick="Button2_Click" />
        <uc1:SingleOrderDetail ID="SingleOrderDetail1" runat="server" Visible="false" />
    </div>
    </form>
</body>
</html>
