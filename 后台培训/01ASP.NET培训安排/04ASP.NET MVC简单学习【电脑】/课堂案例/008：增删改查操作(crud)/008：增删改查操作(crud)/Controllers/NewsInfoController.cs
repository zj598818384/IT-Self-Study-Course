using _008_增删改查操作_crud_.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _008_增删改查操作_crud_.Controllers
{
    public class NewsInfoController : Controller
    {
        DbContext dbContext = new MyContext();
        // GET: NewsInfo
        public ActionResult Index()
        {
            ViewData.Model = from NewsInfo in dbContext.Set<getmoney>()
                             select NewsInfo;
            return View();
        }

        //修改
        public ActionResult Edit(int id)
        {
            ViewData.Model=dbContext.Set<getmoney>().Where(n => n.fid == id).FirstOrDefault();
            return View();
        }

        [HttpPost]
        public ActionResult Edit(getmoney NewsInfo)
        {
            //使用状态方式进行修改
            dbContext.Set<getmoney>().Attach(NewsInfo);
            dbContext.Entry(NewsInfo).State = EntityState.Modified;
            dbContext.SaveChanges();
            return Redirect(Url.Action("Index"));
        }
    }
}