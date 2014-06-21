<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DownLoadManager.ascx.cs"
    Inherits="Admin_Document_Control_DownLoadManager" %>
    <h2>Quản lý lịch sử download tài liệu của người dùng</h2>
<style>
    .style
    {
        float: left;
        margin-right: 10px;
        font-weight: bold;
        margin-bottom: 5px;
    }
</style>
<div class="style">
    Nhập Username</div>
<div class="style">
    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox></div>
<div class="style">
    <asp:Button ID="btSearch" runat="server" Text="Tìm" OnClick="btSearch_Click" />
</div>
<div style="clear:both">
    <table class="grid">
        <tr>
            <th width="30px">
                STT
            </th>
            <th width="100px">
                Ngày tải
            </th>
            <th width="200px">
                Tài liệu
            </th>
            <th width="100px">
                Điểm cần
            </th>
            <th width="100px">
                Điểm trước khi tải
            </th>
            <th width="100px">
                Điểm sau khi tải
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
</div>
