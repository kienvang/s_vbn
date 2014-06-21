<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true"
    CodeFile="ProductRegisterDetail.aspx.cs" Inherits="Admin_Registers_ProductRegisterDetail"
    Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" runat="Server">
    <table width="100%">
        <tr>
            <td width="150px">
                <b>Tên sản phẩm</b>
            </td>
            <td>
                :&nbsp;<asp:Label ID="lblProductName" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <b>Tên công ty</b>
            </td>
            <td>
                :&nbsp;<asp:Label ID="lblCompanyName" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <b>Số điện thoại</b>
            </td>
            <td>
                :&nbsp;<asp:Label ID="lblCompanyPhone" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <b>Địa chỉ email</b>
            </td>
            <td>
                :&nbsp;<asp:Label ID="lblCompanyEmail" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <b>Mã số thuế</b>
            </td>
            <td>
                :&nbsp;<asp:Label ID="lblCompanyNumberTax" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <b>Địa chỉ</b>
            </td>
            <td>
                :&nbsp;<asp:Label ID="lblCompanyAddress" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <b>Ghi chú</b>
            </td>
            <td>
                :&nbsp;<asp:Label ID="lblNote" runat="server"></asp:Label>
            </td>
        </tr>
        <tr height="24px">
            <td colspan="2">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                <b>Hình ảnh</b>
            </td>
            <td>
                <asp:Image ID="img" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <b>Giá bán cho VBN</b>
            </td>
            <td>
                :&nbsp;<asp:Label ID="lblPriceBuy" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <b>Giá đề nghị bán</b>
            </td>
            <td>
                :&nbsp;<asp:Label ID="lblPriceSell" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <b>Số lượng</b>
            </td>
            <td>
                :&nbsp;<asp:Label ID="lblQuantity" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <b>Thông tin tóm tắt</b>
            </td>
            <td>
                :&nbsp;<asp:Label ID="lblAbstract" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <b>Thông tin bảo hành</b>
            </td>
            <td>
                :&nbsp;<asp:Label ID="lblWarranty" runat="server"></asp:Label>
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
                <div>
                    <asp:Label ID="lblDetail" runat="server"></asp:Label>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <b></b>
            </td>
            <td>
                <asp:Button ID="btnSubmit" runat="server" Text="Đăng ký" 
                    onclick="btnSubmit_Click" Visible="false" />
                <asp:Button ID="btnDelete" runat="server" Text="Xóa" 
                    onclick="btnDelete_Click" Visible="false" OnClientClick="return confirm('Xác nhận xóa ?')" />
                <asp:Button ID="btnCancel" runat="server" Text="Quay ra" 
                    onclick="btnCancel_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
