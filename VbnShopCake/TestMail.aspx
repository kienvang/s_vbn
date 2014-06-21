<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TestMail.aspx.cs" Inherits="TestMail" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Email <asp:TextBox ID="txtEmail" runat="server"> </asp:TextBox><br />
    Subject <asp:TextBox ID="txtSubject" runat="server"> </asp:TextBox><br />
    Body <asp:TextBox ID="txtBody" runat="server" TextMode="MultiLine" Width="300px" Height="250px"> </asp:TextBox><br />
    <asp:Button ID="btn" runat="server" Text="demo" onclick="btn_Click" />
    </div>
    </form>
</body>
</html>
