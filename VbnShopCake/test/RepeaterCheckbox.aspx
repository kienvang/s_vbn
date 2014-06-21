<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RepeaterCheckbox.aspx.cs"
    Inherits="test_RepeaterCheckbox" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table width="200" border="1">
            <tr>
                <td>
                    a
                </td>
                <td>
                    b
                </td>
                <td>
                    c
                </td>
            </tr>
            <asp:Repeater ID="rep" runat="server">
                <ItemTemplate>
                    <tr>
                        <td>
                            &nbsp;<asp:LinkButton ID="lk" runat="server">testS</asp:LinkButton>
                        </td>
                        <td>
                            &nbsp;<asp:LinkButton ID="LinkButton1" runat="server" ><asp:CheckBox ID="chk" runat="server" /></asp:LinkButton>
                        </td>
                        <td>
                            &nbsp;
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
    </div>
    </form>
</body>
</html>
