using BlogSystem.IDal;
using BlogSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSystem.Dal
{
    public class BaseService<T> : IBaseService<T> where T : BaseEntity,new()
    {
        //传入上下文
        private readonly BlogDbContext _db;

        //常量const是直接赋值
        //而只读readonly需要在构造函数中赋值

        public BaseService(Models.BlogDbContext db)
        {
            _db = db;
        }
        public async Task CreateAsync(T model, bool saved = true)
        {
            _db.Set<T>().Add(model);
            if (saved)
            {
                await _db.SaveChangesAsync();
            }
        }

        public async Task EditAsync(T model, bool saved = true)
        {
            //关闭判断
            _db.Configuration.ValidateOnSaveEnabled = false;
            //修改状态为modified
            _db.Entry(model).State = EntityState.Modified;
            if (saved)
            {
                await _db.SaveChangesAsync();
                _db.Configuration.ValidateOnSaveEnabled = true;
            }
        }

        //没有得到最终结果
        //返回所有未被删除的数据(没有真的执行)
        public IQueryable<T> GetAllAsync()
        {
            return _db.Set<T>().Where(m => !m.IsRemove).AsNoTracking();
        }

        public IQueryable<T> GetAllByPageAsync(int pageSize = 10, int pageIndex = 0)
        {
            //Take：连续获取
            return GetAllAsync().Skip(pageSize * pageIndex).Take(pageSize);
        }

        public  IQueryable<T> GetAllByPageOrderAsync(int pageSize = 10, int pageIndex = 0, bool asc = true)
        {
            return GetAllOrderAsync(asc).Skip(pageSize * pageIndex).Take(pageSize);
        }

        public IQueryable<T> GetAllOrderAsync(bool asc = false)
        {
            var datas = GetAllAsync();
            if (asc)
            {
                datas = datas.OrderBy(m => m.CreateTime);
            }
            else
            {
                datas = datas.OrderByDescending(m => m.CreateTime);
            }
            return datas;
        }

        public async Task<T> GetOneByIdAsync(Guid id)
        {
             return await GetAllAsync().FirstAsync(predicate: m => m.Id == id);
        }

        public async Task RemoveAsync(Guid id, bool saved = true)
        {
            _db.Configuration.ValidateOnSaveEnabled = false;
            var t = new T() { Id = id };
            t.IsRemove = true;
            if (saved)
            {
                await _db.SaveChangesAsync();
                _db.Configuration.ValidateOnSaveEnabled = true;
            }
        }

        public async Task RemoveAsync(T model, bool saved = true)
        {
            await RemoveAsync(model.Id, saved);
        }

        public async Task Save()
        {
            await _db.SaveChangesAsync();
            _db.Configuration.ValidateOnSaveEnabled = true;
        }

        //销毁：用一次删一次
        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
