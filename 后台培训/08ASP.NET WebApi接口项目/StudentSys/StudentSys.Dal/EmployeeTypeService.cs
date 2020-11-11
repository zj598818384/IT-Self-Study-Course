using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentSys.Model;

namespace StudentSys.Dal
{
    public class EmployeeTypeService : BaseService<Employee>
    {
        public EmployeeTypeService() : base(new StudentContext())
        {
        }

        public Task CreateAsync(EmployeeType employeeType)
        {
            throw new NotImplementedException();
        }
    }
}
