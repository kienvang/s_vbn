<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DetailHistory.ascx.cs" Inherits="Admin_Orders_Controls_DetailHistory" %>
<div>
    <table border="1" width="100%" class="grid-sub">
        <tr class="title">
            <th width="40px">
                STT
            </th>
            <th>
                Thao tác
            </th>
            <th width="150px">
                Ngày
            </th>
            <th width="200px">
                Người tạo
            </th>
        </tr>
        <asp:Repeater ID="repHistory" runat="server">
            <ItemTemplate>
                <tr>
                    <td align="center">
                        <%# Container.ItemIndex + 1 %>
                    </td>
                    <td>
                        <%# Eval("ActionName") %>
                    </td>
                    <td align="center">
                        <%# DateTime.Parse(Eval("ActionDate").ToString()).ToString("dd/MM/yyyy - H:mm")%>
                    </td>
                    <td>
                       <%# Eval("ActionBy")%> 
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
</div>