<%@ Page Language="C#" MasterPageFile="~/MasterPage-2col.master" AutoEventWireup="true"
    CodeFile="ProductDetail.aspx.cs" Inherits="Modules_Products_ProductDetail" Title="Untitled Page" %>

<%@ Register Src="Controls/ProductDetail.ascx" TagName="ProductDetail" TagPrefix="uc1" %>
<%@ Register Src="../Catalogs/Controls/BreadCrumb.ascx" TagName="BreadCrumb" TagPrefix="uc2" %>
<%@ Register Src="Controls/ProductTopNewOrder.ascx" TagName="ProductTopNewOrder"
    TagPrefix="uc3" %>
<%@ Register Src="../Catalogs/Controls/CatalogBox.ascx" TagName="CatalogBox" TagPrefix="uc4" %>
<%@ Register Src="../Adverts/Controls/Adverts2.ascx" TagName="Adverts" TagPrefix="uc5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" runat="Server">

    <script src="/js/jquery.numeric.js" type="text/javascript"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Left" runat="Server">
    <uc5:Adverts ID="Adverts2" runat="server" PositionType="L" PositionId="ALL|PD" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Holder_Content" runat="Server">
    <uc2:BreadCrumb ID="BreadCrumb1" runat="server" />
    <%--<uc5:Adverts ID="Adverts1" runat="server"  PositionType="T" PositionId="ALL|PD" Visible="false"/>--%>
    <uc1:ProductDetail ID="ProductDetail1" runat="server" />
    <uc4:CatalogBox ID="CatalogBox1" runat="server" />
    <uc3:ProductTopNewOrder ID="ProductTopNewOrder1" runat="server" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Footer" runat="Server">

    <script type="text/javascript">
    $(document).ready(function(){
        $(".numeric").numeric();
    });
    </script>

</asp:Content>
