using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentSys.Model;

namespace StudentSys.Dal
{
    public class EmployeeService : BaseService<Employee>
    {
        public EmployeeService() : base(new StudentContext())
        {
        }
    }
}
