<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Carts.ascx.cs" Inherits="Modules_Products_Controls_Carts" %>
<%@ Import Namespace="Library.Tools" %>
<%@ Import Namespace="Modules.Role" %>
<style type="text/css">
    .form ul
    {
    	margin:20px 0;
    }
    
    .form ul li
    {
    	margin:10px 8px 10px 14px;
    	list-style:circle;
    	text-align:justify;
    }
    
    .form ul li a
    {
    	color:#9E0326;
    	font-size:12px;
    }
</style>
<table border="1" class="cart">
    <tr class="title">
        <td width="30px">
            STT
        </td>
        <td>
            Tên sản phẩm
        </td>
        <td width="80px">
            Mã sản phẩm
        </td>
        <td width="90px">
            Giá
        </td>
        <td width="70px">
            Số lượng
        </td>
        <td width="120px">
            Thành tiền
        </td>
        <td width="40px">
        </td>
    </tr>
    <asp:Repeater ID="repCart" runat="server" OnItemCommand="repCart_ItemCommand">
        <ItemTemplate>
            <tr>
                <td align="center">
                    <%# Container.ItemIndex + 1 %>
                </td>
                <td>
                    <%# Eval("ProductName") %>
                </td>
                <td>
                    <%# Eval("ProductCode") %>
                </td>
                <td align="right">
                    <%# Convert.ToDecimal(Eval("Price")) >0 ? Library.Tools.FNumber.FormatNumber(Eval("Price")) + " VND" : "Liên hệ sau" %>
                </td>
                <td align="right">
                    <asp:TextBox ID="txtQuantity" runat="server" CssClass="numeric" Text='<%# FNumber.FormatNumber(Eval("Total")) %>'
                        Width="50px"></asp:TextBox>
                    <asp:HiddenField ID="hidId" runat="server" Value='<%# Eval("ProductId") %>' />
                </td>
                <td align="right">
                    <%# Convert.ToDecimal(Eval("Price")) > 0 ? FNumber.FormatNumber(Convert.ToDecimal(Eval("Price")) * Convert.ToInt32(Eval("Total"))) + "VND" : "Liên hệ sau" %>
                </td>
                <td align="center">
                    <asp:LinkButton ID="lk" runat="server" OnClientClick="return confirm('Xác nhận xóa ?')"
                        CommandName="del" CommandArgument='<%# Eval("ProductId") %>'>Xóa</asp:LinkButton>
                </td>
            </tr>
        </ItemTemplate>
    </asp:Repeater>
    <tr>
        <td colspan="7" align="right" style="font-family: Tahoma; font-size: 14px">
            <b>Tổng cộng</b> :
            <%= FNumber.FormatNumber(Total) %>
            VND
        </td>
    </tr>
</table>
<div class="form" title="Phương thức thanh toán">
    <div>
        <ul>
        <li><a href="<%= CheckRoles.CreateInstant().GetUrlDirect(Request.RawUrl) %>">Bạn đã có tài khoản xin vui lòng đăng nhập để mua hàng</a></li>
        <li><asp:LinkButton ID="lkPayment" runat="server" 
                Text="Thanh toán không cần đăng ký tài khoản" onclick="lkPayment_Click"></asp:LinkButton></li>
        </ul>
    </div>
</div>
<div style="margin: 15px 0; text-align: center">
    <asp:Button ID="btnReCal" CssClass="btn" runat="server" Text="Tính toán lại" OnClick="btnReCal_Click"
        Visible="false" />
    <asp:Button ID="btnPayment" CssClass="btn" runat="server" Text="Thanh toán" OnClick="btnPayment_Click"
        Visible="false" />
    <% if (string.IsNullOrEmpty(Util.CurrentUserName))
       { %>
    <input type="button" id="callpayment" value="Thanh toán" class="btn" />
    <%} %>
    <asp:Button ID="btnContinue" CssClass="btn" runat="server" Text="Tiếp tục mua hàng"
        OnClick="btnContinue_Click" />
</div>

<script type="text/javascript">
    $(document).ready(function(){
        $(".form").dialog({
            bgiframe: false,
            autoOpen: false,
            height: 100,
            width: 300,
            modal: true,
            draggable: false,
            resizable: false,            
            open: function(event, ui) {                
                $(this).parent().appendTo("form");
            },
            close: function(event, ui) {
                
            }
        });
        
        $("#callpayment").click(function(){
            $(".form").dialog('open');
        });
    });
</script>

