<%@ Page Language="C#" MasterPageFile="~/MasterPage-2col.master" AutoEventWireup="true"
    EnableViewState="false" CodeFile="QuickSearch.aspx.cs" Inherits="Modules_Products_QuickSearch"
    Title="Untitled Page" %>

<%@ Import Namespace="Modules.Products" %>
<%@ Register TagPrefix="avg" Namespace="Avg.Controls" Assembly="SmartPager" %>
<%@ Register Src="../Adverts/Controls/Adverts2.ascx" TagName="Adverts" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Left" runat="Server">
    <uc1:Adverts ID="Adverts1" runat="server" PositionType="L" PositionId="ALL|SQ" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Holder_Content" runat="Server">
    <uc1:Adverts ID="Adverts2" runat="server" PositionType="T" PositionId="ALL|SQ" />
    <div class="listProducts">
        <h2 style="text-transform: none">
            Kết quả tìm kiếm :
            <%= TotalSearch %>
            sản phẩm
        </h2>
        <div class="productsInfo">
            <asp:Repeater ID="dltProducts" runat="server">
                <ItemTemplate>
                    <div>
                        <div class="thumbnail">
                            <a href='<%# UrlBuilder.ViewDetail(int.Parse(Eval("CatId").ToString()),Eval("CatTextId").ToString(),int.Parse(Eval("IntId").ToString()),Eval("TextId").ToString()) %>'
                                title='<%# Eval("ProductName") %>'>
                                <img src='<%# !string.IsNullOrEmpty(Eval("Thumbnail").ToString()) ? Eval("Thumbnail").ToString() + "?w=140&h=140&c=0" : "/images/no_img.gif" %>'
                                    alt='<%# Eval("ProductName") %>' title='<%# Eval("ProductName") %>' /></a>
                        </div>
                        <h3>
                            <a href='<%# UrlBuilder.ViewDetail(int.Parse(Eval("CatId").ToString()),Eval("CatTextId").ToString(),int.Parse(Eval("IntId").ToString()),Eval("TextId").ToString()) %>'
                                title='<%# Eval("ProductName") %>'>
                                <%# (!string.IsNullOrEmpty(Eval("ProductCode").ToString()) ? Eval("ProductCode").ToString() + " - " : "") + Eval("ProductName").ToString() %></a></h3>
                        <p style="text-align: justify">
                            <%# Library.Tools.Util.TrimString(Eval("Abstract").ToString(), 150) %></p>
                        <p>
                            <span>Giá:
                                <%# Convert.ToDecimal(Eval("Price")) >0 ? Library.Tools.FNumber.FormatNumber(Eval("Price")) + " VND" : "Liên hệ sau" %>
                            </span>
                        </p>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
        <div>
            <avg:SmartPager ID="smartPager" runat="server" Visible="false" />
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
