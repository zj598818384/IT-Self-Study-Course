using _006_Web_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _006_Web_API.Controllers
{
    public class UserInfoController : ApiController
    {
        // GET: api/UserInfo
        //使用Method=Get的方式请求url=api/userinfo，则这个方法会被调用执行
        //查询所有信息
        public IEnumerable<UserInfo> Get()
        {
            List<UserInfo> list = new List<UserInfo>();
            list.Add(new UserInfo()
            {
                Id = 1,
                Name = "tt"
            });
            list.Add(new UserInfo()
            {
                Id = 2,
                Name = "TT"
            });
            list.Add(new UserInfo()
            {
                Id = 3,
                Name = "ST"
            });
            return list;
        }

        // GET: api/UserInfo/5
        //查询单条信息
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/UserInfo
        //增加
        //这些方法是可以进行更改的
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/UserInfo/5
        //修改
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/UserInfo/5
        //删除
        public void Delete(int id)
        {
        }
    }
}
