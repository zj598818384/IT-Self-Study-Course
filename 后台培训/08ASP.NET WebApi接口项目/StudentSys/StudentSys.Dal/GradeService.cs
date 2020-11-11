using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentSys.Model;
using System.Data.Entity;

namespace StudentSys.Dal
{
    public class GradeService : BaseService<Grade>
    {
        public GradeService() : base(new StudentContext())
        {
        }

        public async Task ChangeOrder(Guid id,int order,bool isSaved=true)
        {
            var grade = new Grade() { Id = id };
            _db.Entry(grade).State = EntityState.Unchanged;
            if (isSaved)
            {
                await SaveAsync();
            }
        }

        //修改年级名
        public async Task ChangeName(Guid id,string name)
        {
            var grade = new Grade() { Id = id };
            _db.Entry(grade).State = EntityState.Unchanged;
            grade.Name = name;
            await SaveAsync();
        }
    }
}
