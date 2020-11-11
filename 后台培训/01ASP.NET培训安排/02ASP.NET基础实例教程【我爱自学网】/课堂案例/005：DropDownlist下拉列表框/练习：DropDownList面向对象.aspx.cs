using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class 练习_DropDownList面向对象 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //go按钮的单击事件
    protected void btngo_Click(object sender, EventArgs e)
    {
        //将请求定向URL路径
        Response.Redirect(DropDownList1.SelectedValue);
    }

    //改变按钮单击事件
    protected void change_Click(object sender, EventArgs e)
    {
        //改变下标为0的text值
        DropDownList1.Items[0].Text = "新浪";
        //改变下标为0的value值
        DropDownList1.Items[0].Value = "http://www.sina.com";
    }

    //新增按钮的单击事件
    protected void addnew_Click(object sender, EventArgs e)
    {
        ListItem obj_li = new ListItem();
        obj_li.Text = "Google";
        obj_li.Value = "http://www.google.com";
        DropDownList1.Items.Add(obj_li);
    }

    //更改按钮
    protected void gengai_Click(object sender, EventArgs e)
    {
        DropDownList obj_li = new DropDownList();
        obj_li = DropDownList1;
        Panel1.Controls.Add(obj_li);
    }
}