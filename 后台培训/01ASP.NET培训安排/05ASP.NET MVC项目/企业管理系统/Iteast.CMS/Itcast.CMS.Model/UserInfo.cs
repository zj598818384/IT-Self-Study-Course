using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itcast.CMS.Model
{
     public class UserInfo
    {
        public int id { get; set; }
        public string username { get; set; }
        public string userpwd { get; set; }
        public string usermail { get; set; }
        public DateTime regtime { get; set; }
    }
}
