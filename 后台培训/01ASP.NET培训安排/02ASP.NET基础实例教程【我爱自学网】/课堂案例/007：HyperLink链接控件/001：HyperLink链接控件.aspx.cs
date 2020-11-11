using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _001_HyperLink链接控件 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //第一个按钮单击事件
    protected void btn1_Click(object sender, EventArgs e)
    {
        //声明创建一个超链接
        HyperLink link = new HyperLink();
        link.NavigateUrl = "http://www.baidu.com";
        link.Text = "百度";

        Panel1.Controls.Add(link);

        //如果这里HyperLink link = new HyperLink();这样写，则会将下面添加的这个链接覆盖上面创建的链接
        link = new HyperLink();
        link.NavigateUrl = "http://www.sina.com";
        link.Text = "新浪";

        Panel1.Controls.Add(link);
    }

    //第二个按钮单击事件
    protected void btn2_Click(object sender, EventArgs e)
    {
        HyperLink link = new HyperLink();
        link.NavigateUrl = "http://www.baidu.com";
        link.Text = "百度";
        link.CssClass = "a1";
        Panel1.Controls.Add(link);
    }
}