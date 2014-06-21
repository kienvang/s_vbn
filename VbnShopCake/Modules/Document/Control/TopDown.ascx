<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TopDown.ascx.cs" Inherits="Modules_Document_Control_TopDown" %>

<script src="/Modules/Document/js/down.js" type="text/javascript"></script>

<link href="/Modules/Document/css/Document.css" rel="stylesheet" type="text/css" />
<div class="listProducts" style="margin-top: 10px">
    <h2>
        Tài liệu được tải nhiều nhất</h2>
    <asp:DataList ID="listTopDown" runat="server" RepeatColumns="3">
        <ItemTemplate>
            <div class="display">
                <a href='<%# Modules.Document.UrlBuilder.DocumentDetail(int.Parse(Eval("IntId").ToString()),Eval("TextId").ToString())%>'>
                    <img src='<%# !string.IsNullOrEmpty(Eval("DisplayImage").ToString()) ? Eval("DisplayImage").ToString()+"?w=120&h=120&c=0" : "/img/icons/Document.png?w=120&h=120&c=0" %>'
                        title='<%# Eval("DocumentName") %>' class="image" /></a>
                <div class="title">
                    <a href='<%# Modules.Document.UrlBuilder.DocumentDetail(int.Parse(Eval("IntId").ToString()),Eval("TextId").ToString())%>'>
                        <%# Eval("DocumentName") %></a>
                </div>
                <b><u>Mô tả:</u></b>
                <%# Library.Tools.FString.SplitString(Eval("Description").ToString(),20) %>... <a
                    href='<%# Modules.Document.UrlBuilder.DocumentDetail(int.Parse(Eval("IntId").ToString()),Eval("TextId").ToString())%>'>
                    chi tiết</a>
            </div>
        </ItemTemplate>
    </asp:DataList>
</div>
<div style="clear: both">
    <% if (CountDoc >= 12)
       { %>
    <a href='<%= Modules.Document.UrlBuilder.ListAllDocument()%>' style="float: right">Xem
        thêm</a>
    <%}
       else if (CountDoc == 0)
       { %>
    <b>Chưa có tài liệu nào trong mục này</b>
    <%} %>
</div>
<div style="clear: both; margin-bottom: 10px">
</div>
