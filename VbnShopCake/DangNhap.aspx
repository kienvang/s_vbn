<%@ Page Language="C#" MasterPageFile="~/MasterPage-2col.master" AutoEventWireup="true"
    CodeFile="DangNhap.aspx.cs" Inherits="DangNhap" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Left" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Holder_Content" runat="Server">
    <div style="width: 300px; margin: 0 auto">
        <asp:Login ID="Login1" runat="server" 
            FailureText="Đăng nhập không thành công. Vui lòng thử đăng nhập lại" 
            LoginButtonText="Đăng Nhập" onloggedin="Login1_LoggedIn" 
            PasswordLabelText="Mật Khẩu :" PasswordRequiredErrorMessage="Nhập mật khẩu" 
            RememberMeText="Nhớ cho lần đăng nhập tiếp" UserNameLabelText="Tên đăng nhập :" 
            UserNameRequiredErrorMessage="Nhập tên đăng nhập." Width="300px">
        </asp:Login>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
