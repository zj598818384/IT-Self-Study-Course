using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itcast.CMS.DAL
{
    public class SqlHelper
    {
        //获取数据库连接字符串
        private static readonly string connString = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;

        //查询
        //返回datatype的类型
        public static DataTable GetTable(string sql,CommandType type,params SqlParameter[] pars)
        {
            //连接数据库
            using (SqlConnection conn=new SqlConnection(connString))
            {
                //配置适配器
                using (SqlDataAdapter apter = new SqlDataAdapter(sql,conn))
                {
                    //指定类型
                    apter.SelectCommand.CommandType = type;
                    if (pars!=null)
                    {
                        apter.SelectCommand.Parameters.AddRange(pars);
                    }
                    DataTable da = new DataTable();
                    apter.Fill(da);
                    return da;
                }
            }
        }

        //删改增
        public static int ExecuteNonquery(string sql,CommandType type,params SqlParameter[] pars)
        {
            using (SqlConnection conn=new SqlConnection(connString))
            {
                using (SqlCommand cmd=new SqlCommand(sql,conn))
                {
                    cmd.CommandType = type;
                    if (pars!=null)
                    {
                        cmd.Parameters.AddRange(pars);
                    }
                    conn.Open();
                    //返回受影响的行
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static object ExecuteScalare(string sql,CommandType type,params SqlParameter[] pars)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = type;
                    if (pars != null)
                    {
                        cmd.Parameters.AddRange(pars);
                    }
                    conn.Open();
                    //返回受影响的行
                    return cmd.ExecuteScalar();
                }
            }
        }
    }
}
