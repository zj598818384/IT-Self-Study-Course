using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentSys.Model;
using System.Data.Entity;

namespace StudentSys.Dal
{
    public class SubjectService : BaseService<Subject>
    {
        public SubjectService() : base(new StudentContext())
        {
        }

        //修改班级名
        public async Task EditName(Guid id,string name)
        {
            var sub = new Subject()
            {
                Id = id
            };
            _db.Entry(sub).State = EntityState.Unchanged;
            sub.Name = name;
            await SaveAsync();
        }
    }
}
