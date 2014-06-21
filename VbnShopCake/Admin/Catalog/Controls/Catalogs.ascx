<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Catalogs.ascx.cs" Inherits="Admin_Catalog_Controls_Catalogs" %>
<table border="0">
    <tr>
        <td>
            <div id="prev-invi">
                <img src="/img/button/button-invi-prev.gif" />
            </div>
            <div id="prev">
                <a href="javascript:void(0)">
                    <img src="/img/button/button-prev.gif" />
                </a>
            </div>
        </td>
        <td>
            <div id="catalogs">
                <div style="background-color: #F7D777; margin-bottom: 3px">
                    <% if (catParent == null)
                       { %>
                    Danh mục gốc
                    <%}
                       else
                       { %>
                    <%= catParent.CatalogName %>
                    <%} %>
                </div>
                <div>
                    <select class="ddlCatalog" style="width: 200px">
                        <asp:Repeater ID="repCatalog" runat="server">
                            <HeaderTemplate>
                                <% if (catParent == null)
                                   { %>
                                <option value='-1|0|True|0'>Chọn danh mục gốc</option>
                                <%}
                                   else
                                   { %>
                                <option value='-1|<%= this.ParentId.ToString() + "|" + this.IsLeaf.ToString() + "|" + this.Id.ToString() %>'>Chọn
                                    danh mục cha</option>
                                <%} %>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <option value='0|<%# Eval("ParentId").ToString() + "|" + Eval("IsLeaf").ToString() + "|" + Eval("Id").ToString() %>'>
                                    <%# Eval("CatalogName") %></option>
                            </ItemTemplate>
                        </asp:Repeater>
                    </select>
                </div>
            </div>
        </td>
        <td>
            <div id="next-invi">
                <img src="/img/button/button-invi-next.gif" />
            </div>
            <div id="next">
                <a href="javascript:void(0)">
                    <img src="/img/button/button-next.gif" />
                </a>
            </div>
        </td>
    </tr>
</table>

<script type="text/javascript">
    $(document).ready(function(){
        LoadCatalog();
        
        function LoadCatalog()
        {
            var st = $(".ddlCatalog").val().split('|');
            
            var parentId = st[1];
            var isLeaf = st[2];
            
            $("#prev-invi").hide();
            $("#prev").hide();
            $("#next-invi").hide();
            $("#next").hide();
                
            if (parentId == 0 && isLeaf == 'True')
            {
                $("#prev-invi").show();
                $("#prev").hide();
                $("#next-invi").show();
                $("#next").hide();
            }
            else if (parentId != 0 && isLeaf == 'True')
            {
                $("#prev-invi").hide();
                $("#prev").show();
                $("#next-invi").show();
                $("#next").hide();
            }
            else if (parentId == 0 && isLeaf == 'False')
            {
                $("#prev-invi").show();
                $("#prev").hide();
                $("#next-invi").hide();
                $("#next").show();
            }
            else
            {
                $("#prev-invi").hide();
                $("#prev").show();
                $("#next-invi").hide();
                $("#next").show();
            }
            //alert(st[0]);
            if (st[0] == "-1")
            {
                $("#next-invi").show();
                $("#next").hide();
                $("#prev-invi").show();
                $("#prev").hide();
            }
        }
        
        function getCatalog(Id,type)
        {
            var _url = "/Admin/Catalog/WebServices/GetCatalog.aspx";
			var _data = "Id=" + Id +
			            "&t=" + type;

			$.ajax({
				url: _url,
				data: _data,
				cache: false,
				success: function(html) {
					var obj = $(html);
					obj.find(".ddlCatalog").bind("change", function(e) {
						Bind();
					});
					$("#catalogs").html(obj);
					LoadCatalog();
				},
				error: function() {

				}
			});
			
        }
        
        function Bind()
        {
            var st = $(this).val().split('|');
            LoadCatalog(st[1],st[2]);
        }
        
        $(".ddlCatalog").change(function(){
            Bind();
        });
        
        $("#prev").click(function(){
            var st = $(".ddlCatalog").val().split('|');
            getCatalog(st[1],"prev");
        });
        
        $("#next").click(function(){
            var st = $(".ddlCatalog").val().split('|');
            getCatalog(st[3], "next");
        });
    });
</script>

