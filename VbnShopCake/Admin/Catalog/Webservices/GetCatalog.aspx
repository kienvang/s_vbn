<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GetCatalog.aspx.cs" Inherits="Admin_Catalog_Webservices_GetCatalog" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="cats" runat="server">
        <div style="background-color: #F7D777; margin-bottom: 3px">
            <% if (ParentId == 0 && Request["t"] == "prev")
               { %>
            Danh mục gốc
            <%}
               else
               { %>
            <%= catParent.CatalogName %>
            <%} %>
        </div>
        <div>
            <select class="ddlCatalog" style="width: 200px">
                <asp:Repeater ID="repCatalog" runat="server">
                    <HeaderTemplate>
                        <% if (ParentId == 0 && Request["t"] == "prev")
                           { %>
                        <option value='-1|0|True|0'>Chọn danh mục gốc</option>
                        <%}
                           else
                           { %>
                        <option value='-1|<%= this.ParentId.ToString() + "|" + this.IsLeaf.ToString() + "|" + this.Id.ToString() %>'>
                            Chọn danh mục cha</option>
                        <%} %>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <option value='0|<%# Eval("ParentId").ToString() + "|" + Eval("IsLeaf").ToString() + "|" + Eval("Id").ToString() %>'>
                            <%# Eval("CatalogName") %></option>
                    </ItemTemplate>
                </asp:Repeater>
            </select>
        </div>
    </div>
    </form>
</body>
</html>
