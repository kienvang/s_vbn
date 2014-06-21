<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EditProduct.ascx.cs" Inherits="Admin_Products_Controls_EditProduct" %>
<%@ Register Src="../../Catalog/Controls/GetCatalogs.ascx" TagName="GetCatalogs"
    TagPrefix="uc1" %>
<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
<div>
    <h2>
        Cập Nhật Sản Phẩm
    </h2>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="error" />
    <asp:CustomValidator ID="valProducts" runat="server" ErrorMessage="CustomValidator"
        OnServerValidate="valProducts_ServerValidate" Display="None"></asp:CustomValidator>
    <table width="100%">
        <tr valign="top">
            <td width="120px">
                <b>Tên sản phẩm</b>
            </td>
            <td width="20px">
                :
            </td>
            <td>
                <asp:TextBox ID="txtProductName" runat="server" Width="250px"></asp:TextBox>
                <asp:RequiredFieldValidator ControlToValidate="txtProductName" ID="RequiredFieldValidator1"
                    runat="server" ErrorMessage="Nhập tên sản phẩm" Display="Dynamic" Text="*"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr valign="top">
            <td width="120px">
                <b>Danh mục</b>
            </td>
            <td width="20px">
                :
            </td>
            <td>
                <div style="width: 550px">
                    <uc1:GetCatalogs ID="ucCatalogs" runat="server" />
                </div>
            </td>
        </tr>
        <tr valign="top">
            <td width="120px">
                <b>Hình sản phẩm</b>
            </td>
            <td width="20px">
                :
            </td>
            <td>
                <asp:FileUpload ID="fileThumbnail" runat="server" />
                <asp:Image ID="img" runat="server" ImageAlign="Top" />
            </td>
        </tr>
        <tr valign="top">
            <td width="120px">
                <b>Nhà cung cấp</b>
            </td>
            <td width="20px">
                :
            </td>
            <td>
                <asp:DropDownList ID="ddlSuppliers" runat="server" Width="250px" AppendDataBoundItems="true">
                    <asp:ListItem Value="-1">Chọn nhà cung cấp</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ControlToValidate="ddlSuppliers" InitialValue="-1" ID="RequiredFieldValidator3"
                    runat="server" ErrorMessage="Chọn nhà cung cấp" Text="*" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr valign="top">
            <td width="120px">
                <b>Tóm tắt</b>
            </td>
            <td width="20px">
                :
            </td>
            <td>
                <asp:TextBox ID="txtAbstract" runat="server" TextMode="MultiLine" Width="550px"></asp:TextBox>
            </td>
        </tr>
        <tr valign="top">
            <td width="120px">
                <b>Chế độ bảo hành</b>
            </td>
            <td width="20px">
                :
            </td>
            <td>
                <asp:TextBox ID="txtWarranty" runat="server" TextMode="MultiLine" Width="550px"></asp:TextBox>
            </td>
        </tr>
        <tr valign="top">
            <td width="120px">
                <b>Thông tin chi tiết</b>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <FCKeditorV2:FCKeditor ID="txtDetail" runat="server" ToolbarSet="MyToolbar" Width="700px"
                    Height="300px">
                </FCKeditorV2:FCKeditor>
                <%--<asp:TextBox ID="txtDetail" runat="server" TextMode="MultiLine" Width="700px" Height="300px"></asp:TextBox>--%>
            </td>
        </tr>
        <tr valign="top">
            <td colspan="3">
            </td>
        </tr>
        <tr valign="top">
            <td width="120px">
            </td>
            <td colspan="2">
                <asp:Button ID="btnEdit" runat="server" Text="Cập nhật" OnClick="btnEdit_Click" />
                <asp:Button ID="btnDelete" runat="server" Text="Xóa" OnClick="btnDelete_Click" OnClientClick="return confirm('Xác nhận xóa ?')" />
                <asp:Button ID="btnCancel" runat="server" Text="Hủy cập nhật" OnClick="btnCancel_Click" />
            </td>
        </tr>
    </table>
</div>
