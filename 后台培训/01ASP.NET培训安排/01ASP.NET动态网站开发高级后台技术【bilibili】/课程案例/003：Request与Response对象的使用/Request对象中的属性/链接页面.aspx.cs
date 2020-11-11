using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Request对象中的属性_链接页面 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //string name = Request.QueryString["name"];
        //string age = Request.QueryString["age"];

        string name = Request.Params["name"];
        string age = Request.Params["age"];
        //在页面上显示
        Response.Write("姓名："+name+"年龄"+age);
    }
}