using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSystem.Models
{
    public class BookSystemContext:DbContext
    {
        //构造函数   base("连接字符串的参数")
        public BookSystemContext() : base("con")
        {
            //关闭检查
            Database.SetInitializer<BookSystemContext>(null);
        }

        //重写方法
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //关闭一对一以及一对多
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }

        //注册表
        public DbSet<BookType> BookTypes { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
