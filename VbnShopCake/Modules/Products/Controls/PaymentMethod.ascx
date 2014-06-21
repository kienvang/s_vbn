<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PaymentMethod.ascx.cs"
    Inherits="Modules_Products_Controls_PaymentMethod" %>
<style type="text/css">
    .payment .pitem
    {
        margin-bottom: 4px;
    }
    .payment .pitem label
    {
        margin-left: 2px;
    }
    .payment .pitem .nl
    {
        margin-left: 14px;
        margin-top: 2px;
    }
</style>
<div class="payment">
    <div class="pitem" id="divCah" runat="server">
        <asp:RadioButton ID="rdoCah" runat="server" Checked="true" Text="Giao hàng tận nơi và thu tiền (Chỉ áp dụng trong phạm vi TP.HCM)"
            GroupName="pay" />
        <asp:HyperLink ID="lkCah" runat="server" NavigateUrl="/" Target="_blank">(Hướng dẫn thanh toán)</asp:HyperLink>
    </div>
    <div class="pitem" id="divBanking" runat="server">
        <asp:RadioButton GroupName="pay" ID="rdoBanking" runat="server" Text="Thanh toán qua tài khoản ngân hàng va Internet Banking" />
        <asp:HyperLink ID="lkBanking" runat="server" NavigateUrl="/" Target="_blank">(Hướng dẫn thanh toán)</asp:HyperLink>
    </div>
    <div class="pitem" id="divNL" runat="server">
        <asp:RadioButton ID="rdoNL" runat="server" Text="Thanh toán qua ví điện tử Ngân Lượng"
            GroupName="pay" />
        <asp:HyperLink ID="lkNL" runat="server" NavigateUrl="/" Target="_blank">(Hướng dẫn thanh toán)</asp:HyperLink>
        <div class="nl">
            <img src="/img/payment-nl.png" />
        </div>
    </div>
    <div class="pitem" id="divCardInternal" runat="server">
        <asp:RadioButton GroupName="pay" ID="rdoCardInternal" runat="server" Text="Thanh toán qua thẻ nội địa" />
        <asp:HyperLink ID="lkCardInternal" runat="server" NavigateUrl="/" Target="_blank">(Hướng dẫn thanh toán)</asp:HyperLink>
    </div>
    <div class="pitem" id="divVisa" runat="server">
        <asp:RadioButton GroupName="pay" ID="rdoVisa" runat="server" Text="Thanh toán qua thẻ tín dụng"
            Enabled="false" />
        <asp:HyperLink ID="lkVisa" runat="server" NavigateUrl="/" Target="_blank">(Hướng dẫn thanh toán)</asp:HyperLink>
    </div>
</div>
