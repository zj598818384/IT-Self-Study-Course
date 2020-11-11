using _02_控制器.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02_控制器.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //传数据
            //一般存放一些部主要的数据
            ViewBag.Content = "这是Cotroller里的数据";
            ViewBag.Zname = "张三";
            ViewBag.Zage = 12;
            ViewData["Age"] = 40;
            return View();
        }

        public void Demo()
        {
            //一次读取的session，读取一次将会被清空
            TempData["Hello"] = "World";
            Response.Redirect("~/Home/Demo2");
        }

        public ActionResult Demo2()
        {
            return View();
        }

        public ActionResult ShowData()
        {
            return View("ShowData2",new Student()
            {
                Id=1,
                Name="张三",
                Age=20
            });
        }
    }
}