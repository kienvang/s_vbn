<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DetailPhotos.ascx.cs"
    Inherits="Admin_Products_Controls_DetailPhotos" %>
<div style="margin: 5px 0">
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="error" ValidationGroup="photo" />
    <asp:CustomValidator ID="valPhotos" runat="server" ErrorMessage="CustomValidator"
        Display="None" OnServerValidate="valPhotos_ServerValidate" ValidationGroup="photo"></asp:CustomValidator>
    <table width="100%">
        <tr>
            <td width="120px">
                Tên hình
            </td>
            <td>
                <asp:TextBox ID="txtPhotoName" runat="server" Width="250px" ValidationGroup="photo"></asp:TextBox>
                <%--<asp:RequiredFieldValidator ControlToValidate="txtPhotoName" ValidationGroup="photo"
                    ID="RequiredFieldValidator1" runat="server" ErrorMessage="Nhập tên hình" Display="Dynamic"
                    Text="*"></asp:RequiredFieldValidator>--%>
            </td>
        </tr>
        <tr>
            <td>
                Chọn hình
            </td>
            <td>
                <asp:FileUpload ID="uploadPhoto" runat="server" ValidationGroup="photo" />
                <asp:RequiredFieldValidator ControlToValidate="uploadPhoto" ValidationGroup="photo"
                    ID="reqPhoto" runat="server" ErrorMessage="Chọn hình ảnh" Display="Dynamic"
                    Text="*"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                <asp:Button ID="btnAddPhoto" runat="server" Text="Thêm hình" OnClick="btnAddPhoto_Click"
                    ValidationGroup="photo" />
                <asp:Button ID="btnEditPhoto" runat="server" Text="Cập nhật" ValidationGroup="photo"
                    Visible="false" onclick="btnEditPhoto_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="Hủy cập nhật"
                    Visible="false" onclick="btnCancel_Click" />
                <asp:HiddenField ID="hidStatus" runat="server" />
                <asp:HiddenField ID="hidId" runat="server" />
            </td>
        </tr>
    </table>
</div>
<div>
    <table border="1" width="100%" class="grid-sub">
        <tr class="title">
            <th width="40px">
                STT
            </th>
            <th>
                Tên Hình
            </th>
            <th width="150px">
                Hình Ảnh
            </th>
            <th width="90px">
                Hiển Thị
            </th>
            <td width="40px">
            </td>
            <td width="40px">
            </td>
        </tr>
        <asp:Repeater ID="repPhotos" runat="server" 
            onitemcommand="repPhotos_ItemCommand">
            <ItemTemplate>
                <tr>
                    <td align="center">
                        <%# Container.ItemIndex + 1 %>
                    </td>
                    <td>
                        <%# Eval("PhotoName") %>
                    </td>
                    <td align="center">
                        <img width="100px" height="80px" src='<%# Eval("Path") %>' />
                    </td>
                    <td align="center">
                        <asp:LinkButton ID="lkVisible" runat="server" CommandName="isvisible" CommandArgument='<%# Eval("Id") %>'>
                            <asp:CheckBox ID="chk" runat="server" Checked='<%# Eval("IsVisible") %>' />
                        </asp:LinkButton>
                    </td>
                    <td align="center">
                        <asp:LinkButton ID="LinkButton2" runat="server" CommandName="edit" CommandArgument='<%# Eval("Id") %>'>
                            Sữa
                        </asp:LinkButton>
                    </td>
                    <td align="center">
                        <asp:LinkButton OnClientClick="return confirm('Xác nhận xóa ?')" ID="LinkButton1" runat="server" CommandName="del" CommandArgument='<%# Eval("Id") %>'>
                            Xóa
                        </asp:LinkButton>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
</div>
