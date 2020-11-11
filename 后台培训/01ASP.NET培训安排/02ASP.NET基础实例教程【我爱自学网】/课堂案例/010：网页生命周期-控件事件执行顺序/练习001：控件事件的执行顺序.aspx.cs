using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class 练习001_控件事件的执行顺序 : System.Web.UI.Page
{
    //前面的序号
    int i = 1;
    protected void Page_Load(object sender, EventArgs e)
    {
        //每次页面载入都清空这个文本框
        TextBox2.Text = "";
        TextBox2.Text = i++.ToString() + ":PageLoad" + "\n";
    }

    //文本改变事件
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        TextBox2.Text += i++.ToString() + ":TextChanged"+"\n";
    }

    //下拉框
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        TextBox2.Text += i++.ToString() + ":SelectChanged" + "\n";
    }

    //按钮单击事件
    protected void Button1_Click(object sender, EventArgs e)
    {
        TextBox2.Text += i++.ToString() + ":ButtonCLick" + "\n";
    }
}