using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TextBox文本框 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void txt_zifu_TextChanged(object sender, EventArgs e)
    {
        
    }

    protected void txt_pwd_TextChanged(object sender, EventArgs e)
    {
        if (txt_name.Text!=""&&txt_pwd.Text!="")
        {
            //txt_zifu.Enabled = true;
            //txt_duohang.Enabled = true;
            //btn_chaifen.Enabled = true;
            Panel1.Enabled = true;
        }
    }

    //按钮单击事件
    protected void btn_chaifen_Click(object sender, EventArgs e)
    {
        //定义一个字符数组
        char[] ca;
        //赋值
        ca = txt_zifu.Text.ToCharArray();
        //循环
        for (int i=0;i<ca.Length;i++)
        {
            //给多行文本框赋值，并且将字符单个输出并换行
            txt_duohang.Text += ca[i].ToString() + "\n";
        }
    }
}