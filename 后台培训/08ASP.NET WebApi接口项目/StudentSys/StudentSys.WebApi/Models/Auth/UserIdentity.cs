using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace StudentSys.WebApi.Models.Auth
{
    public class UserIdentity: IIdentity
    {
        //给Name赋值
        public UserIdentity(string name, int id)
        {
            Name = name;
        }

        //只读get，内部可以写
        public string Name { get; }
        //Guid唯一标识符
        public int Id { get; set; }
        public string AuthenticationType { get; }
        public bool IsAuthenticated { get; }
    }

    //继承User中的接口
    public class ApplicationUser : IPrincipal
    {
        //给identity赋值
        public ApplicationUser(string name, int id)
        {
            //传入name给identity
            //UserIdentity实现了IIdentity接口
            Identity = new UserIdentity(name, id);
        }

        public IIdentity Identity { get; }

        public bool IsInRole(string role)
        {
            throw new NotImplementedException();
        }
    }
}