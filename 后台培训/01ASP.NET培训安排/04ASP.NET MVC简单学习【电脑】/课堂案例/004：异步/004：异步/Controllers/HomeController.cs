using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _004_异步.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        //方法一
        public ActionResult CalcAdd(int calc1, int calc2)
        {
            int sum = calc1 + calc2;
            return Content(sum.ToString());
        }

        public ActionResult CalcAdd1(int calc1, int calc2)
        {
            int sum = calc1 + calc2;
            //返回一个json对象
            var temp = new
            {
                Sum = sum
            };
            //JsonRequestBehavior.AllowGet：允许以get方式返回请求
            return Json(temp,JsonRequestBehavior.AllowGet);
        }
    }
}