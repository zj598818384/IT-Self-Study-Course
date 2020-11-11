using BookSystem.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSystem.IDAL
{
    //写增删改查
    //T：如果需要对某个表进行增删改查就改成增删改查
    //T的数据必须来自BaseEntity，所以需要进行继承
    public interface IBaseService<T>:IDisposable where T:BaseEntity
    {
        //处理对应的功能
        //添加
        void Add(T t);
        //修改
        void Edit(T t);
        //移除
        void Remove(Guid id);
        //查询一条数据
        T GetOne(Guid id);
        //查询集合：不会立即生成SQL语句，知道最后需要结果的时候，才会统一生成
        IQueryable<T> GetAll();
    }
}
