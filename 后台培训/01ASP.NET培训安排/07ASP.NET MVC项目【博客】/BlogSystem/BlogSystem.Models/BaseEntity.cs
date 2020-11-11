using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSystem.Models
{
    //基类
    public class BaseEntity
    {
        //编号
        public Guid Id { get; set; } = Guid.NewGuid();
        //创建时间
        public DateTime CreateTime { get; set; } = DateTime.Now;
        //是否被删除(伪删除)
        public bool IsRemove { get; set; }
    }
}
