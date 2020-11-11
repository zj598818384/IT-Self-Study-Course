using _008_增删改查操作_crud_.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _008_增删改查操作_crud_.Controllers
{
    public class UserInfoController : Controller
    {
        DbContext dbContext = new MyContext();
        // GET: UserInfo
        public ActionResult Index()
        {
            var list = dbContext.Set<admin>();
            return View(list);
        }

        //添加
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(admin admin1)
        {
            dbContext.Set<admin>().Add(admin1);
            //如果内存中的对数据发生了变化，并且希望将这个变化映射到数据库，需要执行这个方法
            int result=dbContext.SaveChanges();
            if (result>0)
            {
                return Redirect(Url.Action("Index", "UserInfo"));
            }
            else
            {
                return Redirect(Url.Action("Add"));
            }
        }

        //修改
        public ActionResult Edit(string id)
        {
            ViewData.Model = dbContext.Set<admin>()
                .Where(u => u.username == id).FirstOrDefault();
            return View();
        }

        [HttpPost]
        public ActionResult Edit(admin admin1)
        {
            dbContext.Set<admin>().AddOrUpdate(admin1);
            int result = dbContext.SaveChanges();
            if (result>0)
            {
                return Redirect(Url.Action("Index"));
            }
            else
            {
                return Redirect(Url.Action("Edit", new RouteValueDictionary(new { username = admin1.username })));
            }
        }

        //删除
        public ActionResult Remove(string id)
        {
            var admin1 = dbContext.Set<admin>()
                .Where(u => u.username == id).FirstOrDefault();
            dbContext.Set<admin>().Remove(admin1);
            dbContext.SaveChanges();
            return Redirect(Url.Action("Index"));
        }
    }
}