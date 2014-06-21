<%@ Page Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="Admin_Banner_Default" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" runat="Server">
    <div class="viet-blog box58">
        <div class="box58-container">
            <h2 class="a14 forecolor-01">
                Thông Tin Logo</h2>
            <div class="body" style="padding: 10px 0 10px 0; font-size: 11px; font-family: Verdana">
                <div>
                    <asp:FileUpload ID="fileLogo" runat="server" />
                    <asp:Button ID="btnLogo" runat="server"
                        Text="Cập nhật" onclick="btnLogo_Click" />
                </div>
            </div>
        </div>
    </div>
    <div class="viet-blog box58">
        <div class="box58-container">
            <h2 class="a14 forecolor-01">
                Thông Tin Banner</h2>
            <div class="body" style="padding: 10px 0 10px 0; font-size: 11px; font-family: Verdana">
                <div>
                    <asp:FileUpload ID="fileBanner" runat="server" />
                    <asp:Button ID="btnBanner" runat="server"
                        Text="Cập nhật" onclick="btnBanner_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
