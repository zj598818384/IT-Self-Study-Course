<%@ Page Language="C#" AutoEventWireup="true" CodeFile="练习002：页面加载自动选中第一个复选框.aspx.cs" Inherits="练习002_页面加载自动选中第一个复选框" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:CheckBox ID="CheckBox1" runat="server" Text="自动选中" />
        <asp:CheckBox ID="CheckBox2" runat="server" Text="非自动选中" />
    </div>
    </form>
</body>
</html>
