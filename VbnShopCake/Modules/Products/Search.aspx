<%@ Page Language="C#" MasterPageFile="~/MasterPage-2col.master" AutoEventWireup="true"
    CodeFile="Search.aspx.cs" Inherits="Modules_Products_Search" Title="Untitled Page"
    EnableViewState="false" %>

<%@ Import Namespace="Modules.Products" %>
<%@ Register TagPrefix="avg" Namespace="Avg.Controls" Assembly="SmartPager" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Left" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Holder_Content" runat="Server">
    <div class="listProducts">
        <h2 style="text-transform: none">
            Kết quả tìm kiếm :
            <%= TotalSearch %>
            sản phẩm
        </h2>
        <div class="productsInfo">
            <asp:Repeater ID="dltProducts" runat="server">
                <ItemTemplate>
                    <%# Container.ItemIndex % 3 == 0 ? "<div class='items'>" : "" %>
                    <div class="item">

                        <script type="text/javascript">
                                $(function() {
                                    $('.thumb-<%# Container.ItemIndex.ToString() + "-" + ClientID.ToString() %>').lightBox();
                                });
                        </script>

                        <div class="thumbnail">
                            <a class="thumb-<%# Container.ItemIndex.ToString() + "-" + ClientID.ToString() %>"
                                href='<%# !string.IsNullOrEmpty(Eval("Thumbnail").ToString()) ? Eval("Thumbnail").ToString() + "?w=500&c=1" : "/images/no_img.gif" %>'
                                title='<%# Eval("ProductName").ToString() + " " + Library.Tools.Util.TrimString(Eval("Abstract").ToString(), 150) %>'>
                                <img src='<%# !string.IsNullOrEmpty(Eval("Thumbnail").ToString()) ? Eval("Thumbnail").ToString() + "?w=180&h=180&c=0" : "/images/no_img.gif" %>'
                                    alt='<%# Eval("ProductName") %>' title='<%# Eval("ProductName") %>' /></a>
                        </div>
                        <div class="info">
                            <h3>
                                <p class="cat" style="font-weight: bold">
                                    <%# Eval("ProductCode").ToString()%>
                                    <% if (Modules.Role.CheckRoles.CreateInstant().IsRoles(Modules.Role.EnumsRoles.Administrator))
                                       { %>
                                    <a href='/Admin/Products/Detail.aspx?Id=<%# Eval("Id") %>'>
                                        <img src="/img/button/properties.png" />
                                    </a>
                                    <%} %>
                                </p>
                                <a href='<%# Modules.Products.UrlBuilder.ViewDetail(int.Parse(Eval("CatId").ToString()),Eval("CatTextId").ToString(),int.Parse(Eval("IntId").ToString()),Eval("TextId").ToString()) %>'
                                    title='<%# Eval("ProductName") %>'>
                                    <%# Eval("ProductName") %></a></h3>
                            <p>
                                <span>Giá: <span class="orange">
                                    <%# Convert.ToDecimal(Eval("Price")) >0 ? Library.Tools.FNumber.FormatNumber(Eval("Price")) + " VND" : "Liên hệ sau" %>
                                </span></span>
                            </p>
                        </div>
                    </div>
                    <%# ((Container.ItemIndex + 1) % 3 == 0 || ((Container.ItemIndex + 1) % 3 != 0 && Container.ItemIndex == last && Container.ItemIndex > 0)) ? "</div>" : "" %>
                </ItemTemplate>
                <SeparatorTemplate>
                    <div style="width: 50px; margin: 0">
                        &nbsp;</div>
                </SeparatorTemplate>
            </asp:Repeater>
        </div>
    </div>
    <div>
        <avg:SmartPager ID="smartPager" runat="server" Visible="false" />
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
