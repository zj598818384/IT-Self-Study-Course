using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _003_viewmodel与身份校验.Models
{
    //新建视图模型
    public class LoginViewModel
    {
        //ef
        [Required]//非空
        [EmailAddress]//校验邮箱地址
        [StringLength(maximumLength:100,MinimumLength =5)]//长度校验，最长100，最短5
        public string LoginName { get; set; }

        [Required]//非空
        [StringLength(maximumLength: 30, MinimumLength = 6)]//长度校验，最长100，最短5
        public string LoginPwd { get; set; }
    }
}