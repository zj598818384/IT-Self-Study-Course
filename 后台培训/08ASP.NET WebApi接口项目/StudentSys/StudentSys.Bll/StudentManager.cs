using StudentSys.Dal;
using StudentSys.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.Bll
{
    class StudentManager
    {

        //添加学生
        public static async Task CreateStudent(string name,string sex,DateTime bornDate,Guid? classid=null,string phone=null,string qq=null,string email=null,string imagepath=null)
        {
            using (StudentService stuSvc=new StudentService())
            {
                await stuSvc.CreateAsync(new Student()
                {
                    Name = name,
                    Sex = sex,
                    BornDate = bornDate,
                    ClassId = classid,
                    Email = email,
                    Phone = phone,
                    QQ = qq,
                    ImagePath = imagepath
                });
            }
        }

        //修改学生班级：分配班级
        public static async Task StudentChangeClass(Guid stuId,Guid classId)
        {
            using (StudentService stuSvc=new StudentService())
            {
                await stuSvc.ChangeClass(stuId, classId);
            }
        }


    }
}
