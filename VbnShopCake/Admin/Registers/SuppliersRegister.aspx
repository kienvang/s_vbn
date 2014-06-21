<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true"
    CodeFile="SuppliersRegister.aspx.cs" Inherits="Admin_Registers_SuppliersRegister"
    Title="Đăng Ký Nhà Cung Cấp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" runat="Server">
    <h2>
        Danh Sách Đăng Ký Nhà Cung Cấp</h2>
    <div>
        <table border="1" class="grid">
            <tr>
                <th width="30px">
                    STT
                </th>
                <th>
                    Tên
                </th>
                <th width="120px">
                    Loại
                </th>
                <th width="80px">
                    Email
                </th>
                <th width="60px">
                    Điện thoại
                </th>
                <th width="180px">
                    Địa chỉ
                </th>
                <th width="120px">
                    Người đăng ký
                </th>
                <th width="70px">
                    Ngày đăng ký
                </th>
                <th width="40">
                </th>
            </tr>
            <asp:Repeater ID="repSupplier" runat="server" OnItemCommand="repSupplier_ItemCommand">
                <ItemTemplate>
                    <tr class="row">
                        <td align="center">
                            <%# Container.ItemIndex + 1 %>
                        </td>
                        <td>
                            <%# Eval("SupplierName") %>
                        </td>
                        <td>
                            <%# Eval("TypeName") %>
                        </td>
                        <td>
                            <%# Eval("Email") %>
                        </td>
                        <td>
                            <%# Eval("Phone") %>
                        </td>
                        <td>
                            <%# Eval("Address") %>
                        </td>
                        <td>
                            <%# Eval("UserName") %>
                        </td>
                        <td align="center">
                            <%# Convert.ToDateTime(Eval("CreatedDate")).ToString("dd/MM/yyyy")%>
                        </td>
                        <td align="center">
                            <asp:LinkButton ID="lkDel" OnClientClick="return confirm('Xác nhận xóa?')" runat="server"
                                CommandName="del" CommandArgument='<%# Eval("Id") %>' >
                                <img src="/img/button/exit.png" />
                            </asp:LinkButton>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
