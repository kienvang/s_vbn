<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DetailCarts.ascx.cs" Inherits="Admin_Orders_Controls_DetailCarts" %>
<%@ Import Namespace="Library.Tools" %>
<%@ Import Namespace="LayerHelper.ShopCake.BLL" %>
<table width="100%" border="1" class="grid-sub">
    <tr class="title">
        <td width="30px" rowspan="2">
            STT
        </td>
        <td rowspan="2">
            Tên sản phẩm
        </td>
        <td colspan="3" align="center">
            Giá mua
        </td>
        <td colspan="3" align="center">
            Giá bán
        </td>
        <td width="100px" align="center" rowspan="2">
            Lợi nhuận
        </td>
    </tr>
    <tr>
        <td width="100px" align="center">
            Giá mua
        </td>
        <td width="65px" align="center">
            Số lượng
        </td>
        <td width="100px" align="center">
            Tổng giá mua
        </td>
        <td width="100px" align="center">
            Giá bán
        </td>
        <td width="65px" align="center">
            Số lượng
        </td>
        <td width="100px" align="center">
            Tổng giá bán
        </td>
    </tr>
    <asp:Repeater ID="repItems" runat="server">
        <ItemTemplate>
            <tr>
                <td colspan="9">
                    Nhà cung cấp :
                    <%# SuppliersManager.CreateInstant().GetSupplierName(new Guid(Eval("SupplierId").ToString()))%>
                </td>
            </tr>
            <asp:Repeater ID="repItemsDetail" runat="server" DataSource='<%# GetItemsDetail(new Guid(Eval("Id").ToString())) %>'>
                <ItemTemplate>
                    <tr class="row">
                        <td align="center">
                            <%# Container.ItemIndex + 1 %>
                        </td>
                        <td>
                           <%# (!string.IsNullOrEmpty(Eval("ProductCode").ToString()) ? Eval("ProductCode").ToString() + " - " : "") + Eval("ProductName").ToString() %>
                        </td>
                        <td align="right">
                            <%# FNumber.FormatNumber(Eval("PoPrice"))%>
                        </td>
                        <td align="right">
                            <%# Eval("Amount").ToString()%>
                        </td>
                        <td align="right">
                            <%# FNumber.FormatNumber(Eval("TotalPoPrice")) %>
                        </td>
                        <td align="right">
                            <%# FNumber.FormatNumber(Eval("PriceAfterTax"))%>
                        </td>
                        <td align="right">
                            <%# Eval("Amount").ToString()%>
                        </td>
                        <td align="right">
                            <%# FNumber.FormatNumber(Eval("TotalPriceAfterTax"))%>
                        </td>
                        <td align="right">
                            <%# FNumber.FormatNumber((Convert.ToDouble(Eval("PriceAfterTax")) - Convert.ToDouble(Eval("PoPrice"))) * Convert.ToInt32(Eval("Amount")))%>
                        </td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    <tr class="total">
                        <td colspan="2">
                            Tổng cộng :
                        </td>
                        <td align="right">
                            <%= FNumber.FormatNumber(PoPrice)%>
                        </td>
                        <td align="right">
                            <%= TotalAmount.ToString()%>
                        </td>
                        <td align="right">
                            <%= FNumber.FormatNumber(TotalPoPrice) %>
                        </td>
                        <td align="right">
                            <%= FNumber.FormatNumber(PriceAfterTax)%>
                        </td>
                        <td align="right">
                            <%= TotalAmount.ToString()%>
                        </td>
                        <td align="right">
                            <%= FNumber.FormatNumber(TotalPriceAfterTax)%>
                        </td>
                        <td align="right">
                            <%= FNumber.FormatNumber(TotalPriceAfterTax - TotalPoPrice)%>
                        </td>
                    </tr>
                </FooterTemplate>
            </asp:Repeater>
        </ItemTemplate>
    </asp:Repeater>
</table>
