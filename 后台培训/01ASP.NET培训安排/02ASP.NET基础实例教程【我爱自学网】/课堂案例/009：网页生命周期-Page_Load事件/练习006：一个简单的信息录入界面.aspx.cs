using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class 练习006_一个简单的信息录入界面 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            RadioButton2.Checked = true;
        }
        
    }

    //确定按钮单击事件
    protected void Button1_Click(object sender, EventArgs e)
    {
        //将姓名添加到结果
        TextBox2.Text += TextBox1.Text+",";
        //将性别添加到结果
        if (RadioButton1.Checked)
        {
            TextBox2.Text += RadioButton1.Text+",";
        }
        else
        {
            TextBox2.Text += RadioButton2.Text + ",";
        }
        //将班级添加到结果
        TextBox2.Text += DropDownList1.Text;
    }
}