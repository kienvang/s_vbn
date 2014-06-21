<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AddDocument.ascx.cs" Inherits="Admin_Document_Control_AddDocument" %>
<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
<%@ Register Src="DocumentMenu.ascx" TagName="DocumentMenu" TagPrefix="uc1" %>
<style>
    .name, .control
    {
        float: left;
        margin-right: 5px;
        width: 100px;
        margin-bottom: 7px;
        font-weight: bold;
    }
    .control
    {
        width: 400px;
    }
</style>

<script type="text/javascript">
    $(document).ready(function(){
        $(".numeric").numeric();
    });
</script>

<uc1:DocumentMenu ID="DocumentMenu1" runat="server" />
<h2 style="margin-bottom: 20px">
    Thêm tài liệu</h2>
<asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="valid-error" />
<asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="CustomValidator"
    Display="None" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
<div class="name">
    Tên tài liệu
</div>
<div class="control">
    <asp:TextBox ID="txtName" runat="server" Width="300px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName"
        Display="Dynamic" ErrorMessage="Nhập tên tài liệu">*</asp:RequiredFieldValidator>
</div>
<div style="clear: both">
    <div class="name">
        Nhóm tài liệu
    </div>
    <div class="control">
        <asp:DropDownList ID="ddlGroup" runat="server" AppendDataBoundItems="true">
            <asp:ListItem Value="">-Chọn nhóm tài liệu-</asp:ListItem>
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Chọn nhóm tài liệu"
            ControlToValidate="ddlGroup" Display="Dynamic">*</asp:RequiredFieldValidator>
    </div>
</div>
<div style="clear: both">
    <div class="name">
        Mô tả
    </div>
    <div class="control">
        <FCKeditorV2:FCKeditor ID="txtDescription" runat="server" Width="700px" Height="300px">
        </FCKeditorV2:FCKeditor>
        <%--<asp:TextBox ID="txtDescription" runat="server" Width="700px" TextMode="MultiLine" Height="300px"></asp:TextBox>--%>
    </div>
</div>
<div id="file" runat="server">
    <div style="clear: both">
        <div class="name">
            Chọn file
        </div>
        <div class="control">
            <table width="100%">
                <tr>
                    <td width="150px">
                        <asp:RadioButton ID="rdoUpload" runat="server" Text="Upload file" Checked="true"
                            GroupName="upload" />
                        <asp:FileUpload ID="UpLoadDocument" runat="server" />
                    </td>
                    <td>
                        <asp:RadioButton ID="rdoSelectFile" runat="server" Text="Chọn file" GroupName="upload" />
                        <asp:DropDownList ID="ddlSelectFile" runat="server" AppendDataBoundItems="true" Width="250px">
                            <asp:ListItem Value="">Chọn file</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
            </table>
        </div>
    </div>
</div>
<div id="image" runat="server">
    <div style="clear: both">
        <div class="name">
            Hình ảnh đại diện
        </div>
        <div class="control">
            <asp:FileUpload ID="UpLoadImage" runat="server" />
        </div>
    </div>
</div>
<div id="trailer" runat="server">
    <div style="clear: both">
        <div class="name">
            Video Trailer
        </div>
        <div class="control">
            <asp:FileUpload ID="UploadVideo" runat="server" />
        </div>
    </div>
</div>
<%--<div style="clear:both">
    <div class="name">
        Hướng dẫn
    </div>
    <div class="control">
        <FCKeditorV2:FCKeditor ID="txtGuide" runat="server" Width="700px" Height="300px">
        </FCKeditorV2:FCKeditor>
    </div>
</div>--%>
<div style="clear: both">
    <div class="control" style="margin-left: 105px">
        <asp:CheckBox ID="check" runat="server" Text="Cho phép hiển thị Trailer" />
    </div>
</div>
<div style="clear: both">
    <div class="name">
        Điểm
    </div>
    <div class="control">
        <asp:TextBox ID="txtMark" runat="server" Width="100px" CssClass="numeric"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Nhập điểm"
            ControlToValidate="txtMark" Display="Dynamic">*</asp:RequiredFieldValidator>
    </div>
</div>
<div style="clear: both; margin-left: 105px">
    <asp:Button ID="btAdd" runat="server" Text="Thêm" OnClick="btAdd_Click" />
</div>
