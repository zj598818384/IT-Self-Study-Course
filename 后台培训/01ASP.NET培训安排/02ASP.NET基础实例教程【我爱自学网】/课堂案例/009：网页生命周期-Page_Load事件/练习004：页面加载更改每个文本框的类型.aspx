<%@ Page Language="C#" AutoEventWireup="true" CodeFile="练习004：页面加载更改每个文本框的类型.aspx.cs" Inherits="练习004_页面加载更改每个文本框的类型" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox2" runat="server" Text="我是为空"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" Text="我是密码框"></asp:TextBox>
        <asp:TextBox ID="TextBox1" runat="server" Text="我是不能更改"></asp:TextBox>
    </div>
    </form>
</body>
</html>
