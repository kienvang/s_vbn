<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SearchBox.ascx.cs" Inherits="Modules_Home_Controls_SearchBox" %>
<h2>
    Tìm kiếm</h2>
<div style="margin: 5px 0 5px 5px">
    <b>Tên sản phẩm</b>
    <div style="margin:5px 0">
        <asp:TextBox ID="txtProductName" runat="server" Width="190px" CssClass="ssearch"></asp:TextBox>
    </div>
    <b>Loại sản phẩm</b>
    <div style="margin:5px 0">
        <asp:TextBox ID="txtCatalogName" runat="server" Width="190px" CssClass="ssearch"></asp:TextBox>
    </div>
    <div style="margin:5px 0">
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
    </div>
    <div style="text-align: right; margin-top:10px">
        <asp:Button ID="btnSearch" runat="server" Text="Tìm" CssClass="btn" ValidationGroup="search" />
    </div>
</div>

<script type="text/javascript">
    $(document).ready(function(){
        function Search()
        {
            var ProductName = $("#<%= txtProductName.ClientID %>").val();
            var Price = $("#<%= ddlPrice.ClientID %>").val();
            var CatalogName = $("#<%= txtCatalogName.ClientID %>").val();
                
            var jsonStr = "{ProductName:'" + ProductName + "',Price:'" + Price + "',CatalogName:'" + CatalogName + "'}";
            //alert(jsonStr);    
            $.ajax({
	            type: "POST",
	            url: "/Admin/Webservices/WebService.asmx/Search",
	            contentType: "application/json; charset=utf-8",
	            dataType: "json",
	            data: jsonStr,
	            success: function(msg) {
	                window.location = msg.d;
		            return true;
	            },
	            error: function() {
	                return false;
	            }
            });
        }
    
        $("input[id$='txtProductName']").keyup(function(event) {
            if (event.keyCode == '13') {
                Search();
            }
        });
        
        $("input[id$='txtCatalogName']").keyup(function(event) {
            if (event.keyCode == '13') {
                Search();
            }
        });
        
        $("#<%= btnSearch.ClientID %>").click(function(){
            Search();
            return false;
        });
    
    });
    
</script>

