<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true"
    CodeFile="ProductsRegister.aspx.cs" Inherits="Admin_Registers_ProductsRegister"
    Title="Đăng Ký Bán Hàng" %>
<%@ Import Namespace="Library.Tools" %>
<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" runat="Server">
    <h2>
        Danh Sách Đăng Ký Bán Hàng</h2>
    <div>
        <table border="1" class="grid">
            <tr>
                <th width="30px">
                    STT
                </th>
                <th>
                    Tên sản phẩm
                </th>
                <th width="120px">
                    Giá bán cho VBN
                </th>
                <th width="120px">
                    Giá đề nghị bán
                </th>
                <th width="160px">
                    Người bán
                </th>
                <th width="70px">
                    Ngày đăng
                </th>
                <th width="70px">
                    Tình trạng
                </th>
                <th width="40">
                </th>
                <th width="40">
                </th>
            </tr>
            <asp:Repeater ID="repProducts" runat="server" 
                onitemcommand="repProducts_ItemCommand">
                <ItemTemplate>
                    <tr class="row">
                        <td align="center">
                            <%# Container.ItemIndex + 1 %>
                        </td>
                        <td>
                        <a href='/Admin/Registers/ProductRegisterDetail.aspx?id=<%# Eval("Id") %>'>
                            <%# Eval("ProductName") %></a>
                        </td>
                        <td align="right">
                            <%# FNumber.FormatNumber( Eval("PriceBuy")) %>
                        </td>
                        <td align="right">
                            <%# FNumber.FormatNumber( Eval("PriceSell")) %>
                        </td>
                        <td>
                            <%# Eval("UserName") %>
                        </td>
                        <td align="center">
                            <%# Convert.ToDateTime(Eval("CreatedDate")).ToString("dd/MM/yyyy")%>
                        </td>
                        <td align="center">
                            <img src='/img/button/<%# Convert.ToBoolean(Eval("Approved")) ? "checked.png" : "unchecked.gif" %>' /> 
                        </td>
                        <td align="center">
                        <a href='/Admin/Products/AddEditProduct.aspx?id=<%# Eval("Id") %>'>
                        <img src='/img/button/add.png' />
                        </a>
                        </td>
                        <td align="center">
                            <asp:LinkButton ID="lkDel" OnClientClick="return confirm('Xác nhận xóa?')" runat="server" Visible='<%# !bool.Parse(Eval("Approved").ToString()) %>'
                                CommandName="del" CommandArgument='<%# Eval("Id") %>'>
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
