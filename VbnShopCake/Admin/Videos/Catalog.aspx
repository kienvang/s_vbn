<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true"
    CodeFile="Catalog.aspx.cs" Inherits="Admin_Videos_Catalog" Title="Untitled Page" %>

<%@ Register Src="Controls/Menu.ascx" TagName="Menu" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" runat="Server">
    <uc1:Menu ID="Menu1" runat="server" />
    <h2>
        Danh mục video</h2>
    <table border="1" class="grid">
        <tr>
            <th width="30px">
            </th>
            <th>
                Tên loại video
            </th>
            <th width="40px">
            </th>
            <th width="40px">
            </th>
        </tr>
        <asp:Repeater ID="repCat" runat="server" OnItemCommand="repCat_ItemCommand">
            <ItemTemplate>
                <tr>
                    <td align="center">
                        <%# Container.ItemIndex + 1 %>
                    </td>
                    <td>
                        <%# Eval("CatName") %>
                    </td>
                    <td align="center">
                        <a href='/Admin/Videos/AddEditCatalog.aspx?id=<%# Eval("Id") %>'>
                            <img src="/img/button/properties.png" />
                        </a>
                    </td>
                    <td align="center">
                        <asp:LinkButton OnClientClick="return confirm('Xác nhận xóa ?')" ID="link" runat="server"
                            CommandName="del" CommandArgument='<%# Eval("Id") %>'>
                                <img src="/img/button/exit.png" />
                        </asp:LinkButton>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
