using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.Model
{
    //系统设置表
    public class SysSetting:BaseEntity
    {
        public int JobScore { get; set; }
        public int CompleteScore { get; set; }
        public int ExamScore { get; set; }
        public int TriggerScore { get; set; }
    }
}
