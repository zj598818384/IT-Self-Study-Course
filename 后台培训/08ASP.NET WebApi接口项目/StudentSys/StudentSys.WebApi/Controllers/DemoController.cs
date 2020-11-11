using StudentSys.WebApi.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace StudentSys.WebApi.Controllers
{
    //准备工作
    /*1.ef引用并设置连接串
     * 2.jwt引用
     * 3.attribute特性用来过滤/校验登录的合法性
     * 4.每个控制器都要做跨域处理Cors
     * 5.为action编写ViewModel用来校验提交的数据合法性
     * 6.为返回的结果编写一个ResponseData处理统一返回的数据
     */

    [MyAuth]
    [EnableCors(origins:"*",headers:"*",methods:"*")]
    public class DemoController : ApiController
    {
        //public IHttpActionResult Demo()
        //{
            
        //}
    }
}
