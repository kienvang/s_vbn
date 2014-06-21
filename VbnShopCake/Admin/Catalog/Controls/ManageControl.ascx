<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ManageControl.ascx.cs"
    Inherits="Admin_Catalog_Controls_ManageControl" %>
<div>
    <h2>
        Quản Lý Danh Mục
    </h2>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="error" />
    <asp:CustomValidator ID="validUpdate" runat="server" Display="None"
        OnServerValidate="validUpdate_ServerValidate"></asp:CustomValidator>
    <div id="divUpdate" runat="server" visible="false">
        <table width="100%">
            <tr>
                <td width="120px">
                    Tên danh mục
                </td>
                <td width="5px">
                    :
                </td>
                <td>
                    <asp:TextBox ID="txtCatalogName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ControlToValidate="txtCatalogName" ID="RequiredFieldValidator1"
                        runat="server" ErrorMessage="Nhập tên danh mục" Display="Dynamic">*</asp:RequiredFieldValidator>
                    <asp:CustomValidator ID="valCatalogName" runat="server" ErrorMessage="Trùng tên danh mục"
                        Display="Dynamic" Text="*" OnServerValidate="valCatalogName_ServerValidate"></asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td>
                    Mã danh mục
                </td>
                <td width="5px">
                    :
                </td>
                <td>
                    <asp:TextBox ID="txtCatCode" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ControlToValidate="txtCatCode" ID="RequiredFieldValidator2"
                        runat="server" ErrorMessage="Nhập mã danh mục" Display="Dynamic">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    Danh mục cha
                </td>
                <td width="5px">
                    :
                </td>
                <td>
                    <asp:DropDownList ID="ddlCatalog" runat="server" Width="210px">
                        <asp:ListItem Selected="True" Value="-1">
                    ----------------------------------------------
                        </asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    Tool tip
                </td>
                <td width="5px">
                    :
                </td>
                <td>
                    <asp:TextBox ID="txtToolTip" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Hiển thị
                </td>
                <td width="5px">
                    :
                </td>
                <td>
                    <asp:CheckBox ID="chkIsVisible" runat="server" Text="Thiết lập hiển thị" />
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td colspan="2">
                    <asp:Button ID="btnAdd" runat="server" Text="Thêm" OnClick="btnAdd_Click" />
                    <asp:Button ID="btnUpdate" runat="server" Text="Cập nhật" OnClick="btnUpdate_Click"
                        Visible="false" />
                    <asp:Button ID="btnCancel" runat="server" Text="Hủy cập nhật" ValidationGroup="other"
                        OnClick="btnCancel_Click" />
                    <asp:HiddenField ID="hidId" runat="server" />
                </td>
            </tr>
        </table>
    </div>
</div>
<div style="margin: 10px 0">
    <table border="1" class="grid" style="margin: 5px 0">
        <tr>
            <td>
                <b>Danh mục gốc</b>
                <asp:Repeater ID="repListCat" runat="server">
                    <HeaderTemplate>
                        &nbsp;>&nbsp;
                    </HeaderTemplate>
                    <ItemTemplate>
                        <%# Eval("CatalogName") %>
                    </ItemTemplate>
                    <SeparatorTemplate>
                        &nbsp;>&nbsp;
                    </SeparatorTemplate>
                </asp:Repeater>
            </td>
        </tr>
    </table>
    <table border="1" class="grid">
        <tr class="title">
            <th width="60px">
                Mã
            </th>
            <th>
                Tên Loại
            </th>
            <th width="80px">
                Mã Loại
            </th>
            <th>
                Tooltip
            </th>
            <th width="100px">
                Số Lượng
            </th>
            <th width="70px">
                Hiển Thị
            </th>
            <td width="60px">
                <asp:LinkButton ID="lkAddRoot" ValidationGroup="update" runat="server" CommandName="add"
                    CommandArgument="0" OnCommand="lkAddRoot_Command">Thêm</asp:LinkButton>
            </td>
            <td width="60px">
            </td>
            <td width="60px">
            </td>
        </tr>
        <tr id="trHeader" runat="server" class="alpha-1">
            <td align="center">
                <div style="padding-left: 2px;">
                    <a href='/Admin/Catalog/Default.aspx?catId=<%= _cat.ParentId %>'>
                        <%= _cat.Id %></a>
                </div>
            </td>
            <td>
                <%= _cat.CatalogName %>
            </td>
            <td>
                <%= _cat.CatCode %>
            </td>
            <td>
                <%= _cat.ToolTip %>
            </td>
            <td align="right">
                <%= _cat.ProductAmount %>
            </td>
            <td align="center">
            </td>
            <td align="center">
                <asp:LinkButton ID="lkAdd" ValidationGroup="update" runat="server" CommandName="add"
                    OnCommand="lkAdd_Command">Thêm</asp:LinkButton>
            </td>
            <td align="center">
            </td>
            <td align="center">
            </td>
        </tr>
        <asp:Repeater ID="repCatalog" runat="server" OnItemCommand="repCatalog_ItemCommand">
            <ItemTemplate>
                <tr class="alpha-2">
                    <td align="center">
                        <div style="padding-left: 2px;">
                            <div style="float: left; margin-right: 5px">
                                <asp:ImageButton ValidationGroup="update" ID="ImageButton1" ImageUrl="/img/button/Back.png"
                                    runat="server" CommandName="move-prev" CommandArgument='<%# Eval("Id") %>' OnClientClick="return confirm('Dịch chuyển về cùng cấp cha ?')"
                                    Visible='<%# int.Parse(Eval("ParentId").ToString()) == 0 ? false: true %>' />
                            </div>
                            <div style="float: left">
                                <a href='/Admin/Catalog/Default.aspx?catId=<%# Eval("Id") %>'>
                                    <%# Eval("Id") %>
                                </a>
                            </div>
                            <div style="clear: both">
                            </div>
                        </div>
                    </td>
                    <td>
                        <%# Eval("CatalogName") %>
                    </td>
                    <td>
                        <%# Eval("CatCode") %>
                    </td>
                    <td>
                        <%# Eval("Tooltip") %>
                    </td>
                    <td align="right">
                        <%# Eval("ProductAmount") %>
                    </td>
                    <td align="center">
                        <asp:LinkButton ID="lk5" ValidationGroup="update" runat="server" CommandName="visible"
                            CommandArgument='<%# Eval("Id") %>'>
                            <img src='<%# bool.Parse(Eval("IsVisible").ToString()) ? "/img/icons/checked.gif" : "/img/icons/unchecked.gif" %>' />
                        </asp:LinkButton>
                    </td>
                    <td align="center">
                        <asp:LinkButton ID="lk0" ValidationGroup="update" runat="server" CommandName="add"
                            CommandArgument='<%# Eval("Id") %>'>Thêm</asp:LinkButton>
                    </td>
                    <td align="center">
                        <asp:LinkButton ID="lk1" ValidationGroup="update" runat="server" CommandName="edit"
                            CommandArgument='<%# Eval("Id") %>'>Sửa</asp:LinkButton>
                    </td>
                    <td align="center">
                        <asp:LinkButton ID="lk2" ValidationGroup="update" runat="server" CommandName="del"
                            CommandArgument='<%# Eval("Id") %>' OnClientClick="return confirm('Xác nhận xóa danh mục ?')">Xóa</asp:LinkButton>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
</div>
