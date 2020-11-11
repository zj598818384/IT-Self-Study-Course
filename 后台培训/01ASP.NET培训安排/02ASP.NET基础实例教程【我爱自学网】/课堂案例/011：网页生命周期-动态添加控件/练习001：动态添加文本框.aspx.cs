using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class 练习001_动态添加文本框 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //获取文本框的数值
        int i = 0;
        try
        {
            i = Int16.Parse(txt_num.Text);
        }
        catch
        { }

        
        TextBox _txt;
        if (i > 0)
        {
            //创建
            for (int _i = 0; _i < i; _i++)
            {
                _txt = new TextBox();
                _txt.Text = _i.ToString();
                panel1.Controls.Add(_txt);
            }
        }
    }

    //按钮单击事件
    protected void btn1_Click(object sender, EventArgs e)
    {
       
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}