<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Adverts2.ascx.cs" Inherits="Modules_Adverts_Controls_Adverts2" %>
<%@ Register Src="BoxAdvert.ascx" TagName="BoxAdvert" TagPrefix="uc1" %>
<div class="adv-header">
    <div class="line">
    </div>
    <div class="header">
        Quảng Cáo</div>
</div>
<asp:Repeater ID="repAdverts" runat="server">
    <HeaderTemplate>
        <ul class="listBanner">
    </HeaderTemplate>
    <ItemTemplate>
        <uc1:BoxAdvert ID="BoxAdvert1" runat="server" AdvertPositionId='<%# Eval("Id") %>'
            IsSingle='<%# Eval("IsSingle") %>' FHeight="<%# Height %>" FWidth="<%# Width %>" />
    </ItemTemplate>
    <FooterTemplate>
        </ul>
    </FooterTemplate>
</asp:Repeater>
<asp:Repeater ID="repAdverts2" runat="server">
    <HeaderTemplate>
        <div class="listBanner2">
            <ul>
    </HeaderTemplate>
    <ItemTemplate>
        <p <%# Total == Container.ItemIndex + 1 ? "class='last'" : "" %>>
            <uc1:BoxAdvert ID="BoxAdvert1" runat="server" AdvertPositionId='<%# Eval("Id") %>'
                IsSingle='<%# Eval("IsSingle") %>' FHeight="<%# Height %>" FWidth="<%# Width %>" />
        </p>
    </ItemTemplate>
    <FooterTemplate>
        </ul> </div>
    </FooterTemplate>
</asp:Repeater>
