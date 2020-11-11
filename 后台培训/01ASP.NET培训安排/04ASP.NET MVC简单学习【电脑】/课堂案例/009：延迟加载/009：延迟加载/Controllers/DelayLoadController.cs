using _009_延迟加载.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _009_延迟加载.Controllers
{
    public class DelayLoadController : Controller
    {
        // GET: DelayLoad
        public ActionResult Index()
        {
            DbContext dbContext = new MyContext();

            //延迟加载：如果不使用数据，则只是凭借SQL语句，不会将结果集拿到内存中来

            IQueryable<admin> list = dbContext.Set<admin>()
                .OrderByDescending(u => u.username)//默认会将lambda表达式封装成Expression对象，而调用IQueryable<T>的方法
                .Skip(2)
                .Take(3);
            ViewBag.list = list;


            IEnumerable<admin> list2 = dbContext.Set<admin>()
                .AsEnumerable()
                .OrderByDescending(u => u.username)
                .Skip(2)
                .Take(3);
            ViewBag.list2 = list2;

            //导航属性默认也会使用延迟加载
            IQueryable<admin> list3 = dbContext.Set<admin>();
            ViewBag.list3 = list3.Include(n=>n.username).ToList();
            return View();
        }
    }
}