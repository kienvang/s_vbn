<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BreadCrumb.ascx.cs" Inherits="Modules_Document_Control_BreadCrumb" %>
<p class="marginB10">
    <a href="/" class="breadrum">Trang chủ</a>&nbsp;&nbsp;> 
    <a href='<%= Modules.Document.UrlBuilder.ListDocument() %>'class="breadrum">Tài liệu</a>&nbsp;&nbsp;>
    <asp:Repeater ID="repBreadCrumb" runat="server">
        <ItemTemplate>
            <a href='<%# Modules.Document.UrlBuilder.ListDocumentByGroup(Eval("TextId").ToString(),int.Parse(Eval("IntId").ToString()))%>'
                class="breadrum">
                <%# Eval("GroupName") %>
            </a>
        </ItemTemplate>
        <SeparatorTemplate>
            &nbsp;&nbsp;>&nbsp;&nbsp;
        </SeparatorTemplate>
    </asp:Repeater>
</p>
