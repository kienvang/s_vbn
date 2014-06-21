<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DocumentBox.ascx.cs" Inherits="Modules_Document_Control_DocumentBox" %>
<h2>Tài liệu</h2>
<ul class="levMenu">
   <asp:Repeater ID="RepDocument" runat="server">
        <ItemTemplate>
            <li><a href='<%# Modules.Document.UrlBuilder.ListDocumentByGroup(Eval("TextId").ToString(),int.Parse(Eval("IntId").ToString()))%>'> <%# Eval("GroupName") %></a></li>
        </ItemTemplate>
   </asp:Repeater>
</ul>