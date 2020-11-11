using Itcast.CMS.DAL;
using Itcast.CMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itcast.CMS.BLL
{
    public class UserInfoService
    {
        UserInfoDal UserInfoDal = new UserInfoDal();
        public UserInfo GetUserInfo(string username,string userpwd)
        {
            return UserInfoDal.GetUserInfo(username, userpwd);
        }
    }
}
