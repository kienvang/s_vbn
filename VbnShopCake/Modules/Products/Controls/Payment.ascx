<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Payment.ascx.cs" Inherits="Modules_Products_Controls_Payment" %>
<%@ Register Src="../../Payment/Controls/SingleOrderDetail.ascx" TagName="SingleOrderDetail"
    TagPrefix="uc1" %>
<%@ Register Assembly="MSCaptcha" Namespace="MSCaptcha" TagPrefix="cc1" %>
<%@ Register Src="PaymentMethod.ascx" TagName="PaymentMethod" TagPrefix="uc2" %>
<%@ Import Namespace="Library.Tools" %>

<script src="/js/jquery.timepicker.js" type="text/javascript"></script>

<link href="/css/timePicker.css" rel="stylesheet" type="text/css" />
<style type="text/css">
    .error ol, ul
    {
        list-style-type: inherit;
    }
    label.rq
    {
    	color:Red;
    	margin-left:2px;
    }
</style>
<div style="margin: 10px 0">
    <div>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="error" />
        <asp:CustomValidator ID="valCart" runat="server" Display="Dynamic" OnServerValidate="valCart_ServerValidate"
            ErrorMessage=""></asp:CustomValidator>
    </div>
    <h2>
        Thông Tin Khách Hàng</h2>
    <table width="100%" cellpadding="2" cellspacing="2">
        <tr>
            <td width="120px">
                <b>Tên khách hàng</b>
                <label class="rq">
                    *</label>
            </td>
            <td>
                <asp:TextBox ID="txtCustomerName" runat="server" Width="450px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCustomerName"
                    Display="Dynamic" ErrorMessage="Nhập tên">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <b>Địa chỉ email</b><label class="rq">*</label>
            </td>
            <td>
                <asp:TextBox ID="txtCustomerEmail" runat="server" Width="350px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtCustomerEmail"
                    Display="Dynamic" ErrorMessage="Nhập địa chỉ email">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtCustomerEmail"
                    Text="*" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                    Display="Dynamic" ErrorMessage="Địa chỉ email không đúng"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>
                <b>Điện thoại</b><label class="rq">*</label>
            </td>
            <td>
                <asp:TextBox ID="txtCustomerPhone" runat="server" Width="350px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtCustomerPhone"
                    Display="Dynamic" ErrorMessage="Nhập số điện thoại">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <b>Địa chỉ</b><label class="rq">*</label>
            </td>
            <td>
                <asp:TextBox TextMode="MultiLine" ID="txtCustomerAddress" runat="server" Width="450px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtCustomerAddress"
                    Display="Dynamic" ErrorMessage="Nhập địa chỉ">*</asp:RequiredFieldValidator>
            </td>
        </tr>
    </table>
</div>
<div style="margin: 10px 0">
    <h2>
        Thông Tin Giao Hàng</h2>
    <table width="100%" cellpadding="2" cellspacing="2">
        <tr>
            <td colspan="2" style="padding-bottom: 10px">
                <asp:CheckBox ID="chkCopy" runat="server" Text=" Thông tin giao hàng giống thông tin khách hàng"
                    AutoPostBack="true" Font-Bold="true" ValidationGroup="copy" OnCheckedChanged="chkCopy_CheckedChanged"
                     />
            </td>
        </tr>
        <tr>
            <td width="120px">
                <b>Tên khách hàng</b><label class="rq">*</label>
            </td>
            <td>
                <asp:TextBox ID="txtShipCustomerName" runat="server" Width="450px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtShipCustomerName"
                    Display="Dynamic" ErrorMessage="Nhập tên người nhận">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <b>Địa chỉ email</b><label class="rq">*</label>
            </td>
            <td>
                <asp:TextBox ID="txtShipCustomerEmail" runat="server" Width="350px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtShipCustomerEmail"
                    Display="Dynamic" ErrorMessage="Nhập địa chỉ email người nhận">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtShipCustomerEmail"
                    Text="*" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                    Display="Dynamic" ErrorMessage="Địa chỉ email người nhận không đúng"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>
                <b>Điện thoại</b><label class="rq">*</label>
            </td>
            <td>
                <asp:TextBox ID="txtShipCustomerPhone" runat="server" Width="350px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtShipCustomerPhone"
                    Display="Dynamic" ErrorMessage="Nhập số điện thoại người nhận">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <b>Địa chỉ</b><label class="rq">*</label>
            </td>
            <td>
                <asp:TextBox ID="txtShipCustomerAddress" runat="server" Width="450px" TextMode="MultiLine"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtShipCustomerAddress"
                    Display="Dynamic" ErrorMessage="Nhập địa chỉ người nhận">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <b>Thời gian giao hàng</b><label class="rq">*</label>
            </td>
            <td>
                <asp:TextBox ID="txtShipDate" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtShipDate"
                    Display="Dynamic" ErrorMessage="Nhập ngày giao hàng">*</asp:RequiredFieldValidator>
                <asp:TextBox ID="txtShipTime" runat="server" Width="40px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txtShipTime"
                    Display="Dynamic" ErrorMessage="Nhập thời gian giao hàng">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtShipTime"
                    Text="*" ValidationExpression="\d{2}:\d{2}" Display="Dynamic" ErrorMessage="Địa chỉ email người nhận không đúng"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>
                <b>Ghi chú</b>
            </td>
            <td>
                <asp:TextBox ID="txtShipNote" runat="server" Width="450px" TextMode="MultiLine"></asp:TextBox>
                <div class="note">
                    * Nếu muốn tặng thiệp hay ghi lời chúc lên bánh kem bạn hãy ghi chú tại đây</div>
            </td>
        </tr>
        <tr>
            <td colspan="2">
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
            </td>
        </tr>
    </table>
</div>
<div>
    <h2>
        Phương thức thanh toán</h2>
    <table width="100%">
        <tr valign="top">
            <td width="120">
                <b>Phương thức</b>
            </td>
            <td>
                <uc2:PaymentMethod ID="ucPayment" runat="server" />
            </td>
        </tr>
        <tr valign="top">
            <td>
                <b>Mã xác nhận</b><label class="rq">*</label>
            </td>
            <td style="padding-top: 5px">
                <asp:TextBox ID="txtCaptcha" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="txtCaptcha"
                    Display="Dynamic" ErrorMessage="Nhập mã xác nhận">*</asp:RequiredFieldValidator>
                <div id="captcha">
                    <cc1:CaptchaControl ID="Captcha1" runat="server" CaptchaBackgroundNoise="Low" CaptchaLength="5"
                        CaptchaHeight="40" CaptchaWidth="150" CaptchaLineNoise="None" CaptchaMinTimeout="5"
                        CaptchaMaxTimeout="240" FontColor="#529E00" CustomValidatorErrorMessage="Vui lòng nhập mã xác nhận như trong hình" />
                </div>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td style="padding-top: 15px">
                <asp:Button ID="btnPayment" CssClass="btn" runat="server" Text="Mua hàng" OnClick="btnPayment_Click" />
                <asp:Button ID="btnCancel" CssClass="btn" runat="server" Text="Quay ra" ValidationGroup="cancel"
                    OnClick="btnCancel_Click" />
                <asp:Button ID="btnDelete" CssClass="btn" runat="server" Text="Hủy giỏ hàng" ValidationGroup="del"
                    OnClick="btnDelete_Click" OnClientClick="return confirm('Hủy giỏ hàng?')" />
                <asp:Button ID="btnPayGuide" CssClass="btn" runat="server" Text="Hướng dẫn thanh toán"
                    ValidationGroup="pay" Visible="false" />
            </td>
        </tr>
    </table>
</div>
<uc1:SingleOrderDetail ID="SingleOrderDetail1" runat="server" Visible="false" />

<script type="text/javascript">
    $(document).ready(function(){
	    $("#<%= txtShipDate.ClientID %>").datepicker({
	        showOn: 'both'
	        , buttonImage: '/img/button/calendar-up.gif'
	        , buttonImageOnly: true
	        , dateFormat: 'dd/mm/yy'
	        , clearText: ''
	        , firstDay: 1
	    });
	    
	    LoadCaptcha()
            
        function LoadCaptcha()
        {
            var img = $("#captcha img").attr("src");
            $("#captcha img").attr("src", "<%= url %>" + "/" + img);
        }
        
	    $("#<%= txtShipTime.ClientID %>").timePicker({step:30, startTime:"08:00", endTime:"22:00"});
    });
</script>

