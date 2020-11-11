<%@ Page Language="C#" AutoEventWireup="true" CodeFile="练习003：设置下拉框的第二项默认选中状态.aspx.cs" Inherits="练习003_设置下拉框的第二项默认选中状态" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>旅游</asp:ListItem>
            <asp:ListItem>爬山</asp:ListItem>
            <asp:ListItem>足球</asp:ListItem>
            <asp:ListItem>听歌</asp:ListItem>
        </asp:DropDownList>
    </div>
    </form>
</body>
</html>
