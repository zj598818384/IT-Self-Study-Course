using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _001_HelloWord.Controllers
{
    //HomeController类
    //要求新建的控制器，继承与Controller这个类
    public class HomeController : Controller
    {
        //在MVC中，访问时，实际访问的是某个类的某个方法
        //在ASP.NET中，访问时，实际访问的是某个类
        // GET: Home
        //行为：action
        public ActionResult Index()
        {
            //再没有指认view的时候，默认会找方法名相同的视图进行显示
            //还可以自定义视图,里面使用字符串的形式
            return View("Show");
        }

        public ActionResult HtmlTest()
        {
            //数据来源于行为，行为把数据做好之后，交给view去渲染
            //由行为向视图传递数据
            //ViewData键值对集合
            ViewData["zhh"] = "123";//集合类型
            //在数据中使用键来得到这个值
            ViewBag.qq = "456";
            //ViewBag就是ViewData的简写
            return View();
        }
    }
}