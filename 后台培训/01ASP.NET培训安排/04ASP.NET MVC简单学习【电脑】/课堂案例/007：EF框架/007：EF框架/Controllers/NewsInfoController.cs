using _007_EF框架.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _007_EF框架.Controllers
{
    public class NewsInfoController : Controller
    {
        // GET: NewsInfo
        public ActionResult Index()
        {
            DbContext dbContext = new Model1();
            //连接查询
            //var list = from newsInfo in dbContext.Set<NewsInfo>()
            //           join typeInfo in dbContext.Set<_007_EF框架.Models.NewsType>() on newsInfo.nTid equals typeInfo.tid
            //           select newsInfo;

            //from后面的in一定要是一个集合类型的对象，才可以连接
            //var list = from newsType in dbContext.Set<NewsInfo>()
            //           from newsInfo in newsType.NewsInfo
            //           select new
            //           {
            //               NTitle = newsInfo.nTitle,
            //               TTitle = newsType.tTitle
            //           };

            return View();
        }
    }
}