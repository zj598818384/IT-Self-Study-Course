<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListBox列表框.aspx.cs" Inherits="ListBox列表框" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListBox ID="ListBox1" runat="server" Height="246px" Width="119px" SelectionMode="Multiple">
            <asp:ListItem>薯条</asp:ListItem>
            <asp:ListItem>可乐</asp:ListItem>
            <asp:ListItem>牛奶</asp:ListItem>
            <asp:ListItem>咖啡</asp:ListItem>
            <asp:ListItem>冰淇淋</asp:ListItem>
            <asp:ListItem>火腿肠</asp:ListItem>
            <asp:ListItem>奶茶</asp:ListItem>
            <asp:ListItem>方便面</asp:ListItem>
            <asp:ListItem>香蕉</asp:ListItem>
            <asp:ListItem>苹果</asp:ListItem>
            <asp:ListItem>鸡蛋</asp:ListItem>
            <asp:ListItem>面条</asp:ListItem>
        </asp:ListBox>
        <asp:Button ID="Button1" runat="server" Text="确定" OnClick="Button1_Click"/>
        <asp:TextBox ID="TextBox1" runat="server" Width="119px" Height="246px" TextMode="MultiLine"></asp:TextBox>
    </div>
    </form>
</body>
</html>
