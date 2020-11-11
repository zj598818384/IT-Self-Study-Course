using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentSys.WebApi.Models.User
{
    public class CreateEmloyeeViewModel
    {
        public string LoginName { get; set; }
        public string  Password { get; set; }
        public Guid TypeId { get; set; }
        public string  Phone { get; set; }
    }
}