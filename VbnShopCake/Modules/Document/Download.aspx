<%@ Page Language="C#" MasterPageFile="~/MasterPage-2col.master" AutoEventWireup="true"
    CodeFile="Download.aspx.cs" Inherits="Modules_Document_Control_Download" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" runat="Server">

    <script type="text/javascript">
    $(document).ready(function(){
        var t=$('#time').attr('total');
        var id=$('#time').attr('intid');
        $('#time').countdown({until: t, format: 'HMS', onTick: everyFive, tickInterval: 1, onExpiry: download}); 
        function everyFive(periods) 
        {
            $("#divtime").text(periods[4] + ':' + twoDigits(periods[5]) + 
            ':' + twoDigits(periods[6]));  
        }
        function download()
        {
            window.location=location.href+"&down=1";
        }
    });
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Holder_Left" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Holder_Content" runat="Server">
    <span style="font-size: 13px; font-weight: bold">Vui lòng chờ , tài liệu sẽ tự động tải sau 15s, nếu không tự tải, vui lòng bấm 
    <asp:LinkButton ID="lnkDown" runat="server" onclick="lnkDown_Click" OnClientClick="return confirm('Bạn có chắc chắn muốn tải tài liệu này?')">vào đây</asp:LinkButton>
        <div id="time" total='15' class="hide" intid='<%= IntId %>'>
        </div>
        <div id="divTime">
        </div>
    </span>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Footer" runat="Server">
</asp:Content>
