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
using StudentSys.WebApi.Models.Auth;

namespace StudentSys.WebApi.Filters
{
    public class MyAuthAttribute : Attribute, IAuthorizationFilter
    {
        public bool AllowMultiple {get;}

        public async Task<HttpResponseMessage> ExecuteAuthorizationFilterAsync(HttpActionContext actionContext, CancellationToken cancellationToken, Func<Task<HttpResponseMessage>> continuation)
        {
            //对整个控制器都需要过滤
            //如果控制器中有AllowAnonymous则跳过过滤
            //当某个特定的action加入了如果控制器中有AllowAnonymous则跳过过滤特定时跳过检查
            if (actionContext.ActionDescriptor.GetCustomAttributes<AllowAnonymousAttribute>(true).Count>0)
            {
                return await continuation();
            }

            //获取request==>headers==>token
            IEnumerable<string> headers;
            //获取headers里面的token，判断是否获取到
            if (actionContext.Request.Headers.TryGetValues(name: "token", values: out headers))
            {
                //如果获取到了headers里的token
                //token解密jwt   解密返回键值对
                //获取账号
                //接口数据
                string loginName = JwtTools.Decode(jwtStr: headers.First())["LoginName"].ToString();
                int userID = (int)JwtTools.Decode(jwtStr: headers.First())["UserId"];
                //存入User.Identity.Name
                //强制转换为ApiController得到user 
                (actionContext.ControllerContext.Controller as ApiController).User = new ApplicationUser(loginName, userID);
                //异步方法await
                return await continuation();
            }
            //返回错误码
            return new HttpResponseMessage(HttpStatusCode.Unauthorized);
        }
    }
}