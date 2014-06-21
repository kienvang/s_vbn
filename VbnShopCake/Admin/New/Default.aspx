<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="Admin_New_Default" Title="Tin Tức" %>

<%@ Register TagPrefix="avg" Namespace="Avg.Controls" Assembly="SmartPager" %>
<%@ Register Src="Controls/Menu.ascx" TagName="Menu" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" runat="Server">
    <uc1:Menu ID="Menu1" runat="server" />
    <h2>
        Tin tức</h2>
    <div>
        <table border="1" class="grid">
            <tr>
                <th width="30px">
                    STT
                </th>
                <th>
                    Tin tức
                </th>
                <th width="120px">
                    Người tạo
                </th>
                <th width="50px">
                    Hiển thị
                </th>
                <th width="40">
                </th>
                <th width="40">
                </th>
            </tr>
            <asp:Repeater ID="repNews" runat="server" OnItemCommand="repNews_ItemCommand">
                <ItemTemplate>
                    <tr class="row">
                        <td align="center">
                            <%# Container.ItemIndex + 1 %>
                        </td>
                        <td>
                            <%# Eval("Subject") %>
                        </td>
                        <td>
                            <%# Eval("CreatedBy") %>
                        </td>
                        <td align="center">
                            <asp:LinkButton ID="LinkButton1" runat="server" CommandName="isvisible" CommandArgument='<%# Eval("Id") %>'>
                                <img src='<%# bool.Parse(Eval("IsVisible").ToString()) ? "/img/icons/checked.gif" : "/img/icons/unchecked.gif" %>' />
                            </asp:LinkButton>
                        </td>
                        <td align="center">
                            <a href='/Admin/New/AddEdit.aspx?id=<%# Eval("Id") %>'>
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
        </table>
    </div>
    <div>
        <avg:SmartPager ID="smartPager" runat="server" />
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
