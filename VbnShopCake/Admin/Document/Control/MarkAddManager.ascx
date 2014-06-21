<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MarkAddManager.ascx.cs" Inherits="Admin_Document_Control_MarkAddManager" %>

<style>
    .style
    {
        float: left;
        margin-right: 10px;
        font-weight: bold;
        margin-bottom: 5px;
    }
</style>
<h2> Quản lý lịch sử nạp điểm của người dùng</h2>
<div class="style">
    Nhập Username</div>
<div class="style">
    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox></div>
<div class="style">
    <asp:Button ID="btSearch" runat="server" Text="Tìm" onclick="btSearch_Click" />
</div>
<div style="clear: both">
    <table class="grid">
        <tr>
            <th width="30px">
                STT
            </th>
            <th width="100px">
                Ngày nạp
            </th>
            <th width="100px">
                Số điểm
            </th>
            <th width="100px">
                Điểm trước khi nạp thẻ
            </th>
            <th width="100px">
                Điểm sau khi nạp thẻ
            </th>
        </tr>
        <tbody>
            <asp:Repeater ID="RepHistory" runat="server">
                <ItemTemplate>
                    <tr>
                        <td align="center">
                            <%# Container.ItemIndex+1%>
                        </td>
                        <td align="center">
                            <%# Eval("Date")%>
                        </td>
                        <td align="center">
                            <%# Eval("Mark") %>
                        </td>
                        <td align="center">
                            <%# Eval("MarkBeforeAdd") %>
                        </td>
                        <td align="center">
                            <%# Eval("MarkAfterAdd") %>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</div>