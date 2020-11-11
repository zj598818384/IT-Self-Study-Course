using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class 练习005_拆分字符 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn1_Click(object sender, EventArgs e)
    {
        //建立一个数组，获取文本框的内容
        char[] arr_char = TextBox1.Text.ToCharArray();
        //遍历数组中的每一个字符
        txt2.Text = "";
        foreach (char _char in arr_char)
        {
            txt2.Text += _char.ToString() + "|";
        }
    }
}