using _005_过滤器.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace _005_过滤器.Controllers
{
    [MyAuthorization]//当前控制器下的所有行为，都被应用了这个过滤器
    public class HomeController : Controller
    {
        // GET: Home
        //过滤标记
        //[MyAuthorization]//当前行为在执行前，会执行身份验证过滤器
        //在执行行为之前先执行身份验证

        //[MyException]//异常处理过滤器  
        //在Web.config文件中新建一个
        //<customErrors mode="On"></customErrors>

        [MyAction]//行为过滤器
        [MyResult]//结果过滤器
        public ActionResult Index()
        {
            //异常处理
            //throw new Exception("");
            Response.Write("行为执行中<br>");
            return View();
        }

        public ActionResult Show()
        {
            return View();
        }

        //在全局中注册Global文件中，过滤器，则所有控制器的所有行为，都会执行这个过滤器
        //filters.Add(new MyAuthorization())

        //系统默认的异常处理过滤器，如果使用自定义异常处理，要将一下代码删除
        //filters.Add(new HandleErrorAttribute())
        //自己添加
        //filters.Add(new MyException());

        //过滤器的第二种实现方式：重写控制器的方法，这样，会应用于所有的行为
        protected override void OnAuthentication(AuthenticationContext filterContext)
        {
            filterContext.HttpContext.Response.Write("456");
        }
    }
}