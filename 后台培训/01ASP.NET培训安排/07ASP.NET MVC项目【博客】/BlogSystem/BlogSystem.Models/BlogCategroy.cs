using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSystem.Models
{
    public class BlogCategroy:BaseEntity
    {
        //分类名称
        public string CategoryName { get; set; }

        //用户外键
        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        //用户
        public User User { get; set; }
    }
}
