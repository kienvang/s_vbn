<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ListAdverts.ascx.cs" Inherits="Admin_Adverts_Controls_ListAdverts" %>
<%@ Register TagPrefix="avg" Namespace="Avg.Controls" Assembly="SmartPager" %>
<%@ Register Src="Menu.ascx" TagName="Menu" TagPrefix="uc1" %>
<%@ Register Src="../../../Modules/Controls/BoxImageFlash2.ascx" TagName="BoxImageFlash"
    TagPrefix="uc2" %>
<style type="text/css">
    .normal
    {
        background-color: #007DC4;
        color: #FFF;
        font-weight: bold;
        text-align: center;
    }
    .overlimit
    {
        background-color: red;
        color: #FFF;
        font-weight: bold;
        text-align: center;
    }
    .overwarming
    {
        background-color: #FFC000;
        color: #FFF;
        font-weight: bold;
        text-align: center;
    }
    .overwarming2
    {
        background: url(/img/button/warning.png) no-repeat scroll 0 0;
    }
    .overwarming2 span
    {
        display: none;
    }
</style>
<h2>
    Danh sách quảng cáo
</h2>
<asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="error" />
<asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="CustomValidator"
    Display="None"></asp:CustomValidator>
<div>
    Left : width = 195px, Top : width = 750px
    <table border="1" class="grid">
        <tr>
            <th width="30px">
                STT
            </th>
            <th>
                Tên
            </th>
            <th width="120px">
            </th>
            <th width="30px">
                Số trang
            </th>
            <th width="80px">
                Bắt đầu
            </th>
            <th width="80px">
                Kết thúc
            </th>
            <th width="30px">
                Ngày
            </th>
            <th width="50px">
                Loại
            </th>
            <th width="25px">
            </th>
            <th width="25px">
            </th>
        </tr>
        <asp:Repeater ID="repAdvert" runat="server" OnItemCommand="repAdvert_ItemCommand">
            <ItemTemplate>
                <tr class="row">
                    <td align="center">
                        <%# Container.ItemIndex + 1 %>
                    </td>
                    <td>
                    <%# getDetail(int.Parse(Eval("TotalPage").ToString()), Eval("Id").ToString(), Eval("AdvertName").ToString())%>
                    </td>
                    <td align="center">
                        <uc2:BoxImageFlash ID="BoxImageFlash1" runat="server" FWidth="120" FHeight="100" AdvertId='<%# Eval("Id") %>' />
                    </td>
                    <td align="center">
                        <%# Eval("TotalPage") %>
                    </td>
                    <td align="center">
                        <%# Convert.ToDateTime(Eval("BeginDate")).ToString("dd/MM/yyyy") %>
                    </td>
                    <td align="center">
                        <%# Convert.ToDateTime(Eval("EndDate")).ToString("dd/MM/yyyy") %>
                    </td>
                    <td align="right" class='<%# cssOver(Eval("Remain").ToString()) %>'>
                        <span>
                            <%# Eval("Remain") %>
                        </span>
                    </td>
                    <td align="center">
                        <%# Eval("Type") %>
                    </td>
                    <td align="center">
                        <a href='/Admin/Adverts/AddEditAdvert.aspx?id=<%# Eval("Id") %>'>
                            <img src="/img/button/properties.png" /></a>
                    </td>
                    <td align="center">
                        <asp:LinkButton OnClientClick="return confirm('Xác nhận xóa ?')" ID="link" runat="server"
                            CommandName="del" CommandArgument='<%# Eval("Id").ToString() + "|" + Eval("Remain").ToString() %>' ValidationGroup="del">
                                <img src="/img/button/exit.png" />
                        </asp:LinkButton>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    <avg:SmartPager ID="smartPager" runat="server" Visible="false" />
</div>
