using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSystem.Models
{
    //粉丝表
    public class Fans:BaseEntity
    {
        //用户编号
        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        public User User { get; set; }
        //关注的用户编号

        [ForeignKey(nameof(FocusUser))]
        public Guid FocusUserId { get; set; }
        public User FocusUser { get; set; }
    }
}
