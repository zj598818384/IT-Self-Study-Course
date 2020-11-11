using Itcast.CMS.BLL;
using Itcast.CMS.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Itcasr.CMS.WebApp.Controllers
{
    //让后台控制器继承自过滤器控制器
    public class AdminNewListController : BaseController// Controller
    {
        // GET: AdminNewList
        NewInfoService NewInfoService = new NewInfoService();
        //分页列表
        public ActionResult Index()
        {
            int pageIndex = Request["pageIndex"] != null ? int.Parse(Request["pageIndex"]) : 1;
            int pageSize = 5;
            int pageCount = NewInfoService.GetPageCount(pageSize);
            pageIndex = pageIndex < 1 ? 1 : pageIndex;
            pageIndex = pageIndex > pageCount ? pageCount : pageIndex;
            //获取分页的数据
            List<NewInfo> list = NewInfoService.GetPageList(pageIndex, pageSize);
            ViewData["list"] = list;
            ViewData["pageIndex"] = pageIndex;
            ViewData["pageCount"] = pageCount;
            return View();
        }

        //获取详细记录
        public ActionResult GetNewInfoModel()
        {
            int id = int.Parse(Request["id"]);
            //获取详细信息
            NewInfo newInfo = NewInfoService.GetModel(id);
            //JsonRequestBehavior.AllowGet：含义：如果使用get方式来请求的话，这里会报异常
            return Json(newInfo, JsonRequestBehavior.AllowGet);
        }

        //删除信息
        public ActionResult DeleteNewInfo()
        {
            //接收编号
            int id = int.Parse(Request["id"]);
            //调用业务层
            if (NewInfoService.DeleteInfo(id))
            {
                return Content("ok");
            }
            else
            {
                return Content("no");
            }
        }


        //展示添加信息表单页面
        public ActionResult ShowAddInfo()
        {
            return View();
        }



        
        //文件上传ina
        public ActionResult FileUpload()
        {
            //接收文件的id值，接收文件数据
            HttpPostedFileBase postFile = Request.Files["fileUp"];
            if (postFile==null)
            {
                return Content("no:请选择上传文件");
            }
            else
            {
                //文件名称
                string fileName = Path.GetFileName(postFile.FileName);
                //获取文件类型：获取扩展名
                string fileExt = Path.GetExtension(fileName);
                if (fileExt==".jpg")
                {
                    //新建文件夹，存放不同日期的文件
                    string dir = "/ImagePath/" + DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day + "/";
                    //创建目录
                    //Path.GetDirectoryName(Request.MapPath(dir))：判断目录是否存在，存在则不再创建
                    Directory.CreateDirectory(Path.GetDirectoryName(Request.MapPath(dir)));
                    //对重复的文件夹进行重命名
                    string newfileName = Guid.NewGuid().ToString();
                    //构建完整的路径
                    string fullDir = dir + newfileName + fileExt;
                    //将文件保存在目录下面
                    postFile.SaveAs(Request.MapPath(fullDir));
                    //返回文件路径
                    //var a = Request.QueryString["showImage"];
                    //return Content("<script>" + a + " '.append(< img src = '" + fullDir + "' width = '40px' height = '40px');window.location.href = ' FileUpload';</script>");
                    return Content("ok:" + fullDir);
                }
                else
                {
                    return Content("no:文件格式错误");
                }
            }
        }

        //添加信息
        [ValidateInput(false)]//表示可以接受前面传过来的input标签
        public ActionResult AddNewInfo(NewInfo newInfo)
        {
            newInfo.subdatetime = DateTime.Now;
            //判断是否添加成功
            if (NewInfoService.AddInfo(newInfo))
            {
                return Content("ok");
            }
            else
            {
                return Content("no");
            }
        }


    }
}