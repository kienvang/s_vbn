<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true"
    CodeFile="AddEditAdvert.aspx.cs" Inherits="Admin_Adverts_AddEditAdvert" Title="Untitled Page" %>

<%@ Register Src="Controls/Menu.ascx" TagName="Menu" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" runat="Server">
    <uc1:Menu ID="Menu1" runat="server" />
    <h2>
        <asp:Label ID="lblStatus" runat="server"></asp:Label>
    </h2>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="error" />
    Left : width = 195px, Top : width = 750px
    <table width="100%">
        <tr>
            <td>
                <table width="100%" cellpadding="2" cellspacing="2">
                    <tr>
                        <td width="120px">
                            <b>Tên quảng cáo</b>
                        </td>
                        <td>
                            :&nbsp;<asp:TextBox ID="txtAdvertName" runat="server" Width="400px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtAdvertName"
                                Display="Dynamic" ErrorMessage="Nhập tên quảng cáo">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <b>Bắt đầu</b>
                        </td>
                        <td>
                            :&nbsp;<asp:TextBox ID="txtBeginDate" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtBeginDate"
                                Display="Dynamic" ErrorMessage="Nhập ngày bắt đầu">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <b>Kết thúc</b>
                        </td>
                        <td>
                            :&nbsp;<asp:TextBox ID="txtEndDate" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtEndDate"
                                Display="Dynamic" ErrorMessage="Nhập ngày kết thúc">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <b>Loại</b>
                        </td>
                        <td>
                            :
                            <asp:DropDownList ID="ddlType" runat="server">
                                <asp:ListItem Value="" Selected="True">Chọn loại file</asp:ListItem>
                                <asp:ListItem Value="IMAGE">Hình ảnh</asp:ListItem>
                                <asp:ListItem Value="FLASH">Flash</asp:ListItem>
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="ddlType"
                                Display="Dynamic" ErrorMessage="Chọn loại file">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Kích thước
                        </td>
                        <td>
                            :
                            Rộng : <asp:TextBox ID="txtWidth" runat="server"></asp:TextBox>
                            &nbsp;&nbsp;-&nbsp;&nbsp;
                            Cao : <asp:TextBox ID="txtHeight" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <b>File</b>
                        </td>
                        <td>
                            :&nbsp;<asp:FileUpload ID="fileLoad" runat="server" />
                            <asp:RequiredFieldValidator ID="reqFile" runat="server" ControlToValidate="fileLoad"
                                Display="Dynamic" ErrorMessage="Chọn file">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <b>Địa chỉ trang web</b>
                        </td>
                        <td>
                            :&nbsp;<asp:TextBox ID="txtAddressUrl" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtAddressUrl"
                                Display="Dynamic" ErrorMessage="Nhập địa chỉ trang web">*</asp:RequiredFieldValidator>
                            &nbsp;http://
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <b>Hiển thị</b>
                        </td>
                        <td>
                            :&nbsp;<asp:CheckBox ID="chkIsVisible" runat="server" Text="Thiết lập hiển thị" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <b></b>
                        </td>
                        <td>
                            <asp:Button ID="btnAdd" runat="server" Text="Thêm" OnClick="btnAdd_Click" />
                            <asp:Button ID="btnEdit" runat="server" Text="Cập nhật" Visible="false" OnClick="btnEdit_Click" />
                            <asp:Button ID="btnDelete" runat="server" Text="Xóa" ValidationGroup="del" Visible="false"
                                OnClick="btnDelete_Click" />
                            <asp:Button ID="btnCancel" runat="server" Text="Quay ra" ValidationGroup="cancel"
                                OnClick="btnCancel_Click" />
                        </td>
                    </tr>
                </table>
            </td>
            <td>
                <asp:Image ID="Image1" runat="server" Width="200px" Visible="false" />
            </td>
        </tr>
    </table>

    <script type="text/javascript">
	    $(function() {
		    $("#<%= txtBeginDate.ClientID %>").datepicker({
		        showOn: 'both'
		        , buttonImage: '/img/button/calendar-up.gif'
		        , buttonImageOnly: true
		        , dateFormat: 'dd/mm/yy'
		        , clearText: ''
		        , firstDay: 1
		    });
		    
		    $("#<%= txtEndDate.ClientID %>").datepicker({
		        showOn: 'both'
		        , buttonImage: '/img/button/calendar-up.gif'
		        , buttonImageOnly: true
		        , dateFormat: 'dd/mm/yy'
		    });
		    
		   
	    });
    </script>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
