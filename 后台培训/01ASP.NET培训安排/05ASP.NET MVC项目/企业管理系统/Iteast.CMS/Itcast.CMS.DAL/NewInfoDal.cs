using Itcast.CMS.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itcast.CMS.DAL
{
    public class NewInfoDal
    {
        //查询
        public List<NewInfo> GetPageList(int start,int end)
        {
            string sql = "select * from (select row_number() over(order by id) as num,*from T_News) as t where t.num>=@start and t.num<=@end";
            SqlParameter[] pars =
            {
                new SqlParameter("@start",SqlDbType.Int),
                new SqlParameter("@end",SqlDbType.Int)
            };
            pars[0].Value = start;
            pars[1].Value = end;
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            List<NewInfo> list = null;
            if (da.Rows.Count>0)
            {
                list = new List<NewInfo>();
                NewInfo newInfo = null;
                foreach (DataRow row in da.Rows)
                {
                    newInfo = new NewInfo();
                    LoadEntity(row, newInfo);
                    list.Add(newInfo);
                }
            }
            return list;
        }

        private void LoadEntity(DataRow row,NewInfo newInfo)
        {
            newInfo.id = Convert.ToInt32(row["ID"]);
            newInfo.author = row["Author"] != DBNull.Value ? row["Author"].ToString() : string.Empty;
            newInfo.title = row["Title"] != DBNull.Value ? row["Title"].ToString() : string.Empty;
            newInfo.msg = row["Msg"] != DBNull.Value ? row["Msg"].ToString() : string.Empty;
            newInfo.imagepath = row["ImagePath"] != DBNull.Value ? row["ImagePath"].ToString() : string.Empty;
            newInfo.subdatetime = Convert.ToDateTime(row["SubDateTime"]);
        }

        /// <summary>
        /// 获取总的记录数
        /// </summary>
        /// <returns></returns>
        public int GetRecordCount()
        {
            string sql = "select count(*) from T_News";
            return Convert.ToInt32(SqlHelper.ExecuteScalare(sql, CommandType.Text));
        }

        /// <summary>
        /// 获取一条记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public NewInfo GetModel(int id)
        {
            string sql = "select * from T_News where id=@id";
            SqlParameter[] pars =
            {
                new SqlParameter("@id",SqlDbType.Int)
            };
            pars[0].Value = id;
            DataTable da = SqlHelper.GetTable(sql, CommandType.Text, pars);
            NewInfo newInfo = null;
            if (da.Rows.Count>0)
            {
                newInfo = new NewInfo();
                LoadEntity(da.Rows[0], newInfo);
            }
            return newInfo;
        }

        //返回删除所影响的行数
        public int DeleteInfo(int id)
        {
            string sql = "delete from T_News where id=@id";
            //直接赋值
            return SqlHelper.ExecuteNonquery(sql, CommandType.Text, new SqlParameter("@id",id));
            
        }

        //添加一条记录
        public int AddInfo(NewInfo newInfo)
        {
            //插入数据
            string sql = "insert into T_News(Author,Title,Msg,ImagePath,SubDateTime) values(@Author,@Title,@Msg,@ImagePath,@SubDateTime)";
            SqlParameter[] pars =
            {
                new SqlParameter("@Author",SqlDbType.NVarChar,32),
                new SqlParameter("@Title",SqlDbType.NVarChar,32),
                new SqlParameter("@Msg",SqlDbType.NVarChar),
                new SqlParameter("@ImagePath",SqlDbType.NVarChar,100),
                new SqlParameter("@SubDateTime",SqlDbType.DateTime)
            };
            pars[0].Value = newInfo.author;
            pars[1].Value = newInfo.title;
            pars[2].Value = newInfo.msg;
            pars[3].Value = newInfo.imagepath;
            pars[4].Value = newInfo.subdatetime;

            return SqlHelper.ExecuteNonquery(sql, CommandType.Text, pars);
        }
    }
}
