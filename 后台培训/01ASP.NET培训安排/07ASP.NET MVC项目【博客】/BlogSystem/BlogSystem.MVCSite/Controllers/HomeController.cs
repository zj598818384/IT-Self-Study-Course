using BlogSystem.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BlogSystem.MVCSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //注册

        [HttpGet]
        //防止伪造
        //[ValidateAntiForgeryToken]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(Models.UserViewModels.RegisterViewModel model)
        {
            //加入二次校验
            if (ModelState.IsValid)
            {
                IBLL.IUserManager userManager = new UserManager();
                await userManager.Register(model.Email, model.PassWord);
                return Content("注册成功");
            }
            return View(model);
        }


        //登录
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login(Models.UserViewModels.LoginViewModels model)
        {
            return View();
        }
    }
}