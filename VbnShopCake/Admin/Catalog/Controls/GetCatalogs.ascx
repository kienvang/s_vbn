<%@ Control Language="C#" AutoEventWireup="true" CodeFile="GetCatalogs.ascx.cs" Inherits="Admin_Catalog_Controls_GetCatalogs" %>
<%--<asp:UpdatePanel ID="update" runat="server">
    <ContentTemplate>--%>
        <div style="margin: 10px 0">
            <table border="1" class="grid" cellpadding="2" cellspacing="2" style="margin: 5px 0">
                <tr>
                    <td width="120px">
                        <asp:Label ID="lblCatName" runat="server">Chọn danh mục</asp:Label>
                        <asp:RequiredFieldValidator ControlToValidate="txt" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Chọn danh mục" Display="Dynamic" Text="*"></asp:RequiredFieldValidator>
                    </td>
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
            <table border="1" cellpadding="2" cellspacing="2" class="grid">
                <tr class="title">
                    <th width="80px">
                        Mã
                    </th>
                    <th>
                        Tên Loại
                    </th>
                    <th width="100px">
                        Số Lượng
                    </th>
                    <th width="60px">
                    </th>
                </tr>
                <tr id="trHeader" runat="server" class="alpha-1">
                    <td>
                        <div style="padding-left: 2px;">
                            <asp:LinkButton ID="lkPrev" runat="server" CommandName="prev" OnCommand="lkPrev_Command"
                                ValidationGroup="cats"></asp:LinkButton>
                        </div>
                    </td>
                    <td>
                        <asp:Label ID="lblCatName0" runat="server"></asp:Label>
                    </td>
                    <td align="right">
                        <asp:Label ID="lblAmount" runat="server"></asp:Label>
                    </td>
                    <td align="center">
                        <asp:LinkButton ID="lkSelect" runat="server" CommandName="selectfirst" OnCommand="lkSelect_Command"
                            ValidationGroup="cats">
                            Chọn
                        </asp:LinkButton>
                    </td>
                </tr>
                <asp:Repeater ID="repCatalog" runat="server" OnItemCommand="repCatalog_ItemCommand">
                    <ItemTemplate>
                        <tr class="alpha-2">
                            <td>
                                <div style="padding-left: 2px;">
                                    <asp:LinkButton ID="lk" runat="server" CommandArgument='<%# Eval("Id") %>' CommandName="next"
                                        ValidationGroup="cats"><%# Eval("Id") %></asp:LinkButton>
                                </div>
                            </td>
                            <td>
                                <%# Eval("CatalogName") %>
                            </td>
                            <td align="right">
                                <%# Eval("ProductAmount") %>
                            </td>
                            <td align="center">
                                <asp:LinkButton ID="lk0" runat="server" CommandName="select" CommandArgument='<%# Eval("Id") %>'
                                    ValidationGroup="cats">Chọn</asp:LinkButton>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </div>
        <asp:HiddenField ID="hidCatId" runat="server" />
        <asp:HiddenField ID="hidListCats" runat="server" />
        <asp:HiddenField ID="hidIsDirty" runat="server" />
        <asp:TextBox ID="txt" runat="server" CssClass="hide"></asp:TextBox>
    <%--</ContentTemplate>
</asp:UpdatePanel>--%>
