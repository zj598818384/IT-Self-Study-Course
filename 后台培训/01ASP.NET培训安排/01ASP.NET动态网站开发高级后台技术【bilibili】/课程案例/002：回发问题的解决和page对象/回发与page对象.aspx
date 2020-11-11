<%@ Page Language="C#" AutoEventWireup="true" CodeFile="回发与page对象.aspx.cs" Inherits="回发与page对象" %>
<%-- 
     Language="C#"：后台使用C#语言
    AutoEventWireup="true"：设置是否自动调用网页load事件，默认为true
    CodeFile="回发与page对象.aspx.cs"：后台文件代码
     Inherits="回发与page对象"：后台代码类
     --%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /><br />
        <asp:Button ID="Button1" runat="server" Text="复制到第二个文本框" OnClick="Button1_Click" /><br /><br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </div>
    </form>
</body>
</html>
