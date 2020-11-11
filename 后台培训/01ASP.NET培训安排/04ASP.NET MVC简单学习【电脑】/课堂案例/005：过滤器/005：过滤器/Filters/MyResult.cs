using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _005_过滤器.Filters
{
    public class MyResult: ActionFilterAttribute
    {
        //结果执行之后
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            filterContext.HttpContext.Response.Write("结果执行后<br>");
        }

        //结果执行之前
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            filterContext.HttpContext.Response.Write("结果执行前<br>");
        }
    }
}