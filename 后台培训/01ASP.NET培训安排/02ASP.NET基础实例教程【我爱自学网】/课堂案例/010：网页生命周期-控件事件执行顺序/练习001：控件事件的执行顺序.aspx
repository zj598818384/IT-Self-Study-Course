<%@ Page Language="C#" AutoEventWireup="true" CodeFile="练习001：控件事件的执行顺序.aspx.cs" Inherits="练习001_控件事件的执行顺序" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        拥有TextChange事件的TextBox：<asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        拥有SelectChange事件的DropDownList：
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
        </asp:DropDownList>
        <br />
        拥有Click事件的Button：<asp:Button ID="Button1" runat="server" Text="提交(刷新)" OnClick ="Button1_Click"/>
        <br />
        输出结果文本框：<asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" Height="157px"></asp:TextBox>
    </div>
    </form>
</body>
</html>
