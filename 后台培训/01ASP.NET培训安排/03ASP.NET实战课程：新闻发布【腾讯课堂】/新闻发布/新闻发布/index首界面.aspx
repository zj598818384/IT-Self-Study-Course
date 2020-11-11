<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index首界面.aspx.cs" Inherits="新闻发布.index首界面" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>首界面</title>
    <style type="text/css">
        body{
            margin:0px;
            padding:0px;
        }

        #top{
            height:70px;
            border:1px solid red;
            font-size:50px;
            color:#48A1FF;
            text-align:center;
            line-height:70px;
        }
        #left{
            float:left;
            width:15%;
            border:1px solid red;
            height:500px;
        }
        #right{
            float:right;
            width:84%;
            height:500px;
            border:1px solid red;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="top">系统登录管理</div>
        <div id="left">
            <asp:TreeView ID="TreeView1" runat="server" ImageSet="News" NodeIndent="10" Font-Size="16pt" Font-Names="微软雅黑">
                <HoverNodeStyle Font-Underline="True" />
                <Nodes>
                    <asp:TreeNode Text="系统登录管理" Value="系统登录管理">
                        <asp:TreeNode Text="用户查询" Value="用户查询"></asp:TreeNode>
                        <asp:TreeNode Text="用户添加" Value="用户添加"></asp:TreeNode>
                    </asp:TreeNode>
                </Nodes>
                <NodeStyle Font-Names="Arial" Font-Size="10pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
                <ParentNodeStyle Font-Bold="False" />
                <SelectedNodeStyle Font-Underline="True" HorizontalPadding="0px" VerticalPadding="0px" />
            </asp:TreeView>
        </div>
        <div id="right"></div>
    </form>
</body>
</html>
