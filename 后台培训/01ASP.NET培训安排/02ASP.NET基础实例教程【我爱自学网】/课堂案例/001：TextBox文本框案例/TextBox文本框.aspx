<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TextBox文本框.aspx.cs" Inherits="TextBox文本框" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>TextBox案例</title>
    <link rel="stylesheet" type="text/css" href="style.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="div1">
            姓名：<asp:TextBox ID="txt_name" runat="server"></asp:TextBox><br />
             密码：<asp:TextBox ID="txt_pwd" runat="server" TextMode="Password" AutoPostBack="true" OnTextChanged="txt_pwd_TextChanged"></asp:TextBox><br />
        <asp:Panel ID="Panel1" runat="server" BorderColor="#3366ff" BorderStyle="Solid" BorderWidth="2px" Enabled="false">
                <asp:TextBox ID="txt_zifu" runat="server" OnTextChanged="txt_zifu_TextChanged"></asp:TextBox>
                <asp:Button ID="btn_chaifen" runat="server" Text="拆分字符串" onclick="btn_chaifen_Click"/><br />
                <asp:TextBox ID="txt_duohang" runat="server" TextMode="MultiLine" Height="182px"></asp:TextBox>
          </asp:Panel>
    </div>
    </form>
</body>
</html>
