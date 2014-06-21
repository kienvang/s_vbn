<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="Admin_Videos_Default" Title="Danh Sách Video" %>

<%@ Register Src="Controls/Menu.ascx" TagName="Menu" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" runat="Server">
    <uc1:Menu ID="Menu1" runat="server" />
    <h2>
        Danh Sách Video</h2>
    <div>
        <table border="1" class="grid">
            <tr>
                <th width="30px">
                    STT
                </th>
                <th>
                    Tên Video
                </th>
                <th width="120px">
                    Danh mục
                </th>
                <th width="200px">
                    Loại
                </th>
                <th width="60px">
                    Trang chủ
                </th>
                <th width="60px">
                    Auto Start
                </th>
                <th width="40px">
                </th>
                <th width="40px">
                </th>
            </tr>
            <asp:Repeater ID="repVideos" runat="server" OnItemCommand="repVideos_ItemCommand">
                <ItemTemplate>
                    <tr class="row">
                        <td align="center">
                            <%# Container.ItemIndex + 1 %>
                        </td>
                        <td>
                            <%# Eval("VideoName") %>
                        </td>
                        <td>
                            <%# Eval("CatName") %>
                        </td>
                        <td>
                            <%# Eval("TypeName") %>
                        </td>
                        <td align="center">
                            <input type="radio" name="visiblehome" class="isvisiblehome" id='<%# Eval("Id") %>'
                                <%# Convert.ToBoolean(Eval("IsVisibleHome")) ? "checked='checked'" : "" %> />
                        </td>
                        <td align="center">
                            <asp:LinkButton ID="LinkButton1" runat="server" CommandName="autostart" CommandArgument='<%# Eval("Id") %>'>
                                <img src='<%# bool.Parse(Eval("AutoStart").ToString()) ? "/img/icons/checked.gif" : "/img/icons/unchecked.gif" %>' />
                            </asp:LinkButton>
                        </td>
                        <td align="center">
                            <a href='/Admin/Videos/AddEditVideo.aspx?id=<%# Eval("Id") %>'>
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
    </div>

    <script type="text/javascript">
        $(document).ready(function(){
            $(".isvisiblehome").click(function(){
                var jsonStr = "{videoid:'" + $(this).attr("Id") + "'}";
                
                $.ajax({
				    type: "POST",
				    url: "/Admin/Webservices/WebService.asmx/UpdateVisibleHome",
				    contentType: "application/json; charset=utf-8",
				    dataType: "json",
				    data: jsonStr,
				    success: function(msg) {
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
