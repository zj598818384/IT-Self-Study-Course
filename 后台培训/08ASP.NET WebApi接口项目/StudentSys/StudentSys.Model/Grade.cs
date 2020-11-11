using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.Model
{
    //年级表
    public class Grade:BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public int Order { get; set; }
    }
}
