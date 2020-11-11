using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSystem.Models
{
    public class User:BaseEntity
    {
        //邮箱
        [Required,StringLength(maximumLength:40),Column(TypeName ="varchar")]
        public string Email { get; set; }
        //密码
        [Required, StringLength(maximumLength: 30), Column(TypeName = "varchar")]
        public string PassWord { get; set; }
        //头像
        [Required, StringLength(maximumLength: 300), Column(TypeName = "varchar")]
        public string ImagePath { get; set; }
        //粉丝数
        public int FansCount { get; set; }
        //关注数
        public int FocusCount { get; set; }
        //博客名称
        public string SiteName { get; set; }
    }
}
