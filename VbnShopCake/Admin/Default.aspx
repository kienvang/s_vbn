<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="Admin_Default" Title="VBN Administrator System" %>

<%@ Register Src="Events/Controls/Events.ascx" TagName="Events" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
    <link href="/Admin/css/screen.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" runat="Server">
    <div style="margin: 0px 5px 0 5px">
        <table width="100%">
            <tr valign="top">
                <td width="32%">
                    <uc1:Events ID="ucOrder" runat="server" />
                </td>
                <td width="2%">
                    &nbsp;
                </td>
                <td width="32%">
                    <uc1:Events ID="ucRegisterProduct" runat="server" />
                    <uc1:Events ID="ucRegisterSupplier" runat="server" />
                </td>
                <td width="2%">
                    &nbsp;
                </td>
                <td width="32%">
                    <uc1:Events ID="ucFeedBack" runat="server" />
                </td>
            </tr>
        </table>
    </div>

    <script type="text/javascript">
        $(document).ready(function(){
            $(".event").click(function(){
                var id = $(this).attr("id");
                
                var jsonStr = "{EventId:'" + id + "'}";
                //alert(jsonStr);    
                $.ajax({
	                type: "POST",
	                url: "/Admin/Webservices/WebService.asmx/ApprovedEvent",
	                contentType: "application/json; charset=utf-8",
	                dataType: "json",
	                data: jsonStr,
	                success: function(msg) {
	                    $("div[id='" + id + "']").hide(600);
		                return true;
	                },
	                error: function() {
	                    return false;
	                }
                });
            });
        });
    </script>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
