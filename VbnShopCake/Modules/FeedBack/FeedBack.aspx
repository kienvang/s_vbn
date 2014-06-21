<%@ Page Language="C#" MasterPageFile="~/MasterPage-2col.master" AutoEventWireup="true"
    CodeFile="FeedBack.aspx.cs" Inherits="Modules_FeedBack" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" runat="Server" EnableViewState="false">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Left" runat="Server" EnableViewState="false">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Holder_Content" runat="Server">
    <h2>
        Chúng tôi rất trân trọng những ý kiến đóng góp của quý khách.
    </h2>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="error"/>
    <table width="100%" border="0" cellpadding="4" cellspacing="2">
        <tr>
            <td width="150px">
                <b>Tên quý khách</b>
            </td>
            <td>
                :&nbsp;<asp:TextBox ID="txtSender" runat="server" Width="450px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtSender"
                    Display="Dynamic" ErrorMessage="Nhập tên quý khách">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <b>Địa chỉ email</b>
            </td>
            <td>
                :&nbsp;<asp:TextBox ID="txtSenderEmail" runat="server" Width="450px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtSenderEmail"
                    Display="Dynamic" ErrorMessage="Nhập địa chỉ email">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtSenderEmail"
                    Text="*" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                    Display="Dynamic" ErrorMessage="Địa chỉ email không đúng"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>
                <b>Thông tin liên hệ</b>
            </td>
            <td>
                &nbsp;&nbsp;<asp:TextBox ID="txtMessage" runat="server" TextMode="MultiLine" Width="450px"
                    Height="250px"></asp:TextBox>
            </td>
        </tr>
        <tr valign="bottom" height="30px">
            <td>
                <b></b>
            </td>
            <td>
                <asp:Button ID="btnSend" runat="server" Text="Gởi ý kiến" OnClick="btnSend_Click" CssClass="btn" />
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Footer" runat="Server" EnableViewState="false">
</asp:Content>
