using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace EF优化.Models
{
    public class BookDemo3Context:DbContext
    {
        //构造函数   base("连接字符串的参数")
        public BookDemo3Context() : base("con")
        {
            //关闭检查
            Database.SetInitializer<BookDemo3Context>(null);
        }

        //重写方法
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //关闭一对多和多对多
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }

        //注册
        public DbSet<BookType> BookTypes { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
