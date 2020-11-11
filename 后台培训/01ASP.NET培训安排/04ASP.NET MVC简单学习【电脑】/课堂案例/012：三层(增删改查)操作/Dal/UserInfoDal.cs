using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public partial class UserInfoDal:BaseDal<UserInfo>
    {
        //重写方法
        public override Expression<Func<UserInfo, int>> GetKey()
        {
            return u => u.id;
        }

        public override Expression<Func<UserInfo, bool>> GetByIdKey(int id)
        {
            return u => u.id == id;
        }
    }
}
