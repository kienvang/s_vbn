<%@ Control Language="C#" AutoEventWireup="true" CodeFile="VisibleInHome.ascx.cs"
    Inherits="Admin_Catalog_Controls_VisibleInHome" %>
<script src="/js/jquery.numeric.js" type="text/javascript"></script>
<div>
    <table border="1" class="grid">
        <tr class="title">
            <th width="40px">
                STT
            </th>
            <th width="50px">
                Mã
            </th>
            <th>
                Tên Danh Mục
            </th>
            <th width="150px">
                Hiển Thị
            </th>
            <th width="150px">
                Thứ Tự
            </th>
            <th width="200px">
                Sắp Xếp
            </th>
            <th width="50px">
            </th>
        </tr>
        <asp:Repeater ID="repCatalog" runat="server" 
            onitemcommand="repCatalog_ItemCommand">
            <ItemTemplate>
                <tr class="row">
                    <td align="center">
                        <%# Container.ItemIndex + 1 %>
                    </td>
                    <td>
                        <%# Eval("Id") %>
                    </td>
                    <td>
                        <%# Eval("CatalogName") %>
                    </td>
                    <td align="center">
                        <asp:LinkButton ID="lkVisible" runat="server" CommandName="visiblehome" CommandArgument='<%# Eval("Id") %>'>
                            <img src='<%# bool.Parse(Eval("IsVisibleHome").ToString()) ? "/img/icons/checked.gif" : "/img/icons/unchecked.gif" %>' />
                        </asp:LinkButton>
                    </td>
                    <td align="center">
                        <%# Eval("OrderIndex") %>
                    </td>
                    <td align="center">
                        <asp:TextBox CssClass="numeric update" ID="txtOrder" runat="server" Text='<%# Eval("OrderIndex") %>'></asp:TextBox>
                        <asp:Button index="<%# Container.ItemIndex %>" CssClass="order update" ID="Button1" runat="server" Text="Button" CommandName="order" CommandArgument='<%# Eval("Id") %>' />
                    </td>
                    <td>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
</div>
<script type="text/javascript">
    $(document).ready(function(){
        $(".numeric").numeric();
        
        function isNumeric(value) 
        { 
            if (value.match(/^\d+(\.\d+)?$/) == null) 
                return false; 
            return true; 
        }
    });
</script>