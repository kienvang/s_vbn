<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true"
    CodeFile="SettingBasic.aspx.cs" Inherits="Admin_Adverts_SettingBasic" Title="Thiết Lập Quảng Cáo" %>

<%@ Register Src="Controls/Menu.ascx" TagName="Menu" TagPrefix="uc1" %>
<%@ Register Src="../../Modules/Controls/BoxImageFlash2.ascx" TagName="BoxImageFlash2"
    TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">

    <script src="/js/jquery.numeric.js" type="text/javascript"></script>

    <script src="/Admin/js/advert.js" type="text/javascript"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" runat="Server">
    <uc1:Menu ID="Menu1" runat="server" />
    <h2>
        Thiết lập quảng cáo</h2>
    <div style="margin: 10px">
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="group" />
        <asp:CustomValidator ID="valGroup" ValidationGroup="group" Display="None" runat="server"
            ErrorMessage="CustomValidator" OnServerValidate="valGroup_ServerValidate"></asp:CustomValidator>
        <b>Trang hiển thị</b> :
        <%--<asp:DropDownList ID="ddlPosition" runat="server" AppendDataBoundItems="true" AutoPostBack="true"
            OnSelectedIndexChanged="ddlPosition_SelectedIndexChanged">
            <asp:ListItem Value="">Chọn trang hiển thị</asp:ListItem>
        </asp:DropDownList>--%>
        <select style="width:150px" class="ddlPosition">
            <option value="" >
                Chọn trang hiển thị
            </option>
            <asp:Repeater ID="repTypeParent" runat="server">
                <ItemTemplate>
                    <optgroup label='<%# Eval("PositionName") %>'>
                        <asp:Repeater ID="repType" runat="server" DataSource='<%# loadType(Eval("Id").ToString()) %>'>
                            <ItemTemplate>
                                <option value='<%# Eval("Id") %>' <%# Eval("Id").ToString() == Request["id"] ? "selected='selected'" : "" %>><%# Eval("PositionName") %> </option>
                            </ItemTemplate>
                        </asp:Repeater>
                    </optgroup>
                </ItemTemplate>
            </asp:Repeater>
        </select>
        <span id="group" runat="server" visible="false">Tên nhóm
            <asp:TextBox ID="txtGroupName" runat="server" ValidationGroup="group"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Nhập tên nhóm"
                ValidationGroup="group" Text="*" Display="Dynamic" ControlToValidate="txtGroupName"></asp:RequiredFieldValidator>
            Cao
            <asp:TextBox ID="txtHeight" runat="server" Width="40px"></asp:TextBox>
            Rộng
            <asp:TextBox ID="txtWidth" runat="server" Width="40px"></asp:TextBox>
            <asp:Button ID="btnGroup" runat="server" Text="Tạo nhóm" ValidationGroup="group"
                OnClick="btnGroup_Click" />
        </span>
    </div>
    <div>
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
                <th width="45px">
                    Vị trí
                </th>
                <th width="50px">
                    Hiển thị
                </th>
                <th width="50px">
                    Thứ tự
                </th>
                <th width="70px">
                    H x W
                </th>
                <th width="120">
                    Sắp xếp
                </th>
                <th width="40px">
                </th>
                <th width="40px">
                </th>
            </tr>
            <asp:Repeater ID="repAdvert" runat="server" OnItemCommand="repAdvert_ItemCommand">
                <ItemTemplate>
                    <tr class="row">
                        <td align="center">
                            <%# Container.ItemIndex + 1%>
                        </td>
                        <td>
                            <%# Eval("AdvertName")%>
                        </td>
                        <td align="center">
                            <uc2:BoxImageFlash2 ID="BoxImageFlash1" runat="server" FWidth="120" FHeight="100" 
                            AdvertId='<%# GetAdvertId(new Guid(Eval("Id").ToString()), Convert.ToBoolean(Eval("IsSetting")), Convert.ToBoolean(Eval("IsSingle"))) %>'/>
                        </td>
                        <td align="left">
                            <div runat="server" visible='<%# Eval("IsSetting") %>'>
                                <div class="click pos-<%# Eval("Id") %>" id='<%# Eval("Id") %>' typeid='<%# Eval("PositionTypeId")%>'>
                                    <span class='<%# Eval("Id") %>'>
                                        <%# Eval("PositionTypeId")%></span>&nbsp;<img src="/img/expand-all.gif" />
                                </div>
                                <div class="pos-<%# Eval("Id") %>" style="display: none;">
                                    <img src="/img/ajax-loader.gif" />
                                </div>
                            </div>
                        </td>
                        <td align="center">
                            <asp:LinkButton ID="lk" runat="server" CommandName='<%# bool.Parse(Eval("IsSetting").ToString()) ? "isvisible" : "setvisible" %>'
                                CommandArgument='<%# Eval("Id") %>'>
                                <img src='<%# bool.Parse(Eval("IsVisible").ToString()) ? "/img/icons/checked.gif" : "/img/icons/unchecked.gif" %>' />
                            </asp:LinkButton>
                        </td>
                        <td align="right">
                            <%# Eval("OrderIndex")%>
                        </td>
                        <td align="center">
                            <div id="Div1" runat="server" visible='<%# Eval("IsSetting") %>'>
                                <%# Eval("Height")%>
                                x
                                <%# Eval("Width")%>
                            </div>
                        </td>
                        <td>
                            <div id="ord" runat="server" visible='<%# Eval("IsSetting") %>'>
                                <asp:TextBox CssClass="numeric update" ID="txtOrder" runat="server" Text='<%# Eval("OrderIndex") %>'
                                    Width="40px"></asp:TextBox>
                                <asp:Button index="<%# Container.ItemIndex %>" CssClass="order update" ID="Button1"
                                    runat="server" Text="Sắp xếp" CommandName="order" CommandArgument='<%# Eval("Id") %>' />
                            </div>
                        </td>
                        <td align="center">
                            <div id="group" runat="server" visible='<%# !bool.Parse(Eval("IsSingle").ToString()) %>'>
                                <a href='/Admin/Adverts/SettingGroup.aspx?id=<%# Eval("Id") %>'>
                                    <img src="/img/button/Properties.png" />
                                </a>
                            </div>
                        </td>
                        <td align="center">
                            <asp:LinkButton ID="lkDel" OnClientClick="return confirm('Xác nhận xóa?')" runat="server"
                                CommandName="del" CommandArgument='<%# Eval("Id") %>' Visible='<%# Eval("IsSetting") %>'>
                                    <img src="/img/button/exit.png" />
                            </asp:LinkButton>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
    </div>
    <div id="form" title="Vị trí hiển thị quảng cáo">
        <div id="view" style="font-size: 12px; font-family: Tahoma;" isupdate="false">
        </div>
    </div>
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
