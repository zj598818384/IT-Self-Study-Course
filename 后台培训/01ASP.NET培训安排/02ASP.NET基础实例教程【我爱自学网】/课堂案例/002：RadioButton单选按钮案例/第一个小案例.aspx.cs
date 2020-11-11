using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class 第一个小案例 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //按钮单击事件
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (rbth_1.Checked==true)
        {
            TextBox1.Text = "选中了" + rbth_1.Text;
        }
        if (rbth_2.Checked == true)
        {
            TextBox1.Text = "选中了" + rbth_2.Text;
        }
        if (rbth_3.Checked == true)
        {
            TextBox1.Text = "选中了" + rbth_3.Text;
        }
        if (rbth_4.Checked == true)
        {
            TextBox1.Text = "选中了" + rbth_4.Text;
        }
    }
}