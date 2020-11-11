<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login登录窗体.aspx.cs" Inherits="新闻发布.Login登录窗体" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>登录窗体</title>
    <style type="text/css">
        body{
            margin:0px;
            padding:0px;
        }
        .big_box{
            width:350px;
            height:300px;
            border:2px solid #48A1FF;
            margin:0 auto;
            margin-top:130px;
            box-shadow:2px 2px 2px #808080;
            border-radius:10px;
        }
        .dl_txt{
            width:350px;
            height:50px;
            display:block;
            font-size:24px;
            letter-spacing:4px;
            color:#fff;
            background:#48A1FF;
            line-height:50px;
            text-align:center;
            border-top-left-radius:10px;
            border-top-right-radius:10px;
        }

        .p_1{
            width:330px;
            height:40px;
            line-height:40px;
            font-size:16px;
            margin-left:20px;
        }

        .input_name{
            width:200px;
            height:24px;
            outline:none;
        }

        .a_zc{
            font-size:14px;
            color:#000;
            text-decoration:none;
        }

        .input_pwd{
            width:200px;
            height:24px;
            outline:none;
        }

        .btn_dl{
            width:70px;
            height:30px;
            background:#48A1FF;
            color:#fff;
            font-size:16px;
            letter-spacing:2px;
            margin-left:80px;
            border:none;
            margin-top:10px;
            border-radius:8px;
        }
        .btn_cz{
            width:70px;
            height:30px;
            background:#48A1FF;
            color:#fff;
            font-size:16px;
            letter-spacing:2px;
            margin-left:30px;
            border:none;
            margin-top:10px;
            border-radius:8px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="big_box">
        <span class="dl_txt">登录窗体</span>
        <p class="p_1">
            账户：<input  type="text" class="input_name"/>
            <a href="#" class="a_zc">用户注册</a>
        </p>
        <p class="p_1" style="margin-top:30px;">
            密码：<input  type="text" class="input_pwd"/>
        </p>
        <button class="btn_dl">登录</button>
        <button class="btn_cz">重置</button>
    </div>
    </form>
</body>
</html>
