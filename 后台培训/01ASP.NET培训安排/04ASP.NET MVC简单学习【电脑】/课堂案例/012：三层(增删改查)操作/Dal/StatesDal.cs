using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public partial class StatesDal:BaseDal<States>
    {
        //面向抽象编程
        //泛型
        public override Expression<Func<States, bool>> GetByIdKey(int id)
        {
            return u => u.id == id;
        }

        public override Expression<Func<States, int>> GetKey()
        {
            return u => u.id;
        }
    }
}
