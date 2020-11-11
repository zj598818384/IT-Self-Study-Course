using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentSys.Model;

namespace StudentSys.Dal
{
    public class StudentDocService : BaseService<StudentDoc>
    {
        public StudentDocService() : base(new StudentContext())
        {
        }
    }
}
