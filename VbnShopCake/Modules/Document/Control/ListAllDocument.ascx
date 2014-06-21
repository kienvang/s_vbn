<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ListAllDocument.ascx.cs"
    Inherits="Modules_Document_Control_ListAllDocument" %>

<script src="/Modules/Document/js/down.js" type="text/javascript"></script>

<%@ Register TagPrefix="avg" Namespace="Avg.Controls" Assembly="SmartPager" %>
<link href="/Modules/Document/css/Document.css" rel="stylesheet" type="text/css" />
<div class="listProducts">
    <h2>
        <asp:Label ID="lbTitle" runat="server">
        </asp:Label>
    </h2>
    <asp:DataList ID="listAll" runat="server" RepeatColumns="3">
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
<avg:SmartPager ID="smartPager" runat="server" />
