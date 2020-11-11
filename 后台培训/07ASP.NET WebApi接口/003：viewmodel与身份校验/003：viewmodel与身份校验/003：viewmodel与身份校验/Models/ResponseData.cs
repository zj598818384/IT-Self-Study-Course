using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _003_viewmodel与身份校验.Models
{
    public class ResponseData
    {
        //默认200，代表正常
        public int Code { get; set; } = 200;
        //给数据
        public object Data { get; set; }
        //错误信息
        public string ErrorMessage { get; set; }
    }
}