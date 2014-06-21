<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DocumentDetail.ascx.cs"
    Inherits="Modules_Document_Control_DocumentDetail" %>

<script src="/Modules/Document/js/down.js" type="text/javascript"></script>

<%@ Register Src="../../Videos/Controls/VideoBox.ascx" TagName="VideoBox" TagPrefix="uc1" %>
<%@ Import Namespace="Modules.Document" %>
<h2>
    <asp:Label ID="lbTitle" runat="server"></asp:Label>
</h2>
<style>
    .detail
    {
        width: 450px;
        float: left;
    }
    .name
    {
        width: 100px;
        font-weight: bold;
    }
    .detail tr
    {
        height: 20px;
    }
    .CustomerInfo
    {
        float: right;
        width: 295px;
        border: solid 1px Red;
        margin-left: 5px;
    }
    .CustomerInfo tr
    {
        height: 20px;
    }
</style>
<div class="viewVideo" style="margin-bottom: 20px">
    <div class="showvideo" style="width: 600px">
        <h3>
            Videos</h3>
        <uc1:VideoBox ID="VideoBox1" runat="server" />
    </div>
</div>
<table style="clear: both" class="detail">
    <tr>
        <td class="name">
            Đánh giá
        </td>
        <td>
            <img src='<%= ReMark==0 ? "/img/icons/star0.gif" : ReMark>0 && ReMark<=DocumentConfig.star1 ? "/img/icons/1star.gif" : ReMark>DocumentConfig.star1 && ReMark<=DocumentConfig.star2 ? "/img/icons/2star.gif" : ReMark>DocumentConfig.star2 && ReMark<=DocumentConfig.star3 ? "/img/icons/3star.gif" : ReMark >DocumentConfig.star3 && ReMark<=DocumentConfig.star4 ? "/img/icons/4star.gif" : "/img/icons/5star.gif" %>'>
            <img src="/img/icons/remark.gif" style="cursor: pointer" class="mark" />
            <div class="showRemark">
                <br />
                <input value="1" type="radio" name="remark" intid='<%= IntId %>' /><img src="/img/icons/1star.gif" />
                <br />
                <input value="2" type="radio" name="remark" intid='<%= IntId %>' /><img src="/img/icons/2star.gif" />
                <br />
                <input value="3" type="radio" name="remark" intid='<%= IntId %>' /><img src="/img/icons/3star.gif" />
                <br />
                <input value="4" type="radio" name="remark" intid='<%= IntId %>' /><img src="/img/icons/4star.gif" />
                <br />
                <input value="5" type="radio" name="remark" intid='<%= IntId %>' /><img src="/img/icons/5star.gif" />
            </div>
        </td>
    </tr>
    <tr>
        <td class="name">
            Số lần tải:
        </td>
        <td>
            <asp:Label ID="lbSoLanTai" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="name">
            Dung lượng:
        </td>
        <td>
            <asp:Label ID="lbDungLuong" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="name">
            Ngày cập nhật:
        </td>
        <td>
            <asp:Label ID="lbNgayCapNhat" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="name">
            Điểm cần:
        </td>
        <td>
            <asp:Label ID="lbDiemCan" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="name">
            Xem thử:
        </td>
        <td>
            <div class="show" isshow='<%= IsShowVideo %>'>
                <%if (IsShowVideo == true)
                  { %>
                <img src="/img/icons/trial.jpg" style="cursor: pointer" /></div>
            <%}
                  else
                  { %>
            Không có
            <%} %>
        </td>
    </tr>
    <tr>
        <td class="name">
            Mô tả:
        </td>
        <td>
            <asp:Label ID="lbDescription" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="name">
            Hướng dẫn
        </td>
        <td>
            <asp:Label ID="lbGuide" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="name">
            Tải tài liệu:
        </td>
        <td>
            <% if (IsSignIn())
               { %>
            <asp:LinkButton ID="lnkDown" runat="server" OnClientClick="return confirm('Bạn thực sự muốn tải tài liệu này?')"
                OnClick="lnkDown_Click">
                        <img src="/img/icons/btnDownload.jpg" title="Nhấn để tải về" />
            </asp:LinkButton>
            <% }
               else
               { %>
            <a href="http://dangnhap.vbn.vn/Dangky.aspx" style="color: Blue">Đăng kí thành viên
                để download</a>
            Hoặc <a href="<%= Modules.Role.CheckRoles.CreateInstant().GetUrlDirect(Request.RawUrl) %>"
            title="Đăng nhập" style="color: Blue">Đăng nhập</a>
            <% } %>
        </td>
    </tr>
</table>
<div id="divInfo" runat="server">
    <table class="CustomerInfo">
        <tr>
            <td>
                <b>Số điểm hiện tại của bạn: </b>
            </td>
            <td>
                <asp:Label ID="lbMark" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <b>Lần download gần đây nhất:</b>
            </td>
            <td>
                <asp:Label ID="lbDateDownEarly" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <b>Số điểm trước khi down: </b>
            </td>
            <td>
                <asp:Label ID="lbMarkBeforeDown" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <b>Số điểm sau khi down:</b>
            </td>
            <td>
                <asp:Label ID="lbMarkAfterDown" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <b>Tài liệu:</b>
            </td>
            <td>
                <asp:Label ID="LbDoc" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</div>
<%--<div style="clear: both">
    <hr style="width: 471px; float: left" />
    <br />
    <strong>Số lần tải: </strong></asp:Label>
    <br />
    <br />
    <strong>Đánh giá: </strong><asp:Label ID="lbDanhGia" runat="server"></asp:Label>
    <br />
    <br />
    <strong>Dung lượng: </strong><asp:Label ID="lbDungLuong" runat="server"></asp:Label>
    <br />
    <br />
    <strong>Ngày cập nhật: </strong><asp:Label ID="lbNgayCapNhat" runat="server"></asp:Label>
    <br />
    <br />
    <strong>Điểm cần: </strong><asp:Label ID="lbDiemCan" runat="server"></asp:Label>
    <br />
    <br />
    <div>
    <strong>Sử dụng: </strong><div class="show"><img src="/img/icons/trial.jpg" style="cursor:pointer"/></div>
    </div>
    <br />
    <br />
    <strong>Tải tài liệu: </strong>
    <% if (IsSignIn())
       { %>
    <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='123' CommandName="down"
        OnClientClick="return confirm('Bạn thực sự muốn tải tài liệu này?')">
                        <img src="/img/icons/download.jpg" title="Nhấn để tải về" />
    </asp:LinkButton>
    <% }
       else
       { %>
    <a href="http://dangnhap.vbn.vn/Dangky.aspx" style="color: Blue">Đăng kí thành viên
        để download</a>
    <% } %>
    <br />
    <br />
    <hr style="width: 471px; float: left" />
    <br />
    <strong>Mô tả: </strong>
    <asp:Label ID="lbDescription" runat="server" style="font-size:12px"></asp:Label>
</div>--%>