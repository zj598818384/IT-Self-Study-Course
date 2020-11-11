using StudentSys.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.Dal
{
    public class StudentService : BaseService<Student>
    {
        public StudentService() : base(new StudentContext())
        {
        }

        //修改摸个学生的班级
        public async Task ChangeClass(Guid stuId,Guid clsId)
        {
            Student stu = new Student() { Id = stuId };
            _db.Entry(stu).State = EntityState.Unchanged;
            stu.ClassId = clsId;
            await SaveAsync(false);
        }
    }
}
