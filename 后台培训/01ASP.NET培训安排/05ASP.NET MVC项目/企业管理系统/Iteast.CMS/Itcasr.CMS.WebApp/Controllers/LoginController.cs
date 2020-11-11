using Itcast.CMS.BLL;
using Itcast.CMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Itcasr.CMS.WebApp.Controllers
{
    public class LoginController : Controller
    {
        //约定大于配置
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UserLogin()
        {
            //验证用户名和密码
            //获取用户输入的用户名和密码
            string username = Request["name"];
            string userpwd = Request["pwd"];
            UserInfoService UserInfoService = new UserInfoService();
            UserInfo userInfo= UserInfoService.GetUserInfo(username, userpwd);
            if (userInfo != null)
            {
                //保存信息
                Session["userInfo"] = userInfo;
                return RedirectToAction("../Home/index");
            }
            else
            {
                return Content("<script>alert('用户名或密码输入错误');window.location.href = ' Index';</script>");
            }
        }
    }
}