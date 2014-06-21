<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true"
    CodeFile="AddEditVideo.aspx.cs" Inherits="Admin_Videos_AddEditVideo" Title="Add - Edit Videos"
    ValidateRequest="false" %>

<%@ Register Src="Controls/Menu.ascx" TagName="Menu" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" runat="Server">
    <uc1:Menu ID="Menu1" runat="server" />
    <h2>
        <asp:Label ID="lblStatus" runat="server"></asp:Label>
    </h2>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="error" />
    <div>
        <table width="100%">
            <tr>
                <td width="120px">
                    <b>Tên video</b>
                </td>
                <td>
                    :&nbsp;<asp:TextBox ID="txtVideoName" runat="server" Width="400px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtVideoName"
                        Display="Dynamic" ErrorMessage="Nhập tên video">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <b>Loại video</b>
                </td>
                <td>
                    :&nbsp;<asp:DropDownList ID="ddlCatalog" runat="server" AppendDataBoundItems>
                        <asp:ListItem Value="">Chọn loại video</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="ddlCatalog"
                        Display="Dynamic" ErrorMessage="Chọn loại video">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <b>Hình đại diện</b>
                </td>
                <td>
                    :&nbsp;<asp:FileUpload ID="fileThumbnail" runat="server" />
                    <asp:Image ID="img" runat="server" ImageAlign="Middle" Visible="false" />
                </td>
            </tr>
            <tr>
                <td>
                    <b>Loại</b>
                </td>
                <td>
                    :
                    <asp:DropDownList ID="ddlVideoType" runat="server" AppendDataBoundItems="false" Width="250px"
                        AutoPostBack="True" OnSelectedIndexChanged="ddlVideoType_SelectedIndexChanged">
                        <asp:ListItem Value="">Chọn loại video</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr id="tdUpload" runat="server">
                <td>
                    <b>Chọn file</b>
                </td>
                <td>
                    :&nbsp;<asp:FileUpload ID="fileUpload" runat="server" />
                    <asp:RequiredFieldValidator ID="reqVideo" runat="server" ControlToValidate="fileUpload"
                        Display="Dynamic" ErrorMessage="Chọn file video">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr id="tdOjectType" runat="server">
                <td>
                    <b>Loại liên kết</b>
                </td>
                <td>
                    :&nbsp;<asp:DropDownList ID="ddlOjectType" runat="server">
                        <asp:ListItem Value="URL" Selected="True">URL</asp:ListItem>
                        <asp:ListItem Value="EMBED">Embeb</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr id="tdCodeEmbeb" runat="server">
                <td>
                    <b>Code</b>
                </td>
                <td>
                    :&nbsp;<asp:TextBox ID="txtCodeEmbeb" runat="server" TextMode="MultiLine" Width="400px"
                        Height="150px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="reqCodeEmbeb" runat="server" ControlToValidate="txtCodeEmbeb"
                        Display="Dynamic" ErrorMessage="Nhập Url hoặc Embeb">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <b>Hiển thị</b>
                </td>
                <td>
                    :&nbsp;<asp:CheckBox ID="chkIsVisibleHome" runat="server" Text="Hiển thị trên trang chủ" />
                </td>
            </tr>
            <tr>
                <td>
                    <b>Tự động chạy</b>
                </td>
                <td>
                    :&nbsp;<asp:CheckBox ID="chkAutoStart" runat="server" Text="Tự động chạy" />
                </td>
            </tr>
            <tr>
                <td>
                    <b>Mô tả</b>
                </td>
                <td>
                    :&nbsp;<asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Width="400px"
                        Height="250px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <b></b>
                </td>
                <td>
                    <asp:Button ID="btnAdd" runat="server" Text="Thêm" OnClick="btnAdd_Click" />
                    <asp:Button ID="btnEdit" runat="server" Text="Cập nhật" Visible="false" OnClick="btnEdit_Click" />
                    <asp:Button ID="btnDelete" runat="server" Text="Xóa" Visible="false" ValidationGroup="del"
                        OnClick="btnDelete_Click" OnClientClick="return confirm('Xác nhận xóa?')" />
                    <asp:Button ID="btnCancel" runat="server" Text="Quay ra" ValidationGroup="cancel"
                        OnClick="btnCancel_Click" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
