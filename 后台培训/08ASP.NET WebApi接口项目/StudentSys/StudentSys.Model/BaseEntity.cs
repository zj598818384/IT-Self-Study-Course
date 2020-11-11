using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.Model
{
    //需要继承的表
    public class BaseEntity
    {
        //guid唯一标识符，不会重复
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime CreateTime { get; set; } = DateTime.Now;
        public bool IsRemoved { get; set; }
    }
}
