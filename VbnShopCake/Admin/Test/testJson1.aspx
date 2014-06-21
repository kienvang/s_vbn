<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="testJson1.aspx.cs" Inherits="Admin_Test_testJson1" Title="Untitled Page" %>
<%@ Import Namespace="LayerHelper.ShopCake.DAL.EntityClasses" %>
<asp:Content ID="Content1" ContentPlaceHolderID="header" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" Runat="Server">
<div id="demo">
</div>
<input type="button" value="demo" id="btn" />
<script type="text/javascript">
    $(document).ready(function(){
        $("#btn").click(function(){
            HelloWorld("Tung");
        });
        
        function HelloWorld(st)
        {
            var jsonStr = "{st:'" + st + "'}";
            $.ajax({
				type: "POST",
				url: "/Admin/Webservices/ProductServices.asmx/HelloWorld",
				contentType: "application/json; charset=utf-8",
				dataType: "json",
				data: jsonStr,
				success: function(msg) {
				    $("#demo").html(msg.d[0] + "-" + msg.d[1]);
					return true;
				},
				error: function() {
					return false;
				}
			});
        }
    });
</script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" Runat="Server">
</asp:Content>

