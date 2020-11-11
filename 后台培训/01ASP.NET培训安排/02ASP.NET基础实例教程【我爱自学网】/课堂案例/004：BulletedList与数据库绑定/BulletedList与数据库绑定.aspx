<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BulletedList与数据库绑定.aspx.cs" Inherits="BulletedList与数据库绑定" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div >
        <asp:BulletedList ID="BulletedList1" runat="server" DisplayMode="HyperLink" meta:resourcekey="BulletedList1Resource1" CssClass="style1">
            <asp:ListItem meta:resourcekey="ListItemResource1" Value="http://www.baidu.com">苹果</asp:ListItem>
            <asp:ListItem meta:resourcekey="ListItemResource2" Value="http://www.360.com">梨子</asp:ListItem>
            <asp:ListItem meta:resourcekey="ListItemResource3" Value="http://www.2345.com">香蕉</asp:ListItem>
            <asp:ListItem meta:resourcekey="ListItemResource4" Value="http://www.taobao.com">草莓</asp:ListItem>
        </asp:BulletedList>
    </div>
    </form>
</body>
</html>
