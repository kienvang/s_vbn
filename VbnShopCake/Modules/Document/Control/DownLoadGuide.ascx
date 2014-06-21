<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DownLoadGuide.ascx.cs"
    Inherits="Modules_Document_Control_DownLoadGuide" %>
<%@ Register Src="../../Products/Controls/PaymentMethod.ascx" TagName="PaymentMethod"
    TagPrefix="uc1" %>
<h2>
    Nạp điểm qua mã số thẻ cào</h2>
<div>
    <asp:Label ID="lblPutCard" runat="server"></asp:Label>
</div>
<b>
    <asp:Label ID="lbAlert" runat="server"></asp:Label>
</b>
<asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="code" />
<asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="CustomValidator"
    ValidationGroup="code" Display="None"></asp:CustomValidator>
<div style="clear: both; margin: 10px 0">
    <b>Nhập mã số</b>
    <asp:TextBox ID="txtCode" runat="server" ValidationGroup="code">
    </asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Nhập mã số"
        ValidationGroup="code" ControlToValidate="txtCode" Display="Dynamic">*</asp:RequiredFieldValidator>
    <asp:Button ID="btSubmit" runat="server" Text="Nạp điểm" OnClick="btSubmit_Click"
        ValidationGroup="code" CssClass="btn" />
</div>
<div id="divMark" runat="server">
    <h2>
        Nạp điểm qua thanh toán</h2>
    <div>
    <asp:Label ID="lblPayOnline" runat="server"></asp:Label>
    </div>
    <table width="100%">
        <tr valign="top">
            <td width="120px">
                <b>Các mức điểm</b>
            </td>
            <td>
                <div style="margin-bottom: 10px">
                    <asp:RadioButtonList ID="rdoMark" runat="server">
                    </asp:RadioButtonList>
                </div>
            </td>
        </tr>
        <tr valign="top">
            <td>
                <b>Thanh toán</b>
            </td>
            <td>
                <uc1:PaymentMethod ID="PaymentMethod1" runat="server" ProductId="DOC" />
            </td>
        </tr>
        <tr>
            <td>
                <b></b>
            </td>
            <td>
                <div style="margin-top: 10px">
                    <asp:Button ID="btnPay" runat="server" Text="Thanh Toán" CssClass="btn" OnClick="btnPay_Click" />
                </div>
            </td>
        </tr>
    </table>
</div>
