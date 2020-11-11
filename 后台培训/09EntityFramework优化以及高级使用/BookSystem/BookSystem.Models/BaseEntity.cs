using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSystem.Models
{
    //所有类继承的父类
    //这里面存放所有类都必须拥有的字段
    public class BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime CreateTime { get; set; } = DateTime.Now;
        //是否删除
        public bool IsRemove { get; set; }
    }
}
