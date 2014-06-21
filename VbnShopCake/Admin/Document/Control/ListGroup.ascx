<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ListGroup.ascx.cs" Inherits="Admin_Document_Control_ListGroup" %>
<%@ Register TagPrefix="avg" Namespace="Avg.Controls" Assembly="SmartPager" %>
<div class="border">
    <ul class="bullet-admin">
        <li><a href="/Admin/Document/ListDocument.aspx/">Danh sách tài liệu</a></li>
        <li><a href="/Admin/Document/AddEditDocument.aspx">Thêm tài liệu</a></li>
        <li><a href="/Admin/Document/ListGroup.aspx">Quản lý nhóm tài liệu</a></li>
        <li><a href="/Admin/Document/MarkManager.aspx">Quản lý điểm thành viên</a></li>
    </ul>
</div>
<h2>
    Quản lý nhóm tài liệu</h2>
<asp:ValidationSummary ID="ValidationSummary1" runat="server" />
<asp:CustomValidator ID="CustomValidator1" runat="server" 
    ErrorMessage="CustomValidator" Display="None"></asp:CustomValidator>
<div style="clear:both;margin-top: 10px">
    <div style="float: left">
        <b>Tên nhóm tài liệu</b>
    </div>
    <div style="float: left; margin-left: 5px">
        <asp:TextBox ID="txtGroupName" runat="server" Width="200px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ErrorMessage="Nhập tên nhóm tài liệu" ControlToValidate="txtGroupName" 
            Display="Dynamic">*</asp:RequiredFieldValidator>
    </div>
    <div style="float:left;margin-left:5px">
        <asp:Button ID="btAdd" runat="server" Text="Thêm" onclick="btAdd_Click"/>
        <asp:Button ID="btEdit" runat="server" Text="Sửa" onclick="btEdit_Click" />
    </div>
</div>
<table class="grid" style="margin-top:10px">
    <thead>
        <tr>
            <th width="30px">
                STT
            </th>
            <th width="300px">
                Tên nhóm
            </th>
      
            <th width="40px">
                Sửa
            </th>
            <th width="40px">
                Xóa
            </th>
        </tr>
    </thead>
    <tbody>
        <asp:Repeater ID="RepGroup" runat="server" OnItemCommand="RepGroup_ItemCommand">
            <ItemTemplate>
                <tr>
                    <td align="center">
                        <%# Container.ItemIndex+1%>
                    </td>
                    <td>
                        <%# Eval("GroupName")%>
                    </td>
                   
                    <td align="center">
                        <a href='/Admin/Document/ListGroup.aspx?id=<%# Eval("Id") %>'>
                            <img src="/img/button/Properties.png" title="Sửa" />
                        </a>
                    </td>
                    <td align="center">
                        <asp:LinkButton ID="lkDel" OnClientClick="return confirm('Xác nhận xóa?')" runat="server"
                            CommandName="del" CommandArgument='<%# Eval("Id") %>' ValidationGroup="cancel">
                                <img src="/img/button/exit.png" title="Xóa" />
                        </asp:LinkButton>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </tbody>
</table>
<avg:SmartPager ID="smartPager" runat="server" />