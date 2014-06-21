<%@ Page Language="C#" MasterPageFile="~/MasterPage-2col.master" AutoEventWireup="true"
    CodeFile="SupplierRegister.aspx.cs" Inherits="Modules_Registers_SupplierRegister"
    Title="Untitled Page" ValidateRequest="false" %>

<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
<%@ Register Assembly="MSCaptcha" Namespace="MSCaptcha" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Left" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Holder_Content" runat="Server">
    <h2>
        Đăng Ký Nhà Cung Cấp</h2>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="error" />
    <asp:CustomValidator ID="valRegister" runat="server" ErrorMessage="CustomValidator"
        Display="None" OnServerValidate="valRegister_ServerValidate"></asp:CustomValidator>
    <table width="100%">
        <tr>
            <td width="150px">
                <b>Tên nhà cung cấp</b>
            </td>
            <td>
                :&nbsp;<asp:TextBox ID="txtSupplierName" runat="server" Width="450px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtSupplierName"
                    Display="Dynamic" ErrorMessage="Nhập tên nhà cung cấp">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <b>Loại nhà cung cấp</b>
            </td>
            <td>
                :
                <asp:DropDownList ID="ddlSupplierType" runat="server" AppendDataBoundItems="true"
                    Width="200px">
                    <asp:ListItem Value="">Chọn loại nhà cung cấp</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="ddlSupplierType"
                    Display="Dynamic" ErrorMessage="Chọn loại nhà cung cấp">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <b>Email</b>
            </td>
            <td>
                :&nbsp;<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtEmail"
                    Display="Dynamic" ErrorMessage="Nhập địa chỉ email">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail"
                    Text="*" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                    Display="Dynamic" ErrorMessage="Địa chỉ email không đúng"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>
                <b>Điện thoại</b>
            </td>
            <td>
                :&nbsp;<asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtPhone"
                    Display="Dynamic" ErrorMessage="Nhập số điện thoại">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <b>Địa chỉ</b>
            </td>
            <td>
                :&nbsp;<asp:TextBox ID="txtAddress" runat="server" Width="450px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtAddress"
                    Display="Dynamic" ErrorMessage="Nhập địa chỉ">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <b>Thông tin nhà cung cấp</b>
            </td>
            <td>
                <FCKeditorV2:FCKeditor ID="txtAboutContent" runat="server" ToolbarSet="SimpleBar"
                    Width="400px" Height="300px">
                </FCKeditorV2:FCKeditor>
            </td>
        </tr>
        <tr>
            <td>
                Mã xác nhận
            </td>
            <td>
                <asp:TextBox ID="txtCaptcha" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtCaptcha"
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
