using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _003_Route路由规则.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //利用路由规则传递参数
        //没有一个键叫做id
        public ActionResult Index(string id)
        {
            ViewBag.id = id;
            return View();
        }
    }
}