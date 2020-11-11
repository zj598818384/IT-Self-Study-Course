using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.Model
{
    //班级表
    //继承BaseEntity
    public class Class:BaseEntity
    {
        [Required]
        public string Name { get; set; }
        //是否毕业
        public bool IsGraduation { get; set; }

        [ForeignKey(nameof(Grade))]
        public Guid GradeId { get; set; }
        public Grade Grade { get; set; }

    }
}
