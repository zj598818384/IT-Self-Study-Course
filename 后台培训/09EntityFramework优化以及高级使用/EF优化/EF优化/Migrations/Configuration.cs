namespace EF优化.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EF优化.Models.BookDemo3Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EF优化.Models.BookDemo3Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            //添加数据
            //在进行数据迁移的时候记得将这里面的数据注释，否则会重复执行
            //context.BookTypes.AddOrUpdate(new Models.BookType { Name = "散文" });
            //context.BookTypes.AddOrUpdate(new Models.BookType { Name = "科幻" });
            //context.BookTypes.AddOrUpdate(new Models.BookType { Name = "诗歌" });
            //context.BookTypes.AddOrUpdate(new Models.BookType { Name = "儿童" });


            //EF中的5态
            //Unchanged  持久态,未修改的
            //Midfied   发生修改后
            //Deleted  删除
            //Added  游离态，还未保存，向数据库中添加数据
            //Detached new出来的对象，跟数据没有关系
        }
    }
}
