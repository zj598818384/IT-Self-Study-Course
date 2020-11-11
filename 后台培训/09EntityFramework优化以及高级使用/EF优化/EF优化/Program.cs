using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF优化
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (Models.BookDemo3Context db=new Models.BookDemo3Context())
            {
                //读取数据
                //foreach (var item in db.BookTypes)
                //{
                //    Console.WriteLine(item.Name);
                //}

                //一、从数据库拿数据
                //拿到现在的状态
                //var type = db.BookTypes.Find(1);
                ////这里的状态是：持久态，从数据库中取出来
                //Console.WriteLine(db.Entry(type).State);

                ////修改数据状态
                ////从持久态变成Remove的
                //db.BookTypes.Remove(db.BookTypes.Find(1));
                ////这里的状态是：删除的时候，但是还没有删
                //Console.WriteLine(db.Entry(type).State);

                //db.SaveChanges();
                ////这里的状态是：已经操作完成了，跟数据库没有关系了
                //Console.WriteLine(db.Entry(type).State);


                ////二、不从数据库拿数据，直接new一个数据
                ////new一个对象，处于游离态，跟数据库没有任何关系
                //var type1 = new Models.BookType() { Id = 3 };
                //Console.WriteLine(db.Entry(type1).State);
                ////强制将游离态更改为持久态，还未进行修改的时候
                ////表示是被删除的状态
                //db.Entry(type1).State = System.Data.Entity.EntityState.Deleted;
                //db.BookTypes.Remove(type1);
                //Console.WriteLine(db.Entry(type1).State);
                //db.SaveChanges();
                //Console.WriteLine(db.Entry(type1).State);

                ////三、使用五态的方式进行查询
                ////查询数据
                //foreach (var item in db.BookTypes)
                //{
                //    Console.WriteLine(item.Id);
                //}


                #region 修改
                ////四、不从数据库拿数据，直接new一个数据
                ////查看生成的SQL语句
                //db.Database.Log = (msg) =>
                //{
                //    Console.WriteLine(msg);
                //};

                ////new一个对象，处于游离态，跟数据库没有任何关系
                //var type1 = new Models.BookType() { Id = 4};
                ////修改状态
                //db.Entry(type1).State = System.Data.Entity.EntityState.Unchanged;
                ////修改数据
                //type1.Name = "修改了";
                //type1.CreateTime = DateTime.Now;
                //db.SaveChanges();

                ////(2)以整个对象修改
                //var type2= new Models.BookType() { Id = 4 ,Name="aaa",CreateTime=DateTime.Now};
                ////处于已经修改了的状态
                //db.Entry(type2).State = System.Data.Entity.EntityState.Modified;
                //db.SaveChanges();
                #endregion

                //查询
                //AsNoTracking：不被缓存的
                var item=db.BookTypes.AsNoTracking().First(m=>m.Id==4);
                //此时的状态跟数据库没有关系
                Console.WriteLine(db.Entry(item).State);

            }
        }
    }
}
