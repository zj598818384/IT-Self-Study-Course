using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _001_webapi.Controllers
{
    //api中的
    [Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values 行为action
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        //FromBody：加上这个的数据只能从data里面获取
        //加上这个东西数据只能从主体过来，不能通过地址栏QueryString进行参数传递
        //从body过来的走对象，不从body过来写单个参数
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
