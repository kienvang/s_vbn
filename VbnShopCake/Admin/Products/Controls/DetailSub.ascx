<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DetailSub.ascx.cs" Inherits="Admin_Products_Controls_DetailSub" %>
<div>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="error" />
    <table border="0">
        <tr>
            <td width="150px">
                <b>Tên sản phẩm</b>
            </td>
            <td>
                :&nbsp;<asp:TextBox ID="txtProductName" runat="server" Width="450px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtProductName"
                    Display="Dynamic" ErrorMessage="Nhập tên sản phẩm">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <b>Giá</b>
            </td>
            <td>
                :&nbsp;<asp:TextBox ID="txtPriceSub" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPriceSub"
                    Display="Dynamic" ErrorMessage="Nhập giá">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ValidationExpression="[\d]{0,9}"
                    runat="server" ControlToValidate="txtPriceSub" Display="Dynamic" ErrorMessage="Giá tiền phải là số">*</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>
                <b>Mô tả</b>
            </td>
            <td>
                :&nbsp;<asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Width="450px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <b></b>
            </td>
            <td>
                <asp:Button ID="btnAdd" runat="server" Text="Thêm" OnClick="btnAdd_Click" />
                <asp:Button ID="btnEdit" runat="server" Text="Cập nhật" OnClick="btnEdit_Click" Visible="false" />
                <asp:Button ID="btnDelete" runat="server" Text="Xóa" ValidationGroup="del" OnClientClick="return confirm('Xác nhận xóa ?')"
                    OnClick="btnDelete_Click" Visible="false" />
                <asp:Button ID="btnCancel" runat="server" Text="Hủy cập nhật" ValidationGroup="cancel"
                    OnClick="btnCancel_Click" Visible="false" />
                <asp:HiddenField ID="hidId" runat="server" />
            </td>
        </tr>
    </table>
</div>
<div style="margin: 10px 0">
    <table border="1" class="grid-sub" width="100%">
        <tr class="title">
            <th width="40px">
                STT
            </th>
            <th>
                Sản phẩm
            </th>
            <th width="150px">
                Giá
            </th>
            <th width="150px">
                Người tạo
            </th>
            <th width="40px">
            </th>
            <th width="40px">
            </th>
        </tr>
        <asp:Repeater ID="repSub" runat="server" OnItemCommand="repSub_ItemCommand">
            <ItemTemplate>
                <tr class="row">
                    <td align="center">
                        <%# Container.ItemIndex + 1 %>
                    </td>
                    <td>
                        <%# Eval("ProductName") %>
                    </td>
                    <td align="right">
                        <%# Library.Tools.FNumber.FormatNumber(Eval("Price")) %>
                    </td>
                    <td>
                        <%# Eval("CreatedBy") %>
                    </td>
                    <td align="center">
                        <asp:LinkButton ValidationGroup="edit" ID="LinkButton1" runat="server" CommandName="edit" CommandArgument='<%# Eval("Id") %>'>
                            <img src="/img/button/properties.png" />
                        </asp:LinkButton>
                    </td>
                    <td align="center">
                        <asp:LinkButton OnClientClick="return confirm('Xác nhận xóa ?')" ID="link" runat="server"
                            CommandName="del" CommandArgument='<%# Eval("Id") %>' ValidationGroup="del">
                            <img src="/img/button/exit.png" />
                        </asp:LinkButton>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
</div>
