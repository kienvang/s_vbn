<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Login.ascx.cs" Inherits="ControlsHome_Login" %>
<%@ Import Namespace="Modules.Role" %>
<div class="profile">
    <h6>
        Xin chào
        <asp:LoginName ID="LoginName1" runat="server" />
    </h6>
    <p class="marginT5">
        <% if (CheckRoles.CreateInstant().IsRoles(EnumsRoles.Administrator))
           { %>
        <a href="/Admin/" title="Quản Trị">Quản Trị</a><br />
        <%} %>
        <asp:LoginStatus ID="LoginStatus1" runat="server" LogoutText="Thoát" LoginText="Đăng nhập"
            OnLoggedOut="LoginStatus1_LoggedOut" />
            <asp:HyperLink ID="lk" runat="server" ToolTip="Đăng ký" NavigateUrl="http://dangnhap.vbn.vn/Dangky.aspx">Đăng ký</asp:HyperLink>
        <%--<a title="Thoát" href="#" class="button">Thoát</a>--%>
    </p>
    <fieldset>
        <%if (string.IsNullOrEmpty(Library.Tools.Util.CurrentUserName))
          { %>
        <a href="<%= Modules.Role.CheckRoles.CreateInstant().GetUrlDirect(Request.RawUrl) %>"
            title="Đăng nhập">Đăng nhập</a>
        <%} %>
    </fieldset>
</div>
