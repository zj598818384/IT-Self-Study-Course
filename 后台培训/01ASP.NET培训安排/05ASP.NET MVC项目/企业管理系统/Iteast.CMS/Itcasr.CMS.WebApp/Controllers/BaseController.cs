using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Itcasr.CMS.WebApp.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        //过滤器中的方法：actionFilter
        //当执行控制器方法之前先执行该方法，常用于判断session中是否有值
        //过滤器是一个受保护的成员
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (Session["userInfo"] == null)
            {
                filterContext.HttpContext.Response.Redirect("/Login/Index");
            }
            //base用于从派生类中访问基类的成员：
            //1.调用基类上已被其他方法重写的方法。
            //2.指定创建派生类实例时应调用的基类构造函数
            //基类访问只能在构造函数、实例方法或实例属性访问器中进行。
            //从静态方法中使用base关键字是错误的
            base.OnActionExecuting(filterContext);
        }
    }
}