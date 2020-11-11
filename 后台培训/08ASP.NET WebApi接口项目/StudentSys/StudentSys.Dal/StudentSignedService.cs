using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentSys.Model;
using System.Data.Entity;

namespace StudentSys.Dal
{
    public class StudentSignedService : BaseService<StudentSigned>
    {
        public StudentSignedService() : base(new StudentContext())
        {
        }

        //修改签到信息
        public async Task ChangeSignedType(Guid id,string typeName)
        {
            var sign = new StudentSigned()
            {
                Id = id
            };
            _db.Entry(sign).State = EntityState.Unchanged;
            sign.SignedType = typeName;
            await SaveAsync(false);
        }

        //签退信息
        public async Task Signout(Guid[] signIds,DateTime? outTime=null)
        {
            if (outTime==null)
            {
                outTime = DateTime.Now;
            }
            foreach (var signId in signIds)
            {
                var sign = new StudentSigned()
                {
                    Id = signId
                };
                _db.Entry(sign).State = EntityState.Unchanged;
                sign.OutTime = outTime;
            }

            await SaveAsync(false);
        }
    }
}
