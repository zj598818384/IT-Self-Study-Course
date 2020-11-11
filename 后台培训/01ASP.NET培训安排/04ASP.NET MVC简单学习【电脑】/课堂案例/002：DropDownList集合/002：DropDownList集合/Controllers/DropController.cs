using _002_DropDownList集合.Models;//引入命名空间
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _002_DropDownList集合.Controllers
{
    public class DropController : Controller
    {

        // GET: Drop
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]//如果出现方法名相同，就更改提交方式
        public string HtmlTest(string sanha)
        {
            return "三哈";
        }


        [HttpGet]
        public ActionResult HtmlTest()
        {
            //构造SelectListItem集合
            List<SelectListItem> list = new List<SelectListItem>();
            list.Add(new SelectListItem()
            {
                //Selected是否默认选中
                Selected = false,
                Text="123",
                Value="1"
            });
            list.Add(new SelectListItem()
            {
                //Selected是否默认选中
                Selected = false,
                Text = "124",
                Value = "2"
            });
            list.Add(new SelectListItem()
            {
                //Selected是否默认选中
                Selected = true,
                Text = "125",
                Value = "3"
            });
            list.Add(new SelectListItem()
            {
                //Selected是否默认选中
                Selected = false,
                Text = "126",
                Value = "4"
            });
            //传值到前台
            ViewData["ddlist"] = list;
            return View("HtmlTest");

            Person p1 = new Person();
            p1.Text("12");
            //在点方法的时候带有v的图标表示虚方法
            //带有下箭头的表示扩展方法，也就是说这个方法不是定义在原始类文件中的，是被扩展进去的，这种方法就叫扩展方法
            //在不能改变源代码的时候，但是又要改变代码，则使用扩展方法

            //传过去的类型必须以Person类中的类型一一对应
            ViewData.Model = new Person()
            {
                Age = 10,
                QQ = "123"
            };
        }

        //按照路由规则进行参数的传递
        //第一种方式：request["键"]的方式接受参数
        public ActionResult Add()
        {
            int id = int.Parse(Request["id"]);
            ViewBag.Id = id;
            return View();
        }

        //第二种方式：自动装配
        //如果要实现行为的重载，要满足两个条件：1、参 数不同，2、请求类型不同
        [HttpPost]
        public ActionResult Add(int id)
        {
            //Id2：object类型
            ViewBag.Id2 = id;
            return View();
        }
        
        public ActionResult AddPerson()
        {
            return View();
        }

        [HttpPost]
        //添加
        //自动装配：可以完成自定义类型的参数的自动装配
        //person=new person();
        //person.Age=request["Age"];
        public ActionResult AddPerson(Person person)
        {
            ViewData.Model = person;
            return View("AddPerson1");
        }

        public ActionResult Say()
        {
            //输出原样字符串
            return Content("abc");
        }

        public ActionResult RedirectTest()
        {
            //进行视图页面之间的跳转
            return Redirect(Url.Action("Index","home"));
        }

        public ActionResult JsonTest()
        {
            Person p = new Person()
            {
                Age = 10,
                QQ = "123"
            };
            return Json(p, JsonRequestBehavior.AllowGet);
        }
    }
}