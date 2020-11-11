<%@ Page Language="C#" AutoEventWireup="true" CodeFile="001：HyperLink链接控件.aspx.cs" Inherits="_001_HyperLink链接控件" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        .a1{
            width:70px;
            height:30px;
            border:1px solid red;
            background:#FFB200;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btn1" runat="server" OnClick="btn1_Click" Text="向panel中添加两个超链接"/>
        <br />
        <asp:Button ID="btn2" runat="server" OnClick="btn2_Click" Text="生成一个带有cssclass属性的超链接，放入panel内"/>
        <asp:Panel ID="Panel1" runat="server" Height="72px"></asp:Panel>
    </div>
    </form>
</body>
</html>
