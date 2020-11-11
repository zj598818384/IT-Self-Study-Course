using Bll;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class UserInfoController : Controller
    {
        StatesBll statesbll = new StatesBll();
        UserInfoBll userinfobll = new UserInfoBll();
        // GET: UserInfo
        public ActionResult Index()
        {
            //ViewData.Model= userinfobll.GetList(10, 0);
            return View();
        }

        //分页
        public ActionResult LoadList(int pageSize, int pageIndex)
        {
            var list = userinfobll.
                GetList(pageSize, pageIndex)
                .Select(u => new
                {
                    Id = u.id,
                    cid = u.CustomerID,
                    pwd = u.CustomerPWD,
                    type = u.CustomerType,
                    score = u.Score,
                    stateid = u.States.StatesName
                })
                .ToList();
            int rowsCount = userinfobll.GetCount();
            int pageCount = Convert.ToInt32(Math.Ceiling(rowsCount * 1.0 / pageSize));

            StringBuilder pager = new StringBuilder();
            if (pageIndex == 1)
            {
                pager.Append("首页    上一页");
            }
            else
            {
                pager.Append("<a href='javascript:GoPage(1)'>首页</a>$nbsp;<a href='javascript:GoPage(" + (pageIndex - 1) + ")'>上一页</a>");
            }
            if (pageIndex == pageCount)
            {
                 pager.Append("下一页   尾页");
            }
            else
            {
                pager.Append("<a href='javascript:GoPage(" + (pageIndex + 1) + ")'>下一页</a>$nbsp;<a href='javascript:GoPage(" + pageCount + ")'>尾页</a>");
            }

            //生成匿名对象，然后进行序列化
            var temp = new
            {
                list = list,
                pager = pager.ToString()
             };

            //进行序列化
            return Json(temp,JsonRequestBehavior.AllowGet);
        }

        public ActionResult Add()
        {
            //查询
            List<SelectListItem> list = new List<SelectListItem>();
            var list1 = statesbll.GetList(100, 0);
            foreach (var item in list1)
            {
                list.Add(new SelectListItem()
                {
                    Text = item.StatesName,
                    Value = item.id.ToString()
                });
            }
            ViewBag.TypeList = list;
            return View();
        }

        [HttpPost]
        public ActionResult Add(UserInfo userinfo)
        {
            userinfobll.Add(userinfo);
            return Redirect(Url.Action("Index"));
        }

        public ActionResult Edit(int id)
        {
            ViewBag.Id = id;
            return View();
        }
    }
}