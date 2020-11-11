<%@ Page Language="C#" AutoEventWireup="true" CodeFile="实现计算器效果.aspx.cs" Inherits="实现计算器效果" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>基于事件+控件实现计算器</title>
</head>
<body>
    <%--server告知服务器处理--%>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>+<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>=<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="计算"  OnClick="Button1_Click"/><br>
            <%-- 定义 --%>
            <%string into = "我在这里学习asp.net呢"; %>
            <%-- 输出 --%>
            <%=into %>
        </div>
        
    </form>
</body>
</html>
        