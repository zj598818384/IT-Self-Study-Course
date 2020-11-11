using Itcast.CMS.BLL;
using Itcast.CMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Itcasr.CMS.WebApp.Controllers
{
    public class NewListController : Controller
    {
        NewInfoService NewInfoService = new NewInfoService();
        // GET: NewList
        public ActionResult Index()
        {
            int pageIndex = Request["pageIndex"] != null ? int.Parse(Request["pageIndex"]) : 1;
            int pageSize = 5;
            int pageCount = NewInfoService.GetPageCount(pageSize);
            pageIndex = pageIndex < 1 ? 1 : pageIndex;
            pageIndex = pageIndex > pageCount ? pageCount : pageIndex;
            List<NewInfo> list = NewInfoService.GetPageList(pageIndex, pageSize);
            ViewData["list"] = list;
            ViewBag.pageIndex = pageIndex;
            ViewBag.pageCount = pageCount;
            //分页
            return View();
        }

        //详细信息
        public ActionResult ShowDetail()
        {
            int id = int.Parse(Request["id"]);
            NewInfo newInfo = NewInfoService.GetModel(id);
            ViewData.Model = newInfo;
            return View();
        }
    }
}