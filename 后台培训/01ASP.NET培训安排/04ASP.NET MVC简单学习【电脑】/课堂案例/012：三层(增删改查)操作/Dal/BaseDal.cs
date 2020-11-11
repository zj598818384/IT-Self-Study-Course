using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    //泛型
    public abstract partial class BaseDal<T>
        where T:class
    {
        DbContext dbContext = new MyContext();

        //查询多条
        public IQueryable<T> GetList(int pageSize, int pageIndex)
        {
            return dbContext.Set<T>()
                .OrderByDescending(GetKey())
                .Skip((pageIndex - 0 * pageSize))
                .Take(pageSize);
        }

        //查询单条
        public T GetById(int id)
        {
            return dbContext.Set<T>().Where(GetByIdKey(id)).FirstOrDefault();
        }

        //增加
        public int Add(T states)
        {
            dbContext.Set<T>().Add(states);
            return dbContext.SaveChanges();
        }

        //修改
        public int Edit(T states)
        {
            //先加进去
            dbContext.Set<T>().Attach(states);
            //将状态修改为修改状态
            dbContext.Entry(states).State = EntityState.Modified;
            return dbContext.SaveChanges();
        }

        //删除
        public int Remove(int id)
        {
            var states = GetById(id);
            dbContext.Set<T>().Remove(states);
            return dbContext.SaveChanges();
        }

        public abstract Expression<Func<T, int>> GetKey();
        public abstract Expression<Func<T, bool>> GetByIdKey(int id);

        public int GetCount()
        {
            return dbContext.Set<T>().Count();
        }
    }
}
