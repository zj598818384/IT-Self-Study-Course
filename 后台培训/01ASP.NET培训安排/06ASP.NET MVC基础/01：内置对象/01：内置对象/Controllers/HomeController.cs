using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01_内置对象.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //内置对象       Request           Response          Session          Cookie               Application                 Service
            //                     请求                 相应                   会话               客户端数据         当前网站对象                服务器对象 
            //Request：服务器接收到客户端的数据
            //Request.QueryString["name"]：get请求
            //return View(Request.QueryString["name"]);
            return Content($"{Request.QueryString["name"]}-{Request.QueryString["age"]}-{Request.QueryString["id"]}");
        }


        //Request
        public ActionResult PostData()
        {
            //Request.Form：post请求
            return Content(Request.Form["loginname"]);
        }


        public ActionResult FileData()
        {
            //Request.MapPath()：将虚拟路径装换为物理路径
            //什么是虚拟路径：相对路径就是虚拟路径，相对文件的路径
            //物理路径：绝对路径就是物理路径，相对于磁盘来说
            //SaveAs方法需要物理路径
            //Request.Files：post请求的文件(文件上传)
            Request.Files["file"].SaveAs(Request.MapPath("~/uploads/" + Request.Files["file"].FileName));
            return Content("ok");
        }

        //请求头
        public ActionResult RequestHeaders()
        {
            Response.Headers["hello"] = "world";
            return Content(Request.Headers["token"]);
        }

        //Response：服务器给客户端  
        public ActionResult ResponeData()
        {
            //向客户端输出内容
            //Response.Write("你好");

            //重定向
            // Response.Redirect("http://www.baidu.com");
            
            return Content("");
        }

        //session
        public ActionResult SessionData()
        {
            //时长20分钟
            //数据保存在服务器中
            //安全高，性能低
            //用来存放少量数据比如账号
            //用来存放账号信息，其他的最好不好保存在session中，主要用来做身份识别
            //Session是一个键值对

            Session["user"] = Request.Form["user"];
            return Content("会话中的数据是："+Session["user"]);
        }
        
        //读取session数据
        public ActionResult GetSession()
        {
            //数据不会共享，每个人数据都是独立的
            return Content("当前会话的数据是："+Session["user"]);
        }

        //清除会话，退出
        public ActionResult ClearSession()
        {
            //清除会话
            //销毁
            Session.Abandon();
            //清除
            //Session.Clear();
            return Content("当前会话的数据是："+Session["user"]);
        }

        //Cookie
        public ActionResult CookieSave()
        {
            //时效性
            Response.Cookies.Add(new HttpCookie("token")
            {
                Value = "aaavbbb",
                //过期时间7天
                Expires = DateTime.Now.AddDays(7)
            });
            return Content("ok");
        }

        //得到cookie
        public ActionResult CookieGet()
        {
            try
            {
                return Content(Request.Cookies["token"].Value);
            }
            catch
            {
                return Content("cookie已不存在");
            }
            
        }
        
        //删除cookie
        public ActionResult CookieClear()
        {
            //清除cookie值，使用过期的方式
            Response.Cookies.Add(new HttpCookie("token")
            {
                Expires=DateTime.Now.AddDays(-1)
            });

            return Content("ok");
        }

        //application
        //存
        public ActionResult ApplicationData()
        {
            HttpContext.Application["user"] = "123";
            return Content("");
        }

        //获取
        public ActionResult ApplicationGet()
        {
            return Content(HttpContext.Application["user"].ToString());
        }

        //Server
        public ActionResult ServerDemo()
        {
            //转发——路径不变，内容发生变化
            //server.mappath()——虚拟路径转物理路径
            //server.htmlencode
            //server.htmldecode
            //server.urldecode
            //server.urlecode
            Server.Transfer("/ShowDemo.html");
            return Content("");
        }

        public ActionResult ShowDemo()
        {
            return Content("这是内容");
        }
    }
}