using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public partial class UserInfoBll:BaseBll<UserInfo>
    {
        public override BaseDal<UserInfo> GetDal()
        {
            return new UserInfoDal();
        }
    }
}
