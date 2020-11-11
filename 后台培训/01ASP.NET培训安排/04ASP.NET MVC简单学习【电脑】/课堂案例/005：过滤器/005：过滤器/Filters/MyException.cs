using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _005_过滤器.Filters
{
    public class MyException: System.Web.Mvc.HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            //如下代码不可以被删除，所以捕获不到异常
            base.OnException(filterContext);

            //记录日志

            //实现页面跳转
            filterContext.Result = new RedirectResult("/Error/400.html");
        }
    }
}