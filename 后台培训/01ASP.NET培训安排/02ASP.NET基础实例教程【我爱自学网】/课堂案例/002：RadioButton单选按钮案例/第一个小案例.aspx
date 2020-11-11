<%@ Page Language="C#" AutoEventWireup="true" CodeFile="第一个小案例.aspx.cs" Inherits="第一个小案例" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:RadioButton ID="rbth_1" runat="server"  Text="猫" GroupName="animal"/>
        <asp:RadioButton ID="rbth_2" runat="server" Text="狗"  GroupName="animal"/>
        <asp:RadioButton ID="rbth_3" runat="server" Text="鼠" GroupName="animal"/>
        <asp:RadioButton ID="rbth_4" runat="server"  Text="蛇" GroupName="animal"/><br />
        <asp:Button ID="Button1" runat="server" Text="点击" OnClick="Button1_Click" />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </div>
    </form>
</body>
</html>
