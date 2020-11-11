using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class 回发与page对象 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)//首次加载
        {
            //在这里编写<首次加载>需要处理的工作
            this.TextBox1.Text = "请输入内容!";
        }
        else//回发
        {
            //在这里编写<回发>时需要处理的工作
        }
        
    }

    //按钮的单击事件
    protected void Button1_Click(object sender, EventArgs e)
    {
        this.TextBox2.Text = this.TextBox1.Text;
    }
}