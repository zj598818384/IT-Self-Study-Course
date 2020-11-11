<%@ Page Language="C#" AutoEventWireup="true" CodeFile="成绩选择.aspx.cs" Inherits="成绩选择" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:RadioButton ID="rbth_1" runat="server"  Text="不及格" GroupName="animal"/>
        <asp:RadioButton ID="rbth_2" runat="server" Text="及格"  GroupName="animal"/>
        <asp:RadioButton ID="rbth_3" runat="server" Text="良好" GroupName="animal"/>
        <asp:RadioButton ID="rbth_4" runat="server"  Text="优秀" GroupName="animal"/><br />
        <asp:Button ID="Button1" runat="server" Text="点击" OnClick="Button1_Click" />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Label ID="lblcuowu" runat="server" ForeColor="Red"></asp:Label>
        <asp:Button ID="btn" runat="server" Text="检测" OnClick="btn_Click" />
    </div>
    </form>
</body>
</html>
