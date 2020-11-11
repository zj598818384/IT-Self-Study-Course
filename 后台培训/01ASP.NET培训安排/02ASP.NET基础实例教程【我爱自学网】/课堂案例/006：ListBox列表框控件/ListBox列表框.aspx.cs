using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ListBox列表框 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //确定按钮的单击事件
    protected void Button1_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        //for (int i=0;i<ListBox1.Items.Count;i++)
        //{
        //    if (ListBox1.Items[i].Selected)
        //    {
        //        TextBox1.Text += ListBox1.Items[i].Text + ",";
        //    }
        //}

        foreach (ListItem _li in ListBox1.Items)
        {
            if (_li.Selected)
            {
                TextBox1.Text += _li.Text+",";
            }
        }
    }
}