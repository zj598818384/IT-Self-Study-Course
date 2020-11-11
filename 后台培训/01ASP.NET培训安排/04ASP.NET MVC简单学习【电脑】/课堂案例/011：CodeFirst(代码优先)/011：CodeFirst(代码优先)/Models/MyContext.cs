using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _011_CodeFirst_代码优先_.Models
{
    public class MyContext:DbContext
    {
        //调用父类构造方法
        public MyContext():base("name=MyContext")
        {

        }

        public DbSet<BookInfo1> BookInfo1 { get; set; }
        public DbSet<BookType1> BookType1 { get; set; }
    }
}