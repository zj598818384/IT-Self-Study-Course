using _006_Web_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace t1_Client.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //客户端对象的创建与初始化
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //指定get操作
            HttpResponseMessage response=client.GetAsync("http://localhost:57073/api/userinfo").Result;
            //var list=response.Content.ReadAsByteArrayAsync<List<UserInfo>>().Result;
            //ViewData.Model = list;

            return View();
        }
    }
}