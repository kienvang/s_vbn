<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Adverts.ascx.cs" Inherits="Modules_Adverts_Controls_Adverts" %>
<%@ Register Src="../../Controls/BoxImageFlash.ascx" TagName="BoxImageFlash" TagPrefix="uc1" %>
<asp:Repeater ID="repAdverts" runat="server">
    <HeaderTemplate>
        <ul class="listBanner">
    </HeaderTemplate>
    <ItemTemplate>
        <li>
            <uc1:BoxImageFlash ID="BoxImageFlash1" runat="server" MediaName='<%# Eval("AdvertName") %>'
                MediaPath='<%# Eval("Path") %>' MediaAddress='<%# Eval("AddressUrl") %>' MediaType='<%# Eval("Type") %>'
                FWidth="<%# Width %>" FHeight="<%# Height %>" />
        </li>
    </ItemTemplate>
    <FooterTemplate>
        </ul>
    </FooterTemplate>
</asp:Repeater>
<asp:Repeater ID="repAdverts2" runat="server">
    <HeaderTemplate>
        <div class="listBanner2">
    </HeaderTemplate>
    <ItemTemplate>
        <p <%# Total == Container.ItemIndex + 1 ? "class='last'" : "" %> >
            <uc1:BoxImageFlash ID="BoxImageFlash1" runat="server" MediaName='<%# Eval("AdvertName") %>'
                MediaPath='<%# Eval("Path") %>' MediaAddress='<%# Eval("AddressUrl") %>' MediaType='<%# Eval("Type") %>'
                FWidth="<%# Width %>" FHeight="<%# Height %>" />
        </p>
    </ItemTemplate>
    <FooterTemplate>
        </div>
    </FooterTemplate>
</asp:Repeater>
