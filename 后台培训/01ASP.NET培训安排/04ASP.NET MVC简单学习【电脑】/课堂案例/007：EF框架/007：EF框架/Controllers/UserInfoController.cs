using _007_EF框架.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _007_EF框架.Controllers
{
    public class UserInfoController : Controller
    {
        // GET: UserInfo
        public ActionResult Index()
        {
            //建议：声明父类型的变量，指向子类型的对象
            //面向多态的开始

            //Model1 model = new Model1();
            //查询语法
            //var a = from UserInfo in model.UserInfo
            //        select UserInfo;

            //方法语法
            //var list = model.UserInfo.Select(u => u);

            IQueryable<NewsInfo> list;
            //创建上下文对象
            DbContext dbContext = new Model1();
            //基本查询
            //list = from UserInfo in dbContext.Set<UserInfo>()
            //       select UserInfo;

            //单条件查询
            //list = from UserInfo in dbContext.Set<UserInfo>()
            //       where UserInfo.uid > 2
            //       select UserInfo;

            //多条件查询
            //list = from UserInfo in dbContext.Set<UserInfo>()
            //       where UserInfo.uid > 2 && UserInfo.username.Length > 2
            //       select UserInfo;

            //连接查询


            //查询单列
            //var list1 = from UserInfo in dbContext.Set<UserInfo>()
            //       select UserInfo.uid;

            //查询多列
            //var list1 = from UserInfo in dbContext.Set<UserInfo>()
            //            select new UserInfoViewModel()
            //            {
            //                uid = UserInfo.uid,
            //                name = UserInfo.username
            //            };

            var list1 = from userinfo in dbContext.Set<NewsInfo>()
                        select userinfo;
            //skip()表示取几条，take()表示拿几条
            list1 = list1.OrderByDescending(u => u.uid).Skip(2).Take(3);

            return View(list1);  
        }

        //方法查询
        public ActionResult index2()
        {
            DbContext dbContext = new Model1();

            //基本查询
            var list1 = dbContext.Set<NewsInfo>();

            IQueryable<NewsInfo> list;
            //单条件查询
            // ist = list1.Where(u => u.uid > 2);

            //多条件查询
            //(u.username.Contains("二")包含二的字符串
            //list = list1.Where(u => (u.uid > 2) || (u.username.Contains("二")));
            list = list1.Where(u => u.uid > 2).Where(u => u.username.Contains("二"));

            //多列查询
            list = list1.Select(u => new NewsInfo()
            {
                uid = u.uid,
                username = u.username
            });
            return View(list);
        }
    }
}