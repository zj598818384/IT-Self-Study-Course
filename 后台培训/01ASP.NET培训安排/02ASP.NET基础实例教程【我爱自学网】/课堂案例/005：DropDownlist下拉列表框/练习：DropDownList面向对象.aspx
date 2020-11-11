<%@ Page Language="C#" AutoEventWireup="true" CodeFile="练习：DropDownList面向对象.aspx.cs" Inherits="练习_DropDownList面向对象" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true">
            <asp:ListItem Value="http://www.baidu.com">百度</asp:ListItem>
            <asp:ListItem Value="http://www.2345.com">2345导航</asp:ListItem>
            <asp:ListItem Value="http://www.taobao.com">淘宝</asp:ListItem>
            <asp:ListItem Value="http://www.qq.com">腾讯QQ</asp:ListItem>
        </asp:DropDownList>
    <div>
        <asp:Button ID="btngo" runat="server" Text="go>" OnClick="btngo_Click"/>
        <asp:Button ID="change" runat="server" Text="改变" OnClick="change_Click" />
        <asp:Button ID="addnew" runat="server" Text="新增" OnClick="addnew_Click" />
        <asp:Button ID="gengai" runat="server" Text="更改" OnClick="gengai_Click" />
        <asp:Panel ID="Panel1" runat="server" Height="68px"></asp:Panel>
    </div>
    </form>
</body>
</html>
