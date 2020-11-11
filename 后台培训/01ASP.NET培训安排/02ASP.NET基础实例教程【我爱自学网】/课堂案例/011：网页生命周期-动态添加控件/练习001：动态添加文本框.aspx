<%@ Page Language="C#" AutoEventWireup="true" CodeFile="练习001：动态添加文本框.aspx.cs" Inherits="练习001_动态添加文本框" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txt_num" runat="server" ></asp:TextBox>
        <asp:Button ID="btn1" runat="server" Text="添加文本框" OnClick="btn1_Click"/>
        <asp:Button ID="Button1" runat="server" Text="添加文本框1" OnClick="Button1_Click"/>
        <br />
        <asp:Panel ID="panel1" runat="server"></asp:Panel>
    </div>
    </form>
</body>
</html>
