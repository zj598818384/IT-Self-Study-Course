using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Request对象中的属性_ServerVariables属性 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //输出显示浏览器的版本信息
        Response.Write("您的浏览器版本是：");
        Response.Write(Request.ServerVariables["HTTP_USER_AGENT"].ToString());
        Response.Write("<br>您的浏览器语言是：");
        Response.Write(Request.ServerVariables["HTTP_ACCEPT_LANGUAGE"].ToString());
    }
}