using _011_CodeFirst_代码优先_.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _011_CodeFirst_代码优先_.Controllers
{
    public class BookType1Controller : Controller
    {
        DbContext dbContext = new MyContext();
        // GET: BookType1
        public ActionResult Index()
        {
            //当操作的表存在时，则不进行创建如果不存在，则创建
            //dbContext.Database.CreateIfNotExists();
            //dbContext.SaveChanges();

            ViewData.Model = dbContext.Set<BookType1>();
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(BookType1 bookType1)
        {
            dbContext.Set<BookType1>().Add(bookType1);
            dbContext.SaveChanges();

            return Redirect(Url.Action("Index"));
        }
    }
}