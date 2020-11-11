using StudentSys.Dal;
using StudentSys.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.Bll
{
    public class EmployeeManager
    {
        //登录
        public static bool Login(string mail,string pwd,out Guid userid)
        {
            using (var empSvc=new EmployeeService())
            {
                var emp = empSvc.GetAll(predicate: m => m.Email == mail && m.Password == pwd).FirstOrDefaultAsync();
                emp.Wait();
                if (emp.Result==null)
                {
                    userid = Guid.Empty;
                    return false;
                }
                else
                {
                    userid = emp.Result.Id;
                    return true;
                }
            }
        }

        //创建职工，分配账号
        public static async Task CreateEmployee(string email,string pwd,Guid typeid,string phone = null)
        {
            using (var empSvc=new EmployeeService())
            {
                await empSvc.CreateAsync(new Employee()
                {
                    Email = email,
                    Password = pwd,
                    EmployeeTypeId = typeid,
                    Phone = phone
                });
            }
        }


    }
}
