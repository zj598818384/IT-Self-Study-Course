using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _005_过滤器.Filters
{
    public class MyAction: ActionFilterAttribute
    {
        //行为执行前执行的代码
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.HttpContext.Response.Write("<br>行为执行前执行的代码<br>");
        }

        //行为执行后执行的代码
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            filterContext.HttpContext.Response.Write("行为执行后执行的代码<br>");
        }
    }
}