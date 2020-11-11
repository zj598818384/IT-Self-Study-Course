using StudentSys.Bll;
using StudentSys.WebApi.Filters;
using StudentSys.WebApi.Models.SysSetting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace StudentSys.WebApi.Controllers
{
    [MyAuth]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix(prefix: "api/setting")]
    public class SysSettingController : ApiController
    {
        [HttpPost]
        [AllowAnonymous]
        [Route(template:"createEmpType")]
        public async Task<IHttpActionResult> CreateEmpType(CreateEmployeeTypeViewModel model)
        {
            if (ModelState.IsValid)
            {
                await SystemManager.CreateEmployeeType(model.Name);
                return this.SendData("");
            }

            return this.ErrorData("数据有误");
        }
    }
}
