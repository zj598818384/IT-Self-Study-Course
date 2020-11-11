using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public partial class StatesBll:BaseBll<States>
    {
        public override BaseDal<States> GetDal()
        {
            return new StatesDal();
        }
    }
}
