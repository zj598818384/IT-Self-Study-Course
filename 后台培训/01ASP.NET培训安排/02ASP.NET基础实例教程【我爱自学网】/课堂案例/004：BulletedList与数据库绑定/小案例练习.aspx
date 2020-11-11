<%@ Page Language="C#" AutoEventWireup="true" CodeFile="小案例练习.aspx.cs" Inherits="小案例练习" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        .style1{
            color:#23FF00; 
        }

        .style2{
            color:#FF00F8;
            list-style-type:circle;
        }

        .style3{
            color:#FFB200;
            list-style-type:square;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:RadioButton ID="rdo1" runat="server" Text="样式1：横向排列" AutoPostBack="true" GroupName="style" OnCheckedChanged="rdo1_CheckedChanged"/>
        <asp:RadioButton ID="rdo2" runat="server" Text="样式2：纵向排列" AutoPostBack="true" GroupName="style"  OnCheckedChanged="rdo2_CheckedChanged"/>
        <asp:RadioButton ID="rdo3" runat="server" Text="样式3：大间距纵向排列，并以超链接方式显示" OnCheckedChanged="rdo3_CheckedChanged" />
        <asp:BulletedList ID="BulletedList1" runat="server" CssClass>
            <asp:ListItem Value="http://www.baidu.com">百度</asp:ListItem>
            <asp:ListItem Value="http://www.taobao.com">淘宝</asp:ListItem>
            <asp:ListItem Value="http://www.2345.com">2345浏览器</asp:ListItem>
            <asp:ListItem Value="http://www.360.com">360浏览器</asp:ListItem>
        </asp:BulletedList>
    </div>
    </form>
</body>
</html>
