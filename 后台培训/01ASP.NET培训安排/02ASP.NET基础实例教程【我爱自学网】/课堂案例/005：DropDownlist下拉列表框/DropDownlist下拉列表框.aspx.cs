using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DropDownlist下拉列表框 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    //下拉框
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        txt1.Text = DropDownList1.SelectedValue;
        txt2.Text = DropDownList1.SelectedIndex.ToString();
        txt3.Text = DropDownList1.SelectedItem.Text;
        
    }

    //清除所有的项
    protected void btn1_Click(object sender, EventArgs e)
    {
        DropDownList1.Items.Clear();
        txt1.Text = "";
        txt2.Text = "";
        txt3.Text = "";
    }

    //自动选中第三项
    protected void btn2_Click(object sender, EventArgs e)
    {
        //在设定之前，先要清除原先的选项，否则报错
        DropDownList1.SelectedItem.Selected = false;
        //自动选中下标为2的那一项
        DropDownList1.Items[2].Selected = true;
    }
}