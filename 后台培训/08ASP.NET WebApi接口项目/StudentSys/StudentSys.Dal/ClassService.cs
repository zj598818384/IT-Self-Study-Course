using StudentSys.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.Dal
{
    public class ClassService : BaseService<Class>
    {
        public ClassService() : base(new StudentContext())
        {
        }

        //修改班级名称
        public async Task ChangeName(Guid id,string clsname)
        {
            var cls = new Class() { Id = id };
            _db.Entry(cls).State = EntityState.Unchanged;
            //对一行数据进行修改，进行独立修改
            cls.Name = clsname;
            await SaveAsync();
        }

        //班级升级
        public async Task ChangeGrade(Guid id, Guid gradeId)
        {
            var cls = new Class() { Id = id };
            _db.Entry(cls).State = EntityState.Unchanged;
            //对一行数据进行修改，进行独立修改
            cls.GradeId = gradeId;
            await SaveAsync();
        }

        //班级毕业
        public async Task ClassGraduation(Guid id)
        {
            var cls = new Class() { Id = id };
            // EntityState.Unchanged：EF框架的状态，自对象加载到上下文中后，此对象尚未经过修改
            _db.Entry(cls).State = EntityState.Unchanged;
            cls.IsGraduation = true;
            await SaveAsync();
        }
    }
}
