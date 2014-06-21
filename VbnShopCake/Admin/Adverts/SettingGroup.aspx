<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true"
    CodeFile="SettingGroup.aspx.cs" Inherits="Admin_Adverts_SettingGroup" Title="Nhóm quảng cáo" %>

<%@ Register Src="Controls/Menu.ascx" TagName="Menu" TagPrefix="uc1" %>
<%@ Register Src="../../Modules/Controls/BoxImageFlash2.ascx" TagName="BoxImageFlash2"
    TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" runat="Server">
    <uc1:Menu ID="Menu1" runat="server" />
    <h2>
        Tên nhóm :
        <asp:Label ID="lblGroupName" runat="server"></asp:Label>
    </h2>
    Cao
    <asp:TextBox ID="txtHeight" runat="server" Width="40px"></asp:TextBox>
    Rộng
    <asp:TextBox ID="txtWidth" runat="server" Width="40px"></asp:TextBox>
    <asp:Button ID="btnGroup" runat="server" Text="Cập nhật" ValidationGroup="group"
        OnClick="btnGroup_Click" />
    <div style="margin-top: 15px">
        <table border="1" class="grid">
            <tr>
                <th width="30px">
                    STT
                </th>
                <th>
                    Tên quảng cáo
                </th>
                <th width="120px">
                </th>
                <th width="60px">
                </th>
                <th width="50px">
                    Hiển thị
                </th>
            </tr>
            <asp:Repeater ID="repAdvert" runat="server" OnItemCommand="repAdvert_ItemCommand">
                <ItemTemplate>
                    <tr class="row">
                        <td align="center">
                            <%# Container.ItemIndex + 1 %>
                        </td>
                        <td>
                            <%# Eval("AdvertName") %>
                        </td>
                        <td align="center">
                            <uc2:BoxImageFlash2 ID="BoxImageFlash21" runat="server" FWidth="120" FHeight="100" AdvertId='<%# Eval("Id") %>'/>
                        </td>
                        <td align="center">
                            <%# Eval("Type") %>
                        </td>
                        <td align="center">
                            <asp:LinkButton ID="lk" runat="server" CommandName="setting" CommandArgument='<%# Eval("Id") %>'>
                                <img src='<%# bool.Parse(Eval("IsSetting").ToString()) ? "/img/icons/checked.gif" : "/img/icons/unchecked.gif" %>' />
                            </asp:LinkButton>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
