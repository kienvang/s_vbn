<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Position.aspx.cs" Inherits="Admin_Webservices_Position" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="div" runat="server">
        <select id="selPos" style="width: 250px">
            <option value="">Không thiết lập </option>
            <asp:Repeater ID="repPosition" runat="server">
                <ItemTemplate>
                    <option value="<%# Eval("Id") %>" <%# Request["typeid"] == Eval("Id").ToString() ? "selected='selected'" : ""%>>
                        <%# Eval("TypeName") %>
                    </option>
                </ItemTemplate>
            </asp:Repeater>
        </select>
        <div class="viewItem">
            <table width="98%">
                <tr>
                    <td width="120px">
                        <b>Mã vị trí</b>
                    </td>
                    <td>
                        <asp:Label ID="lblPosId" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>Tên vị trí</b>
                    </td>
                    <td>
                        <asp:Label ID="lblTypeName" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>Rộng</b>
                    </td>
                    <td>
                        <asp:Label ID="lblWidth" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>Cao</b>
                    </td>
                    <td>
                        <asp:Label ID="lblHeight" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
        <input type="hidden" value='<%= Request["id"] %>' id="posid" />
        <input type="hidden" value='<%= Request["typeid"] %>' id="typeid" />
    </div>
    </form>
</body>
</html>
