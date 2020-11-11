<%@ Page Language="C#" AutoEventWireup="true" CodeFile="练习005：拆分字符.aspx.cs" Inherits="练习005_拆分字符" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server" Text="1212121212"></asp:TextBox>
        <asp:Button ID="btn1" runat="server" Text="拆分" OnClick="btn1_Click"/>
        <br />
        <asp:TextBox ID="txt2" runat="server" TextMode="MultiLine"></asp:TextBox>
    </div>
    </form>
</body>
</html>
