using Itcast.CMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Itcast.CMS.DAL
{
    public class UserInfoDal
    {
        //用来获取数据库中的用户名和密码
        public UserInfo GetUserInfo(string username,string userpwd)
        {
            string sql = "select * from T_UserInfo where UserName=@username and UserPwd=@userpwd";
            SqlParameter[] pars = {
                new SqlParameter("@username", SqlDbType.NVarChar, 32),
                new SqlParameter("@userpwd", SqlDbType.NVarChar, 32)};
            pars[0].Value = username;
            pars[1].Value = userpwd;

            //调用sqlhelper执行
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            UserInfo userInfo = null;
            if (da.Rows.Count>0)
            {
                userInfo = new UserInfo();
                LoadEntity(userInfo, da.Rows[0]);
            }
            return userInfo;
        }

        public void LoadEntity(UserInfo userInfo,DataRow row)
        {
            userInfo.id = Convert.ToInt32(row["id"]);
            userInfo.username = row["username"] != DBNull.Value ? row["username"].ToString() : string.Empty;
            userInfo.userpwd = row["userpwd"] != DBNull.Value ? row["userpwd"].ToString() : string.Empty;
        }
    }
}
