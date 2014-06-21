<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Payment.ascx.cs" Inherits="Admin_Payment_Control_Payment" %>
<h2>
    Các phương thức thanh toán</h2>
<table class="grid">
    <tr>
        <th width="30">
        </th>
        <th width="180px">
            Tên phương thức
        </th>
        <th>
            Link hướng dẫn
        </th>
    </tr>
    <asp:Repeater ID="rep" runat="server">
        <ItemTemplate>
            <tr class="row">
                <td align="center">
                    <%# Container.ItemIndex + 1 %>
                </td>
                <td>
                    <%# Eval("PayName") %>
                    <asp:HiddenField ID="hidId" runat="server" Value='<%# Eval("PayId") %>' />
                </td>
                <td align="center">
                    <asp:TextBox ID="txtLink" runat="server" Width="99%" Text='<%# Eval("Link") %>'></asp:TextBox>
                </td>
            </tr>
        </ItemTemplate>
    </asp:Repeater>
</table>
<div style="margin-top: 10px">
    <asp:Button ID="btnCapNhat" runat="server" Text="Cập nhật" OnClick="btnCapNhat_Click" />
</div>
