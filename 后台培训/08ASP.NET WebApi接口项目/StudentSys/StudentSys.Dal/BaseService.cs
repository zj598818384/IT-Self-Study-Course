using StudentSys.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.Dal
{
    //泛型：继承接口 泛型再继承baseentity，进行实例化
    public class BaseService<T> : IDisposable where T:BaseEntity,new()
    {
        //添加属性表示只读，只有继承自BaseEntity才可以使用
        protected readonly StudentContext _db;
        public BaseService(StudentContext db)
        {
            _db = db;
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        //增加    async：异步的
        public async Task CreateAsync(T t,bool saved=true)
        {
            //不是立即保存，而是要保存的时候才一起保存
            _db.Set<T>().Add(t);
            //表示如果saved等于true则执行
            if(saved)
                //表示可以对多条数据进行保存
                await _db.SaveChangesAsync();
        }

        //校验
        public async Task SaveAsync(bool isValid=true)
        {
            if (!isValid)
            {
                //关闭校验
                _db.Configuration.ValidateOnSaveEnabled = false;
                await _db.SaveChangesAsync();
                //保存之后再进行数据库校验
                _db.Configuration.ValidateOnSaveEnabled = true;
                return;
            }
            else
            {
                await _db.SaveChangesAsync();
            }
            
        }

        //修改
        public async Task EditAsync(T t,bool saved=true)
        {
            _db.Entry(t).State = EntityState.Modified;
            if (saved)
            {
                await SaveAsync(isValid: false);
            }
        }

        //删除
        public async Task Remove(Guid id,bool saved=true)
        {
            T t = new T()
            {
                Id = id
            };
            _db.Entry(t).State = EntityState.Unchanged;
            t.IsRemoved = true;
            if (saved)
            {
                await SaveAsync(isValid: false);
            }
        }

        //查
        //查询所有数据
        public IQueryable<T> GetAll()
        {
            return _db.Set<T>().AsNoTracking().Where(m => !m.IsRemoved);
        }

        //扩展，可以自己加条件
        public IQueryable<T> GetAll(Expression<Func<T,bool>> predicate)
        {
            return GetAll().Where(predicate);
        }

        //扩展，可以自己加条件，可升序降序
        public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate,bool asc)
        {
            var data= GetAll().Where(predicate);
            if (asc)
            {
                return data.OrderBy(m => m.CreateTime);
            }
            else
            {
                return data.OrderByDescending(m => m.CreateTime);
            }
        }

        //扩展，可以自己加条件，可分页，可排序
        public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate, bool asc,int pageIndex, int pageSize=10)
        {
             return GetAll(predicate,asc).Skip(pageSize-pageIndex).Take(pageSize);
        }

        //查询一个数据
        public async Task<T> GetOne(Guid id)
        {
            return await GetAll().FirstAsync(predicate: m => m.Id == id);
        }
    }
}
