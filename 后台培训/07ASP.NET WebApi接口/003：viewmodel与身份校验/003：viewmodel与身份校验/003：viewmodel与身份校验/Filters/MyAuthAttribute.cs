using _003_viewmodel与身份校验.Models.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace _003_viewmodel与身份校验.Filters
{
    //IAuthenticationFilter：过滤器 特性
    public class MyAuthAttribute : Attribute, IAuthorizationFilter
    {
        public bool AllowMultiple
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public async Task<HttpResponseMessage> ExecuteAuthorizationFilterAsync(HttpActionContext actionContext, CancellationToken cancellationToken, Func<Task<HttpResponseMessage>> continuation)
        {
            //获取request——headers——token
            IEnumerable<string> headers;//空数组
            //获取headers里面的token，判断是否获取到
            if (actionContext.Request.Headers.TryGetValues(name: "token", values: out headers))
            {
                //如果获取到了headers里的token
                //token解密jwt   解密返回键值对
                //获取账号
                //接口数据
                string loginName = JwtTools.Decode(jwtStr: headers.First())["LoginName"].ToString();
                int userID =(int)JwtTools.Decode(jwtStr: headers.First())["UserId"];
                //存入User.Identity.Name
                //强制转换为ApiController得到user 
                (actionContext.ControllerContext.Controller as ApiController).User = new ApplicationUser(loginName,userID);
                //异步方法await
                return await continuation();
            }
            //返回错误码
            return new HttpResponseMessage(HttpStatusCode.Unauthorized);
        }
    }
}