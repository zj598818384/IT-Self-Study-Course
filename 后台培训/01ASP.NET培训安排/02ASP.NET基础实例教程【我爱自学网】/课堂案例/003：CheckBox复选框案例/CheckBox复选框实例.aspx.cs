using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CheckBox复选框实例 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //按钮的单击事件
    protected void btn1_Click(object sender, EventArgs e)
    {
        txtbox1.Text = "";
        //定义一个checkbox的变量；
        CheckBox _chk;
        //遍历所有控件
        foreach (Control ctl in div_chks.Controls)
        {
            //检测当前控件是否是checkbox类型
            if (ctl is CheckBox)
            {
                //将control转换为checkbox类型
                _chk = (CheckBox)ctl;
                if (_chk.Checked==true)
                {
                    txtbox1.Text += _chk.Text + ",";
                }
            }
        }
    }

    //foreach数组遍历
    protected void btn2_Click(object sender, EventArgs e)
    {
        txtbox1.Text = "";
        char[] cs = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        foreach (char _cs in cs)
        {
            txtbox1.Text += _cs.ToString() + Convert.ToChar(13);
        }
    }
}