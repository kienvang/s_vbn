<%@ Page Language="C#" MasterPageFile="~/MasterPage-1col.master" AutoEventWireup="true"
    CodeFile="Default3.aspx.cs" Inherits="test_Default3" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" runat="Server">

    <script src="/js/jquery.numeric.js" type="text/javascript"></script>

    <script src="/js/jquery.contextMenu.js" type="text/javascript"></script>

    <link href="/css/jquery.contextMenu.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Content" runat="Server">
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    <div class="test">
        <div class="view">
            show
            <input type="text" />
        </div>
        <div class="view" style="display: none">
            hide
        </div>
    </div>
    <input type="button" value="show" id="btnshow" />
    <input type="button" value="hide" id="btnhide" />
    <br />
    <table width="100%" border="1">
        <tr>
            <td rowspan="2">
                Col 1
                <input type="checkbox" />
            </td>
            <td>
                Col 2
            </td>
        </tr>
        <tr>
            <td>
                Col3
            </td>
        </tr>
    </table>
    <div class="customerRow">Context Menu
    </div>
    <div class="openmenu">Context Menu 1111
    </div>
    <ul id="myMenu" class="contextMenu">
        <li class="insert"><a href="#insert">Adddsa dsadas dasdas New</a></li>
        <li class="edit"><a href="#edit">Edit ds asd sadsa </a></li>
        <li class="delete"><a href="#delete">Delete</a></li>
    </ul>

    <script type="text/javascript">
    $(document).ready(function(){
        $("#<%= TextBox1.ClientID %>").numeric();
        
        $("#btnshow").click(function(){
            $(".view").toggle(1000);
        });
        $("#btnhide").click(function(){
            $(".view").hide();
        });
        
        $(".customerRow").contextMenu(
            { menu: 'myMenu' }, 
            function(action, el, pos) { 
                contextMenuWork(action, el, pos); 
            }
        );
        
        $(".openmenu").contextMenu(
            { menu: 'myMenu', leftButton: true }, 
            function(action, el, pos) { 
                contextMenuWork(action, el.parent("tr"), pos); 
        });
    });
    </script>

</asp:Content>
