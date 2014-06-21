<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ListDocument.ascx.cs"
    Inherits="Modules_Document_Control_ListDocument" %>
<%@ Register src="TopDown.ascx" tagname="TopDown" tagprefix="uc1" %>
<%@ Register src="TopNew.ascx" tagname="TopNew" tagprefix="uc2" %>

<uc1:TopDown ID="TopDown1" runat="server" />
<uc2:TopNew ID="TopNew1" runat="server" />

<%--<style>
    .image, .info
    {
        float: left;
        height: 135px;
        width: 107px;
        margin-bottom: 25px;
    }
    .info
    {
        width: 133px;
        margin-right: 10px;
    }
    .name, .description .down
    {
        clear: both;
        height: 50px;
    }
    .description
    {
        height: 50px;
    }
    .down
    {
        height: 35px;
    }
</style>
<div class="listProducts">
    <h2>
        Tài liệu được tải nhiều nhất</h2>
    <asp:DataList ID="listTopDown" runat="server" RepeatColumns="3">
        <ItemTemplate>
            <div class="image">
                <img src='<%# int.Parse(Eval("DisplayType").ToString())==1 ? "/img/icons/document.png" : "/img/icons/video.png" %>'
                    alt='<%# Eval("DocumentName") %>' title='<%# Eval("DocumentName") %>' />
            </div>
            <div class="info">
                <div class="name">
                    <b /><a href='#' style="font">
                        <%# Eval("DocumentName") %></a></b>
                </div>
                <div class="description">
                    <b>Mô tả:</b>
                    <%# SplitString(Eval("Description").ToString()) %>
                </div>
                <div class="down">
                    <asp:ImageButton ID="btDown" runat="server" ImageUrl="/img/icons/download.jpg" />
                </div>
            </div>
        </ItemTemplate>
    </asp:DataList>
</div>
<div style="clear: both; margin-bottom: 20px">
    <a href='#' style="float: right">Xem thêm</a>
</div>
<div class="listProducts">
    <h2>
        Tài liệu mới đăng</h2>
    <asp:DataList ID="ListDown" runat="server" RepeatColumns="3">
        <ItemTemplate>
            <div class="image">
                <img src='<%# int.Parse(Eval("DisplayType").ToString())==1 ? "/img/icons/document.png" : "/img/icons/video.png" %>'
                    alt='<%# Eval("DocumentName") %>' title='<%# Eval("DocumentName") %>' />
            </div>
            <div class="info">
                <div class="name">
                    <b /><a href='#' style="font">
                        <%# Eval("DocumentName") %></a></b>
                </div>
                <div class="description">
                    <b>Mô tả:</b>
                    <%# SplitString(Eval("Description").ToString()) %>
                </div>
                <div class="down">
                    <a href='#'>
                        <img src="/img/icons/download.jpg" title="Nhấn để tải về" /></a></div>
            </div>
        </ItemTemplate>
    </asp:DataList>
</div>
<div style="clear: both; margin-bottom: 20px">
    <a href='#' style="float: right">Xem thêm</a>
</div>--%>
