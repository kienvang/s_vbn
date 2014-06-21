<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ListDocument.ascx.cs"
    Inherits="Admin_Document_Control_ListDocument" %>
<%@ Register TagPrefix="avg" Namespace="Avg.Controls" Assembly="SmartPager" %>
<%@ Register src="DocumentMenu.ascx" tagname="DocumentMenu" tagprefix="uc1" %>
<script src="/Admin/Document/js/Document.js" type="text/javascript"></script>

<style>
    .style
    {
        float: left;
        margin-right: 10px;
        font-weight: bold;
    }
</style>

<uc1:DocumentMenu ID="DocumentMenu1" runat="server" />
<h2>
    Danh sách tài liệu</h2>
<table class="grid">
    <thead>
        <tr>
            <th width="30px">
                STT
            </th>
            <th width="150px">
                Tên tài liệu
            </th>
            <th width="100px">
                Nhóm tài liệu
            </th>
            <th width="300px">
                Mô tả
            </th>
            <th width="70px">Dung lượng (MB)</th>
            <th width="50px">
                Hiển thị
            </th>
            <th width="50px">
                Hiện thị trailer
            </th>
            <th width="30px">
                Sửa
            </th>
            <th width="30px">
                Xóa
            </th>
        </tr>
    </thead>
    <tbody>
        <asp:Repeater ID="RepDocument" runat="server" 
            onitemcommand="RepDocument_ItemCommand">
            <ItemTemplate>
                <tr>
                    <td align="center">
                        <%# Container.ItemIndex+1%>
                    </td>
                    <td>
                        <%# Eval("DocumentName")%>
                    </td>
                    <td>
                        <%# Eval("GroupName") %>
                    </td>
                    <td>
                        <%# Library.Tools.FString.SplitString(Eval("Description").ToString(),20) %>...<a
                    href='<%# Modules.Document.UrlBuilder.DocumentDetail(int.Parse(Eval("IntId").ToString()),Eval("TextId").ToString())%>'>
                    chi tiết</a>
                    </td>
                    <td>
                        <%# Eval("FileSize") %> 
                    </td>
                    <td align="center">
                        <asp:CheckBox ID="checkId" CssClass="CheckId" runat="server" Checked='<%# Eval("IsVisible") %>' docId='<%# Eval("Id") %>'/>
                    </td>
                    <td align="center">
                        <asp:CheckBox ID="checkShow" CssClass="CheckShow" runat="server" Checked='<%# Eval("ShowVideo") %>' docId='<%# Eval("Id") %>'/>
                    </td>
                    <td align="center">
                        <a href='/Admin/Document/EditDocument.aspx?id=<%# Eval("Id") %>'>
                            <img src="/img/button/Properties.png" />
                        </a>
                    </td>
                    <td align="center">
                        <asp:LinkButton ID="lkDel" OnClientClick="return confirm('Xác nhận xóa?')" runat="server"
                            CommandName="del" CommandArgument='<%# Eval("Id") %>'>
                                <img src="/img/button/exit.png" />
                        </asp:LinkButton>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </tbody>
</table>
<avg:SmartPager ID="smartPager" runat="server" />