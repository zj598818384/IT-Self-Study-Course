<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListBox实现的简单点菜程序.aspx.cs" Inherits="ListBox实现的简单点菜程序" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListBox ID="ListBox1" runat="server" SelectionMode="Multiple" Height="292px" Width="170px">
            <asp:ListItem>糖醋排骨</asp:ListItem>
            <asp:ListItem>宋嫂鱼汤</asp:ListItem>
            <asp:ListItem>酸菜鱼</asp:ListItem>
            <asp:ListItem>白灼菜心</asp:ListItem>
            <asp:ListItem>烧鹅</asp:ListItem>
            <asp:ListItem>烤鸡</asp:ListItem>
            <asp:ListItem>鸭头</asp:ListItem>
            <asp:ListItem>千岛湖鱼头</asp:ListItem>
            <asp:ListItem>狗不理包子</asp:ListItem>
            <asp:ListItem>北京烤鸭</asp:ListItem>
            <asp:ListItem>油爆虾</asp:ListItem>
            <asp:ListItem>香辣鸡翅</asp:ListItem>
        </asp:ListBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text=">>>" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="<<<" OnClick="Button2_Click"/>
        <br />
        <asp:ListBox ID="ListBox2" runat="server" SelectionMode="Multiple" Height="292px" Width="170px">
        </asp:ListBox>
    </div>
    </form>
</body>
</html>
