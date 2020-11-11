<%@ Page Language="C#" AutoEventWireup="true" CodeFile="练习001：求和.aspx.cs" Inherits="练习001_求和" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        输入需要几个文本框：<asp:TextBox ID="txtnum" runat="server"></asp:TextBox>
        <asp:Button ID="btn1" runat="server" Text="创建文本框组" /><br />
        <asp:Panel ID="panel" runat="server"></asp:Panel>
        <asp:Button ID="btnsum" runat="server" Text="求和" OnClick="btnsum_Click"/>
    </div>
    </form>
</body>
</html>
