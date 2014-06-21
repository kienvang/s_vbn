<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ListProducts.ascx.cs"
    Inherits="Admin_Products_Controls_ListProducts" %>
<%@ Import Namespace="Library.Tools" %>
<div>
    <table width="100%">
        <tr>
            <td width="120px">
                <b>Tên sản phẩm</b>
            </td>
            <td>
                <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <b>Loại sản phẩm</b>
            </td>
            <td>
                <asp:TextBox ID="txtCatalogName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <b>Giá</b>
            </td>
            <td>
                <asp:DropDownList ID="ddlPrice" runat="server" Width="195px">
                    <asp:ListItem Value="0" Selected="True">-------------- Chọn giá --------------</asp:ListItem>
                    <asp:ListItem Value="1">Dưới 100 ngàn</asp:ListItem>
                    <asp:ListItem Value="1-1.5">Từ 100 đến 150 ngàn</asp:ListItem>
                    <asp:ListItem Value="1.5-2">Từ 150 đến 200 ngàn</asp:ListItem>
                    <asp:ListItem Value="2-2.5">Từ 200 đến 250 ngàn</asp:ListItem>
                    <asp:ListItem Value="2.5-3">Từ 250 đến 300 ngàn</asp:ListItem>
                    <asp:ListItem Value="3-4">Từ 300 đến 400 ngàn</asp:ListItem>
                    <asp:ListItem Value="4-10">Từ 400 ngàn đến 1 triệu</asp:ListItem>
                    <asp:ListItem Value="10-30">Từ 1 đến 3 triệu</asp:ListItem>
                    <asp:ListItem Value="30-50">Từ 3 đến 5 triệu</asp:ListItem>
                    <asp:ListItem Value="50-100">Từ 5 đến 10 triệu</asp:ListItem>
                    <asp:ListItem Value="100">Trên 10 triệu</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <b></b>
            </td>
            <td>
            <asp:Button ID="btnSearch" Text="Tìm" runat="server" onclick="btnSearch_Click" />
            </td>
        </tr>
        
    </table>
</div>
<div>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="true" AllowSorting="true"
        CssClass="grid" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand"
        OnPageIndexChanging="GridView1_PageIndexChanging">
        <Columns>
            <asp:TemplateField HeaderText="STT" HeaderStyle-Width="25px" ItemStyle-HorizontalAlign="Center">
                <ItemTemplate>
                    <%# Container.DataItemIndex + 1 %>
                </ItemTemplate>
                <HeaderStyle Width="25px" HorizontalAlign="Center"></HeaderStyle>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Mã SP" HeaderStyle-Width="80px">
                <ItemTemplate>
                    <%# Eval("ProductCode") %>
                </ItemTemplate>
                <HeaderStyle Width="80px"></HeaderStyle>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Tên Sản Phẩm">
                <ItemTemplate>
                    <a href='/Admin/Products/Detail.aspx?id=<%# Eval("Id") %>'>
                        <%# Eval("ProductName") %>
                    </a>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Giá" HeaderStyle-Width="60px">
                <HeaderStyle Width="60px"></HeaderStyle>
                <ItemStyle HorizontalAlign="Right" />
                <ItemTemplate>
                    <div>
                        <%# FNumber.FormatNumber(Eval("Price"))%>
                    </div>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Số Lượng" HeaderStyle-Width="40px">
                <HeaderStyle Width="40px"></HeaderStyle>
                <ItemStyle HorizontalAlign="Right" />
                <ItemTemplate>
                    <div>
                        <%# Eval("Amount") %>
                    </div>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Danh Mục" HeaderStyle-Width="120px">
                <ItemTemplate>
                    <a>
                        <%# Eval("CatalogName") %>
                    </a>
                </ItemTemplate>
                <HeaderStyle Width="120px"></HeaderStyle>
            </asp:TemplateField>
           
            <asp:TemplateField HeaderText="Ngày tạo" HeaderStyle-Width="50px">
                <ItemTemplate>
                    <%# DateTime.Parse(Eval("CreatedDate").ToString()).ToString("dd/MM/yy") %>
                </ItemTemplate>
                <HeaderStyle Width="50px"></HeaderStyle>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Hiển thị" HeaderStyle-Width="40px">
                <HeaderStyle Width="30px"></HeaderStyle>
                <ItemStyle HorizontalAlign="Center" />
                <ItemTemplate>
                    <asp:LinkButton ID="link0" runat="server" CommandName="isvisible" CommandArgument='<%# Eval("Id") %>'>
                        <img src='<%# bool.Parse(Eval("IsVisible").ToString()) ? "/img/icons/checked.gif" : "/img/icons/unchecked.gif" %>' />
                    </asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="" HeaderStyle-Width="30px">
                <HeaderStyle Width="30px"></HeaderStyle>
                <ItemStyle HorizontalAlign="Center" />
                <ItemTemplate>
                    <a href='/Admin/Products/EditProduct.aspx?Id=<%# Eval("Id") %>'>
                        <img src="/img/button/properties.png" />
                    </a>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="" HeaderStyle-Width="30px">
                <HeaderStyle Width="30px"></HeaderStyle>
                <ItemStyle HorizontalAlign="Center" />
                <ItemTemplate>
                    <asp:LinkButton OnClientClick="return confirm('Xác nhận xóa ?')" ID="link" runat="server"
                        CommandName="del" CommandArgument='<%# Eval("Id") %>'>
                <img src="/img/button/exit.png" />
                    </asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <HeaderStyle CssClass="title" />
        <RowStyle CssClass="row alpha-2" />
    </asp:GridView>
</div>
