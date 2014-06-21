<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="Admin_Feedback_Default" Title="Feed Back" %>

<%@ Register TagPrefix="avg" Namespace="Avg.Controls" Assembly="SmartPager" %>
<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" runat="Server">
    <h2>
        Danh sách khách hàng liên hệ
    </h2>
    <div style="margin: 10px 0">
        <table class="grid" border="1">
            <tr class="title">
                <th width="40px">
                    STT
                </th>
                <th>
                    Nội dung
                </th>
                <th width="150px">
                    Tên khách hàng
                </th>
                <th width="80px">
                    Email
                </th>
                <th width="80px">
                    Ngày đăng
                </th>
                <th width="120px">
                    User
                </th>
                <th width="40px">
                    Duyệt
                </th>
            </tr>
            <asp:Repeater ID="repFeedBack" runat="server" 
                onitemcommand="repFeedBack_ItemCommand">
                <ItemTemplate>
                    <tr class="row">
                        <td align="center">
                            <%# Container.ItemIndex + 1 %>
                        </td>
                        <td>
                            <div style="height: 100px; overflow: auto; margin: 5px 0">
                                <%# Eval("Message") %>
                            </div>
                        </td>
                        <td>
                            <%# Eval("Sender") %>
                        </td>
                        <td>
                            <%# Eval("SenderEmail") %>
                        </td>
                        <td align="center">
                            <%# DateTime.Parse(Eval("SendDate").ToString()).ToString("dd/MM/yyyy")%>
                        </td>
                        <td>
                            <%# Eval("UserName")%>
                        </td>
                        <td align="center">
                            <asp:LinkButton ID="lk" runat="server" CommandName="approve" CommandArgument='<%# Eval("Id") %>'>
                                <asp:CheckBox ID="chk" runat="server" Checked='<%# Eval("Approved") %>' />
                            </asp:LinkButton>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
    </div>
    <avg:SmartPager ID="smartPager" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
