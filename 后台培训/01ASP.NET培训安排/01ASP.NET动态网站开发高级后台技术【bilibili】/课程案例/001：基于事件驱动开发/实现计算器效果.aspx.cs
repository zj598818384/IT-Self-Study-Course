using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class 实现计算器效果 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //【计算按钮的单击事件】
    protected void Button1_Click(object sender, EventArgs e)
    {
        int a = Convert.ToInt32(this.TextBox1.Text.Trim());
        int b = Convert.ToInt32(this.TextBox2.Text.Trim());
        this.TextBox3.Text = (a + b).ToString();
    }
}