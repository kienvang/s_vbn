<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true"
    CodeFile="AdvertSetting.aspx.cs" Inherits="Admin_Adverts_AdvertSetting" Title="Untitled Page" %>

<%@ Register Src="../../Modules/Controls/BoxImageFlash.ascx" TagName="BoxImageFlash"
    TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" runat="Server">
    <uc1:BoxImageFlash ID="BoxImageFlash21" runat="server" />
    <div style="margin:10px 0">
        <table class="grid">
            <tr>
                <th width="40px">
                </th>
                <th>
                    Quảng cáo
                </th>
                <th width="150px">
                    Trang
                </th>
                <th width="150px">
                    Vị trí
                </th>
                <th width="60px">
                </th>
            </tr>
            <asp:Repeater ID="repSetting" runat="server">
                <ItemTemplate>
                    <tr>
                        <td>
                            <%# Container.ItemIndex + 1 %>
                        </td>
                        <td>
                            <%# Eval("GroupName") %>
                        </td>
                        <td>
                            <%# Eval("PositionName") %>
                        </td>
                        <td>
                            <%# Eval("TypeName") %>
                        </td>
                        <td>
                            <%# Convert.ToBoolean(Eval("IsSingle")) ? "Đơn lẻ" : "Nhóm" %>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
    </div>
    <div>
        <asp:Button ID="btnDelete" runat="server" Text="Xóa" 
            OnClientClick="return confirm('Xác nhận xóa?')" onclick="btnDelete_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Quay ra" 
            onclick="btnCancel_Click" />
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
