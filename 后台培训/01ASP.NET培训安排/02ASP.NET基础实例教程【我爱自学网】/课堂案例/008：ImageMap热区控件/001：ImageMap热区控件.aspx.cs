using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _001_ImageMap热区控件 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ImageMap1_Click(object sender, ImageMapEventArgs e)
    {

    }

    //添加按钮
    protected void btn1_Click(object sender, EventArgs e)
    {
        RectangleHotSpot ha = new RectangleHotSpot();
        ha.Left = 0;
        ha.Right=200;
        ha.Top = 300;
        ha.Bottom = 400;
        ha.NavigateUrl = "http://www.taobao.com";
        ha.AlternateText = "淘宝";
        ImageMap1.HotSpots.Add(ha);
    }
}