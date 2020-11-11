using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class 练习002_页面加载自动选中第一个复选框 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CheckBox1.Checked = true;
    }
}