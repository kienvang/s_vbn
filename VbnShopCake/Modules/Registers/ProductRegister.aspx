<%@ Page Language="C#" MasterPageFile="~/MasterPage-2col.master" AutoEventWireup="true"
    CodeFile="ProductRegister.aspx.cs" Inherits="Modules_Registers_ProductRegister"
    Title="Untitled Page" ValidateRequest="false" %>

<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
<%@ Register Assembly="MSCaptcha" Namespace="MSCaptcha" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Left" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Holder_Content" runat="Server">
    <h2>
        Đăng Ký Bán Hàng</h2>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="error" />
    <asp:CustomValidator ID="valProduct" runat="server" ErrorMessage="CustomValidator"
        Display="None" OnServerValidate="valProduct_ServerValidate"></asp:CustomValidator>
    <table width="100%" cellpadding="2" cellspacing="2">
        <tr>
            <td width="120px">
                <b>Tên sản phẩm</b>
            </td>
            <td>
                :&nbsp;<asp:TextBox ID="txtProductName" runat="server" Width="400px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtProductName"
                    Display="Dynamic" ErrorMessage="Nhập tên sản phẩm">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <b>Tên công ty</b>
            </td>
            <td>
                :&nbsp;<asp:TextBox ID="txtCompanyName" runat="server" Width="400px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtCompanyName"
                    Display="Dynamic" ErrorMessage="Nhập tên công ty">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <b>Số điện thoại</b>
            </td>
            <td>
                :&nbsp;<asp:TextBox ID="txtCompanyPhone" runat="server" Width="250px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtCompanyPhone"
                    Display="Dynamic" ErrorMessage="Nhập số địên thoại công ty">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <b>Địa chỉ email</b>
            </td>
            <td>
                :&nbsp;<asp:TextBox ID="txtCompanyEmail" runat="server" Width="250px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtCompanyEmail"
                    Display="Dynamic" ErrorMessage="Nhập địa chỉ email">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtCompanyEmail"
                    Text="*" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                    Display="Dynamic" ErrorMessage="Địa chỉ email không đúng"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>
                <b>Mã số thuế</b>
            </td>
            <td>
                :&nbsp;<asp:TextBox ID="txtCompanyNumberTax" runat="server" Width="400px"></asp:TextBox>
                
            </td>
        </tr>
        <tr>
            <td>
                <b>Địa chỉ</b>
            </td>
            <td>
                :&nbsp;<asp:TextBox ID="txtCompanyAddress" runat="server" Width="400px" TextMode="MultiLine"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtCompanyAddress"
                    Display="Dynamic" ErrorMessage="Nhập địa chỉ công ty">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <b>Ghi chú</b>
            </td>
            <td>
                :&nbsp;<asp:TextBox ID="txtNote" runat="server" Width="400px" TextMode="MultiLine"></asp:TextBox>
                
            </td>
        </tr>
        <tr height="20px">
        <td></td>
        </tr>
        <tr>
            <td>
                <b>Thông tin tóm tắt</b>
            </td>
            <td>
                :&nbsp;<asp:TextBox ID="txtAbstract" runat="server" TextMode="MultiLine" Width="400px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <b>Hình ảnh</b>
            </td>
            <td>
                :&nbsp;<asp:FileUpload ID="fileUpload" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <b>Số lượng</b>
            </td>
            <td>
                :&nbsp;<asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtQuantity"
                    Display="Dynamic" ErrorMessage="Nhập số lượng">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ControlToValidate="txtQuantity" ValidationExpression="[\d]{0,6}"
                    ID="RegularExpressionValidator4" runat="server" ErrorMessage="Nhập số lượng là số"
                    Display="Dynamic" Text="*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>
                <b>Giá cho VBN</b>
            </td>
            <td>
                :&nbsp;<asp:TextBox ID="txtPriceBuy" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPriceBuy"
                    Display="Dynamic" ErrorMessage="Nhập giá bán cho VBN">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ControlToValidate="txtPriceBuy" ValidationExpression="[\d]{0,9}"
                    ID="RegularExpressionValidator1" runat="server" ErrorMessage="Nhập giá tiền là số"
                    Display="Dynamic" Text="*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>
                <b>Giá đề nghị bán</b>
            </td>
            <td>
                :&nbsp;<asp:TextBox ID="txtPriceSell" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtPriceSell"
                    Display="Dynamic" ErrorMessage="Nhập giá đề nghị bán">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ControlToValidate="txtPriceSell" ValidationExpression="[\d]{0,9}"
                    ID="RegularExpressionValidator2" runat="server" ErrorMessage="Nhập giá tiền là số"
                    Display="Dynamic" Text="*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>
                <b>Thông tin bảo hành</b>
            </td>
            <td>
                :&nbsp;<asp:TextBox ID="txtWarranty" runat="server" TextMode="MultiLine" Width="400px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <b>Thông tin chi tiết</b>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <FCKeditorV2:FCKeditor ID="txtDetail" runat="server" ToolbarSet="SimpleBar" Width="600px"
                    Height="300px">
                </FCKeditorV2:FCKeditor>
            </td>
        </tr>
        <tr>
            <td>
                Mã xác nhận
            </td>
            <td>
                <asp:TextBox ID="txtCaptcha" runat="server"></asp:TextBox>
                <div id="captcha">
                    <cc1:CaptchaControl ID="Captcha1" runat="server" CaptchaBackgroundNoise="Low" CaptchaLength="5"
                        CaptchaHeight="40" CaptchaWidth="150" CaptchaLineNoise="None" CaptchaMinTimeout="5"
                        CaptchaMaxTimeout="240" FontColor="#529E00" CustomValidatorErrorMessage="Vui lòng nhập mã xác nhận như trong hình" />
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <b></b>
            </td>
            <td>
                <asp:Button ID="btnSubmit" CssClass="btn" runat="server" Text="Đăng Ký" OnClick="btnSubmit_Click" />
                <asp:Button ID="btnCancel" CssClass="btn" runat="server" Text="Thoát" ValidationGroup="cancel" OnClick="btnCancel_Click" />
            </td>
        </tr>
    </table>

    <script type="text/javascript">
        $(document).ready(function(){
            LoadCaptcha()
            
            function LoadCaptcha()
            {
                var img = $("#captcha img").attr("src");
                $("#captcha img").attr("src", "<%= url %>" + "/" + img);
            }
        });
    </script>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
