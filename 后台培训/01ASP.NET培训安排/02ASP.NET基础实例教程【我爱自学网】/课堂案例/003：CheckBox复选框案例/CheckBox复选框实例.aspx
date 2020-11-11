<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CheckBox复选框实例.aspx.cs" Inherits="CheckBox复选框实例" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Checkbox复选框实例</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div id="div_chks" runat="server">
        <asp:Label ID="lblhobby" runat="server" Text="请选择你的爱好" Font-Size="Large" ForeColor="#3366ff"></asp:Label><br />
        <asp:CheckBox ID="CheckBox1" runat="server" Text="足球" Width="100px" />
        <asp:CheckBox ID="CheckBox2" runat="server" Text="篮球" Width="100px" />
        <asp:CheckBox ID="CheckBox3" runat="server" Text="羽毛球" Width="100px" />
        <asp:CheckBox ID="CheckBox4" runat="server" Text="排球" Width="100px" />
        <asp:CheckBox ID="CheckBox5" runat="server" Text="游泳" Width="100px" />
        <asp:CheckBox ID="CheckBox6" runat="server" Text="潜水" Width="100px" /><br />
        <asp:CheckBox ID="CheckBox7" runat="server" Text="骑自行车" Width="100px" />
        <asp:CheckBox ID="CheckBox8" runat="server" Text="爬山" Width="100px" />
        <asp:CheckBox ID="CheckBox9" runat="server" Text="旅游" Width="100px" />
        <asp:CheckBox ID="CheckBox10" runat="server" Text="环游世界" Width="100px" />
        <asp:CheckBox ID="CheckBox11" runat="server" Text="CEO" Width="100px" />
        <asp:CheckBox ID="CheckBox12" runat="server" Text="公司" Width="100px" /><br />
        <asp:Button ID="btn1" runat="server" Text="button" OnClick="btn1_Click" />
        <asp:TextBox ID="txtbox1" runat="server" TextMode="MultiLine" Rows="4"></asp:TextBox>
        <br />
        <asp:Button ID="btn2" runat="server" Text="foreach数组遍历" OnClick="btn2_Click" />
    </div>
    </div>
    </form>
</body>
</html>
