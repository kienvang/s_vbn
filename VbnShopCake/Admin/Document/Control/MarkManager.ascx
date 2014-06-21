<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MarkManager.ascx.cs" Inherits="Admin_Document_Control_MarkManager" %>

<script type="text/javascript">
    $(document).ready(function(){
        $(".numeric").numeric();
    });
</script>
<div class="border">
    <ul class="bullet-admin">
        <li><a href="/Admin/Document/ListDocument.aspx/">Danh sách tài liệu</a></li>
        <li><a href="/Admin/Document/AddEditDocument.aspx">Thêm tài liệu</a></li>
        <li><a href="/Admin/Document/ListGroup.aspx">Quản lý nhóm tài liệu</a></li>
        <li><a href="/Admin/Document/MarkManager.aspx">Quản lý điểm thành viên</a></li>
    </ul>
</div>
<h2>Quản lý điểm thành viên</h2>
<asp:ValidationSummary ID="ValidationSummary1" runat="server" />
<asp:CustomValidator ID="CustomValidator1" runat="server" 
    ErrorMessage="CustomValidator" Display="None"></asp:CustomValidator>
<table class="grid" style="margin-top:10px">
    <thead>
        <tr>
            <th width="30px">
                STT
            </th>
            <th width="100px">
                Tên đăng nhập
            </th>
            <th width="300px">
                Tên thành viên
            </th>
            <th width="50px">
                Điểm
            </th>
        </tr>
    </thead>
    <tbody>
        <asp:Repeater ID="RepMark" runat="server">
            <ItemTemplate>
                <tr>
                    <td align="center">
                        <%# Container.ItemIndex+1%>
                        <asp:HiddenField ID="HidID" runat="server" Value='<%# Eval("Id") %>' />
                    </td>
                    <td>
                        <%# Eval("username")%>
                    </td>
                    <td>
                        <%# Eval("FullName") %>
                    </td>
                    <td align="center">
                        <asp:TextBox ID="txtMark" runat="server" Text='<%# Eval("Mark") %>' style="text-align:center" CssClass="numeric"></asp:TextBox>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </tbody>
</table>

<div style="clear:both;margin-top:5px">
    <asp:Button ID="btEdit" runat="server" Text="Cập nhật" onclick="btEdit_Click"/>
</div>
