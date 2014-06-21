<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EditPayment.ascx.cs" Inherits="Admin_Payment_Control_EditPayment" %>
<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
<h2>
    <asp:Label ID="lblPayName" runat="server"></asp:Label></h2>
<FCKeditorV2:FCKeditor ID="txtBody" runat="server" ToolbarSet="MyToolbar" Width="100%"
    Height="650px">
</FCKeditorV2:FCKeditor>
<div style="margin-top: 10px">
    <asp:Button ID="btnUpdate" runat="server" Text="Cập nhật" 
        onclick="btnUpdate_Click" />
    <asp:Button ID="btnCancel" runat="server" Text="Quay ra" 
        onclick="btnCancel_Click" />
</div>
