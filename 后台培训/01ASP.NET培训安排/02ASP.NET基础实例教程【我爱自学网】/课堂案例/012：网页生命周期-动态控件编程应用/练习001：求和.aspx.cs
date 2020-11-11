using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class 练习001_求和 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int i = 0;
        try
        {
            i = Int16.Parse(txtnum.Text);
        }
        catch{}
        TextBox _txt;
        if (i > 0)
        {
            for (int _i=0;_i<i;_i++)
            {
                _txt = new TextBox();
                _txt.Text = _i.ToString();
                panel.Controls.Add(_txt);   
            }
        }
    }

    //求和
    protected void btnsum_Click(object sender, EventArgs e)
    {
        double d_sum = 0;
        TextBox _txt;
        foreach (Control _ctl in panel.Controls)
        {
            //判断是否是textbox
            if (_ctl is TextBox)
            {
                _txt = (TextBox)_ctl;
            }
        }
    }
}