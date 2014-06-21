<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DetailShipping.ascx.cs"
    Inherits="Admin_Orders_Controls_DetailShipping" %>
<%@ Import Namespace="Library.Tools" %>
<div>
    <table width="100%" border="1" class="grid-sub">
        <tr class="title">
            <td>
                Người nhận
            </td>
            <td width="200px">
                Sản phẩm
            </td>
            <td width="120px">
                Đơn giá
            </td>
            <td width="65px">
                Số lượng
            </td>
            <td width="120px">
                Thành tiền
            </td>
        </tr>
        <asp:Repeater ID="repShipping" runat="server">
            <ItemTemplate>
                <asp:Repeater ID="repShipDetail" runat="server" DataSource='<%# GetShippingItem(new Guid(Eval("Id").ToString())) %>'>
                    <ItemTemplate>
                        <tr class="row">
                            <%# Container.ItemIndex == 0 ? GetItemHtml(new Guid(Eval("ShippingId").ToString())) : "" %>
                            <td>
                                <%# (!string.IsNullOrEmpty(Eval("ProductCode").ToString()) ? Eval("ProductCode").ToString() + " - " : "") + Eval("ProductName").ToString() %>
                            </td>
                            <td align="right">
                                <%# FNumber.FormatNumber(Eval("PriceAfterTax"))%>
                            </td>
                            <td align="right">
                                <%# Eval("Amount") %>
                            </td>
                            <td align="right">
                                <%# FNumber.FormatNumber( Convert.ToDouble(Eval("PriceAfterTax")) * Convert.ToInt32(Eval("Amount"))) %>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
                <tr class="total">
                    <td>
                        Tổng cộng :
                    </td>
                    <td align="right" colspan="4">
                        <%# FNumber.FormatNumber(TotalPriceSell)%>
                    </td>
                    
                </tr>
            </ItemTemplate>
            <SeparatorTemplate>
                <tr height="10px">
                    <td colspan="5">
                    </td>
                </tr>
            </SeparatorTemplate>
        </asp:Repeater>
    </table>
</div>
