using _003_viewmodel与身份校验.Filters;
using _003_viewmodel与身份校验.Models.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _003_viewmodel与身份校验.Controllers
{

    //1、通过特性的方式进行JWT校验
    //(1)特性与过滤器 auth——只有特性可以写在方法，类的上面

    //2、在校验过程中读取到JWT中的账号信息并存入User.Identity.Name
    //3、可以在任意action方法中读取User.Indentity.Name属性里的数据

         
    [RoutePrefix(prefix:"api/Users")]
    public class UsersController : ApiController
    {

        [Route(template:"login")]
        //身份过滤
        public IHttpActionResult Login(Models.LoginViewModel model)
        {

            //传递上来的数据通过了校验
            //model状态的校验
            if (ModelState.IsValid)
            {
                //表示成功，并传入data(jwt)
                return Ok(new Models.ResponseData()
                {
                    //加密方法
                    Data=JwtTools.Encoder(new Dictionary<string, object>() {
                        { "LoginName",model.LoginName},
                        { "userID",1}//id
                    })
                });
            }
            //传递上来的数据未通过校验
            else
            {
                //表示返回错误信息，错误码为500，提示错误信息
                return Ok(new Models.ResponseData() { Code = 500, ErrorMessage = "账号密码错误" });
            }

            //使用三元表达式
            //return Ok(ModelState.IsValid ? new Models.ResponseData() : new Models.ResponseData() { Code = 500, ErrorMessage = "账号密码有误" });
        }

        [MyAuth]
        [HttpGet]
        [Route(template:"getuser")]
        public IHttpActionResult GetUserInfo()
        {
            //获取账号，返回账号
            //推荐使用id操作
            //不然需要先去数据库获取id，然后在操作，加重了数据库的操作
            return Ok(new Models.ResponseData() { Data=((UserIdentity)User.Identity).Id});
        }
    }
}
