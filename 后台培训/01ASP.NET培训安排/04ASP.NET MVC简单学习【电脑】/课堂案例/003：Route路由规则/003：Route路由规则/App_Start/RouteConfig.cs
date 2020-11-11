using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _003_Route路由规则
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //自定义路由规则的要求：小范围写在前，大范围写在后
            routes.MapRoute(
                name: "NewsShow",
                url: "{year}-{month}-{day}-{id}",
                defaults: new
                {
                    Controller = "News",
                    Action = "Show"
                },
                constraints:new
                {
                    year="^\\d{4}$",
                    month="^\\d{1,2}$",
                    day="^\\d{1,2}$"
                }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
