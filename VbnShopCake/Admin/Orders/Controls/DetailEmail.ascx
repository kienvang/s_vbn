<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DetailEmail.ascx.cs" Inherits="Admin_Orders_Controls_DetailEmail" %>
<div>
    <table border="1" width="100%" class="grid-sub">
        <tr class="title">
            <th width="40px">
                STT
            </th>
            <th>
                Tiêu đề
            </th>
            <th width="120px">
                Gởi từ
            </th>
            <th width="120px">
                Gởi đến
            </th>
            <th width="120px">
                Người gởi
            </th>
            <th width="120px">
                Ngày gởi
            </th>
        </tr>
        <asp:Repeater ID="repHistory" runat="server">
            <ItemTemplate>
                <tr>
                    <td align="center">
                        <%# Container.ItemIndex + 1 %>
                    </td>
                    <td>
                        <%# Eval("Subject") %>
                    </td>
                    <td>
                        <%# Eval("EmailFrom")%>
                    </td>
                    <td>
                        <%# Eval("EmailTo")%>
                    </td>
                    <td>
                        <%# Eval("SendBy")%>
                    </td>
                    <td align="center">
                        <%# DateTime.Parse(Eval("ReceiveDated").ToString()).ToString("dd/MM/yyyy - H:mm")%>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
</div>
