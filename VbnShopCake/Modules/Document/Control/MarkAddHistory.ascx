<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MarkAddHistory.ascx.cs" Inherits="Modules_Document_Control_MarkAddHistory" %>
 <%@ Register TagPrefix="avg" Namespace="Avg.Controls" Assembly="SmartPager" %>
 <h2>Lịch sử nạp điểm</h2>
 <div style="clear:both;margin-bottom:5px">
    Số điểm hiện tại : <asp:Label ID="lbCurrentMark" runat="server" ForeColor="Red"></asp:Label>
 </div>
 
 
<table border="1" class="cart">
    <tr class="title">
        <td width="30px">
            STT
        </td>
        <td width="100px">
            Ngày nạp
        </td>
        <td width="100px">
            Số điểm 
        </td>
        <td width="100px">
            Điểm trước khi nạp thẻ
        </td>
        <td width="100px">
            Điểm sau khi nạp thẻ
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
<avg:SmartPager ID="smartPager" runat="server" />
