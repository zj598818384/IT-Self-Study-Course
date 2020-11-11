using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 精度转换练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //编程实现计算几天（如46天）是几周零几天。
            int days = 46;
            int weeks = 46 / 7;
            int day = 46 % 7;
            Console.WriteLine("{0}天是{1}周零{2}天",days,weeks,day);

            //编程实现107653秒是几天几小时几分钟几秒？
            //60*60一小时的秒数
            //3600*24一天的秒数
            int seconds = 107653;
            int days1 = seconds / 86400;//求得天数
            int secs = seconds % 86400;//求得求完天数后剩余的秒数
            int hours = secs / 3600;//求得小时数
            secs=secs % 3600;//求得小时数后剩余的秒数
            int mins = secs / 60;//求得分钟数
            secs = secs % 60;//求得分钟数后所剩下的秒数
            Console.WriteLine("{0}秒是{1}天{2}小时{3}分钟{4}秒",seconds,days,hours,mins,secs);
        }
    }
}
