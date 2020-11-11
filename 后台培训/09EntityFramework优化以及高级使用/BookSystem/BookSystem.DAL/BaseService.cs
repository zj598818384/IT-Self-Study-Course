using BookSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSystem.DAL
{
    //实现接口
    public class BaseService<T> : IDAL.IBaseService<T> where T:BaseEntity,new()
    {
        private Models.BookSystemContext db = new Models.BookSystemContext();

        public void Add(T t)
        {
            //封装
            db.Set<T>().Add(t);
            db.SaveChanges();
        }

        //释放
        public void Dispose()
        {
            db.Dispose();
        }

        public void Edit(T t)
        {
            db.Entry(t).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public IQueryable<T> GetAll()
        {
            //脱离状态
            //结果处于游离态而非持久态
            return db.Set<T>().Where(m =>! m.IsRemove ).AsNoTracking();
        }

        public T GetOne(Guid id)
        {
            return GetAll().First(m => m.Id == id);
        }

        public void Remove(Guid id)
        {
            var t = new T() { Id=id};
            db.Entry(t).State = EntityState.Unchanged;
            t.IsRemove = true;
            db.SaveChanges();
        }
    }
}
