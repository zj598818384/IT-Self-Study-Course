using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ListBox实现的简单点菜程序 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //右箭头
    protected void Button1_Click(object sender, EventArgs e)
    {
        //remove
        //反项遍历
        for (int i=ListBox1.Items.Count-1;i>=0;i--)
        {
            if (ListBox1.Items[i].Selected)
            {
                ListBox2.Items.Add(ListBox1.Items[i]);
                ListBox1.Items.Remove(ListBox1.Items[i].Text);
            }
        }

        //removeAt
        //for (int c=ListBox1.Items.Count-1;c>=0;c--)
        //{
        //    if (ListBox1.Items[c].Selected)
        //    {
        //        ListBox1.Items.RemoveAt(c);
        //    }
        //}
    }

    //左箭头
    protected void Button2_Click(object sender, EventArgs e)
    {
        //remove
        //反项遍历
        for (int i = ListBox2.Items.Count - 1; i >= 0; i--)
        {
            if (ListBox2.Items[i].Selected)
            {
                ListBox1.Items.Add(ListBox2.Items[i]);
                ListBox2.Items.Remove(ListBox2.Items[i].Text);
            }
        }
    }
}