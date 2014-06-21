<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DetailStore.ascx.cs" Inherits="Admin_Products_Controls_DetailStore" %>
<%@ Import Namespace="Library.Tools" %>
<div>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="store"
        CssClass="error" />
    <table width="100%">
        <tr>
            <td width="120px">
                Số lượng
            </td>
            <td>
                :
                <asp:TextBox ID="txtAmount" runat="server" ValidationGroup="store"></asp:TextBox>
                <asp:RequiredFieldValidator ControlToValidate="txtAmount" ID="reqAmount" runat="server"
                    ErrorMessage="Nhập số lượng" Text="*" Display="Dynamic" ValidationGroup="store"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ControlToValidate="txtAmount" ID="regAmount" runat="server"
                    ValidationExpression="[\d]{1,8}" ErrorMessage="Nhập chữ số" Text="*" Display="Dynamic"
                    ValidationGroup="store"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>
                Giá bán
            </td>
            <td>
                :
                <asp:TextBox ID="txtPrice" runat="server" ValidationGroup="store"></asp:TextBox>
                <asp:RequiredFieldValidator ControlToValidate="txtPrice" ID="reqPrice" runat="server"
                    ErrorMessage="Nhập giá bán" Text="*" Display="Dynamic" ValidationGroup="store"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ControlToValidate="txtPrice" ID="regPrice" runat="server"
                    ValidationExpression="[\d]{1,8}" ErrorMessage="Nhập chữ số" Text="*" Display="Dynamic"
                    ValidationGroup="store"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>
                Giá mua
            </td>
            <td>
                :
                <asp:TextBox ID="txtPoPrice" runat="server" ValidationGroup="store"></asp:TextBox>
                <asp:RequiredFieldValidator ControlToValidate="txtPoPrice" ID="reqPricePo" runat="server"
                    ErrorMessage="Nhập giá mua" Text="*" Display="Dynamic" ValidationGroup="store"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ControlToValidate="txtPoPrice" ID="regPricePo" runat="server"
                    ValidationExpression="[\d]{1,8}" ErrorMessage="Nhập chữ số" Text="*" Display="Dynamic"
                    ValidationGroup="store"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                <asp:RadioButton ID="rdoCapNhat" runat="server" Text="Cập nhật" Checked="true" GroupName="store"
                    OnCheckedChanged="rdoCapNhat_CheckedChanged" AutoPostBack="True" />
                <asp:RadioButton ID="rdoNoPrice" runat="server" Text="Không cập nhật giá" GroupName="store"
                    OnCheckedChanged="rdoNoPrice_CheckedChanged" AutoPostBack="True" />
                <asp:RadioButton ID="rdoNoAmount" runat="server" Text="Số lượng không xác định" GroupName="store"
                    OnCheckedChanged="rdoNoAmount_CheckedChanged" AutoPostBack="True" />
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                <asp:Button ID="btnAdd" runat="server" Text="Thêm" ValidationGroup="store" OnClick="btnAdd_Click" />
            </td>
        </tr>
    </table>
</div>
<div>
    <table border="1" class="grid-sub">
        <tr class="title">
            <th width="40px">
                STT
            </th>
            <th width="150px">
                Nhập
            </th>
            <th width="150px">
                Xuất
            </th>
            <th width="150px">
                Giá bán
            </th>
            <th width="150px">
                Giá mua
            </th>
            <th width="200px">
                Ngày tạo
            </th>
            <th width="150px">
                Người tạo
            </th>
        </tr>
        <asp:Repeater ID="repStore" runat="server">
            <ItemTemplate>
                <tr class="row">
                    <td align="center">
                        <%# Container.ItemIndex + 1 %>
                    </td>
                    <td align="right">
                        <%# Eval("Import") %>
                    </td>
                    <td align="right">
                        <%# Eval("Export") %>
                    </td>
                    <td align="right">
                        <%# FNumber.FormatNumber(Eval("Price")) %>
                    </td>
                    <td align="right">
                        <%# FNumber.FormatNumber(Eval("PoPrice")) %>
                    </td>
                    <td align="center">
                        <%# DateTime.Parse(Eval("CreatedDate").ToString()).ToString("dd/MM/yyyy") %>
                    </td>
                    <td>
                        <%# Eval("CreatedBy") %>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
</div>
