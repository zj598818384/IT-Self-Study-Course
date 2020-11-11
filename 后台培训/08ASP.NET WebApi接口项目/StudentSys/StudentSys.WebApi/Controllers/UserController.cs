using StudentSys.Bll;
using StudentSys.WebApi.Filters;
using StudentSys.WebApi.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace StudentSys.WebApi.Controllers
{

    [MyAuth]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix(prefix:"api/user")]
    public class UserController : ApiController
    {
        [Route(template:"login")]
        [HttpPost]
        //过滤的过程中自动跳过
        [AllowAnonymous]
        public IHttpActionResult Login(LoginViewModel model)
        {
            Guid guid;

            if (ModelState.IsValid)
            {
                if (EmployeeManager.Login(model.LoginName, model.Password, out guid))
                {
                    Guid aa = guid;

                    return this.SendData(JwtTools.Encoder(new Dictionary<string, object>()
                    {
                        { "username",model.LoginName},
                        { "userid",guid}
                    }));
                }
                else
                {
                    return this.ErrorData("账号密码有误");
                }
            }
            return this.ErrorData("您输入的数据不合法");
            
        }

        [HttpPost,AllowAnonymous,Route(template:"Create")]
        public async Task<IHttpActionResult> CreateUser(CreateEmloyeeViewModel model)
        {
            if (ModelState.IsValid)
            {
                await EmployeeManager.CreateEmployee(model.LoginName, model.Password, model.TypeId, model.Phone);
                return this.SendData("");
            }
            return this.ErrorData("您输入的数据有误");
        }
    }
}
