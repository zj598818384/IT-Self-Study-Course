using BlogSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSystem.IDal
{
    public interface IBaseService<T>:IDisposable where T:BaseEntity
    {
        //异步
        //创建
        //执行这些方法会进行自动保存
        Task CreateAsync(T model,bool saved=true);
        //修改
        Task EditAsync(T model,bool saved= true);
        //删除一条
        Task RemoveAsync(Guid id, bool saved = true);
        //删除多条
        Task RemoveAsync(T model, bool saved = true);
        //保存
        Task Save();
        //查询一条
        Task<T> GetOneByIdAsync(Guid id);
        //查询多条
        IQueryable<T> GetAllAsync();
        //分页
        IQueryable<T> GetAllByPageAsync(int pageSize = 10, int pageIndex = 0);
        //按所有排序
        IQueryable<T> GetAllOrderAsync(bool asc = false);
        //按分页排序
        IQueryable<T> GetAllByPageOrderAsync(int pageSize = 10, int PageIndex = 0, bool asc = true);

    }
}
