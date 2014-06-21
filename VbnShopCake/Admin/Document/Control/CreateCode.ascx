<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CreateCode.ascx.cs" Inherits="Admin_Document_Control_CreateCode" %>
<h2>
    Quản lý thẻ nạp</h2>
<div class="border">
    <ul class="bullet-admin">
        <li class="addCode" style="cursor: pointer; width:80px">Tạo thẻ </li>
        <li class="searchCode" style="cursor: pointer; width:80px">Tìm kiếm</li>
    </ul>
</div>
<style>
    .name, .control
    {
        float: left;
        margin-right: 5px;
        width: 120px;
        margin-bottom: 7px;
        font-weight: bold;
    }
    .control
    {
        width: 400px;
    }
</style>
<asp:ValidationSummary ID="ValidationSummary1" runat="server" />

<script type="text/javascript">
    $(document).ready(function(){
        $(".numeric").numeric();
        $(".add").hide();
        
        $(".addCode").click(function(){
            $(".add").show();
            $(".search").hide();
        });
        
        $(".searchCode").click(function(){
            $(".add").hide();
            $(".search").show();
        });
        
        $(function() {
	    $("#<%= txtCreatedDate.ClientID %>").datepicker({
	        showOn: 'both'
	        , buttonImage: '/img/button/calendar-up.gif'
	        , buttonImageOnly: true
	        , dateFormat: 'dd/mm/yy'
	    });
    });
    });
</script>

<asp:CustomValidator ID="CustomValidator1" runat="server" 
    ErrorMessage="CustomValidator" Display="None"></asp:CustomValidator>
<div class="search" style="clear:both">
    <div class="name" style="width:50px">
        Ngày tạo</div>
    <div class="control" style="width:180px">
        <asp:TextBox ID="txtCreatedDate" runat="server"></asp:TextBox></div>
        
    <div class="control">
        <asp:Button ID="btSearch" runat="server" Text="Tìm kiếm" 
            ValidationGroup="search" onclick="btSearch_Click"/>
    </div>
</div>
<div class="add" style="clear: both">
    <div class="name">
        Số lượng thẻ
    </div>
    <div class="control">
        <asp:TextBox ID="txtCount" runat="server" CssClass="numeric">
        </asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCount"
            Display="Dynamic" ErrorMessage="Nhập Số lượng thẻ">*</asp:RequiredFieldValidator>
    </div>
    <div style="clear: both">
        <div class="name">
            Số điểm cho mỗi thẻ</div>
        <div class="control">
            <asp:TextBox ID="txtMark" runat="server" CssClass="numeric">
            </asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtMark"
                Display="Dynamic" ErrorMessage="Nhập số điểm cho mỗi thẻ">*</asp:RequiredFieldValidator>
        </div>
    </div>
    <div style="clear: both; margin-left: 125px; margin-bottom: 5px">
        <asp:Button ID="btAdd" runat="server" Text="Tạo thẻ" Style="clear: both" OnClick="btAdd_Click" /></div>
</div>
<div style="clear: both">
    <asp:LinkButton ID="lnkExport" runat="server" Text="Xuất ra Excel" OnClick="lnkExport_Click" ValidationGroup="export">
    
    </asp:LinkButton>
</div>
<div id="code" runat="server">
    <table class="grid">
        <thead>
            <tr>
                <th width="30px">
                    STT
                </th>
                <th width="200px">
                    Mã số
                </th>
                <th width="100px">
                    Số điểm
                </th>
                <th width="100px">
                    Ngày tạo
                </th>
                <th width="100px">
                    Tình trạng
                </th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="RepCode" runat="server">
                <ItemTemplate>
                    <tr>
                        <td align="center">
                            <%# Container.ItemIndex+1%>
                        </td>
                        <td align="center">
                            <%# Eval("code")%>
                        </td>
                        <td align="center">
                            <%# Eval("mark") %>
                        </td>
                        <td align="center">
                            <%# DateTime.Parse(Eval("CreatedDate").ToString()).ToShortDateString() %>
                        </td>
                        <td align="center">
                            <%# bool.Parse(Eval("IsDeleted").ToString()) ? "Đã sử dụng" : "Chưa sử dụng"%>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</div>
