<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DownLoadHistory.ascx.cs"
    Inherits="Modules_Document_Control_DownLoadHistory" %>
    <%@ Register TagPrefix="avg" Namespace="Avg.Controls" Assembly="SmartPager" %>
<h2>Lịch sử tải tài liệu</h2>
<table border="1" class="cart">
    <tr class="title">
        <td width="30px">
            STT
        </td>
        <td width="150px">
            Ngày tải
        </td>
        <td width="200px">
            Tài liệu
        </td>
        <td width="60px">
            Điểm cần
        </td>
        <td width="120px">
            Điểm trước khi tải
        </td>
        <td width="100px">
            Điểm sau khi tải
        </td>
    </tr>
    <tbody>
        <asp:Repeater ID="RepHistory" runat="server">
            <ItemTemplate>
                <tr>
                    <td align="center">
                        <%# Container.ItemIndex+1%>
                    </td>
                    <td align="center">
                        <%# Eval("Date") %>
                    </td>
                    <td>
                        <%# Eval("DocumentName") %>
                    </td>
                    <td align="center">
                        <%# Eval("Mark") %>
                    </td>
                    <td align="center">
                        <%# Eval("MarkBeforeDown") %>
                    </td>
                    <td align="center">
                        <%# Eval("MarkAfterDown") %>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </tbody>
</table>
<avg:SmartPager ID="smartPager" runat="server" />