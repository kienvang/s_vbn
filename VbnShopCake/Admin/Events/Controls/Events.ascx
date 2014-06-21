<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Events.ascx.cs" Inherits="Admin_Events_Controls_Events" %>
<div class="box-contain">
    <h2>
        <asp:Label ID="lblEventType" runat="server"></asp:Label></h2>
    <div class="body">
        <div style="margin: 0 5px 10px 5px; padding-top:10px">
            <asp:Repeater ID="repEvent" runat="server">
                <ItemTemplate>
                    <div id='<%# Eval("Id") %>' style="padding-bottom: 5px">
                        <div style="float: left">
                            <input type="checkbox" id='<%# Eval("Id") %>' class="event" />
                            <a href='<%# Eval("AddressUrl") %>' target="_blank">
                                <%# Library.Tools.Util.TrimString(Eval("EventName").ToString(), 30) %></a>
                        </div>
                        <div style="float: right; color: Gray; padding-top:5px">
                            <%# Convert.ToDateTime(Eval("CreatedDate")).ToString("dd/MM") %>
                        </div>
                        <div style="clear: both">
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
            <asp:Label ID="lblNote" runat="server">Chưa có sự kiện nào</asp:Label>
        </div>
    </div>
</div>
