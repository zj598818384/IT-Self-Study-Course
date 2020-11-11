<%@ Page Language="C#" AutoEventWireup="true" CodeFile="练习006：一个简单的信息录入界面.aspx.cs" Inherits="练习006_一个简单的信息录入界面" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        输入姓名：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        选择性别：<asp:RadioButton ID="RadioButton2" runat="server"  Text="男"/>
       <asp:RadioButton ID="RadioButton1" runat="server" Text="女"/>
        <br />
        选择班级：<asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>一班</asp:ListItem>
            <asp:ListItem>二班</asp:ListItem>
            <asp:ListItem>三班</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Button ID="Button1" runat="server" Text="确定" OnClick="Button1_Click"/>
        <br />
        显示结果：<asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" Width="329px"></asp:TextBox>
    </div>
    </form>
</body>
</html>
