using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//radiobutton2个编程要点：
//1、autopostback：在change事件发生后立即执行(提交页面)
//2、后台程序想设置某组某项为选定状态时，必须确保同组的其他控件设置为checked=false
public partial class 成绩选择 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //按钮单击事件
    protected void Button1_Click(object sender, EventArgs e)
    {
        //将单选按钮的选中状态全部取消
        rbth_1.Checked = rbth_2.Checked = rbth_3.Checked = rbth_4.Checked = false;
        double d_num = -1;
        try
        {
            d_num = double.Parse(TextBox1.Text);
        }
        catch
        {
        }

        if (d_num>=0&&d_num<=100)
        {
            lblcuowu.Text = "";
            if (d_num >= 0 && d_num < 60)
            {
                rbth_1.Checked = true;
            }
            if (d_num >= 60 && d_num < 70)
            {
                rbth_2.Checked = true;
            }
            if (d_num >= 70 && d_num < 80)
            {
                rbth_3.Checked = true;
            }
            if (d_num >= 80 && d_num <= 100)
            {
                rbth_4.Checked = true;
            }
        }
        else
        {
            lblcuowu.Text = "请输入正确的成绩";
        }
    }

    //检测按钮单击事件
    protected void btn_Click(object sender, EventArgs e)
    {
        try
        {
            int i = Int16.Parse("ddd");
        }
        catch 
        {
        }
    }
}