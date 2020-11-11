<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DropDownlist下拉列表框.aspx.cs" Inherits="DropDownlist下拉列表框" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true">
            <asp:ListItem Value="a">111</asp:ListItem>
            <asp:ListItem Value="b">222</asp:ListItem>
            <asp:ListItem Value="c">333</asp:ListItem>
            <asp:ListItem Value="d">444</asp:ListItem>
        </asp:DropDownList>
    <div>
        显示值：<asp:TextBox ID="txt1" runat="server"></asp:TextBox><br />
        显示下标：<asp:TextBox ID="txt2" runat="server"></asp:TextBox><br />
        显示内容：<asp:TextBox ID="txt3" runat="server"></asp:TextBox><br />
        <asp:Button ID="btn1" runat="server" Text="清除所有的项" OnClick="btn1_Click"/>
        <asp:Button ID="btn2" runat="server" Text="自动选中第三项" OnClick="btn2_Click"/>
    </div>
    </form>
</body>
</html>
