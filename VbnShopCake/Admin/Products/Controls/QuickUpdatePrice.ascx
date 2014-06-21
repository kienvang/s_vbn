<%@ Control Language="C#" AutoEventWireup="true" CodeFile="QuickUpdatePrice.ascx.cs"
    Inherits="Admin_Products_Controls_QuickUpdatePrice" %>
<%@ Import Namespace="Library.Tools" %>

<script src="/js/jquery.numeric.js" type="text/javascript"></script>

<div>
    <table border="1" cellpadding="2" cellspacing="2" class="grid">
        <tr class="title">
            <th width="40px">
                STT
            </th>
            <th width="50px">
                Mã SP
            </th>
            <th>
                Tên Sản Phẩm
            </th>
            <th width="120px">
                Giá mua
            </th>
            <th width="135px">
            </th>
            <th width="120px">
                Giá bán
            </th>
            <th width="135px">
            </th>
        </tr>
        <asp:Repeater ID="repDeals" runat="server">
            <ItemTemplate>
                <tr class="row">
                    <td align="center">
                        <%# Container.ItemIndex + 1 %>
                    </td>
                    <td>
                        <%# Eval("IntId") %>
                    </td>
                    <td>
                        <a href='/Admin/Products/Detail.aspx?id=<%# Eval("Id") %>'>
                            <%# Eval("ProductName") %>
                        </a>
                    </td>
                    <td align="right">
                        <span class="d-pricepo-<%# Container.ItemIndex %>">
                            <%# FNumber.FormatNumber(Eval("PriceBuy"))%>
                        </span>
                        <%# Eval("Currency") %>
                    </td>
                    <td>
                        <div>
                            <div class="updatepo-<%# Container.ItemIndex %>">
                                <input class="numeric pricepo-<%# Container.ItemIndex %> update" type="text" />
                                <input type="button" class="ipricepo update" value="Cập nhật" index="<%# Container.ItemIndex %>" />
                            </div>
                            <div class="updatepo-<%# Container.ItemIndex %>" style="display: none">
                                <img src="/img/ajax-loader.gif" />
                                Đang cập nhật giá
                            </div>
                        </div>
                    </td>
                    <td align="right">
                        <span class="d-price-<%# Container.ItemIndex %>">
                            <%# FNumber.FormatNumber(Eval("Price")) %>
                        </span>
                        <%# Eval("Currency") %>
                    </td>
                    <td>
                        <div>
                            <div class="update-<%# Container.ItemIndex %>">
                                <input class="numeric price-<%# Container.ItemIndex %> update" type="text" />
                                <input type="button" class="iprice update" value="Cập nhật" index="<%# Container.ItemIndex %>" />
                                <input type="hidden" class="id-<%# Container.ItemIndex %>" value='<%# Eval("Id") %>' />
                            </div>
                            <div class="update-<%# Container.ItemIndex %>" style="display: none">
                                <img src="/img/ajax-loader.gif" />
                                Đang cập nhật giá
                            </div>
                        </div>
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
        
        $(".iprice").click(function(){
            var index = $(this).attr("index");
            var value = $(".price-" + index).val();
            var productId = $(".id-" + index).val();
            if (isNumeric(value))
            {
                UpdatePrice(productId, value, index)
            }
            return false;
        });
        
        $(".ipricepo").click(function(){
            var index = $(this).attr("index");
            var value = $(".pricepo-" + index).val();
            var productId = $(".id-" + index).val();
            if (isNumeric(value))
            {
                UpdatePricePo(productId, value, index)
            }
            return false;
        });
        
        function UpdatePricePo(productId, price, index)
        {
            var jsonStr = "{_ProductId:'" + productId + "',_Price:'" + price + "'}";
            $(".updatepo-" + index).toggle(1000);
            $(".pricepo-" + index).val("")
            $.ajax({
				type: "POST",
				url: "/Admin/Webservices/ProductServices.asmx/UpdatePriceBuy",
				contentType: "application/json; charset=utf-8",
				dataType: "json",
				data: jsonStr,
				success: function(msg) {
				    $(".d-pricepo-" + index).html(msg.d[0]);
				    $(".updatepo-" + index).toggle(1000);
					return true;
				},
				error: function() {
				    $(".updatepo-" + index).toggle(1000);
					return false;
				}
			});
        }
        
        function UpdatePrice(productId, price, index)
        {
            var jsonStr = "{_ProductId:'" + productId + "',_Price:'" + price + "'}";
            $(".update-" + index).toggle(1000);
            $(".price-" + index).val("")
            $.ajax({
				type: "POST",
				url: "/Admin/Webservices/ProductServices.asmx/UpdatePrice",
				contentType: "application/json; charset=utf-8",
				dataType: "json",
				data: jsonStr,
				success: function(msg) {
				    $(".d-price-" + index).html(msg.d[0]);
				    $(".update-" + index).toggle(1000);
					return true;
				},
				error: function() {
				    $(".update-" + index).toggle(1000);
					return false;
				}
			});
        }
    });
</script>

