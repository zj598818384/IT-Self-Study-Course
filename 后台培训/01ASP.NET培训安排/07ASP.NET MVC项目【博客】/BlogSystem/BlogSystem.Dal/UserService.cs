using BlogSystem.IDal;
using BlogSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSystem.Dal
{
    public class UserService:BaseService<Models.User>,IUserService
    {
        public UserService():base(new BlogDbContext())
        {

        }
    }
}
