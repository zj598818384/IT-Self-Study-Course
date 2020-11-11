using _001_webapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _001_webapi.Controllers
{
    //路由前缀
    [RoutePrefix(prefix:"api/user")]
    public class UserController : ApiController
    {
        //请求方式，因为没有使用restful风格，需要自己制定用哪种类型来处理
        [HttpPost]
        //路由名称routename
        [Route(template:"Login")]
        //接受传过来的账号密码
        public string Login(LoginViewModel model)
        {
            return "ok";
        }

        [Route(template:"Message")]
        public IHttpActionResult GetMessage()
        {
            //return Ok();
            //只有OK可以带数据返回
            return Ok(new Student {
                id=80,
                name="taotao"
            });//代表成功返回200
               //return NotFound();//返回404，未找到
               // return InternalServerError(new Exception(message:"你错了"));//500 内部服务器错误


            //为什么在一个方法里面可以返回多个不同的结果？
            //因为IHttpActionResult是一个接口，而接口实现类，其中里面的四种返回结果都实现了接口类，所以可以返回这四种
        }
    }
}
