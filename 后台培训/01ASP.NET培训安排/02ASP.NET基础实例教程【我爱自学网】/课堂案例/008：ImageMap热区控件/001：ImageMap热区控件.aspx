                                                                                                                                                    <%@ Page Language="C#" AutoEventWireup="true" CodeFile="001：ImageMap热区控件.aspx.cs" Inherits="_001_ImageMap热区控件" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <%-- 圆形热区的定义 --%>
        <asp:ImageMap ID="ImageMap1" runat="server" ImageUrl="~/img/傻滔.jpg" Width="250px" Height="400px">
            <asp:CircleHotSpot X="25" Y="25" Radius="25" NavigateUrl="http://www.baidu.com" AlternateText="百度"/>
        </asp:ImageMap>
        <%-- 方形热区定义 --%>
        <asp:ImageMap ID="ImageMap2" runat="server" ImageUrl="~/img/爱心.jpg" Width="200px" Height="200px">
                <asp:RectangleHotSpot Left="80" Top="80" NavigateUrl="http://www.sina.com" AlternateText="新浪" />
        </asp:ImageMap>
        <%-- 多边形区定义 --%>
        <asp:ImageMap ID="ImageMap3" runat="server" ImageUrl="~/img/爱心.jpg" Width="200px" Height="200px">
            <asp:PolygonHotSpot NavigateUrl="http://www.qq.com" AlternateText="qq" Coordinates="0,0,100,0,100,100" />
        </asp:ImageMap>
        <asp:Button ID="btn1" runat="server" OnClick="btn1_Click " Text="为淘宝添加最后一个热区"/>
    </div>
    </form>
</body>
</html>
