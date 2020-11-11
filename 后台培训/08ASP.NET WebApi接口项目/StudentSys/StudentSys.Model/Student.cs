using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.Model
{
    //学生表
    public class Student:BaseEntity
    {
        [Required]
        public string  Name { get; set; }
        [Required]
        public string Sex { get; set; }
        public DateTime BornDate { get; set; }
        public string Phone { get; set; }
        public string QQ { get; set; }
        public string Email { get; set; }
        //照片路径
        public string ImagePath { get; set; }

        [ForeignKey(nameof(Class))]//外键
        //值类型允许为空加？号，引用类型允许为空加required
        public Guid? ClassId { get; set; }
        public Class Class { get; set; }
    }
}
